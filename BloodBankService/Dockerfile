#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["BloodBankService/BloodBank.API.csproj", "BloodBankService/"]
RUN dotnet restore "BloodBankService/BloodBank.API.csproj"
COPY . .
WORKDIR "/src/BloodBankService"
RUN dotnet build "BloodBank.API.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "BloodBank.API.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "BloodBank.API.dll"]