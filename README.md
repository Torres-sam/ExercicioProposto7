# ExercicioProposto7

Este é um projeto simples em C# que solicita ao usuário um número inteiro e informa se o número é **negativo**, **zero** ou **positivo**.

## 💡 Descrição

O programa recebe um valor digitado pelo usuário, verifica o sinal do número e exibe uma mensagem correspondente. É um exemplo básico de uso de estrutura condicional (`if`, `else if`, `else`) em C#.

## 🧪 Exemplo de uso

Digite um valor inteiro: -10
O número é negativo !

Digite um valor inteiro: 0
O número é 0

Digite um valor inteiro: 25
O número é positivo !

🔧 Como executar
Certifique-se de ter o .NET SDK instalado.

Clone este repositório:

git clone https://github.com/Torres-sam/ExercicioProposto7.git
Acesse o diretório do projeto:

cd ExercicioProposto7
Compile e execute o projeto:

dotnet run
📁 Estrutura
Copiar
Editar
ExercicioProposto7/
├── Program.cs
├── ExercicioProposto7.csproj
└── README.md

🧠 Conceitos abordados
Leitura de dados com Console.ReadLine()

Conversão de string para inteiro com int.Parse

Estruturas condicionais em C#

Validação de entrada (opcional)

✅ Possível melhoria
Você pode melhorar o programa usando int.TryParse para evitar exceções quando o usuário digitar algo inválido.
