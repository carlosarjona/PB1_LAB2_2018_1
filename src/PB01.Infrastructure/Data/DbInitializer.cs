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

            var BemPatrimonial = new BemPatrimonial[]
            {
                new BemPatrimonial {
                    Descricao = "Fulano da Silva",
                    DataCadastro = new DateTime(20-05-2018),
                    NumeroTombo = "A1B2"
                },

                new BemPatrimonial {
                    Descricao = "Beltrano da Silva",
                    DataCadastro = new DateTime(22-02-2018),
                    NumeroTombo = "A5C4"
                }
            };

            context.AddRange(BemPatrimonial);

            var enderecos = new Endereco[]
            {
                new Endereco {
                    CEP = "78058788",
                    Bairro = "Itiquira",
                    Logradouro = "Rua 10",
                    Numero = "7341",
                    
                },

                new Endereco {
                    CEP = "78000999",
                    Bairro = "Dom Aquino",
                    Logradouro = "Rua 11",
                    Numero = "15",
                    
                }
            };

            context.AddRange(enderecos);

            var Responsavel = new Responsavel[]
            {
                new Responsavel
                {
                   Email = "cuiaba@123.com",
                    Nome = "jose da silva"
                },

                new Responsavel
                {
                    Email = "cuiaba@12345.com",
                    Nome = "mario da silva"
                }

            };

            context.AddRange(Responsavel);

            var especies = new Categoria[]
            {

                new Categoria
                {
                    Descricao = "Predio"

                },

                new Categoria
                {

                    Descricao = "Condominio"
                }


            };

            context.AddRange(typeof(Categoria));

            var consultas = new Auditoria[]
            {
                new Auditoria
                {
                    Data  = new DateTime(01/01/2018),
                    Aprovado = true
                },

                new Auditoria
                {
                    Data  = new DateTime(02/01/2018),
                    Aprovado = true
                }

            };

            context.AddRange(typeof(Auditoria));

            context.SaveChanges();
        }

        
    }
}
