swagger-codegen generate -l java -i https://gfaapi.liej6799.xyz/swagger/v1/swagger.json -c config.json -o output/
cp config/build.gradle output/
cp config/pom.xml output/
cd output
mvn install -DskipTests
