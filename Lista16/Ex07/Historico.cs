﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex07
{
    class Historico
    {
        private string aluno;
        private Disciplina[] discs = new Disciplina[30];
        private int m;
        public void SetNome(string a) {aluno = a;}
        public void Inserir(Disciplina d)
        {
            if(m < 30)
            {
               discs[m] = d;
                m++;
            }
        }
        public Disciplina[] Listar()
        {
            Disciplina[] vetor = new Disciplina[m];
            Array.Copy(discs, vetor, m);
            return vetor;
        }
        public double CalcularIRA()
        {
            double ira = 0;
            for(int k = 0; k < m; k++)
            {
                ira += discs[k].GetMedia();
            }
            ira /= m;
            return ira;
        }
    }
    class Disciplina
    {
        private string nome;
        private string semestre;
        private double media;
        private bool aprovado;
        public void SetNome(string n) { nome = n; }
        public void SetSemestre(string s) { semestre = s; }
        public void SetMedia(double m) { media = m; }
        public void SetAprovado(bool a) { aprovado = a; }
        public double GetMedia()
        {
            return media;
        }
        public override string ToString()
        {
            if (aprovado == true)
                return $"{nome} - {semestre} - {media:0} - Aprovado";
            else
                return $"{nome} - {semestre} - {media:0} - Não aprovado";
        }
    }
}
