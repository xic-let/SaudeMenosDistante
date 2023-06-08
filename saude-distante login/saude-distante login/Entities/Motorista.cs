﻿using saude_distante_login.Entities.Enums;
using saude_distante_login.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace saude_distante_login.Entities
{
    public class Motorista : Colaborador//, IAutenticacao
    {
        //Construtores da classe Motorista
        public Motorista()
        {

        }

        public Motorista(string nome, Genero genero, string contacto, string morada, Concelho concelho, string email, int idColaborador, string funcao, double vencimento, string password, int equipa) 
            : base(nome, genero, contacto, morada, concelho, email, idColaborador, funcao, vencimento, password, equipa)
        {

        }


        //Métodos da classe Motorista


        /*public bool Autenticar(string funcao, string email, string password)
        {
            return base.Email == email && base.Password == password && funcao.ToLower() == "motorista";
        }*/

        public void MostrarMenuMotorista()
        {
            Console.WriteLine("++++++++++++++++++++++++++++++++++++++");
			Console.WriteLine("Bem-vindo/a " + this.Nome);
            Console.WriteLine("Selecione uma opção:");
            Console.WriteLine();
            Console.WriteLine("1. Adicionar Rota");
            Console.WriteLine("2. Verificar plano de rota");
            Console.WriteLine("3. Aceder relatório estatístico");
            Console.WriteLine("4. Sair");
            Console.WriteLine();
            Console.Write("Opção (1-3): ");
            Console.WriteLine("++++++++++++++++++++++++++++++++++++++");
            string opcao = Console.ReadLine();

            switch (opcao)
            {
                case "1":
                    Console.WriteLine("Adicionar Rota: ");
                    Rotas.AdicionarRota(id, concelho, freguesia, equipa, data);
                    break;
                case "2":
                    Console.WriteLine("Plano de rotas: ");
                    Rotas rota = new Rotas();
                    rota.VerPlanoRota(Rotas.rotas);
                    break;
                case "3":
                    RelConsultas();
                    break;
                case "4":
                    Console.WriteLine("Obrigado por utilizar o nosso sistema. Até breve!");
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Opção inválida. Por favor, selecione uma opção válida.");
                    break;
            }
        }
    }
}
