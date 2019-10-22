using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using ModeloLivro;

namespace PersistenciaLivro
{
    public class PLivro
    {
        private string arquivo = "arquivo.xml";
        public List<Livro> Open()
        {
            XmlSerializer x = new XmlSerializer(typeof(List<Livro>));
            StreamReader f = null;
            List<Livro> a = null;
            try
            {
                f = new StreamReader(arquivo, Encoding.Default);
                a = x.Deserialize(f) as List<Livro>;
            }
            catch
            {
                a = new List<Livro>();
            }
            finally
            {
                if (f != null) f.Close();
            }
            return a;
        }
        public void Save(List<Livro> a)
        {
            XmlSerializer x = new XmlSerializer(typeof(List<Livro>));
            StreamWriter f = new StreamWriter(arquivo, false, Encoding.Default);
            x.Serialize(f, a);
            f.Close();
        }
    }
}
