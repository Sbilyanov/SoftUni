using System;
using System.Collections.Generic;
using System.Text;

namespace CustomDataStructures
{
   public class CustomList
    {
        private const int InitialCapacity = 2;
        private int[] array;

        public CustomList()
        {
            this.array = new int[InitialCapacity];
        }

        public int Count { get; private set; }

        public int this[int index] 
        {
            get
            {
                this.ValidateIndex(index);
                return this.array[index];
            }
            set
            {
                this.ValidateIndex(index);
                this.array[index] = value;
            }
        }

        private void ValidateIndex(int index)
        {
            if (index >= this.Count)
            {
                throw new ArgumentOutOfRangeException("Invalid index!");
            }
        }

        public void InsertAt(int number,int index)
        {
            if (index>this.Count)
            {
                throw new ArgumentOutOfRangeException("Invalid index");
            }

            if (this.array.Length==this.Count-1)
            {
                Resize();
            }

            this.ShiftRight(index);
            this.array[index] = number;
            this.Count++;
        }

        private void ShiftRight(int index)
        {
           
            for (int i = Count ; i > index; i--)
            {
                this.array[i] = this.array[i - 1]; 
            }
        }

        public int RemoveAt(int index)
        {
            ValidateIndex(index);

            int number = this.array[index];
            this.array[index] = default;
            Shift(index);
            this.Count--;

            if (this.Count==this.array.Length/2)
            {
                this.Shirnk();
            }

            return number;
        }

        private void Shirnk()
        {
            int[] copy = new int[this.array.Length / 2];
            Array.Copy(this.array, copy, Count);

            this.array = copy;
        }

        private void Shift(int index)
        {
            for (int i = index; i <this.Count-1; i++)
            {
                this.array[i] = this.array[i + 1];
            }
            this.array[this.Count - 1] = default;
        }

        public void Add(int number)
        {
            if (this.array.Length==this.Count)
            {
                this.Resize();
            }

            this.array[this.Count] = number;
            this.Count++;
        }

        private void Resize()
        {
            int[] copy = new int[this.array.Length * 2];

            for (int i = 0; i < this.array.Length; i++)
            {
                copy[i] = this.array[i];
            }
            this.array = copy;
        }
    }
}
