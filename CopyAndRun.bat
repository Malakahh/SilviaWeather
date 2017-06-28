@echo off

SET dllPath=D:\GitRepos\SilviaWeather\SilviaWeather\SilviaWeather\bin\Debug\SilviaWeather.dll
SET pdbPath=D:\GitRepos\SilviaWeather\SilviaWeather\SilviaWeather\bin\Debug\SilviaWeather.pdb
SET targetPath=D:\GitRepos\Silvia\Silvia\SilviaBootstrapper\bin\Debug\Plug-ins
SET toRunRoot=D:\GitRepos\Silvia\Silvia\SilviaBootstrapper\bin\Debug
SET toRun=D:\GitRepos\Silvia\Silvia\SilviaBootstrapper\bin\Debug\Silvia.exe

xcopy /y %dllPath% %targetPath%
xcopy /y %pdbPath% %targetPath%

cd %toRunRoot%
start %toRun%