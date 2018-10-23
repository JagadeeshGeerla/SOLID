using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID
{
    /// <summary>
    /// Extension of the Open Close Principle. 
    /// Derived classes must be substitutable for their base classes.
    /// You should be able to use any derived class instead of a parent class 
    /// and have it behave in the same manner without modification.
    /// 
    /// While implementing derived classes, need to ensure that the derived classes 
    /// just extend the functionality of base classes without replacing the functionality of base classes.
    /// </summary>
    class RectangleLSP
    {
        protected int mWidth = 0;
        protected int mHeight = 0;

        public virtual void SetWidth(int width)
        {
            mWidth = width;
        }

        public virtual void SetHeight(int height)
        {
            mHeight = height;
        }

        public virtual int GetArea()
        {
            return mWidth * mHeight;
        }
    }

    // While implementing derived class if one replaces the functionality of base class then,  
    // it might results into undesired side effects when such derived classes are used in existing program modules. 
    class SquareLSP : RectangleLSP
    {
        // This class modifies the base class functionality instead of extending the base class functionality 

        // Now below methods implementation will impact base class functionality. 
        public override void SetWidth(int width)
        {
            mWidth = width;
            mHeight = width;
        }

        public override void SetHeight(int height)
        {
            mWidth = height;
            mHeight = height;
        }
    }

    class LiskovSubstitutionPrincipleDemo
    {
        private static RectangleLSP CreateInstance()
        {
            // As per Liskov Substitution Principle "Derived types must be completely substitutable for their base types". 
            bool SomeCondition = false;
            if (SomeCondition == true)
            {
                return new RectangleLSP();
            }
            else
            {
                return new SquareLSP();
            }
        }

        public static void LSPDemo()
        {
            Console.WriteLine("\n\nLiskov Substitution Principle Demo ");

            RectangleLSP RectangleObject = CreateInstance();

            // User assumes that RectangleObject is a rectangle and (s)he is able to set the width and height as for the base class 
            RectangleObject.SetWidth(5);
            RectangleObject.SetHeight(10);

            // Now this results into the area 100 (10 * 10 ) instead of 50 (10 * 5). 
            Console.WriteLine("Liskov Substitution Principle has been violated and returned wrong result : " + RectangleObject.GetArea());

            // So once again I repaet that sub classes should extend the functionality, sub classes functionality should not impact base class functionality. 
        }
    }
}
