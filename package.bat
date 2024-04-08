@echo off

call %~dp0\vars.bat

call "%UAT_BAT%" ^
-ScriptsForProject="%UPROJECT_PATH%" ^
BuildCookRun ^
-project="%UPROJECT_PATH%" ^
-noP4 ^
-clientconfig=Development ^
-serverconfig=Development ^
-nocompile ^
-nocompileeditor ^
-installed ^
-unrealexe="%UE5EDITOR_CMD_EXE%" ^
-utf8output ^
-platform=Win64 ^
-build ^
-cook ^
-map=Entry ^
-CookCultures=en ^
-unversionedcookedcontent ^
-pak ^
-compressed ^
-SkipCookingEditorContent ^
-stage ^
-package ^
-archive ^
-archivedirectory="%PROJECT_DIR%\PackagedGame"
