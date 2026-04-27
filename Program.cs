using System.Collections;
using System.Collections.Generic;
using System.Reflection.Metadata;
using SistemaBiblioteca;

List<Livro> listaDeLivros = new List<Livro>();
List<Emprestimo> listaDeEmprestimo = new List<Emprestimo>();

bool rodando = true;

while(rodando)
{
    Console.WriteLine("\n--- MENU DA BIBLIOTECA ---");
    Console.WriteLine("1 - Cadastrar Livro");
    Console.WriteLine("2 - Lista Livros");
    Console.WriteLine("3 - Buscar ");
    Console.WriteLine("4 - Emprestimo ");
    Console.WriteLine("5 - sair");
    Console.WriteLine("Escolha uma opção: ");

    string opcao = Console.ReadLine();


switch (opcao)
{
    case "1":
        Console.Write("Titulo do Livro: ");
        string titulo = Console.ReadLine();
        Console.Write("Autor: ");
        string autor = Console.ReadLine();

        Livro novoLivro = new Livro(titulo, autor);

        listaDeLivros.Add(novoLivro);

        Console.WriteLine("Livro cadastrado com sucesso!");
    break;

    case "2":
        Console.WriteLine("--- LISTA DE LIVROS ---");
        
        if (listaDeLivros.Count == 0)
            {
                Console.WriteLine("Livros em falta");
            }
        else
            {
                
                foreach (var livro in listaDeLivros)
                    {
                        Console.WriteLine($"Titulo: {livro.Titulo} | Autor: {livro.Autor}");
                    }
            }
    break;

    case "3":
    Console.WriteLine("--- BUSCAR LIVRO ---");
    Console.WriteLine("Digite o titulo para busca: ");
    string busca = Console.ReadLine();

    bool encontrado = false;

    foreach (Livro l in listaDeLivros)
    {
        if (l.Titulo.ToUpper() == busca.ToUpper())
            {
                Console.WriteLine($"Livro encontrado! Autor: {l.Autor} | Status: {l.EstaDisponivel}");
                encontrado = true;
            }
            }
        if (!encontrado)
            {
                Console.WriteLine("Livro nao localizado no acervo.");
            }
    break;

    case "4":
        Console.WriteLine("--- REALIZAR EMPRESTIMO ---");

        if (listaDeLivros.Count > 0)
            {
                Console.Write("Digite o titulo do livro que deseja retirar: ");
                string tituloBusca = Console.ReadLine();

                Livro livroEncontrado = null;

                foreach (Livro l in listaDeLivros)
                {
                    if (l.Titulo.ToUpper() == tituloBusca.ToUpper())
                    {
                        livroEncontrado = l;
    break;
                    }
                }
        if (livroEncontrado != null)
                {
                    Console.Write("Nome do Cliente: ");
                    string cliente = Console.ReadLine();

                    Emprestimo novoEmprestimo = new Emprestimo(livroEncontrado, cliente);
                    
                    listaDeEmprestimo.Add(novoEmprestimo);

                    listaDeLivros.Remove(livroEncontrado);

                Console.WriteLine("\n>>> EMPRÉSTIMO REALIZADO <<<");
                Console.WriteLine($"Livro: {livroEncontrado.Titulo}");
                Console.WriteLine($"Cliente: {cliente}");

                Console.WriteLine($"DATA DE DEVOLUCAO: {novoEmprestimo.DataDevolucao.ToShortDateString()}");
                Console.WriteLine("----------------------------");
                }
        else
            {
                Console.WriteLine("Livro nao encontrado no acervo!");
            }
            }
        else
            {
                Console.WriteLine("Nao ha livros no acervo para emprestar. ");
            }
    break;

    case "5":
        Console.WriteLine("Encerrando o sistema...");
        rodando = false;
    break;

}

}
