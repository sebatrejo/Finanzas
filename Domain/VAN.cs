namespace Finanzas.Domain
{
    public class VAN
    {
        public VAN() {}
        public double A { get; set; }
        public double VA { get; set; }
        public double Qconstante { get; set; }
        public double r { get; set; }
        public double n { get; set; }
        
        public double CalculateVAN()
        {
            return (-1) * A + VA;
        }
        public double CalculateVANconstante()
        {
            return 0;
        }
    }
}
