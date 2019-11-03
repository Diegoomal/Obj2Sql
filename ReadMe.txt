
Passos:
    1. Sql.cs                           // Modelagem dos dados
    2. SqlBuilder.cs                    // Construção dinamica do objeto
    3. SqlBuilderImplCreateSelect.cs    // implementação do metodo de criação
    4. SqlBuilderImplSelectWhere.cs     // implementação do metodo de filtragem
    5. SqlBilderInstance.cs             // Instancia estatica de acesso aos metodos

Observações:
    por ser recursivo, para ser chamado na ordem
    SqlBuilderInstanceSelect.SqlSelect.Create().Where().Build();
    deve ser implementado no caminho inverso.
    seguindo a os passos descritos acima.

//
//
//

Program.cs

SqlBuilderInstanceInsert.cs         // Instancia
SqlBuilderImplInsertCreate.cs       // implementação do método
SqlBuilderImplInsertFields.cs       // implementação do método
SqlBuilderImplInsertReturning.cs    // implementação do método

SqlBuilderInstanceSelect.cs         // Instancia
SqlBuilderImplSelectCreate.cs       // implementação do método
SqlBuilderImplSelectFields.cs       // implementação do método
SqlBuilderImplSelectWhere.cs        // implementação do método

SqlBuilderInstanceUpdate.cs         // Instancia
SqlBuilderImplUpdateCreate.cs       // implementação do método
SqlBuilderImplUpdateFields.cs       // implementação do método
SqlBuilderImplUpdateWhere.cs        // implementação do método

SqlBuilderInstanceDelete.cs         // Instancia
SqlBuilderImplDeleteCreate.cs       // implementação do método
SqlBuilderImplDeleteWhere.cs        // implementação do método