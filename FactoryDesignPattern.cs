using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logical_Program
{
    public interface ICar
    {
        void Start();
    }

    public class SixSeaterCar : ICar
    {
        public void Start()
        {
            throw new NotImplementedException();
        }
    }

    public class FourSeaterCar : ICar
    {
        public void Start()
        {
            throw new NotImplementedException();
        }
    }
    public class CarFactory
    {
        public ICar GetCar(string carType)
        {
            switch(carType)
            {
                case "SixSeaterCar":
                    return new FourSeaterCar();
                case "FourSeaterCar":
                    return new SixSeaterCar();
            }
            return null;
        }
    }

    public class FactoryDesignPattern
    {
        CarFactory carfactory = new CarFactory();
        ICar sixseatercar = carfactory.GetCar("SixSeaterCar");
        ICar fourseatercar = carfactory.GetCar("FourSeaterCar");
    }
}
