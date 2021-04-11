FROM mcr.microsoft.com/dotnet/aspnet:3.1 AS base
WORKDIR /app
EXPOSE 5001

FROM mcr.microsoft.com/dotnet/sdk:3.1 AS build
WORKDIR /src
COPY ["Assignment2.csproj", "./"]
RUN dotnet restore "Assignment2.csproj"
COPY . .
WORKDIR "/src/."
RUN dotnet build "Assignment2.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Assignment2.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Assignment2.dll"]
