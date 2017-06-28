# fint-utdanning-model-csharp

 [ ![Download](https://api.bintray.com/packages/fint/nuget/FINT.Model.Utdanning/images/download.svg) ](https://bintray.com/fint/nuget/FINT.Model.Utdanning/_latestVersion)


## Pack and deploy to Bintray

```
msbuild /t:pack /p:Configuration=Release
nuget push FINT.Model.Utdanning\bin\Release\FINT.Model.Utdanning.0.0.1.nupkg -Source https://api.bintray.com/nuget/fint/nuget
```