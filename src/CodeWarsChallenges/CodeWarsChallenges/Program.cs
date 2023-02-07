//CODE WARS CHALLENGE - 'Valid Braces.'
/* Escreva uma função que receba uma string de chaves e determine se a ordem das chaves é válida. 
 * Ele deve retornar truese a string for válida e falsese for inválida.
 * Este Kata é semelhante ao Kata Parênteses Válidos , mas apresenta novos caracteres: colchetes []e chaves {}. 
 * Todas as strings de entrada não serão vazias e consistirão apenas em parênteses, colchetes e chaves: ()[]{}.
 * O que é considerado Válido? 
 * Uma sequência de chaves é considerada válida se todas as chaves forem combinadas com a chave correta.
 * 
 * Exemplos
 * "(){}[]"   =>  True
 * "([{}])"   =>  True
 * "(}"       =>  False
 * "[(])"     =>  False
 * "[({})](]" =>  False
 * 
 * Assert.AreEqual(true, Brace.validBraces( "()" ));
 * Assert.AreEqual(false, Brace.validBraces("[(])"));
 */


Console.WriteLine(ValidBraces("[(])"));

static bool ValidBraces(String braces)
{
    const string PARENTESES = "PARENTESES";
    const string COLCHETE = "COLCHETE";
    const string CHAVE= "CHAVE";
    List<string> controle = new();

    foreach (var caracter in braces) 
    {
        if (caracter.Equals('('))
            controle.Add(PARENTESES);

        if (caracter.Equals('{'))
            controle.Add(CHAVE);

        if (caracter.Equals('['))
            controle.Add(COLCHETE);

        if (caracter.Equals(')'))
        {
            var parenteses = controle.FirstOrDefault(x => x.Equals(PARENTESES));
            if(parenteses is not null)
                controle.Remove(parenteses);
        }
        if (caracter.Equals(']'))
        {
            var colchete = controle.FirstOrDefault(x => x.Equals(COLCHETE));
            if (colchete is not null)
                controle.Remove(colchete);
        }
        if (caracter.Equals('}'))
        {
            var chave = controle.FirstOrDefault(x => x.Equals(CHAVE));
            if (chave is not null)
                controle.Remove(chave);
        }
    }
    return !controle.Any();
}

/*//bool abriuParenteses;
    //bool abriuChaves;
    //bool abriuColchetes;
    //if (caracter.Equals('('))
    //    abriuParenteses = true;

    //if (caracter.Equals('{'))
    //    abriuChaves = true;

    //if (caracter.Equals('['))
    //    abriuColchetes = true;*/