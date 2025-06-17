# Diagram

## Overview
Solução direcionada para exemplo de código!

Abordagem dos temas:
- Design Patterns

## Criacional
- Abstract Factory
Abstract Factory é um padrão de design criacional que resolve o problema de criar famílias inteiras de produtos sem especificar suas classes concretas.

Abstract Factory define uma interface para criar todos os produtos distintos, mas deixa a criação real do produto para classes de fábrica concretas. Cada tipo de fábrica corresponde a uma certa variedade de produto.

O código do cliente chama os métodos de criação de um objeto factory em vez de criar produtos diretamente com uma chamada de construtor ( newoperador). Como um factory corresponde a uma única variante de produto, todos os seus produtos serão compatíveis.

O código do cliente trabalha com fábricas e produtos somente por meio de suas interfaces abstratas. Isso permite que o código do cliente trabalhe com quaisquer variantes de produto, criadas pelo objeto de fábrica. Você apenas cria uma nova classe de fábrica concreta e a passa para o código do cliente.

## Estrutural
- Adaptor
Adaptador é um padrão de design estrutural que permite que objetos incompatíveis colaborem.

O Adapter atua como um wrapper entre dois objetos. Ele captura chamadas para um objeto e as transforma em formato e interface reconhecíveis pelo segundo objeto.

## Comportamental
- Strategy
Estratégia é um padrão de design comportamental que transforma um conjunto de comportamentos em objetos e os torna intercambiáveis ​​dentro do objeto de contexto original.

O objeto original, chamado contexto, contém uma referência a um objeto de estratégia. O contexto delega a execução do comportamento ao objeto de estratégia vinculado. Para alterar a maneira como o contexto realiza seu trabalho, outros objetos podem substituir o objeto de estratégia vinculado atualmente por outro.

# References
- https://en.wikipedia.org/wiki/Software_design_pattern 
- https://www.fabiosilvalima.net/design-patterns-no-mundo-real/ 
- http://www.macoratti.net/13/09/net_dp1.htm
- https://refactoring.guru/design-patterns/abstract-factory
- https://refactoring.guru/design-patterns/adapter
- https://refactoring.guru/design-patterns/strategy