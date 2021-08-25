dotnet publish -c Release "gfa-worker-item" -o ".\dist\item" -r "win-x86"
dotnet publish -c Release "gfa-worker-purchase" -o ".\dist\purchase" -r "win-x86"
zip -j ./dist/item.zip ./dist/item/*
zip -j ./dist/purchase.zip ./dist/purchase/*

rm -rf dist/item
rm -rf dist/purchase
