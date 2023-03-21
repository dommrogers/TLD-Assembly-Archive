set app=305620
set depot=305621

set archive-folder=E:\TLD-Assembly-Archive

rmdir %archive-folder%\%1 /S /Q

mkdir %archive-folder%\%1
mkdir %archive-folder%\%1\game_files
mkdir %archive-folder%\%1\call_analysis
mkdir %archive-folder%\%1\call_analysis_cs

REM get the manifest files
%archive-folder%\_apps\dd\DepotDownloader.exe -app %app% -depot %depot% -manifest %2 -filelist files.txt -dir %archive-folder%\%1\game_files -username %3

rmdir %archive-folder%\%1\game_files\.DepotDownloader /S /Q

REM call cpp2il
%archive-folder%\_apps\cpp2il\Cpp2IL.exe --game-path=%archive-folder%\%1\game_files --use-processor=callanalyzer --output-as=dummydll --output-to=%archive-folder%\%1\call_analysis

REM generate C# project
ilspycmd -p -o %archive-folder%\%1\call_analysis_cs %archive-folder%\%1\call_analysis\Assembly-CSharp.dll