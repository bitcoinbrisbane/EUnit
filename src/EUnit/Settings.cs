using System;

namespace EUnit
{
    public class Settings
    {
        public String Url { get; set; }

        public Boolean TestRPC { get; set; }
        
        public String Account { get; set; }
        
        public String Password { get; set; }
        
        public Settings()
        {
        }
        
        public Settings(String[] inputs)
        {
            Url = inputs[0];
            Account = inputs[1];
            Password = inputs[2];
        }
    }
}