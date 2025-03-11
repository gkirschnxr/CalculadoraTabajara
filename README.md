# Calculadora Tabajara 2025

![](https://imgur.com/xANU6aj)


## Introdução

Uma calculadora de console simples, que permite realizar as quatro operações matemáticas.

## Funcionalidades

- **Operações básicas:** Realize somas, subtrações, multiplicações e divisões com facilidade
- **Suporte a decimais:** Trabalhe com números até três casas decimais;
- **Validação de entrada:** Garante que apenas números válidos sejam aceitos;
- **Divisão por zero:** Valida erros se divisão por zero;
- **Tabuada:** Gera a tabuada até 10 do número informado;
- **Histórico de operações:** Armazena o histórico de operações.

## Como utilizar

1. Clone o repositório ou baixe o código fonte;
2. Abra o terminal ou o prompt de comando e navegue até a pasta raiz;
3. Utilize o comando abaico para restaurar as dependências do projeto.
```
dotnet restore
```
4. Em seguida, compile a solução utilizando o comando:
```
dotnet build --configuration Release
```
5. Para executar o projeto compilando em tempo real
```
dotnet run --project CalculadoraTabajara.ConsoleApp
```
6. Para executar o arquivo compilado, navegue até a pasta `./CalculadoraTabajara.ConsoleApp/bin/Release/net8.0/` e execute o arquivo:
```
CalculadoraTabajara.ConsoleApp.exe
```
## Requisitos

- .NET SDK (recomendado .NET 8.0 ou superior) para compilação e execução do projeto.