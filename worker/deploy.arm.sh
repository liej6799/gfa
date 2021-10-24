dotnet publish -c Release "gfa-worker-item" -o ".\dist\item" -r "win10-arm64"
dotnet publish -c Release "gfa-worker-purchase" -o ".\dist\purchase" -r "win10-arm64"
dotnet publish -c Release "gfa-worker-vendor" -o ".\dist\vendor" -r "win10-arm64"
dotnet publish -c Release "gfa-worker-sales" -o ".\dist\sales" -r "win10-arm64"

zip  ./dist/worker.arm.zip ./dist/item/* ./dist/purchase/* ./dist/vendor/* ./dist/sales/*

rm -rf dist/item
rm -rf dist/purchase
rm -rf dist/vendor
rm -rf dist/sales
