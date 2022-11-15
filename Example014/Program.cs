/*

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

*/
//Сумма чисел от 1 до n
/*int SumFor(int n)
{
 int result = 0;
 for (int i = 1; i <= n; i++) result += i;
 return result;
}
int SumRec(int n)
{
 if (n == 0) return 0;
 else return n + SumRec(n - 1);
}
Console.WriteLine(SumFor(10)); // 55
Console.WriteLine(SumRec(10)); // 55
*/
//Факториал числа
/*int FactorialFor(int n)
{
 int result = 1;
 for (int i = 1; i <= n; i++) result *= i;
 return result;
}
int FactorialRec(int n)
{
 if (n == 1) return 1;
 else return n * FactorialRec(n - 1);
}
Console.WriteLine(FactorialFor(10)); // 3628800
Console.WriteLine(FactorialRec(10)); // 3628800
*/
//Вычислить аn
/*int PowerFor(int a, int n)
{ int result = 1;
 for (int i = 1; i <= n; i++) result *= a;
 return result;
}
int PowerRec(int a, int n)
{ //return n == 0 ? 1 : PowerRec(a, n - 1) * a;
 if (n == 0) return 1;
 else return PowerRec(a, n - 1) * a;
}



Console.WriteLine(PowerFor(2, 10)); // 1024
Console.WriteLine(PowerRec(2, 10)); // 1024
*/
//перебор слов
/*int n=1;
void FindWords(string alphabet, char[] word, int length = 0)
{
 if (length == word.Length)
 {
 Console.WriteLine($"{n++} {new String(word)}"); return;
 }
 for (int i = 0; i < alphabet.Length; i++)
 {
 word[length] = alphabet[i];
 FindWords(alphabet, word, length + 1);
 }
}
FindWords("аисв", new char[2]);
*/
//Как посмотреть содержимое папки?
/*void CatalogInfo(string path, string indent = "")
{
 DirectoryInfo catalogs = new DirectoryInfo(path);
 foreach (var currentCatalog in catalogs.GetDirectories())
 {
 Console.WriteLine($"{indent}{currentCatalog.Name}");
 CatalogInfo(currentCatalog.FullName, indent + " ");
 }
 foreach (var item in catalogs.GetFiles())
 {
 Console.WriteLine($"{indent}{item.Name}");
 }
}
string path = @"C:\Users\vasileva\Desktop\examples_2\Example001_helloConsole";
CatalogInfo(path);
*/

//Игра в пирамидки
/*void Towers(string with = "1", string on = "3", string some = "2", int count = 3)
{
 if (count > 1) Towers(with, some, on, count - 1);
 Console.WriteLine($"{with} >> {on}");
 if (count > 1) Towers(some, on, with, count - 1);
}
Towers();
*/
/*string emp = String.Empty;
string[] tree = { emp, "/", "*", "10", "-", "+", emp, emp, "4", "2", "1", "3" };
//                       0 1 2 3 4 5 6 7 8 9 10 11
void InOrderTraversal(int pos = 1)
{
 if (pos < tree.Length)
 {
 int left = 2 * pos;
 int right = 2 * pos + 1;
 if (left < tree.Length && !String.IsNullOrEmpty(tree[left])) InOrderTraversal(left);
 Console.WriteLine(tree[pos]);
 if (right < tree.Length && !String.IsNullOrEmpty(tree[right])) InOrderTraversal(right);
 }
}

InOrderTraversal();
*/


/*Console.Clear();
Console.Write("Введите N: ");
int n=int.Parse(Console.ReadLine());
Console.WriteLine(PrintNumbers(1,n));
// цифры от 1 до N
string PrintNumbers(int start, int end)
{
    if (start == end) return start.ToString();
    return (start + " " + PrintNumbers(start + 1, end));
}
//сумма цифр
int SumNumbers(int number)
{
    if (number == 0) return 0;
    return (number % 10 + SumNumbers(number / 10));
}
*/
//дополнительно

/*void fill(Dictionary<string, string> numbers){
    for(int i=0;i<5;i++){
        string[] str = Console.ReadLine().Split();
        numbers[str[0]]=str[1];
        numbers[str[1]]=str[0];
    }
    string name = Console.ReadLine();
    Console.WriteLine("Синонимом к введенному имени будет: "+numbers[name]);
     
}
void vibori(Dictionary<string, int> numbers){
    for(int i=0;i<5;i++){
        string[] str = Console.ReadLine().Split();
        if(numbers.ContainsKey(str[0]))
            numbers[str[0]]=numbers[str[0]]+int.Parse(str[1]);
        else
            numbers[str[0]]=int.Parse(str[1]);
    }
    foreach(var num in numbers)
    {
        Console.WriteLine($"{num.Key} - {num.Value}");
    }  
}
void premission(){
    Dictionary<string, List<string>> file = new Dictionary<string, List<string>>();
    for(int i=0;i<3;i++){
        string[] str = Console.ReadLine().Split();
        file[str[0]]= new List<string>();
        for(int j=1;j<str.Length;j++)
            file[str[0]].Add(str[j]);
    }
    foreach(var f in file)
    {
        Console.WriteLine($"{f.Key} - {String.Join(" ", f.Value)}");
    } 
}

var Access = new Dictionary<string, string>()
{
    { "read", "R"},
    { "write", "W"},
    { "execute", "X"}
};

Dictionary<string, string> numbers = new Dictionary<string, string>();
Dictionary<string, int> numbers2 = new Dictionary<string, int>();

//fill(numbers);
//vibori(numbers2);
premission();
*/

/*
int k = 0;
string FillNumbers(int n){
    if (n==1) return (k+1).ToString();
    else 
    {
        k++;
        return (k+" " + FillNumbers(n-1));
    }     
}
*/
//n=5
//F(5)=5+F(4)
//F(4)=4+F(3)
//F(3)=3+F(2)
//F(2)=2+F(1)=
//F(1)=1
//Console.WriteLine(FillNumbers(5));
/*
string FillNumbers(int begin2, int end){
    if(end==begin2) return end.ToString();
    else
         return (begin2+" " + FillNumbers(begin2+1,end));
}
Console.WriteLine(FillNumbers(4,8));
*/
/*
string FindDictionary(int n){
    Dictionary<string,string> dict = new Dictionary<string, string>(); 
    for(int i=0;i<n;i++){
        Console.Write("Введите пары слов: ");
        string[] names = Console.ReadLine().Split();
        dict.Add(names[0],names[1]);
        dict.Add(names[1],names[0]);
    }
    Console.Write("Введите имя: ");
    string choose_name = Console.ReadLine();
    return dict[choose_name];
}
Console.Write("Введите число слов: ");
int kol = int.Parse(Console.ReadLine());
Console.WriteLine(FindDictionary(kol));
*/
/*void FindMaxString(int n){
    Dictionary<string,int> dict = new Dictionary<string, int>(); 
    for(int i=0;i<n;i++){
        string[] words = Console.ReadLine().Split();
        foreach(var word in words){
            if (dict.ContainsKey(word)){
                dict[word]=dict[word]+1;
            }
            else
                dict.Add(word,1);
        }
    }
    Console.WriteLine();
    int max = 1;
    string name=String.Empty;
    foreach(var el in dict){
        if(el.Value>max){
            max=el.Value;
            name=el.Key;
        }  
        Console.WriteLine($"Слово {el.Key} встретилось {el.Value}");
    }
    Console.WriteLine();
    Console.WriteLine(name);
}

Console.Write("Введите число строк: ");
int kol = int.Parse(Console.ReadLine());
FindMaxString(kol);

*/
//ДЗ.Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
/*Console.Clear();
Console.Write("Введите N: ");
int n = int.Parse(Console.ReadLine());
string FillNumbers(int n)
{
    if (n == 1) return n.ToString();
    else
    {
        return (n + " " + FillNumbers(n - 1));
    }
}
Console.WriteLine(FillNumbers(n));
*/
//Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N. С помощью рекурсии!!!

/*Console.Write("Введите N: ");
int n = int.Parse(Console.ReadLine());
Console.Write("Введите M: ");
int m = int.Parse(Console.ReadLine());
int sum = 0;
if (n > m)
{
    Console.WriteLine($"Сумма элементов =  {SumNumbers(n, m)}");
}
else
{
    Console.WriteLine($"Сумма элементов =  {SumNumbers(m, n)}");
}

int SumNumbers(int max, int min)
{
    if (min > max)
    {
        return sum;
    }
    else
    {
        sum = sum + max;
        return (SumNumbers(max - 1, min));
    }
}
*/

//Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n. С помощью рекурсии!!!