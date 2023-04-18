namespace Monopoly{
  class Program{
    static void Main(string[] args){
      Game monopoly = new();
      monopoly.Create();
      monopoly.Start();
    }
  }
}