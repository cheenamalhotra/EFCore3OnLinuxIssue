
FROM mcr.microsoft.com/dotnet/core/sdk:3.0 AS build-env
WORKDIR /app

# Copy everything else and build
COPY . ./
RUN dotnet publish src/DemoProject/DemoProject.csproj --framework netcoreapp3.0 --runtime linux-x64 -c Release -o /app/src/DemoProject/out

# Build runtime image
FROM mcr.microsoft.com/dotnet/core/runtime:3.0

WORKDIR /app
COPY --from=build-env /app/src/DemoProject/out/ .

ENTRYPOINT ["dotnet", "DemoProject.dll"]