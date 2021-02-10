using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace _04.Froggy
{
    class Lake<T>:IEnumerable<T>
    {
        private List<T> stones;

        public Lake(List<T> stones)
        {
            this.stones = stones;
       
            
        }

        public IEnumerator<T> GetEnumerator()
        {
            for (int i = 0; i < this.stones.Count; i+=2)
            {
                yield return this.stones[i];
            }

            int index = this.stones.Count % 2 != 0 ? this.stones.Count - 2 : this.stones.Count - 1;
            for (int i = index; i >= 1; i-=2)
            {
                yield return this.stones[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
