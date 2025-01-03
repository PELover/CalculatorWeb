namespace CnxDevSoft_Junior_Assignment_CalculatorWeb.Models
{
	public class CalculatorModel
	{
		public double x { get; set; }
		public double y { get; set; }
		public double? result { get; set; }
		public string operators { get; set; }
        public static List<string>? resulthistory { get; set; } = new List<string>();
		public int count { get; set; } = 1;
	}
}
