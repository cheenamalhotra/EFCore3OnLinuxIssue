
FROM mcr.microsoft.com/dotnet/core/sdk:3.0 AS build-env
WORKDIR /app

# Copy everything else and build
COPY . ./
RUN dotnet publish src/EFCore3Demo/EFCore3Demo.csproj --framework netcoreapp3.0 --runtime linux-x64 -c Release -o /app/src/EFCore3Demo/out --configfile ./src/EFCore3Demo/Properties/NuGet.config

# Build runtime image
FROM mcr.microsoft.com/dotnet/core/runtime:3.0

WORKDIR /app
COPY --from=build-env /app/src/EFCore3Demo/out/ .

ENTRYPOINT ["dotnet", "EFCore3Demo.dll"]