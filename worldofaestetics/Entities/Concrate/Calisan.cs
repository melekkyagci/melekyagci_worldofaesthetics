using System;
using Core.Entities;

namespace Entites.Concrate
{
    public class Calisan : IEntity
    {
        public int Id { get; set; }   
        public string isim { get; set; }
        public string soyisim { get; set; }
        public int sifre { get; set; }
    }
}