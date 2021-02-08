using System;
using System.Collections.Generic;
using System.Text;

namespace _03.GenericSwapMethodString
{
    class Box<T>
    {

        public Box(T value)
        {
            this.Value = value;
        }
        public T Value { get; private set; }

        public override string ToString()
        {
            return $"{this.Value.GetType().FullName}: {this.Value}";
        }

        public void IndexSwap(List<Box<T>>boxes,int firstIndex,int secondIndex)
        {
            Box<T> temp = boxes[firstIndex];
            boxes[firstIndex] = boxes[secondIndex];
            boxes[secondIndex] = temp;
        }
    }
}
