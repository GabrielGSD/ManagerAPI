-> Adicionar nova soluçao

```dotnet new solution -o Manager.sln```

-> Adicionar novo projeto de API

```dotnet new webapi -o Manager.API```

-> Adicionar novo projeto biblioteca de classes

```dotnet new classlib -o Manager.Domain```

```dotnet new classlib -o Manager.Services```

```dotnet new classlib -o Manager.Infra```

OBS: A camada Core fica as coisas em comum das camadas como extensão, regex, etc.

```dotnet new classlib -o Manager.Core```

-> Adicionar FluentValidation

```dotnet add package FluentValidation```

-> Buildar o projeto

```dotnet build```



