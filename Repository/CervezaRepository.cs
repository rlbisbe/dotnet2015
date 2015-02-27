using System.Collections.Generic;
using MvcSample.Web.Models;
using System;

namespace MvcSample.Web
{
    public class CervezaRepository : ICervezaRepository
    {
        public DateTime GenerationDate { get; set; }

        public CervezaRepository () 
        {
            GenerationDate = DateTime.Now;
        }

		public List<Cerveza> GetCervezas()
		{
            List<Cerveza> cervezas = new List<Cerveza>()
            {
                new Cerveza()
                {
                    Nombre = "Guinness",
                    Percent = 4.0
                },
                new Cerveza()
                {
                    Nombre = "Paulaner",
                    Percent = 5.5
                }
            };

            return cervezas;
		}
    }
}