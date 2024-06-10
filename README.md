<h1>RestClientsMVVM</h1>

<p>RestClientsMVVM é uma aplicação que demonstra o uso de padrões de arquitetura MVVM (Model-View-ViewModel) em um aplicativo multiplataforma usando o framework .NET MAUI.</p>

<h2>Descrição</h2>

<p>Esta aplicação permite que o usuário gerencie uma lista de clientes, realizando operações CRUD (Create, Read, Update, Delete) sobre os dados dos clientes. Ela utiliza uma abordagem baseada em ViewModels para separar a lógica de apresentação (View) da lógica de negócios (ViewModel).</p>

<h2>Recursos</h2>

<ul>
  <li>Adicionar um novo cliente</li>
  <li>Visualizar a lista de clientes</li>
  <li>Editar informações de um cliente existente</li>
  <li>Excluir um cliente da lista</li>
</ul>

<h2>Estrutura do Projeto</h2>

<ul>
  <li><strong>Models:</strong> Contém as classes de modelo que representam os dados da aplicação, como a classe <code>Cliente</code>.</li>
  <li><strong>Services:</strong> Contém os serviços de acesso aos dados, como o serviço <code>ClienteDatabase</code> para operações CRUD no banco de dados SQLite.</li>
  <li><strong>ViewModels:</strong> Contém as ViewModels que fornecem dados e comportamento para as Views da aplicação, como as ViewModels <code>MainViewModel</code> e <code>ClienteViewModel</code>.</li>
  <li><strong>Views:</strong> Contém as Views da aplicação, implementadas em XAML, como as páginas <code>MainPage</code> e <code>ClientePage</code>.</li>
  <li><strong>AppShell:</strong> Define a estrutura da aplicação e as rotas de navegação entre as páginas.</li>
</ul>

<h2>Configuração</h2>

<ol>
  <li>Clonar o repositório: <code>git clone https://github.com/seu-usuario/RestClientsMVVM.git</code></li>
  <li>Abrir o projeto no Visual Studio ou Visual Studio Code.</li>
  <li>Compilar e executar o projeto.</li>
</ol>

<h2>Pré-requisitos</h2>

<ul>
  <li>.NET MAUI SDK instalado</li>
  <li>Visual Studio 2022 ou Visual Studio Code com extensões relevantes</li>
</ul>

<h2>Tecnologias Utilizadas</h2>

<ul>
  <li>.NET MAUI</li>
  <li>C#</li>
  <li>XAML</li>
  <li>SQLite</li>
</ul>

<h2>Contribuição</h2>

<p>Contribuições são bem-vindas! Sinta-se à vontade para abrir uma issue para reportar bugs ou solicitar novos recursos. Se desejar contribuir com código, faça um fork do repositório, faça as alterações e envie um pull request.</p>

<h2>Licença</h2>

<p>Este projeto está licenciado sob a <a href="https://opensource.org/licenses/MIT">MIT License</a>.</p>

</body>
</html>
