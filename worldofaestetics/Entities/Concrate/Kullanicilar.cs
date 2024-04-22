using System;
using Core.Entities;

namespace Entites.Concrate
{ 

public class Kullanicilar : IEntity
    {
    public int Id { get; set; }
    public string Name { get; set; }
    public string Soyad { get; set; }
    public int Telefonnumarasi { get; set; }
    public int CommentID { get; set; }
    public int RandevuId { get; set; }
    }


}