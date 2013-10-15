using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace ExemploWinRT_DateETimePickers
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            // Forçando o idioma da interface para "Português / Brasil".
            Windows.Globalization.ApplicationLanguages.PrimaryLanguageOverride = "pt-BR";

            this.InitializeComponent();
        }
        /// <summary>
        /// Handler para o evento DateChanged do controle CompromissoDatePicker. Neste exemplo estamos somente exibindo um MessageDialog com a nova data escolhida.
        /// </summary>
        /// <param name="sender">O controle que disparou este evento.</param>
        /// <param name="e">Informações sobre o evento DateChanged.</param>
        private async void CompromissoDatePicker_DateChanged(object sender, DatePickerValueChangedEventArgs e)
        {
            await new Windows.UI.Popups.MessageDialog(string.Format("Data anterior: {0}\nNova data: {1}", e.OldDate, e.NewDate), "A data foi alterada").ShowAsync();
        }
        /// <summary>
        /// Handler para o evento TimeChanged do controle CompromissoTimePicker. Neste exemplo estamos somente exibindo um MessageDialog com o novo horário escolhido.
        /// </summary>
        /// <param name="sender">O controle que disparou este evento.</param>
        /// <param name="e">Informações sobre o evento TimeChanged.</param>
        private async void CompromissoTimePicker_TimeChanged(object sender, TimePickerValueChangedEventArgs e)
        {
            await new Windows.UI.Popups.MessageDialog(string.Format("Horário anterior: {0}\nNovo horário: {1}", e.OldTime, e.NewTime), "O horário foi alterado").ShowAsync();
        }
    }
}
