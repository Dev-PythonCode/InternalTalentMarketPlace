# Mac Testing Guide - Bypass SQL Server Authentication

## Problem
SQL Server is not natively compatible with macOS, making it difficult to test features that require authentication.

## Solution
Use `MockAuthService` and `MockSkillService` to bypass database authentication and provide hardcoded test data.

## How It Works

### 1. Mock Authentication Service
**File:** `Services/MockAuthService.cs`

- Returns a pre-configured test user without database access
- Hardcoded employee with ID=1, Manager role
- Always returns "authenticated" status

### 2. Mock Skill Service
**File:** `Services/MockSkillService.cs`

- Returns 40+ hardcoded programming skills
- Organized in 5 categories:
  - Programming Languages (Python, Java, JavaScript, C#, etc.)
  - Web Frameworks (React, Django, Spring Boot, etc.)
  - Databases (MySQL, PostgreSQL, MongoDB, etc.)
  - Cloud Platforms (AWS, Azure, Google Cloud, etc.)
  - DevOps Tools (Docker, Kubernetes, Git, etc.)

### 2. Configuration Toggle
**File:** `appsettings.Development.json`

```json
{
  "UseMockAuth": true  // Set to true for Mac testing (enables both MockAuth and MockSkills)
}
```

### 3. Service Registration
**File:** `Program.cs`

The application checks `UseMockAuth` configuration:
- **true** → Uses `MockAuthService` + `MockSkillService` (no database)
- **false** → Uses real `AuthService` + `SkillService` (requires SQL Server)

## Usage

### Enable Mock Authentication (Default for Development)

```bash
cd /Users/Dev/Projects/InternalTalentMarketPlace/TalentMarketPlace
dotnet run
```

Look for this message in the console:
```
⚠️  USING MOCK SERVICES (No database required)
🔧 MockAuthService initialized with test user:
   User: Test Manager (test@example.com)
   Role: Manager
   Designation: Senior Manager
🔧 MockSkillService initialized with 40 skills
```

### Disable Mock Authentication (Production)

Edit `appsettings.Development.json`:
```json
{
  "UseMockAuth": false
}
```

Or set environment variable:
```bash
export UseMockAuth=false
dotnet run
```

## Test User Details

When using MockAuthService, you're automatically logged in as:

```
Name:       Test Manager
Email:      test@example.com
Role:       Manager
Department: Engineering
Level:      Senior Manager
Location:   Bangalore
Team:       Engineering (ID: 1)
Status:     Available
```

## Testing the NLP Requirement Feature

1. **Start Python API:**
   ```bash
   cd /Users/Dev/Projects/PythonAPI
   source .venv/bin/activate  # if using venv
   python app.py
   ```

2. **Start C# Application:**
   ```bash
   cd /Users/Dev/Projects/InternalTalentMarketPlace/TalentMarketPlace
   dotnet run
   ```

3. **Navigate to Post Requirement:**
   - Open browser to `http://localhost:5xxx` (check console for port)
   - You'll be auto-logged in as "Test Manager"
   - Click "Post & Manage Requirements"
   - Click "Post New Requirement"

4. **Test NLP Feature:**
   - Enter natural language description in the blue AI section
   - Example: "Senior Python developer with 5 years Django in Bangalore"
   - Click brain icon (🧠) to parse
   - Review auto-populated fields
   - Submit requirement

## Important Notes

### ⚠️ Limitations with Mock Services:

1. **No Database Persistence**: 
   - Requirements won't be saved (RequirementService still tries to access DB)
   - Skills and authentication work perfectly in-memory

2. **Testing Scope**:
   - ✅ Good for: Testing UI, NLP parsing, form population, **skill selection**
   - ❌ Not good for: Testing full save/load workflows

3. **Mock Data**:
   - **Authentication**: Fully mocked ✅
   - **Skills**: 40 common skills available ✅
   - **Requirements/Teams**: Still need database ❌

### 🔧 For Full Testing Without Database:

You would need to also mock:
- ~~`ISkillService`~~ ✅ **Already mocked!**
- `IRequirementService` - for saving requirements
- `ITeamService` - for team dropdown

## Alternative: Use Docker SQL Server

If you need full database functionality on Mac:

```bash
# Run SQL Server in Docker
docker run -e "ACCEPT_EULA=Y" -e "SA_PASSWORD=YourStrong@Passw0rd" \
  -p 1433:1433 --name sqlserver \
  -d mcr.microsoft.com/mssql/server:2022-latest

# Update connection string in appsettings.Development.json
"ConnectionStrings": {
  "DefaultConnection": "Server=localhost,1433;Database=TalentMarketplace;User Id=sa;Password=YourStrong@Passw0rd;TrustServerCertificate=True;"
}

# Set UseMockAuth to false
"UseMockAuth": false
```

## Switching Between Mock and Real Auth

### For Mac Development (No Database):
```json
// appsettings.Development.json
{
  "UseMockAuth": true
}
```

### For Windows/Production (With SQL Server):
```json
// appsettings.json or appsettings.Production.json
{
  "UseMockAuth": false,
  "ConnectionStrings": {
    "DefaultConnection": "Server=YOUR_SERVER;Database=TalentMarketplace;..."
  }
}
```

## Console Output Reference

### With Mock Auth:
```
🔧 Configuration: Python API URL = http://localhost:5000
🔧 Registering HttpClient for Python API...
🔧 Registering application services...
⚠️  USING MOCK AUTHENTICATION (No database required)
🔧 MockAuthService initialized with test user:
   User: Test Manager (test@example.com)
   Role: Manager
   Department: Engineering
🔧 Building application...
```

### With Real Auth:
```
🔧 Configuration: Python API URL = http://localhost:5000
🔧 Registering HttpClient for Python API...
🔧 Registering application services...
🔐 Using real authentication (Database required)
🔧 Building application...
```

## Troubleshooting

### Issue: Still seeing database errors
**Cause:** Other services (SkillService, RequirementService) still access database

**Solution:** Only test the NLP parsing UI, not the full save workflow

### Issue: Skills dropdown is empty
**Cause:** SkillService tries to load from database

**Solution:** 
1. Either use Docker SQL Server (see above)
2. Or mock SkillService too (more complex)

### Issue: Can't save requirements
**Cause:** RequirementService needs database

**Expected:** This is normal with MockAuth - you can test form population but not saving

## Quick Reference

| Feature | Mock Services | Real Services |
|---------|---------------|---------------|
| Login Page | Bypassed | Required |
| View UI | ✅ Works | ✅ Works |
| NLP Parsing | ✅ Works | ✅ Works |
| Form Population | ✅ Works | ✅ Works |
| Load Skills | ✅ Works (40 skills) | ✅ Works (from DB) |
| Save Requirements | ❌ Fails | ✅ Works |
| Database Access | ❌ None | ✅ Full |

---

**Recommendation for NLP Testing:**
Use Mock Services (MockAuth + MockSkills) to test the complete NLP parsing and form auto-population workflow. **All 40 skills are available in the dropdown**, so you can fully test the feature without a database!
