
dotnet publish -c Release "aspnet-core\src\gfa_web.DbMigrator" -o ".\dist\Migrator" -r "linux-x64" /p:PublishSingleFile=true

cp aspnet-core/appsettings/mi_appsettings_dev.json dist/Migrator/appsettings.json
cd dist/Migrator
./gfa_web.DbMigrator

cd ../../aspnet-core
docker build -t liej6799/gfaapi .

cd ../angular
docker build -t liej6799/gfaweb .

cd ../
docker-compose up -d