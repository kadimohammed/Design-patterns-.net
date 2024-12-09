using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E__Prototype
{
    internal class Forme
    {
        public string Type { get; set; }
        public string Couleur { get; set; }

        public Forme Clone()
        {
            // return (Forme)this.MemberwiseClone();
            return new Forme
            {
                Type = this.Type,
                Couleur = this.Couleur
            };
        }

        public override string ToString()
        {
            return $"Type: {Type}, Couleur: {Couleur}";
        }
    }
}
