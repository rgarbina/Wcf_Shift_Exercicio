# Wcf_Shift_Exercicio

Shift - Tecnologia que pulsa
Núcleo de Inovação e Tecnologia – Gestão de Produtos
Rua Siqueira Campos, 2827 | 3° andar - Centro, São José do Rio Preto - SP, 15010-040
Fone +55 11 3014-3223
Processo de recrutamento
Nome
Data
Caro Candidato, estamos à procura de um novo parceiro de trabalho. Esta tarefa é demasiadamente difícil e requer
sabedoria para uma escolha certeira.
No intuito de conhecê-lo melhor, preparamos este pequeno teste. Pedimos desculpas se estamos subestimando sua
capacidade técnica, mas acredite, nossas intenções são as melhores e mais profundas possíveis.
Este teste é composto por 3 exercícios:
Os dois primeiros são para voltados para conceitos e aplicação de integrações de sistemas e o ultimo trata-se da criação
de consultas básicas ao banco de dados. Utilize a linguagem SQL para resolução desse exercício.
Boa sorte!
1º Exercício – O laboratório ShiftLabs precisa otimizar e automatizar a chegada dos pedidos para a área técnica, por isso ele
está solicitando que seus parceiros enviem os pedidos para um webservice disponibilizado pela ShiftLabs na rede.
Peço que elaborem uma rotina, em qualquer linguagem, que consuma o webservice do ShiftLabs de acordo com a
documentação. Abaixo segue a documentação:
Campos Tipo Descrição
Identificador String Enviar o nome completo do candidato
Pedido.Codigo String Base64 dos campos [Identificador] concatenado com o campo
[Pedido.OrdemServico]
Pedido.OrdemServico Integer Codigo sequencial - Deve ser um único para cada pedido
Paciente.Codigo Integer Codigo do paciente – Deve ser único por paciente
Paciente.Nome String Enviar o nome completo do candidato
Paciente.Sexo String Sexo do paciente
Exames.Exame.Codigo Integer
Utilizar os códigos:
100: Hemograma
101: Glicose
102: T4
103: TSH
Exames.Exame.Descricao String Descrição do exame
Segue o link do webservice:
http://processoseletivo.shift.com.br/shift/integracao/procseletivo/shift.bs.WSProcSeletivo.cls?WSDL=1
Deve ser feito uma solicitação para o webservice de um pedido contendo pelo menos 2 exames procedimentos.
2º Exercício – Um ERP fiscal precisa realizar uma integração com o laboratório ShiftLabs, porem o laboratório não possui um
layout para disponibilizar para o ERP.
Elabore um layout XML e JSON de extração de dados a partir do diagrama abaixo:
3º Exercício – Elabore consultas SQL com base no diagrama da próxima página para responder as seguintes questões:
a. Qual o número total de exames por convenio do mês de fevereiro de 2018?
b. Quais exames foram realizados nos postos 001 e 002 no dia 05/04/18?
c. Qual o faturamento do Laboratório no ano de 2018?
d. Quantos atendimentos foram realizados no mês de janeiro de 2017 pelo usuário 099?
e. Quantos pacientes foram atendidos no posto “Santa Julia” no mês de abril de 2017?
f. Quais exames foram solicitados em atendimentos do tipo “Emergência” no dia 25/11/2018 no posto 009? 
