using Microsoft.Quantum.Simulation.Core;
using Microsoft.Quantum.Simulation.Simulators;
using System.Diagnostics;

namespace Cliente
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private async void cmdExecute_Click(object sender, EventArgs e)
        {

            #region Setup
            int intNumberOfExperiments = 0;
            int intValue = 0;

            //limpa qualquer alteração anterior
            lstOutput.Items.Clear();
            lblStatus.Text = "Status: Iniciando...";
            #endregion

            #region Captura os parâmetros

            if (txtValue.Text == string.Empty || !(int.TryParse(txtValue.Text, out intValue)))
            {
                MessageBox.Show("Por favor, entre com um valor válido para realizar a fatoração.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (txtNumberOfInteractions.Text == string.Empty || !(int.TryParse(txtNumberOfInteractions.Text, out intNumberOfExperiments)))
            {
                MessageBox.Show("Por favor, entre com um valor válido para o número de interações.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            #endregion

            #region Calcula os fatores do valor
            // Variavel para guardar a lista de resultados do Fatorizador 
            List<long> aintValues = new List<long>();

            // Cria o simulador local
            lblStatus.Text = "Status: Criando o simulador...";
            var sim = new QuantumSimulator();

            // Executa N Interações no Simulador
            lblStatus.Text = "Status: Iniciando o Loop de Experimentos...";
            for (int i = 0; i < intNumberOfExperiments; i++)
            {
                lblStatus.Text = string.Format("Status: Interação {0}", i);
                long resultado = await GrooverFatorialQuantum.FactorizeWithGrovers2.Run(sim, intValue);
                aintValues.Add(resultado);
            }

            #endregion

            #region Determina a frequencia e ordena a quantidade do menor para o maior

            // Utiliza o LINQ para agrupar (contar a frequencia) e ordernar
            var aintResult = aintValues.GroupBy(x => x)
                .OrderBy(g => g.Count());

            // Imprime na Lista
            lblStatus.Text = "Status: Imprindo a lista...";
            foreach (var objItem in aintResult)
            {
                lstOutput.Items.Add(string.Format("{0} ocorre {1} vezes", objItem.Key, objItem.Count()));
            }
            #endregion 

            lblStatus.Text = "Status: Concluido.";
        }
    }
}