@echo off
set package_root=..\..\
REM Find the spkl in the package folder (irrespective of version)
For /R %package_root% %%G IN (spkl.exe) do (
	IF EXIST "%%G" (set spkl_path=%%G
	goto :continue)
	)

:continue
@echo Using '%spkl_path%' 
REM spkl earlybound [path] [connection-string] [/p:release]
"%spkl_path%" earlybound "%cd%\.." "AuthType=OAuth;Username=zjohnson@DLcrm.onmicrosoft.com;Password=Basketballislife22#;LoginPrompt=true;Url=https://dlcrm.crm.dynamics.com"

pause