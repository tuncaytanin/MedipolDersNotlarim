using KutuphaneYonetimi1O.Entites.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace KutuphaneYonetimi1O.MVC.Controllers.Api
{
    public class KategoriController : ApiController
    {
        private KutuphaneContext db;
        public KategoriController()
        {
            db = new KutuphaneContext();
        }

        [HttpGet]

        public IHttpActionResult GetKategoris()
        {
            var kategoris = db.Kategori.Where(x => x.KategoriDurumu == true).ToList();

            return Ok(kategoris);
        }

        //api/kategori/1
        [HttpGet]
        public IHttpActionResult GetKategori(int id)
        {
            var kategori = db.Kategori.SingleOrDefault(x => x.KategoriId == id);
            if (kategori == null)
                return NotFound();
            return Ok(kategori);
        }

        [HttpPost]
        public IHttpActionResult AddKategori(Kategori pKategori)
        {
            if (!ModelState.IsValid)
                return BadRequest();

            db.Kategori.Add(pKategori);
                db.SaveChanges();
            return Ok(pKategori);
        }

        [HttpPut]
        public IHttpActionResult UpdateKategori(int id , Kategori pKategori)
        {
            if (!ModelState.IsValid)
                return BadRequest();

            var kategori = db.Kategori.SingleOrDefault(x=>x.KategoriId == id);
            if (kategori == null)
                return NotFound();

            kategori.KategoriAdi = pKategori.KategoriAdi;
            kategori.KategoriDurumu = pKategori.KategoriDurumu;
            kategori.KategoriAciklama = pKategori.KategoriAciklama;
            db.SaveChanges();

            return Ok(kategori);
        }  

        [HttpDelete]
        public IHttpActionResult DeleteKategori(int id)
        {
            var kategori = db.Kategori.SingleOrDefault(x=>x.KategoriId == id);
            if (kategori == null)
                return NotFound();
            db.Kategori.Remove(kategori);
            db.SaveChanges();

            return Ok();
        }
    }
}
