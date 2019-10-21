using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelo;
using Persistencia;

namespace Negocio
{
    public class NGame
    {
        public List<Game> Select()
        {
            PGame p = new PGame();
            return p.Open().OrderBy(Game => Game.Nome).ToList();
        }
        public List<Game> SelectData()
        {
            PGame p = new PGame();
            return p.Open().OrderBy(Game => Game.DataCompra).ToList();
        }
        public List<Game> Top10()
        {
            PGame p = new PGame();
            List<Game> novo = p.Open().OrderBy(Game => Game.Estrelas).ToList();
            List<Game> ret = new List<Game>();
            for(int i = 0; i < 10; i++)
            {
                ret.Add(novo[i]);
            }
            return ret;
        }
        public void Update(Game g)
        {
            PGame p = new PGame();
            List<Game> jg = p.Open();
            for(int i = 0; i < jg.Count; i++)
            {
                if(g.Id == jg[i].Id)
                {
                    jg.RemoveAt(i);
                    break;
                }
                jg.Add(g);
                p.Save(jg);
            }
        }
        public void Insert(Game g)
        {
            PGame p = new PGame();
            List<Game> jg = p.Open();
            int m = 0;
            foreach (Game x in jg) if (x.Id > m) m = x.Id;
            g.Id = m + 1;
            jg.Add(g);
            p.Save(jg);
        }
        public void Delete(Game g)
        {
            PGame p = new PGame();
            List<Game> cs = p.Open();
            for (int i = 0; i < cs.Count; i++)
                if (cs[i].Id == g.Id)
                {
                    cs.RemoveAt(i);
                    break;
                }
            p.Save(cs);
        }
    }
}
