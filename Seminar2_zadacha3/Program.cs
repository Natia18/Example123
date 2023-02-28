// Напишите программу, которая принимает на вход цифру, 
// обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

Console.Write("Введите цифру обозначающую день недели : ");
int number = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(IsHoliday(number) ? "Да" : "Нет");

bool IsHoliday(int day)
{
    return day == 6 || day == 7;
}