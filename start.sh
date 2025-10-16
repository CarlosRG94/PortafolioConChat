#!/bin/bash
set -e

echo "Restaurando paquetes..."
dotnet restore

echo "Compilando..."
dotnet build --configuration Release

echo "Publicando..."
dotnet publish "Portafolio\Portafolio.csproj" -c Release -o out

echo "Iniciando aplicación..."
# Railway exporta PORT como variable de entorno; la usamos aquí
export ASPNETCORE_URLS="http://0.0.0.0:${PORT:-5000}"
dotnet out/Portafolio.dll
