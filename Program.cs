using System.Diagnostics;
using Torre;

Class1 bah = new Class1();
Class2 beh = new Class2();

int Objetivo = 100000000;

int ValoriParaArmazenamento = 0;
int ValoriParaMineracao = 0;
int ValoriParaPolimento = 0;
int ValoriParaCaminhada = 0;
int ValoriParaColocar = 0;
int ValoriParaMulti = 0;

List<int> Armazenamento = new List<int>() {2,4,6,10,16,28,50,80,120,180,250,350,500,700,1000,1400,2800,5000,7500,12500,20000,100000,500000,1000000};List<int> armazenamento = new List<int>() {2,4,6,10,16,28,50,80,120,180,250,350,500,700,1000,1400,2800,5000,7500,12500,20000,100000,500000,1000000};
List<int> VelMineracao = new List<int>() {1,2,4,8,16,32,64,128,256,512,1024,2048,4096,8192,16384,32768};
List<int> VelPolimento = new List<int>() {0,1,2,4,6,8,12,15};
List<float> VelCaminhada = new List<float>() {30,40,70,80,100};
List<float> VelColocar = new List<float>() {10,40,80,90,100};
List<float> MultiArmazenamento = new List<float>() {2,10,20,50,100};

int InfoArmazenamento = Armazenamento[ValoriParaArmazenamento];
int InfoMineracao = VelMineracao[ValoriParaMineracao];
int InfoPolimento = VelPolimento[ValoriParaPolimento];
float InfoCaminhada = VelCaminhada[ValoriParaCaminhada];
float InfoColocar = VelColocar[ValoriParaColocar];
float InfoMulti = MultiArmazenamento[ValoriParaMulti];


float PrecoArmazenamento = Armazenamento[ValoriParaArmazenamento] * 8;
float PrecoMineracao = VelMineracao[ValoriParaMineracao] * 12;
if (ValoriParaPolimento <= 4)
{
    float PrecoPolimento = VelPolimento[ValoriParaPolimento] * 10;
}
else
{
    float PrecoPolimento = VelPolimento[ValoriParaPolimento] * 25;
}
float PrecoCaminhada = VelCaminhada[ValoriParaCaminhada] * 15;
float PrecoColocar = VelColocar[ValoriParaColocar] * 15;
float PrecoMulti = MultiArmazenamento[ValoriParaMulti] * 100;

int Dinheito = 0;
int Torre = 0;

void LetrasRapido(string texto)
{
    Console.Clear();
    foreach (char letra in texto)
    {
        Console.Write(letra);
        Thread.Sleep(35);
    }
}
void LetrasMedio(string texto)
{
    Console.Clear();
    foreach (char letra in texto)
    {
        Console.Write(letra);
        Thread.Sleep(60);
    }
}

void LetrasLento(string texto)
{
    Console.Clear();
    foreach (char letra in texto)
    {
        Console.Write(letra);
        Thread.Sleep(90);
    }
}

void LetrasSuperLento(string texto)
{
    Console.Clear();
    foreach (char letra in texto)
    {
        Console.Write(letra);
        Thread.Sleep(700);
    }
}

void LetrasSuperRapido(string texto)
{
    Console.Clear();
    foreach (char letra in texto)
    {
        Console.Write(letra);
        Thread.Sleep(5);
    }
}

void LetrasLentoSemApagar(string texto)
{
    foreach (char letra in texto)
    {
        Console.Write(letra);
        Thread.Sleep(90);
    }
}

void LetrasRapidoSemApagar(string texto)
{
    foreach (char letra in texto)
    {
        Console.Write(letra);
        Thread.Sleep(35);
    }
}

void ApagarProgresso()
{
    Console.Clear();
    Console.WriteLine("Você tem certeza que quer começar tudo do zero?");
    string DecisãoApagar = Console.ReadLine();
    if (DecisãoApagar == "s")
    {
        Torre = 0;
        Dinheito = 0;
        ValoriParaArmazenamento = 0;
        ValoriParaMineracao = 0;
        ValoriParaPolimento = 0;
        ValoriParaCaminhada = 0;
        ValoriParaColocar = 0;
        ValoriParaMulti = 0;
        LetrasRapido("Progresso apagado com sucesso!");
        Thread.Sleep(3000);
        Inicio();
    }
    else if (DecisãoApagar == "n")
    {
        LetrasRapido("Ok, vamos continuar de onde paramos.");
        Thread.Sleep(3000);
    }
    else
    {
        LetrasRapido("Opção inválida, vamos tentar novamente.");
        Thread.Sleep(3000);
        ApagarProgresso();
    }
}

void Tutorial()
{
    LetrasRapido("O objetivo do jogo é minerar e polir pedras preciosas para ganhar dinheiro e aumentar a sua torre de tamanho.\n\nCom esse dinheiro você aprimora suas estatisticas para chegar em 100.000.000 de andares");
    Console.ReadKey();
    LetrasRapidoSemApagar("\n\nVocê pode minerar pedras preciosas escrevendo 'M'");
    Console.ReadKey();
    LetrasRapidoSemApagar("\n\nVocê pode polir pedras preciosas escrevendo 'P'");
    Console.ReadKey();
    LetrasRapidoSemApagar("\n\nVocê pode vender pedras preciosas escrevendo 'V'");
    Console.ReadKey();
    LetrasRapidoSemApagar("\n\nVocê pode comprar upgrades clicando no botão 'U'");
    Console.ReadKey();
    LetrasRapidoSemApagar("\n\nPara acessar as configurações escreva 'C', lá terá outros comandos escritos");
    Console.ReadKey();
    LetrasRapidoSemApagar("\n\nNão tem um botão para você se mover ou colocar os tijolos, mas eles ainda são aprimoráveis");
    Console.ReadKey();
    LetrasRapidoSemApagar("\n\nBoa sorte!");
    Console.ReadKey();
    Console.Clear();
}

void Inicio()
{
    Console.Clear();
        Thread.Sleep(3000);
        LetrasLento("Olá");
        Thread.Sleep(5000);
        LetrasSuperLento("...");
        Thread.Sleep(5000);
        LetrasLento("Você quer jogar? (s/n)\n\n");
        string resposta = Console.ReadLine();
        Tentar();

        void Tentar()
    {
        if (resposta == "s" || resposta == "S")
        {
            LetrasLento("Ok, ");
            Thread.Sleep(1500);
            LetrasLentoSemApagar("Vamos jogar!");
            Thread.Sleep(3000);
            LetrasLento("Antes de começar, você quer ver o tutorial? (s/n)\n\n");
            string resposta = Console.ReadLine();
            if (resposta == "s" || resposta == "S")
            {
                LetrasLento("Ok, ");
                LetrasLentoSemApagar("vamos começar o tutorial!");
                Thread.Sleep(1500);
                Tutorial();
            }
            else if (resposta == "n" || resposta == "N")
            {              
                LetrasLento("Ok, ");
                LetrasLentoSemApagar("vamos começar o jogo!");
                Thread.Sleep(1500);                
                Menu();
            }
            else
            {
                LetrasMedio("Opção inválida, vamos tentar novamente.");
                Thread.Sleep(2500);
                Tentar();
            }
        }
        else if (resposta == "n" || resposta == "N")
        {
            LetrasLento("Você tem certeza que quer sair? (s/n)\n\n");
            string confirmacao = Console.ReadLine();
            if (confirmacao == "s" || confirmacao == "S")
            {
                LetrasLento("Ok, até mais!");
                Thread.Sleep(3000);
                LetrasLento("O computador será desligado em 3 segundos.");
                Thread.Sleep(1000);
                Class1.DefinirTamanhoFonteConsole(900);
                for (int i = 3; i >= 0; i--)
                {
                    Console.Clear();
                    Console.Write(i);
                    Thread.Sleep(1000);
                }
                Process.Start("shutdown.exe", "/s /t 0");
            }
            else
            {
                LetrasLento("Ok, ");
                Thread.Sleep(1500);
                LetrasLentoSemApagar("Vamos jogar!");
                Thread.Sleep(3000);
                LetrasLento("Antes de começar, você quer ver o tutorial? (s/n)\n\n");
                string resposta = Console.ReadLine();
                if (resposta == "s" || resposta == "S")
                {
                    LetrasLento("Ok, ");
                    LetrasLentoSemApagar("vamos começar o tutorial!");
                    Thread.Sleep(1500);
                    Tutorial();
                }
                else if (resposta == "n" || resposta == "N")
                {
                    LetrasLento("Ok, ");
                    LetrasLentoSemApagar("vamos começar o jogo!");
                    Menu();
                }
                else
                {
                    LetrasMedio("Opção inválida, vamos tentar novamente.");
                    Thread.Sleep(2500);
                    Tentar();
                }
            }
        }
        else
        {
            LetrasMedio("Vamos tentar novamente.");
            Thread.Sleep(2500);
            Inicio();
        }
    }
}

void Minerar()
{

}

void Polir()
{

}

void Colocar()
{

}

void Comprar()
{

}

void Configurar()
{

}

void Menu()
{
    Console.Clear();
    Class1.DefinirTamanhoFonteConsole(65);
    Class1.DefinirTamanhoFonteConsole(65);
    Class1.DefinirTamanhoFonteConsole(65);
    Class1.DefinirTamanhoFonteConsole(65);
    Console.WriteLine("█   █ ███ ████  █████ ████     █████  ███  █   █ █████ ████  \r\n█   █  █  █   █ █     █   █      █   █   █ █   █ █     █   █ \r\n█████  █  ████  ████  ████       █   █   █ █ █ █ ████  ████  \r\n█   █  █  █     █     █  █       █   █   █ ██ ██ █     █  █  \r\n█   █ ███ █     █████ █   █      █    ███  █   █ █████ █   █ ");
}


Class1.DefinirTamanhoFonteConsole(80);
Class2.AtivarTelaCheia();

Class2.AtivarTelaCheia();
Class2.AtivarTelaCheia();
Class2.AtivarTelaCheia();
Inicio();

Class1.DefinirTamanhoFonteConsole(65);
Class1.DefinirTamanhoFonteConsole(65);
Class1.DefinirTamanhoFonteConsole(65);
Class1.DefinirTamanhoFonteConsole(65);
LetrasSuperRapido("█   █ ███ ████  █████ ████     █████  ███  █   █ █████ ████  \r\n█   █  █  █   █ █     █   █      █   █   █ █   █ █     █   █ \r\n█████  █  ████  ████  ████       █   █   █ █ █ █ ████  ████  \r\n█   █  █  █     █     █  █       █   █   █ ██ ██ █     █  █  \r\n█   █ ███ █     █████ █   █      █    ███  █   █ █████ █   █ ");
