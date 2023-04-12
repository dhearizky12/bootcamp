public class FizzBuzz
{
    private int n;
    private Dictionary<int, string> fizzBuzzDict;

    public FizzBuzz(int n)//constructor
    {
        this.n = n;
        fizzBuzzDict = new Dictionary<int, string>();
    }

    public void AddDictionary(int key, string value) {
        fizzBuzzDict[key] = value;
    }

    public void HasilDictionary() {
        Console.WriteLine("Current FizzBuzz dictionary:");
        foreach (KeyValuePair<int, string> kvp in fizzBuzzDict) {
            Console.WriteLine("{0}: {1}", kvp.Key, kvp.Value);
        }
    }

    public void PrintHasilFizzBuzz() {
        string[] arrResults = new string[n]; // untuk menyimpan hasil fizbuz ke dalam tipe data array string untuk wadah/posisi

        for (int i = 1; i <= n; i++) {
            string output = "";
            foreach (KeyValuePair<int, string> kvp in fizzBuzzDict) { //KeyValuePair itu paten, foreach untuk nge-loop semua item dari collection dictionary
               // Console.Write (kvp.Key + " ");
                //Console.WriteLine (kvp.Value);
                if (i % kvp.Key == 0) {
                    output += kvp.Value;
                }
            }
            if (output == "") {
                output = i.ToString();
            }
            arrResults[i-1] = output; // untuk menyimpan output pada posisi indeks array yg di inginkan
        }
        //Console.WriteLine(string.Join("",arrResults));
        // Console.WriteLine(string.Join("--", arrResults));

        foreach (string itemresult in arrResults){
            Console.Write (itemresult + " ,");
        }

    }
}