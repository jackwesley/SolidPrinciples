﻿using SOLIDPrinciples._5_DIP._5._2_Solucao.Interfaces;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace SOLIDPrinciples._5_DIP._5._2_Solucao
{
    public class ProdutoRepository : IProdutoRepository
    {
        public void AdicionarProduto(Produto produto)
        {
            using (var cn = new SqlConnection())
            {
                var cmd = new SqlCommand();
                cn.ConnectionString = "Connection String";
                cmd.Connection = cn;

                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "INSERT INTO PRODUTO (NOME, EAN, URLIMAGEM) VALUES(@nome, @ean, @urlImagem)";
                cmd.Parameters.AddWithValue("nome", produto.Nome);
                cmd.Parameters.AddWithValue("ean", produto.EAN);
                cmd.Parameters.AddWithValue("urlImagem", produto.UrlImagem);


                cn.Open();
                cmd.ExecuteNonQuery();
            }
        }
    }
}
