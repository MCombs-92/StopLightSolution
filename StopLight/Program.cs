using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StopLight {
	class Program {

		enum TrafficLight {
			Red = 1, Green, Yellow
		};

		void Displaytrafficlight(TrafficLight Color) {
			switch(Color) {
				case TrafficLight.Red:
					Console.WriteLine("Red");
					break;
				case TrafficLight.Green:
					Console.WriteLine("Green");
					break;
				case TrafficLight.Yellow:
					Console.WriteLine("Yellow");
					break;
			}
		}

		void run() {
			for (int idx = 0; idx < 3; idx++) {
				int coloridx = 1; // color is red
				TrafficLight color = (TrafficLight) coloridx;
				Displaytrafficlight(color);
				color = (TrafficLight)(++coloridx);
				Displaytrafficlight(color);
				color = (TrafficLight)(++coloridx);
				Displaytrafficlight(color);
			}
		}

		static void Main(string[] args) {

			(new Program()).run();

		}
	}
}
