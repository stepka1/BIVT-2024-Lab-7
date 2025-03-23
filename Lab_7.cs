using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Green_1:");

            Green_1.Participant[] participants_1 = new Green_1.Participant[10];

            participants_1[0] = new Green_1.Participant.Participant100M("Степанова", "Спартак", "Зайцев");
            participants_1[1] = new Green_1.Participant.Participant100M("Кристиан", "Русь", "Жарков");
            participants_1[2] = new Green_1.Participant.Participant100M("Чехова", "Юность", "Свиридов");
            participants_1[3] = new Green_1.Participant.Participant100M("Зайцева", "Быки", "Свиридов");
            participants_1[4] = new Green_1.Participant.Participant100M("Смирнова", "Русь", "Павлов");

            participants_1[5] = new Green_1.Participant.Participant500M("Кристиан", "Химик", "Распутин");
            participants_1[6] = new Green_1.Participant.Participant500M("Иванова", "Байкал", "Иванов");
            participants_1[7] = new Green_1.Participant.Participant500M("Жаркова", "Югра", "Жарков");
            participants_1[8] = new Green_1.Participant.Participant500M("Чехова", "Метеор", "Тихонов");
            participants_1[9] = new Green_1.Participant.Participant500M("Степанова", "Энергия", "Свиридов");

            participants_1[0].Run(41.94);  
            participants_1[1].Run(55.29);  
            participants_1[2].Run(72.01);  
            participants_1[3].Run(140.78);  
            participants_1[4].Run(95.45);  
            participants_1[5].Run(79.63);  
            participants_1[6].Run(29.67);  
            participants_1[7].Run(18.41);  
            participants_1[8].Run(140.87);  
            participants_1[9].Run(75.52);  

            for (int i = 0; i < participants_1.Length; i++)
            {
                participants_1[i].Print();
            }

            Console.WriteLine($"Passed the standard: {Green_1.Participant.PassedTheStandard}");
            Console.WriteLine();

            Console.WriteLine("Участники забега на 100 метров, тренирующиеся у Свиридова:");
            var trainerParticipants = Green_1.Participant.GetTrainerParticipants(
                participants_1,
                typeof(Green_1.Participant.Participant100M),
                "Свиридов"
            );

            foreach (var participant in trainerParticipants)
            {
                participant.Print();
            }
            Console.WriteLine();
            
            //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            
            Console.WriteLine("Green_2:");

            Green_2.Student[] students_1 = new Green_2.Student[10];
            students_1[0] = new Green_2.Student("Лев", "Петров");
            students_1[1] = new Green_2.Student("Алевтина", "Козлова");
            students_1[2] = new Green_2.Student("Полина", "Смирнова");
            students_1[3] = new Green_2.Student("Иван", "Смирнов");
            students_1[4] = new Green_2.Student("Алиса", "Смирнова");
            students_1[5] = new Green_2.Student("Юрий", "Чехов");
            students_1[6] = new Green_2.Student("Степан", "Кристиан");
            students_1[7] = new Green_2.Student("Анастасия", "Полевая");
            students_1[8] = new Green_2.Student("Никита", "Зайцев");
            students_1[9] = new Green_2.Student("Оксана", "Лисицына");

            students_1[0].Exam(3);
            students_1[0].Exam(4);
            students_1[0].Exam(4);
            students_1[0].Exam(4);

            students_1[1].Exam(5);
            students_1[1].Exam(3);
            students_1[1].Exam(4);
            students_1[1].Exam(2);

            students_1[2].Exam(5);
            students_1[2].Exam(4);
            students_1[2].Exam(2);
            students_1[2].Exam(5);

            students_1[3].Exam(4);
            students_1[3].Exam(5);
            students_1[3].Exam(4);
            students_1[3].Exam(5);

            students_1[4].Exam(4);
            students_1[4].Exam(3);
            students_1[4].Exam(5);
            students_1[4].Exam(4);

            students_1[5].Exam(3);
            students_1[5].Exam(4);
            students_1[5].Exam(3);
            students_1[5].Exam(4);

            students_1[6].Exam(5);
            students_1[6].Exam(5);
            students_1[6].Exam(5);
            students_1[6].Exam(3);

            students_1[7].Exam(4);
            students_1[7].Exam(3);
            students_1[7].Exam(4);
            students_1[7].Exam(4);

            students_1[8].Exam(5);
            students_1[8].Exam(5);
            students_1[8].Exam(2);
            students_1[8].Exam(3);

            students_1[9].Exam(4);
            students_1[9].Exam(5);
            students_1[9].Exam(4);
            students_1[9].Exam(4);

            Green_2.Student.SortByAvgMark(students_1);

            for (int i = 0; i < students_1.Length; i++)
            {
                students_1[i].Print();
            }

            Console.WriteLine($"Количество отличников: {Green_2.Student.ExcellentAmount}");
            Console.WriteLine();

            //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

            Console.WriteLine("Green_3:");

            Green_3.Student[] students_2 = new Green_3.Student[10];

            students_2[0] = new Green_3.Student("Ярослав", "Козлов");
            students_2[1] = new Green_3.Student("Сергей", "Свиридов");
            students_2[2] = new Green_3.Student("Екатерина", "Батова");
            students_2[3] = new Green_3.Student("Николай", "Луговой");
            students_2[4] = new Green_3.Student("Ирина", "Кристиан");
            students_2[5] = new Green_3.Student("Полина", "Зайцева");
            students_2[6] = new Green_3.Student("Мирослав", "Степанов");
            students_2[7] = new Green_3.Student("Игорь", "Чехов");
            students_2[8] = new Green_3.Student("Александра", "Павлова");
            students_2[9] = new Green_3.Student("Максим", "Свиридов");

            students_2[0].Exam(4);
            students_2[0].Exam(3);
            students_2[0].Exam(4);

            students_2[1].Exam(4);
            students_2[1].Exam(4);
            students_2[1].Exam(3);

            students_2[2].Exam(3);
            students_2[2].Exam(2);
            students_2[2].Exam(0);

            students_2[3].Exam(4);
            students_2[3].Exam(3);
            students_2[3].Exam(3);

            students_2[4].Exam(5);
            students_2[4].Exam(4);
            students_2[4].Exam(5);

            students_2[5].Exam(4);
            students_2[5].Exam(4);
            students_2[5].Exam(3);

            students_2[6].Exam(3);
            students_2[6].Exam(4);
            students_2[6].Exam(4);

            students_2[7].Exam(4);
            students_2[7].Exam(4);
            students_2[7].Exam(2);

            students_2[8].Exam(3);
            students_2[8].Exam(4);
            students_2[8].Exam(5);

            students_2[9].Exam(3);
            students_2[9].Exam(3);
            students_2[9].Exam(4);

            Green_3.Student.SortByAvgMark(students_2);

            Console.WriteLine("Список студентов (отсортированный по среднему баллу):");
            for (int i = 0; i < students_2.Length; i++)
            {
                students_2[i].Print();
            }
            Console.WriteLine();

            var expelledStudents = Green_3.Commission.Expel(ref students_2);
            Console.WriteLine("Исключенные студенты:");
            foreach (var student in expelledStudents)
            {
                student.Print();
            }
            Console.WriteLine();

            if (expelledStudents.Length > 0)
            {
                Console.WriteLine("Восстанавливаем студента:");
                expelledStudents[0].Print();
                Green_3.Commission.Restore(ref students_2, expelledStudents[0]);
            }

            Green_3.Commission.Sort(students_2);

            Console.WriteLine("\nОбновленный список студентов (отсортированный по ID):");
            foreach (var student in students_2)
            {
                student.Print();
            }
            Console.WriteLine();

            //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            
            Console.WriteLine("Green_4:");

            // Создаем дисциплину "Long jump"
            var longJump = new Green_4.LongJump();

            // Добавляем участников
            longJump.Add(new Green_4.Participant("Анастасия", "Свиридова"));
            longJump.Add(new Green_4.Participant("Кристина", "Батова"));
            longJump.Add(new Green_4.Participant("Мирослав", "Пономарев"));

            // Добавляем результаты прыжков
            longJump.Participants[0].Jump(4.92); longJump.Participants[0].Jump(0.08); longJump.Participants[0].Jump(9.10);
            longJump.Participants[1].Jump(1.02); longJump.Participants[1].Jump(9.58); longJump.Participants[1].Jump(9.25);
            longJump.Participants[2].Jump(2.27); longJump.Participants[2].Jump(8.03); longJump.Participants[2].Jump(4.15);

            // Сортируем участников
            longJump.Sort();

            // Выводим информацию
            Console.WriteLine("Участники Long jump (отсортированные по лучшему прыжку):");
            longJump.Print();

            // Повторная попытка для первого участника
            Console.WriteLine("\nПовторная попытка для Анастасии Свиридовой:");
            longJump.Retry(0);

            // Выводим обновленную информацию
            Console.WriteLine("\nУчастники Long jump после повторной попытки:");
            longJump.Print();

            // Создаем дисциплину "High jump"
            var highJump = new Green_4.HighJump();

            // Добавляем участников
            highJump.Add(new Green_4.Participant("Анастасия", "Свиридова"));
            highJump.Add(new Green_4.Participant("Кристина", "Батова"));
            highJump.Add(new Green_4.Participant("Мирослав", "Пономарев"));

            // Добавляем результаты прыжков
            highJump.Participants[0].Jump(1.80); highJump.Participants[0].Jump(1.85); highJump.Participants[0].Jump(1.90);
            highJump.Participants[1].Jump(1.95); highJump.Participants[1].Jump(1.92); highJump.Participants[1].Jump(1.98);
            highJump.Participants[2].Jump(1.75); highJump.Participants[2].Jump(1.80); highJump.Participants[2].Jump(1.85);

            // Сортируем участников
            highJump.Sort();

            // Выводим информацию
            Console.WriteLine("\nУчастники High jump (отсортированные по лучшему прыжку):");
            highJump.Print();

            // Повторная попытка для первого участника
            Console.WriteLine("\nПовторная попытка для Анастасии Свиридовой:");
            highJump.Retry(0);

            // Выводим обновленную информацию
            Console.WriteLine("\nУчастники High jump после повторной попытки:");
            highJump.Print();
            Console.WriteLine();

            //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            
            Console.WriteLine("Green_5");

            // Создаем группы
            Green_5.EliteGroup bntm = new Green_5.EliteGroup("БНТМ (Elite)");
            Green_5.SpecialGroup bek = new Green_5.SpecialGroup("БЭК (Special)");
            Green_5.EliteGroup bpm = new Green_5.EliteGroup("БПМ (Elite)");

            // Студенты БНТМ
            Green_5.Student[] bntmStudents =
            {
                new Green_5.Student("Дарья", "Павлова"),
                new Green_5.Student("Светлана", "Жаркова"),
                new Green_5.Student("Игорь", "Пономарев"),
                new Green_5.Student("Максим", "Кристиан"),
                new Green_5.Student("Григорий", "Козлов"),
                new Green_5.Student("Игорь", "Зайцев"),
                new Green_5.Student("Полина", "Павлова"),
                new Green_5.Student("Савелий", "Павлов"),
                new Green_5.Student("Иван", "Козлов"),
                new Green_5.Student("Инна", "Батова")
            };
            int[][] bntmMarks =
            {
                new [] {3, 3, 5, 4, 3}, new [] {4, 4, 4, 3, 4}, new [] {5, 3, 4, 4, 4}, new [] {4, 4, 5, 5, 3},
                new [] {4, 5, 2, 5, 5}, new [] {2, 5, 5, 3, 4}, new [] {5, 4, 3, 4, 3}, new [] {3, 3, 4, 4, 3},
                new [] {5, 5, 4, 3, 3}, new [] {5, 3, 3, 5, 3}
            };
            for (int i = 0; i < bntmStudents.Length; i++)
            {
                foreach (var mark in bntmMarks[i])
                {
                    bntmStudents[i].Exam(mark);
                }
                bntm.Add(bntmStudents[i]);
            }

            // Студенты БЭК
            Green_5.Student[] bekStudents =
            {
                new Green_5.Student("Татьяна", "Лисицына"), new Green_5.Student("Анастасия", "Лисицына"), new Green_5.Student("Виктор", "Полевой"),
                new Green_5.Student("Алевтина", "Батова"), new Green_5.Student("Лев", "Жарков"), new Green_5.Student("Лев", "Чехов"),
                new Green_5.Student("Юрий", "Зайцев"), new Green_5.Student("Марк", "Петров"), new Green_5.Student("Александра", "Чехова"),
                new Green_5.Student("Анастасия", "Батова")
            };
            int[][] bekMarks =
            {
                new [] {3, 3, 4, 2, 3}, new [] {3, 2, 5, 5, 3}, new [] {2, 4, 4, 5, 2},
                new [] {3, 3, 5, 5, 3}, new [] {5, 2, 3, 4, 4}, new [] {3, 4, 2, 4, 4},
                new [] {4, 3, 3, 4, 3}, new [] {5, 5, 4, 3, 3}, new [] {5, 4, 3, 3, 5},
                new [] {3, 5, 5, 3, 5}
            };

            for (int i = 0; i < bekStudents.Length; i++)
            {
                foreach (var mark in bekMarks[i])
                    bekStudents[i].Exam(mark);
                bek.Add(bekStudents[i]);
            }

            // Студенты БПМ
            Green_5.Student[] bpmStudents =
            {
                new Green_5.Student("Оксана", "Зайцева"), new Green_5.Student("Юрий", "Пономарев"), new Green_5.Student("Юрий", "Тихонов"),
                new Green_5.Student("Степан", "Зайцев"), new Green_5.Student("Марина", "Смирнова"), new Green_5.Student("Светлана", "Кристиан"),
                new Green_5.Student("Алевтина", "Жаркова"), new Green_5.Student("Инна", "Смирнова"), new Green_5.Student("Алиса", "Сидорова"),
                new Green_5.Student("Татьяна", "Чехова")
            };
            int[][] bpmMarks =
            {
                new [] {3, 4, 3, 3, 3}, new [] {5, 2, 5, 4, 2}, new [] {4, 4, 4, 3, 5},
                new [] {4, 3, 3, 4, 4}, new [] {3, 2, 3, 4, 5}, new [] {5, 3, 2, 4, 2},
                new [] {5, 5, 3, 3, 3}, new [] {3, 5, 4, 3, 3}, new [] {4, 3, 4, 2, 3},
                new [] {4, 4, 5, 3, 5}
            };
            for (int i = 0; i < bpmStudents.Length; i++)
            {
                foreach (var mark in bpmMarks[i])
                    bpmStudents[i].Exam(mark);
                bpm.Add(bpmStudents[i]);
            }

            // Сортируем группы по среднему баллу
            Green_5.Group[] groups = { bntm, bek, bpm };
            Green_5.Group.SortByAvgMark(groups);

            // Выводим результаты
            foreach (var group in groups)
            {
                Console.WriteLine($"{group.Name}: {group.AvgMark:F2}");
            }
        }
    }
}

