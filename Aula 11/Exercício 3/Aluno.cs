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

        public void calcMedia()
        {
            media = ((prova1 + prova2) * 5 + trabalho * 4)/14;
        }

        public void calcFinal()
        {
            if (media < 60)
            {
                final = 60 - media;
                Console.WriteLine($"O aluno precisa de {final} pontos na prova final");
            } else
            {
                final = 0;
                Console.WriteLine("O aluno não precisa fazer final");
            }
        }
    }
}