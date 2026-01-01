# Quick Reference - Unified Scoring System

## TL;DR (Too Long; Didn't Read)

All three talent search pages now use **the same scoring algorithm**:

**Only mandatory skills count. Optional skills are shown but don't affect the score.**

## Score Calculation

```
Match % = (Earned mandatory weight / Total mandatory weight) × 100
```

## Scoring Per Skill

| Match Type | Condition | Weight |
|-----------|-----------|--------|
| **Full** | Years ≥ Required | 100% |
| **Good** | Years ≥ 80% of Required | 70% |
| **Partial** | Years < 80% of Required | (Years ÷ Required) × 50% |
| **Missing** | No experience | 0% |

## Pages Using Unified Scoring

| Page | URL | Uses |
|------|-----|------|
| Job Board | `/job-board` | EmployeeService.CalculateMatchScoreAsync() |
| Application Review | `/application-review` | EmployeeService.CalculateMatchScoreAsync() |
| AI Search | `/ai-search` | SearchService.CalculateUnifiedMatchScore() |

All use **mandatory-only** logic ✅

## Example: 1 Year JavaScript

**Requirement**: JS (2 yrs), TS (2 yrs), SQL (2 yrs), Node (2 yrs) - all mandatory

**Candidate**: JavaScript 1 year only

**Calculation**:
```
Total weight = 4
JS: 1/2 = 50% → 50% × 50% = 0.25 points
TS: 0 points
SQL: 0 points
Node: 0 points
─────────────────────
Score = 0.25 / 4 = 6.25%
```

**Result**: 6.25% on ALL pages ✅

## Where Scoring Happens

### Job Board
- **File**: `Pages/JobBoard.razor`
- **When**: Page loads
- **How**: `EmployeeService.CalculateMatchScoreAsync(employeeId, requirementId)`
- **Fresh**: Yes, calculated each time

### Application Review
- **File**: `Pages/ApplicationReview.razor`
- **When**: Page loads (recalculates)
- **How**: `ApplicationService.ValidateApplicationAsync()` → `EmployeeService.CalculateMatchScoreAsync()`
- **Fresh**: Yes, recalculated on each load

### AI Search
- **File**: `Pages/AiSearch.razor` (calls SearchService)
- **When**: User submits query
- **How**: `SearchService.CalculateUnifiedMatchScore()`
- **Fresh**: Yes, calculated for each search

## Key Code Locations

### EmployeeService (Database-backed)
```csharp
// Services/EmployeeService.cs, lines 224-340
public async Task<EmployeeWithMatchScore> CalculateMatchScoreAsync(
    int employeeId, 
    int requirementId)
{
    // Only counts mandatory skills
    // Uses IsMandatory flag from RequirementSkill
    // Uses Weightage from database (default = 1)
}
```

### SearchService (Query-backed)
```csharp
// Services/SearchService.cs, lines 680-745
private (decimal MatchPercentage, bool MeetsRequirements) CalculateUnifiedMatchScore(
    Employee employee,
    List<string> mandatorySkillNames,
    List<string> optionalSkillNames,
    decimal? minYears,
    string experienceOperator)
{
    // Only counts skills in mandatorySkillNames
    // optionalSkillNames are ignored for scoring
}
```

## Testing Quick Checks

### Check 1: Consistent Scores
1. Find candidate on Job Board → note score (e.g., 6.25%)
2. Go to Application Review
3. Find same candidate applying to same position
4. Score should match ✅

### Check 2: AI Search Accuracy
1. Go to AI Search
2. Search "JavaScript developers with 2 years"
3. Find candidate with 1 year JavaScript
4. Score should be ~25-50% (partial match)
5. Should match Job Board for same requirement ✅

### Check 3: Optional Skills Ignored
1. Create requirement with:
   - JavaScript (mandatory)
   - React (optional)
2. Search "JavaScript and React developers"
3. Candidate with JS but no React should still get high score
4. React shouldn't lower the score ✅

## Common Questions

**Q: Why is my score 0% if I have the skill?**
A: You might not meet the minimum years requirement. E.g., 0.5 years for a 2-year requirement = partial match only.

**Q: Why don't optional skills affect my score?**
A: Only mandatory skills count. Optional skills are nice-to-have. This ensures fair, consistent scoring.

**Q: Why do I see different scores on different pages?**
A: This should NOT happen anymore! All pages use unified scoring now. If you see differences, please report a bug.

**Q: How are weightages calculated?**
A: Each skill has a weight (default = 1). Total weight = number of mandatory skills. Your earned weight = sum of your matches.

**Q: What if I have more experience than required?**
A: Still counts as 100% match. Extra experience doesn't increase your score.

## Debug Tips

### View Scoring Logs
- Open browser console (F12 → Console tab)
- Search pages will show detailed scoring breakdown
- Look for "UNIFIED SCORE CALC" messages

### Example Debug Output
```
🔍 UNIFIED SCORE CALC: John Doe
   Mandatory: JavaScript, TypeScript
   Optional: React
   Min Years: 2
   ✅ JavaScript: 2 >= 2 → +1
   ⚠️  TypeScript: 1 >= 80% of 2 → +0.7
   ❌ No React (Optional - ignored)
   SCORE: 1.7/2 = 85.00%
```

## Summary Table

| Feature | Job Board | App Review | AI Search |
|---------|-----------|-----------|-----------|
| Algorithm | Mandatory only | Mandatory only | Mandatory only |
| Score Type | Fresh | Recalculated | Fresh |
| Source | Database | Database | Parsed query |
| Consistency | ✅ Same | ✅ Same | ✅ Same |

---

**Remember**: All three pages use the same unified scoring. One employee = one score for any given skill set.
