using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TGDI_Vorbereiter
{
    public partial class BasisN : Form
    {
        private Random rand = new Random();
        private const int N_NUMBERS = 4;

        private List<string[]> zahlen = new List<string[]>();

        public BasisN()
        {
            InitializeComponent();
            ZahlenGenerieren();

        }

        private void generierenBtn_Click(object sender, EventArgs e)
            => ZahlenGenerieren();

        private void ZahlenGenerieren()
        {
            zahlensystemeMatrix.Rows.Clear();
            zahlen.Clear();

            for (int i = 0; i < N_NUMBERS; i++)
            {
                var zufallszahl = rand.Next(1, 255);

                var umgerechnet = new string[] {
                    DezimalZuBasisN(zufallszahl, 2),
                    DezimalZuBasisN(zufallszahl, 8),
                    DezimalZuBasisN(zufallszahl, 10),
                    DezimalZuBasisN(zufallszahl, 16)
                };

                zahlen.Add(umgerechnet);

                List<string> ausgabe = new List<string>();
                for(int j = 1; j < (i + 1); j++)
                    ausgabe.Add("");

                ausgabe.Add(umgerechnet[i]);

                zahlensystemeMatrix.Rows.Add(ausgabe.ToArray());
            }
        }

        private string DezimalZuBasisN(int zahl, int basis)
            => Convert.ToString(zahl, basis);

        private void prüfenBtn_Click(object sender, EventArgs e)
        {
            zahlensystemeMatrix.Rows.Clear();

            foreach(var numbers in zahlen)
                zahlensystemeMatrix.Rows.Add(numbers.ToArray());
        }
    }
}
