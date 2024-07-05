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
//using System.Web.Script.Serialization;
using System.Xml.Serialization;
using System.Collections;

namespace Konacno
{
    
    public partial class Form1 : Form

    {
        public List<ClassDesktop> Lista = new List<ClassDesktop>();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnPokreni_Click(object sender, EventArgs e)
        {
            if (lblPokreni.Text == "Pokrenuto")
            {
                lblPokreni.Text = "Pokreni";
            }
            else
            {
                lblPokreni.Text = "Pokrenuto";
            }
        }



        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnUnesi_Click(object sender, EventArgs e)
        {

            try
            {
                ClassDesktop x = new ClassDesktop();
                x.Proizvodjac = txt1.Text;
                x.Model = txt2.Text;
                x.Procesor = txt3.Text;
                x.MaticnaPloca = txt4.Text;
                x.Memorija = Convert.ToInt32(txt5.Text);
                x.OperativniSistem = txt6.Text;
                x.BrzinaProcesora = Convert.ToInt32(txt7.Text);
                x.TipSocketa = txt8.Text;
                Lista.Add(x);
                PuniListu();
            }
            catch
            {
                MessageBox.Show("greska");
            }

        }

        public void PuniListu()
        {
            try 
            { ListaDesktopova.Items.Clear(); 
                foreach (ClassDesktop l in Lista)
                { ListaDesktopova.Items.Add(l.UredjajInfo()); } } 
            catch 
            { MessageBox.Show("greska"); } }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //private void btnExport_Click(object sender, EventArgs e)
        //{
        //    {
        //        try
        //        {
        //            //JavaScriptSerializer js = new JavaScriptSerializer();
        //            //string JSON = js.Serialize(Lista);
        //            txtjson.Text = JSON;

        //            StreamReader sr = new StreamReader(@"C:\export\Desktopovi.json");
        //            string json = sr.ReadToEnd();
        //            sr.Close();

        //            List<ClassDesktop> sListaJSON = new List<ClassDesktop>();

        //            sListaJSON = js.Deserialize<List<ClassDesktop>>(json);

        //            ListaDesk.Items.Clear();
        //            foreach (ClassDesktop std in sListaJSON)
        //            {
        //                ListaDesk.Items.Add(std.ToString());
        //            }
        //        }
        //        catch
        //        {
        //            MessageBox.Show("greska");
        //        }
        //    }
        //}


    }
}

