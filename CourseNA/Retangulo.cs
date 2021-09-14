using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseNA {
    class Retangulo {
        public double Largura;
        public double Altura;

        public double Area() {
            return (Largura * Altura);
        }

        public double Perimetro() {
            return (Largura + Largura + Altura + Altura);
        }
    }
}
