namespace Atividade
{
class Clientes     {
public string Nome {get; set;}
public string Endereco {get; set;}
public float Valor {get; protected set;}
public float valor_imposto {get; protected set;}
public float total {get; protected set;}

public virtual void Pagar_Imposto(float v)
    {
this.Valor = v;
this.valor_imposto = this.Valor * 10 / 100;
this.total = this.Valor + this.valor_imposto;
    }
                    }
}