double fatura;
double minimo;
double jurosmensais;
double pagamentominimo;
double valornaopago;
double juros;
double iofmensal;
double iofdiario;
double proximafatura;
double custorotativo;

Console.Clear();

Console.WriteLine(@"
--- Crédito Rotativo de Cartão de Crédito --- ");

Console.Write ("Valor total da fatura (R$)........: ");
fatura = Convert.ToDouble(Console.ReadLine());

Console.Write ("Pagamento mínimo (%)..............: ");
minimo = Convert.ToDouble(Console.ReadLine());

Console.Write ("Taxa de juros mensais (%).........: ");
jurosmensais = Convert.ToDouble(Console.ReadLine());

minimo = minimo / 100;

pagamentominimo = minimo * fatura;

Console.WriteLine($@"
Pagamento mínimo..................: R${pagamentominimo}");

Console.WriteLine(@"
Caso seja pago o valor mínimo:");

valornaopago = fatura - pagamentominimo;

Console.WriteLine (@$"
Valor não pago....................: R${valornaopago}");

jurosmensais = jurosmensais / 100;

juros = valornaopago * jurosmensais;

Console.WriteLine ($"Juros.............................: R${juros}");

iofmensal = valornaopago * 0.0038;

Console.WriteLine ($"IOF mensal........................: R${iofmensal}");

iofdiario = valornaopago * 0.00246;

Console.WriteLine ($"IOF diário........................: R${iofdiario}");

custorotativo = juros + iofmensal + iofdiario;

proximafatura = valornaopago + custorotativo;

Console.WriteLine ($@"
Valor a pagar na próxima fatura...: R${proximafatura}");

Console.WriteLine ($"Custo do crédito rotativo.........: R${custorotativo}");