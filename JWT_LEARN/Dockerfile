FROM microsoft/dotnet:2.1-aspnetcore-runtime AS base
WORKDIR /app
EXPOSE 53189
EXPOSE 44365

FROM microsoft/dotnet:2.1-sdk AS build
WORKDIR /src
COPY ["JWT_LEARN/JWT_LEARN.csproj", "JWT_LEARN/"]
RUN dotnet restore "JWT_LEARN/JWT_LEARN.csproj"
COPY . .
WORKDIR "/src/JWT_LEARN"
RUN dotnet build "JWT_LEARN.csproj" -c Release -o /app

FROM build AS publish
RUN dotnet publish "JWT_LEARN.csproj" -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "JWT_LEARN.dll"]