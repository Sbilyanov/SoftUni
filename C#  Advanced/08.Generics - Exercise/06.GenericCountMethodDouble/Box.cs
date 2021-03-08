using System;
using System.Collections.Generic;
using System.Text;

namespace _06.GenericCountMethodDouble
{
    public class Box<T>:IComparable
        where T:IComparable
    {
    
        public Box(T value)
        {
            this.Value = value;
        }

        public T Value { get; private set; }

        public int CompareTo(object obj)
        {
            Box<T> box = obj as Box<T>;

            int compare = this.Value.CompareTo(box.Value);

            return compare;
        }

        public override string ToString()
        {
            return $"{this.Value.GetType().FullName}: {this.Value}";
        }
    }
}
