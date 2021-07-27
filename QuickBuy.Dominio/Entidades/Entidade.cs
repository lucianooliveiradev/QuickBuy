﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QuickBuy.Dominio.Entidades
{
    public abstract class Entidade
    {
        protected List<string> _mensagensValidacao { get; set; }
        private List<string> MensagemValidacao
        {
            get { return _mensagensValidacao ?? (_mensagensValidacao = new List<string>()); }
        }

        public abstract void Validate();
        protected bool EhValido
        {
            get{ return !MensagemValidacao.Any(); }
        }

        protected void AddMensagem(string msg)
        {
            _mensagensValidacao.Add(msg);
        }

        protected void LimparMensagensValidacao()
        {
            _mensagensValidacao.Clear();
        }
    }
}
