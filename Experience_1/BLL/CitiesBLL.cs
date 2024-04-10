using Exiprience_1;
using Microsoft.IdentityModel.Tokens;

namespace BLL
{
    public class CitiesBLL
    {
        private CitiesDAL citiesDAL;
        public CitiesBLL()
        {
            citiesDAL = new CitiesDAL();
        }
        public List<CityDTO> GetAll()
        {
            return citiesDAL.GetAll().Select(c => new CityDTO(c)).ToList();
        }
        public CityDTO Add(string city)
        {
            CityDTO dTO = new CityDTO(city);

            if (citiesDAL.GetAll().Count(x => x.CityName == city) > 0)
                return null;
            return new(citiesDAL.Add(dTO.Todall()));


        }
        public void Delete(string city)
        {
            City? c = citiesDAL.GetAll().FirstOrDefault(x => x.CityName == city);
            if (c == null) return;
            citiesDAL.Delete(c.CityId);
        }
        public CityDTO Update(string oldcity, string newcity)
        {
            if (citiesDAL.GetAll().Count(x => x.CityName == newcity) > 0)
                //throw new Exception("קיים שם כזה");
                return null;
            City? c = citiesDAL.GetAll().FirstOrDefault(x => x.CityName == oldcity);
            if (c == null) return null;//throw new Exception("לא קיים שם כזה"); ;
            return new(citiesDAL.Update(new City() { CityId = c.CityId, CityName = newcity }));
        }
        public List<CityDTO> OrderBy()
        {
            return citiesDAL.OrderBy().Select(c => new CityDTO(c)).ToList();
        }
        public List<CityDTO> OrderByDesc()
        {
            return citiesDAL.OrderByDesc().Select(c => new CityDTO(c)).ToList();
        }
        public List<CityDTO> GetTop5Cities()
        {
            return citiesDAL.GetTop5Cities().Select(c => new CityDTO(c)).ToList();
        }
        public List<CityDTO> GetCitiesInPage(int pageIndex, int pageSize)
        {
            return citiesDAL.GetCitiesInPage(pageIndex, pageSize).Select(c => new CityDTO(c)).ToList();
        }
        public List<City> GetCitiesByPartialName(string partialName)
        {

            return citiesDAL.GetCitiesByPartialName(partialName).ToList();
        }
        public List<City> SelectByName_hibrish(string partialName)
        {
            return citiesDAL.SelectByName_hibrish(partialName).ToList();

        }
    }
}
