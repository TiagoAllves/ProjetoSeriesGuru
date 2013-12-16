using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ProjetoSeriesGuru.Entidades;
using ProjetoSeriesGuru.Repositorio;
using ProjetoSeriesGuru.Web.Models;

namespace ProjetoSeriesGuru.Web.Controllers
{
    public class UsuarioController : Controller
    {
        //
        // GET: /Usuario/

        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Cadastrar(UsuarioModel usuarioModel)
        {
            var usuarioDomain = new Usuario();
            var repositorio = new Usuarios();
            
            usuarioDomain.Nome = usuarioModel.Nome;
            usuarioDomain.Sobrenome = usuarioModel.Sobrenome;
            usuarioDomain.Senha = usuarioModel.Senha;
            usuarioDomain.Email = usuarioModel.Email;
            usuarioDomain.Sexo = usuarioModel.Sexo;
            repositorio.Salvar(usuarioDomain);
            return View("Index");
        }
        public ActionResult Buscar(UsuarioModel usuarioModel)
        {
            var repositorio = new Usuarios();
            repositorio.ObterPor(usuarioModel.Email, usuarioModel.Senha);
            return View("Home");
        }
    }
}
