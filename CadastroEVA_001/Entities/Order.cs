using CadastroEVA_001.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace CadastroEVA_001.Entities
{
    class Order
    {
        public OrderStatus Status { get; set; }
        public Client Client { get; set; }
        public DateTime Moment { get; set; }
        public double QtMaoDeObra { get; set; }
        public double VlDesconto { get; set; }
        public WorkHour WorkHour { get; set; } = new WorkHour();
        public List<OrderItem> Items { get; set; } = new List<OrderItem>();
        private double _vlBasePrice;
        private double _vlTotal;

        public Order()
        {

        }
        public Order(DateTime moment, OrderStatus status, Client client, double qtmaodeobra, double vldesconto)
        {
            Moment = moment;
            Status = status;
            Client = client;
            QtMaoDeObra = qtmaodeobra;
            VlDesconto = VlDesconto;
        }
        public Order(double qtmaodeobra, double vldesconto)
        {
            QtMaoDeObra = qtmaodeobra;
            VlDesconto = VlDesconto;
        }
        public void AddItem(OrderItem item)
        {
            Items.Add(item);
        }
        public void RemoveItem(OrderItem item)
        {
            Items.Remove(item);
        }
        public double Total()
        {
            double sum = 0;
            foreach(OrderItem item in Items)
            {
                sum += item.SubTotal();
            }
            //_vlBasePrice = (Quantity * Product.ValorProdutos(Id));
            _vlTotal = WorkHour.CalculaPreco(QtMaoDeObra, sum, VlDesconto);
            return _vlTotal;
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Data/Hora Pedido: " + Moment.ToString("dd/MM/yyyy HH:mm:ss"));
            sb.AppendLine("Status do Pedido: " + Status);
            sb.AppendLine("Cliente: " + Client);
            sb.AppendLine("Items do Pedido:");
            foreach (OrderItem item in Items)
            {
                sb.AppendLine(item.ToString());
            }
            sb.AppendLine("Preco Total: $ " + Total().ToString("F2", CultureInfo.InvariantCulture));
            return sb.ToString();
        }

    }
}
