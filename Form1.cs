namespace NominaEmpleados
{
    public partial class Form1 : Form
    {

        // Instanciamos la clase 

        Empleado myEmpleado = new Empleado();
        Nomina myNomina = new Nomina();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            myEmpleado.Nombres = textNombre.Text;
            myEmpleado.Identificacion = textIdentificacion.Text;
            myEmpleado.ValorDia = Convert.ToDecimal(textValorDia.Text);

            myNomina.DiasLaborales = Convert.ToInt32(textDiasLab.Text);

            textNombre.Clear();
            textIdentificacion.Clear();
            textSalario.Clear();
            comboBoxCargo.ResetText();


            MessageBox.Show("Gracias, Su Registro Fue Guardado Exitosamente");



        }


        private void btnLiquidar_Click(object sender, EventArgs e)
        {
            textLiquidar.Text = myNomina.CalculandoNomina
                (Convert.ToInt32(myNomina.DiasLaborales), Convert.ToDecimal(myEmpleado.ValorDia)).ToString();

        }
        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            textNombre.Clear();
            textIdentificacion.Clear();
            comboBoxCargo.ResetText();
            textSalario.Clear();
            textValorDia.Clear();
            textDiasLab.Clear();
        }
    }
}