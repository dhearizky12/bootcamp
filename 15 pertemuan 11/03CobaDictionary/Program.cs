//HASHTABLE

using System.Collections;
namespace HasntableExample
{
	class Program
	{
		static void Main(string[] args)
		{
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

			Console.WriteLine("=========================================================================");
            Console.WriteLine("=========================================================================");

            Hashtable hashtableinput = new Hashtable();
            

            Console.WriteLine("Enter key-value pairs (dont type anything to stop input):");

            while (true)
            {
                Console.Write("Key: ");
                string key = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(key))
                {
                    break;
                }

                Console.Write("Value: ");
                string value = Console.ReadLine();

                hashtableinput.Add(key, value);
            }

            Console.WriteLine("\nHashtable:");

            foreach (DictionaryEntry aw in hashtableinput)
            {
                Console.WriteLine($"Key: {aw.Key}, Value: {aw.Value}");
            }
            Console.WriteLine("==========================================");
            Console.WriteLine("\nEnter a key to remove from the Hashtable:");
            string removeKey = Console.ReadLine();
            
            if (hashtableinput.Contains(removeKey))
            {
                hashtableinput.Remove(removeKey);
                Console.WriteLine($"Key {removeKey} has been removed from the Hashtable.");
            }
            else
            {
                Console.WriteLine($"Key {removeKey} not found in Hashtable.");
            }

            Console.WriteLine($"===========================================================");
            Console.WriteLine($"print hasil hastable baru");

               foreach (DictionaryEntry we in hashtableinput)
            {
                Console.WriteLine($"Key: {we.Key}, Value: {we.Value}");
            }
            Console.WriteLine($"===========================================================");
            Console.WriteLine("\nEnter a key to remove the value from the Hashtable:");
            string removeKey2 = Console.ReadLine();

            if (hashtableinput.Contains(removeKey2))
            {
                hashtableinput[removeKey2] = null;
                Console.WriteLine($"Value associated with key {removeKey2} has been removed from the Hashtable.");
            }
            else
            {
                Console.WriteLine($"Key {removeKey2} not found in Hashtable.");
            }

              foreach (DictionaryEntry o in hashtableinput)
            {
                Console.WriteLine($"Key: {o.Key}, Value: {o.Value}");
            }
      }
    }
}

