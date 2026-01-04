# Requirement Scoring with Overall vs Skill-Specific Experience

## The Problem

When a requirement is created with:
- **Overall experience:** "5 years total experience"
- **No skill-specific experience:** Skills listed but no individual years

**Example:**
```
"Python developer with 5 years experience"
```

**Current parsing:**
- Skills: Python, (maybe other inferred skills)
- Overall experience: 5 years
- Skill-specific experience: Python = 0 years

**Question:** How should we score/match candidates against this requirement?

## Proposed Solution: Intelligent Experience Fallback

### Strategy 1: Distribute Overall Experience to Primary Skills

When overall experience is specified but skill-specific experience is not:

```
IF requirement has:
  - Overall experience: 5 years
  - Primary skills without specific experience
THEN:
  - Assign overall experience to all primary (mandatory) skills
  - Leave optional skills at 0 years
```

**Example:**
```
Input: "Python developer with 5 years experience"

Parsed:
  - Skills: Python (mandatory, 0 years specified)
  - Overall: 5 years

Applied Logic:
  - Python: 5 years (inherited from overall)
  - Result: Candidate needs 5 years Python experience
```

### Strategy 2: Use Skill-Specific When Available, Fallback to Overall

When some skills have specific experience and others don't:

```
Input: "Python developer with Python 3 years, Django, and 5 years total"

Parsed:
  - Python: 3 years (specific)
  - Django: 0 years (not specified)
  - Overall: 5 years

Applied Logic:
  - Python: 3 years (use specific)
  - Django: 5 years (fallback to overall for unspecified skills)
```

### Strategy 3: Context-Aware Primary Skill Detection

If the role mentions a specific technology, that's the primary skill:

```
"Python developer with 5 years" → Python gets 5 years
"Java architect with 8 years" → Java gets 8 years
"Full stack developer with 4 years" → All mentioned skills get 4 years
```

## Implementation Plan

### 1. Update Python API `/parse-requirement` Endpoint

Add intelligent experience distribution:

```python
def distribute_overall_experience(extracted_data):
    """
    Distribute overall experience to skills without specific experience
    """
    overall_exp = extracted_data.get('min_years_experience', 0)
    skills = extracted_data.get('skills', [])
    roles = extracted_data.get('roles', [])
    
    # Identify primary skills based on role
    primary_skills = identify_primary_skills(skills, roles)
    
    for skill in skills:
        if skill['years'] == 0 and overall_exp > 0:
            # Check if this is a primary/mandatory skill
            if skill['is_mandatory'] or skill['name'] in primary_skills:
                skill['years'] = overall_exp
                skill['experience_source'] = 'overall_fallback'
            # Optional skills stay at 0
    
    return skills
```

### 2. Add Response Metadata

Include information about how experience was assigned:

```json
{
  "extracted": {
    "skills": [
      {
        "name": "Python",
        "years": 5,
        "is_mandatory": true,
        "experience_source": "overall_fallback",  // NEW
        "confidence": "high"  // NEW
      },
      {
        "name": "Django",
        "years": 0,
        "is_mandatory": false,
        "experience_source": "not_specified",
        "confidence": "medium"
      }
    ],
    "min_years_experience": 5,
    "experience_distribution_applied": true  // NEW
  }
}
```

### 3. Scoring Algorithm

**Candidate Matching Score Calculation:**

```javascript
For each required skill:
  IF skill has specific experience requirement (years > 0):
    score = calculate_experience_match(candidate_years, required_years, is_mandatory)
  ELSE IF skill is mandatory AND overall experience exists:
    score = calculate_experience_match(candidate_years, overall_experience, true)
  ELSE:
    score = calculate_skill_presence(candidate_has_skill, is_mandatory)

Total Score = weighted_average(all_skill_scores)
```

**Experience Match Calculation:**

```python
def calculate_experience_match(candidate_years, required_years, is_mandatory):
    if candidate_years >= required_years:
        # Meets or exceeds requirement
        score = 100
    elif candidate_years >= required_years * 0.8:
        # Close match (80%+)
        score = 80 + (candidate_years / required_years * 20)
    elif candidate_years > 0:
        # Has some experience
        score = (candidate_years / required_years) * 70
    else:
        # No experience
        score = 0 if is_mandatory else 20
    
    return score
```

## Example Scenarios

### Scenario 1: Overall Experience Only

**Requirement:**
```
"Python developer with 5 years experience"
```

**Parsed & Applied:**
- Python: 5 years (inherited from overall), Mandatory
- Score calculation: Candidate needs 5+ years Python

**Candidate A:** Python 6 years → Score: 100%  
**Candidate B:** Python 4 years → Score: 85%  
**Candidate C:** Python 2 years → Score: 56%

---

### Scenario 2: Mixed Experience

**Requirement:**
```
"Python developer with Python 3 years, Django, React nice to have, 5 years total"
```

**Parsed & Applied:**
- Python: 3 years (specific), Mandatory
- Django: 5 years (inherited from overall), Mandatory
- React: 0 years (optional stays at 0), Optional

**Candidate A:** Python 4y, Django 6y, React 0y → Score: 95%  
**Candidate B:** Python 3y, Django 3y, React 2y → Score: 85%  
**Candidate C:** Python 2y, Django 2y, React 0y → Score: 65%

---

### Scenario 3: All Skill-Specific

**Requirement:**
```
"Developer with Python 3 years, Django 2 years, AWS 4 years"
```

**Parsed & Applied:**
- Python: 3 years (specific), Mandatory
- Django: 2 years (specific), Mandatory
- AWS: 4 years (specific), Mandatory
- No overall experience fallback needed

**Scoring:** Direct comparison of each skill

---

### Scenario 4: No Experience Specified

**Requirement:**
```
"Python developer needed with Django and React"
```

**Parsed & Applied:**
- Python: 0 years, Mandatory
- Django: 0 years, Mandatory
- React: 0 years, Mandatory

**Scoring:** Based purely on skill presence, not experience

**Candidate A:** Has all 3 skills → Score: 100%  
**Candidate B:** Has Python + Django → Score: 67%  
**Candidate C:** Has Python only → Score: 33%

## Recommended Scoring Weights

```python
SCORING_WEIGHTS = {
    'skill_presence': 0.4,      # 40% - Having the skill
    'experience_match': 0.4,    # 40% - Experience level match
    'proficiency_level': 0.1,   # 10% - Skill proficiency
    'mandatory_bonus': 0.1      # 10% - Mandatory skill bonus
}

# Mandatory skill penalty for missing
MANDATORY_MISS_PENALTY = -30  # Severe penalty if mandatory skill missing

# Optional skill bonus
OPTIONAL_BONUS = 5  # Small bonus for having optional skills
```

## Implementation Code Snippet

### Python API Enhancement

```python
@app.route('/parse-requirement', methods=['POST'])
def parse_requirement():
    # ... existing parsing code ...
    
    # ⭐ NEW: Apply intelligent experience distribution
    overall_exp = parsed_data.get('min_years_experience', 0)
    
    for skill in extracted_skills:
        if skill['years'] == 0 and overall_exp > 0 and skill['is_mandatory']:
            # Apply overall experience to mandatory skills without specific experience
            skill['years'] = overall_exp
            skill['experience_source'] = 'overall_fallback'
            logger.info(f"  🔄 Applied overall experience to {skill['name']}: {overall_exp} years")
        else:
            skill['experience_source'] = 'specific' if skill['years'] > 0 else 'not_specified'
    
    result = {
        'original_description': description,
        'extracted': {
            'skills': extracted_skills,
            'location': location,
            'min_years_experience': min_years_experience,
            'experience_distribution_applied': any(s['experience_source'] == 'overall_fallback' for s in extracted_skills),
            # ... other fields
        }
    }
    
    return jsonify(result), 200
```

### C# Form Display

```csharp
// In RequirementDialog.razor - Show experience source indicator

foreach (var skill in extracted.Skills)
{
    var yearsDisplay = skill.Years > 0 ? $"{skill.Years} years" : "Any";
    var sourceIndicator = skill.ExperienceSource == "overall_fallback" 
        ? " (from overall)" 
        : "";
    
    Console.WriteLine($"  {skill.Name}: {yearsDisplay}{sourceIndicator}");
}
```

## UI Considerations

### Visual Indicator in Form

When overall experience is distributed to skills, show it clearly:

```
Skills:
  ✓ Python: 5 years (inherited from overall experience)
  ✓ Django: 0 years
  
Overall Experience: 5 years total
```

### Edit Behavior

Allow users to override the inherited experience:

```
[ ] Use overall experience for all mandatory skills (checked by default)
    When unchecked: Users can set individual skill experience
```

## Summary

**Best Approach:**
1. ✅ Parse skill-specific experience when explicitly stated
2. ✅ For mandatory skills without specific experience, inherit overall experience
3. ✅ Keep optional skills at 0 unless specified
4. ✅ Provide metadata about experience source
5. ✅ Score candidates based on appropriate experience level

**Benefits:**
- Intuitive matching behavior
- Fair scoring even when requirements are vague
- Flexibility for detailed or high-level requirements
- Clear visibility into how experience was assigned

**Files to Update:**
1. `/Users/Dev/Projects/PythonAPI/app.py` - Add experience distribution logic
2. `/Users/Dev/Projects/InternalTalentMarketPlace/TalentMarketPlace/Pages/Shared/RequirementDialog.razor` - Show experience source
3. Future: Scoring/matching algorithm in SearchService

Would you like me to implement this solution?
