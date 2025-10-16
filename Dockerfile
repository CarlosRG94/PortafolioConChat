# Etapa de build
FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build

WORKDIR /app
COPY . .

RUN dotnet restore "Portafolio/Portafolio.csproj"
RUN dotnet build "Portafolio/Portafolio.csproj" -c Release
RUN dotnet publish "Portafolio/Portafolio.csproj" -c Release -o out

# Etapa de runtime
FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS runtime
WORKDIR /app
COPY --from=build /app/out .

# Configurar puerto para Railway
ENV ASPNETCORE_URLS=http://0.0.0.0:${PORT}
ENTRYPOINT ["dotnet", "Portafolio.dll"]
