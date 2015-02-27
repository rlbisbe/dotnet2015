using System;
using MvcSample.Web.Models;
using System.Collections.Generic;

namespace MvcSample.Web
{
    public interface ICervezaRepository
    {
		List<Cerveza> GetCervezas();
		
		DateTime GenerationDate { get; set; }
    }
}