using System;
using System.Collections.Generic;

namespace OppsConcept.Aggregation
{
    interface ITeachable
    {
        void Teach();
    }

     class Professor : ITeachable
    {
        public string Name { get; private set; }
        public string Subject { get; private set; }

        public Professor(string name, string subject)
        {
            Name = name;
            Subject = subject;
        }

        public void Teach()
        {
            Console.WriteLine($"{Name} is teaching {Subject}");
        }

    }
    class University
    {
        public string Name { get; private set; }
        public List<ITeachable> Professors { get; private set; }

        public University(string name)
        {
            Name = name;
            Professors = new List<ITeachable>();
        }

        public void AddProfessor(ITeachable professor)
        {
            Professors.Add(professor);
        }

        public void ShowProfessors()
        {
            Console.WriteLine($"Professors at {Name}:");
            foreach (var professor in Professors)
            {
                professor.Teach();
            }
        }
    }
}
