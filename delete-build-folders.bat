@ECHO off
cls

ECHO Deleting all BIN, OBJ, and NODE_MODULES folders...
ECHO.

FOR /d /r . %%d in (bin,obj) DO (
	IF EXIST "%%d" (		 	 
		ECHO %%d | FIND /I "\node_modules\" > Nul && ( 
			ECHO.Skipping: %%d
		) || (
			ECHO.Deleting: %%d
			rd /s/q "%%d"
		)
	)
)

IF EXIST ".\angular\.angular" (
	rd /s/q .\angular\.angular
)

IF EXIST ".\angular\node_modules" (
	rd /s/q .\angular\node_modules
)

ECHO.
ECHO.BIN and OBJ folders have been successfully deleted. Press any key to exit.
pause > nul