namespace CadastroEVA_001.Entities
{
    class WorkHour
    {
        private double _vlMaoDeObra = 1; //valor hr mao de obra, ex: R$ 1,00/hora
        private double _vlMaoDeObraTotal; //valor total mao de obra
        private double _vlInsumo = 1; //valor fixo insumo energia/agua/etc        
        private double _vlLucro = 2; //valor fixo para calculo lucro
        private double _vlPrecoBruto;
        private double _vlPrecoTotal;
        public double QtMaoDeObra { get; set; }
        public double VlPrecoCusto { get; set; }
        public double VlDesconto { get; set; }
        public Product Product { get; set; } = new Product();

        //CONSTRUTORES
        public WorkHour()
        {

        }
        public WorkHour(int id, double qtmaodeobra, double vlprecocusto, double vldesconto)
        {
            QtMaoDeObra = qtmaodeobra;
            //VlPrecoCusto = vlprecocusto;
            VlPrecoCusto = Product.ValorProdutos(id);
            VlDesconto = VlDesconto;
        }
        //METODOS
        public double CalculaPreco(double qtmaodeobra, double vlprecocusto, double vldesconto)
        {
            _vlPrecoBruto = (vlprecocusto + _vlInsumo) * _vlLucro;
            _vlMaoDeObraTotal = _vlMaoDeObra * qtmaodeobra;
            _vlPrecoTotal = (_vlPrecoBruto - (_vlPrecoBruto * (vldesconto / 100))) + _vlMaoDeObraTotal;
            return _vlPrecoTotal;
        }
    }
}
