﻿using System.Globalization;


namespace CourseNA {
    class Produto {
        public string Nome;
        public double Preco;
        public int Quantidade;

        public double ValorTotalEmEstoque() {
            return (Quantidade * Preco);  
        }

        public void AdicionarProdutos(int quantidade) {
            Quantidade += quantidade;
        } 

        public void RemoverProdutos(int quantidade) {
            Quantidade -= quantidade;
        }

        public override string ToString() {
            return Nome 
                + ", $" 
                + Preco.ToString("F2", CultureInfo.InvariantCulture) 
                + ", "
                + Quantidade 
                + " unidades, Total: $"
                + ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
