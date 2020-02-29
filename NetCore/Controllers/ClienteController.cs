using Microsoft.AspNetCore.Mvc;
using NetCore.Model;
using NetCore.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NetCore.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClienteController: ControllerBase
    {
        ClienteRepository _Cliente;
        public ClienteController(NetCoreContext context)
        {
            _Cliente = new ClienteRepository(context);
        }

        [HttpGet]
        public IEnumerable<Entities.Cliente> GetAll()
        {
            return _Cliente.GetLista();
        }
        [HttpGet("{id}")]
        public Entities.Cliente Get(int id)
        {
            return _Cliente.GetEntity(id);
        }
        [HttpPost]
        public IActionResult Post(Entities.Cliente eEntidad)
        {
            if (!ModelState.IsValid)
                return BadRequest("Not a valid model");

            bool resul = _Cliente.Guardar(eEntidad);

            if (resul)
            {
                return Ok(new
                {
                    Mensaje = "Se inserto correctamente!!!",
                    Cliente = eEntidad
                });
            }
            else
            {
                return BadRequest("Erro al crear una nueva persona");
            }


        }
        [HttpPut]
        public IActionResult Put(Entities.Cliente eEntidad)
        {
            if (!ModelState.IsValid)
                return BadRequest("Not a valid model");

            bool resul = _Cliente.Modificar(eEntidad);

            if (resul)
            {
                return Ok(new
                {
                    Mensaje = "Se actulizo correctamente!!",
                    Cliente = eEntidad
                });
            }
            else
            {
                return BadRequest("Erro al modificar una persona");
            }


        }
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {

            if (id <= 0)
                return BadRequest("Not a valid person id");

            bool resul = _Cliente.Eliminar(id);

            if (resul)
            {
                return Ok(new
                {
                    Mensaje = "Se elimino correctamente!!"
                });
            }
            else
            {
                return BadRequest("Erro al eliminar una persona");
            }

        }
    }
}
