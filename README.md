
# Gestão de Profissionais

- Sistema para gerenciar profissionais e suas especialidades.

## Funcionalidades
- Cadastro de Profissionais: Adicione profissionais com informações específicas, como nome, documento e especialidade.
- Edição de Profissionais: Atualize informações existentes de profissionais.
- Exclusão de Profissionais: Remova profissionais cadastrados.
- Filtro por Especialidade: Liste profissionais filtrando por especialidade.
- Gerenciamento de Especialidades: Consulte todas as especialidades disponíveis.

## Tecnologias Utilizadas
- .NET 8.0
- SQLite
- Entity Framework Core
- ASP.NET MVC

## Configuração e Execução do Projeto

**1 - Clone o Repositório**
- git clone

**2 - Configure a String de Conexão**

```javascript
{
  "ConnectionStrings": 
  {
    "DefaultConnection": "Data Source=gestao.db"
  }
}
```

- Escreva o comando **dotnet ef database update** no terminal para executar as migrações.

**3 - Execute o Projeto**
- dotnet run

## Estrutura do Projeto

**Controllers:**
- **HomeController:** Controla a lógica de negócios para as páginas iniciais, como listagem, adição, edição e exclusão de profissionais.

**Data:**
- **AppDbContext:** Contexto do Entity Framework para gerenciar entidades e interagir com o banco de dados.

**Models:**
- **Profissional:** Representa um profissional cadastrado.
- **Especialidade:** Representa uma especialidade.
- **ErrorViewModel:** Gerencia erros na aplicação.

**Repositories:**
- **ProfissionalRepository:** Gerencia as operações de CRUD para profissionais.
- **EspecialidadeRepository:** Gerencia as operações de CRUD para especialidades.

## Como usar

- Acesse a página inicial para visualizar todos os profissionais cadastrados.
- Use o filtro para selecionar profissionais por especialidade.
- Cadastre novos profissionais na seção Adicionar Profissional.
- Edite ou exclua profissionais conforme necessário.
