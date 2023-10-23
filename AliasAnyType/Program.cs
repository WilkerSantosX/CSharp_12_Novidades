
//Novidades do C# 12
// É possivel dar alias para estruturas de objeto

using XboxConsole = System.Console;
using Games = System.Collections.Generic.List<string>;
using Transacao = (decimal Valor, System.DateTime Data, TipoTransacao tipo);

Games itens = new()
{
    "Grand Theft Auto V",
    "Red Dead Redemption",
    "Fortnite"
};

XboxConsole.WriteLine("==== XBOX ONE LIGADO ====\n");
itens.ForEach(it => XboxConsole.WriteLine(it));

List<Transacao> transacoes = new List<Transacao>
{
    (100.00M, DateTime.Now, TipoTransacao.Deposito),
    (50.00M, DateTime.Now.AddDays(-1), TipoTransacao.Saque),
    (200.00M, DateTime.Now.AddDays(-2), TipoTransacao.Transferencia),
    (100.00M, DateTime.Now.AddDays(-3), TipoTransacao.Deposito),
};

XboxConsole.WriteLine("Lista de transações: \n");

foreach (var transacao in transacoes)
{
    XboxConsole.WriteLine($"Valor: {transacao.Valor:C}, " +
                      $" Data: {transacao.Data}, +" +
                      $" Tipo: {transacao.tipo}\n ");
}

public enum TipoTransacao
{
    Deposito, Saque, Transferencia
}