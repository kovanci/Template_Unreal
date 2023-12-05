@echo off

call %~dp0\vars.bat

call "%UE5EDITOR_CMD_EXE%" "%UPROJECT_PATH%" -run=CompileAllBlueprints
