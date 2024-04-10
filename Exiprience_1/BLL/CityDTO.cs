using Exiprience_1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class CityDTO
    {
        public CityDTO(string c )
        {
            CityName=c;
        }
        public CityDTO(City c)
        {
          //  CityId = c.CityId;
            CityName = c.CityName;
        }

        public int CityId { get; set; }
        public string CityName { get; set; }
        public City Todall()
        {
            City city = new City();
            city.CityId = CityId;
            city.CityName = CityName;
            return city;
        }
    }

}
