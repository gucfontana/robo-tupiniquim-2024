
# Robô Tupiniquim

A AEB (Agência Espacial Brasileira) entrou em contato com a turma da Academia do Programador 2024 para realização de um novo projeto. 

A agência está planejando uma expedição à Marte, mas antes, a AEB vai enviar uma nave espacial (codinome Tupiniquim I) tripulada com um Robô para fazer análises do planeta vermelho. Os alunos da 10ª edição da Academia do Programador, reconhecidos como excelentes programadores, foram contratados para desenvolver o software que irá guiar o Robô nesta empreitada.

---
## Detalhes

A área escolhida para análise é curiosamente retangular e os robôs devem andar por ela com suas câmeras ligadas coletando todo tipo de informação. A posição de um robô é representada por uma combinação de coordenadas X e Y e também uma letra representando a direção que ele está olhando. A área é dividida em um grid para simplificar a navegação. Um exemplo de posição poderia ser: 0,0,N, significando o robô está na parte inferior esquerda com a face para o norte. Use as orientações: N =norte, S = sul, L = leste, O = oeste.  

Para controlar o robô, a AEB envia simples strings com os comandos. Letras possíveis são: E, D e M. As letras E e D fazem o robô virar 90 graus para esquerda e direita respectivamente, sem sair do lugar. A letra M significa se mover uma posição no grid para frente, mantendo a mesma direção.  

Assuma que mover o robô para frente, significa mover sua posição de (X, Y) para (X, Y+1). Por exemplo, um robô na posição (0,0) com a face para o norte, ao se mover uma posição, vai parar em (0,1).

---
## Entrada

```
5 5
1 2 N
EMEMEMEMM
3 3 L
MMDMMDMDDM
```
## Saída

```
1 3 N
5 1 L
```
---
## Funcionalidades

- Recebe como entrada o tamanho do plano de coordenadas.
- Solicita as coordenadas iniciais e as ordens de movimento para um determinado número de robôs.
- Executa as ordens de movimento para cada robô.
- Atualiza a posição e direção de cada robô conforme as ordens de movimento.
- Imprime a posição final de cada robô após a execução das ordens.
---
## Requisitos

- .NET SDK (recomendado .NET 8.0 ou superior) para compilação e execução do projeto.
---
## Como Usar

1. Clone o repositório ou baixe o código fonte do projeto.
2. Abra ou terminal ou o prompt de comando e navegue até a pasta raiz da solução.
3. Utilize o comando abaixo para restaurar as dependências do projeto.

```
dotnet restore
```

4. Em seguida, compile a solução utilizando o comando:
   
```
dotnet build --configuration Release
```

5. Para executar o projeto compilando em tempo real
   
```
dotnet run --project RoboTupiniquim.ConsoleApp
```

6. Para executar o arquivo compilado, navegue até a pasta `./RoboTupiniquim.ConsoleApp/bin/Release/net8.0/` e execute o arquivo:
   
```
RoboTupiniquim.ConsoleApp.exe
```