openapi-generator generate \
   -i https://gfaapi.liej6799.xyz/swagger/v1/swagger.json -g rust\
   -o output --skip-validate-spec

mv output/* worker-rust/openapi/
