using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using H1_Extra_Steps_counter.View;

namespace H1_Extra_Steps_counter.Controller
{
	internal class MainController
	{
		MainView view = new MainView();

		/// <summary>
		/// This is the entry point for the class.
		/// The Start() method calls the Calculation() method, which requires an int parameter from the UserInput() method.
		/// </summary>
		internal void Start()
		{
			Calculation(UserInput());
		}

		/// <summary>
		/// This method prompts the user for an int value, to return.
		/// The value represents the amount of steps that the user has taken.
		/// If the input cannot be converted to int, then an error occurs and the user has to try inputting again, due to the infinite while loop.
		/// </summary>
		/// <returns></returns>
		private int UserInput()
		{
			view.Message("How many steps did you take?");

			while(true)
			{
				try
				{
					return int.Parse(view.ReadLine());

				} catch 
				{
					view.Message("Only write whole numbers.");
				}
			}
		}

		/// <summary>
		/// This method converts the steps to kilometers, using simple math.
		/// First we define the step length to 0.762 and then we divide that with the amount of steps.
		/// Then we have the result in meters, which gets divided by 1000 to get kilometers.
		/// The result then gets output in the console.
		/// </summary>
		/// <param name="steps"></param>
		private void Calculation(int steps)
		{
			float stepLength = 0.762f;
			float km = (steps / stepLength) / 1000;

			view.Message($"You have walked {km.ToString("n2")} km");
		}
	}
}
