using System.Globalization;

namespace ExercicioDeFixacao1.Entities
{
    class ImportProduct : Product
    {
        public double customsFee { get; set; }

        public ImportProduct()
        {
        }

        public ImportProduct(string name, double price, double customsFee) : base(name, price)
        {
            this.customsFee = customsFee;
        }

        public double TotalPrice()
        {
            return Price + customsFee;
        } 
        public override string PriceTag()
        {
            return Name + " $ " + TotalPrice().ToString("F2",CultureInfo.InvariantCulture) + $"(Customs fee: $ {customsFee.ToString("F2",CultureInfo.InvariantCulture)})";
        }
    }
}
