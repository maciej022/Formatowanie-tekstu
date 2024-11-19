using System.Diagnostics.Metrics;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Edytor
{

    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        //metoda, która aktualizuje zmiany wprowadzone do tekstu
        private void Aktualizuj(object sender, RoutedEventArgs e)
        {
            // jeśli kontrolki nie mają wartości, zamyka się program
            if (bold == null || italic == null || Podkresl == null || Czarnyczcionk == null || Czerwonyczcionk == null ||
                Zielonyczcionk == null || Niebieskiczcionk == null ||
                BezowyTlo == null || CzerwonyTlo == null || ZielonyTlo == null
                || NiebieskiTlo == null || Lewo == null || Srodek == null || Prawo == null || Just == null || Arial == null ||
                Times == null || Courier == null || panel == null || suwak == null)
            {
                return; //zamknięcie programu
            }
            //aktualizuje metody zmieniające poszczególne elementy
            UstawKolorCzcionki();
            UstawKolorTla();
            UstawJustowanie();s
            UstawStylCzcionki();
            UstawKrojCzcionki();
            RozmCzionki();
            Progres();
        }


        //ustawienie koloru czcionki
        private void UstawKolorCzcionki()
        {
            if (Czarnyczcionk.IsChecked == true)
            {
                poletekstu.Foreground = Brushes.Black;
            }
            if (Czerwonyczcionk.IsChecked == true)
            {
                poletekstu.Foreground = Brushes.Red;
            }
            if (Zielonyczcionk.IsChecked == true)
            {
                poletekstu.Foreground = Brushes.Green;
            }
            if (Niebieskiczcionk.IsChecked == true)
            {
                poletekstu.Foreground = Brushes.Blue;
            }
        }

        private void UstawKolorTla()
        {
            if (BezowyTlo.IsChecked == true)
            {
                poletekstu.Background = Brushes.DarkKhaki;
            }
            if (CzerwonyTlo.IsChecked == true)
            {
                poletekstu.Background = Brushes.Red;
            }
            if (ZielonyTlo.IsChecked == true)
            {
                poletekstu.Background = Brushes.Green;
            }
            if (NiebieskiTlo.IsChecked == true)
            {
                poletekstu.Background = Brushes.Blue;
            }
        }

        private void UstawJustowanie()
        {
            if (Lewo.IsChecked == true)
                poletekstu.TextAlignment = TextAlignment.Left;
            if (Srodek.IsChecked == true)
                poletekstu.TextAlignment = TextAlignment.Center;
            if (Prawo.IsChecked == true)
                poletekstu.TextAlignment = TextAlignment.Right;
            if (Just.IsChecked == true)
                poletekstu.TextAlignment = TextAlignment.Justify;

        }

        private void UstawStylCzcionki()
        {
            //Domyślny styl tesktu
            var styl = FontStyles.Normal;
            var grubosc = FontWeights.Normal;
            var dodatki = new TextDecorationCollection();

            //jaki styl ma być po zaznaczeniu
            if (bold.IsChecked == true)
                grubosc = FontWeights.Bold;
            if (italic.IsChecked == true)
                styl = FontStyles.Italic;
            if (Podkresl.IsChecked == true)
                dodatki = TextDecorations.Underline;
            poletekstu.FontStyle = styl;
            poletekstu.FontWeight = grubosc;
            poletekstu.TextDecorations = dodatki;
        }


        //zmiana kroju czcionki
        private void UstawKrojCzcionki()
        {
            if (Arial.IsChecked == true)
                poletekstu.FontFamily = new FontFamily("Arial");
            else if (Times.IsChecked == true)
                poletekstu.FontFamily = new FontFamily("Times New Roman");
            else if (Courier.IsChecked == true)
                poletekstu.FontFamily = new FontFamily("Courier New");
        }


        //zmiana wartości suwaka zmienia rozmiar czcionki
        private void RozmCzionki()
        {
            poletekstu.FontSize = suwak.Value;
        }


        //dzialanie panelu progresu
        private void Progres()
        {
            int progresik = 0; //początkowa wartość 0

            if (bold.IsChecked == true) progresik++; //zwiększa się o jeden
            if (italic.IsChecked == true) progresik++;
            if (Podkresl.IsChecked == true) progresik++;
            if (Czarnyczcionk.IsChecked == true || Czerwonyczcionk.IsChecked == true || Zielonyczcionk.IsChecked == true
                || Niebieskiczcionk.IsChecked == true) progresik++;
            if (BezowyTlo.IsChecked == true || CzerwonyTlo.IsChecked == true || ZielonyTlo.IsChecked == true || NiebieskiTlo.IsChecked == true) progresik++;
            if (Lewo.IsChecked == true || Srodek.IsChecked == true || Prawo.IsChecked == true || Just.IsChecked == true) progresik++;
            if (Arial.IsChecked == true || Times.IsChecked == true || Courier.IsChecked == true) progresik++;
            if (suwak.Value != suwak.Minimum) progresik++;
            panel.Value = progresik; //wartość panelu odpowiada progresik
        }
    }
}