﻿namespace ByteBank_ADM.Funcionarios;

public class Auxiliar : Funcionario
{
    public Auxiliar(string cpf) : base(cpf, 2000)
    {
    }

    public override double GetBonificacao()
    {
        return Salario * 0.20;
    }

    public override void AumentarSalario()
    {
        Salario *= 1.10;
    }
}
