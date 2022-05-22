java -jar swagger-codegen-cli.jar generate -l java -i https://devapi.gfaweb.xyz/swagger/v1/swagger.json -c config.json -o output/
cp config/build.gradle output/
cp config/pom.xml output/
cd output
mvn install -DskipTests
