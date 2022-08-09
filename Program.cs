

/* 2 Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.*/
Console.Write("Введите число x ");
int x = int.Parse(Console.ReadLine());

Console.Write("Введите число y ");
int y = int.Parse(Console.ReadLine());

int max;
int min;

if(x > y) max = x;
   else 
      max = y;

if(x < y) min = x; 
    else 
      min = y;

Console.WriteLine ($"Минимальное число равно {min}");
Console.WriteLine ($"Максимальное число равно {max}");


/* 4 Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.*/

Console.Write("Введите число a ");
int a = int.Parse(Console.ReadLine());

Console.Write("Введите число b ");
int b = int.Parse(Console.ReadLine());

Console.Write("Введите число c ");
int c = int.Parse(Console.ReadLine());

int maxNumber  = a;

if (b>maxNumber) maxNumber = b;
if (c>maxNumber) maxNumber = c;

Console.WriteLine ($"Максимальное число равно {maxNumber}");


/*6 Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).*/

Console.WriteLine("Программа принимает число и выдаёт, является ли число чётным");

Console.Write("Введите число t ");
int inpNumber = int.Parse(Console.ReadLine());

if(inpNumber % 2 == 0){
    Console.WriteLine ($"Введеное число {inpNumber} четное");
}
   else {
        Console.WriteLine ($"Введеное число {inpNumber} нечетное");
   }

/*8 Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.*/   

Console.WriteLine("Программа принимает число (N), а на выходе показывает все чётные числа от 1 до N.");

int i = 1;
bool not = true;
Console.Write("Введите число N ");
int inputNumber = int.Parse(Console.ReadLine());
Console.WriteLine("Чётные числа от 1 до " + inputNumber);
    while (i <= inputNumber){
      if (i % 2 != 1){
        Console.Write(i + ", ");
        not = false;
        }
                i++;
       }
           if (not)
            {
                Console.WriteLine("Нет чётных чисел!");
            }
            
