using System.Globalization;

namespace oop3
{
    class Produto
    {
        public string Nome;
        public double Preco;
        public int Quantidade;

        public double ValorTotalEmEstoque()
        {
            return Preco * Quantidade;
        }

        public void AdicionarProdutos(int quantidade)
        {
            Quantidade = Quantidade + quantidade;
        }

        public void RemoverProdutos(int quantidade)
        {
            Quantidade -= quantidade;
        }


        public override string ToString()
        {
            return Nome + ", $ " + Preco.ToString("F2", CultureInfo.InvariantCulture)
            + ", "
            + Quantidade + " Unidades, Total: $"
            + ValorTotalEmEstoque().ToString("f2", CultureInfo.InvariantCulture);
        }
    }
}