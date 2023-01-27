// Задача 20
// Напишите программу, которая
// 1. принимает на вход координаты двух 
// точек и находит расстояние между ними в 2D 
// пространстве.

// A(3,6); B(2,1) -> 5,09
// A(7,5); B(1,-1) -> 7,21

int InsertPosition(string text)
{
	Console.WriteLine(text);
	int pos = Convert.ToInt32(Console.ReadLine());
	return pos;
}
int x1 = InsertPosition("Введите координату x первой точки");
int y1 = InsertPosition("Введите координату y первой точки");

int x2 = InsertPosition("Введите координату x второй точки");
int y2 = InsertPosition("Введите координату y второй точки");

double LenghtLine(int xpos1, int ypos1, int xpos2, int ypos2)
{
	int temp = (xpos2 - xpos1)*(xpos2 - xpos1) + (ypos2 -ypos1)*(ypos2 -ypos1);
	return Math.Sqrt(temp);
}
double rez = LenghtLine(x1,y1,x2,y2);

double rezRound = Math.Round(rez,2,MidpointRounding.ToZero);

Console.WriteLine($"Расстояние между точками равно {rezRound}");

