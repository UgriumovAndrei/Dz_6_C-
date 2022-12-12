//  Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2    1, -7, 567, 89, 223-> 3
Console.WriteLine("Вводите числа с клавиатуры, программа покажет сколько из них положительные а сколько отрицательные; чтобы прервать ввод введите 00");
int countP = 0;
int countO = 0;
string n = "1";
while(n != "00")
{
    n =  Console.ReadLine();
    if(Convert.ToInt32(n)>0)countP++;
    else if(Convert.ToInt32(n)<0)countO++;
    else if (n == "00") break;
    else continue;    
}
Console.Write($" +Числа => {countP}");
Console.Write($" -Числа => {countO}");
