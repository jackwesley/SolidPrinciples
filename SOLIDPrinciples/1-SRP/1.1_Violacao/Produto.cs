﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace SOLIDPrinciples._1_SRP._1._1_Violacao
{
    public class Produto
    {
        public int ProdutoId { get; set; }
        public string Nome { get; set; }
        public string EAN { get; set; }
        public string UrlImagem { get; set; }
        public double Valor { get; set; }



        public string AdicionarProduto()
        {
            if(EAN.Length > 7)
            {
                return "EAN do produto Invalido";
            }

            if (!UrlImagem.Contains("https://"))
            {
                return "Imagem do produto inválida";
            }

            using (var cn = new SqlConnection())
            {
                var cmd = new SqlCommand();
                cn.ConnectionString = "Connection String";
                cmd.Connection = cn;

                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "INSERT INTO PRODUTO (NOME, EAN, URLIMAGEM) VALUES(@nome, @ean, @urlImagem)";
                cmd.Parameters.AddWithValue("nome", Nome);
                cmd.Parameters.AddWithValue("ean", EAN);
                cmd.Parameters.AddWithValue("urlImagem", UrlImagem);


                cn.Open();
                cmd.ExecuteNonQuery();
            }

            //Inserir na fila
            var produtoParaFila = new ProdutoParaFila();
            produtoParaFila.ProdutoId = ProdutoId;
            produtoParaFila.Marketplace = 10;
            produtoParaFila.DataInsercao = DateTime.Now;
            
            new FilaProduto().Inserir(produtoParaFila);


            return "Produto cadastrado com sucesso";
          
        }
    }
}
