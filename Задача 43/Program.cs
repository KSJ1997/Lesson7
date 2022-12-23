// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых,
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)


Console.Write("Задайте точку b1 для первой прямой: ");
int  B1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Задайте точку k1 для первой прямой: ");
int  K1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Задайте точку b2 для второй прямой: ");
int  B2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Задайте точку k2 для второй прямой: ");
int K2 = Convert.ToInt32(Console.ReadLine());

double IntersectionOfTwoLines(int b1, int k1, int b2, int k2)
    {
        double X1 = k1 - k2;
        double X2 = b1 - b2; 
        double x = X2 / -X1;
        double xAnswer = Math.Round(x, 1);
        return xAnswer;
    }

double x = IntersectionOfTwoLines(B1,K1,B2,K2);
double y1 = K1 * x + B1;
double straighty1 = Math.Round(y1, 1);
double y2 = K2 * x + B2;
double straighty2 = Math.Round(y2, 1); 

Console.WriteLine($"Точки пересечения двух пярмых ({straighty1}; {straighty2}) ");
