﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID
{
    /// <summary>
    /// Open to extensions, closed for modifications.
    ///  Use Interfaces or abstract classes, rather than using concrete classes. 
    ///  Such interfaces can be fixed once developed so the classes that depend upon them can rely upon unchanging abstractions.
    /// </summary>
    class OCP
    {
    }

    public class Rectangle
    {
        public double Height { get; set; }
        public double Width { get; set; }
    }

    //public class AreaCalculator
    //{
    //    public double TotalArea(Rectangle[] arrRectangles)
    //    {
    //        double area=0;
    //        foreach (var objRectangle in arrRectangles)
    //        {
    //            area += objRectangle.Height * objRectangle.Width;
    //        }
    //        return area;
    //    }
    //}

    public class Circle
    {
        public double Radius { get; set; }
    }

    public class AreaCalculator
    {
        public double TotalArea(object[] arrObjects)
        {
            double area = 0;
            Rectangle objRectangle;
            Circle objCircle;
            foreach (var obj in arrObjects)
            {
                if (obj is Rectangle)
                {
                    objRectangle = (Rectangle)obj;
                    area += objRectangle.Height * objRectangle.Width;
                }
                else
                {
                    objCircle = (Circle)obj;
                    area += objCircle.Radius * objCircle.Radius * Math.PI;
                }
            }
            return area;
        }
    }

    #region soln

    public abstract class Shape
    {
        public abstract double Area();
    }

    public class Rectangle : Shape
    {
        public double Height { get; set; }
        public double Width { get; set; }
        public override double Area()
        {
            return Height * Width;
        }
    }
    public class Circle : Shape
    {
        public double Radius { get; set; }
        public override double Area()
        {
            return Radius * Radus * Math.PI;
        }
    }

      public class AreaCalculator
    {
        public double TotalArea(Shape[] arrShapes)
        {
            double area = 0;
            foreach (var objShape in arrShapes)
            {
                area += objShape.Area();
            }
            return area;
        }
    }

    #endregion
}
