// Вид 1 Ничего не принимает и ничего не возвращает
/*void Method1()
{
    Console.WriteLine("Автор Васильева Анна");
}
Method1(); //вызов метода
*/

//Вид 2 Ничего не возвращают, но принимают аргументы
/*void Method2(string msg) // в (какое-то количество аргументов)
{
    Console.WriteLine(msg);
}
 Method2("Текст сообщения");
 */

 /*void Method21(string msg, int count) 
{
    int i = 0; // количество сообщений которые будут передаваться в метод
    while(i<count)
    {
        Console.WriteLine(msg);
        i++;
    }
}
//Method21("Текст сообщения", 4); // указывает сколько раз будет выводится слово
Method21(count: 4, msg:"Текст "); //именованный метод. Можно менять местами
*/

//Вид 3 Что-то возвращают, но ничего не принимают

/*int Method3()    //обязательно указывается тип данных, которые ожидаем
{
    return DateTime.Now.Year;
}
int year = Method3(); // сюда положен результат работы
Console.WriteLine(year);
*/

//Вид 4 Что-то принимают, Что-то возвращают

/*string Method4(int count, string c) // взвращаем строку, передает каунт и строка с
{
int i=0;        // строку с друг за дружкой компановать каунт раз
//string rezult = ""; // переменная куда кладем результат конечный// "" пустая строка
string rezult = string.Empty; // пустая строка (это чтобы всем было понятно)
    while (i<count){
        rezult = rezult+c;
        i++;
    }
    return rezult;
}
string res = Method4(10,"asdf"); //Чтобы вызвать, нужно создать нужную переменную, указать значение и текст, который мы будем склеивать 10 раз
Console.WriteLine(res);
*/

/*string Method4(int count, string c) 
{   
string rezult = string.Empty; 
for(int i=0;i<count;i++)  // 1.Инициализация счетчика 2 Проверка условия 3 Инкримент
{
    rezult = rezult+c;
          }
    return rezult;
}
string res = Method4(10,"asdf"); 
Console.WriteLine(res);
*/

/*for(int i=2;i<=10;i++)
{
    for(int j=2;j<=10;j++)
    {
        Console.WriteLine($"{i}x{j}={i*j}");
    }
    Console.WriteLine();
}
*/

//Дан текст. В тексте нужно все пробелы заменить черточками,
//маленькие буквы “к” заменить большими “К”, а большие “С” заменить маленькими “с”.

string text = "— Я думаю, — сказал князь, улыбаясь, — что, "
            + "ежели бы вас послали вместо нашего милого Винценгероде,"
            + "вы бы взяли приступом согласие прусского короля."
            + "Вы так красноречивы. Вы дадите мне чаю?";

// string s = "qwerty"
//             012
// s[3] // r

/*string Replace(string text, char oldValye, char newValye)
{
    string rezult = String.Empty;
    int length = text.Length;
    for (int i = 0; i < length; i++) // пробегаемся от нулевого символа до конца, делая следующее действие
    {
        if(text[i] == oldValye) rezult = rezult + $"{newValye}"; // если текущий символ совпал с тем символом, который мы хотим заменить, то в результат мы должны вложить новый символ
        else rezult = rezult + $"{text[i]}"; // если же совпадений не обнаружено, то в наш результат нужно добавить текущий символ, который как раз и был
    }

    return rezult;
}

string newText = Replace(text, ' ', '|' ); // берем текст и что на что сменить
Console.WriteLine(newText);
Console.WriteLine();
newText = Replace(newText, 'к', 'К' ); // берем текст и что на что сменить
Console.WriteLine(newText);
Console.WriteLine();
newText = Replace(newText, 'С', 'с' ); // берем текст и что на что сменить
Console.WriteLine(newText);
*/


//Сортировка массива

int[] arr = {1,3,8,1,2,6,9,7,5};  //определяем массив
void PrintArray(int[] array) //приходит массив
{
    int count = array.Length;  //получение количества элиментов

    for(int i = 0; i < count; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

void SelectionSort(int[] array)
{
   for(int i = 0; i < array.Length - 1; i++) 
   {
    int minPosition = i;
    for(int j = i+1; j < array.Length ; j++)
    {
        if(array[j]<array[minPosition]) minPosition = j;

    }
    int temporary = array[i];
    array[i] = array[minPosition];
    array[minPosition] = temporary;

   }
}

PrintArray(arr);
SelectionSort(arr);

PrintArray(arr);
