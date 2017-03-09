// to make the programm working this is required 'using System;'
using System;

public class CodeReview

{
  public int Parse(object o)

  {
    // using just 'return int.Parse(o.ToString());' - returns integer in case when object has integer numbers or string with numbers
    // but if object has another type of data like float or string it returns unhandled exception
    // like FormatException or OverflowException
    // so to catch them and return integer or 0 better to use this
    try {
      int num = int.Parse(o.ToString());			
      return num;
    }
    catch (FormatException) {			
      return 0;
    }
    catch (OverflowException) {
      return 0;  
    }
  }

  public string Concat(string[] lines)

  {
  // instead of using this 2 lines
    /*
      string result;

      for(int i = 0; i < lines.Length; i++)
    */
  // I think better to use this
    string result = ""; // for initialization or compiler shows an error 'usnig result without initialization'

    foreach(string s in lines) {
        result += s;
    }
    return result;
  }

}

// and to see all new results we need to add this class with Main
class Review {
	
	public static void Main() {
    
		CodeReview Rev = new CodeReview();
		//< Examples of using method Parse()
    Console.WriteLine("{0}", Rev.Parse("555"));          // shows '555'
		Console.WriteLine("{0}", Rev.Parse("hello"));        // shows '0'
		Console.WriteLine("{0}", Rev.Parse("2147483648"));   // shows '0'
		Console.WriteLine("{0}", Rev.Parse(777));            // shows '777'
		Console.WriteLine("{0}", Rev.Parse(1.57));           // shows '0'
    //>
    //< Examples of using method Concat()
		string[] arr = {
			"Hello", " World!"
		};
		string res = Rev.Concat(arr);		
		Console.WriteLine("\n\n{0}", res);
		//>
	}

}
