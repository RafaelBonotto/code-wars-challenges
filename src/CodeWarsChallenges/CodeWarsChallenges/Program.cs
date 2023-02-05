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


static bool validBraces(String braces)
{
    bool abriuParenteses;
    bool abriuChaves;
    bool abriuColchetes;

    foreach (var caracter in braces) 
    {
        if (caracter.Equals('('))
            abriuParenteses = true;

        if (caracter.Equals('{'))
            abriuChaves = true;

        if (caracter.Equals('['))
            abriuColchetes = true;
    }


    return false;
}