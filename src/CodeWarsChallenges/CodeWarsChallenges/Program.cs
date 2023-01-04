//CODE WARS CHALLENGE - 'Opposites Attract' - RESOLVIDO

//Timmy e Sarah acham que estão apaixonados, mas perto de onde moram, eles só saberão quando colherem uma flor cada um.
//Se uma das flores tiver um número par de pétalas e a outra tiver um número ímpar de pétalas, significa que eles estão apaixonados.
//Escreva uma função que pegue o número de pétalas de cada flor e retorne true se elas estiverem apaixonadas e false se não estiverem.

/*
 * [Test]
 * Assert.AreEqual(true, LoveDetector.lovefunc(1, 4));
 * Assert.AreEqual(false, LoveDetector.lovefunc(2, 2));
 * Assert.AreEqual(true, LoveDetector.lovefunc(0, 1));
 * Assert.AreEqual(false, LoveDetector.lovefunc(0, 0));
 */

static bool LoveFunc(int flor1, int flor2)
{
    if ((flor1 % 2 == 0 && flor2 % 2 != 0) || (flor2 % 2 == 0 && flor1 % 2 != 0))
        return true;

    return false;
}


