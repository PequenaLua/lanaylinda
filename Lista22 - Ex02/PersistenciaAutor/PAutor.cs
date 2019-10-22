using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using ModeloAutor;

namespace PersistenciaAutor
{
    class PAutor
    {
        private string arquivo = "arquivo.xml";
        public List<Autor> Open()
        {
            XmlSerializer x = new XmlSerializer(typeof(List<Autor>));
            StreamReader f = null;
            List<Autor> l = null;
            try
            {
                f = new StreamReader(arquivo, Encoding.Default);
                l = x.Deserialize(f) as List<Autor>;
            }
            catch
            {
                l = new List<Autor>();
            }
            finally
            {
                if (f != null) f.Close();
            }
            return l;
        }
        public void Save(List<Autor> l)
        {
            XmlSerializer x = new XmlSerializer(typeof(List<Autor>));
            StreamWriter f = new StreamWriter(arquivo, "")
        }
    }
}
