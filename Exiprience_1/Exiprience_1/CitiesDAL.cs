
using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exiprience_1
{
    public class CitiesDAL
    {
        public List<City> GetAll()
        {
            using (CitiesContext db = new CitiesContext())
            {
                return db.Cities.ToList();
            }
        }
        public City Add(City city)
        {
            using (CitiesContext db = new CitiesContext())
            {

                EntityEntry<City> c = db.Cities.Add(city);
                db.SaveChanges();
                return c.Entity;
            }

        }
        public void Delete(int cityId)
        {
            using (CitiesContext db = new CitiesContext())
            {
                var city = db.Cities.Find(cityId);
                EntityEntry<City> c = db.Cities.Remove(city);
                db.SaveChanges();

            }
        }
        public City? Update(City city)
        {
            using (CitiesContext db = new CitiesContext())
            {

                EntityEntry<City> c = db.Cities.Update(city);
                db.SaveChanges();
                return c.Entity;
            }

        }
        public List<City> OrderBy()
        {
            using (CitiesContext db = new CitiesContext())
            {
                return db.Cities.OrderBy(city => city.CityName)
                .ToList();
            }
        }
        public List<City> OrderByDesc()
        {
            using (CitiesContext db = new CitiesContext())
            {
                return db.Cities.OrderByDescending(city => city.CityName)
                .ToList();
            }
        }
        public List<City> GetTop5Cities()
        {
            using (CitiesContext db = new CitiesContext())
            {
                return db.Cities.Take(5).ToList();

            }
        }
        public List<City> GetCitiesInPage(int pageIndex, int pageSize)
        {
            using (CitiesContext db = new CitiesContext())
            {
                int startIndex = pageIndex * pageSize;
                List<City> pagedCities = db.Cities.OrderBy(city => city.CityName).Skip(startIndex).Take(pageSize).ToList();
                return pagedCities;
            }
        }
        public List<City> GetCitiesByPartialName(string partialName)
        {
            using (CitiesContext db = new CitiesContext())
            {
                return db.Cities.Where(city => city.CityName.Contains(partialName)).ToList();

            }

        }
        //public List<City> SelectByName_hibrish(string partialName)
        //{
        //    using (CitiesContext db = new CitiesContext())
        //    {
        //        string sqlQuery = "WHERE [city_name] COLLATE Hebrew_CI_AS LIKE '%'+ @cityName+'%'";
        //        return db.Database.SqlQuery<City>(sqlQuery).ToList();
        //    }

        //}
    }

}
