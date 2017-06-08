using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite
{
	public class Rectangle : GraphicObject
	{
		private Point p1, p2, p3, p4;

		public Rectangle(Point p1, Point p2, Point p3, Point p4)
		{
			this.p1 = p1;
			this.p2 = p2;
			this.p3 = p3;
			this.p4 = p4;
		}

		override public void draw()
		{
			Console.WriteLine("RECTANGLE drawn:\np1 = " + p1 + "\np2 = " + p2 + "\np3 = " + p3 + "\np4 = " + p4 + "\n");
		}

		override public void move(int dx, int dy)
		{
			p1.Offset(dx, dy);
			p2.Offset(dx, dy);
			p3.Offset(dx, dy);
			p4.Offset(dx, dy);
			Console.WriteLine("MOVED!");
			Console.WriteLine("Corners of RECTANGLE now at: \np1 = " + p1 + "\np2 = " + p2 + "\np3 = " + p3 + "\np4 = " + p4 + "\n");
		}
	}
}
