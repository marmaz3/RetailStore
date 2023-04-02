using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RetailStore
{
    public class Receipt
    {
        private int reciptNumber;
        private string dataOfPurshe;
        private int customerNumber;
        private string customerName;
        private string customerLastName;
        private string customerAdress;
        private int phoneNumber;
        private int itemNumber;
        private double unitPrice;
        private string description;
        private int quantityPursched;

        public Receipt(int RNumber, string dOfPurshe, int CaNumber, string CaName, string CaLaName, string CaAdress, int PNumber, int INumber, double UPrice, string Description, int QtyPurshed)
        {
            reciptNumber = RNumber;
            dataOfPurshe = dOfPurshe;
            customerNumber = CaNumber;
            customerName = CaName;
            customerLastName = CaLaName;
            customerAdress = CaAdress;
            phoneNumber = PNumber;
            itemNumber = INumber;
            unitPrice = UPrice;
            description = Description;
            quantityPursched = QtyPurshed;


        }

        public int CustomerNumber
        {
            get
            {
                return customerNumber;
            }
            set
            {
                if (value > 0 && value < 9999)
                { customerNumber = value; }

            }
        }
        public string CustomerName
        {
            get
            {
                return customerName;
            }
            set
            {
                customerName = value;
            }
        }
        public string CustomerAdress
        {
            get
            {
                return customerAdress;
            }
            set
            {
                customerAdress = value;
            }

        }
        public int PhoneNumber
        {
            get
            {
                return phoneNumber;
            }
            set
            {
                phoneNumber = value;
            }
        }
        public int ItemNumber
        {
            get
            {
                return itemNumber;
            }
            set
            {
                if (value > 0 && value < 9999)
                { itemNumber = value; }

            }
        }
        public double UnitPrice
        {
            get
            {
                return unitPrice;
            }
            set
            {
                if (value > 0 && value < 9999)
                { unitPrice = value; }

            }
        }
        public string Description
        {
            get
            {
                return description;
            }
            set
            {
                description = value;
            }
        }

        public int quantityPurshed
        {
            get
            {
                return quantityPurshed;
            }
            set
            {
                if (value > 0)
                {
                    quantityPurshed = value;
                }

            }
        }
        private decimal dateOfPurshe
        {
            get
            {
                return dateOfPurshe;
            }
            set
            {
                dateOfPurshe = value;
            }
        }
        public int ReciptNumber
        {
            get
            {
                return reciptNumber;
            }
            set
            {
                if (value > 0 && value < 9999)
                {
                    reciptNumber = value;
                }
            }
        }

        public double Using_quantity_price()
        {
            return Convert.ToDouble(quantityPurshed) * UnitPrice;
        }
        public override string ToString()
        {
            return "Customer Name: " + CustomerName + "CustomerNumber: " + PhoneNumber + "TotalPurshe: " + ItemNumber;
        }
    }



}