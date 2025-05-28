using ByteBank_ADM.Funcionarios;
using ByteBank_ADM.Parceria;
using ByteBank_ADM.SistemaInterno;
using ByteBank_ADM.Utilitario;

#region
//Funcionario pedro = new Funcionario("123456789", 2000);
//pedro.Nome = "Pedro Arcoverde";

//Console.WriteLine(pedro.Nome);
//Console.WriteLine(pedro.GetBonificacao());

//Diretor roberta = new Diretor("987654321");
//roberta.Nome = "Roberta Silva";

//Console.WriteLine(roberta.Nome);
//Console.WriteLine(roberta.GetBonificacao());

//GerenciadorDeBonificacao gerenciador = new GerenciadorDeBonificacao();
//gerenciador.Registrar(pedro);
//gerenciador.Registrar(roberta);

//Console.WriteLine("Total de bonificações: " + gerenciador.TotalDeBonificacao);
//Console.WriteLine("Total de funcionários: " + Funcionario.TotalDeFuncionarios);

//pedro.AumentarSalario();
//roberta.AumentarSalario();

//Console.WriteLine("Novo salário do Pedro: " + pedro.Salario);
//Console.WriteLine("Novo salário da Roberta: " + roberta.Salario);
#endregion
//CalcularBonificacao();
UsarSistema();

void CalcularBonificacao()
{
    GerenciadorDeBonificacao gerenciador = new GerenciadorDeBonificacao();

    Designer ulisses = new Designer("123456");
    ulisses.Nome = "Ulisses Souza";

    Diretor paola = new Diretor("123457");
    paola.Nome = "Paola Souza";

    Auxiliar igor = new Auxiliar("745812");
    igor.Nome = "Igor Dias";

    GerenteDeContas camila = new GerenteDeContas("123459");
    camila.Nome = "Camila Oliveira";

    gerenciador.Registrar(camila);
    gerenciador.Registrar(ulisses);
    gerenciador.Registrar(paola);
    gerenciador.Registrar(igor);

    Console.WriteLine("Total de Bonificação = " + gerenciador.TotalDeBonificacao);
    
}

void UsarSistema()
{
    SistemaInterno sistema = new SistemaInterno();

    Diretor ingrid = new Diretor("982534");
    ingrid.Nome = "Ingrid Novaes";
    ingrid.Senha = "123";
    
    GerenteDeContas ursula = new GerenteDeContas("982534");
    ursula.Nome = "Ursula Souza";
    ursula.Senha = "321";

    ParceiroComercial caio = new ParceiroComercial();
    caio.Senha = "999";



    sistema.Logar(ingrid, "123");
    sistema.Logar(ursula, "123");
    sistema.Logar(caio, "999");
}