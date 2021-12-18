using System;
using CaseStudyZico.Models;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Net.Http;
using System.Text.Json;
using CaseStudyZico.Views;


namespace CaseStudyZico.DAL
{
    class AtomApiRepository
    {

        private string _apiKey;

        public AtomApiRepository()
        {
           
        }

        public List<AtomJsonFields> GetAtomByNumber(int number)
        {
            List<AtomJsonFields> atoms = new List<AtomJsonFields>();
            string apiString = "https://periodic-table-elements-info.herokuapp.com/element/atomicNumber/"+number;

            var client = new HttpClient();
            HttpResponseMessage response = client.Send(new HttpRequestMessage(HttpMethod.Get, apiString));
            using (var reader = new StreamReader(response.Content.ReadAsStream()))
            {
                atoms = JsonSerializer.Deserialize<List<AtomJsonFields>>(reader.ReadToEnd());
            }
            return atoms;
        }

        public List<AtomJsonFields> GetAtomByName(string name)
        {
            List<AtomJsonFields> atoms = new List<AtomJsonFields>();
            string apiString = "https://periodic-table-elements-info.herokuapp.com/element/atomicName/"+name;

            var client = new HttpClient();
            HttpResponseMessage response = client.Send(new HttpRequestMessage(HttpMethod.Get, apiString));
            using (var reader = new StreamReader(response.Content.ReadAsStream()))
            {
                atoms = JsonSerializer.Deserialize<List<AtomJsonFields>>(reader.ReadToEnd());
            }
            return atoms;
        }
    }
}
