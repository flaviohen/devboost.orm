﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

namespace DevBoost.ORM.App
{
    public partial class TbClube
    {
        public TbClube()
        {
            TbJogador = new HashSet<TbJogador>();
        }

        public int IdClube { get; set; }
        public string Clube { get; set; }

        public virtual ICollection<TbJogador> TbJogador { get; set; }
    }
}