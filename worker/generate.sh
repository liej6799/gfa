java -jar openapi-generator-cli.jar generate \
   -i https://gfaapi.liej6799dev.xyz/swagger/v1/swagger.json -g csharp-netcore \
   -o output --skip-validate-spec

dotnet build output/src/Org.OpenAPITools
