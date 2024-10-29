using System;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace PBL_II
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            ConfigurarGrafico();
        }

        /// <summary>
        /// Evento disparado ao clicar no botão calcular.
        /// Faz a validação das entradas e realiza os cálculos necessários para obter o vetor de velocidade resultante e o tempo de travessia.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void calcular_Click(object sender, EventArgs e)
        {
            double largura = Convert.ToDouble(numeric_largura.Text);
            double velocidadeMotor = Convert.ToDouble(numeric_velocidade_motor.Text);
            double velocidadeCorrenteza = Convert.ToDouble(numeric_modulo_correnteza.Text);
            double angulo = Convert.ToDouble(numeric_angulo.Text);

            if (!ValidarEntradas(largura, velocidadeMotor, velocidadeCorrenteza, angulo))
                return;

            double[] vetorVelocidadeRes = CalcularVetorVelocidadeRes(velocidadeMotor, velocidadeCorrenteza, angulo);
            double tempoTravessia = largura / vetorVelocidadeRes[1];

            chart1.Series[0].Points.Clear();

            CalcularCoordenadas(vetorVelocidadeRes, tempoTravessia);
        }

        #region Cálculos

        /// <summary>
        /// Calcula o vetor de velocidade resultante levando em conta a velocidade do motor, a velocidade da correnteza e o ângulo.
        /// </summary>
        /// <param name="velocidadeMotor"></param>
        /// <param name="velocidadeCorrenteza"></param>
        /// <param name="angulo"></param>
        /// <returns></returns>
        private double[] CalcularVetorVelocidadeRes(double velocidadeMotor, double velocidadeCorrenteza, double angulo)
        {
            double anguloRad = angulo * (Math.PI / 180);

            double[] vetorVelocidadeRel = new double[]
            {
                velocidadeMotor * Math.Cos(anguloRad),
                velocidadeMotor * Math.Sin(anguloRad)
            };

            return new double[]
            {
                vetorVelocidadeRel[0] + velocidadeCorrenteza,
                vetorVelocidadeRel[1]
            };
        }

        /// <summary>
        /// Calcula as coordenadas finais.
        /// </summary>
        /// <param name="vetorVelocidadeRes"></param>
        /// <param name="tempoTravessia"></param>
        private void CalcularCoordenadas(double[] vetorVelocidadeRes, double tempoTravessia)
        {
            int numIntervalos = 10;
            double deltaT = tempoTravessia / numIntervalos;

            for (int i = 0; i <= numIntervalos; i++)
            {
                double t = i * deltaT;

                double coordX = vetorVelocidadeRes[0] * t;
                double coordY = vetorVelocidadeRes[1] * t;

                // Adiciona o ponto ao gráfico
                chart1.Series[0].Points.AddXY(coordX, coordY);
            }
        }

        #endregion

        #region Gráfico

        /// <summary>
        /// Configura o gráfico para plotar os pontos.
        /// </summary>
        private void ConfigurarGrafico()
        {
            chart1.Series.Clear();
            Series serie = new Series("Trajetória");
            serie.ChartType = SeriesChartType.Line;
            chart1.Series.Add(serie);

            chart1.ChartAreas[0].AxisX.Title = "Posição X (m)";
            chart1.ChartAreas[0].AxisY.Title = "Posição Y (m)";
        }

        #endregion


        #region Validações
        /// <summary>
        /// Valida se o valor fornecido está dentro do intervalo especificado.
        /// </summary>
        /// <param name="valor"></param>
        /// <param name="min"></param>
        /// <param name="max"></param>
        /// <param name="campo"></param>
        /// <returns>True caso esteja válido, false caso não</returns>
        private bool ValidarIntervalo(double valor, double min, double max, string campo)
        {
            if ((campo != "ângulo" && (valor < min || valor > max)) || (valor <= min || valor >= max))
            {
                MessageBox.Show($"Por favor, insira um valor entre {min} e {max} para {campo}.");
                return false;
            }
            return true;
        }

        /// <summary>
        /// Valida todas as entradas, como largura, velocidade do motor, velocidade da correnteza e ângulo.
        /// </summary>
        /// <param name="largura"></param>
        /// <param name="velocidadeMotor"></param>
        /// <param name="velocidadeCorrenteza"></param>
        /// <param name="angulo"></param>
        /// <returns>True caso estejam todas válidas, false caso não</returns>
        private bool ValidarEntradas(double largura, double velocidadeMotor, double velocidadeCorrenteza, double angulo)
        {
            if (!ValidarIntervalo(largura, 20, 100, "largura")) return false;
            if (!ValidarIntervalo(velocidadeMotor, 2, 10, "velocidade do motor")) return false;
            if (!ValidarIntervalo(velocidadeCorrenteza, 1, 4, "velocidade da correnteza")) return false;
            if (!ValidarIntervalo(angulo, 20, 160, "ângulo")) return false;

            return true;
        }
        #endregion
    }
}
