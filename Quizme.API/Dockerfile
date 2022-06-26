FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["Quizme.API/Quizme.API.csproj", "Quizme.API/"]
RUN dotnet restore "Quizme.API/Quizme.API.csproj"
COPY . .
WORKDIR "/src/Quizme.API"
RUN dotnet build "Quizme.API.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Quizme.API.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Quizme.API.dll"]
