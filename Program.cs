// string subject = "Программирование";

// foreach (char letter in subject)
// {
//     Console.WriteLine(letter);
// }
// for (int count = 0; count < subject.Length; count++)
// {
//     Console.WriteLine(count);
// }

// int[] grades = { 4, 5, 3, 5, 4 };
// int count = 0;
// double mid = 0;
// foreach (int grade in grades)
// {
//     Console.WriteLine(grade);
// }
// for (int i = 0; i < grades.Length; i++)
// {
//     count += grades[i];
//     mid = ((double)count / grades.Length);
// }
// Console.WriteLine(count);
// Console.WriteLine(mid);

// string[] students = { "Аня", "Ярослав", "Вика" };
// int count = 0;

// foreach (string student in students)
// {
//     count++;
//     Console.WriteLine(student);
//     Console.WriteLine(count);
// }

// using System.Drawing;

// int[] points = { 10, 20, 15 };

// for (int i = 0; i < points.Length; i++)
// {
//     points[i] = points[i] + 5;
// }

// for (int i = 0; i < points.Length; i++)
// {
//     Console.WriteLine(points[i]);
// }


// int[] numbers = { 10, 20, 30, 40, 50 };
//         int sum = 0;

//         foreach (int num in numbers)
//         {
//             Console.WriteLine(num);
//             sum += num;
//         }
//         Console.WriteLine($"Сумма чисел: {sum}\n");

// string[] daysOfWeek = { "Понедельник", "Вторник", "Среда", "Четверг", "Пятница", "Суббота", "Воскресенье" };

//         foreach (string day in daysOfWeek)
//         {
//             Console.WriteLine($"{day}!");
//         }

// Console.Write("Введите свою фамилию: ");
// string surname = Console.ReadLine()!.Trim();
// if (string.IsNullOrEmpty(surname)) {
// Console.WriteLine("Фамилия не введена. Завершение работы.");
// return;
// }
// Random rnd = new(surname.GetHashCode() + DateTime.Now.DayOfYear);
// var assigned = Enumerable.Range(1, 10)
// .OrderBy(_ => rnd.Next())
// .Take(2)
// .OrderBy(x => x)
// .ToList();
// Console.WriteLine($"Задачи: №{assigned[0]} и №{assigned[1]}");

// string[] participants = { "Анна", "Иван", "Елена"};

//         int index = 1;

//         foreach (string name in participants)
//         {
//             Console.WriteLine($"{index}. {name}");
//             index++;
//         }

int[] grades = { 3, 5, 4, 5, 2, 5, 4, 5 };

        int countOfFives = 0;

        foreach (int grade in grades)
        {
            if (grade == 5)
            {
                countOfFives++; 
            }
        }

        Console.WriteLine($"Количество оценок равных 5: {countOfFives}");