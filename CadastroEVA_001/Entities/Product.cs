using System;
using System.Collections.Generic;
using System.Text;

namespace CadastroEVA_001.Entities
{
    class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public int Quantity { get; set; }
        private double _vlPrice = 0;
        private string _nmProduto;

        public Product()
        {

        }

        public Product(int id, int quantity)
        {
            Id = id;
            Quantity = quantity;
        }

        public Product(int id, string name, double price)
        {
            Id = id;
            Name = name;
            Price = price;
        }
        public double ValorProdutos(int id)
        {
            //-------------------------------------
            //METODO PARA APLICAR VALOR DO PRODUTO
            //-------------------------------------

            switch (id)
            {
                case 1:
                    //Rosa Monique
                    double _rosaMonique = 0.1;
                    _vlPrice = _rosaMonique;
                    break;
                case 2:
                    //Sepala Pequena
                    double _sepalaPequena = 0.05;
                    _vlPrice = _sepalaPequena;
                    break;
                case 3:
                    //Folha Rosa Grande
                    double _folhaRosaGrande = 0.1;
                    _vlPrice = _folhaRosaGrande;
                    break;
                case 4:
                    //Folha Desidratada
                    double _folhaDesidratada = 0.05;
                    _vlPrice = _folhaDesidratada;
                    break;
                case 5:
                    //Arame
                    double _arame = 1.00;
                    _vlPrice = _arame;
                    break;
                case 6:
                    //Vaso Vidro
                    double _vasoVidro = 8.00;
                    _vlPrice = _vasoVidro;
                    break;
                case 7:
                    //Fita Floral
                    double _fitaFloral = 0.20;
                    _vlPrice = _fitaFloral;
                    break;
                default:
                    _vlPrice = 0;
                    break;
            }
            return _vlPrice;
        }
        public string NomeProdutos(int id)
        {
            //-------------------------------------
            //METODO PARA APLICAR NOME DO PRODUTO
            //-------------------------------------

            switch (id)
            {
                case 1:
                    _nmProduto = "Rosa Monique";
                    break;
                case 2:
                    _nmProduto = "Sepala Pequena";
                    break;
                case 3:
                    _nmProduto = "Folha Rosa Grande";
                    break;
                case 4:
                    _nmProduto = "Folha Desidratada";
                    break;
                case 5:
                    _nmProduto = "Arame";
                    break;
                case 6:
                    _nmProduto = "Vaso Vidro";
                    break;
                case 7:
                    _nmProduto = "Fita Floral";
                    break;
                default:
                    _nmProduto = "NAO EXISTE";
                    break;
            }
            return _nmProduto;
        }
    }
}
