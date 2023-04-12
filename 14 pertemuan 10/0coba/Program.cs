//Array modif by me

namespace ArrayDemo
{
	class Program
	{
		static void Main()
		{
			Animal hewan1 = new Animal("kucing");
			Animal hewan2 = new Animal("bebek");
			Animal hewan3 = new Animal("itik");
			Animal hewan4 = new Animal("ular");
            Animal hewan5 = new Animal("anjing");

			Animal[] objectAnimal1 = { hewan1, hewan2, hewan3, hewan4, hewan5 };
			Animal[] objectAnimal2 = new Animal[5];
			Animal[] objectAnimal3 = new[] { hewan1, hewan2, hewan3, hewan4, hewan5 };
			objectAnimal2[0] = hewan1;
			objectAnimal2[1] = hewan2;
			objectAnimal2[2] = hewan3;
			objectAnimal2[3] = hewan4;
            objectAnimal2[4] = hewan5;

			Console.WriteLine("Nama Hewan ke {0} = {1}", 0 ,objectAnimal1[0].AnimalName);
			Console.WriteLine("Nama Hewan ke {0} = {1}", 1 ,objectAnimal1[1].AnimalName);
			Console.WriteLine("Nama Hewan ke {0} = {1}", 3 ,objectAnimal1[3].AnimalName);
			Console.WriteLine("Nama Hewan ke {0} = {1}", 2 ,objectAnimal1[2].AnimalName);
            Console.WriteLine("Nama Hewan ke {0} = {1}", 4 ,objectAnimal1[4].AnimalName);

            Console.WriteLine("============================================================");

           //for (int i = objectAnimal1.Length -1 ; i>=0 ; i--)
            for (int i = objectAnimal1.Length ; i>=0 ; i--)
			{
				Console.WriteLine($"print (terbalik) objectAnimal1 indeks ke[{i}] = {objectAnimal1[i].AnimalName}");
			}
          
            Console.WriteLine("============================================================");

            //for (int i = 0; i <= objectAnimal2.Length - 1; i++)
            for (int i = 0; i <= objectAnimal2.Length; i++)
			{
				Console.WriteLine($"hasil print objectAnimal2 indeks ke[{i}] = {objectAnimal2[i].AnimalName}");
			}
            Console.WriteLine("============================================================");

            foreach (var animal1 in objectAnimal1 )
			{
				Console.WriteLine($"hasil foreach objectanimal1 = {animal1.AnimalName}");
			}
          

            Array.Sort(objectAnimal1, (x, y) => x.AnimalName.CompareTo(y.AnimalName));
			Array.Sort(objectAnimal3, CompareAnimalByName);

      Console.WriteLine("============================================================");
			foreach (var animalcompare1 in objectAnimal1)
			{
				Console.WriteLine($"hasil compare dengan objectAnimal1 = {animalcompare1.AnimalName}");
			}
            Console.WriteLine("============================================================");
            	foreach (var animalcompare2 in objectAnimal3)
			{
				Console.WriteLine($"hasil compare dengan objectAnimal3 = {animalcompare2.AnimalName}");
			}
        }
		static int CompareAnimalByName (Animal x, Animal y)
		{
			return x.AnimalName.CompareTo(y.AnimalName); //Using quicksort
		}
    
        }
    }

	class Animal
	{
		public string AnimalName { get; set; }
		public Animal (string name) // constructor
		{
			AnimalName = name;
		}
	} 
