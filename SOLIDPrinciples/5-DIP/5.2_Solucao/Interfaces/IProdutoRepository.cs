﻿using System;
using System.Collections.Generic;
using System.Text;

namespace SOLIDPrinciples._5_DIP._5._2_Solucao.Interfaces
{
    public interface IProdutoRepository
    {
        void AdicionarProduto(Produto produto);
    }
}
