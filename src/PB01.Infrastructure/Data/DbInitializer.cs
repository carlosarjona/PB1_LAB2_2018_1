using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using PB01.AplicationCore.Entity;

namespace PB01.Infrastructure.Data
{
   public static class DbInitializer
    {
        public static void Initialize(BemPatrimonialContext context)
        {
            if (context.BensPatrimoniais.Any())
            {
                return;
            }

            var bensPatrimoniais = new BemPatrimonial[]
            {
                new BemPatrimonial
                {
                    Descricao = "casa"
                }
            }
            

        }

        
    }
}
