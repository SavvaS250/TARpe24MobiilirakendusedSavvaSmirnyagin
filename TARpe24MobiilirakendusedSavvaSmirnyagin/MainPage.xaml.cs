namespace TARpe24MobiilirakendusedSavvaSmirnyagin
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        private void OnCounterClicked(object? sender, EventArgs e)
        {
            count++;

            if (count == 1)
                CounterBtn.Text = $"Clicked {count} time";
            else if (count == 10)
                CounterBtn.Text = $"Great job, clicked {count} times!";
            else
                CounterBtn.Text = $"Clicked {count} times";

            if (count == 10)
            {
                botImage.IsVisible = false; // Peidab pildi
                CounterLabel.Text = "Pilt kadus ära!";
            }

            if (count >= 11)
            {
                botImage.IsVisible = true;
            }


            if (botImage.HorizontalOptions == LayoutOptions.Start)
            {
                botImage.HorizontalOptions = LayoutOptions.End;
            }
            else
            {
                botImage.HorizontalOptions = LayoutOptions.Start;
            }
            
            if(count >= 1)
            {
                botImage.Scale += 0.2; //iga nuppu vajutamisega pilt muutub suuremaks
            }
            

            botImage.Rotation += 15;

            var rnd = new Random();
            var rndColor = Color.FromRgb(rnd.Next(256), rnd.Next(256), rnd.Next(256));
            var rndColor2 = Color.FromRgb(rnd.Next(256), rnd.Next(256), rnd.Next(256));
            BackgroundColor = rndColor2;
            if (count >= 5)
            {
                CounterBtn.BackgroundColor = rndColor;
                CounterBtn.TextColor = Colors.White;
            }

            SemanticScreenReader.Announce(CounterBtn.Text);
        }

        private void ResetBtn_Clicked(object sender, EventArgs e)
        {
            count = 0;
            CounterBtn.Text = "Start again!";
            botImage.Rotation = 0;
            botImage.IsVisible = true; // Toob pildi tagasi
            CounterLabel.Text = "";
            botImage.HorizontalOptions = LayoutOptions.Center;
            botImage.Scale = 1;
            BackgroundColor = Colors.White;
            CounterBtn.BackgroundColor = Colors.MediumPurple;
            CounterBtn.TextColor = Colors.Black;
        }
    }
}
