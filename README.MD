# Sistema de Gestão de Biblioteca 📚

Este é um mini sistema de console desenvolvido em **C#** para a disciplina de Análise e Desenvolvimento de Sistemas (ADS) na **Universidade Positivo (Ecoville)**. O projeto foca na aplicação de conceitos de Orientação a Objetos e manipulação de listas.

## 👤 Integrantes
* Antonio Carlos Zinho dos Santos; | Murilo Melo Schlichting;

## 🛠️ Funcionalidades
* **Cadastrar Livro:** Permite inserir título e autor de novos exemplares.
* **Listar Livros:** Exibe todos os livros disponíveis no acervo. Caso não haja livros, exibe a mensagem "LIVROS EM FALTA".
* **Buscar Livro:** Localiza um livro específico pelo título (case-insensitive).
* **Realizar Empréstimo:** * O usuário busca o livro desejado.
    * O sistema remove o livro do acervo principal.
    * É gerada uma data de devolução automática para **7 dias** após a data atual.
* **Sair:** Encerra a execução de forma segura.

## 🧠 Lógica de Negócio Implementada
O sistema vai além do cadastro básico (CRUD), apresentando:
1. **Cálculo de Datas:** Uso de `DateTime` para definir prazos de devolução.
2. **Controle de Inventário:** Movimentação de objetos entre listas (`listaDeLivros` para `listaDeEmprestimo`).
3. **Validação de Estado:** Verificação de listas vazias e disponibilidade de itens.

## 🚀 Como Executar
1. Certifique-se de ter o **SDK do .NET 6.0** (ou superior) instalado.
2. Clone o repositório ou baixe os arquivos.
3. Abra o terminal na pasta do projeto.
4. Execute o comando:
   ```bash
   dotnet run