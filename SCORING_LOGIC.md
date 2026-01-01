# Skill Matching & Scoring Logic Documentation

## Overview
The talent marketplace uses a consistent, transparent scoring system across all pages to match employees with job opportunities. The scoring is based **only on mandatory skills** and overall experience levels.

## Scoring Principles

### ✅ What IS Counted in the Score
1. **Mandatory Skills Only** - Skills marked as "required" or "must-have"
2. **Years of Experience** - For each mandatory skill and overall career experience
3. **Proficiency Level** - The skill mastery level (Beginner/Intermediate/Advanced/Expert)

### ❌ What IS NOT Counted in the Score
1. **Optional Skills** - Nice-to-have or bonus skills
2. **Nice-to-Have Skills** - Secondary or preferred skills
3. These are shown for reference only and do NOT affect the match percentage

## Scoring Formula

### Match Percentage Calculation
```
Match % = (Earned Mandatory Skill Weight / Total Mandatory Skill Weight) × 100
```

Where:
- **Total Mandatory Skill Weight** = Sum of weightage for all mandatory skills
- **Earned Mandatory Skill Weight** = Sum of earned weight from matched mandatory skills

### Per-Skill Score Contribution

For each **mandatory skill**, the contribution is calculated as:

#### 1. **Full Match** (100% of skill weight earned)
- Condition: Employee years ≥ Required years
- Example: Required 5 years, Employee has 5+ years
- Score contribution: 100% of skill weight

#### 2. **Partial Match (Good)** (70% of skill weight earned)
- Condition: Employee years ≥ 80% of required years
- Example: Required 5 years, Employee has 4-4.9 years
- Score contribution: 70% of skill weight

#### 3. **Partial Match (Moderate)** (Variable % of skill weight earned)
- Condition: Employee years < 80% of required years
- Formula: `(Employee Years / Required Years) × 50% of skill weight`
- Example: Required 5 years, Employee has 2 years → (2/5) × 50% = 20% of skill weight

#### 4. **Missing** (0% of skill weight earned)
- Condition: Employee doesn't have the skill
- Score contribution: 0% of skill weight
- Creates a skill gap requiring learning

## Examples

### Example 1: Perfect Fit
```
Requirement:
- Mandatory: Java (3 years required, weight 1)
- Mandatory: Python (2 years required, weight 1)
- Optional: Docker (nice to have)

Employee:
- Java: 4 years
- Python: 3 years
- Docker: 1 year

Calculation:
Total mandatory weight = 1 + 1 = 2
Earned weight = 1 (full match) + 1 (full match) = 2
Match % = (2/2) × 100 = 100%
Category: GOOD FIT ✅
```

### Example 2: Needs Training
```
Requirement:
- Mandatory: React (4 years required, weight 1)
- Mandatory: Node.js (3 years required, weight 1)
- Optional: TypeScript (nice to have)

Employee:
- React: 3 years
- Node.js: 1.5 years (doesn't exist)
- TypeScript: 2 years

Calculation:
Total mandatory weight = 1 + 1 = 2
Earned weight = 0.7 (partial: 3 >= 80% of 4) + 0 (missing) = 0.7
Match % = (0.7/2) × 100 = 35%
Category: NOT RECOMMENDED ⚠️
Gaps: Node.js (missing), React (needs 1 more year)
```

### Example 3: Mixed Skills
```
Requirement:
- Mandatory: SQL (5 years required, weight 2)
- Mandatory: C# (4 years required, weight 1)
- Optional: AWS (nice to have)

Employee:
- SQL: 3 years
- C#: 4 years
- AWS: 2 years

Calculation:
Total mandatory weight = 2 + 1 = 3
Earned weight = (3/5) × 50% of 2 + 1 (full match of 1) = 0.6 + 1 = 1.6
Match % = (1.6/3) × 100 = 53.3%
Category: NEEDS TRAINING 📚
Gaps: SQL (2 years short)
Note: AWS is shown but not counted in score
```

## Score Categories & Recommendations

| Score Range | Category | Meaning | Action |
|-------------|----------|---------|--------|
| 80-100% | **Good Fit** ✅ | Meets all mandatory requirements | Proceed with interview |
| 60-79% | **Needs Training** 📚 | Has foundational skills but needs improvement | Consider with training plan |
| 0-59% | **Not Recommended** ⚠️ | Significant gaps in mandatory skills | Look for better candidates |

## Pages Showing Scoring Details

### 1. **Application Review** (HR/Manager Page)
- Shows **match score percentage**
- Lists **mandatory skills** (scored) with status:
  - ✅ Full Match
  - ⚠️ Partial Match
  - ❌ Missing
- Shows **optional skills** (not scored) for reference
- Displays **scoring explanation** with formula
- Lists **missing mandatory skills** that need learning
- Suggests **learning resources** for gaps

### 2. **Job Board / Current Job Openings** (Employee Page)
- Shows **match score percentage** for each job
- Lists **mandatory skills** required (scored)
- Lists **optional skills** for reference
- Indicates which skills the employee:
  - ✅ Fully meets
  - ⚠️ Partially meets
  - ❌ Is missing
- Shows years of experience for each skill

### 3. **Post Requirement** (HR Page)
- When creating a requirement, HR specifies:
  - Which skills are mandatory vs. optional
  - Years of experience required for each
  - Skill weightage (how important is this skill)

## Consistency Across the Application

✅ **AI Search Assistant** - Uses mandatory skills only
✅ **Post Requirement** - Shows mandatory vs. optional distinction  
✅ **Application Review** - Scores based on mandatory skills only
✅ **Job Board** - Shows mandatory vs. optional clearly
✅ **Career Roadmap** - Considers only mandatory skill gaps for learning paths

## Skill Weightage

Each skill has a **weightage** value that determines its importance:
- **Default weightage**: 1 (equal importance)
- **Higher weightage**: e.g., 2 or 3 for critical skills
- **In calculation**: Earned weight = match status × weightage

Example with weightage:
```
Mandatory skills:
- Java (weight 2): Full match = 2 earned
- Python (weight 1): Partial match = 0.7 earned

Total weight = 3
Earned weight = 2.7
Match % = (2.7/3) × 100 = 90%
```

## Technical Implementation

### Services Involved
1. **EmployeeService.CalculateMatchScoreAsync()**
   - Calculates match score based on mandatory skills only
   - Returns `EmployeeWithMatchScore` with breakdown

2. **ApplicationService.ValidateApplicationAsync()**
   - Uses EmployeeService scoring
   - Generates recommendations based on score
   - Retrieves learning resources for gaps

3. **SearchService** (AI Search Assistant)
   - Uses same scoring logic
   - Returns employees ranked by match %

### Data Models
- **SkillMatchDetail**: Details about individual skill matches
  - `IsMandatory`: Whether skill is mandatory
  - `MatchStatus`: "Full", "Partial", or "Missing"
  - `ScoreContribution`: Weight contributed to score
  - `RequiredYears` & `EmployeeYears`: Experience levels

- **SkillGap**: Skills that need improvement
  - `IsMandatory`: Only mandatory skills create gaps
  - `GapYears`: How many years short
  - `RecommendedResources`: Learning materials

## Key Changes from Previous Logic

### Before
- ❌ Both mandatory and optional skills counted in score
- ❌ Inconsistent scoring across pages
- ❌ Hard to understand why a score was calculated
- ❌ Optional skills artificially lowered match percentage

### After
- ✅ **Only mandatory skills** count toward score
- ✅ Consistent scoring everywhere
- ✅ Clear explanation of how score is calculated
- ✅ Optional skills shown separately as bonuses
- ✅ Transparent skill gap analysis for mandatory skills only

## Example Interpretation Guide

### For Candidates
**"I have a 72% match for this job"**
- This means I have mastered 72% of the mandatory skills required
- Optional skills I have are bonus points but not counted
- If score < 80%, there are training opportunities to improve

### For Hiring Managers
**"Candidate has 65% match"**
- Candidate has ~ 65% of mandatory skills needed
- Can be trained for the remaining gaps
- Look at which mandatory skills are missing for training plan
- Optional skills the candidate HAS are a bonus

### For HR/Recruiters
**"Score is based on mandatory skills only"**
- Ensures consistent, fair evaluation
- Candidates can clearly see what to improve
- Matches with learning path recommendations
- Reduces subjective bias in scoring

## Testing & Validation

To verify the scoring logic works correctly:

1. **Check EmployeeService.CalculateMatchScoreAsync()**
   - Confirm it only adds mandatory skills to totalWeight
   - Verify optional skills don't affect score

2. **Check ApplicationService.ValidateApplicationAsync()**
   - Confirm it uses the EmployeeService score
   - Verify learning resources are only for mandatory gaps

3. **Test Pages**
   - Application Review: Should show mandatory vs. optional clearly
   - Job Board: Should show only mandatory skills affecting score
   - Requirement Creation: Should ask which skills are mandatory

## Contact & Questions
For questions about scoring logic, refer to the code in:
- `/TalentMarketPlace/Services/EmployeeService.cs` - Main scoring logic
- `/TalentMarketPlace/Services/ApplicationService.cs` - Application validation
- `/TalentMarketPlace/Pages/ApplicationReview.razor` - Score display (HR)
- `/TalentMarketPlace/Pages/JobBoard.razor` - Score display (Employee)
