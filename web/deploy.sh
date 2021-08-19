
# dotnet publish -c Release "aspnet-core\src\gfa_web.DbMigrator" -o ".\dist\Migrator" -r "linux-x64" /p:PublishSingleFile=true

# cd dist/Migrator
# ./gfa_web.DbMigrator

# cd ../..
# rm -rf dist/Host
# dotnet publish -c Release "aspnet-core\src\gfa_web.HttpApi.Host" -o ".\dist\Host" -r "linux-x64" /p:PublishSingleFile=true

rm -rf dist/Host.zip
zip -j ./dist/Host.zip ./dist/Host/*

resourceGroup="gfa"
appService="gfa-api"
url="https://gfa-api.azurewebsites.net/"

az webapp config appsettings set -n $appService -g $resourceGroup --settings App__ServerRootAddress=$url App__ClientRootAddress=$url App__CorsOrigins=$url

az webapp deployment source config-zip --src "./dist/Host.zip" -n $appService -g $resourceGroup

