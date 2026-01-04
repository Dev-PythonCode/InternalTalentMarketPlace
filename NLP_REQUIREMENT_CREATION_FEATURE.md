# NLP-Based Requirement Creation Feature

## Overview
This feature enables AI-powered requirement creation in the Post Requirement page. Users can now describe job requirements in natural language, and the system will automatically parse and populate the form fields.

## Changes Made

### 1. Python API - New Endpoint (`/parse-requirement`)

**File:** `/Users/Dev/Projects/PythonAPI/app.py`

**New Endpoint:** `POST /parse-requirement`

**Purpose:** Parse natural language requirement descriptions and extract structured data including skills, experience, location, and roles.

**Request Format:**
```json
{
  "description": "Need a senior Python developer with 5 years Django experience in Bangalore"
}
```

**Response Format:**
```json
{
  "original_description": "...",
  "extracted": {
    "skills": [
      {"name": "Python", "years": 5, "is_mandatory": true},
      {"name": "Django", "years": 0, "is_mandatory": false}
    ],
    "location": "Bangalore",
    "min_years_experience": 5,
    "experience_context": "overall",
    "roles": ["developer"],
    "seniority": "senior",
    "skill_count": 2,
    "mandatory_count": 1
  }
}
```

**Features:**
- Extracts skills with experience requirements
- Identifies mandatory vs. optional skills
- Detects location information
- Recognizes seniority levels (Senior, Junior, Lead)
- Extracts role types
- Provides overall experience requirements

### 2. C# Blazor - Updated RequirementDialog

**File:** `/Users/Dev/Projects/InternalTalentMarketPlace/TalentMarketPlace/Pages/Shared/RequirementDialog.razor`

**Changes:**

#### UI Changes:
1. **Added AI-Powered Input Section** at the top of the dialog
   - Natural language text area for requirement description
   - AI parse button with loading indicator
   - Styled with the same blue theme as AI Search Results page
   - Example placeholder text to guide users

2. **Visual Feedback**
   - Loading spinner during API call
   - Success/error notifications
   - Clear instructions for users

#### Code Changes:
1. **New Fields:**
   - `_nlpPrompt`: Stores the natural language input
   - `_isParsingPrompt`: Loading state indicator

2. **New Methods:**
   - `ParseRequirementPrompt()`: Calls Python API and handles response
   - `ApplyParsedData()`: Auto-populates form fields with parsed data
   - `DetermineSkillLevel()`: Maps years of experience to proficiency levels

3. **New Data Models:**
   - `RequirementParseResult`: API response wrapper
   - `ExtractedRequirementData`: Parsed requirement information
   - `ExtractedSkill`: Individual skill with experience and priority

#### Auto-Population Logic:
- **Title:** Generated from roles and seniority (e.g., "Senior Developer")
- **Description:** Uses the NLP prompt as initial description
- **Location:** Directly mapped from parsed location
- **Skills:** 
  - Matched against existing skill database (case-insensitive)
  - Years of experience auto-filled
  - Priority set based on mandatory flag
  - Proficiency level determined by years of experience:
    - 5+ years → Expert
    - 3-4 years → Advanced
    - 1-2 years → Intermediate
    - <1 year → Beginner

### 3. Test Script

**File:** `/Users/Dev/Projects/PythonAPI/test_requirement_parser.py`

**Purpose:** Test the new `/parse-requirement` endpoint with various scenarios.

**Test Cases:**
1. Python developer with specific framework experience
2. Java developer with Spring Boot
3. Frontend developer with multiple technologies
4. Cloud architect with mandatory skills

**Usage:**
```bash
cd /Users/Dev/Projects/PythonAPI
python test_requirement_parser.py
```

## How to Use

### For End Users:

1. **Open Post Requirement Page**
   - Navigate to "Post & Manage Requirements"
   - Click "Post New Requirement" button

2. **Use Natural Language Input**
   - At the top of the dialog, enter your requirement description
   - Example: "Need a senior Python developer with 5 years Django experience in Bangalore"
   - Click the brain icon (🧠) button to parse

3. **Review Auto-Populated Fields**
   - Title, Location, and Skills will be automatically filled
   - Review and adjust as needed
   - Add or remove skills manually if required

4. **Submit Requirement**
   - Complete any remaining fields
   - Click "Post Requirement"

### For Developers:

#### Testing the API:

```bash
# Start the Python API
cd /Users/Dev/Projects/PythonAPI
python app.py

# In another terminal, run the test script
python test_requirement_parser.py
```

#### Testing the Full Feature:

1. Ensure Python API is running on port 5000
2. Start the C# Blazor application
3. Navigate to Post Requirement page
4. Try the natural language input feature

## API Integration

### C# Code Calling Python API:

```csharp
var requestBody = new { description = _nlpPrompt };
var jsonContent = new StringContent(
    JsonSerializer.Serialize(requestBody),
    Encoding.UTF8,
    "application/json"
);

var response = await Http.PostAsync(
    "http://localhost:5000/parse-requirement", 
    jsonContent
);
```

### Important Notes:

1. **HttpClient Injection**: The dialog uses `@inject HttpClient Http`
2. **CORS**: Already enabled in Python API for all routes
3. **Error Handling**: Comprehensive try-catch blocks with user-friendly messages
4. **Skill Matching**: Case-insensitive matching against existing skill database

## Benefits

1. **Faster Requirement Creation**: Reduces form filling time significantly
2. **Consistent Format**: AI ensures standardized skill extraction
3. **User-Friendly**: Natural language is easier than form fields
4. **Flexible**: Users can still manually adjust all fields
5. **No Breaking Changes**: Existing functionality remains unchanged

## Technical Details

### Dependencies:
- Python API: No new dependencies required
- C# Blazor: Uses existing `HttpClient`, `System.Text.Json`

### Performance:
- API call typically completes in <2 seconds
- Non-blocking UI with loading indicators
- Graceful fallback if API is unavailable

### Error Handling:
- Connection errors: User-friendly message to fill manually
- Parse errors: Detailed logging, user notification
- Validation: All existing form validation still applies

## Future Enhancements

1. **Enhanced Skill Matching**: Fuzzy matching for similar skill names
2. **Team Auto-Detection**: Parse team/department from description
3. **Priority Detection**: Infer requirement priority from language tone
4. **Duration Extraction**: Parse project duration from description
5. **Multi-Language Support**: Support for non-English descriptions

## Troubleshooting

### Issue: API Connection Failed
**Solution:** 
```bash
# Check if Python API is running
curl http://localhost:5000/health

# If not, start it:
cd /Users/Dev/Projects/PythonAPI
python app.py
```

### Issue: Skills Not Auto-Populating
**Possible Causes:**
1. Skill names in API don't match database exactly
2. API returned empty skills array
3. Check browser console for errors

**Debug Steps:**
1. Check browser console for API response
2. Verify skill names exist in database
3. Test with `/parse` endpoint directly

### Issue: Location Not Detected
**Note:** Location detection requires explicit city names in the description.
Supported cities: Bangalore, Chennai, Mumbai, Hyderabad, etc.

## Example Prompts

### Good Examples:
✅ "Need a senior Python developer with 5 years Django experience in Bangalore"
✅ "Looking for Java and Spring Boot developer with 3+ years in Mumbai"
✅ "Cloud architect with AWS, Docker, Kubernetes mandatory in Hyderabad"
✅ "Frontend developer needed with React, TypeScript and 4 years experience"

### Less Effective:
❌ "Need a good developer" (too vague)
❌ "Python" (missing context)
❌ "Someone for my team" (no skills mentioned)

## Code Structure

```
PythonAPI/
├── app.py                          # New /parse-requirement endpoint
├── test_requirement_parser.py      # Test script
└── services/
    └── query_parser.py             # Existing parser (reused)

InternalTalentMarketPlace/
└── TalentMarketPlace/
    └── Pages/
        └── Shared/
            └── RequirementDialog.razor  # Updated with NLP feature
```

## Summary

This feature successfully integrates NLP-based requirement parsing into the Post Requirement workflow without disturbing existing functionality. The Python API's new endpoint leverages the existing query parser, ensuring consistency with the AI Search feature while providing a tailored response format for requirement creation.
