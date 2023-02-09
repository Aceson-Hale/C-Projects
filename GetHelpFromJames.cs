using System;
using System.Data.Common;
using System.Diagnostics;
using System.Drawing;
using static Lesson7_ACE2125157.program.Animal;

namespace Lesson7_ACE2125157
{
    internal class program
    {

        internal abstract class Animal
        {
            private string name = "unknown";

            protected string animalName = "unknown";

            public virtual void GetAnimalName()
            {
                return;
            }
            public virtual void setName (string newname)
            {
                this.name = newname;
            }
            abstract public string Speak();
        }
        internal class Dog : Animal
        {
            private string name = "unknown";
            public override void GetAnimalName()
            {
                base.GetAnimalName();

                animalName = "dog";
            }
            override public void setName(string newname)
            {
                this.name = newname;
            }

            public override string Speak()
            {
                return ("Barks");
            }
        }

        internal class Cat : Animal
        {
            private string name = "unknown";

            public Cat()
            {
                animalName = "Cat";
            }

            override public void setName(string newname)
            {
                this.name = newname;
            }

            public override string Speak()
            {
                return ("meows");
            }

        }

        internal class Pig : Animal
        {
            private string name = "unknown";

            public Pig()
            {
                animalName = "Pig";
            }

            override public void setName(string newname)
            {
                this.name = newname;
                return;

            }

            public override string Speak()
            {
                return ("oinks");
            }
        }

        internal class Cow : Animal
        {
            private string name = "unknown";

            public Cow()
            {
                animalName = "Cow";
            }

           override public void setName(string newname)
            {
                this.name = newname;
            }

            public override string Speak()
            {
                return ("moos");
            }

        }




        const int MENU_EnterAnimal = 1;
        const int MENU_AnimalsSpeak = 2;
        const int MENU_EXIT = 3;

        const int MENU_Dog = 1;
        const int MENU_Cat = 2;
        const int MENU_Pig = 3;
        const int MENU_Cow = 4;


        static int numAnimals = 0;
        static Animal[] Animals = new Animal[100];

        static void Main(string[] args)
        {
            bool exitRequested = false;
            do
            {
                PresentMenu();
                int userSelection = GetUserSelection();
                switch (userSelection)
                {
                    case MENU_EnterAnimal:
                        ProcessAnimalSelection();
                        break;

                    case MENU_AnimalsSpeak:
                        ProcessAnimalSounds();
                        break;

                    case MENU_EXIT:
                        exitRequested = true;
                        break;
                }
            } while (!exitRequested);

        }

        static void PresentMenu()
        {
            Console.WriteLine("1. Enter Animal");
            Console.WriteLine("2. Make the animals speak");
            Console.WriteLine("3. Exit");


        }

        static int GetUserSelection()
        {
            int userSelection = 0;
            do
            {
                Console.Write("Selection: ");
                userSelection = int.Parse(Console.ReadLine());
                if (!ValidUserSelection(userSelection))
                    Console.WriteLine("Please make a valid selection!");
            } while (!ValidUserSelection(userSelection));
            return userSelection;
        }

        static bool ValidUserSelection(int userSelection)
        {
            return (userSelection >= 1) && (userSelection <= 3);
        }
        static void ProcessAnimalSelection()
        {
            PresentAnimalMenu();
            int Animalselection = GetAnimalSelection();
            Animal animal = null;
            switch (Animalselection)
            {
                case MENU_Dog:
                    Animals[numAnimals] = new Dog();
                    Dog dog = new Dog();
                    animal = dog;
                    Console.Write("Enter dog's name: ");
                    dog.setName(Console.ReadLine()); 
                    break;

                case MENU_Cat:
                    Cat cat = new Cat();
                    animal = cat;
                    Console.Write("Enter cat's name: ");
                    break;

                case MENU_Pig:
                    Pig pig = new Pig();
                    animal = pig;
                    Console.Write("Enter pig's name: ");
                    break;
            }
            Animals[numAnimals++] = animal;


        }

        static void PresentAnimalMenu()
        {
            Console.WriteLine("1. Dog");
            Console.WriteLine("2. Cat");
            Console.WriteLine("3. Pig");
            Console.WriteLine("4. Cow");
        }

        static int GetAnimalSelection()
        {
            int Animal = 0;
            do
            {
                Console.Write("Animal: ");
                Animal = int.Parse(Console.ReadLine());
                if (!ValidAnimal(Animal))
                    Console.WriteLine("Please select a valid animal!");
            } while (!ValidAnimal(Animal));
            return Animal;

        }

        static bool ValidAnimal(int animal)
        {
            return (animal >= MENU_Dog) && (animal <= MENU_Cow);
        }
        static void ProcessAnimalSounds()
        { 
            for (int i = 0; i < numAnimals; i++)
            Console.WriteLine("The" + Animals[i].GetAnimalName + Animals[i].setName + Animals[i].Speak());
        }



    }
}
