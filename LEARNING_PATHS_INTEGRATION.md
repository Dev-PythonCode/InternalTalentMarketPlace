================================================================================
LEARNING PATHS INTEGRATION GUIDE - .NET BLAZOR
================================================================================

📋 OVERVIEW
───────────────────────────────────────────────────────────────────────────────

This guide covers integrating the Python Learning Paths API with Blazor
components in the .NET InternalTalentMarketPlace application.

What's Included:
  ✓ JobOpenings.razor component (complete example)
  ✓ Modal helper JavaScript functions
  ✓ HTTP client integration
  ✓ Course display and navigation
  ✓ Difficulty level filtering
  ✓ Error handling and loading states

================================================================================
🚀 QUICK START
================================================================================

1. ADD MODAL HELPERS SCRIPT
──────────────────────────
File: wwwroot/js/modal-helpers.js (already created)

In your _Layout.cshtml or Host.cshtml, add:
  <script src="_framework/blazor.web.js"></script>
  <script src="js/modal-helpers.js"></script>

2. IMPORT REQUIRED NAMESPACES IN COMPONENT
──────────────────────────────────────────
@using System.Text.Json
@using System.Net.Http.Json
@inject HttpClient Http
@inject IJSRuntime JS

3. CREATE COMPONENT CLASS
──────────────────────────
Create code-behind class or embed @code block:

@code {
    private List<JobOpening> jobOpenings = new();
    private JobOpening selectedJob = null;
    private dynamic learningPathData = null;
    private bool isLoadingLearningPath = false;
    private string selectedDifficulty = "Beginner";

    // ... methods ...
}

4. FETCH LEARNING PATHS
──────────────────────
private async Task FetchLearningPaths()
{
    var requestData = new
    {
        technologies = selectedJob.RequiredTechnologies,
        difficulty_level = selectedDifficulty
    };

    var response = await Http.PostAsJsonAsync(
        "http://localhost:5000/learning-paths",
        requestData
    );

    if (response.IsSuccessStatusCode)
    {
        var jsonContent = await response.Content.ReadAsStringAsync();
        learningPathData = JsonSerializer.Deserialize<dynamic>(jsonContent);
    }
}

================================================================================
🔧 COMPONENT SETUP DETAILS
================================================================================

File: Components/Pages/JobOpenings.razor

Structure:
  1. Page directive and imports
  2. UI layout with job cards
  3. Job details modal
  4. Learning path modal
  5. @code block with logic

Key Features:
  ✓ Responsive grid layout (6 job cards)
  ✓ Job details in modal dialog
  ✓ Learning resources fetched from API
  ✓ Course cards with full information
  ✓ External links to course providers
  ✓ Difficulty level selection
  ✓ Error handling and loading states
  ✓ Bootstrap styling with custom CSS

Data Models:
  public class JobOpening
  {
      public int JobId { get; set; }
      public string JobTitle { get; set; }
      public string Company { get; set; }
      public string Location { get; set; }
      public string Description { get; set; }
      public string SalaryRange { get; set; }
      public string ExperienceRequired { get; set; }
      public List<string> RequiredTechnologies { get; set; }
      public List<string> NiceToHaveTechnologies { get; set; }
      public List<string> Responsibilities { get; set; }
  }

================================================================================
🎨 UI LAYOUT
================================================================================

Job Opening Card:
  ┌──────────────────────┐
  │ 💼 Full Stack Dev    │
  │ TechCorp | San Fran  │
  │ We're looking for... │
  │                      │
  │ Tech: React, Node... │
  │ Salary: $120K-$160K  │
  │ Exp: 3-5 years       │
  │                      │
  │ [Details] [Learning] │
  └──────────────────────┘

Job Details Modal:
  ┌─────────────────────────┐
  │ 💼 Job Details      [x] │
  ├─────────────────────────┤
  │ Full Stack Developer    │
  │ TechCorp | San Francisco│
  │                         │
  │ Salary: $120K-$160K     │
  │ Experience: 3-5 years   │
  │                         │
  │ Description:            │
  │ We're looking for...    │
  │                         │
  │ Responsibilities:       │
  │ • Design applications   │
  │ • Develop APIs...       │
  │                         │
  │ Required Tech:          │
  │ [React] [Node] [SQL]... │
  │                         │
  │ Nice to Have:           │
  │ [AWS] [Kubernetes]...   │
  ├─────────────────────────┤
  │ [Close] [Learning Path] │
  └─────────────────────────┘

Learning Path Modal:
  ┌────────────────────────────────┐
  │ 📚 Learning Path            [x]│
  ├────────────────────────────────┤
  │ Required for: Full Stack Dev    │
  │ [React] [Node] [SQL]...         │
  │                                │
  │ Difficulty: ◉Beginner ○Int ○Ad │
  │                                │
  │ 💻 Python Learning Resources    │
  │ ┌──────────────────────────┐    │
  │ │ Python for Everybody     │    │
  │ │ Coursera · 8 weeks       │    │
  │ │ Free / $39+              │    │
  │ │ Rating: 4.8 ⭐          │    │
  │ │ Learn Python basics...   │    │
  │ │ [View Course →]          │    │
  │ └──────────────────────────┘    │
  │                                │
  │ 🐳 Docker Learning Resources    │
  │ [Courses...]                   │
  │                                │
  ├────────────────────────────────┤
  │ [Close]                        │
  └────────────────────────────────┘

================================================================================
📡 API INTEGRATION POINTS
================================================================================

1. FETCH LEARNING PATHS
   Method: POST
   URL: http://localhost:5000/learning-paths
   
   Request:
   {
     "technologies": ["Python", "Docker"],
     "difficulty_level": "Beginner"
   }

2. ERROR HANDLING
   Handle different response codes:
   - 200: Success, process learningPathData
   - 400: Bad request, show error message
   - 500: Server error, show error message
   - Network error: Show connection error

3. TIMEOUT HANDLING
   Set HTTP timeout:
   Http.Timeout = TimeSpan.FromSeconds(30);

================================================================================
🔌 CONNECTING TO EXISTING INFRASTRUCTURE
================================================================================

1. UPDATE APP CONFIGURATION
   In appsettings.json:
   
   {
     "ApiEndpoints": {
       "Python": "http://localhost:5000",
       "LearningPaths": "http://localhost:5000/learning-paths"
     }
   }

2. USE CONFIGURATION IN COMPONENT
   @inject IConfiguration Config
   
   private string apiUrl;
   
   protected override void OnInitialized()
   {
       apiUrl = Config["ApiEndpoints:Python"];
   }

3. CALL WITH DYNAMIC URL
   var response = await Http.PostAsJsonAsync(
       $"{apiUrl}/learning-paths",
       requestData
   );

4. ADD HTTP CLIENT CONFIGURATION
   In Program.cs:
   
   services.AddHttpClient("PythonAPI", client =>
   {
       client.BaseAddress = new Uri("http://localhost:5000");
       client.Timeout = TimeSpan.FromSeconds(30);
   });

   Use in component:
   @inject IHttpClientFactory HttpClientFactory
   var http = HttpClientFactory.CreateClient("PythonAPI");

================================================================================
🎯 COMMON INTEGRATION PATTERNS
================================================================================

PATTERN 1: Display Learning Path for Selected Job
──────────────────────────────────────────────────
Private async Task ViewLearningPath(JobOpening job)
{
    selectedJob = job;
    await FetchLearningPaths();
    await JS.InvokeVoidAsync("showModal", "learningPathModal");
}

PATTERN 2: Difficulty Level Filter
────────────────────────────────────
private async Task HandleDifficultyChange(string difficulty)
{
    selectedDifficulty = difficulty;
    if (selectedJob != null)
    {
        await FetchLearningPaths();
    }
}

PATTERN 3: Parse Dynamic JSON Response
────────────────────────────────────────
var courseObj = JsonSerializer.Deserialize<Dictionary<string, JsonElement>>(
    JsonSerializer.Serialize(course)
);

string title = courseObj.GetString("title");
double rating = courseObj["rating"].GetDouble();

PATTERN 4: Render Course Card
───────────────────────────────
<div class="card mb-2">
    <div class="card-body p-2">
        <h8 class="card-title mb-1">@course["title"]</h8>
        <p class="card-text small">
            <strong>Provider:</strong> @course["provider"]
        </p>
        <a href="@course["url"]" target="_blank" class="btn btn-sm btn-primary">
            <i class="bi bi-box-arrow-up-right"></i> View Course
        </a>
    </div>
</div>

PATTERN 5: Handle Loading States
──────────────────────────────────
@if (isLoadingLearningPath)
{
    <div class="spinner-border" role="status">
        <span class="visually-hidden">Loading...</span>
    </div>
}
else if (learningPathError != null)
{
    <div class="alert alert-danger">@learningPathError</div>
}
else if (learningPathData != null)
{
    <!-- Display courses -->
}

================================================================================
🧪 TESTING THE INTEGRATION
================================================================================

1. RUN PYTHON API
   cd /Users/Dev/Projects/PythonAPI
   source venv/bin/activate
   python3 app.py

2. RUN .NET APPLICATION
   cd /Users/Dev/Projects/InternalTalentMarketPlace/TalentMarketPlace
   dotnet run

3. NAVIGATE TO JOB OPENINGS
   URL: https://localhost:xxxx/job-openings

4. TEST WORKFLOW
   a. Page loads with 6 sample jobs
   b. Click "Details" button - opens job details modal
   c. Click "Learning Path" - fetches courses from Python API
   d. Change difficulty level - refetches courses
   e. Click "View Course" - opens course link in new tab

5. VERIFY API CALLS
   Open browser DevTools (F12)
   Network tab → POST requests to localhost:5000
   Check request/response payloads

================================================================================
🔍 DEBUGGING TIPS
================================================================================

If learning paths don't show:
  1. Check API is running: curl http://localhost:5000/health
  2. Check network requests in DevTools → Network tab
  3. Check browser console for errors: F12 → Console
  4. Verify API URL in component matches running server
  5. Check CORS settings: API should allow requests from Blazor app

Common Issues:

Issue: "CORS error: No 'Access-Control-Allow-Origin' header"
Solution: API already has CORS enabled. Verify Flask server is running.

Issue: "404 Not Found on /learning-paths"
Solution: Flask route missing. Check app.py has @app.route('/learning-paths')

Issue: "JSON parsing error"
Solution: Verify API response format matches expected structure.
Debug: Log jsonContent before parsing: Console.WriteLine(jsonContent);

Issue: "Modal not showing"
Solution: Verify modal-helpers.js is loaded and Bootstrap JS is included.

Issue: "Technologies not found"
Solution: Technology names are case-sensitive. Check exact spelling.
Available techs: Python, JavaScript, React, Node.js, Java, SQL, Docker, etc.

================================================================================
📦 FILE STRUCTURE
================================================================================

After implementation:

InternalTalentMarketPlace/
  TalentMarketPlace/
    Components/
      Pages/
        JobOpenings.razor          ← Main component
    wwwroot/
      js/
        modal-helpers.js            ← Modal utilities
        career-roadmap.js           (existing)
      css/
        app.css                     (existing)

PythonAPI/
  app.py                            (with new endpoints)
  data/
    learning_paths.json             ← Course data
    career_roadmap_training.json    (existing)
  LEARNING_PATHS_API.txt            ← API documentation

================================================================================
🚀 DEPLOYMENT CHECKLIST
================================================================================

Development:
  ✓ Python API running on port 5000
  ✓ .NET app configured to connect to localhost:5000
  ✓ Components working with sample data
  ✓ All navigation and filtering functional

Production:
  ✓ Python API deployed on production server
  ✓ Update API URL in appsettings.json
  ✓ Configure CORS for .NET domain
  ✓ Enable HTTPS (certificate)
  ✓ Set up authentication if needed
  ✓ Add rate limiting (100 req/min)
  ✓ Configure monitoring and alerting
  ✓ Test all functionality end-to-end
  ✓ Load testing (concurrent users)
  ✓ Performance optimization

================================================================================
📚 ADDITIONAL RESOURCES
================================================================================

Learning Paths API Documentation:
  See: /Users/Dev/Projects/PythonAPI/LEARNING_PATHS_API.txt

Component Code:
  See: /Users/Dev/Projects/InternalTalentMarketPlace/TalentMarketPlace/Components/Pages/JobOpenings.razor

Data Structure:
  See: /Users/Dev/Projects/PythonAPI/data/learning_paths.json

Modal Helpers:
  See: /Users/Dev/Projects/InternalTalentMarketPlace/TalentMarketPlace/wwwroot/js/modal-helpers.js

================================================================================
✅ INTEGRATION COMPLETE
================================================================================

The Learning Paths system is fully integrated and ready to use:

1. Start Python API:
   python3 /Users/Dev/Projects/PythonAPI/app.py

2. Start .NET app:
   dotnet run (from TalentMarketPlace directory)

3. Navigate to:
   https://localhost:xxxx/job-openings

4. Test workflow:
   Click "View Learning Path" on any job
   Select difficulty level
   View and access course links

For questions or updates, refer to LEARNING_PATHS_API.txt or component code.
================================================================================
