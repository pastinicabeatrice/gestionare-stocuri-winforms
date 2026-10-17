using System;

namespace Gestionare_Stocuri
{
    public enum TipOperatie
    {
        Achizitie,
        Vanzare,
        Transfer,
        Consum
    }

    public class Operatie
    {
        public int Id { get; private set; }
        public TipOperatie TipOperatie { get; private set; }
        public Material MaterialUtilizat { get; private set; }
        public int Cantitate { get; private set; }
        public DateTime DataOperatie { get; private set; }
        public string Descriere { get; private set; }

        public Operatie()
        {
            Id = 0;
            TipOperatie = TipOperatie.Achizitie;
            MaterialUtilizat = null;
            Cantitate = 0;
            DataOperatie = DateTime.MinValue;
            Descriere = " ";

            SetDescriere();
        }

        public Operatie(int id, TipOperatie tip, Material materialUtilizat, int cantitate, DateTime dataOperatie)
        {
            Id = id;
            TipOperatie = tip;
            MaterialUtilizat = materialUtilizat;
            Cantitate = cantitate;
            DataOperatie = dataOperatie;

            SetDescriere();
        }

        public void ActualizeazaOperatie(TipOperatie tip, Material materialUtilizat, int cantitate, DateTime dataOperatie)
        {
            TipOperatie = tip;
            MaterialUtilizat = materialUtilizat;
            Cantitate = cantitate;
            DataOperatie = dataOperatie;
            SetDescriere();
        }

        private void SetDescriere()
        {
            Descriere = $"Operatie: {TipOperatie}, Material: {MaterialUtilizat?.Nume}, Cantitate: {Cantitate}, Data: {DataOperatie.ToShortDateString()}";
        }
    }
}
