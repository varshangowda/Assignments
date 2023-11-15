using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApi_Assignment1.Models;

namespace WebApi_Assignment1.Controllers
{
    public class CountryController : ApiController
    {

            private static List<Country> countries = new List<Country>
    {
        new Country { CID = 1, CountryName = "Inadia", Capital = "Delhi" },
        new Country { CID = 2, CountryName = "Japan", Capital = "Tokyo" },
        new Country { CID = 3, CountryName = "Iran", Capital = "Tehran" }
    };

            // GET: api/Country
            public IHttpActionResult Get()
            {
                return Ok(countries);
            }

            // GET: api/Country/1
            public IHttpActionResult Get(int id)
            {
                var country = countries.FirstOrDefault(c => c.CID == id);
                if (country == null)
                {
                    return NotFound();
                }
                return Ok(country);
            }

            // POST: api/Country
            public IHttpActionResult Post([FromBody] Country country)
            {
                country.CID = countries.Count + 1;
                countries.Add(country);
                return CreatedAtRoute("DefaultApi", new { id = country.CID }, country);
            }

            // PUT: api/Country/1
            public IHttpActionResult Put(int id, [FromBody] Country updatedCountry)
            {
                var country = countries.FirstOrDefault(c => c.CID == id);
                if (country == null)
                {
                    return NotFound();
                }

                country.CountryName = updatedCountry.CountryName;
                country.Capital = updatedCountry.Capital;

                return Ok(country);
            }

            // DELETE: api/Country/1
            public IHttpActionResult Delete(int id)
            {
                var country = countries.FirstOrDefault(c => c.CID == id);
                if (country == null)
                {
                    return NotFound();
                }

                countries.Remove(country);

                return Ok(country);
            }
        }

    }
