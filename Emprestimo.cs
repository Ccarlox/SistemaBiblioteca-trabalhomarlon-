using System;

namespace SistemaBiblioteca
{
    public class Emprestimo
    {
        public Livro LivroEmprestado { get; set;}
        public string NomeCliente { get; set;}
        public DateTime DataDevolucao { get; set;}

        public Emprestimo(Livro livro, string cliente)
        {
            LivroEmprestado = livro;
            NomeCliente = cliente;

            DataDevolucao = DateTime.Now.AddDays(7);

            livro.EstaDisponivel = false;
        }
    }
}