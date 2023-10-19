using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace IskolaAPI.Controllers
{
    [Microsoft.AspNetCore.Mvc.Route("api/[controller]")]
    [ApiController]
    public class TesztController : ControllerBase
    {

        // Csak a publikus metódusok látszanak HTTP végpontként
        // Ha nem adjuk meg, akkor alapértelmezetten GET metódussal lekérdezhető
        // api/Teszt/Udvozles
        // Route nélkül: api/Teszt/Udvozles?nev=Bence
        // Route-al: api/Teszt/Udvozles/Bence
        [HttpGet]
        [Microsoft.AspNetCore.Mvc.Route("Udvozles/{nev}")]
        public string Udvozles(string nev = "Felhasználó")
        {
            return "szia " + nev + "!";
        }

        // api/Teszt/Negyzete/5
        // 1-nél több HTTP végpontnál meg kell adni
        // a ROUTE útvonalat
        // négyzetes zárójeles jelölő = attribútum, annotáció
        //[HttpGet]
        //[Route("Negyzete/{szam}")]
        [HttpGet("Negyzete/{szam}")]
        public string Negyzete(double szam)
        {
            return Math.Pow(szam, 2).ToString();
        }
    }
}
