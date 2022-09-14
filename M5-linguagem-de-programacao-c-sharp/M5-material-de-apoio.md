# Linguagem de Programação C#

- [Escopo do programa](#escopo-do-programa)
- [Namespaces](#namespaces)
- [Using](#using)
- [Variáveis e constantes](#variáveis-e-constantes)
- [Comentários](#comentários)
- [System](#system)
- [Tipos](#tipos)
- [Nullable Types](#nullable-type)
- [Alias](#alias)
- [Conversão de dados](#conversão-de-dados)
- [Parse](#parse)
- [Convert](#convert)
- [Métodos e funções](#métodos-e-funções)
- [Value Types e Reference Types](#value-types-e-reference-types)
- [Struct](#struct)
- [Enum](#enum)
## Escopo do programa

- Importações
- Namespaces
- Classe
- Método principal

## Namespaces

Pastas são divisões físicas, namespaces são divisões lógicas, pois durante a compilação as divisões físicas serão perdidas e sobrará apenas a divisão lódica. Assim como não podemos ter dois arquivos com o mesmo nome na pasta, o ideal é ter um namespace e uma classe por aquivo. Não pode ter duas classes com o mesmo nome no mesmo namespace. 

Normalmante o namespace tem o mesmo nome da pasta. É possível ter um namespace dentro de outro usando um ponto. A importação é feita pelo namespace.

## Using

Palavra reservada para fazer importações

## Variáveis e constantes

Não é possível iniciar uma variável ou constante com as palavras reservadas ```var``` sem inicializá-la (atribuir valor). A variável tera o tipo do primeiro valor atribuído.

Constantes são mais otimizadas que as variáveis e necessitam que o tipo esteja explícito logo depois da palavra reservada.


## Comentários

**Uma linha**

```csharp
// comentário de uma linha
```

**Múltiplas linhas**

```csharp
/*
comentário de
múltiplas linhas
*/
```

**XML (metadata)**

```csharp
/// notação XML
```  

## System

Tipo base para o .NET do qual os outros tipos derivam. O uso é implícito.

## Byte

Em C# temos o tipo ```byte``` para representar um byte de fato. É útil para por exemplo fazer leitura de arquivos usando cadeira de bytes. ```sbyte``` (signed byte) permite valores negativos.

```csharp
byte meubyte = 127;
```

## Tipos

```csharp
// em ordem do menor para o maior:
short inteiro = 2;
int inteiro2 = 2;
long inteiro3 = 2;

float real = 23.5F;
double real2 = 23.5; // é o único que não precisa de notação
decimal real3 = 23.5M;

bool boolean = true;

char caracter = 'A'; // aspas simples
string palavra = "palavra"; // aspas duplas

// object: tipo genérico, útil quando não sabemos o tipo que vamos usar
object objetoIndefinido; // diferente do var, é possível inicializar sem valor
object objeto = 2;
object objeto2 = 23.5;
object objeto3 = true;
object objeto4 = 'B';
object objeto5 = "palavra";
```

## Nullable type

É possível atribuir ```null```à um objeto desde que seja marcado como nullable usando uma interrogação na frente do tipo. Todo tipo primitivo pode ser nullable.

```csharp
int? idade = null;
```

## Alias

Apelido que todo tipo do .NET tem, por exemplo o tipo ```string``` é alias de ```System.String```. É recomendado sempre usars o alias pois escrevemos menos.

## Conversão de dados

**Conversão implícita**

Conversões que podem ser executadas com passagem de dados e com dados compatíveis, e se o tamanho do dado for coerente.

```csharp
float valor = 25.8F
int outro = 25;

valor = outro; // número float pode ser um inteiro, por isso a conversão está correta
```

**Conversão explícita**

Quando os tipos não são compatíveis, usando parênteses antes da atribuição

```csharp
int inteiro = 100;
uint inteiroSemSinal = (uint)inteiro;
```

## Parse

Método presente em todo tipo primitivo, usado para converter um char ou string para outro tipo. Caso haja incompatibilidade, gera erro.

```csharp
int inteiro = int.Parse("100");
int inteiro = int.Parse("2");

int inteiro = int.Parse("teste"); // dará erro pois não é um número
```

## Convert

Diferente do parse, permite a conversão de vários tipos de valor, não somente string e char. Caso haja incompatibilidade, gera erro.

```csharp
int inteiro = Convert.toInt32("100");
int inteiro2 = Convert.ToInt32(2312.9);
```

## Métodos e funções

Definição de um método:

```csharp
static string RetornaNome(string nome, string Sobrenome)
{
    return nome + " " + sobrenome;
}

static void Main(string args[])
{
    var nome = RetornaNome("Trixie", "Mattel");

    Console.WriteLine(nome); // Trixie Mattel
}
```

## Value Types e Reference Types

A memória é dividida em Heap, que armazena os dados, e Stack, que armazena as referência dos dados.

Value types armazenam dados e usam o local Stack da memória. Quando um valor é armazenado, a memória é alocada, e a variável acessa esse dado diretamente. Built-in, Struct e Enum são value types.

```csharp
int x = 25;
int y = x; // cria uma cópia de x, são duas variáveis independentes
```

Reference types armazenam o endereço do objeto que contém os dados. São armazenados no Heap. Ao assimilar uma variável, ela cria uma referência apontando para a mesma informação. Classes, Objects, Arrays são reference types.

```csharp
var arr = new string[2];
arr[0] = "Item 1";
var arr2 = arr; // não cria uma cópia
```

**Garbage collector:** fica olhando a memória Heap e quando um objeto não está em uso, deleta esse objeto. Não acessa a Stack.

## Struct

São tipos de dado estruturado, apenas a estrutura, o esqueleto. É composto de propriedades e métodos. A instância é criada a partir da palavra ```new```.

```csharp
struct Product
{
    public int Id;
    public float Price;

    public float PriceInDolar(float dolar)
    {
        return Price * dolar;
    }
}
```

## Enum

Usados em listas curtas e dados fixos. Sempre começa com a letra E. 

```csharp
enum EEstadoCivil
{
    Solteiro = 1,
    Casado = 2,
    Divorciado = 3
}
```

Depois de criado pode ser usado como tipo.

```csharp
public EEstadoCivil EstadoCivil;

var cliente = new Cliente("Trixie", EEstadoCivil.Caasado);

Console.WriteLine(cliente.EstadoCivil); // Casado
Console.WriteLine((int)cliente.EstadoCivil); // 2
```