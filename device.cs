using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace _01._04._2024.model
{
    internal class device
    {
        public string Width;
        public string Height;
        public string Weight;
        public device(string width,string height, string weight) 
        { 
            Width = width;
            Height = height;
            Weight = weight;
        }
        public void OpenDevice()
        {
         if(true)
         {
                Console.WriteLine("Device opening…");
         }
         else
            {
                Console.WriteLine("Device already opened");
            }
        }
        public void DeviceClose()
        {
            if(false)
            {
                Console.WriteLine("Device opening…");
            }
            else 
            {
                Console.WriteLine("Device already opened");
            }
        }
    }
}
