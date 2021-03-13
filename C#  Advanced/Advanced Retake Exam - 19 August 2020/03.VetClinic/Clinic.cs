using System;
using System.Collections.Generic;
using System.Text;

namespace _03.VetClinic
{
   public class Clinic
    {
        private List<Pet> data;

        public Clinic(int capacity)
        {
            this.Capacity = capacity;
            this.data = new List<Pet>();

        }

        public int Capacity { get; set; }

    }
}
