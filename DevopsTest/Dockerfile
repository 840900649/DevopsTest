FROM mcr.microsoft.com/dotnet/core/sdk:3.1-buster AS build
COPY *.csproj ./app/
WORKDIR /app
#自定义第三方源
#RUN dotnet nuget add source http://nexus.adq.xin -n nuget.org
RUN dotnet restore

COPY . ./
RUN dotnet publish -c release  -o out

FROM mcr.microsoft.com/dotnet/core/aspnet:3.1-buster-slim AS runtime
EXPOSE 80
WORKDIR /app
COPY --from=build /app/out ./