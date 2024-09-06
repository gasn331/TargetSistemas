# Target Sistemas

Este repositório contém dois exercícios distintos, um sobre cálculo de faturamento e outro sobre estrutura de banco de dados.

## Estrutura do Projeto

- **Faturamento**: Contém o exercício relacionado ao cálculo de faturamento diário de uma distribuidora.
- **BancoDeDados**: Contém o exercício de modelagem e consulta de banco de dados para um sistema de cadastro de clientes.

## 1. Exercício de Faturamento

### Descrição

Dado um vetor que guarda o valor de faturamento diário de uma distribuidora para todos os dias de um ano, o objetivo é criar um programa que calcule e retorne:

- O menor valor de faturamento ocorrido em um dia do ano.
- O maior valor de faturamento ocorrido em um dia do ano.
- Número de dias no ano em que o valor de faturamento diário foi superior à média anual.

**Notas**:
- O vetor já está carregado com as informações de valor de faturamento.
- Podem existir dias sem faturamento (finais de semana e feriados). Estes dias devem ser ignorados no cálculo da média.
- Utilize o algoritmo mais eficiente possível para realizar esses cálculos.

### Implementação

A implementação para este exercício pode ser encontrada na pasta `Faturamento`.

## 2. Exercício de Banco de Dados

### Descrição

Uma empresa solicitou um aplicativo para manutenção de um cadastro de clientes. Após a reunião de definição dos requisitos, foram estabelecidos os seguintes pontos:

- Um cliente pode ter um número ilimitado de telefones.
- Cada telefone de cliente tem um tipo, por exemplo: comercial, residencial, celular, etc. O sistema deve permitir cadastrar novos tipos de telefone.
- O sistema deve permitir cadastrar novos estados brasileiros.

As tarefas incluem:

1. Propor um modelo lógico para o banco de dados que atenda à aplicação, com tabelas e campos necessários.
2. Indicar as chaves primárias (PK) e chaves estrangeiras (FK).
3. Criar uma consulta SQL que retorne o código, a razão social e o(s) telefone(s) de todos os clientes do estado de São Paulo (código “SP”).