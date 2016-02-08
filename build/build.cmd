ECHO off

CALL NuGet restore ..\log4net.Azure.sln
CALL "%programfiles(x86)%\MSBuild\14.0\Bin\amd64\MsBuild.exe" ..\log4net.Azure.sln /p:Configuration=Release

@IF %ERRORLEVEL% NEQ 0 GOTO err
@EXIT /B 0
:err
@EXIT /B 1