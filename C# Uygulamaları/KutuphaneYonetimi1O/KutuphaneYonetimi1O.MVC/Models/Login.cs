using KutuphaneYonetimi1O.Entites.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KutuphaneYonetimi1O.MVC.Models
{
    public static class Login
    {

        //toDo kategori eklemede cache tazeleme yap
        //
        private static List<Kategori> kategoris;
        // propertis
        public static List<Kategori> Kategoris
        {
            get {
                if (kategoris ==null)
                {
                    KategorileriListele();
                }
                return kategoris; 
            }
            set { kategoris = value; }
        }


        private static List<Yazar> yazars;

        public  static List<Yazar> Yazars { 
            get {
                if (yazars ==null)
                {
                    YazarlariListele();
                }
                return yazars;
            } set { yazars = value; }
        }


        private static List<Personel> personels;

        public static List<Personel> Personels{
            get
            {
                if (personels==null)
                {
                    PersonelleriListele();
                }
                return personels;
            }
            set { personels = value; } 
        }


        private static List<YayinEvi> yayinEvis;
        public static List<YayinEvi>  YayinEvis{
            get
            {
                if (yayinEvis == null)
                {
                    YayinEviListele();
                }
                return yayinEvis;
            }
            set { yayinEvis = value; }
                }

        private static void YayinEviListele()
        {
            using (KutuphaneContext db = new KutuphaneContext())
            {
                yayinEvis = db.YayinEvi.AsNoTracking().ToList();
            }
        }

        private static List<Kitap> kitaps;
        public static List<Kitap> Kitaps {
            get
            {
                if (kitaps==null)
                {
                    KitaplariListele();
                    if (kategoris == null)
                    {
                        KategorileriListele();
                    }
                    if (yazars == null)
                    {
                        YazarlariListele();
                    }
                    if (yayinEvis == null)
                    {
                        YayinEviListele();
                    }

                    KitabiEslemeYap();
                }
                return kitaps;
            }
            set
            {
                kitaps = value;
            }
        }



        private static void KitabiEslemeYap()
        {
            for (int i = 0; i < kitaps.Count; i++)
            {
                kitaps[i].Kategori = kategoris.Where(x => x.KategoriId == kitaps[i].KategoriId).FirstOrDefault();
                kitaps[i].Yazar = yazars.Where(x => x.YazarId == kitaps[i].YazarId).FirstOrDefault();
                kitaps[i].YayinEvi = yayinEvis.Where(x => x.YayinEviId == kitaps[i].YayinEviId).FirstOrDefault();
            }
        }

        private static List<Uye> uyes;
        public static List<Uye> Uyes {
            get
            {
                if (uyes==null)
                {
                    UyeleriListele();
                }
                return uyes;
            }
            set
            {
                uyes = value;
            }
        }

        private static void UyeleriListele()
        {
            using (KutuphaneContext db = new KutuphaneContext())
            {
                uyes = db.Uye.AsNoTracking().ToList();
            }
        }

        private static void KitaplariListele()
        {
            using (KutuphaneContext db =new KutuphaneContext())
            {
                kitaps = db.Kitap.ToList();
            }
        }

        private static void PersonelleriListele()
        {
            using (KutuphaneContext db = new KutuphaneContext())
            {
                personels = db.Personel.AsNoTracking().ToList();
            }
        }

        private static void YazarlariListele()
        {
            using (KutuphaneContext db = new KutuphaneContext())
            {
                yazars = db.Yazar.AsNoTracking().ToList();
            }

        }

        private static void KategorileriListele()
        {
            using (KutuphaneContext db = new KutuphaneContext())
            {
                kategoris = db.Kategori.AsNoTracking().ToList();
            }
        }
    }
}