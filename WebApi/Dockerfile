FROM mcr.microsoft.com/dotnet/aspnet:5.0 AS final
WORKDIR /WebApi
COPY bin/Release/net5.0 /WebApi/publish
ENTRYPOINT ["dotnet", "/WebApi/publish/WebApi.dll"]
