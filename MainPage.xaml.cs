namespace EFARINANGOT1
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }

     
        private void btn_Calcular_Clicked(object sender, EventArgs e)
        {
            Decimal salario = Convert.ToDecimal(txt_salario.Text);
            Decimal aporte = Convert.ToDecimal(9.45);
            Decimal DatoCalculado = ((salario * aporte) / 100);

            DisplayAlert("Alerta", "Bienvenido " + txt_nombre.Text + " " + txt_apellido.Text + "\nTienes  " + txt_edad.Text + " años\nTu aporte mensual es: " + DatoCalculado+"","Ok");
        }
    }

}
