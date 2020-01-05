FROM mcr.microsoft.com/dotnet/core/sdk:3.1 AS build-env
WORKDIR /app

# Copy csproj and restore as distinct layers
COPY *.sln .
COPY sample-metrics-generator/*.csproj ./sample-metrics-generator/
RUN dotnet restore

# Copy everything else and build
COPY sample-metrics-generator/. ./sample-metrics-generator/
WORKDIR /app/sample-metrics-generator
RUN dotnet publish -c Release -o out

# Build runtime image
FROM mcr.microsoft.com/dotnet/core/aspnet:3.1 AS runtime
WORKDIR /app
COPY --from=build-env /app/sample-metrics-generator/out ./
ENTRYPOINT ["dotnet", "sample-metrics-generator.dll"]
