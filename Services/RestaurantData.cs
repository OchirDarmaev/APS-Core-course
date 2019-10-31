using System.Linq;
using System.Collections.Generic;
using Pluralsight.Models;

namespace Pluralsight.Services
{
    public class InMemoryRestaurantData : IRestaurantData
    {
        private readonly List<Restaurant> _restaurants;

        public InMemoryRestaurantData()
        {
            _restaurants = new List<Restaurant>
            {
                new Restaurant{ Id=1, Name= "Scott's Pizza Place" },
                new Restaurant{ Id=2, Name= "Tersiguels" },
                new Restaurant{ Id=3, Name= "King;s Contivance" },
            };
        }
        public IEnumerable<Restaurant> GettAll()
        {
            return _restaurants.OrderBy(x => x.Name);
        }
    }
}