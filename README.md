# Projeto Controle_de_Notas
Este projeto é um teste técnico desenvolvido, especialmente, para avaliar as suas 


## índice
- <a href="#-requisitos"> Informações </a>
- <a href="#-requisitos"> Requisitos </a>
- <a href="#-tecnologias-utilizadas"> Tecnologias utilizadas </a>
- <a href ="#regras-de-negocios"> Layout </a>
- <a href="informações"> Infra Estrutura </a>

## Informações
habilidades como desenvolvedor fullstack.
Teste Técnico TechNation - Fullstack 
criação de uma tela do sistema financeiro de uma empresa com os 
dados das notas fiscais emitidas no ano passado (2023) e um dashboard. Essa ferramenta 
será utilizada pelo pessoal responsável pelo financeiro para manter o controle das notas e  saber os principais indicadores

## Requisitos
 Para facilitar a operação do software pelos responsáveis do financeiro, a página deve conter as seguintes informações e funcionalidades:
  - #### Dashboard com Indicadores: indicadores com opções de filtro por mês, trimestre e ano. As seguintes informações devem ser mostradas no dashboard:
    - Valor total das notas emitidas;
    - Valor total das notas emitidas, mas sem ter a cobrança feita;
    - Valor total das notas vencidas - Inadimplência;
    - Valor total das notas a vencer;
    - Valor total das notas pagas;
    - Gráfico de evolução da inadimplência mês a mês;
    - Gráfico de evolução da receita recebida mês a mês;
    - Lista de notas emitidas: Parte da tela onde podemos ver e filtrar as notas fiscais presentes no sistema e aplicar filtros para encontrar as notas desejadas. 
 - #### Informações necessárias:
    - Nome do pagador;
    - Número de identificação da nota;
    - Data de emissão da nota;
    - Data da cobrança;
    - Data do pagamento;
    - Valor da nota;
    - Documento da nota fiscal;
    - Documento do boleto bancário;
    - Status da nota;
        - Emitida;
        - Cobrança realizada;
        - Pagamento em atraso;
        - Pagamento realizado;
 - #### Filtros necessários:
    - Filtrar por mês de emissão da nota;
    - Filtrar pelo mês que a cobrança foi realizada:
    - Filtrar pelo mês que o pagamento foi realizado:
    - Filtrar pelo status da nota

## Tecnologias Utilizadas
- banco de dados SQlite
- EC2 AWS
- GitHub com GitAction para deploy automatico
- Container Docker e DockerHub
- NetCore 8, entityFramework e Blazor
- linux AWS
- JavaScript, Html, Bootstrap
- chart.js

## Layout
![dashbord e graficos do projeto](./assets/Captura%20de%20tela%202024-09-21%20205927.png)
###
###
![Tabela, filtros e paginações](./assets/Captura%20de%20tela%202024-09-21%20210026.png)

## Como rodar o projeto
 é necessario apenas o netCore 8 para rodar, o banco está no projeto principal na camada Controle_de_notas.