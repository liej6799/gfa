dotnet publish -c Release "gfa-worker-item" -o ".\dist\item" -r "win-x64"
dotnet publish -c Release "gfa-worker-purchase" -o ".\dist\purchase" -r "win-x64"
dotnet publish -c Release "gfa-worker-vendor" -o ".\dist\vendor" -r "win-x64"
dotnet publish -c Release "gfa-worker-sales" -o ".\dist\sales" -r "win-x64"

zip  ./dist/worker.zip ./dist/item/* ./dist/purchase/* ./dist/vendor/* ./dist/sales/*

rm -rf dist/item
rm -rf dist/purchase
rm -rf dist/vendor
rm -rf dist/sales
