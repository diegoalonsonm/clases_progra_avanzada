using Inventario.Abstracciones.LogicaNegocio.Inventario.ListarInventario;
using Inventario.Abstracciones.ModelosUI;
using Inventario.LogicaNegocio.Inventario.ListarInventario;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.SessionState;

namespace Inventario.UI.Controllers
{
    public class InventarioController : Controller
    {
        IListarInventarioLN _listarInventario;

        public InventarioController()
        {
            _listarInventario = new ListarInventarioLN();
        }

        // GET: Inventario
        public ActionResult ListarInventario()
        {
            List<InventarioDTO> inventario = _listarInventario.ListarInventario();
            return View(inventario);
        }

        // GET: Inventario/Details/5
        public ActionResult DetallesInventario()
        {
            InventarioDTO inventario = new InventarioDTO();
            return View(inventario);
        }

        // GET: Inventario/Create
        public ActionResult CrearInventario()
        {
            return View();
        }

        // POST: Inventario/Create
        [HttpPost]
        public ActionResult CrearInventario(InventarioDTO inventario)
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
                }

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Inventario/Edit/5
        public ActionResult EditarInventario()
        {
            InventarioDTO inventario = new InventarioDTO { Vehiculo= "Nissan" };
            return View(inventario);
        }

        // POST: Inventario/Edit/5
        [HttpPost]
        public ActionResult EditarInventario(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Inventario/Delete/5
        public ActionResult EliminarInventario()
        {
            InventarioDTO inventario = new InventarioDTO { Vehiculo = "Nissan" };
            return View(inventario);
        }

        // POST: Inventario/Delete/5
        [HttpPost]
        public ActionResult EliminarInventario(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
