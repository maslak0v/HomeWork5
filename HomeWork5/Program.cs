namespace HomeWork5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Quadcopter quadcopter = new Quadcopter();

            List<string> components = quadcopter.GetComponents();
            Console.WriteLine("Components of the Quadcopter:");
            foreach (var component in components)
            {
                Console.WriteLine(component);
            }

            Console.WriteLine(quadcopter.GetInfo());

            quadcopter.Charge();

            IChargeable chargeableQuadcopter = quadcopter;
            Console.WriteLine(chargeableQuadcopter.GetInfo());

        }
    }
    interface IRobot
    {
        public string GetInfo();

        public List<string> GetComponents();

        public virtual string GetRobotType()
        {
            return "I am a simple robot.";
        }
    }

    interface IChargeable
    {
        void Charge();

        string GetInfo();
    }

    interface IFlyingRobot : IRobot
    {
        public virtual string GetRobotType()
        {
            return "I am a flying robot.";
        }
    }

    class Quadcopter : IChargeable, IFlyingRobot
    {
        private List<string> _components = new List<string> { "rotor1", "rotor2", "rotor3", "rotor4" };

        public List<string> GetComponents()
        {
            return _components;
        }
        public void Charge()
        {
            Console.WriteLine("Charging...");
            Thread.Sleep(3000);
            Console.WriteLine("Charged!");
        }


        public string GetInfo()
        {
            return "Quadcopter information.";
        }
    }
}
