// mengkonversi string ke int
string intString = "12345";
int varInt = int.Parse(intString);
Console.WriteLine (varInt);

// mengkonversi string ke double
string doubleString = "12345.678";
double varDouble = double.Parse(doubleString);
Console.WriteLine (varDouble);

// mengkonversi string ke boolean
string boolString = "true";
bool varBool = bool.Parse(boolString);
Console.WriteLine (varBool);


//mencoba tryparse
string intString1 = "f12345"; 
int varInt1;

bool berhasilParsing = int.TryParse(intString1, out varInt1);

if (berhasilParsing) 
{ 
   Console.WriteLine("parsing berhasil =" + varInt1); 
} 
else 
{ 
   Console.WriteLine("Parsing gagal");
}


//mencoba tryparse
string intString2 = "12345"; 
int varInt2;

bool berhasilParsing2 = int.TryParse(intString2, out varInt2);
Console.WriteLine("Parsing = " + berhasilParsing2);


if (berhasilParsing2) 
{ 
   Console.WriteLine("parsing berhasil = " + varInt2); 
} 
else 
{ 
   Console.WriteLine("Parsing gagal ke 2");
}

Console.ReadLine();