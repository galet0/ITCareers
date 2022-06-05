using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam_Pharmacy
{
    class Pharmacy
    {
        private string name;
        private List<Medicine> medicines;

        public Pharmacy(string name)
        {
            Name = name;
            this.medicines = new List<Medicine>();
        }
        public string Name
        {
            get { return name; }
            private set
            {
                if (value.Length < 3)
                {
                    throw new ArgumentException("Invalid name");
                }
                name = value;
            }
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append($"Pharmacy {Name} has {medicines.Count} medicines and they are:");
            if (medicines.Count > 0)
            {
                foreach (var medicine in medicines)
                {
                    sb.AppendLine();
                    sb.Append(medicine.ToString());
                }
            }
            else
            {
                sb.Append("N/A");
            }
            return sb.ToString();
        }

        public void Order(Medicine medicine)
        {
            this.medicines.Add(medicine);
        }

        public bool Sell(Medicine medicine)
        {
            return this.medicines.Remove(medicine);
        }

        public double CalculateTotalPrice()
        {
            return this.medicines.Sum(m => m.Price);
        }

        public void RenamePharmacy(string newName)
        {
            this.Name = newName;
        }

        public void SellAllMedicines()
        {
            this.medicines.Clear();
        }

        public Medicine GetMedicineWithHighestPrice()
        {
            return this.medicines.OrderByDescending(m => m.Price).FirstOrDefault();
        }

        public Medicine GetMedicineWithLowestPrice()
        {
            return this.medicines.OrderBy(m => m.Price).FirstOrDefault();
        }
    }
}
