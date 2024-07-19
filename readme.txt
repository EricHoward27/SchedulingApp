# SchedulingApp Setup Guide

## Pre-requisites
- .NET Framework 4.7.2 or higher
- Visual Studio (Community Edition or higher)
- MySQL Server
- MySQL Workbench

## Setup Steps
1. Unzip the project to a directory on your system.
2. Open MySQL Workbench and create a new schema (e.g., `client_schedule`).
3. Run the provided SQL script to set up the database schema and initial data.
4. Open the project in Visual Studio.
5. Update the `App.config` file with your MySQL connection details.
6. Restore NuGet packages by right-clicking the solution and selecting `Restore NuGet Packages`.
7. Build the solution (Build -> Build Solution).
8. Run the application (F5 or Start).
9. Add initial users to the `Users` table via MySQL Workbench.

## Initial Login Credentials
- Username: test
- Password: welcome123

## Contact
For any issues, contact Eric Howard at ehowa24@wgu.edu