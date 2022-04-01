FROM mcr.microsoft.com/dotnet/aspnet:5.0 AS final
WORKDIR /src
COPY ./bin/Release/net5.0 /app/publish 
ENTRYPOINT ["dotnet", "/app/publish/WebApi.dll"]