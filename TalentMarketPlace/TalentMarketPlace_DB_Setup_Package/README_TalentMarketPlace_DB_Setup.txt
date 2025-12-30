
Talent MarketPlace - Database Setup Package
===========================================

This package contains:
1. TalentMarketPlace_Final_DB_Setup.sql
2. This README file

Prerequisites:
- SQL Server 2019+ or SQL Server Express / LocalDB
- SQL Server Management Studio (SSMS)
- .NET 8 SDK (for EF Core migrations)

How to Use:
-----------
1. Open SQL Server Management Studio (SSMS)
2. Connect to your SQL Server instance
3. Open the file: TalentMarketPlace_Final_DB_Setup.sql
4. Execute the script (Press F5)

What the Script Does:
--------------------
- Drops the database 'TalentMarketPlace_dev' if it exists
- Creates a fresh database
- Creates all required tables aligned with EF Core models
- Creates EmailHistory and ScheduledEmails with correct schema
- Inserts EF migration history record

EF Core Notes:
--------------
After running the script, execute the following commands:

dotnet ef migrations add InitialAlignedSchema
dotnet ef database update

Important:
----------
- This script is intended for DEV / LOCAL environments
- Do NOT use DROP DATABASE in production

Contact:
--------
Generated via ChatGPT for Talent MarketPlace project
