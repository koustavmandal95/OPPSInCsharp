using System;
using System.Collections.Generic;

namespace OppsConcept.Aggregation
{
    class Professor
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
        public List<Professor> Professors { get; private set; }

        public University(string name)
        {
            Name = name;
            Professors = new List<Professor>();
        }

        public void AddProfessor(Professor professor)
        {
            Professors.Add(professor);
            Console.WriteLine($"{professor.Name} has been added to {Name}");
        }

        public void ShowProfessors()
        {
            Console.WriteLine($"Professors at {Name}:");
            foreach (var professor in Professors)
            {
                Console.WriteLine($"- {professor.Name} ({professor.Subject})");
            }
        }
    }
}
