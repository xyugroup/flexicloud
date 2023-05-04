FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build

WORKDIR /src
COPY ["src/FlexiCloudPay.Web.Host/FlexiCloudPay.Web.Host.csproj", "src/FlexiCloudPay.Web.Host/"]
COPY ["src/FlexiCloudPay.Web.Core/FlexiCloudPay.Web.Core.csproj", "src/FlexiCloudPay.Web.Core/"]
COPY ["src/FlexiCloudPay.Application/FlexiCloudPay.Application.csproj", "src/FlexiCloudPay.Application/"]
COPY ["src/FlexiCloudPay.Core/FlexiCloudPay.Core.csproj", "src/FlexiCloudPay.Core/"]
COPY ["src/FlexiCloudPay.EntityFrameworkCore/FlexiCloudPay.EntityFrameworkCore.csproj", "src/FlexiCloudPay.EntityFrameworkCore/"]
WORKDIR "/src/src/FlexiCloudPay.Web.Host"
RUN dotnet restore 

WORKDIR /src
COPY ["src/FlexiCloudPay.Web.Host", "src/FlexiCloudPay.Web.Host"]
COPY ["src/FlexiCloudPay.Web.Core", "src/FlexiCloudPay.Web.Core"]
COPY ["src/FlexiCloudPay.Application", "src/FlexiCloudPay.Application"]
COPY ["src/FlexiCloudPay.Core", "src/FlexiCloudPay.Core"]
COPY ["src/FlexiCloudPay.EntityFrameworkCore", "src/FlexiCloudPay.EntityFrameworkCore"]
WORKDIR "/src/src/FlexiCloudPay.Web.Host"
RUN dotnet publish -c Release -o /publish --no-restore

FROM mcr.microsoft.com/dotnet/aspnet:7.0
EXPOSE 80
WORKDIR /app
COPY --from=build /publish .
ENTRYPOINT ["dotnet", "FlexiCloudPay.Web.Host.dll"]
