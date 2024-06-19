# Desafio Código
Obs.: A implementação do front não foi necessária.

O que queremos com esse desafio? 

Identificar como é a sua linha de raciocínio para resolver um problema. 
Vamos avaliar: 

Arquitetura de software

Decisões de design de software (Se houver código)

Boas práticas & Clean Code (Se houver código)

## Detalhes do **Desafio**

**O objetivo dessa funcionalidade é desenvolver um cadastro de produto, seguindo os critérios abaixo:**

- o produto precisa ter um id único; que não se repita.
- o produto precisa ter nome; não pode ser nulo.
- o produto precisa ter descrição.
- o produto precisa ter valor; não pode ser menor do que 0,01.
- o produto pode pertencer a varias categorias. A estrutura de categorias precisa respeitar níveis de hierarquia.
Exemplo:
Moveis -> Moveis para escritório -> Mesas para escritório
- em relação aos assets:
    - o produto pode ter até 10 imagens
    - o produto pode ter até 5 vídeos
- o produto pode ter N atributos, contendo uma estrutura de atributos dinâmicos.
Exemplos:
- atributo nome -> tipo texto -> Produto 123
- atributo medida -> tipo numérico -> 100cm

## **Observações:**

**Frontend/Mobile**

Os produtos cadastrados enquanto a aplicação estiver offline, deverá ser enviada após reestabelecer a conexão

**Backend**

- um produto cadastrado precisa ter 100% de disponibilidade
- ao realizar um cadastro, outros sistemas precisam dessa informação;
- o cadastro vai ter no mínimo 20k/s de requisições
