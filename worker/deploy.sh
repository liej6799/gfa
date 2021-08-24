dotnet publish -c Release "gfa-worker-item" -o ".\dist\item" -r "win-x86"
zip -j ./dist/item.zip ./dist/item/*
rm -rf dist/item