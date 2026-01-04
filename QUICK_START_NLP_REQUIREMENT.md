# Quick Start: NLP-Based Requirement Creation

## 🚀 Setup & Testing

### 1. Start Python API
```bash
cd /Users/Dev/Projects/PythonAPI
python app.py
```

Expected output:
```
[INFO] Loading SpaCy model from ./models/talent_ner_model
[INFO] ✅ Model loaded successfully!
[INFO] Starting Flask API...
 * Running on http://0.0.0.0:5000
```

### 2. Test the New Endpoint
```bash
# In a new terminal
cd /Users/Dev/Projects/PythonAPI
python test_requirement_parser.py
```

### 3. Start C# Application
```bash
cd /Users/Dev/Projects/InternalTalentMarketPlace/TalentMarketPlace
dotnet run
```

## 📝 How to Use

### Step 1: Navigate to Post Requirement
1. Open the application
2. Go to "Post & Manage Requirements"
3. Click **"Post New Requirement"** button

### Step 2: Use AI-Powered Input
At the top of the dialog, you'll see a blue section:

```
┌─────────────────────────────────────────────────────┐
│ 🪄 AI-Powered Requirement Creation                  │
├─────────────────────────────────────────────────────┤
│ [Enter requirement description here...       ] [🧠] │
│                                                      │
│ Describe your requirement in natural language       │
│ and let AI auto-populate the form fields below      │
└─────────────────────────────────────────────────────┘
```

### Step 3: Enter Natural Language Description

**Example Input:**
```
Need a senior Python developer with 5 years Django experience in Bangalore
```

### Step 4: Click the Brain Icon (🧠)
- API will parse your description
- Loading spinner appears during processing
- Success message shown when complete

### Step 5: Review Auto-Populated Fields
The following fields will be automatically filled:

✅ **Title**: "Senior Developer"  
✅ **Description**: Your natural language input  
✅ **Location**: "Bangalore"  
✅ **Skills**:
   - Python (5 years) - Mandatory
   - Django (0 years) - Nice to Have

### Step 6: Adjust & Submit
- Review all fields
- Make manual adjustments if needed
- Add/remove skills as required
- Click **"Post Requirement"**

## 💡 Example Prompts

### ✅ Effective Prompts

1. **Full Stack Developer**
   ```
   Senior full-stack developer with React, Node.js, and MongoDB, 4 years experience in Chennai
   ```
   
2. **DevOps Engineer**
   ```
   DevOps engineer needed with Docker, Kubernetes, AWS mandatory skills, 6+ years in Mumbai
   ```

3. **Data Scientist**
   ```
   Looking for Python data scientist with TensorFlow, Pandas, 3 years ML experience in Bangalore
   ```

4. **Frontend Developer**
   ```
   Frontend developer with React, TypeScript, CSS mandatory, Vue.js nice to have, Hyderabad
   ```

5. **Cloud Architect**
   ```
   Lead cloud architect with AWS, Azure, Terraform, 8 years experience
   ```

### ❌ Less Effective Prompts

```
❌ "Good developer needed"
   → Too vague, no skills mentioned

❌ "Python"
   → Missing experience, location, role context

❌ "Someone for my team"
   → No technical requirements specified
```

## 🎯 What Gets Auto-Populated

| Field | Source | Example |
|-------|--------|---------|
| **Title** | Seniority + Role | "Senior Developer", "Lead Engineer" |
| **Description** | Your input | Full prompt text |
| **Location** | City names | Bangalore, Chennai, Mumbai |
| **Skills** | Tech keywords | Python, Django, React |
| **Experience** | Numbers + context | "5 years", "3+ years" |
| **Priority** | "mandatory" keyword | Mandatory vs. Nice-to-have |

## 🔍 Skill Proficiency Mapping

Experience automatically maps to proficiency:

- **0-1 years** → Beginner
- **1-3 years** → Intermediate  
- **3-5 years** → Advanced
- **5+ years** → Expert

## 🛠️ Troubleshooting

### Problem: "Failed to parse requirement"

**Check:**
1. ✅ Python API is running on port 5000
2. ✅ Test with: `curl http://localhost:5000/health`
3. ✅ Check console for errors

### Problem: Skills not auto-populating

**Causes:**
- Skill names don't match database
- Skills not in tech dictionary
- API returned empty array

**Solution:**
- Add skills manually after parsing
- Check browser console for details
- Verify skills exist in database

### Problem: Location not detected

**Note:** Only specific cities are detected:
- Bangalore
- Chennai  
- Mumbai
- Hyderabad
- Delhi

**Solution:** Manually select location from dropdown

## 🔧 Testing the API Directly

### Using cURL:

```bash
curl -X POST http://localhost:5000/parse-requirement \
  -H "Content-Type: application/json" \
  -d '{"description": "Senior Python developer with 5 years Django in Bangalore"}'
```

### Expected Response:

```json
{
  "original_description": "Senior Python developer with 5 years Django in Bangalore",
  "extracted": {
    "skills": [
      {"name": "Python", "years": 5, "is_mandatory": true},
      {"name": "Django", "years": 0, "is_mandatory": false}
    ],
    "location": "Bangalore",
    "min_years_experience": 5,
    "seniority": "Senior",
    "roles": ["developer"],
    "skill_count": 2,
    "mandatory_count": 1
  }
}
```

## 📊 Benefits

| Traditional Method | NLP Method |
|-------------------|------------|
| Fill 8+ form fields | Enter 1 sentence |
| Select skills one by one | Auto-detected |
| Manual experience entry | Auto-extracted |
| 2-3 minutes | 30 seconds |

## 🎓 Tips for Best Results

1. **Be Specific**: Include role, skills, experience, location
2. **Use Keywords**: "mandatory", "senior", "years experience"
3. **Mention Location**: City names are well-recognized
4. **List Skills**: Separate with commas or "and"
5. **State Experience**: "5 years", "3+ years", etc.

## 📞 Support

If you encounter issues:
1. Check Python API is running
2. Review browser console for errors
3. Try the test script first
4. Fallback to manual form filling

---

**Version:** 1.0  
**Last Updated:** January 3, 2026  
**Feature Status:** ✅ Production Ready
