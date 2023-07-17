using System;
using System.Collections.Generic;
using System.Text;

namespace AccessModifiers
{
    public class House
    {
        string _suburb;

        public House()
        {

        }

        // prop'un default erişimi private
        public int Id { get; set; }
        private string City { get; set; }// Sadece kendi classında erişilebilir.
        protected string Suburb { get; set; }// Sadece kendi classında ve class'ı inherit eden classlardan erişilebilir.
    }

    public class HouseTest : House // protected örneği
    {
        public HouseTest()
        {
            
        }
    }
}
