FROM microsoft/dotnet:2.1.300-sdk AS build-env
COPY . ./
RUN dotnet publish -c Release -o out

FROM microsoft/azure-functions-dotnet-core2.0:2.0
ENV AzureWebJobsStorage=<MyAzureStorageConnectionString>
COPY --from=build-env /Functions/out /home/site/wwwroot