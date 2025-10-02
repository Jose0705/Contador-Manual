namespace ContadorManual
{
    public partial class MainPage : ContentPage
    {
        // conteo lleva el conteo de la aplic git statusacion
        private int conteo;
        public MainPage()
        {
            InitializeComponent();
            conteo = 0;
            ConteoLabel.Text = conteo.ToString();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            conteo++;
            ConteoLabel.Text = conteo.ToString();
        }

        private void Button_Clicked_1(object sender, EventArgs e)
        {
            conteo = 0;
            ConteoLabel.Text = conteo.ToString();
        }
    }
}
