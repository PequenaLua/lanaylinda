using Modelo;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Persistencia
{
    public class PGame
    {
        private string arquivo = "arquivo.xml";
        public void Save(List<Game> v)
        {
            XmlSerializer x = new XmlSerializer(typeof(List<Game>));
            StreamWriter s = new StreamWriter(arquivo, false, Encoding.Default);
            x.Serialize(s, v);
            s.Close();
        }
        public List<Game> Open()
        {
            XmlSerializer x = new XmlSerializer(typeof(List<Game>));
            StreamReader s = null;
            List<Game> gm = null;
            try
            {
                s = new StreamReader(arquivo, Encoding.Default);
                gm = x.Deserialize(s) as List<Game>;
            }
            catch
            {
                gm = new List<Game>();
            }
            finally
            {
                if (s != null) s.Close();
            }
            return gm;
        }
    }
}
