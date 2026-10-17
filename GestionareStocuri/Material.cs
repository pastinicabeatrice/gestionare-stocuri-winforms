using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestionare_Stocuri
{
    public enum CategorieMaterial
    {
        MateriePrima,
        ProdusFinit,
        Consumabile,
        Ambalaje
    }
    public class Material
    {
        [Key]
       
        public int Id { get; set; }
        public string Nume { get;  set; }
        public string CodDeBare { get;  set; }
        public int Cantitate { get; set; }
        public decimal Pret { get; set; }
        public DateTime DataExpirare { get; set; }
        public string Caracteristici { get; set; }
        public string Furnizor { get; set; }
        public string LocatieStoc { get; set; }
        public double Greutate { get; set; }
        public double Lungime { get; set; }
        public double Latime { get; set; }
        public double Inaltime { get; set; }
        public DateTime DataAdaugareStoc { get; set; }
        public virtual ICollection<Operatie> Operatii { get; set; }
        public TipOperatie TipOperatie { get; set; }
        public CategorieMaterial Categorie { get; set; }

        public Material()
        {
            Id = 0;
            Nume = " ";
            CodDeBare = " ";
            Cantitate = 0;
            Pret = 0;
            DataExpirare = DateTime.MinValue;
            Furnizor = " ";
            LocatieStoc = " ";
            Greutate = 0;
            Lungime = 0;
            Latime = 0;
            Inaltime = 0;
            DataAdaugareStoc = DateTime.MinValue;

            SetCaracteristici();
            Operatii = new List<Operatie>();
        }

        public Material(int id, string nume, string codDeBare, int cantitate, decimal pret, DateTime dataExpirare, string furnizor, string locatieStoc, double greutate, double lungime, double latime, double inaltime, DateTime dataAdugareStoc)
        {
            Id = id;
            Nume = nume;
            CodDeBare = codDeBare;
            Cantitate = cantitate;
            Pret = pret;
            DataExpirare = dataExpirare;
            Furnizor = furnizor;
            LocatieStoc = locatieStoc;
            Greutate = greutate;
            Lungime = latime;
            Inaltime = inaltime;
            DataAdaugareStoc = dataAdugareStoc;

            SetCaracteristici();
            Operatii = new List<Operatie>();
        }

        private void SetCaracteristici()
        {
            Caracteristici = $"Nume: {Nume}, CodDeBare: {CodDeBare}, Cantitate: {Cantitate}, Pret: {Pret}, DataExpirare: {DataExpirare.ToShortDateString()}, " +
                             $"Furnizor: {Furnizor}, LocatieStoc: {LocatieStoc}, Greutate: {Greutate} kg, Dimensiuni: {Lungime} x {Latime} x {Inaltime} m, " +
                             $"DataAdaugareStoc: {DataAdaugareStoc.ToShortDateString()}";
        }
    }
}
