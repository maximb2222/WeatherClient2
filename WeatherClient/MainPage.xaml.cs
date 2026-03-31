using WeatherClient.Models;
using WeatherClient.Services;

namespace WeatherClient;

public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();
    }

    private async void OnRefreshClicked(object sender, EventArgs e)
    {
        btnRefresh.IsEnabled = false;
        actIsBusy.IsRunning = true;

        WeatherData weatherData = await WeatherService.GetWeather(txtPostalCode.Text);
        BindingContext = weatherData;

        btnRefresh.IsEnabled = true;
        actIsBusy.IsRunning = false;
    }
}
