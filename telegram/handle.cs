using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using Telegram.Bot;
using Telegram.Bot.Args;
using Telegram.Bot.Types;
using Telegram.Bot.Types.Enums;
/////////////////////////////////////////////class for handeling different information////////////////////////////
namespace telegram
{
    public class handle
    {
        private static  async void Bot_OnMessage(object sender,MessageEventArgs e)
        {
            if (e.Message.Text != null)
            {
                //////////////handle incoming message//
                string messageText = e.Message.Text;
                long chatId = e.Message.Chat.Id;
                //////////////////////weather data///////

                if (messageText.StartsWith("/weather"))
                {
                    string location = messageText.Substring(9);
                    HttpClient client = new HttpClient();
                    string apiUr1 = $"https://api.codebazan.ir/weather/?city=%D8%AA%D9%87%D8%B1%D8%A7%D9%86";
                    HttpResponseMessage response = await client.GetAsync(apiUr1);
                    if (response.IsSuccessStatusCode)
                    {
                        string responseContent = await response.Content.ReadAsStringAsync();
                        WeatherData weatherData = parseweatherData(responseContent);
                        return weatherData;
                    }
                    else { return null; }
                }
                //////////////////////////////////////////////bitcoin //////
                if (messageText.StartsWith("/bitcoin"))
                {
                    HttpClient client = new HttpClient();
                    string apiUr2 = $"https://api.kucoin.com/api/v1/market/stats?symbol=BTC-USDT";
                    HttpResponseMessage responce = await client.GetAsync(apiUr2);
                    if (responce.IsSuccessStatusCode)
                    {
                        string reponceContent = await responce.Content.ReadAsStringAsync();
                        CoinData coinData = parseCoinData(reponceContent);
                        return ;
                    }
                    else { null};
                }

            }
        }
    }
}
public class WeatherData
{
    public double Temp_max { get; set; }
    public double Temp_min { get; set; }
}
public class CoinData
{
    public double buy { get; set; }
    public double sell { get; set; }
}


