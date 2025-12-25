using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Geometry
{
	abstract class Shape
	{
		public Color Color { get; set; }
		public Shape(Color color)
		{
			this.Color = color;
		}
		public abstract double GetArea();   //Мы не значем как посчитать площадь фигуры, пока не знаем какая у нас фигура.
		public abstract double GetPerimeter();
		public abstract void Draw();
		public virtual void Info()
		{
			Console.WriteLine($"Площадь фигуры: {GetArea()}");
			Console.WriteLine($"Периметр фигуры: {GetPerimeter()}");
			Draw();
		}
	}
}
