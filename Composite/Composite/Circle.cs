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
			Console.WriteLine("CIRCLE drawn: x=" + x + " and y= " + y + ", radius r= " + radius);
		}

		override public void add(GraphicObject g)
		{
		}

		override public void remove(GraphicObject g)
		{
		}

		override public void move(int dx, int dy)
		{
			x += dx;
			y += dy;
			Console.WriteLine("Position of CIRCLE now at: x = " + x + "y= " + y + ".");
		}
	}
}
