@echo off
pushd %1

FOR /F "tokens=*" %%G IN ('DIR /B /AD /S bin') DO RMDIR /S /Q "%%G"
FOR /F "tokens=*" %%G IN ('DIR /B /AD /S obj') DO RMDIR /S /Q "%%G"
FOR /F "tokens=*" %%G IN ('DIR /B /AD /S debug') DO RMDIR /S /Q "%%G"

set excludeExtensions=.user;.suo

:remove_files
for %%i in (%excludeExtensions%) do (
	del *%%i /S/F
	del *%%i /S/F/AH
)

call :remove_empty_folders_recursively "%CD%"

popd


pause
goto :EOF

:remove_empty_folders_recursively
pushd %1
for /f "delims=" %%a in ('dir /AD/B') do (
	call :remove_empty_folders_recursively "%%a"
)
popd
rmdir %1 1>NUL 2>NUL && echo Removed folder - %1
goto :EOF

