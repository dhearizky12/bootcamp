namespace myProgram;

class Program {
    static void Main() {
        Vehicle myMotor = new Vehicle();
        DeskripsiMotor Honda_beat = myMotor.MyMethod(0, 2);
        Console.WriteLine(Honda_beat.NumberOfDoors);
        Console.WriteLine(Honda_beat.NumberOfWheels);


}
class Vehicle {
    public Vehicle () {
        Console.WriteLine("Vehicle Constructor");
    }
    public DeskripsiMotor MyMethod(int numberOfDoors, int numberOfWheels)
    {
        DeskripsiMotor myMotor = new();
        myMotor.NumberOfDoors = numberOfDoors;
        myMotor.NumberOfWheels = numberOfWheels;
        return myMotor;
    }

    public DeskripsiMotor MotorEditor(DeskripsiMotor MyMotor2) {
        //MotorEditor MyMotor2 = new();
        MyMotor2.NumberOfDoors = 5;
        MyMotor2.NumberOfWheels = 5;
        return MyMotor2;
    }

}

class DeskripsiMotor {
    public int NumberOfDoors { get; set; }
    public int NumberOfWheels { get; set; }
    public DeskripsiMotor() {
        Console.WriteLine("Deskripsi Motor constructor");
    }
}

public DeskripsiMotor? Metod (T1 Key){
    
}

}