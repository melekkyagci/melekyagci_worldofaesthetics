using System;
using Core.Entities;

namespace Entites.Concrate
{
	public class Randevu : IEntity
    {
		public int Id { get; set; }
		public string isim { get; set; }
		public string soyisim { get; set; }
		public int numara { get; set; }
        public int randevutarihi { get; set; }
        public int bolum { get; set; }

    }
}