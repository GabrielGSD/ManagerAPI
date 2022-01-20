# Atalhos
**-** Cria uma propriedade (prop + tab)

```public int MyProperty { get; set; }```

**-** Cria uma propriedade com a entidade fechada (propg + tab)

```public int MyProperty { get; private set; }```


# Anotações
**-** O construtor ```protected User(){}``` é uma particularidade do EF, ela não é publica pois é importante ela estar aberta apenas para o EF e não para qualquer pessoa.

**-** Regex para email: ```@"^([\w-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([\w-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$"```

**-** DTO é usado para fazer a comunição entre a API e serviço 

**-** A camada de serviço é quem deve manipular as regras de negócio
