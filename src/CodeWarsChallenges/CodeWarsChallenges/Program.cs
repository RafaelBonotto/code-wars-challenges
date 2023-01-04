//CODE WARS CHALLENGE - 'L1: Set Alarm' - RESOLVIDO

/*
Escreva uma função chamada setAlarm que recebe dois parâmetros. 
O primeiro parâmetro, Employees , é verdadeiro sempre que você está empregado e o segundo parâmetro, vacation , 
é verdadeiro sempre que você está de férias.
A função deve retornar true se você estiver empregado e não estiver de férias 
(porque essas são as circunstâncias nas quais você precisa definir um alarme). 
Caso contrário, deve retornar falso.

[Test]
Assert.AreEqual(false, Kata.SetAlarm(true, true));
Assert.AreEqual(false, Kata.SetAlarm(false, true));
Assert.AreEqual(true, Kata.SetAlarm(true, false));
Assert.AreEqual(false, Kata.SetAlarm(false, false));
 */


static bool SetAlarm(bool employed, bool vacation)
    => employed && !vacation;

