REM @echo off

set app=305620
set depot=305621

set archive-folder=%cd%

if "%~5"=="Y" (
	rmdir %archive-folder%\%1 /S /Q
)


IF NOT EXIST %archive-folder%\%1 (
	mkdir %archive-folder%\%1
)

IF NOT EXIST %archive-folder%\%1\game_files (
	mkdir %archive-folder%\%1\game_files
)

IF NOT EXIST %archive-folder%\%1\call_analysis (
	mkdir %archive-folder%\%1\call_analysis
)

IF NOT EXIST %archive-folder%\%1\call_analysis_cs (
	mkdir %archive-folder%\%1\call_analysis_cs
)

IF EXIST %archive-folder%\%1\info.txt (
	del %archive-folder%\%1\info.txt
)

echo app=%app% >> %archive-folder%\%1\info.txt
echo depot=%depot% >> %archive-folder%\%1\info.txt
echo manifest=%2 >> %archive-folder%\%1\info.txt

REM get the manifest files
IF NOT EXIST %archive-folder%\%1\game_files\GameAssembly.dll (
echo Downloading manifest %2..
	%archive-folder%\_apps\dd\DepotDownloader.exe -app %app% -depot %depot% -manifest %2 -filelist files.txt -dir %archive-folder%\%1\game_files -username %3 -password %4
)

IF EXIST %archive-folder%\%1\game_files\.DepotDownloader (
	rmdir %archive-folder%\%1\game_files\.DepotDownloader /S /Q
)

REM call cpp2il
IF NOT EXIST %archive-folder%\%1\call_analysis\Assembly-CSharp.dll (
	echo Generating call_analysis %1..
	%archive-folder%\_apps\cpp2il\Cpp2IL.exe --game-path=%archive-folder%\%1\game_files --use-processor=callanalyzer --output-as=dummydll --output-to=%archive-folder%\%1\call_analysis
)

REM generate C# project
IF NOT EXIST %archive-folder%\%1\call_analysis_cs\Assembly-CSharp.csproj (
	echo Generating call_analysis_cs %1..
	ilspycmd -p -o %archive-folder%\%1\call_analysis_cs %archive-folder%\%1\call_analysis\Assembly-CSharp.dll
)