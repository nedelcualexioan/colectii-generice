using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace colectii_generice
{
    public class Masina:IComparable<Masina>
    {
        private int id;
        private int persId;
        private String marca;
        private String model;
        private String culoare;
        private int anFabricatie;

        public Masina(int id, int persId, String marca, String model, String culoare, int anFabricatie)
        {
            this.id = id;
            this.persId = persId;
            this.marca = marca;
            this.model = model;
            this.culoare = culoare;
            this.anFabricatie = anFabricatie;
        }

        public Masina(String line)
        {
            id = int.Parse(line.Split(',')[0]);
            persId = int.Parse(line.Split(',')[1]);
            marca = line.Split(',')[2];
            model = line.Split(',')[3];
            culoare = line.Split(',')[4];
            anFabricatie = int.Parse(line.Split(',')[5]);
        }

        public int Id
        {
            get => id;
            set => id = value;
        }

        public int PersId
        {
            get => persId;
            set => persId = value;
        }
        public String Marca
        {
            get => this.marca;
            set => this.marca = value;
        }

        public String Model
        {
            get => this.model;
            set => this.model = value;
        }

        public String Culoare
        {
            get => this.culoare;
            set => this.culoare = value;
        }

        public int AnFabricatie
        {
            get => this.anFabricatie;
            set => this.anFabricatie = value;
        }

        public int CompareTo(Masina other)
        {
            if (this.AnFabricatie.CompareTo(other.AnFabricatie) > 0)
                return 1;

            if (this.AnFabricatie.CompareTo(other.AnFabricatie) < 0)
                return -1;

            return 0;
        }

        public override bool Equals(object obj)
        {
            if(obj is Masina m)
            {
                return m.Marca == marca && m.Model == model && m.Culoare == culoare && m.AnFabricatie == anFabricatie;
            }

            return false;
        }

        public override String ToString()
        {
            String text = "";

            text += "ID: " + id + "\n";
            text += "ID proprietar: " + persId + "\n";
            text += "Marca: " + marca + "\n";
            text += "Model: " + model + "\n";
            text += "Culoare: " + culoare + "\n";
            text += "An fabricatie: " + anFabricatie + "\n";

            return text;
        }
    }
}
