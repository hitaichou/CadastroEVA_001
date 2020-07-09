using System.Globalization;

namespace CadastroEVA_001.Entities
{
    class OrderItem
    {
        public int Id { get; set; }
        public int Quantity { get; set; }
        public double Price { get; set; }
        public string Name { get; set; }        
        public Product Product { get; set; } = new Product();
        //private double _vlSubTotal;
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
        //METODOS
        public double SubTotal()
        {            
            return (Quantity * Product.ValorProdutos(Id));
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
