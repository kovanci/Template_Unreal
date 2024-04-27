@echo off

REM ## About UAT: https://github.com/botman99/ue4-unreal-automation-tool

set ROOTDIR=%~dp0
set ROOTDIR=%ROOTDIR:~0,-1%

set PROJECT=TP_Chimp
set PROJECT_DIR=%ROOTDIR%
set UPROJECT_PATH=%PROJECT_DIR%\%PROJECT%.uproject

set UE5_DIR=C:\EpicGames\UE_5.4
set UE5EDITOR_EXE=%UE5_DIR%\Engine\Binaries\Win64\UnrealEditor.exe
set UE5EDITOR_CMD_EXE=%UE5_DIR%\Engine\Binaries\Win64\UnrealEditor-Cmd.exe
set BUILD_BAT=%UE5_DIR%\Engine\Build\BatchFiles\Build.bat
set UAT_BAT=%UE5_DIR%\Engine\Build\BatchFiles\RunUAT.bat