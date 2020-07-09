﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CadastroEVA_001.Entities.Enums
{
    enum OrderStatus :int
    {
        PagamentoPendente = 0,
        Processando = 1,
        Enviado = 2,
        Entregue = 3
    }
}
