using System;
namespace HerançaMultipla.Entities
{
    abstract class Device
    {
        public int SerialNumber { get; set; }

        public abstract void processDoc(string doc);
    }
}