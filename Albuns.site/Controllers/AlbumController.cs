﻿using Albuns.site.Repository;
using System.Web.Mvc;

namespace Albuns.site.Controllers
{
    public class AlbumController : Controller
    {
        private readonly IAlbumRepository _albumRepository;

        public AlbumController(IAlbumRepository albumRepository)
        {
            _albumRepository = albumRepository;
        }

        public ActionResult Index(int id)
        {
            ViewBag.albums = _albumRepository.getAlbums(id);
            ViewBag.albumId = id;
            return View();
        }
    }
}