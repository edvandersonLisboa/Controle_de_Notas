# Acesse https://aka.ms/customizecontainer para saber como personalizar seu contêiner de depuração e como o Visual Studio usa este Dockerfile para criar suas imagens para uma depuração mais rápida.

# Esta fase é usada durante a execução no VS no modo rápido (Padrão para a configuração de Depuração)
FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS base
USER app
WORKDIR /app
EXPOSE 8080
EXPOSE 8081
ENV ASPNETCORE_URLS=http://+:5016;http://+:8080

# Esta fase é usada para compilar o projeto de serviço
ARG BUILD_CONFIGURATION=Release
ENV ASPNETCORE_ENVIRONMENT=${ASPNETCORE_ENVIRONMENT}
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
ARG BUILD_CONFIGURATION=Release
WORKDIR /src
COPY ["Controle_de_notas/Controle_de_notas.csproj", "Controle_de_notas/"]
COPY ["Applications/Applications.csproj", "Applications/"]
COPY ["Data/Data.csproj", "Data/"]
COPY ["Domain/Domain.csproj", "Domain/"]
COPY ["Shared/Shared.csproj", "Shared/"]
RUN dotnet restore "./Controle_de_notas/Controle_de_notas.csproj"
COPY . .
WORKDIR "/src/Controle_de_notas"
RUN dotnet build "./Controle_de_notas.csproj" -c $BUILD_CONFIGURATION -o /app/build

# Esta fase é usada para publicar o projeto de serviço a ser copiado para a fase final
FROM build AS publish
ARG BUILD_CONFIGURATION=Release
RUN dotnet publish "./Controle_de_notas.csproj" -c $BUILD_CONFIGURATION -o /app/publish /p:UseAppHost=false

# Esta fase é usada na produção ou quando executada no VS no modo normal (padrão quando não está usando a configuração de Depuração)
FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
COPY . ControleDeNotaFiscal.db
ENTRYPOINT ["dotnet", "Controle_de_notas.dll"]