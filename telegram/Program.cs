using System.Runtime.CompilerServices;
using System.Xml.Xsl;
using telegram;
using Telegram.Bot;
using Telegram.Bot.Args;
using Telegram.Bot.Types;

///////////////////////////////////////////////یاسین منعم///////////تمرین ربات تلگرام///////////////////////////////////////////////////////////////////////////////////////

////////////////////////////initialize thr telegrambotclient with API token///////////////////////////////////////////////////

TelegramBotClient botClient = new TelegramBotClient("6880357606:AAGpARYTbfBxs41limbVXINriSSQPgRw6qg");

handle handle = new handle


botClient.OnMessage += Bot_OnMessage;

botClient.StartReceiving();

























