#!/bin/bash

echo "=========================================="
echo "Testing NLP Requirement Creation Feature"
echo "=========================================="
echo ""

# Step 1: Check Python API
echo "Step 1: Checking Python API..."
if curl -s http://localhost:5000/health > /dev/null 2>&1; then
    echo "✅ Python API is running on port 5000"
else
    echo "❌ Python API is NOT running"
    echo "   Start it with: cd /Users/Dev/Projects/PythonAPI && python app.py"
    echo ""
    read -p "Do you want to start Python API now? (y/n) " -n 1 -r
    echo
    if [[ $REPLY =~ ^[Yy]$ ]]; then
        echo "Starting Python API..."
        cd /Users/Dev/Projects/PythonAPI
        osascript -e 'tell app "Terminal" to do script "cd /Users/Dev/Projects/PythonAPI && python app.py"'
        echo "⏳ Waiting 5 seconds for API to start..."
        sleep 5
    else
        echo "Skipping Python API start"
    fi
fi

echo ""

# Step 2: Test the new endpoint
echo "Step 2: Testing /parse-requirement endpoint..."
TEST_RESPONSE=$(curl -s -X POST http://localhost:5000/parse-requirement \
  -H "Content-Type: application/json" \
  -d '{"description": "Senior Python developer with 5 years Django in Bangalore"}')

if [ $? -eq 0 ] && echo "$TEST_RESPONSE" | grep -q "extracted"; then
    echo "✅ /parse-requirement endpoint is working"
    echo "   Sample skills extracted:"
    echo "$TEST_RESPONSE" | python3 -c "import sys, json; data=json.load(sys.stdin); [print(f\"     - {s['name']} ({s['years']} years)\") for s in data.get('extracted', {}).get('skills', [])]" 2>/dev/null || echo "     (Unable to parse response)"
else
    echo "❌ /parse-requirement endpoint failed"
    echo "   Response: $TEST_RESPONSE"
fi

echo ""

# Step 3: Check C# Application
echo "Step 3: Checking C# Application configuration..."
CONFIG_FILE="/Users/Dev/Projects/InternalTalentMarketPlace/TalentMarketPlace/appsettings.Development.json"

if grep -q '"UseMockAuth": true' "$CONFIG_FILE"; then
    echo "✅ Mock authentication is enabled (good for Mac testing)"
else
    echo "⚠️  Mock authentication is NOT enabled"
    echo "   Edit $CONFIG_FILE"
    echo "   Add: \"UseMockAuth\": true"
fi

echo ""

# Step 4: Instructions
echo "=========================================="
echo "Ready to Test!"
echo "=========================================="
echo ""
echo "Start the C# application:"
echo "  cd /Users/Dev/Projects/InternalTalentMarketPlace/TalentMarketPlace"
echo "  dotnet run"
echo ""
echo "Then:"
echo "  1. Open browser to http://localhost:5xxx (check console for port)"
echo "  2. You'll be auto-logged in as 'Test Manager'"
echo "  3. Click 'Post & Manage Requirements'"
echo "  4. Click 'Post New Requirement'"
echo "  5. In the blue AI section, enter:"
echo "     'Senior Python developer with 5 years Django in Bangalore'"
echo "  6. Click the brain icon (🧠)"
echo "  7. Watch the form auto-populate!"
echo ""
echo "Note: Saving won't work without database, but NLP parsing will!"
echo ""
