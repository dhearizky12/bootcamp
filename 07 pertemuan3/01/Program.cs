class AnimalKingdom {
  static void Main(string[] args){
    // Animal hewan = new Animal("hayawan", 3, "Heeee");
    // Console.Write(hewan.name);
    // Console.Write(" ");
    // Console.Write(hewan.age);
    // Console.Write(" ");
    // Console.Write(hewan.sound);

    Cat memong = new Cat("Memong", 3);

    Console.Write(memong.name);
    Console.Write(" ");
    Console.Write(memong.age);
    Console.Write(" ");
    Console.Write(memong.sound);

    Console.WriteLine();

    memong.makeSound();

    Console.WriteLine();
    Console.WriteLine();
    
    Dog dogo = new Dog("Dogo", 5);
    Console.Write(dogo.name);
    Console.Write(" ");
    Console.Write(dogo.age);
    Console.Write(" ");
    Console.Write(dogo.sound);

    Console.WriteLine();

    dogo.makeSound();
  }
}

// Child classes (let make 2 subclasses)
class Cat: Animal {
  public Cat(string name, int age): base(name, age, "Meoow") {

  }
}

class Dog: Animal {
  public Dog(string name, int age): base(name, age, "Wuff"){

  }

  public override void makeSound(){
    Console.WriteLine("Hai im " + this.name + ", i said " + this.sound);
  }
}


// Parent Class
class Animal {
  public string name;
  public int age;
  public string sound;

  public Animal(string name, int age, string sound){
    this.name = name;
    this.age = age;
    this.sound = sound;
  }

  public virtual void makeSound(){
    Console.WriteLine(this.name + " said " + this.sound);
  }
}
