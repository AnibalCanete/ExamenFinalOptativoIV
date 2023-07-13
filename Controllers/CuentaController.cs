using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ExamenFinalOptativoIV.Controllers
{
    [Controller]
    [Route("api/[controller]")]
    public class CuentaController : Controller
    {
        private cuentaService servicio;
        string cadenaConexion = "Server=127.0.0.1;Port=8080;Database=OptativoIV;User Id=postgres;Password=admin";

        public CuentaController()
        {
            servicio = new cuentaService(cadenaConexion);
        }

        // GET: api/values
        [HttpGet]

        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/values/5
        [HttpGet("consultar/{cuenta}")]

        public infraestructure.Models.cuentaModel Get(string cuenta)
        {
            var result = servicio.consultarCuenta(cuenta);
            return result;
        }

        // POST api/values
        [HttpPost]
        
        public void Post([FromBody]string value)
        {

        }

        // PUT api/values/5
        [HttpPost("{id}")]

        public void Put(int id, [FromBody]string value)
        {

        }

        // DELETE api/values/5
        [HttpDelete("{id}")]

        public void Delete(int id)
        {

        }
        // GET: CuentaController
        public ActionResult Index()
        {
            return View();
        }

        // GET: CuentaController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: CuentaController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: CuentaController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: CuentaController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: CuentaController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: CuentaController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: CuentaController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
