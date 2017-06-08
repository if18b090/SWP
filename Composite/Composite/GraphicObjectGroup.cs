using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite
{
	public class GraphicObjectGroup : GraphicObject
	{
		private List<GraphicObject> objectList = new List<GraphicObject>();

		override public void draw()
		{
			foreach (GraphicObject member in objectList)
			{
				member.draw();
			}
		}

		override public void move(int dx, int dy)
		{
			foreach (GraphicObject member in objectList)
			{
				member.move(dx, dy);
			}
		}

		public void add(GraphicObject g)
		{
			objectList.Add(g);
		}

		public void remove(GraphicObject g)
		{
			objectList.Remove(g);
		}
	}
}
