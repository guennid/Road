
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
            if (index==-1)
            {
                fahrzeugObjekt = new Fahrzeug();
                Fahrzeuge.Add(fahrzeugObjekt);
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



            //Erstelle einen XML-Serialisierer für Objekte vom Typ Blog

            // vorher XmlSerializer serializer = new XmlSerializer(typeof(ArrayList), new Type[] { typeof(Fahrzeug) });
            XmlSerializer serializer = new XmlSerializer(typeof(List<Fahrzeug>));
            //Erstelle einen FileStream auf die Datei, in die unserer
            //Blog-Objekt in XML-Form gespeichert werden soll.
            FileStream file = new FileStream(Application.StartupPath
                                             + "\\Fahrzeuge.xml",
                                             FileMode.Create);
            //Serialisiere das übergebene Blog-Objekt (blogObj)
            //und schreibe es in den FileStream.
            //vorher serializer.Serialize(file, arrList);
            serializer.Serialize(file, Fahrzeuge);
            //Schließe die XML-Datei.
            file.Close();
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

        
    }


}
