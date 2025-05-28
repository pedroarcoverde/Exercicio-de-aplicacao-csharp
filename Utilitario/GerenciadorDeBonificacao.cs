using ByteBank_ADM.Funcionarios;

namespace ByteBank_ADM.Utilitario;

public class GerenciadorDeBonificacao
{
    public double TotalDeBonificacao { get; private set; }

    public void Registrar(Funcionario funcionario)
    {
        TotalDeBonificacao += funcionario.GetBonificacao();
    }

}
