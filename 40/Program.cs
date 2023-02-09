// Задача 40: Напишите программу, 
//которая принимает на вход три числа
// и проверяет, 
// может ли существовать треугольник со сторонами такой длины.
// ❗ Теорема о неравенстве треугольника: 
// каждая сторона треугольника меньше суммы двух других сторон.
Console.Clear();
int InputSides(string massage)
{
    Console.Write(massage);
    int side = Convert.ToInt32(Console.ReadLine());
    return side;
}
bool Triangle(int a, int b, int c)
{
    if (a < b + c && b < a + c && c < a + b ) return true;
    else return false;
}
int sa = InputSides("Введите величину стороны а: ");
int sb = InputSides("Введите величину стороны b: ");
int sc = InputSides("Введите величину стороны c: ");

//Console.WriteLine ($"Это треугольник? {Triangle(sa,sb,sc)}");
Console.WriteLine("Это треугольник?");
if (Triangle(sa, sb, sc) == true) Console.Write("Да");
else Console.Write("Нет");