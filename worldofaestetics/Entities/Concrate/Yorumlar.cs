using System;
using Core.Entities;

namespace Entites.Concrate
{

    public class Yorumlar : IEntity
    {
		public int ID { get; set; }
		public string Kullaniciadi { get; set; }
        public int Yorum { get; set; }
        public int Tarih { get; set; }

    }
}