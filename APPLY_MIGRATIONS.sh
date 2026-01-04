#!/bin/bash

# Script to apply migrations and seed database with 50+ employees
# This script should be run from the TalentMarketPlace project directory

echo "========================================"
echo "Database Migration Script"
echo "========================================"
echo ""

# Check if we're in the right directory
if [ ! -f "Program.cs" ]; then
    echo "❌ Error: Please run this script from the TalentMarketPlace project directory"
    exit 1
fi

echo "📦 Building project..."
dotnet build

if [ $? -ne 0 ]; then
    echo "❌ Build failed. Please fix compilation errors."
    exit 1
fi

echo ""
echo "📋 Creating migration..."
dotnet ef migrations add AddExtended50EmployeesWithSkills

if [ $? -ne 0 ]; then
    echo "⚠️  Migration creation failed or already exists"
fi

echo ""
echo "🔄 Updating database..."
dotnet ef database update

if [ $? -eq 0 ]; then
    echo ""
    echo "✅ Database update successful!"
    echo ""
    echo "📊 Seeded Data Summary:"
    echo "   ✓ 50 new employees (IDs: 8-57)"
    echo "   ✓ Diverse skills assigned to each employee"
    echo "   ✓ 3-6 skills per employee"
    echo "   ✓ Varied proficiency levels (Beginner to Expert)"
    echo "   ✓ Different experience years per skill"
    echo "   ✓ Various locations and designations"
    echo ""
else
    echo "❌ Database update failed."
    echo "Common issues:"
    echo "  - LocalDB not available on macOS (use SQL Server Docker or remote DB)"
    echo "  - Database connection string incorrect"
    echo "  - SQL Server not running"
    exit 1
fi
