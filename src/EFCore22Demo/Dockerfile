
FROM mcr.microsoft.com/dotnet/core/sdk:2.2-bionic AS build-env
WORKDIR /app

# Copy everything else and build
COPY . ./
RUN dotnet publish src/EFCore22Demo/EFCore22Demo.csproj --framework netcoreapp2.2 --runtime linux-x64 -c Release -o /app/src/EFCore22Demo/out

# Build runtime image
FROM mcr.microsoft.com/dotnet/core/runtime:2.2-bionic

WORKDIR /app
COPY --from=build-env /app/src/EFCore22Demo/out/ .

ENTRYPOINT ["dotnet", "EFCore22Demo.dll"]