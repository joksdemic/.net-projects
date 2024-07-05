using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Konacno
{

    internal interface IUredjaj
    {
        string Proizvodjac { get; set; }

        string Model { get; set; }

        string Procesor { get; set; }

        string MaticnaPloca { get; set; }

        int Memorija { get; set; }

        string Boja { get; set; }

        string UredjajInfo();
    }

    internal interface IDesktop
    {
        string OperativniSistem { get; set; }

        int BrzinaProcesora { get; set; }

        string TipSocketa { get; set; }

    }

    internal interface ILaptop
    {
        int RezolucijaEkrana { get; set; }

        string TipEkrana { get; set; }

        string VrstaDiska { get; set; }
    }

    internal interface IMobilni
    {
        string KapacitetBaterije { get; set; }

        string SimSlot { get; set; }

        string Senzori { get; set; }
    }

    internal interface IGaming
    {
        string Konekcija { get; set; }

        float Dimenzije { get; set; }

        string Mreza { get; set; }
    }

    internal interface IPrinter
    {
        string BojaStampe { get; set; }

        string Format { get; set; }

        string TipSkenera { get; set; }
    }

    internal interface ISingleBoard
    {
        string Napajanje { get; set; }

        int Tezina { get; set; }
    }

    internal interface ITablet
    {
        float DijagonalaEkrana { get; set; }

        int BrojPortova { get; set; }

        bool DualSim { get; set; }
    }
}


