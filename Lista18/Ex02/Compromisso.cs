using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex02
{
    class Compromisso
    {
        public string assunto { get; set; }
        public string local { get; set; }
        public DateTime data { get; set; }
        public override string ToString()
        {
            return $"{assunto} - {local} - {data}";
        }
    }
}
