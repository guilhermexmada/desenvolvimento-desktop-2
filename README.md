
# 🎓 Aulas de desenvolvimento desktop - módulo 02

Este repositório guarda todos os exercícios realizados no segundo módulo da disciplina de desenvolvimento para desktop com C#, dentro do curso técnico de Desenvolvimento de Sistemas da ETEC de Registro-SP, com o professor Luiz.

As aulas do módulo 02 tinham como objetivo a introdução a Programação Orientada a Objetos na construção de programas de computador desktop.

## 🗃 Como visualizar?
Cada pasta do repositório guarda uma atividade diferente desenvolvida no ambiente Visual Studio 2015. Todas as atividades são aplicações windows form na linguagem C#. 

Aqui vai um passo a passo para visualizar as atividades, do mesmo modo que foi realizado em aula:

1. Baixe este repositório.
2. Instale o Visual Studio. Você pode usar [este](https://visualstudio.microsoft.com/pt-br/) link.
3. Instale o XAMPP. Você pode usar [este](https://www.apachefriends.org/pt_br/index.html) link.
3. Instale o HeidiSQL. Você pode usar [este](https://www.heidisql.com/download.php) link.
4. No painel de controle do XAMPP, você deve iniciar o serviço **MySQL**.
4. No gerenciador de sessões do HeidiSQL, você deve adicionar uma sessão usando o botão "Nova". Para que a sessão não entre em conflito com as configurações das atividades, ela deve possuir:
- Servidor/IP: **127.0.0.1**
- Usuário: **root**
- Nenhuma senha
5. Entre no repositório baixado, acesse a pasta com a atividade que você deseja visualizar e procure um arquivo de extensão *.sql* (se a atividade utilizar banco de dados, ele estará disponível através deste arquivo)
6.  Abra o arquivo *.sql* com o programa HeidiSQL e execute o código usando **CTRL+A** e **F9**. Você também pode entrar na sessão do HeidiSQL e selecionar a opção *arquivo > executar arquivo SQL...* (isto deve baixar o banco de dados usado na atividade)
3. Para visualizar a atividade, você pode abrir o Visual Studio e selecionar a opção *File>Open>Project/Solution* e então localizar o arquivo *Program.cs* dentro do diretório da atividade
4. Você também pode procurar diretamente o arquivo *Program.cs* no repositório baixado e tentar abrí-lo com o programa Visual Studio
5. Estando com a atividade aberta, clique no botão "Start" ou na tecla F5 para executar a atividade, abrindo uma janela com interface padrão do Windows

## ❓ O que é Windows Form Application?
É um tipo de projeto .NET que cria programas para computador de forma facilitada, pois permite montar interfaces de usuário "arrastando e soltando" elementos (chamados de "controls") dentro do Visual Studio.

Dentre os controles que podem ser usados nesse tipo de projeto, temos botões, formulários, menus, textos, listas, barras de progresso, abas, containers, imagens, entre outros.

## ❓ O que é .NET?
A .NET (dot net) é uma plataforma de desenvolvimento unificado criada pela Microsoft. Trata-se de um grande ecossistema para desenvolver sistemas diversos, possuindo ferramentas como:
- IDEs (ambientes de desenvolvimento integrado)
- APIs (aplicações e serviços de terceiros)
- Frameworks (sistemas multifunções para linguagens específicas)
- Libs ou bibliotecas (conjuntos de funções e recursos para linguagens específicas)

Além disso, a .NET é multiplataforma - pode ser usada em Windows, Linux ou macOS.

## 📦 O que é Programação Orientada a Objetos?

A Programação Orientada a Objetos (POO) é um paradigma de programação, ou seja, uma maneira de programar que aproxima o código do mundo real, visando resolver problemas de forma mais eficiente.

Diverge do paradigma conhecido como programação estruturada, que tenta codificar apenas através de funções e estruturas de controle como condições e laços, organizando o software em blocos lógicos.
 
A POO organiza o software em classes e objetos. Essas estruturas tentam "imitar" as características e comportamentos de entidades reais para melhorar a reutilização e a manutenção do código. 

Esse conceito pode ser aplicado à várias linguagens de programação e possui alguns fundamentos:
- 🚹 **Classes**: abstração de um elemento ou grupo de elementos reais, possuindo atributos e métodos
- 🔖 **Atributos**: características de uma classe, representadas por variáveis que armazenam dados
- 🔧 **Métodos**: comportamentos de uma classe, representadas por funções
- 🙋🙋‍♀️ **Objetos**: são instâncias de classes, ou seja, entidades específicas que derivam de um grupo maior, possuindo seus mesmos atributos  e métodos
- 📝 **Abstração**: capacidade de representar entidades abstratas ou concretas da vida real em formato de código
- ⬇️ **Herança**: transferência de propriedades entre classes ou de uma classe para um objeto
- 🎛 **Polimorfismo**: capacidade de objetos usarem os mesmos métodos, mas de formas diferentes
- 🔒 **Encapsulamento**: possibilidade de ocultar detalhes internos das entidades, controlando a herança e o polimorfismo

## ✏️ Meu aprendizado em C# para Windows Forms Application
1. Construção e interação com interfaces
2. Exibição de listas e gráficos
3. Conexão e operações com banco de dados relacional
4. Programação orientada a objetos
5. Formatação de dados em arquivos para impressão

## Tecnologias utilizadas

[![My Skills](https://skillicons.dev/icons?i=cs,visualstudio,mysql)](https://skillicons.dev)

## 📃 Licença

- [MIT](https://choosealicense.com/licenses/mit/)

## 👤 Sobre mim
- 👤 Guilherme Shimada Pereira ([guilhermexmada](https://github.com/guilhermexmada))
- 🎓 Técnico em Desenvolvimento de Sistemas (2024)
- 🎓 Cursando Desenvolvimento de Software Multiplataforma (até 2027!) 
- 🚀 Rumo à Cibersegurança!

## 🔗 Referências

- Visual Studio: [visualstudio.microsoft](https://visualstudio.microsoft.com/pt-br/)
- XAMPP: [apachefriends.org](https://www.apachefriends.org/pt_br/index.html)
- HeidiSQL: [heidisql/download](https://www.heidisql.com/download.php)
- Ícones das tecnologias: [tandpfun/skill-icons](https://github.com/tandpfun/skill-icons)
- Emojis: [piliapp/emoji](https://getemoji.com/)
