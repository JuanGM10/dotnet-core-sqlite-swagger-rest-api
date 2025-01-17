## Dotnet Core Swagger Sqlite REST API
![.NET Core](https://github.com/maheshkareeya/dotnet-core-sqlite-swagger-rest-api/workflows/.NET%20Core/badge.svg)

`Git Clone`
```
git clone https://github.com/maheshkareeya/dotnet-core-sqlite-swagger-rest-api.git
```
`Change Directory`
```
cd dotnet-core-sqlite-swagger-rest-api
```

`Restore Packages`
```
dotnet restore
```

`Build Command`
```
dotnet build
```

`Run Command`
```
dotnet run
```

`Watch Command`
```
dotnet watch run
```

`Check Url`

http://localhost:5000/swagger

https://localhost:5001/swagger

`Download Required Packages`
```
dotnet add package Microsoft.EntityFrameworkCore
```
```
dotnet add package Microsoft.
```
```
EntityFrameworkCore.Design
```
```
dotnet add package Swashbuckle.AspNetCore
```
```
dotnet tool install --global dotnet-ef
```
```
dotnet tool install --global dotnet-ef --version 3.1.5
```
`Aplicando la nueva migracion`
```
dotnet ef migrations add InitialCreate --context UserContext --output-dir Migrations
```

`Consuma del API Suma`
```
{
  "number1": 12,
  "number2": 8
}
```

`Consuma del API Multiplicar`
```
{
  "number1": 12,
  "number2": 8
}
```
`Aplicar test`
```
dotnet test
```
`Demo`

dotnet ef migrations add InitialCreate --context UserContext --output-dir Migrations
![Screenshot 2020-06-14 at 3 58 37 AM](https://user-images.githubusercontent.com/16520789/84580449-b6e04d00-adf4-11ea-9d95-0b9440cc8939.png)
