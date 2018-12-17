FROM microsoft/dotnet:2.1-aspnetcore-runtime AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM microsoft/dotnet:2.1-sdk AS build
WORKDIR /src
COPY RestWhitASPNETUdemy/RestWhitASPNETUdemy.csproj RestWhitASPNETUdemy/
RUN dotnet restore RestWhitASPNETUdemy/RestWhitASPNETUdemy.csproj
COPY . .
WORKDIR /src/RestWhitASPNETUdemy
RUN dotnet build RestWhitASPNETUdemy.csproj -c Release -o /app

FROM build AS publish
RUN dotnet publish RestWhitASPNETUdemy.csproj -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "RestWhitASPNETUdemy.dll"]
