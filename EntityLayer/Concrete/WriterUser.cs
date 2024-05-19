using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class WriterUser :IdentityUser<int>
    {
        //burda verdiğimiz prop lar sql de user tablosunda olup AspNetUsers tablosunda olmayan başlıklardır.
        public string Name { get; set; }

        public string UserName { get; set; }

        public string ImageUrl { get; set; }





    }
}
