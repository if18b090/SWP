using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite
{
	public class Circle : GraphicObject
	{
		private int x;
		private int y;
		private int radius;


		public Circle(int x, int y, int radius)
		{
			this.x = x;
			this.y = y;
			this.radius = radius;
		}

	override public void draw()
		{
			Console.WriteLine("CIRCLE drawn:\nx=" + x + "\ny=" + y + "\nradius r=" + radius + "\n");
		}

		override public void move(int dx, int dy)
		{
			x += dx;
			y += dy;
			Console.WriteLine("MOVED!");
			Console.WriteLine("Position of CIRCLE now at:\nx = " + x + "\ny = " + y + "\n");
		}
	}
}
