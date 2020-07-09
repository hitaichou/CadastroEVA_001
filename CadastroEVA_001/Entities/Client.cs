using System;
using System.Collections.Generic;
using System.Text;

namespace CadastroEVA_001.Entities
{
    class Client
    {
        public string Name  { get; set; }

        public Client()
        {

        }
        public Client(string name)
        {
            Name = name;
        }
        public override string ToString()
        {
            return Name;
        }

    }
}
