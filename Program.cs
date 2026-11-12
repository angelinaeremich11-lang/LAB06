using LAB06;

Fraction f1 = new Fraction(12, 345);
Fraction f2 = new Fraction(5, 7);
Fraction f3 = new Fraction(2);

Console.WriteLine($"{f1}");
Console.WriteLine($"{f2}");
Console.WriteLine($"{f3}");

Console.WriteLine($"{f1} + {f2} = {f1 + f2}");
Console.WriteLine($"{f1} - {f2} = {f1 - f2}");
Console.WriteLine($"{f1} * {f2} = {f1 * f2}");
Console.WriteLine($"{f1} / {f2} = {f1 / f2}");

Fraction f4 = new Fraction(1, 800);
Fraction f5 = new Fraction(2, 400);
Console.WriteLine($"{f4} + {f5} = {f4 + f5}");