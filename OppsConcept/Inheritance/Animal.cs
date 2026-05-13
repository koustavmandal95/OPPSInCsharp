using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OppsConcept.Inheritance
{
    class Animal
{
  public virtual void animalSound()
  {
    Console.WriteLine("The animal makes a sound");
  }
}

class Pig : Animal
{
  public override void animalSound()
  {
    Console.WriteLine("The pig says: wee wee");
  }
}

class Program
{
  static void Main(string[] args)
  {
    Animal myPig = new Pig();
    myPig.animalSound();
  }
}
}