
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;


namespace Oldtimer
{

    public partial class Main : Form
  
  //  public partial class Main : MetroFramework.Forms.MetroForm

    {
      // private ArrayList arrList = new ArrayList();
        private static List<Fahrzeug> Fahrzeuge = new List<Fahrzeug>();
        private static List<Wartung> wartungen = new List<Wartung>();
        private static Boolean changedData;
        

        public Main()
        {
            InitializeComponent();

          

            //Fahrzeug XML einlesen
            XMLReaderFahrzeug();
        
        }

        

        private void buttonSaveFahrzeug_Click(object sender, EventArgs e)
        {
           
            Fahrzeug fahrzeugObjekt;
            int index = comboBox1.SelectedIndex;
            if (index == -1)
            {

                fahrzeugObjekt = new Fahrzeug();
                Fahrzeuge.Add(fahrzeugObjekt);
                if (Fahrzeuge.Count == 0)
                {
                    fahrzeugObjekt.identnummer = 1;
                } else { fahrzeugObjekt.identnummer = Fahrzeuge[Fahrzeuge.Count() - 1].identnummer + 1; }

                comboBox1.Items.Add(textBoxModell.Text + " " + textBoxHersteller.Text);



            }
            else
            {
                fahrzeugObjekt = Fahrzeuge[index];
            }
            fahrzeugObjekt.kennzeichen = textBoxKennzeichen.Text;
            fahrzeugObjekt.hersteller = textBoxHersteller.Text;
            fahrzeugObjekt.modell = textBoxModell.Text;
            fahrzeugObjekt.antriebsart = textBoxAntriebsart.Text;
            fahrzeugObjekt.fahrzeugident = textBoxIdentifikation.Text;
            fahrzeugObjekt.hoechstgeschwindigkeit = textBoxHoechstgeschwindigkeit.Text;
            fahrzeugObjekt.leistung = textBoxLeistung.Text;
            fahrzeugObjekt.kmmiles = comboBoxkmmiles.SelectedIndex;

            Datenserializer("\\Fahrzeuge.xml");



            
        }

       

        

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void XMLReaderFahrzeug()

        {
            if (File.Exists("Fahrzeuge.xml"))
            {
                using (FileStream fs = new FileStream("Fahrzeuge.xml", FileMode.Open))
                {
                    //Vorher XmlSerializer xmlSer = new XmlSerializer(typeof(ArrayList), new Type[] { typeof(Fahrzeug) });
                    XmlSerializer xmlSer = new XmlSerializer(typeof(List<Fahrzeug>));
                    Fahrzeuge = (List<Fahrzeug>)xmlSer.Deserialize(fs);
                }
            
        }
        comboBox1.Items.Clear();


            foreach (Fahrzeug p in Fahrzeuge)
        comboBox1.Items.Add(p.modell+ " "+p.hersteller);

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = comboBox1.SelectedIndex;
            if (index!=-1)
            {
                textBoxKennzeichen.Text = Fahrzeuge[index].kennzeichen;
                textBoxHersteller.Text = Fahrzeuge[index].hersteller;
                textBoxModell.Text = Fahrzeuge[index].modell;
                textBoxAntriebsart.Text = Fahrzeuge[index].antriebsart;
                textBoxIdentifikation.Text = Fahrzeuge[index].fahrzeugident;
                textBoxLeistung.Text = Fahrzeuge[index].leistung;
                textBoxHoechstgeschwindigkeit.Text = Fahrzeuge[index].hoechstgeschwindigkeit;
                comboBoxkmmiles.SelectedIndex = Fahrzeuge[index].kmmiles;
                

            }
            
          
        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
          
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void ButtonNeuesFahrzeug_Click(object sender, EventArgs e)
        {

            // Neu angewählt
            changedData = false;
            comboBox1.SelectedIndex = -1;
            textBoxKennzeichen.Text = "";
            textBoxHersteller.Text = "";
            textBoxModell.Text = "";
            textBoxAntriebsart.Text = "";
            textBoxIdentifikation.Text = "";
            textBoxLeistung.Text = "";
            textBoxHoechstgeschwindigkeit.Text = "";
            comboBoxkmmiles.SelectedIndex = -1;

        }

        private void textBoxKennzeichen_TextChanged(object sender, EventArgs e)
        {
            changedData = true;

        }

        private void labelLeistung_Click(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void metroTextBox1_Click(object sender, EventArgs e)
        {

        }

        private void buttondelFahrzeug_Click(object sender, EventArgs e)
        {
            //Delete Entry
            int index = comboBox1.SelectedIndex;
            if (index != -1)
            {
                Fahrzeuge.RemoveAt(index);
               Datenserializer("\\Fahrzeuge.xml");


            }

        }


        private void Datenserializer(string xmldatei)
        {
            if (xmldatei.Contains("Fahrzeuge.xml")) { XmlSerializer serializer = new XmlSerializer(typeof(List<Fahrzeug>));
                FileStream file = new FileStream(Application.StartupPath
                                         + xmldatei,
                                         FileMode.Create);
                serializer.Serialize(file, Fahrzeuge);
                file.Close();
            }
            
                
           


        }


    }


}
