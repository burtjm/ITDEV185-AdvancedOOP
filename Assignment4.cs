using System; 
using System.Collections.Generic; 
  
class Program { 
  
     public static void Main() {
      List<int> myList = new List<int>() {
         52,
         12,
         45,
		 1,
		 40
      };
	  
      
	 Console.WriteLine("Operations: ");
	 
	  foreach(int i in myList) {
		Console.WriteLine("Base Numbers: {0}", i );
	  }

      foreach(int i in myList) {
		Console.WriteLine("Tripled: {0}", i*15 );
	  }
	  
	  foreach(int i in myList) {
			Console.WriteLine("Squared: {0}", i*i);
	  }
	 
	  
		Console.ReadKey();
	  
	
	 }
}