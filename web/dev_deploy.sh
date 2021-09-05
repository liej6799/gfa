cd aspnet-core
docker build -t liej6799/gfamigrator -f Dockerfile.mi.dev .
docker run -t liej6799/gfamigrator

docker build -t liej6799/gfaapi -f Dockerfile.dev .

cd ../angular
docker build -t liej6799/gfaweb -f Dockerfile.dev .

cd ../
docker-compose up -d