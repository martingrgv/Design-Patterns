namespace Command.Models
{
    public class Light
    {
        public Light()
        {
            IsTurnedOn = false;       
        }

        public void TurnOn()
        {
            IsTurnedOn = true;
            Console.WriteLine("Light is turned on.");
        }

        public void TurnOff()
        {
            IsTurnedOn = false;
            Console.WriteLine("Light is turned off.");
        }

        public bool IsTurnedOn { get; private set; }
    }
}
