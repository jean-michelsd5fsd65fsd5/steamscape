using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace generation_map
{
    class Pattern_map
    {
        private List<Obj_loc> objets;

        public Pattern_map(List<Obj_loc> objets)
        {
            Objets = objets;
        }
        public Pattern_map(string path)
        {
            Objets = this.load(path);
        }

        public void save(string path)
        {
            XmlSerializer xs = new XmlSerializer(typeof(List<Obj_loc>));
            using (StreamWriter wr = new StreamWriter(path+".xml"))
            {
                xs.Serialize(wr, objets);
            }
        }
        public List<Obj_loc> load(string path)
        {
            List<Obj_loc> liste = new List<Obj_loc>();
            XmlSerializer xs = new XmlSerializer(typeof(List<Obj_loc>));
            using (StreamReader rd = new StreamReader(path + ".xml"))
            {
                liste = xs.Deserialize(rd) as List<Obj_loc>;
            }
            return liste;
        }

        public List<Obj_loc> Objets
        {
            get { return objets; }
            set { objets = value; }
        }
        public override string ToString()
        {
            string texte = "liste : \n";
            foreach (var item in Objets)
            {
                texte += item + "\n";
            }
            return texte;
        }
    }
}
