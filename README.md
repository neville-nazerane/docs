# docs
Documentation website on all nugets

## Testing code locally

1. *Add a connection string*
Open command line on migration "Docs.Migration"

```
dotnet user-secrets set connectionStrings:sqlDb "<connection string here>"
```

2. *Update database*
```
dotnet ef database update
```
