﻿using Jogo_da_velha_válido.uteis;
char[,] tabuleiro =
{
    {'1', '2', '3' },
    {'4', '5', '6' },
    {'7', '8', '9' }
};
int jogadorAtual = 1;
bool rodando = true;

while (rodando)
{
    JogoVelha.MostrarTabuleiro(tabuleiro);
    char simbolo;
    int linha = 0, coluna = 0, escolha;
    if (jogadorAtual == 1)
    {
        simbolo = 'X';
    }
    else
        simbolo = 'O';
    Console.WriteLine($"Jogador {jogadorAtual}, escolha uma posição: ");
    escolha = int.Parse(Console.ReadLine());
    switch (escolha)
    {
        case 1:
            linha = 0;
            coluna = 0;
            break;
        case 2:
            linha = 0;
            coluna = 1;
            break;
        case 3:
            linha = 0;
            coluna = 2;
            break;
        case 4:
            linha = 1;
            coluna = 0;
            break;
        case 5:
            linha = 1;
            coluna = 1;
            break;
        case 6:
            linha = 1;
            coluna = 2;
            break;
        case 7:
            linha = 2;
            coluna = 0;
            break;
        case 8:
            linha = 2;
            coluna = 1;
            break;
        case 9:
            linha = 2;
            coluna = 2;
            break;
        default:
            break;
    }
    if (JogoVelha.VerificaPosicao(tabuleiro, linha, coluna, escolha))
    {
        tabuleiro[linha, coluna] = simbolo;
        JogoVelha.VerificaVencedor(tabuleiro, jogadorAtual, ref rodando);
        JogoVelha.verificaEmpate(tabuleiro, ref rodando);
        JogoVelha.TrocaJogador(ref jogadorAtual);
    }
    else
    {
        Console.WriteLine("Opção inválida!");
        Console.WriteLine("Pressione qualquer tecla para continuar...");
        Console.ReadLine();
    }
}
