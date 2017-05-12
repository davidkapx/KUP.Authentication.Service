FROM microsoft/aspnetcore:1.1
ARG source=.
WORKDIR /app
EXPOSE 5000
COPY $source .
ENTRYPOINT ["dotnet", "KUP.Authentication.Api.dll"]
