using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_6
{
    public class Green_1
    {
        public abstract class Participant
        {
            //поля
            private string _surname;
            private string _group;
            private string _trainer;
            private double _result;
            private bool _resultFilled;
            protected double _standard;
            private static int _passedCounter;

            //свойства
            public string Surname  => _surname;
            public string Group  => _group;
            public string Trainer  => _trainer;
            public double Result  => _result;
            public static int PassedTheStandard => _passedCounter;
            public bool HasPassed => _resultFilled && _result <= _standard && _result > 0;

            // статический конструктор
            static Participant()
            {
                _passedCounter = 0;
            }

            //конструкторы
            public Participant(string surname, string group, string trainer)
            {
                _surname = surname;
                _group = group;
                _trainer = trainer;
                _result = 0;
                _resultFilled = false;
                _standard = 100;
            }

            //остальные методы
            public void Run(double result)
            {
                if (result <= 0)
                {
                    return;
                }
                if (!_resultFilled)
                {
                    _result = result;
                    _resultFilled = true;
                    if (result <= _standard)
                    {
                        _passedCounter++;
                    }
                }
            }

            public static Participant[] GetTrainerParticipants(Participant[] participants, Type participantType, string trainer)
            {
                int count = 0;
                foreach (var participant in participants)
                {
                    if (participant.GetType() == participantType && participant.Trainer == trainer)
                    {
                        count++;
                    }
                }
                Participant[] result = new Participant[count];
                int index = 0;
                foreach (var participant in participants)
                {
                    if (participant.GetType() == participantType && participant.Trainer == trainer)
                    {
                        result[index] = participant;
                        index++;
                    }
                }
                return result;
            }
            // классы наследники
            public class Participant100M : Participant
            {
                public Participant100M(string surname, string group, string trainer) : base(surname, group, trainer)
                {
                    _standard = 12;
                }
            }

            public class Participant500M : Participant
            {
                public Participant500M(string surname, string group, string trainer) : base(surname, group, trainer)
                {
                    _standard = 90;
                }
            }

            public void Print()
            {
                Console.WriteLine($"{Surname} {Group} {Trainer} {Result} {HasPassed}");
            }
            
        }
    }
}
