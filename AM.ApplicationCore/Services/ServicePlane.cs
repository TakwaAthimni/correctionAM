using AM.ApplicationCore.Domain;
using AM.ApplicationCore.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.ApplicationCore.Services
{
    public class ServicePlane :Service<Plane>, IServicePlane
    {
        public ServicePlane(IUnitOfWork uow):base(uow)
        {
        }
        public IEnumerable<Passenger> GetPassengers(Plane p)
        {
          return  p.Flights.SelectMany(f => f.Tickets).Select(t => t.Passenger);
        }
        public IEnumerable<Flight> GetFlights(int n)
        {
            return GetMany().OrderByDescending(p => p.PlaneId).Take(n)
                .SelectMany(p => p.Flights).OrderByDescending(f => f.FlightDate);
            
        }

       
        public bool IsAvailablePlane(int n, Flight f)
        {
            return f.Plane.Capacity>= f.Tickets.Count + n;        }

        public void DeletePlane()
        {
            Delete(p => (DateTime.Now - p.ManufactureDate).TotalDays > 3650);
        }
    }
} 