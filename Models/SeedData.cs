using Microsoft.EntityFrameworkCore;
using MvcViatura.Data;
using System;

namespace MvcViatura.Models
{
    public class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new MvcViaturaContext(
            serviceProvider.GetRequiredService<
            DbContextOptions<MvcViaturaContext>>()))
            {
                // Procura na bd se já existem livros
                if (context.Viatura.Any())
                {
                    return; // Se a bd já tiver dados não faz nada
                }


                context.Viatura.AddRange(

                   new Viatura
                   {
                       Marca = "Alfa Romeo",
                       Modelo = "Stelvio",
                       Cor = "Azul",
                       Cilindrada = 2143,
                       Ano = 2017,
                       Mes = 06,
                       Tipo = "SUV",
                       Preco = 31990,
                       ForPgto = "À Vista"
                   },
                   new Viatura
                   {
                       Marca = "Mercedes-Benz",
                       Modelo = "A180",
                       Cor = "Preto",
                       Cilindrada = 1461,
                       Ano = 2018,
                       Mes = 01,
                       Tipo = "SUV",
                       Preco = 22990,
                       ForPgto = "À Vista"
                   },                   
                   new Viatura
                   {
                       Marca = "VW",
                       Modelo = "T-Cross",
                       Cor = "Branco",
                       Cilindrada = 999,
                       Ano = 2022,
                       Mes = 03,
                       Tipo = "SUV",
                       Preco = 24799,
                       ForPgto = "Financiamento"
                   },
                   new Viatura
                   {
                       Marca = "SEAT",
                       Modelo = "Ibiza",
                       Cor = "Preto",
                       Cilindrada = 1199,
                       Ano = 2011,
                       Mes = 01,
                       Tipo = "Carrinha",
                       Preco = 7750,
                       ForPgto = "Financiamento"
                   },
                   new Viatura
                   {
                       Marca = "Fiat",
                       Modelo = "500",
                       Cor = "Branco",
                       Cilindrada = 1242,
                       Ano = 2017,
                       Mes = 08,
                       Tipo = "Citadino",
                       Preco = 12800,
                       ForPgto = "Financiamento"
                   }
                    );
                    context.SaveChanges();

                    if (context.Cliente.Any())
                    {
                        return; // Se a bd já tiver dados não faz nada
                    }

                context.Cliente.AddRange(
                    new Cliente
                    {
                        Nome = "José Rocha",
                        Morada = "Rua de Pádua Correia, 44",
                        DtNasc = DateTime.Parse("31/10/1999"), 
                        Email = "ze13lima@gmail.com",
                        Telefone = 919192215
                    },
                    new Cliente
                    {
                        Nome = "António Sergio",
                        Morada = "Rua do sol nascente,2",
                        DtNasc = DateTime.Parse("14/09/1984"), 
                        Email = "tonho@gmail.com",
                        Telefone = 914759861
                    },
                    new Cliente
                    {
                        Nome = "Maria Amélia",
                        Morada = "Rua do Kfc, 47",
                        DtNasc = DateTime.Parse("04/10/1990"), 
                        Email = "amelinha@gmail.com",
                        Telefone = 911234567
                    },
                    new Cliente
                    {
                        Nome = "Francisco Santos",
                        Morada = "Rua das cruzes, 99",
                        DtNasc = DateTime.Parse("10/01/1970"), 
                        Email = "chico@gmail.com",
                        Telefone = 912458716
                    }
                    );
                    context.SaveChanges();
                    if (context.Funcionario.Any())
                    {
                        return; // Se a bd já tiver dados não faz nada
                    }

                context.Funcionario.AddRange(
                    new Funcionario
                    {
                        Nome = "Sergio Almeida",
                        Morada = "Rua do Mc, 44",
                        Email = "serginho@gmail.com",
                        Telefone = 987456123,
                        Nib = "PT5015484851235484263",
                        Contribuinte = 025689741
                    }
                    );
                    context.SaveChanges();


            }
        }
    }
}
