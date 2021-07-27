﻿using System;
using System.Collections.Generic;
using System.Text;

namespace QuickBuy.Dominio.Entidades
{
    public class Usuario : Entidade
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        /// <summary>
        /// Um usuário pode ter nenhum ou muitos pedidos
        /// </summary>
        public List<Pedido> Pedidos { get; set; } = new List<Pedido>();

        public override void Validate()
        {
            if (string.IsNullOrWhiteSpace(Email))
            {
                AddMensagem("Email não pode ficar vazio");
            }
        }
    }
}
