﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite
{
	public abstract class GraphicObject
	{
		public abstract void draw();
		public abstract void move(int dx, int dy);
	}
}
