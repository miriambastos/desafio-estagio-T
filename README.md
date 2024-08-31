**1)** Dado a sequência de Fibonacci, onde se inicia por 0 e 1 e o próximo valor sempre será a soma dos 2 valores anteriores (exemplo: 0, 1, 1, 2, 3, 5, 8, 13, 21, 34...), escreva um programa na linguagem que desejar onde, informado um número, ele calcule a sequência de Fibonacci e retorne uma mensagem avisando se o número informado pertence ou não a sequência. 

IMPORTANTE: Esse número pode ser informado através de qualquer entrada de sua preferência ou pode ser previamente definido no código;

**2)** Escreva um programa que verifique, em uma string, a existência da letra ‘a’, seja maiúscula ou minúscula, além de informar a quantidade de vezes em que ela ocorre. 

IMPORTANTE: Essa string pode ser informada através de qualquer entrada de sua preferência ou pode ser previamente definida no código; 

**3)** Observe o trecho de código abaixo: int INDICE = 12, SOMA = 0, K = 1; enquanto K < INDICE faça { K = K + 1; SOMA = SOMA + K; } imprimir(SOMA); 

Ao final do processamento, qual será o valor da variável SOMA? 

**4)** Descubra a lógica e complete o próximo elemento: 

a) 1, 3, 5, 7, _ 9, 11, 13, 15, 17, 19... 

b) 2, 4, 8, 16, 32, 64, _ 128, 256, 512, 1.024...  

c) 0, 1, 4, 9, 16, 25, 36, _ 49, 64, 81, 100... 

d) 4, 16, 36, 64, _ 100, 144, 196, 256...

e) 1, 1, 2, 3, 5, 8, _ 13, 21, 34, 55... 

f) 2,10, 12, 16, 17, 18, 19, _ 200, 201, 202, 203, 204, 205...

**5)** Você está em uma sala com três interruptores, cada um conectado a uma lâmpada em salas diferentes. Você não pode ver as lâmpadas da sala em que está, mas pode ligar e desligar os interruptores quantas vezes quiser. Seu objetivo é descobrir qual interruptor controla qual lâmpada. Como você faria para descobrir, usando apenas duas idas até uma das salas das lâmpadas, qual interruptor controla cada lâmpada?   

Tenho o interruptor A, B e C e tenho as salas 1, 2 e 3. 

Passo 1 - Ligue o interruptor A e deixe ligado por 10 minutos.

Passo 2 - Desligue o interruptor A e ligue o interruptor B.

Passo 3 - Vá até as salas das lâmpadas e verifique:  
      Se a lâmpada estiver acesa, ela é controlada pelo interruptor B.
      Se a lâmpada estiver apagada, mas estiver quente, ela que estava acesa antes, logo é controlada pelo interruptor A.
      Se a lâmpada estiver apagada e estiver fria, ela é controlada pelo interruptor C.

OBS: Respostas das questões 1, 2 e 3 estão no código, comentadas. Para execução retirar os comentarios.
