using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite
{
	class Program
	{
		static void Main(string[] args)
		{
			Circle circle = new Circle(2, 3, 4);
			Rectangle rect = new Rectangle(new Point(2, 3), new Point(3, 4), new Point(4, 5), new Point(5, 6));
			Triangle triage = new Triangle(new Point(1, 2), new Point(3, 4), new Point(4, 5));

			circle.draw();
			rect.draw();
			triage.draw();

			Console.WriteLine("\n");

			GraphicObjectGroup Group = new GraphicObjectGroup();
			Group.add(rect);
			Group.add(triage);

			Group.draw();
			Group.move(1, 1);
			Console.ReadKey();
		}
	}
}
