
dotnet publish -c Release "aspnet-core\src\gfa_web.DbMigrator" -o ".\dist\Migrator" -r "linux-x64" /p:PublishSingleFile=true

cp appsettings/mi_appsettings_dev.json dist/Migrator/appsettings.json
cd dist/Migrator
./gfa_web.DbMigrator