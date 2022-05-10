java -jar openapi-generator.jar generate \
   -i https://devapi.gfaweb.xyz/swagger/v1/swagger.json -g csharp-netcore \
   -o output --skip-validate-spec

dotnet build output/src/Org.OpenAPITools

