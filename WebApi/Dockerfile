FROM mcr.microsoft.com/dotnet/aspnet:5.0 AS final
WORKDIR /Travelers
COPY ./WebApi/bin/Release/net5.0 ./publish
ENTRYPOINT ["dotnet", "/publish/WebApi.dll"]