
1. Sql.cs           // Modelagem dos dados
2. SqlBuilder.cs    // Construção dinamica do objeto
3. Create.cs        // implementação do metodo de criação
4. ImplWhere.cs     // implementação do metodo de filtragem
5. Instance.cs      // Instancia estatica de acesso aos metodos

Observações:
    por ser recursivo, para ser chamado na ordem
    Obj2Sql.Select.Instance.Sql.CreateByObject(p).Build();
    deve ser implementado no caminho inverso.
    seguindo a os passos descritos acima.