using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using TestFDLT.Models;
using System.IO;
using System.Net.Http;

namespace TestFDLT.Controllers
{
    public class PersonaController : Controller
    {
        public JsonResult LlamarJson()
        {
            /*List<Persona> listPersonas = null;
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(@"https://rest.fidelitytools.net/Fidelitytools/Segmentacion/Persona/Obtener/ff759bde0391fc5e85289e943488a13d/NTQ2Mw/true/0/10");
            using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
            using (Stream stream = response.GetResponseStream())
            using (StreamReader reader = new StreamReader(stream))
            {
                var json = reader.ReadToEnd();
                List<Persona> listPersonas = JsonConvert.DeserializeObject<List<Persona>>(json);
                return Json(listPersonas, JsonRequestBehavior.AllowGet);
            }*/
            using (var client = new WebClient())

            {
                string json = client.DownloadString("https://rest.fidelitytools.net/Fidelitytools/Segmentacion/Persona/Obtener/ff759bde0391fc5e85289e943488a13d/NTQ2Mw/true/0/10");
                dynamic jsonResult = JsonConvert.DeserializeObject<dynamic>(json);
                List<Persona> listPersonas = jsonResult.personas;
                return Json(listPersonas, JsonRequestBehavior.AllowGet);
            }

            /*Prueba JArray
             * using (var client = new WebClient())

            {
                Persona rowsResult = null;
                string json = client.DownloadString("https://rest.fidelitytools.net/Fidelitytools/Segmentacion/Persona/Obtener/ff759bde0391fc5e85289e943488a13d/NTQ2Mw/true/0/10");
                dynamic jsonResult = JsonConvert.DeserializeObject<dynamic>(json);
                JArray jsonResponse = JArray.Parse(jsonResult.personas);

                foreach (var item in jsonResponse)
                {
                    JObject jRaces = (JObject)item["personas"];
                    foreach (var rItem in jRaces)
                    {
                        string rItemKey = rItem.Key;
                        JObject rItemValueJson = (JObject)rItem.Value;
                        rowsResult = Newtonsoft.Json.JsonConvert.DeserializeObject<Persona>(rItemValueJson.ToString());
                    }
                }
                //List<Persona> listPersonas = JsonConvert.DeserializeObject<List<Persona>>(json);
                //List<Persona> listPersonas = jsonResult.personas;
                return Json(rowsResult, JsonRequestBehavior.AllowGet);
                */

            //También arroja excepción con Dictionary...
                    
        }

        // GET: Persona
        public ActionResult Persona_vista()
        {
            return View();
        }

        // GET: Persona/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Persona/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Persona/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Persona/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Persona/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
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

        // GET: Persona/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Persona/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
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
