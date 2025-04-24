# DESF5 - Atividade do Desafio Final

Este projeto é uma API RESTful em .NET Core com arquitetura MVC, criada como parte da atividade final da disciplina de Arquitetura de Software.

## 🧱 Estrutura

- CRUD de produtos
- Serviço (Service Layer)
- Repositório (Repository Pattern)
- EF Core com banco em memória
- Testável e simples para evoluções futuras

## 🚀 Como executar

1. Clone este repositório
2. Execute `dotnet restore` e `dotnet run` na pasta `ProdutoApi/`
3. Acesse os endpoints via Postman ou Swagger

## Endpoints principais

- `GET /api/produto`
- `GET /api/produto/{id}`
- `GET /api/produto/buscar/{nome}`
- `POST /api/produto`
- `DELETE /api/produto/{id}`
- `GET /api/produto/contar`

---
Projeto desenvolvido com fins didáticos para o desafio final.