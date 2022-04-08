namespace CarWashing
{
    public abstract class CarWasherBase : ICarWasher
    {
        private readonly List<ICar> _cars;

        public CarWasherBase()
        {
            _cars = new List<ICar>();
        }
        public string MakeWashingService()
        {
            if (!_cars.Any()) return "Thre are no cars to wash";
            return this.Wash(_cars.OrderBy(c => c.RegistrationDate).ToList());
        }
        protected abstract string Wash(List<ICar> cars);

        public void AddCar(ICar car)
        {
            _cars.Add(car);           
        }

        public void AddCars(IEnumerable<ICar> cars)
        {
            _cars.AddRange(cars);
        }

        
    }

}