//HASHTABLE

using System.Collections;
namespace HasntableExample
{
	class Program
	{
		static void Main(string[] args)
		{

			HashSet
			Hashtable hashtable = new Hashtable();
			//Key-Value pair
			hashtable.Add("ID", 1001);
			hashtable.Add("School", "SD1");
			hashtable.Add("Address", 494949);
			hashtable.Add("City", "SALATIGA");
			hashtable.Add("Email", "yes@yo.com");
			hashtable.Add(125,123);

			foreach(var element in hashtable) {
				Console.WriteLine("print element from 'foreach' var typedata : "  + element);
			}
			
			foreach (object obj in hashtable.Keys) //Use object because the key can be any type
			{
				Console.WriteLine("print using foreach object type data "+ obj + " : " + hashtable[obj]);
			}

			foreach (DictionaryEntry de in hashtable) //DictionaryEntry is a struct of Key and Value
			{
				Console.WriteLine($"print using Dictionary Entry Key: {de.Key}, Value: {de.Value}");
			}
			
			Console.WriteLine("ID : " + hashtable["ID"]);
			Console.WriteLine("School : " + hashtable["School"]);
			Console.WriteLine("Address : " + hashtable["Address"]);
			Console.WriteLine("Email ID : " + hashtable["City"]);
			Console.WriteLine("125 : " + hashtable[125]);
			
			Hashtable hashTable2 = new Hashtable() 
			{
				{"ID", 1001},
				{"School", "SD1"},
				{"Address", 494949},
				{"City", "SALATIGA"},
				{"Email", "yes@yo.com"}
			};
			
			Console.WriteLine("hastable2 Contains : " + hashTable2.Contains("City"));
			Console.WriteLine("hastable2 Contains : " + hashTable2.Contains("SALATIGA"));
			Console.WriteLine("hastable2 Contains Key : " + hashTable2.ContainsKey("City")); 
			Console.WriteLine("hastable2 Contains Value : " + hashTable2.ContainsValue("SALATIGA"));
			
			//hashTable2.Add("ID", 1002); //will error because ID is already added
            hashTable2.Add("ID2", 1005);

	        foreach (DictionaryEntry ab in hashTable2) //awalnya 'new' terus diganti 'ab' new tidak boleh di pakai sebagai instance object baru karena termasuk kata kata dalam sistem
			{
				Console.WriteLine($"print hashTable2 using Dictionary Entry Key: {ab.Key}, Value: {ab.Value}");
			}
           

		 	hashTable2.Remove("City");
            Console.WriteLine("Remove index City from hastable");
            foreach(var element2 in hashTable2) {
				Console.WriteLine("print hashTable2 element from 'foreach' var typedata : "  + element2);
			}
			hashTable2["ID"] = 1003;

             Console.WriteLine("Remove value in key 'ID' from 1001 to 1003");
            foreach(var element2 in hashTable2) {
				Console.WriteLine("print hashTable2 element from 'foreach' var typedata : "  + element2);
			}
		}
	}
} 