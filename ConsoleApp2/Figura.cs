namespace ConsoleApp2
{
    public class Figura
    {
        public Figura(double r)
        {
            area = 3.14 * r * r;
        }
        public Figura(double b, double h)
        {
            area = b * h;
        }
        public double getArea()
        {
            return area;
        }
        private double area;
    }
    
}