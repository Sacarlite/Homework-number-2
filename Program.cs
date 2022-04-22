/* //Задание №1
using System;
class Program
{

 static void Main (string[] args)
{
  int number=0;
    Console.WriteLine("Введите число: ");
  number=Convert.ToInt32(Console.ReadLine());
  number=ShowSecondNumber(number);
  Console.WriteLine(number);

}
static int ShowSecondNumber(int number){
    while(number>100){
    number /=10;
    }
        number %=10;
    return number;
}
}*/
/* //Задание №2
using System;
class Program
{

 static void Main (string[] args)
{
  int number=0;
  Console.WriteLine("Введите число: ");
  number=Convert.ToInt32(Console.ReadLine());
  number=ShowSecondNumber(number);
  Console.WriteLine(number);

}
static int ShowSecondNumber(int number){
    if(number<100){
        Console.WriteLine("Число не содержит 3 разряда");
        Environment.Exit(0);
    }
    while(number>1000){
    number /=10;
    }
        number %=10;
    return number;
}
}*/
/* //Задание №3
using System;
class Program
{

 static void Main (string[] args)
{
  int number=0;
  Console.WriteLine("Введите число: ");
  number=Convert.ToInt32(Console.ReadLine());
  ShowSecondNumber(number);
}
static void ShowSecondNumber(int number){
    if(number<0||number>7){
        Console.WriteLine("Число не может являтся днём недели");
        Environment.Exit(0);
    }
    else if(number==6&&number==7){
            Console.WriteLine("-Выходной");
            
    }
    else{
    Console.WriteLine("-Рабочий день недели");
    }
}}*/