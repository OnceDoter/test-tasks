
namespace wpf_tomsk_asu.Models
{
    public enum EquationType
    {
        Линейная = 1,
        Квадратичная = 2,
        Кубическая = 3,
        q4th = 4,
        q5th = 5
    }
    class EquationModel
    {
        internal double a;
        internal double b;
        internal double x;
        internal double y;
        public EquationModel() { }
    }
}
