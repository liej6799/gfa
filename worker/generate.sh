openapi-generator generate \
   -i https://gfaapi.liej6799.xyz/swagger/v1/swagger.json -g csharp-netcore \
   -o output --skip-validate-spec

dotnet build output/src/Org.OpenAPITools

