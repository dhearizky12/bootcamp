public abstract class Mobil
{
	protected string nama;  
	public abstract string Klakson();
} 

public class Honda : Mobil
{  
	public Honda() 
	{
		this.nama = "Civic";        
	}    
	
	override public string Klakson()
	{ 
		return "Biimm.....!";
	}
} 