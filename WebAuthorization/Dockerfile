#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

#Depending on the operating system of the host machines(s) that will build or run the containers, the image specified in the FROM statement may need to be changed.
#For more information, please see https://aka.ms/containercompat

FROM mcr.microsoft.com/dotnet/aspnet:3.1 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:3.1 AS build
WORKDIR /src
COPY ["WebAuthorization/WebAuthorization.csproj", "WebAuthorization/"]
COPY ["Library.BL.Impl/Library.Bl.Impl.csproj", "Library.BL.Impl/"]
COPY ["Library.Entities/Library.Entities.csproj", "Library.Entities/"]
COPY ["Library.Models/Library.Models.csproj", "Library.Models/"]
COPY ["Library.DAL.Abstract/Library.DAL.Abstract.csproj", "Library.DAL.Abstract/"]
COPY ["Library.BI.Abstract/Library.Bl.Abstract.csproj", "Library.BI.Abstract/"]
COPY ["Library.DAL.Impl/Library.DAL.Impl.csproj", "Library.DAL.Impl/"]
RUN dotnet restore "WebAuthorization/WebAuthorization.csproj"
COPY . .
WORKDIR "/src/WebAuthorization"
RUN dotnet build "WebAuthorization.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "WebAuthorization.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "WebAuthorization.dll"]