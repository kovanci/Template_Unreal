@echo off

call %~dp0\vars.bat

set EDITOR_CMD="%UE5EDITOR_EXE%" "%UPROJECT_PATH%" %*
echo %EDITOR_CMD%
start "" %EDITOR_CMD%