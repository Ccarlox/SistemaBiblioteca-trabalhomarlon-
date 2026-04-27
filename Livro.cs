using System;

namespace SistemaBiblioteca
{
    public class Livro
    {
        public string Titulo { get; set; }
        public string Autor { get; set; }
        public bool EstaDisponivel { get; set; }

        public Livro(string titulo, string autor)
        {
            Titulo = titulo;
            Autor = autor;
            EstaDisponivel = true;
        }
    }
}