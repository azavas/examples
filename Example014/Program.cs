using System.Linq;

string text = "(1,2) (2,3) (4,5) (6,7)"
                .Replace("(", "")//убрали скобки
                .Replace(")", "")
                ;
Console.WriteLine(text);
var data = text.Split(" ")//сплит -разделитель
            .Select(item => item.Split(','))//преобразовали в массив
            .Select(e => (x: int.Parse(e[0]), y: int.Parse(e[1]))) //скобки остались, но строки преобразованы в числа
            .Where(e => e.x % 2 == 0)
            .Select(point => (point.x * 10, point.y))
            .ToArray();

for (int i = 0; i < data.Length; i++)
{
    Console.WriteLine(data[i]);
    //for(int k=0; k<data[i].Length; k++){
    //  Console.WriteLine(data[i][k]);
    //}
    //Console.WriteLine();
    //Console.WriteLine(data[i].x*10);
}