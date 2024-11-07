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

namespace WpfApp3
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        // Pogrubienie
        private void AktualizujPogrubienie(object sender, RoutedEventArgs e)
        {
            TextSelection tekst = poleTekstowe.Selection;
            if (checkBoxPogrubienie.IsChecked == true)
                tekst.ApplyPropertyValue(TextElement.FontWeightProperty, FontWeights.Bold);
            else
                tekst.ApplyPropertyValue(TextElement.FontWeightProperty, FontWeights.Normal);
        }

        // Kursywa
        private void AktualizujKursywa(object sender, RoutedEventArgs e)
        {
            TextSelection tekst = poleTekstowe.Selection;
            if (checkBoxKursywa.IsChecked == true)
                tekst.ApplyPropertyValue(TextElement.FontStyleProperty, FontStyles.Italic);
            else
                tekst.ApplyPropertyValue(TextElement.FontStyleProperty, FontStyles.Normal);
        }

        // Podkreślenie
        private void AktualizujPodkreslenie(object sender, RoutedEventArgs e)
        {
            TextSelection tekst = poleTekstowe.Selection;
            if (checkBoxPodkreslenie.IsChecked == true)
                tekst.ApplyPropertyValue(Inline.TextDecorationsProperty, TextDecorations.Underline);
            else
                tekst.ApplyPropertyValue(Inline.TextDecorationsProperty, null);
        }

        // Zmiana rozmiaru czcionki
        private void AktualizujRozmiarCzcionki(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            TextSelection tekst = poleTekstowe.Selection;
            tekst.ApplyPropertyValue(TextElement.FontSizeProperty, suwakRozmiar.Value);
        }

        // Zmiana koloru czcionki - Czerwony
        private void AktualizujKolorCzcionkiCzerwony(object sender, RoutedEventArgs e)
        {
            TextSelection tekst = poleTekstowe.Selection;
            tekst.ApplyPropertyValue(TextElement.ForegroundProperty, Brushes.Red);
        }

        // Zmiana koloru czcionki - Zielony
        private void AktualizujKolorCzcionkiZielony(object sender, RoutedEventArgs e)
        {
            TextSelection tekst = poleTekstowe.Selection;
            tekst.ApplyPropertyValue(TextElement.ForegroundProperty, Brushes.Green);
        }

        // Zmiana koloru czcionki - Niebieski
        private void AktualizujKolorCzcionkiNiebieski(object sender, RoutedEventArgs e)
        {
            TextSelection tekst = poleTekstowe.Selection;
            tekst.ApplyPropertyValue(TextElement.ForegroundProperty, Brushes.Blue);
        }

        // Zmiana kroju czcionki - Arial
        private void AktualizujKrojCzcionkiArial(object sender, RoutedEventArgs e)
        {
            TextSelection tekst = poleTekstowe.Selection;
            tekst.ApplyPropertyValue(TextElement.FontFamilyProperty, new FontFamily("Arial"));
        }

        // Zmiana kroju czcionki - Times New Roman
        private void AktualizujKrojCzcionkiTimes(object sender, RoutedEventArgs e)
        {
            TextSelection tekst = poleTekstowe.Selection;
            tekst.ApplyPropertyValue(TextElement.FontFamilyProperty, new FontFamily("Times New Roman"));
        }

        // Zmiana kroju czcionki - Calibri
        private void AktualizujKrojCzcionkiCalibri(object sender, RoutedEventArgs e)
        {
            TextSelection tekst = poleTekstowe.Selection;
            tekst.ApplyPropertyValue(TextElement.FontFamilyProperty, new FontFamily("Calibri"));
        }

        // Wyrównanie tekstu do lewej
        private void WyrównajTekstLewo(object sender, RoutedEventArgs e)
        {
            poleTekstowe.Selection.ApplyPropertyValue(Paragraph.TextAlignmentProperty, TextAlignment.Left);
        }

        // Wyrównanie tekstu do środka
        private void WyrównajTekstSrodek(object sender, RoutedEventArgs e)
        {
            poleTekstowe.Selection.ApplyPropertyValue(Paragraph.TextAlignmentProperty, TextAlignment.Center);
        }

        // Wyrównanie tekstu do prawej
        private void WyrównajTekstPrawo(object sender, RoutedEventArgs e)
        {
            poleTekstowe.Selection.ApplyPropertyValue(Paragraph.TextAlignmentProperty, TextAlignment.Right);
        }

        // Justowanie tekstu
        private void WyrównajTekstJustowanie(object sender, RoutedEventArgs e)
        {
            poleTekstowe.Selection.ApplyPropertyValue(Paragraph.TextAlignmentProperty, TextAlignment.Justify);
        }
    }
}