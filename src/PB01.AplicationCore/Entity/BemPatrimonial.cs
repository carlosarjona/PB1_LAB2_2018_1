﻿using System;
using System.Collections.Generic;
using System.Text;

namespace PB01.AplicationCore.Entity
{

  

   public class BemPatrimonial
    {

        public BemPatrimonial()
        {

        }


        public int BemPatrimonialId { get; set; }
        public DateTime DataCadastro { get; set; }
        public string NumeroTombo { get; set; }
        public string Descricao { get; set; }
    }
}
