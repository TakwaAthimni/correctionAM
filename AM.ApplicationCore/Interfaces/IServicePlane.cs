using AM.ApplicationCore.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.ApplicationCore.Interfaces
{
    public interface IServicePlane:IService<Plane>
    {

        IEnumerable<Passenger> GetPassengers(Plane p);
        IEnumerable<Flight> GetFlights(int n);
        Boolean IsAvailablePlane(int n, Flight f);
        void DeletePlane();

    }
}
