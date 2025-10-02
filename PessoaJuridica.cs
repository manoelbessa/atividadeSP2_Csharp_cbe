
namespace Atividade
{
class PessoaJuridica : Clientes
        {
public string cnpj {get; set;}
public string ie { get; set; }

        public override void Pagar_Imposto(float v)
            {
            this.Valor = v;
            this.valor_imposto = this.Valor * 20 / 100;
            this.total = this.Valor + this.valor_imposto;
             }
        }
}