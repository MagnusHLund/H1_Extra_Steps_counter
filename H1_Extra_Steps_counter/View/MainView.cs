using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H1_Extra_Steps_counter.View
{
	internal class MainView
	{
		/// <summary>
		/// This method outputs a custom message based on the parameter
		/// </summary>
		/// <param name="message"></param>
		internal void Message(string message)
		{
            Console.WriteLine(message);
        }

		/// <summary>
		/// This method returns a Console.ReadLine().
		/// </summary>
		/// <returns></returns>
		internal string ReadLine()
		{
			return Console.ReadLine();
		}
	}
}
