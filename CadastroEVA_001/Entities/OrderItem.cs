using System.Globalization;

namespace CadastroEVA_001.Entities
{
    class OrderItem
    {
        public int Id { get; set; }
        public int Quantity { get; set; }
        public double Price { get; set; }
        public string Name { get; set; }
        //public double QtMaoDeObra { get; set; }
        //public double VlDesconto { get; set; }
        public Product Product { get; set; } = new Product();
        //public WorkHour WorkHour { get; set; } = new WorkHour();
        //private double _vlSubTotal;
        //private double _vlBasePrice;
        //private double _vlPrice = 0;


        //CONSTRUTORES
        public OrderItem()
        {

        }
        
        public OrderItem(int id, int quantity, Product product)
        {
            Id = id;        
            Quantity = quantity;
            Product = product;
        }
        /*public OrderItem(double qtmaodeobra, double vldesconto)
        {
            QtMaoDeObra = qtmaodeobra;            
            VlDesconto = VlDesconto;
        }*/

        //METODOS
        public double SubTotal()
        {
            //_vlBasePrice = (Quantity * Product.ValorProdutos(Id));
            //_vlSubTotal = WorkHour.CalculaPreco(QtMaoDeObra, _vlBasePrice, VlDesconto);
            return (Quantity * Product.ValorProdutos(Id));//_vlSubTotal;
        }
       
        public override string ToString()
        {
            return Product.NomeProdutos(Id) //busco o nome do produto
                + ", R$"
                + Product.ValorProdutos(Id).ToString("F2", CultureInfo.InvariantCulture) //busco o valor do produto
                + ", Quantity: "
                + Quantity
                + ", Subtotal: $"
                + SubTotal().ToString("F2", CultureInfo.InvariantCulture);
        }


    }
}
