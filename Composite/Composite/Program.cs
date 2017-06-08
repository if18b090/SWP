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
			Rectangle rectangle = new Rectangle(new Point(0, 0), new Point(1, 0), new Point(1, 1), new Point(0, 1));
			Triangle triangle = new Triangle(new Point(1, 2), new Point(3, 4), new Point(4, 5));
			Circle circle = new Circle(2, 3, 4);

			GraphicObjectGroup Group = new GraphicObjectGroup();
			Group.add(rectangle);
			Group.add(triangle);
			Group.add(circle);

			Group.draw();

			Group.move(1, 1);
			Console.ReadKey();
		}
	}
}
