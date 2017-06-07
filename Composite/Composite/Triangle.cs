using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite
{
	public class Triangle : GraphicObject
	{
		private Point p1;
		private Point p2;
		private Point p3;

		public Triangle(Point p1, Point p2, Point p3)
		{
			this.p1 = p1;
			this.p2 = p2;
			this.p3 = p3;
		}

		override public void draw()
		{
			Console.WriteLine("TRIANGLE drawn: p1 = " + p1 + ", p2 = " + p2 + " and p3 = " + p3 + ".");
		}

		override public void add(GraphicObject g)
		{
		}

		override public void remove(GraphicObject g)
		{
		}

		override public void move(int dx, int dy)
		{
			p1.Offset(dx, dy);
			p2.Offset(dx, dy);
			p3.Offset(dx, dy);
			Console.WriteLine("Corners of TRIANGLE now at: p1 = " + p1 + ", p2 = " + p2 + " p3= " + p3 + ".");
		}
	}
}
