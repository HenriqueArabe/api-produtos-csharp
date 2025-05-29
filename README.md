# API Produtos C# 🤖📦

**API RESTful** em **ASP.NET Core** com **Swagger** para gerenciar produtos de forma simples e elegante.

---

## 🎯 Objetivo do Projeto

Esse projeto serve como demonstração de:

* Criação de APIs com **ASP.NET Core Web API**
* Documentação e testes via **Swagger UI**
* Operações CRUD (Create, Read, Update, Delete) em memória
* Uso de **DataAnnotations** para validação de modelos
* Versionamento incrementando commits claros para portfólio

---

## 🚀 Funcionalidades

* **Listar produtos**: `GET /api/produtos`
* **Buscar produto**: `GET /api/produtos/{id}`
* **Adicionar produto**: `POST /api/produtos`
* **Atualizar produto**: `PUT /api/produtos/{id}`
* **Remover produto**: `DELETE /api/produtos/{id}`

---

## 🛠️ Tecnologias

* **.NET 8.0**
* **ASP.NET Core Web API**
* **Swashbuckle/Swagger**
* **C# 10**

---

## ⚙️ Pré-requisitos

* [.NET 6 SDK](https://dotnet.microsoft.com/download)
* **Git** instalado
* **Visual Studio 2022** (ou superior) ou qualquer IDE compatível

---

## 📥 Como Executar

1. **Clone** o repositório:

   ```bash
   git clone https://github.com/seu-usuario/api-produtos-csharp.git
   cd api-produtos-csharp/MinhaApiProdutos
   ```

2. **Restaure** dependências e **execute**:

   ```bash
   dotnet restore
   dotnet run
   ```

3. Abra no navegador:

   * HTTPS (recomendado): `https://localhost:5243`
   * HTTP (se desativou HTTPS): `http://localhost:5243`

   O **Swagger UI** estará disponível na raiz, permitindo testar todos os endpoints.

---

## 📋 Exemplos de Uso

**Criar um produto** (POST):

```json
{
  "id": 3,
  "nome": "Monitor",
  "preco": 799.99
}
```

**Atualizar produto** (PUT):

```json
{
  "id": 3,
  "nome": "Monitor 4K",
  "preco": 999.99
}
```

**Resposta de Erro** (400 Bad Request):

```json
{
  "errors": {
    "Nome": ["O nome é obrigatório."],
    "Preco": ["Preço deve estar entre R$0,01 e R$10.000,00."]
  }
}
```

---

## 🌟 Contribuições

Contribuições são bem-vindas! Sinta-se à vontade para abrir **issues** ou **pull requests**.

---
