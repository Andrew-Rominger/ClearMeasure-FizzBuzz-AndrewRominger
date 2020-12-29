dotnet build -c Release
dotnet test
if((Read-Host -Prompt "Run Demo app? (y/n)").ToLower() -eq "y"){
    Start-Process -FilePath "TestApp\bin\release\netcoreapp3.1\TestApp.exe"
}