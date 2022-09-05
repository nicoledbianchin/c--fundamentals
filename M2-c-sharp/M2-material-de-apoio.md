# C#

## Por que escolher C#

C# é uma linguagem de programação tipada, compilada e gerenciada, é a principal linguagem da Microsoft, criada em 2001 pelo mesmo criador do Typescript, Anders Hejlsberg. É uma linguagem orientada a objetos.

É uma das linguagens mais completas do mercado, pois faz parte de um ecossistema inteiro (.NET), então serve para aplicações mobile, web, machine learning, criação de jogos, entre outros. Também é uma linguagem muito bem atualizada em desde 2001.

Tem uma maturidade muito grande por ter muitos anos de vida, tem uma comunidade muito grande, que tem um mercado sempre em expansão até por ter o Microsoft por trás.

## Código gerenciado

A execução precisa de um gerenciador pra executar. Código gerenciado também é conhecido como **Runtime**. O gerenciador, ou CLR (Common Language Runtime) gerencia memória, segurança, e outros recursos básicos. 

Dessa forma interagimos menos ou quase não interagimos com os recursos da máquina diretamente. Isso reduz possívels erros e bugs.

## Compilação e gerenciamento

Quando o ecossistema de desenvolvimento Microsoft foi criado, foi pensado para dar suporte a várias linguagens. Dessa forma, as outras linguagens da Microsoft como VB.NET, F# e Cobol.NET todas tem o mesmo gerenciador.

Os compiladores de cada linguagem ficam separados, e essa compilação gera um código intermediária, a **Intermediate Language** (IL), criada pela Microsoft. Em suma, temos um compilador para cada linguagem, mas um gerenciador único, afinal a alocação de memória dentre outros recursos de hardware são a mesma.

O fluxo que acontece então é: o CLR recebe o código em C#, utiliza seu compilador específico, e como resultado final temos um outro código, em uma linguagem única que o runtime entende, a IL. A partir da IL é gerado o código que a máquina entende.

O processo de converter o IL para código de máquina é chamado de **Just in time**, o JIT.

Em resumo:

- Escrevemos nosso código em C# (Alto nível)
- É gerado um código intermediário (IL)
- O CLR recebe o IL e transforma em linguagem de máquina
- O código então é executado e passa a ser gerenciado