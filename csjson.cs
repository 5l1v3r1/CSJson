using System; 
using System.Collections.Generic; 
using System.Text;

namespace CSJson
{
	class Program
	{
		public static void Main(string[] args)
		{
			if (args.Length == 0)
			{
				Console.WriteLine("You did not specify a file!");
			}
			else if (args.Length == 1)
			{
				#if DebugConfig  
        				Console.WriteLine("Debug Mode:\nOnly 1 file specified... continuing...");  
				#endif 
			}
			else
			{
				Console.WriteLine("Dont specify more than 1 file!");
			}
		}
	}
}
