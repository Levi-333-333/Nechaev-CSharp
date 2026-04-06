using System; // Системные классы и функции
using System.Collections.Generic;
using System.Diagnostics;
using System.Security.AccessControl;
using System.Threading.Channels; // Коллекции, на подобие List, Dictionary и так далее

namespace Nechaev_CSharp // Пространство имён
{
    class Instrument
    {
        private string model;
        private float coast;
        private bool isTune;
        public string Model
        {
            get { return model; }
            set { model = value; }
        }
        public float Coast
        {
            get { return coast; }
            set { coast = value; }
        }
        public bool IsTune
        {
            get { return isTune; }
            set { isTune = value; }
        }
        public Instrument(string model, float coast, bool isTune)
        {
            this.model = model;
            this.coast = coast;
            this.isTune = isTune;
        }

        public void Play() => Console.WriteLine("Инструмент звучит");
        public void Tune()
        {
            isTune = true;
            Console.WriteLine("Инструмент настроен");
        }
    }
    class Gutar : Instrument
    {
        private uint stringCount;
        private bool isElectronic;
        public uint StringCount
        {
            get { return stringCount; }
            set { stringCount = value; }
        }
        public bool IsElectronic
        {
            get { return isElectronic; }
            set { isElectronic = value; }
        }
        public Gutar(uint stringCount, bool isElectronic, string model, float coast, bool isTune) : base(model, coast, isTune)
        {
            this.stringCount = stringCount;
            this.isElectronic = isElectronic;
        }
        public void PerformOnTheStreet()
        {
            if (IsTune) Console.WriteLine("Вы брынчите на улице. В будущем вы строчаетесь");
            else Console.WriteLine("Вы позоритесь на всю улицу. В будущем вы строчаетесь");
        }
    }
    class Piano : Instrument
    {
        private uint fretsCount;
        private bool isElectronic;
        public uint FretsCount
        {
            get { return fretsCount; }
            set { fretsCount = value; }
        }
        public bool IsElectronic
        {
            get { return isElectronic; }
            set { isElectronic = value; }
        }
        public Piano(uint fretsCount, bool isElectronic, string model, float coast, bool isTune) : base(model, coast, isTune)
        {
            this.fretsCount = fretsCount;
            this.isElectronic = isElectronic;
        }
        public void PerformInARestaurant()
        {
            if (IsTune) Console.WriteLine("Вы в красивом костюме выступаете в элитном ресторане");
            else Console.WriteLine("Вы позоритель на глазах у элиты");
        }
    }

    class Source
    {
        static void Main(string[] args)
        {
            Gutar gutar = new Gutar(6, false, "Jet", 15000, false);
            gutar.PerformOnTheStreet();
            gutar.Tune();
            gutar.PerformOnTheStreet();
            Instrument newGutar = gutar;
            newGutar.Coast = 3000;
            if (newGutar is Gutar) Console.WriteLine("Вы сторчались.");
        }
    }
}