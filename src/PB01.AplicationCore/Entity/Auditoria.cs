using System;
using System.Collections.Generic;
using System.Text;

namespace PB01.AplicationCore.Entity
{
    class Auditoria
    {
        public int AuditoriaId { get; set; }
        public DateTime Data { get; set; }
        public Boolean Aprovado { get; set; }

    }
}
