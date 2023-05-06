using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace Proiect_paw
{
    public partial class Form2 : Form
    {
        List<Imobil> listaImobile;
        public Form2()
        {
            InitializeComponent();
           
        }
        
        public void displayImobile()
        {
            listView1.Items.Clear();
            foreach( var imobil in listaImobile)
            {
                ListViewItem listViewItem = new ListViewItem(imobil.IdImobil.ToString());
                listViewItem.SubItems.Add(imobil.TipImobil.ToString());
                listViewItem.SubItems.Add(imobil.Adresa);
                listViewItem.SubItems.Add(imobil.SuprafataUtila.ToString());
                listViewItem.SubItems.Add(imobil.NrCamere.ToString());
                listViewItem.SubItems.Add(imobil.Pret.ToString());
                listViewItem.SubItems.Add(imobil.Descriere);
                listViewItem.Tag = imobil;
                listView1.Items.Add(listViewItem);
            }

        }

        public Form2(List<Imobil> listaImob)
        {
            InitializeComponent();
            listaImobile =listaImob;
            displayImobile();
        }

        private void tbForm2ImbViz_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnStergere_Click(object sender, EventArgs e)
        {
            foreach(ListViewItem itm in listView1.Items)
            {
                if(itm.Checked)
                {
                    int idIm=Convert.ToInt32(itm.SubItems[0].Text);
                    for(int i=0;i<listaImobile.Count;i++)
                    {
                        if (listaImobile[i].IdImobil == idIm)
                            listaImobile.RemoveAt(i);
                    }
                    itm.Remove();
                }
            }
        }

        private void listView1_ItemChecked(object sender, ItemCheckedEventArgs e)
        {
            if(e.Item.Checked)
            {
                e.Item.BackColor = Color.Pink;
            }
            if(e.Item.Checked==false)
            { e.Item.BackColor = Color.White; }
        }

        private void serializareToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BinaryFormatter bf=new BinaryFormatter();
            using (FileStream fs = File.OpenWrite("imobile.bin"))
            {
                bf.Serialize(fs, listaImobile);
            }
        }

        private void deserializareToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BinaryFormatter bf = new BinaryFormatter();
            using(FileStream fs=File.OpenRead("imobile.bin"))
            {
                listaImobile = (List<Imobil>)bf.Deserialize(fs);
                displayImobile();
            }
        }
    }
}
