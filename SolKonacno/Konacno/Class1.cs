using Konacno;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Konacno
{
    public class ClsUredjaj : IUredjaj
    {
        public string _Proizvodjac;
        public string _Model;
        public string _Procesor;
        public string _MaticnaPloca;
        public int _Memorija;
        public string _Boja;

        public string Proizvodjac { get { return _Proizvodjac; } set { _Proizvodjac = value; } }

        public string Model { get { return _Model; } set { _Model = value; } }

        public string Procesor { get { return _Procesor; } set { _Procesor = value; } }

        public string MaticnaPloca { get { return _MaticnaPloca; } set { _MaticnaPloca = value; } }

        public int Memorija { get { return _Memorija; } set { _Memorija = value; } }

        public string Boja { get { return _Boja; } set { _Boja = value; } }


        public virtual string UredjajInfo()
        {
            return string.Format("Proizvodjac: {0}, Model: {1}, Procesor: {2}, MaticnaPloca{3}, Memorija: {4}, Boja{5} ", this.Proizvodjac, this.Model, this.Procesor, this.MaticnaPloca, this.Memorija.ToString(), this.Boja);

        }

    }
    public class ClassDesktop : ClsUredjaj, IDesktop
    {
        public string _OperativniSistem;
        public int _BrzinaProcesora;
        public string _TipSocketa;


        public string OperativniSistem { get { return _OperativniSistem; } set { _OperativniSistem = value; } }

        public int BrzinaProcesora { get { return _BrzinaProcesora; } set { _BrzinaProcesora = value; } }

        public string TipSocketa { get { return _TipSocketa; } set { _TipSocketa = value; } }

        public override string UredjajInfo()
        {
            return "Desktop";
        }


    }

    public class ClassLaptop : ClsUredjaj, ILaptop
    {
        private int _RezolucijaEkrana;
        private string _TipEkrana;
        private string _VrstaDiska;

        public int RezolucijaEkrana { get { return _RezolucijaEkrana; } set { _RezolucijaEkrana = value; } }

        public string TipEkrana { get { return _TipEkrana; } set { _TipEkrana = value; } }

        public string VrstaDiska { get { return _VrstaDiska; } set { _VrstaDiska = value; } }

        public override string UredjajInfo()
        {
            return "Laptop ";
        }
    }
}
public class ClassMobilni : ClsUredjaj, IMobilni
{
    private string _KapacitetBaterije;
    private string _SimSlot;
    private string _Senzori;

    public string KapacitetBaterije { get { return _KapacitetBaterije; } set { _KapacitetBaterije = value; } }

    public string SimSlot { get { return _SimSlot; } set { _SimSlot = value; } }

    public string Senzori { get { return _Senzori; } set { _Senzori = value; } }


    public override string UredjajInfo()
    {
        return "Mobilni";
    }
}

public class ClassGaming : ClsUredjaj, IGaming
{
    private string _Konekcija;
    private float _Dimenzije;
    private string _Mreza;

    public string Konekcija { get { return _Konekcija; } set { _Konekcija = value; } }
    public float Dimenzije { get { return _Dimenzije; } set { _Dimenzije = value; } }
    public string Mreza { get { return _Mreza; } set { _Mreza = value; } }

    public override string UredjajInfo()
    {
        return "gaming";
    }
}


public class ClassPrinter : ClsUredjaj, IPrinter
{
    private string _BojaStampe;
    private string _Format;
    private string _TipSkenera;

    public string BojaStampe { get { return _BojaStampe; } set { _BojaStampe = value; } }

    public string Format { get { return _Format; } set { _Format = value; } }

    public string TipSkenera { get { return _TipSkenera; } set { _TipSkenera = value; } }

    public override string UredjajInfo()
    {
        return "Printer";
    }
}

public class ClassSingleBoard : ClsUredjaj, ISingleBoard
{
    private string _Napajanje;
    private int _Tezina;

    public string Napajanje { get { return _Napajanje; } set { _Napajanje = value; } }

    public int Tezina { get { return _Tezina; } set { _Tezina = value; } }

    public override string UredjajInfo()
    {
        return "Single Board";
    }
}

public class ClassTablet : ClsUredjaj, ITablet
{
    private float _DijagonalaEkrana;
    private int _BrojPortova;
    private bool _DualSim;

    public float DijagonalaEkrana { get { return _DijagonalaEkrana; } set { _DijagonalaEkrana = value; } }

    public int BrojPortova { get { return _BrojPortova; } set { _BrojPortova = value; } }

    public bool DualSim { get { return _DualSim; } set { _DualSim = value; } }


    public override string UredjajInfo()
    {
        return "Tablet";
    }
}

