# Linguagens e Compiladores

## Níveis de acesso

Sempre que falamos em enviar instruções ao computador, nos referimos a instruções a nível de máquina, ou diretamente ao hardware (Processador, Memória, Disco...). Estas instruções sempre serão no formato binário, afinal o computador não fala outra língua, então dizemos que estas instruções são de **baixo nível**. Quanto maior o nível de detalhe da instrução, mais baixo terá de ser o nível a ser adentrado utilizando alguma linguagem de programação.

As linguagens mais novas como C#, Java e demais, são consideradas linguagens de **alto nível**, justamente por prover uma abstração aos níveis mais baixos. Então se você precisa escrever um valor específico em um local específico da memória por exemplo, você precisa de mais liberdade, e terá muito mais trabalho.

Veja uma simples comparação entre uma linguagem de baixo nível (Assembly) e uma de alto nível (C#).

```assembly
			global    _start

		    section   .text
_start:   	mov rax, 1
			mov rdi, 1
			rsi, message
			mov rdx, 13
			syscall
			mov rax, 60
			xor rdi, rdi
			syscall

			section   .data
message:	db        "Hello, World", 10
```

<small>Exemplo escrito em Assembly (Fonte: https://cs.lmu.edu/~ray/notes/x86assembly/).</small>

```csharp
namespace  ConsoleApp1
{
	class  Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Hello World");
		}
	}
}
```

<small>Exemplo escrito em C#.</small>

## Linguagem compilada e interpretada

**Linguagem compilada** precisa da compilação, precisa ser transformada em uma linguagem binária, que a máquina entende. 

*Prós:* detecção de erro é feito em tempo de compilação, aplicação fica com tamanho menor pois no final tudo é transformado para arquivos binários, com um arquivo final após a compilação, tende a ter mais performance pois a máquina lê mais rápido o arquivo binário do que para interpretar um arquivo.

*Contras:* precisa de um compilador, o que pode ter mais burocracia.

**Linguagem interpretada** não é convertida pra binário, são simplesmente lidos. Essa leitura e interpretação do que precisa ser feito é feito em tempo real, em tempo de execução. Javascript por exemplo é uma linguagem interpretada.

*Prós:* não precisa ser compilada, o que facilita correções, e é mais simples de ser distribuída.

*Contras:* detecção de erros acontece sómente em tempo de execução, o tamanho da aplicação final fica maior (pois são arquivos de texto e não binários), como os arquivos são interpretados a otimização não é feita ou é feita parcialmente.

## Tipagem de dados

Linguagens tipadas obrigam a especificar o tipo de dado da informação. Isso dá uma menor liberdade na escrita de código, mas fornece uma maior otimização pois o sistema já sabe onde armazenar cada tipo de informação na memória.

```csharp
int idade;
```
<small>Exemplo tipagem de dados em C#.</small>