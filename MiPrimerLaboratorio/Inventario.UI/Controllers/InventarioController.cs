using Inventario.Abstracciones.AccessoDatos.Inventario.ObtenerInvenstarioPorId;
using Inventario.Abstracciones.LogicaNegocio.Inventario.ActualizarInventarioLN;
using Inventario.Abstracciones.LogicaNegocio.Inventario.CrearInventarioLN;
using Inventario.Abstracciones.LogicaNegocio.Inventario.EliminarInventarioLN;
using Inventario.Abstracciones.LogicaNegocio.Inventario.ListarInventario;
using Inventario.Abstracciones.LogicaNegocio.Inventario.ObtenerInventarioIdLN;
using Inventario.Abstracciones.ModelosUI;
using Inventario.LogicaNegocio.Inventario.ActualizarInventario;
using Inventario.LogicaNegocio.Inventario.CrearInventario;
using Inventario.LogicaNegocio.Inventario.EliminarInventario;
using Inventario.LogicaNegocio.Inventario.ListarInventario;
using Inventario.LogicaNegocio.Inventario.ObtenerInventarioId;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using System.Web.SessionState;

namespace Inventario.UI.Controllers
{
    [Authorize]
    public class InventarioController : Controller
    {
        private IListarInventarioLN _listarInventario;
        private ICrearInventarioLN _crearInventario;
        private IObtenerInventarioIdLN _obtenerInventarioId;
        private IActualizarInventarioLN _actualizarInventario;
        private IEliminarInventarioLN _eliminarInventario;

        public InventarioController()
        {
            _listarInventario = new ListarInventarioLN();
            _crearInventario = new CrearInventarioLN();
            _obtenerInventarioId = new ObtenerInventarioIdLN();
            _actualizarInventario = new ActualizarInventarioLN();
            _eliminarInventario = new EliminarInventarioLN();
        }

        // GET: Inventario
        [Authorize(Roles = "Administrador")]
        public ActionResult ListarInventario()
        {
            List<InventarioDTO> inventario = _listarInventario.ListarInventario();
            return View(inventario);
        }

        // GET: Inventario/Details/5
        public ActionResult DetallesInventario(int id)
        {
            InventarioDTO inventario = _obtenerInventarioId.ListarInventario(id);
            return View(inventario);
        }

        // GET: Inventario/Create
        public ActionResult CrearInventario()
        {
            return View();
        }

        // POST: Inventario/Create
        [HttpPost]
        public async Task<ActionResult> CrearInventario(InventarioDTO inventario)
        {
            try
            {
                if (inventario.archivo != null && inventario.archivo.ContentLength > 0)
                {                   
                    byte[] arhicvoBytes;
                    using (var memoriaStream = new System.IO.MemoryStream())
                    {
                        inventario.archivo.InputStream.CopyTo(memoriaStream);
                        arhicvoBytes = memoriaStream.ToArray();
                    }

                    string base64String = Convert.ToBase64String(arhicvoBytes);
                    int cantidadRegistros = await _crearInventario.CrearInventario(inventario);
                }

                return RedirectToAction("ListarInventario");
            }
            catch
            {
                return View();
            }
        }

        // GET: Inventario/Edit/5
        public ActionResult EditarInventario(int id)
        {
            InventarioDTO inventario = _obtenerInventarioId.ListarInventario(id);
            return View(inventario);
        }

        // POST: Inventario/Edit/5
        [HttpPost]
        public ActionResult EditarInventario(int id, InventarioDTO inventario)
        {
            try
            {
                inventario.Id = id;
                _actualizarInventario.ActualizarInventario(inventario);

                return RedirectToAction("ListarInventario");
            }
            catch
            {
                return View();
            }
        }

        // GET: Inventario/Delete/5
        public ActionResult EliminarInventario(int id)
        {
            InventarioDTO inventario = _obtenerInventarioId.ListarInventario(id);
            return View(inventario);
        }

        // POST: Inventario/Delete/5
        [HttpPost]
        public ActionResult EliminarInventario(int id, InventarioDTO inventario)
        {
            try
            {
                //inventario.Id = id;
                _eliminarInventario.EliminarInventario(id);

                return RedirectToAction("ListarInventario");
            }
            catch
            {
                return View();
            }
        }
    }
}
