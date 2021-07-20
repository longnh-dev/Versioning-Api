FROM mcr.microsoft.com/dotnet/aspnet:5.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY ["Versioning/Versioning.csproj", "Versioning/"]
RUN dotnet restore "Versioning/Versioning.csproj"
COPY . .
WORKDIR "/src/Versioning"
RUN dotnet build "Versioning.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Versioning.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Versioning.dll"]
