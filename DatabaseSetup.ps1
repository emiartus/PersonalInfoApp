# Ensure NuGet and Entity Framework are installed
if (-Not (Get-Command nuget -ErrorAction SilentlyContinue)) {
    Write-Host "NuGet is not installed. Please install it to continue." -ForegroundColor Red
    Exit
}

# Paths
$projectPath = "."  # Adjust this to your project directory if the script is not in the project root
$projectName = "DataLayer"  # Replace with your project name
$toolsDir = "$projectPath\packages\EntityFramework.Tools.*\tools"

# Check if EF Tools are available
if (-Not (Test-Path $toolsDir)) {
    Write-Host "Entity Framework Tools are not installed. Installing now..."
    nuget install EntityFramework.Tools -OutputDirectory $projectPath\packages
}

# Import the Entity Framework Tools
Import-Module (Get-ChildItem "$toolsDir\EntityFramework.PowerShell.dll" -Recurse | Select-Object -First 1).FullName

# Enable Migrations
Write-Host "Enabling Migrations..."
Invoke-Expression -Command "Enable-Migrations -ProjectName $projectName"

# Create Initial Migration
Write-Host "Creating Initial Migration..."
Invoke-Expression -Command "Add-Migration InitialCreate -ProjectName $projectName"

# Update Database
Write-Host "Updating Database..."
Invoke-Expression -Command "Update-Database -ProjectName $projectName"

Write-Host "Database setup complete!" -ForegroundColor Green