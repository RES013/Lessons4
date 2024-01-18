// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!"


int c = 5598486;
int d = 13015126;
int s1 = d - c;
Console.Write($"В Москве больше жителей чем в Санкт-Петербурге на: {s1}");

decimal wageForYear = 260548.56895m;
Console.WriteLine($"Зарплата за год {wageForYear:F2}");
decimal wageForMounth = wageForYear / 12;
Console.WriteLine($"Зарплата за месяц {wageForMounth:F2}");
decimal NDFL = wageForMounth * 13 / 100;
Console.WriteLine($"НДФЛ {NDFL}");
decimal wageWhitoutNDFL = wageForMounth - NDFL;
Console.WriteLine($"Зарплата c вычетом НДФЛ {wageWhitoutNDFL:F2}");
