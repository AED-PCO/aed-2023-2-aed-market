# AED Market

## Introdução

O sistema AED Market é uma aplicação voltada ao gerenciamento de produtos no estoque de mercados, possuindo todas as funções essenciais, como adicionar produtos, remover produtos, alterar dados de produtos cadastrados, gerar um relatório do estado atual do estoque e possui sistema de login com dados criptografados.

### Inserir produtos

No processo de inserir um produto, o usuário deverá informar o código, o preço, o nome e a quantidade atual do mesmo.

### Remover produtos

Para remover um produto é necessário informar o seu código, esse processo é irreversível e apaga todos os dados relacionados ao produto.

### Alterar dados

Para editar o estoque, o usuário deve fornecer o código do produto desejado, e poderá editar todas as respectivas informações.

### Relatório do sistema

O relatório gerado pelo sistema informa a quantidade total de produtos cadastrados, as respectivas informações de cada produto, o usuário que gerou o relatório e o momento em que o relatório foi gerado.

### Sistema de login

O sistema de login permite o cadastro de usuário e para cada usuário fornece acesso a um "estoque" diferente.

Os usuários têm seu login e senha criptografados para garantir a segurança.

## Detalhes técnicos

A seguir estão alguns detalhes mais técnicos da aplicação.

## Estrutura

A estrutura que será utilizada na aplicação é a lista, mais especificamente a lista duplamente encadeada, pois ela permite um melhor acesso aos produtos além de não ser limitada em tamanho por alguma variável.

## Classes

As classes usadas no projeto, para uma melhor organização.

### Produtos

A classe produtos armazena todos os dados de um produto, seu nome, preço, quantidade, código, próximo produto da lista e o produto anterior da lista.

### Estoque

A classe estoque serve para interagir com os produtos cadastrados, ela adiciona, remove, localiza, lê os produtos salvos e salvas os produtos cadastrados, a classe estoque armazena o primeiro produto, o último produto e quantidade de produtos armazenados.

### Usuário

A classe usuária serve para realizar o processo de login, cadastro e direcionar a qual estoque o usuário tem acesso, além de armazenar dados dos usuários, como nome e senha, e garante que sejam criptografados ao serem salvos.

## Pastas do projeto

Detalhes da separação dos conteúdos/arquivos nas pastas do projeto.

### SRC

Esta pasta contém todos os códigos do projeto, assim como outros arquivos que devam ficar com os mesmos.

### Relatório

Esta pasta é direcionada para o relatório do projeto.

### Docs

Esta pasta contém todos os documentos do projeto (Com exceção da README.md), como projeto das telas e padrões para armazenamento ou organização dos códigos.
