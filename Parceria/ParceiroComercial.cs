using ByteBank_ADM.SistemaInterno;

namespace ByteBank_ADM.Parceria;

public class ParceiroComercial : IAutenticavel
{
    public string Senha { get; set; }

    public bool Autenticar(string senha)
    {
        return Senha == senha;
    }

}
