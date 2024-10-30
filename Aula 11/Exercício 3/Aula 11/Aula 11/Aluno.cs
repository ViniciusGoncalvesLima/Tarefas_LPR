using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_11
{
    internal class Aluno
    {
        public string matricula, nome;
        public float prova1, prova2, trabalho, media, final;

        public float calcMedia()
        {
            media = (prova1 + prova2) * 5 + trabalho * 4;
        }

        public float calcFinal()
        {
            if (media < 60)
            {
                final = 60 - media;
            } else
            {
                return 0;
            }
        }
    }
}