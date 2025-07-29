using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OppsConcept.Aggregation
{
    public class AggregationDriver
    {
        static void Main(string[] args)
        {
            Professor prof1 = new Professor("Dr. Smith", "Computer Science");
            Professor prof2 = new Professor("Dr. Johnson", "Mathematics");
            
            University university = new University("Harvard University");
            university.AddProfessor(prof1);
            university.AddProfessor(prof2);
            
            university.ShowProfessors();
            
            // Professors can exist independently
            prof1.Teach();
            prof2.Teach();
        }
    }
}
