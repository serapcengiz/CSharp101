using System;
namespace toDo
{
    class Kart
    {
        
            private string baslik;
            private string icerik;
            private string atananKisi;
            private string buyukluk;
            private int Durum=0;

            public Kart(string baslik,string icerik,string atananKisi,string buyukluk)
            {
                Baslik=baslik;
                Icerik=icerik;
                AtananKisi=atananKisi;
                Buyukluk=buyukluk;
            }

        public string Baslik { get => baslik; set => baslik = value; }
        public string Icerik { get => icerik; set => icerik = value; }
        public string AtananKisi { get => atananKisi; set => atananKisi = value; }
        public string Buyukluk{get =>buyukluk;set =>buyukluk=value;}
        
        public int Durum1 { get => Durum; set => Durum = value; }
    }
}