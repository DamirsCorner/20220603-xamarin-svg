using System.Collections.Generic;
using System.ComponentModel;
using System.Net.Http;
using System.Runtime.CompilerServices;
using System.Text.Json;
using XamarinFormsSvg.Models;

namespace XamarinFormsSvg.ViewModels
{
    public class MainViewModel : INotifyPropertyChanged
    {
        private readonly string API_KEY = "change_me"; // TODO: get one here: https://p.nomics.com/pricing#

        private IReadOnlyList<Currency> currencies;

        public event PropertyChangedEventHandler PropertyChanged;

        public IReadOnlyList<Currency> Currencies
        {
            get => currencies;
            private set
            {
                currencies = value;
                this.OnPropertyChanged();
            }
        }

        public MainViewModel()
        {
            this.LoadCurrencies();
        }

        private async void LoadCurrencies()
        {
            var httpClient = new HttpClient();
            var json = await httpClient.GetStringAsync($"https://api.nomics.com/v1/currencies/ticker?key={API_KEY}");
            this.Currencies = JsonSerializer.Deserialize<List<Currency>>(json);
        }

        private void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
