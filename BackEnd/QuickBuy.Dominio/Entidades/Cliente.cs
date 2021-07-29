using System;
using System.Collections.Generic;
using System.Text;

namespace QuickBuy.Dominio.Entidades
{
    public class Cliente
    {
        public int Id { get; set; }
        public string Cpf { get; set; }
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
        /// <summary>
        /// Um cliente pode ter nenhum ou muitos pedidos
        /// </summary>
        public List<Pedido> Pedidos { get; set; } = new List<Pedido>();

    }
}
