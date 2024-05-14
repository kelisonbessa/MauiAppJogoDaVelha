namespace MauiAppJogoDaVelha
{
    public partial class MainPage : ContentPage
    {
        string vez = "X";
        int countPlays = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            countPlays++;
            Button btn = (Button)sender;
            btn.IsEnabled = false;


            if(vez == "X")
            {
                btn.Text = "X";
                line(vez);
                vez = "O";
            }
            else
            {
                btn.Text = "O";
                line(vez);
                vez = "X";
            }

            if (countPlays >= 9)
            {
                DisplayAlert("Empate", "Partida empatada parabéns ao dois jogadores", "OK");
                zerar();
            }

        }
        
        private void line(string game)
        {
            if ((btn10.Text == game && btn11.Text == game && btn12.Text == game)
                || (btn20.Text == game && btn21.Text == game && btn22.Text == game)
                || (btn30.Text == game && btn31.Text == game && btn32.Text == game)
                || (btn10.Text == game && btn20.Text == game && btn30.Text == game)
                || (btn11.Text == game && btn21.Text == game && btn31.Text == game)
                || (btn12.Text == game && btn22.Text == game && btn32.Text == game)
                || (btn10.Text == game && btn21.Text == game && btn32.Text == game)
                || (btn12.Text == game && btn21.Text == game && btn30.Text == game))
            {
                DisplayAlert("Parabéns", $"O {game} Ganhou!", "OK");
                zerar();
            }
            
        }

        private void zerar()
        {
            btn10.Text = "";
            btn11.Text = "";
            btn12.Text = "";
            btn20.Text = "";
            btn21.Text = "";
            btn22.Text = "";
            btn30.Text = "";
            btn31.Text = "";
            btn32.Text = "";

            btn10.IsEnabled = true;
            btn11.IsEnabled = true;
            btn12.IsEnabled = true;
            btn20.IsEnabled = true;
            btn21.IsEnabled = true;
            btn22.IsEnabled = true;
            btn30.IsEnabled = true;
            btn31.IsEnabled = true;
            btn32.IsEnabled = true;

            countPlays = 0;
        }
    }

}
