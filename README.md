# Backend Challenge 
## API Validação de senha
Para construir a API em questão, foi utilizado o Design Pattern **Builder**

A ideia foi realizar a validação da senha mantendo a praticidade para mudanças futuras fazendo com que a API tenha uma facilidade para extensibilidade, e sempre mantendo a coesão.

Em seguida foi implementado o **Teste unitário** utilizando como parametro de password o valor "AbTp9!fok" que passará em todas as validações do teste.

## Instruções

É um projeto simples de ser utilizado, após clonar o projeto e builda-lo, o metodo a ser chamado é o **Validate**, e o mesmo recebe um único parametro do tipo **string** com o nome de **password** via POST.Com isso a API retornará um **Boolean** informando se a senha seria aceita.

> #### Validações
>
> - Nove ou mais caracteres.
> - Ao menos 1 dígito.
> - Ao menos 1 letra minúscula.
> - Ao menos 1 letra maiúscula.
> - Ao menos 1 caractere especial.
> - Não possuir caracteres repetidos dentro do conjunto.

