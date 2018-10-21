using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Oldtimer
{
    [Serializable]
    [XmlRoot(ElementName = "A")]
    public class Fahrzeug
    {

        [XmlElement("IdentNummer")]
        public int identnummer { get; set; }
        [XmlElement("Name")]
        public string name { get; set; }
        [XmlElement("Hersteller")]
        public string hersteller { get; set; }
        [XmlElement("Modell")]
        public string modell { get; set; }
        [XmlElement("Kennzeichen")]
        public string kennzeichen { get; set; }
        [XmlElement("Fahrzeugident")]
        public string fahrzeugident { get; set; }
        [XmlElement("Antriebsart")]
        public string antriebsart { get; set; }
        [XmlElement("Hoechstgeschwindigkeit")]
        public string hoechstgeschwindigkeit { get; set; }
        [XmlElement("Leistung")]
        public string leistung { get; set; }
        [XmlElement("kmmiles")]
        public int kmmiles { get; set; }






    }
    public class Wartung
    {

        [XmlElement("SollDatum")]
        public string WSollDatum { get; set; }
        [XmlElement("Sollkm")]
        public string Wkm { get; set; }
        [XmlElement("IstDatum")]
        public string WIstDatum { get; set; }
        [XmlElement("Istkm")]
        public string WIstkm { get; set; }
        [XmlElement("Thema")]
        public string wthema { get; set; }
        [XmlElement("Detail")]
        public string Wdetail { get; set; }
        






    }


}
