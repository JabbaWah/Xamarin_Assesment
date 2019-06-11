using System;
using System.Collections.Generic;
using System.Text;

namespace Xamarin1019011_Task2.Models
{
    public class Token
    {
        public int ID { get; set; }
        public string AccessToken { get; set; }
        public string ErrorMessage { get; set; }
        public DateTime ExpiryDate { get; set; }

        public Token() { }
    }
}
