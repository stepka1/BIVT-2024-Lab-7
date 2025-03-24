using System;
using System.Linq;

namespace Lab_7
{
    public class Green_4
    {
        // Класс Participant
        public class Participant
        {
            // Поля
            private string _name;
            private string _surname;
            private double[] _jumps;

            // Свойства
            public string Name => _name;
            public string Surname => _surname;
            public double[] Jumps
            {
                get
                {
                    if (_jumps == null) return null;
                    double[] copy = new double[_jumps.Length];
                    Array.Copy(_jumps, copy, _jumps.Length);
                    return copy;
                }
            }
            public double BestJump
            {
                get
                {
                    if (_jumps == null || _jumps.Length == 0) return 0;
                    return _jumps.Max();
                }
            }

            // Конструкторы
            public Participant(string name, string surname)
            {
                _name = name;
                _surname = surname;
                _jumps = new double[3]; // Максимум 3 прыжка
            }

            // Методы
            public void Jump(double result)
            {
                if (_jumps == null) return;
                for (int i = 0; i < _jumps.Length; i++)
                {
                    if (_jumps[i] == 0)
                    {
                        _jumps[i] = result;
                        return;
                    }
                }
            }

            public static void Sort(Participant[] array)
            {
                if (array == null) return;
                for (int i = 0; i < array.Length - 1; i++)
                {
                    for (int j = 0; j < array.Length - 1 - i; j++)
                    {
                        if (array[j].BestJump < array[j + 1].BestJump)
                        {
                            (array[j], array[j + 1]) = (array[j + 1], array[j]);
                        }
                    }
                }
            }

            public void Print()
            {
                Console.WriteLine($"{Name} {Surname} {BestJump}");
            }
        }

        // Абстрактный класс Discipline
        public abstract class Discipline
        {
            // Поля
            private string _name;
            private Participant[] _participants;

            // Свойства
            public string Name => _name;
            public Participant[] Participants
            {
                get
                {
                    if (_participants == null) return null;
                    Participant[] copy = new Participant[_participants.Length];
                    Array.Copy(_participants, copy, _participants.Length);
                    return copy;
                }
            }

            // Конструктор
            public Discipline(string name)
            {
                _name = name;
                _participants = new Participant[0]; // Инициализация пустого массива
            }

            // Методы
            public void Add(Participant participant)
            {
                Array.Resize(ref _participants, _participants.Length + 1);
                _participants[_participants.Length - 1] = participant;
            }

            public void Add(params Participant[] participants)
            {
                int oldLength = _participants.Length;
                Array.Resize(ref _participants, oldLength + participants.Length);
                Array.Copy(participants, 0, _participants, oldLength, participants.Length);
            }

            public void Sort()
            {
                Participant.Sort(_participants);
            }
            // Абстрактный метод для повторной попытки
            public abstract void Retry(int index);

            public void Print()
            {
                Console.WriteLine($"Дисциплина: {Name}");
                foreach (var participant in _participants)
                {
                    participant.Print();
                }
            }
        }

        // Класс LongJump
        public class LongJump : Discipline
        {
            // Конструктор
            public LongJump() : base("Long jump") { }

            // Переопределение метода Retry
            public override void Retry(int index)
            {
                if (index < 0 || index >= Participants.Length)
                    return;

                Participant participant = Participants[index];
                double bestJump = participant.BestJump;

                // Добавляем две новые попытки
                participant.Jump(bestJump);
                participant.Jump(bestJump);
            }
        }

        // Класс HighJump
        public class HighJump : Discipline
        {
            // Конструктор
            public HighJump() : base("High jump") { }

            // Переопределение метода Retry
            public override void Retry(int index)
            {
                if (index < 0 || index >= Participants.Length)
                {
                    Console.WriteLine("Некорректный индекс участника.");
                    return;
                }

                Participant participant = Participants[index];
                double[] jumps = participant.Jumps;

                // Сбрасываем результат последнего прыжка
                if (jumps.Length > 0)
                {
                    jumps[jumps.Length - 1] = 0; // Сбрасываем последний прыжок
                }
            }
        }
    }
}