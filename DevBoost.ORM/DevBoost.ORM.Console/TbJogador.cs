﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

namespace DevBoost.ORM.App
{
    public partial class TbJogador
    {
        public TbJogador()
        {
            TbPosicao = new HashSet<TbPosicao>();
        }

        public int IdJogador { get; set; }
        public string Nome { get; set; }
        public DateTime? DataNascimento { get; set; }
        public int? IdClube { get; set; }

        public virtual TbClube IdClubeNavigation { get; set; }
        public virtual ICollection<TbPosicao> TbPosicao { get; set; }
    }
}