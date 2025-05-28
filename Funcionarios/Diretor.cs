﻿namespace ByteBank_ADM.Funcionarios;

public class Diretor : FuncionarioAutenticavel
{
    public Diretor(string cpf):base(cpf, 5000) 
    {
    }

    public override double GetBonificacao()
    {
        return Salario * 0.5;
    }

    public override void AumentarSalario()
    {
        Salario *= 1.15;
    }

}
