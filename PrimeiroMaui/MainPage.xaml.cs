namespace PrimeiroMaui
{
    public partial class MainPage : ContentPage
    {
        

        public MainPage()
        {
            InitializeComponent();
        }

        public void Button_Clicked(object sender, EventArgs e)
        {
            double A = Convert.ToDouble(txt_n1.Text);
            double B = Convert.ToDouble(txt_n2.Text);
            double C = Convert.ToDouble(txt_n3.Text);

            double delta = (B * B) - 4 * A * C;

            double raiz = Math.Sqrt(delta);

           

            double resP = (-(B) + raiz) / 2 * A;

            double resN = (-(B) - raiz) / (2 * A);

            string msg = $"O resultado positivo é: " + resP + " O resultado negativo é: " + resN;

            if (delta < 0)
            {
                DisplayAlert("Maui", "Escreva numeros que o resultado da raiz seja inteira", "Fechar");
            }
            else
            {
                DisplayAlert("Maui", msg, "Fechar");
            }
        }
    }

}
