FROM microsoft/dotnet:sdk AS build-env
WORKDIR UserApp/userapp

ENV ASPNETCORE_URLS http://+:80

# Copy csproj and restore as distinct layers
COPY *.csproj ./
RUN dotnet restore

# Copy everything else and build
COPY . ./
RUN dotnet publish -c Release -o out

EXPOSE 5000
EXPOSE 1433

# Build runtime image
FROM microsoft/dotnet:aspnetcore-runtime
WORKDIR UserApp/userapp
COPY --from=build-env UserApp/userapp/out .
ENTRYPOINT ["dotnet", "userapp.dll"]