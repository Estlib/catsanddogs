using System;

namespace CatsAndDogsOOP
{
    class Program
    {

        class Pet
        {
            public string name;
            public string colour;
            public int õnnetase;

            public void KuvaAndmed()
            {
                string animaltype = string.Empty;
                if (GetType() == typeof(Cat))
                {
                    animaltype = "kassi ";
                }
                else
                {
                    animaltype = "koera ";
                }
                Console.WriteLine($"{animaltype}nimi:{name} \nkarvkatte värvus:{colour} \nhea tuju tase:{õnnetase}");
            }
        }

        class Dog : Pet
        {
            public Dog(string _name, string _colour)
            {
                name = _name;
                colour = _colour;
                õnnetase = 0;
            }
            public void WaveTail()
            {
                õnnetase += 1;
            }
            public bool Bark()
            {
                Console.WriteLine("auhauhauhauhauhauhauhauh");
                return true;
            }
        }
        class Cat : Pet
        {
            public Cat(string _name, string _colour)
            {
                name = _name;
                colour = _colour;
                õnnetase = 10;
            }
            public void HearBark()
            {
                õnnetase = 0;
            }
            public void Hiss()
            {
                Console.WriteLine("HSSHSHS IT WAS ME, DIO!");
            }
        }

        static void Main(string[] args)
        {
            Cat cat = new Cat("pallike", "valge");
            Dog dog = new Dog("robert", "tumepruun");
            dog.KuvaAndmed();
            cat.KuvaAndmed();
            LineSplit();
            for (int i = 0; i < 10; i++)
            {
                dog.WaveTail();
            }
            dog.Bark();

            bool koerhaukus = dog.Bark();
            if (koerhaukus)
            {
                cat.HearBark();
            }
            if (cat.õnnetase == 0)
            {
                cat.Hiss();
            }
            LineSplit();

            dog.KuvaAndmed();
            cat.KuvaAndmed();



        }

        private static void LineSplit()
        {
            
                Console.WriteLine($"\n===========================\n");
        }
    }
}
