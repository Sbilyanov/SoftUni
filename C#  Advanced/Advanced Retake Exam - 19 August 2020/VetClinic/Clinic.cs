using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VetClinic
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

        public int Count { get { return data.Count; } }

        public void Add(Pet pet )
        {
            if (data.Count<Capacity)
            {
                this.data.Add(pet);
            }
        }

        public bool Remove(string name)
        {
            Pet pet = data.FirstOrDefault(p => p.Name == name);
            if (pet==null)
            {
                return false;
            }
            data.Remove(pet);
            return true;
        }

        public Pet GetPet(string name, string owner)
        {
            Pet pet = data.FirstOrDefault(p => p.Name == name && p.Owner==owner);
            if (pet == null)
            {
                return null;
            }          
            return pet;
        }
        public Pet GetOldestPet()
        {
           Pet pet=data.OrderByDescending(p=>p.Age).FirstOrDefault();
            if (pet == null)
            {
                return null;
            }
            return pet;

        }
        public string GetStatistics()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append($"The clinic has the following patients:{ Environment.NewLine}");
            foreach (var pet in data)
            {
                sb.Append($"Pet {pet.Name} with owner: { pet.Owner}{ Environment.NewLine}");
            }


            return sb.ToString();
        }
    }
}
