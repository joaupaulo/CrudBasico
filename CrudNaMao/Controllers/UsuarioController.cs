using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CrudNaMao.Models;
using CrudNaMao.Models.Contexto;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace CrudNaMao.Controllers
{
    public class UsuarioController : Controller
    {





        private readonly UsuarioModelContext _usuario;

        public UsuarioController(UsuarioModelContext usuario)
        {
            _usuario = usuario;

        }



        public IActionResult Index()
        {

            var lista = _usuario.Usuario.ToList();
            CarregaTipoUsuario();
            return View(lista);
        }


        [HttpGet]
        public IActionResult Create()
        {

            var usuario = new Usuario();
            CarregaTipoUsuario();
            return View(usuario);
        }




        [HttpPost]
        public IActionResult Create(Usuario usuario)
        {

           if(ModelState.IsValid)
            {
                _usuario.Usuario.Add(usuario);
                _usuario.SaveChanges();
               
                return RedirectToAction("Index");
            }
            CarregaTipoUsuario();
            return View(usuario);
        }


        [HttpGet]
        public IActionResult Edit(int Id)
        {

            var usuario = _usuario.Usuario.Find(Id);

            if(usuario != null)
            {


            }
            CarregaTipoUsuario();
            return View(usuario);
        }





        [HttpPost]
        public IActionResult Edit(Usuario usuario)
        {

            if (ModelState.IsValid)
            {
                _usuario.Usuario.Update(usuario);
                _usuario.SaveChanges();
                return RedirectToAction("Index");
            } else
            {
                CarregaTipoUsuario();
                return View(usuario);
            }



        }





        [HttpGet]
        public IActionResult Delete(int Id)
        {
            var usuario = _usuario.Usuario.Find(Id);
            return View(usuario);
            CarregaTipoUsuario();
        }

        [HttpPost]
        public IActionResult Delete(Usuario _user)
        {
            var usuario = _usuario.Usuario.Find(_user.Id);
            if(_user != null)
            {
                _usuario.Usuario.Remove(usuario);
                _usuario.SaveChanges();
                return RedirectToAction("Index");
            }
            CarregaTipoUsuario();
            return View(usuario);
        }




        [HttpGet]
        public IActionResult Details(int Id)
        {
            var usuario = _usuario.Usuario.Find(Id);
            CarregaTipoUsuario();
            return View(usuario);
        }


public void CarregaTipoUsuario()
        {

            var itensTipoUsuario = new List<SelectListItem>
            {
                new SelectListItem{ Value = "1", Text = "Administrador"},
                new SelectListItem{ Value = "2", Text = "Tecnico"},
                new SelectListItem{ Value = "3", Text = "Usuário Normal"}
            };


            ViewBag.TiposUsuario = itensTipoUsuario;
        }



    }
}
