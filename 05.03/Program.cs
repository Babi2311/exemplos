// See https://aka.ms/new-console-template for more information

int a = 5; //colocando um valor para a variavel
int b = 10; //colocando um valor para a variavel
int c = a + b; //colocando um valor para a variavel e fazendo a parte aritmetica ali no caso a +b
var d = 33; // deu um valor para a varial mas não especificando oq é (int,double etc..) o computador indentifica sozinho
var e = "Algum texto"; // deu um "valor" para a varial mas não especificando oq é (int,double etc..) o computador indentifica sozinho
// double f = "Algum texto";
double g = 10.55;
bool isAprovado = true;
string s = "Algum texto";

// Estruturas de devisão if/else, ternárias e switch;

if(a == b && c > b){
    //faz alguma coisa
}
else{
    //faz outra coisa
}

//operadores logicos ternários
if(a == b && c > b){
    //faz alguma coisa
}

bool isVerdadeiro = a == b ? true : false;

//4. Estruturas de repetição while, do/while, for, foreach;
//5. Arrays.

int[] vetor1 = new int[4];
int[] vetor2 = new int[] { 3, 6, 7, 2};

// for(int i = 0; i < 4; i++)
// {
//     int vlr = vetor1[i];
//     Console.WriteLine("valor vetor 1" + vlr);
// }

Console.WriteLine($" valor do vetor 2 {vetor2[i]}");

//vetor1[2] = 23;

int contador = 0;

do{
    Console.WriteLine("digite um valor");
    var str = Console.ReadLine();
    vetor1[contador] = Convert.ToInt32(str);
    contador++;    
}while(contador < 4);

foreach(var vlr in vetor1){
    Console.WriteLine($"valor vetor1: [vlr]");
}