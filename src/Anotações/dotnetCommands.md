> Adicionar nova soluçao

```dotnet new solution -o Manager.sln```

> Adicionar novo projeto de API

```dotnet new webapi -o Manager.API```

> Adicionar novo projeto biblioteca de classes

```
  dotnet new classlib -o Manager.Domai

  dotnet new classlib -o Manager.Services

  dotnet new classlib -o Manager.Infra
```

OBS: A camada Core fica as coisas em comum das camadas como extensão, regex, etc.

```dotnet new classlib -o Manager.Core```

> Adicionar FluentValidation

```dotnet add package FluentValidation```

> Buildar o projeto

```dotnet build```

> Instalar o Entity Framework

```dotnet add package Microsoft.EntityFrameworkCore```

```dotnet add package Microsoft.EntityFrameworkCore.SqlServer```

```dotnet add package Microsoft.EntityFrameworkCore.Tools```

```dotnet add package Microsoft.EntityFrameworkCore.Design```

> Adicionar um projeto na soluçao
```
  dotnet sln ..\..\Manager.sln add .\Manager.API.csproj
  dotnet sln ..\..\Manager.sln add .\Manager.Domain.csproj
  dotnet sln ..\..\Manager.sln add .\Manager.Services.csproj
  dotnet sln ..\..\Manager.sln add .\Manager.Infra.csproj
  dotnet sln ..\..\Manager.sln add .\Manager.Core.csproj
```

> Adicionar uma referencia de projeto em outro
```
  dotnet add .\Manager.Infra\Manager.Infra.csproj reference '..\Manager.Domain\Manager.Domain.csproj'
  dotnet add '.\Manager.Domain\Manager.Domain.csproj' reference '.\Manager.Core\Manager.Core.csproj'
  dotnet add .\Manager.Services\Manager.Services.csproj reference '..\Manager.Domain\Manager.Domain.csproj'
  dotnet add .\Manager.Services\Manager.Services.csproj reference '..\Manager.Core\Manager.Core.csproj'
  dotnet add .\Manager.Services\Manager.Services.csproj reference '..\Manager.Infraestructure\Manager.Infraestructure.csproj'
```

> Instalar ferramenta do ef migrations

```dotnet tool install --global dotnet-ef --version 5.0.1```

> Cria a migration

```dotnet ef migrations add InitialMigration```

> Atualiza o banco de dados com a migration

```dotnet ef database update```

> Remove migration

```dotnet ef migrations remove```



