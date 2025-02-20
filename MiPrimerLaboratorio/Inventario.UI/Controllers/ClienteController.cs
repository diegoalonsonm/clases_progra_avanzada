using Inventario.Abstracciones.LogicaNegocio.Cliente.ActualizarClienteLN;
using Inventario.Abstracciones.LogicaNegocio.Cliente.CrearClienteLN;
using Inventario.Abstracciones.LogicaNegocio.Cliente.EliminarClienteLN;
using Inventario.Abstracciones.LogicaNegocio.Cliente.ListarClienteLN;
using Inventario.Abstracciones.LogicaNegocio.Cliente.ObtenerClientePorIdLN;
using Inventario.Abstracciones.ModelosUI;
using Inventario.LogicaNegocio.Cliente.ActualizarCliente;
using Inventario.LogicaNegocio.Cliente.CrearCliente;
using Inventario.LogicaNegocio.Cliente.EliminarCliente;
using Inventario.LogicaNegocio.Cliente.ListarCliente;
using Inventario.LogicaNegocio.Cliente.ObtenerClientePorId;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace Inventario.UI.Controllers
{
    public class ClienteController : Controller
    {
        private IListarClienteLN _listarCliente;
        private ICrearClienteLN _crearCliente;
        private IObtenerClientePorIdLN _obtenerClientePorId;
        private IActualizarClienteLN _actualizarCliente;
        private IEliminarClienteLN _eliminarCliente;

        public ClienteController()
        {
            _listarCliente = new ListarClienteLN();
            _crearCliente = new CrearClienteLN();
            _obtenerClientePorId = new ObtenerClientePorIdLN();
            _actualizarCliente = new ActualizarClienteLN();
            _eliminarCliente = new EliminarClienteLN();
        }

        // GET: Cliente
        public ActionResult ListarCliente()
        {
            List<ClienteDTO> cliente = _listarCliente.ListarCliente();
            return View(cliente);
        }

        // GET: Cliente/Details/5
        public ActionResult DetallesCliente(int id)
        {
            ClienteDTO cliente = _obtenerClientePorId.ObtenerPorId(id);
            return View(cliente);
        }

        // GET: Cliente/Create
        public ActionResult CrearCliente()
        {
            return View();
        }

        // POST: Cliente/Create
        [HttpPost]
        public async Task<ActionResult> CrearCliente(ClienteDTO cliente)
        {
            try
            {
                int cantidadRegistros = await _crearCliente.crearCliente(cliente);

                return RedirectToAction("ListarCliente");
            }
            catch
            {
                return View();
            }
        }

        // GET: Cliente/Edit/5
        public ActionResult EditarCliente(int id)
        {
            ClienteDTO cliente = _obtenerClientePorId.ObtenerPorId(id);
            return View(cliente);
        }

        // POST: Cliente/Edit/5
        [HttpPost]
        public ActionResult EditarCliente(int id, ClienteDTO clienteDTO)
        {
            try
            {
                clienteDTO.idCliente = id;
                //await _crearCliente.crearCliente(clienteDTO);

                 _actualizarCliente.ActualizarCliente(clienteDTO);
                return RedirectToAction("ListarCliente");
            }
            catch
            {
                return View();
            }
        }

        // GET: Cliente/Delete/5
        public ActionResult EliminarCliente(int id)
        {
            ClienteDTO cliente = _obtenerClientePorId.ObtenerPorId(id);
            return View(cliente);
        }

        // POST: Cliente/Delete/5
        [HttpPost]
        public ActionResult EliminarCliente(int id, FormCollection collection)
        {
            try
            {
                _eliminarCliente.EliminarCliente(id);

                return RedirectToAction("ListarCliente");
            }
            catch
            {
                return View();
            }
        }
    }
}
