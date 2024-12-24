rmdir SourceGit
dotnet publish ..\src\SourceGit\SourceGit.csproj -c Release -r win-arm64 -o SourceGit -p:PublishTrimmed=true -p:TrimMode=link --self-contained