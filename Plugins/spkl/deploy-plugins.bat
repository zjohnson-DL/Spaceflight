@echo off
set package_root=..\..\
REM Find the spkl in the package folder (irrespective of version)
For /R %package_root% %%G IN (spkl.exe) do (
	IF EXIST "%%G" (set spkl_path=%%G
	goto :continue)
	)

:continue
@echo Using '%spkl_path%' 
REM spkl plugins [path] [connection-string] [/p:release]
"%spkl_path%" plugins "%cd%\.." "AuthType=Office365; Username=zjohnson@dlcrm.onmicrosoft.com; Password=Basketballislife22#; Url=https://dlcrm.crm.dynamics.com"

pause