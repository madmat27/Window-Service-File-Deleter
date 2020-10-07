# Window-Service-File-Deleter
A template for a windows service that deletes files from a specified folder every xx minutes

1. To modify: 
-Open the .sln file in Visual Studio 2015 or later edition
-Change the FilePath variable and the timer, according to your needs

2. To use: 
-Save the project
-Do a clean 
-Rebuild

3. To install:
-Navigate to Visual Studio Folder and find "Developer Command Prompt for VS2015"
-Run it as Administrator
-Go to the project folder/bin/release in command line prompt
-To install, type: "installutil LaserOpDeleter.exe" (without the quotes)

4. To execute:
-Go to Control Panel -> Administrative Tools -> Services
-Find "LaserOpDeleterService" and start it.

5. To uninstall:
-Go to Control Panel -> Administrative Tools -> Services
-Find "LaserOpDeleterService" and stop it.
-Navigate to Visual Studio Folder and find "Developer Command Prompt for VS2015"
-Run it as Administrator
-Go to the project folder/bin/release in command line prompt
-To uninstall, type: "installutil /u LaserOpDeleter.exe" (without the quotes)
