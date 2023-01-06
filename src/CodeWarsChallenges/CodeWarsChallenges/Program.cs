//CODE WARS CHALLENGE - 'Detect Pangram' - RESOLVIDO
/*
 * Um pangrama é uma frase que contém todas as letras do alfabeto pelo menos uma vez. 
 * Por exemplo, a frase "The quick brown fox jumps over the lazy dog." é um pangrama, 
 * porque usa as letras AZ pelo menos uma vez (as letras maiúsculas e minúsculas são irrelevantes).
 * Dada uma string, detecte se é ou não um pangrama. Retorna True se for, False se não. Ignore números e pontuação.
 * 
 * [Test]
 * Assert.AreEqual(true, Kata.IsPangram("The quick brown fox jumps over the lazy dog."));
*/

var bolean = IsPangram2("The quick brown fox jumps over the lazy dog.");
Console.WriteLine(bolean);

static bool IsPangram(string str)
{
    var alfab = "ABCDEFGHIJKLMNOPQRSTUVXWYZ";
    var arr = alfab.ToCharArray().ToList();

    foreach (var item in alfab)
        foreach (var character in str)
            if (character.ToString().ToUpper().Equals(item.ToString().ToUpper()))
                arr.Remove(item);

    return !arr.Any();
}

static bool IsPangram2(string str)
    => str.Where(ch => Char.IsLetter(ch)).Select(ch => Char.ToLower(ch)).Distinct().Count() == 26;