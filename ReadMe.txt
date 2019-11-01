
Passos:

    1. Sql.cs
        Modelagem dos dados

    2. SqlBuilder.cs
        Construção dinamica do objeto

    3. SqlBuilderImplCreateSelect.cs
        [implementado]
        metodo de criação

    4. SqlBuilderImplSelectWhere.cs
        [implementado]
        metodo de filtragem

    5. SqlBilderInstance.cs
        Instancia estatica de acesso aos metodos

Observações:

    por ser recursivo, para ser chamado na ordem

    SqlBuilderInstanceSelect.SqlSelect.Create().Where().Build();

    deve ser implementado no caminho inverso.

    seguindo a os passos descritos acima.


    //

    Os arquivos apontados após

    SqlBuilderImplCreateInsert.cs

    SqlBuilderImplInsertReturning.cs


//
//
//

Program.cs

SqlBuilderInstanceSelect.cs         // Instancia
SqlBuilderImplSelectCreate.cs       // método
SqlBuilderImplSelectFields.cs       // método
SqlBuilderImplSelectWhere.cs        // método

SqlBuilderInstanceInsert.cs         // Instancia
SqlBuilderImplInsertCreate.cs       // método
SqlBuilderImplInsertFields.cs       // método
SqlBuilderImplInsertReturning.cs    // método