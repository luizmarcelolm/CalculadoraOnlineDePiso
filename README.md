<h1>Calculadora online de piso</h1>

<h2>Link da aplicação 🔗 https://calculadoraonlinedepiso.azurewebsites.net/</h2>

 <img src="https://github.com/luizmarcelolm/CalculadoraOnlineDePiso/blob/master/wwwroot/Imagens%20readme/1.png" /> 

<h2>O que utilizei:</h2>
<ul>
 <li>Asp.net mvc</li>
 <li>C#</li>
 <li>Css</li> 
 <li>Bootstrap</li>
 <li>Library IronPdf</li>
 <li>Azure</li>
</ul> 

<h1>Como utilizar a aplicação:</h1>
<h3>Deixei o menu o mais simples possível para o usuário não perder tempo procurando as informações para fazer os cálculos. Clicando em (calcular área) ou (adicionar novo) você já é direcionado para digitar as informações. 👇</h3>
 <img src="https://github.com/luizmarcelolm/CalculadoraOnlineDePiso/blob/master/wwwroot/Imagens%20readme/2.png" /> 


<h3>Após clicar em adicionar novo ou calcular área, irá abrir outra página para inserir as informações solicitadas. O formulário irá fazer as validações das informações digitadas e enviar caso entiver tudo corredo. No formulário você podera selecionar a opção de adicionar mais 10% nos cálculos para eventuais quebras e perdas na instalação. 👇</h3>
 <img src="https://github.com/luizmarcelolm/CalculadoraOnlineDePiso/blob/master/wwwroot/Imagens%20readme/3.png" /> 


<h3>Após o envio dos cálculos é criado um item na página inicial com as informações digitadas, e botões de verificar as medidas, criar pdf, editar e excluir. 👇</h3>
 <img src="https://github.com/luizmarcelolm/CalculadoraOnlineDePiso/blob/master/wwwroot/Imagens%20readme/4.png" /> 

<h3>Ao clicar em verificar medidas, você irá visualizar as informações digitadas como local e o cálculo da metragem, quantidade de piso com a opção de adição de 10% sim ou não. 👇</h3>
 <img src="https://github.com/luizmarcelolm/CalculadoraOnlineDePiso/blob/master/wwwroot/Imagens%20readme/5.png" /> 
 
<h3>No icone do pdf gera um arquivo para você salvar caso precise. 👇</h3>
<img src=”https://github.com/luizmarcelolm/CalculadoraOnlineDePiso/blob/master/wwwroot/Imagens%20readme/6.png”>


<h3>No icone de editar você é direcionado para uma página onde as informações digitadas anteriormente aparecem nos campos e podem ser alteradas conforme a necessidade, ao final do formulário é só clicar em alterar e será feita a alteração. 👇</h3>
 <img src="https://github.com/luizmarcelolm/CalculadoraOnlineDePiso/blob/master/wwwroot/Imagens%20readme/7.png" /> 
 
<h3>E o icone da lixeira exclui o item. 👇</h3>
 <img src="https://github.com/luizmarcelolm/CalculadoraOnlineDePiso/blob/master/wwwroot/Imagens%20readme/8.png" /> 
 
<h3>No menu principal tem um item de como fazer os cálculos, ai clicar nele vc será direcionado a página com a explicação dos cálculos. 👇</h3>
 <img src="https://github.com/luizmarcelolm/CalculadoraOnlineDePiso/blob/master/wwwroot/Imagens%20readme/9.png" /> 
 
<h3>É possível fazer o acesso em celulares e tablets também.👇</h3>
 <img src="https://github.com/luizmarcelolm/CalculadoraOnlineDePiso/blob/master/wwwroot/Imagens%20readme/10.png" /> 
 
<h1>Desafios que encontrei no código.</h1>
<h3>Quando fiz os testes para fazer o cálculo da metragem no visual studio 2022 funcionou perfeitamente, porém após fazer o deploy utilizando azure não gerava os dados corretos, no input quando inseria um número quebrado como 0,9 o cálculo éra feito somente como número 9. Isso é devido a utilização de , ou . dependendo da região, como utilizo azure da microsoft o sistema não entendia a , e foi necessário adicionar esse código na classe startup para funcionar. 👇</h3>
 <img src="https://github.com/luizmarcelolm/CalculadoraOnlineDePiso/blob/master/wwwroot/Imagens%20readme/11.png" /> 
 
<h3>Para gerar o pdf do item correto precisei concatenar o link da página + o ID do item correspondente. 👇</h3>
 <img src="https://github.com/luizmarcelolm/CalculadoraOnlineDePiso/blob/master/wwwroot/Imagens%20readme/12.png" /> 






















