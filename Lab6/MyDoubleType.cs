using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6
{
    class MyDoubleType
    {
        public double DoubleValue { get; set; }

        public MyDoubleType(double doubleValue)
        {
            DoubleValue = doubleValue;
        }

        public override string ToString() => $"DoubleValue: {DoubleValue}";

        public static MyDoubleType operator +(MyDoubleType myDoubleType, double tal)
        {
            ;
            return new MyDoubleType(myDoubleType.DoubleValue + tal);
        }

        public static MyDoubleType operator +(double tal, MyDoubleType myDoubleType)
        {
            
            return new MyDoubleType(myDoubleType.DoubleValue + tal); 
        }
        public static MyDoubleType operator +(MyDoubleType myDoubleType, MyDoubleType myDoubleTypes)
        {
            ;
            return new MyDoubleType(myDoubleType.DoubleValue + myDoubleTypes.DoubleValue); 
        }

        public static MyDoubleType operator -(MyDoubleType myDoubleType, double tal)
        {
            ;
            return new MyDoubleType(myDoubleType.DoubleValue - tal); 
        }

        public static MyDoubleType operator -(double tal, MyDoubleType myDoubleType)
        {
            
            return new MyDoubleType(myDoubleType.DoubleValue - tal); 
        }
        public static MyDoubleType operator -(MyDoubleType myDoubleType, MyDoubleType myDoubleTypes)
        {
            
            return new MyDoubleType(myDoubleType.DoubleValue - myDoubleTypes.DoubleValue); ;
        }
        public static MyDoubleType operator *(MyDoubleType myDoubleType, double tal)
        {
            
            return new MyDoubleType(myDoubleType.DoubleValue * tal); ;
        }

        public static MyDoubleType operator *(double tal, MyDoubleType myDoubleType)
        {
            ;
            return new MyDoubleType(myDoubleType.DoubleValue * tal); ;
        }
        public static MyDoubleType operator *(MyDoubleType myDoubleType, MyDoubleType myDoubleTypes)
        {
            
            return new MyDoubleType(myDoubleType.DoubleValue * myDoubleTypes.DoubleValue); ;
        }
        public static MyDoubleType operator /(MyDoubleType myDoubleType, double tal)
        {
            return new MyDoubleType(myDoubleType.DoubleValue / tal);
        }

        public static MyDoubleType operator /(double tal, MyDoubleType myDoubleType)
        {
            return new MyDoubleType(myDoubleType.DoubleValue / tal);
        }
        public static MyDoubleType operator /(MyDoubleType myDoubleType, MyDoubleType myDoubleTypes)
        {
            
            return new MyDoubleType(myDoubleType.DoubleValue / myDoubleTypes.DoubleValue);
        }
        public static bool operator ==(MyDoubleType myDoubleType, double tal)
        {
            if(myDoubleType.DoubleValue == tal)
                return true;
            else
            {
                return false;
            }
        }

        public static bool operator ==(double tal, MyDoubleType myDoubleType)
        {
            if (myDoubleType.DoubleValue == tal)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool operator ==(MyDoubleType myDoubleType, MyDoubleType myDoubleTypes)
        {
            if (myDoubleType.DoubleValue == myDoubleTypes.DoubleValue)
                return true;
            else
            {
                return false;
            }
        }
        public static bool operator !=(MyDoubleType myDoubleType, double tal)
        {
            if (myDoubleType.DoubleValue != tal)
                return true;
            else
            {
                return false;
            }
        }

        public static bool operator !=(double tal, MyDoubleType myDoubleType)
        {
            if (myDoubleType.DoubleValue != tal)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool operator !=(MyDoubleType myDoubleType, MyDoubleType myDoubleTypes)
        {
            if (myDoubleType.DoubleValue != myDoubleTypes.DoubleValue)
                return true;
            else
            {
                return false;
            }
        }
        public static bool operator <(MyDoubleType myDoubleType, double tal)
        {
            if (myDoubleType.DoubleValue < tal)
                return true;
            else
            {
                return false;
            }
        }
        public static bool operator <(double tal, MyDoubleType myDoubleType)
        {
            if (myDoubleType.DoubleValue < tal)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool operator <(MyDoubleType myDoubleType, MyDoubleType myDoubleTypes)
        {
            if (myDoubleType.DoubleValue == myDoubleTypes.DoubleValue)
                return true;
            else
            {
                return false;
            }
        }
        public static bool operator >(MyDoubleType myDoubleType, double tal)
        {
            if (myDoubleType.DoubleValue < tal)
                return true;
            else
            {
                return false;
            }
        }
        public static bool operator >(double tal, MyDoubleType myDoubleType)
        {
            if (myDoubleType.DoubleValue < tal)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool operator >(MyDoubleType myDoubleType, MyDoubleType myDoubleTypes)
        {
            if (myDoubleType.DoubleValue == myDoubleTypes.DoubleValue)
                return true;
            else
            {
                return false;
            }
        }
        public static bool operator >=(MyDoubleType myDoubleType, double tal)
        {
            if (myDoubleType.DoubleValue <= tal)
                return true;
            else
            {
                return false;
            }
        }
        public static bool operator >=(double tal, MyDoubleType myDoubleType)
        {
            if (myDoubleType.DoubleValue > tal)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool operator >=(MyDoubleType myDoubleType, MyDoubleType myDoubleTypes)
        {
            if (myDoubleType.DoubleValue == myDoubleTypes.DoubleValue)
                return true;
            else
            {
                return false;
            }
        }
        public static bool operator <=(MyDoubleType myDoubleType, double tal)
        {
            if (myDoubleType.DoubleValue >= tal)
                return true;
            else
            {
                return false;
            }
        }
        public static bool operator <=(double tal, MyDoubleType myDoubleType)
        {
            if (myDoubleType.DoubleValue >= tal)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool operator <=(MyDoubleType myDoubleType, MyDoubleType myDoubleTypes)
        {
            if (myDoubleType.DoubleValue == myDoubleTypes.DoubleValue)
                return true;
            else
            {
                return false;
            }
        }
    }
}
