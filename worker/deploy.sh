dotnet publish -c Release "gfa-worker-item" -o ".\dist\item" -r "win-x86"
dotnet publish -c Release "gfa-worker-purchase" -o ".\dist\purchase" -r "win-x86"
dotnet publish -c Release "gfa-worker-vendor" -o ".\dist\vendor" -r "win-x86"

zip  ./dist/worker.zip ./dist/item/* ./dist/purchase/* ./dist/vendor/*

rm -rf dist/item
rm -rf dist/purchase
rm -rf dist/vendor
