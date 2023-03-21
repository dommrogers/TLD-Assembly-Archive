# TLD-Assembly-Archive

[Diff Report List](https://dommrogers.github.io/TLD-Assembly-Archive/)

Still a WIP, needs refinement.

## usage
cmd> get.bat $version $manifest $steamusername $steampassword $force(Y/N)
<br>or
<br>cmd> get_all.bat

$force = "Y" will forcively remove old folder and rebuild the version from scratch

## requires
dotnet tool install ilspycmd -g


---
### uses
[DepotDownloader](https://github.com/SteamRE/DepotDownloader)

[Cpp2Il](https://github.com/SamboyCoding/Cpp2IL)

[ilspycmd](https://www.nuget.org/packages/ilspycmd/) 