public class Cat // parent
{
  private string nama;
  private int age;
  private int countLegs ;
  private int isiperut =1 ;

  public Cat(string nama, int age, int countLegs)
  {
    this.nama = nama;
    this.age = age;
    this.countLegs=countLegs;
    //this.isiperut=isiperut;
  }

  public string Nama
  {
    get { return nama; }
    //set { nama = value; }
  }
  public int Age
  {
    get { return age; }
    set { age = value; }
  }
 public int CountLegs
  {
    get { return countLegs; }
    set { countLegs = value; }
  }

  public int Isiperut
  {
    get { return isiperut; }
  }

  public void Makan() {
    this.isiperut++;
  }

  public void Jalan() {
    this.isiperut--;
  }


}


class Program
{
  public static void Main(string[] args)
  {
    Cat memong = new Cat("memong",2,4);
    Cat cepong = new Cat("cepong",1,4);

    
    Console.WriteLine( memong.Nama + " adalah nama kucingku, dia ber-umur " + memong.Age +" tahun" + ". kakinya berjumlah " + memong.CountLegs +" sekarang isi perutnya " + memong.Isiperut );
    memong.Makan();
    memong.Makan();
    memong.Makan();
  Console.WriteLine( memong.Nama + " adalah nama kucingku, dia ber-umur " + memong.Age +" tahun" + ". kakinya berjumlah " + memong.CountLegs +" sekarang isi perutnya " + memong.Isiperut );
    memong.Jalan();
   Console.WriteLine( memong.Nama + " adalah nama kucingku, dia ber-umur " + memong.Age +" tahun" + ". kakinya berjumlah " + memong.CountLegs +" sekarang isi perutnya " + memong.Isiperut );
  }
}
