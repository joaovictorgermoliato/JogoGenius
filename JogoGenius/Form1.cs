using System.Drawing;

namespace JogoGenius
{
    public partial class Form1 : Form
    {


        int sequenciaSelecionada = -1;
        int sequenciaAtual = 0;
        int aux = 0;
        List<Button> sequencia;
        Color corPadrao;
        Color corPiscando;
        bool piscando = false;
        int nivel = 0;

        string corVerdePadrao = "DarkGreen";
        string corAmareloPadrao = "192; 192; 0";
        string corVermelhoPadrao = "DarkRed";
        string corAzulPadrao = "DarkBlue";


        string corVerdePiscando = "LightGreen";
        string corAmareloPiscando = "#FFFF99";
        string corVermelhoPiscando = "#F50E00";
        string corAzulPiscando = "LightBlue";



        public Form1()
        {
            InitializeComponent();

            btVerde.BackColor = ColorTranslator.FromHtml(corVerdePadrao);
            btAmarelo.BackColor = ColorTranslator.FromHtml(corAmareloPadrao);
            btVermelho.BackColor = ColorTranslator.FromHtml(corVermelhoPadrao);
            btAzul.BackColor = ColorTranslator.FromHtml(corAzulPadrao);


            btVerde.FlatAppearance.MouseOverBackColor = ColorTranslator.FromHtml(corVerdePadrao);
            btAmarelo.FlatAppearance.MouseOverBackColor = ColorTranslator.FromHtml(corAmareloPadrao);
            btVermelho.FlatAppearance.MouseOverBackColor = ColorTranslator.FromHtml(corVermelhoPadrao);
            btAzul.FlatAppearance.MouseOverBackColor = ColorTranslator.FromHtml(corAzulPadrao);

            btVerde.FlatAppearance.MouseDownBackColor = ColorTranslator.FromHtml(corVerdePiscando);
            btAmarelo.FlatAppearance.MouseDownBackColor = ColorTranslator.FromHtml(corAmareloPiscando);
            btVermelho.FlatAppearance.MouseDownBackColor = ColorTranslator.FromHtml(corVermelhoPiscando);
            btAzul.FlatAppearance.MouseDownBackColor = ColorTranslator.FromHtml(corAzulPiscando);

            btVerde.Cursor = Cursors.Hand;
            btAmarelo.Cursor = Cursors.Hand;
            btVermelho.Cursor = Cursors.Hand;
            btAzul.Cursor = Cursors.Hand;




        }


        private void btIniciar_Click(object sender, EventArgs e)
        {
            sequenciaSelecionada = -1;
            sequencia = new List<Button>();
            btIniciar.Enabled = false;

            nivel++;

            lbNivel.Text = nivel.ToString();

            GerarSequencia();
            Piscando();
            HabilitaDesabilitaBotao(true);

        }

        private void GerarSequencia()
        {
            Random random = new Random();
            int num = random.Next(0, 4);

            Button bt = null;

            switch (num)
            {

                case 0:
                    bt = btVerde;
                    break;
                case 1:
                    bt = btAmarelo;
                    break;
                case 2:
                    bt = btVermelho;
                    break;
                case 3:
                    bt = btAzul;
                    break;



            }

            sequencia.Add(bt);
        }



        private void Piscando()
        {
            aux = 0;

            for (int i = 0; i < sequencia.Count; i++)
            {
                sequenciaAtual = i;

                corPadrao = sequencia[i].BackColor;

                if (sequencia[i] == btVerde)
                    corPiscando = ColorTranslator.FromHtml(corVerdePiscando);
                else if (sequencia[i] == btAmarelo)
                    corPiscando = ColorTranslator.FromHtml(corAmareloPiscando);
                else if (sequencia[i] == btVermelho)
                    corPiscando = ColorTranslator.FromHtml(corVermelhoPiscando);
                else if (sequencia[i] == btAzul)
                    corPiscando = ColorTranslator.FromHtml(corAzulPiscando);

                timer1.Start();

                while (aux == i)
                {
                    Application.DoEvents();
                }

            }

        }

        private void HabilitaDesabilitaBotao(bool habilita)
        {
            btVerde.Enabled = habilita;
            btAmarelo.Enabled = habilita;
            btVermelho.Enabled = habilita;
            btAzul.Enabled = habilita;

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (!piscando)
            {
                sequencia[sequenciaAtual].BackColor = corPiscando;
                piscando = true;
            }
            else
            {
                sequencia[sequenciaAtual].BackColor = corPadrao;
                piscando = false;
                aux++;
                timer1.Stop();
            }

        }

        private void bt_Click(object sender, EventArgs e)
        {
            sequenciaSelecionada++;

            if (sequencia[sequenciaSelecionada] == (Button)sender)
            {
                if (sequencia.Count - 1 == sequenciaSelecionada)
                {
                    nivel++;
                    lbNivel.Text = nivel.ToString();
                    sequenciaSelecionada = -1;
                    HabilitaDesabilitaBotao(false);
                    GerarSequencia();
                    Thread.Sleep(500);
                    Piscando();
                    HabilitaDesabilitaBotao(true);

                }
            }

            else
            {
                btIniciar.Enabled = true;
                HabilitaDesabilitaBotao(false);
                nivel = 0;
                lbNivel.Text = "";
                MessageBox.Show("Sequência incorreta! Fim de jogo!");

            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            BackColor = Color.Black;
            this.Text = "Jogo Genius";
            label1.ForeColor = Color.White;
            lbNivel.ForeColor = Color.White;
            btIniciar.BackColor = Color.LightGreen;
            btIniciar.ForeColor = Color.Black;
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }
    }
}
