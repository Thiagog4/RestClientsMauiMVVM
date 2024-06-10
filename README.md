RestClientsMVVM
RestClientsMVVM é uma aplicação que demonstra o uso de padrões de arquitetura MVVM (Model-View-ViewModel) em um aplicativo multiplataforma usando o framework .NET MAUI.

Descrição
Esta aplicação permite que o usuário gerencie uma lista de clientes, realizando operações CRUD (Create, Read, Update, Delete) sobre os dados dos clientes. Ela utiliza uma abordagem baseada em ViewModels para separar a lógica de apresentação (View) da lógica de negócios (ViewModel).

Recursos
Adicionar um novo cliente
Visualizar a lista de clientes
Editar informações de um cliente existente
Excluir um cliente da lista
Estrutura do Projeto
Models: Contém as classes de modelo que representam os dados da aplicação, como a classe Cliente.
Services: Contém os serviços de acesso aos dados, como o serviço ClienteDatabase para operações CRUD no banco de dados SQLite.
ViewModels: Contém as ViewModels que fornecem dados e comportamento para as Views da aplicação, como as ViewModels MainViewModel e ClienteViewModel.
Views: Contém as Views da aplicação, implementadas em XAML, como as páginas MainPage e ClientePage.
AppShell: Define a estrutura da aplicação e as rotas de navegação entre as páginas.
Configuração
Clonar o repositório: git clone https://github.com/seu-usuario/RestClientsMVVM.git
Abrir o projeto no Visual Studio ou Visual Studio Code.
Compilar e executar o projeto.
Pré-requisitos
.NET MAUI SDK instalado
Visual Studio 2022 ou Visual Studio Code com extensões relevantes
Tecnologias Utilizadas
.NET MAUI
C#
XAML
SQLite
