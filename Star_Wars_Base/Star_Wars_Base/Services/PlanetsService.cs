﻿using Newtonsoft.Json;
using Star_Wars_Base.Models;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Star_Wars_Base.Services
{
    public class PlanetsService : IPlanetsService
    {
        public async Task<Planet> GetPlanetAsync()
        {
            Planet retVal = null;

            HttpClient client = new HttpClient();
            var planetResponse = await client.GetAsync("https://swapi.dev/api/planets/");

            if (planetResponse.IsSuccessStatusCode)
            {
                retVal = JsonConvert.DeserializeObject<Planet>(await planetResponse.Content.ReadAsStringAsync()); ;
            }
            return retVal;
        }
    }
}
