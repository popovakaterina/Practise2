// Массивы и функции
using System; // Нужен чтобы взаиможействовать с библиотеками (Стандартная библиотека)
class Program //  Название объекта (Program) ,в котором мы работаем
{
    static void WriteSeelct(string[] namesArray) //Создана функция Селект
    {
            for (int i = 0; i < namesArray.Length-1; i++ )
        {
            Console.Write(i+1 + " - " + namesArray[i] + ", ");
        }
        Console.WriteLine(namesArray.Length + " - " + namesArray[namesArray.Length - 1]+ ".");
    }
    static void SelectRace() // функция выбора расы
    {
        string[] nameRace = {"Люди","Эльфы","Гномы","Феи"};
    
        WriteSeelct(nameRace); //Вызвана функция селект в функции выбора расы
        Console.WriteLine("Укажите вашу расу: ");
        int indexRace = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Ваша раса: " + nameRace[indexRace-1]);
    }
    static void SelectClass() // функция выбора расы
    {
        string[] nameClass = {"Черодей","Воин","Земледел","Зельевар"};
    
        WriteSeelct(nameClass); //Вызвана функция селект в функции выбора класса
        Console.WriteLine("Укажите ваш класс: ");
        int indexClass = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Ваш класс: " + nameClass[indexClass-1]);
    }
     static void SelectSex() // функция выбора пола
    {
        string[] nameSex = {"Женский","Мужской"};
    
        WriteSeelct(nameSex); //Вызвана функция селект в функции выбора пола
        Console.WriteLine("Укажите ваш пол: ");
        int indexSex = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Ваш класс: " + nameSex[indexSex-1]);
    }
    static void Main (string[] args) // Первоначальная функция всегда Main, аргумент можеьт быть пустой
    {
       SelectRace(); // Вызов функции раса
       SelectClass(); // Вызов функции класс
       SelectSex();// Вызов функции пол
    }
}