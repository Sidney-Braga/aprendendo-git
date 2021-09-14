namespace CourseNA {
    class ConversorMoeda {

        public static double Cot = 6.0;

        public static double Con(double A, double B) {
            double total = A * B;
            return total + total * Cot / 100.0;
        }

    }
}
