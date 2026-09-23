
partial class Program
{
	    public int speed = 100;
		public int fuel = 50;
		public bool engine = false;
		

		public static void Main(string[] args)
		{
			Program program = new Program();
			program.run();
		}
		private void run()
		{
			
		StartEngine();

		Console.WriteLine("Speed: " + speed);
		Console.WriteLine("Fuel: " + fuel);
		Console.WriteLine("Engine: " + engine);

	}

	private void StartEngine()
	{
		if (engine == false && fuel > 0 ){
			engine = true;
		}
	}
}