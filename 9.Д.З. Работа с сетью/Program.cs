using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Net.Http;
using System.Threading.Tasks;
using Telegram.Bot;
using Telegram.Bot.Types;
using Telegram.Bot.Exceptions;
using Telegram.Bot.Types.InputFiles;
using System.Reflection;

namespace Example_941
{
    class Program
    {
        private static TelegramBotClient client;
        static void Main(string[] args)
        {

            //// Создать бота, позволяющего принимать разные типы файлов, 
            //// *Научить бота отправлять выбранный файл в ответ
            //// 
            //// https://data.mos.ru/
            //// https://apidata.mos.ru/
            //// 
            //// https://vk.com/dev
            //// https://vk.com/dev/manuals

            //// https://dev.twitch.tv/
            //// https://discordapp.com/developers/docs/intro
            //// https://discordapp.com/developers/applications/
            //// https://discordapp.com/verification
            #region Решение моё через парсинг json
            //int n = 0;
            //int au = 0;
            //int doc = 0;
            //string token = File.ReadAllText(@"C:\Users\Dartem\Documents\С#\Видео по С#\Исходники\Исходники модуль 9\token.txt");    //  токен для бота

            //WebClient wc = new WebClient() { Encoding = Encoding.UTF8 };    //  создаём вэбклиент для обмена с интернет-ресурсом

            //int update_id = 0;  //  создаём индентификатор первого обновления, которое должно быть возвращено  Обновление считается подтвержденным, как только вызывается get Updates со смещением, превышающим его update_id.
            //// каждый раз, когда происходит вывод в консоль update_id увеличивается
            //string startUrl = $@"https://api.telegram.org/bot{token}/"; //  что бы делать запросы создадим переменную в которую положим адрес с нашим токеном, ещё в запросе нужен api-метод, но его мы используем ниже

            //while (true)    //  бесконечный цикл в нём с некоторой задержкой выдаём что происодит у бота
            //{
            //    string urlUpload = @"C:\Users\Dartem\Documents\С#\Видео по С#\Исходники\Исходники модуль 9\Theme_09\Example_931\Example_941\bin\Debug\file0.jpg";
            //    //string urlD = $"{startUrl}sendPhoto?photo={urlUpload}";
            //    //byte[] responseArray = wc.UploadFile(urlD, urlUpload);


            //    string url = $"{startUrl}getUpdates?offset={update_id}";    //  создадим строку в которую запишем полный url для взаимодествия с ботом,
            //                                                                //  передав туда функцию getUpdates - "Используйте этот метод для получения входящих обновлений с помощью длительного опроса.
            //                                                                //  Возвращает массив объекта обновления". С параметром идентификатора первого обновления, которое должно быть возвращено. Непонятно пока                
            //                                                                //string url = $"{startUrl}getUpdates";
            //    var r = wc.DownloadString(url); //  выполняем запросы по url, а ответы сохраняем как строку (в ответе передаётся json)
            //    //Console.WriteLine("Что тут");
            //    //Console.WriteLine($"А тут вот что - {r}");

            //    var msgs = JObject.Parse(r)["result"].ToArray();    //  преобразовать из json-строки r, значение ключа "result" в массив 

            //    //Console.WriteLine(r);
            //    foreach (dynamic msg in msgs)   //  цикл по массиву сообщений
            //    {
            //        update_id = Convert.ToInt32(msg.update_id) + 1; //  увеличиваем update_id что бы пометить все сообщения,

            //        if (msg.message.voice != null)
            //        {
            //            string audioId = msg.message.voice.file_id;
            //            Console.WriteLine(audioId);
            //            url = $"{startUrl}getFile?file_id={audioId}";
            //            var a = wc.DownloadString(url);
            //            JToken pathFileAudio = JObject.Parse(a)["result"];

            //            string pathAudio = pathFileAudio.Value<string>("file_path");
            //            Console.WriteLine(pathAudio);
            //            string urlAu = $@"https://api.telegram.org/file/bot{token}/{pathAudio}";   // создаём url откуда будем скачивать файлы
            //            //https://api.telegram.org/file/bot<token>/<file_path>                       

            //            string file = $"audio{au}.oga";   //  создаём файл в котором сохраняем фото

            //            wc.DownloadFile(urlAu, file);
            //            au++;
            //        }
            //        if (msg.message.document != null)
            //        {
            //            //!!!!!!!!!!! Забираем file_name и передаём в stringTxt
            //            string fileTxt;
            //            string docId = msg.message.document.file_id;
            //            Console.WriteLine(docId);
            //            url = $"{startUrl}getFile?file_id={docId}";
            //            var d = wc.DownloadString(url);
            //            JToken pathFileAudio = JObject.Parse(d)["result"];

            //            string pathAudio = pathFileAudio.Value<string>("file_path");
            //            Console.WriteLine(pathAudio);
            //            string urlAu = $@"https://api.telegram.org/file/bot{token}/{pathAudio}";   // создаём url откуда будем скачивать файлы
            //            //https://api.telegram.org/file/bot<token>/<file_path>                       
            //            if (msg.message.document.mime_type == "text/plain")
            //            {

            //                fileTxt = $"audio{doc}.txt";   //  создаём файл в котором сохраняем фото
            //                wc.DownloadFile(urlAu, fileTxt);
            //            }
            //            // string file = $"audio{doc}.txt";   //  создаём файл в котором сохраняем фото

            //            //!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!! Главный образец

            //            else if (msg.message.document.mime_type == "application/pdf")
            //            {
            //                string filePdf = msg.message.document.file_name;    //  сохраняем имя файла в переменную 
            //                Console.WriteLine($"пдфочка {filePdf}");
            //                string pdfId = msg.message.document.file_id;    //  сохраняем айди pdf-ки
            //                url = $"{startUrl}getFile?file_id={pdfId}";
            //                var pdf = wc.DownloadString(url);
            //                JToken pathFilepdf = JObject.Parse(pdf)["result"];
            //                string pathPdf = pathFilepdf.Value<string>("file_path");
            //                string urlForDownloadFile = $@"https://api.telegram.org/file/bot{token}/{pathPdf}";
            //                wc.DownloadFile(urlAu, filePdf);
            //            }


            //        }

            //        if (msg.message.photo != null)
            //        { //  !!если несколько файлов, как быть мб стр 74, подумать!! проверь мб всё норм
            //            var photo = msg.message.photo;  //  тут id файла лежит
            //                                            //foreach (dynamic ph in photo)
            //                                            //{
            //            Console.WriteLine($"длина массива фото {photo.Count}, содержимое последнего {photo[photo.Count - 1]}");
            //            string phph = photo[photo.Count - 1].file_id;   // получаем id файла

            //            Console.WriteLine($"фото самого большого размера {phph}");
            //            //Console.WriteLine(phph);
            //            url = $"{startUrl}getFile?file_id={phph}"; //   получаем урл, с конкретным файл ид, содержащим путь к фото

            //            var p = wc.DownloadString(url); //  тут json с путём этого файла

            //            JToken pathFile = JObject.Parse(p)["result"];   // достаём то, что внутри result в jтокен

            //            string pt = pathFile.Value<string>("file_path");    //  достаём путь к файлу
            //            Console.WriteLine(pt);
            //            string urlPh = $@"https://api.telegram.org/file/bot{token}/{pt}";   // создаём url откуда будем скачивать файлы
            //            //https://api.telegram.org/file/bot<token>/<file_path>                       

            //            string file = $"file{n}.jpg";   //  создаём файл в котором сохраняем фото

            //            wc.DownloadFile(urlPh, file); //  загружаем его на комп

            //            n++;    //  увеличиваем номер файла
            //                    //}
            //                    // создаём документ в который сохраняем названия файлов, при новом проходе загружаем инфу из файла,
            //                    // узнаём название последнего и кладём его в string file. Продолжаем сохранять. Посмотреть, как это реализовано в ДЗ на структуры
            //                    // аудио и видео пробуем достать через get_file

            //            // создать список файлов на этапе формирования массивов с данными (аудио, видео, фото)
            //            // - "Позволяет пользователю просмотреть список загруженных файлов". Можно из json'на по result, потом условия на разные типы см. строку 58

            //        }
            //        string userMessage = msg.message.text;  //  сохраняем в переменную userMessage значение ключа message.text
            //                                                //  - это текст сообщения пользователя

            //        string userId = msg.message.from.id;    //  сохраняем в переменную userId значение ключа message.from.id
            //        string useFirstrName = msg.message.from.first_name; //  сохраняем в переменную useFirstrName значение ключа message.from.first_name

            //        string text = $"{useFirstrName} {userId} {userMessage}";    //  сохраняем всё в переменную и выводим в консоль информацию о сообщении

            //        Console.WriteLine(text);

            //        if (userMessage == "hi")    //  если пользовательское сообщение равно hi
            //        {
            //            Console.WriteLine(userId);
            //            string responseText = $"Здравствуйте, {useFirstrName}"; //  сохраняем приветствие пользователя
            //                                                                    // url = $"{startUrl}sendMessage?chat_id={userId}&text={responseText}";    //  в url передаём новый запрос с функцией ответа
            //                                                                    //  от бота сообщением, хранящмся в responseText
            //            //urlUpload = @"C:\Users\Dartem\Documents\С#\Видео по С#\Исходники\Исходники модуль 9\Theme_09\Example_931\Example_941\bin\Debug\file1.jpg";
            //            //url = $"{startUrl}sendPhoto?chat_id={userId}&photo={urlUpload}";
            //            //Console.WriteLine("+"); // выводим +, всё ок
            //            //                        //wc.DownloadString(url); // передаём запрос через вэб-клиент                       
            //            //wc.DownloadString(url);
            //        }

            //        if (userMessage == "Как дела?")    //  если пользовательское сообщение равно hi
            //        {
            //            string responseText = $"Отлично! Спасибо, {useFirstrName}."; //  сохраняем приветствие пользователя
            //            url = $"{startUrl}sendMessage?chat_id={userId}&text={responseText}";    //  в url передаём новый запрос с функцией ответа
            //                                                                                    //  от бота сообщением, хранящмся в responseText
            //            Console.WriteLine("+"); // выводим +, всё ок
            //            wc.DownloadString(url); // передаём запрос через вэб-клиент
            //        }

            //        //if (fileIn != null) { 
            //        //    url = $"{startUrl}InputMediaPhoto?media={fileIn}";
            //        //    string path = @"C:\Users\Dartem\Documents\С#\Видео по С#\Исходники\Исходники модуль 9\1.png";
            //        //    //FileStream fs = new FileStream("_" + path, FileMode.Create);
            //        //    wc.DownloadFile(url, path);
            //        //}

            //        SendPhoto(userId, urlUpload, token).Wait();
            //    }


            //    Thread.Sleep(500);  //  задержка 


            //}
            #endregion
            #region решение из чата

            string token = System.IO.File.ReadAllText(@"C:\Users\Dartem\Documents\С#\Видео по С#\Исходники\Исходники модуль 9\token1.txt"); // считываем токен из файла и передаём в строковую переменную
            Telegram.Bot.TelegramBotClient client = new TelegramBotClient(token);   // создаём телеграм клиент, передав в него токен 
        
            client.StartReceiving(Update, Error);   // запускаем приём сообщений           

            Console.ReadLine(); // ожидание пользовательского ввода
    
        }
       
        private static async Task Update(ITelegramBotClient botClient, Telegram.Bot.Types.Update update, CancellationToken token)   // создание задачи на работу с сообщениями
        {           

            Telegram.Bot.Types.Message message = update.Message;    //  переменная для хранения части функционала для работы с сообщениями
            
 
            if (message.Text != null)   // если при обновлении в сообщении содержится текст
            {
                Console.WriteLine($"{message.Chat.FirstName}    |    {message.Text}");  // выведи в консоль имя пользователя и сам текст
                if (message.Text.ToLower() == "/start") // если текст сообщения содержит /start, вне зависимости от регистра
                {
                    await botClient.SendTextMessageAsync(message.Chat.Id, $"Добро пожаловать в чат," +
                        $" {message.Chat.FirstName}"); // отправь в соответствующий чат сообщение 
                    return;
                }
                else if (message.Text.ToLower() == "привет")    // если текст сообщения содержит "привет"
                {
                    await botClient.SendTextMessageAsync(message.Chat.Id, $"Привет," +
                        $" {message.Chat.FirstName}"); // отправь в соответствующий чат сообщение с приветствием пользователя
                    return;
                }
                else if (message.Text.ToLower() == "список файлов") // если текст сообщения содержит "список файлов" 
                {
                    DirectoryInfo di = new DirectoryInfo(@"C:\Users\Dartem\Documents\С#\Видео по С#\Исходники\Исходники модуль 9\Theme_09\Example_931\Example_941\bin\Debug\downloads");    // запишем путь в экземпляр класса DirectoryInfo

                    foreach (var fi in di.GetFiles()) // через метод GetFiles получим все файлы сохранённые на диске в нашей директории di
                    {                      
                        Stream stream = System.IO.File.OpenRead($@"C:\Users\Dartem\Documents\С#\Видео по С#\Исходники\Исходники модуль 9\Theme_09\Example_931\Example_941\bin\Debug\downloads\{fi.Name}");  // создаём поток и читаем каждый файл в директории
                        await botClient.SendDocumentAsync(message.Chat.Id, new InputOnlineFile(stream, fi.Name));   // отправляем файлы в чат
                    }

                    return;
                }
            }

            if (message.Photo != null)  // если сообщение содержит картинку
            {
                Console.WriteLine("Получил фото");  // в консоль выведи сообщение о получении фото
                string fileId = update.Message.Photo.Last().FileId; // сохраняем Id файла картинки самого большого разрешения
                string fileUniqueId = update.Message.Photo.Last().FileUniqueId; // сохраняем уникальный Id файла
                Telegram.Bot.Types.File fileInfo = await botClient.GetFileAsync(fileId);    // забираем файл по Id файла
                string filePath = fileInfo.FilePath; // сохраняем путь к файлу на сервере телеграма

                string destinationFilePath = $@"C:\Users\Dartem\Documents\С#\Видео по С#\Исходники\Исходники модуль 9\Theme_09\Example_931\Example_941\bin\Debug\downloads\{fileUniqueId}.png";    // сохраним путь куда будем качать файл
                
                FileStream fileStream = new FileStream(destinationFilePath, FileMode.Create);   // создаём поток для файла с путём сохранения

                await botClient.DownloadFileAsync(  // загружаем файл на диск (по пути из потока) используя путь к файлу на сервере телеграма. Скачиваем файл с сервера телеграма на локальный компьютер. 
                    filePath: filePath,
                    destination: fileStream);

                fileStream.Close(); // закрываем поток

                await botClient.SendTextMessageAsync(message.Chat.Id, "Сохранил файл типа фото");   // отправляем в чат боту сообщение о сохранении файла

                return;
            }
            else if (message.Voice != null) // если сообщение содержит голосовое 
            {
                Console.WriteLine("Получил голосовое");   // в консоль выведи сообщение о получении голосового
                string fileId = update.Message.Voice.FileId;    // сохраняем Id файла голосового
                string fileUniqueId = update.Message.Voice.FileUniqueId;    // сохраняем уникальный Id файла
                Telegram.Bot.Types.File fileInfo = await botClient.GetFileAsync(fileId); // забираем файл по Id файла
                string filePath = fileInfo.FilePath;    // сохраняем путь к файлу на сервере телеграма

                string destinationFilePath = $@"C:\Users\Dartem\Documents\С#\Видео по С#\Исходники\Исходники модуль 9\Theme_09\Example_931\Example_941\bin\Debug\downloads\{fileUniqueId}.mp3";  // сохраним путь куда будем качать файл

                FileStream fileStream = new FileStream(destinationFilePath, FileMode.Create);   // создаём поток для файла с путём сохранения

                await botClient.DownloadFileAsync(  // загружаем файл на диск (по пути из потока) используя путь к файлу на сервере телеграма. Скачиваем файл с сервера телеграма на локальный компьютер. 
                    filePath: filePath,
                    destination: fileStream);
                fileStream.Close(); // закрываем поток
                await botClient.SendTextMessageAsync(message.Chat.Id, "Сохранил файл типа голосовое");  // отправляем в чат боту сообщение о сохранении файла
                return;
            }
            else if (message.Audio != null) // если сообщение содержит голосовое 
            {
                Console.WriteLine("Получил аудио"); // в консоль выведи сообщение о получении аудио
                string fileId = update.Message.Audio.FileId;     // сохраняем Id файла аудио
                Telegram.Bot.Types.File fileInfo = await botClient.GetFileAsync(fileId);    // забираем файл по Id файла
                string filePath = fileInfo.FilePath;    // сохраняем путь к файлу на сервере телеграма
                string fileName = update.Message.Audio.FileName;    // сохраняем имя файла

                string destinationFilePath = $@"C:\Users\Dartem\Documents\С#\Видео по С#\Исходники\Исходники модуль 9\Theme_09\Example_931\Example_941\bin\Debug\downloads\{fileName}";  // сохраним путь куда будем качать файл

                FileStream fileStream = new FileStream(destinationFilePath, FileMode.Create);   // создаём поток для файла с путём сохранения


                await botClient.DownloadFileAsync(  // загружаем файл на диск (по пути из потока) используя путь к файлу на сервере телеграма. Скачиваем файл с сервера телеграма на локальный компьютер. 
                    filePath: filePath,
                    destination: fileStream);
                fileStream.Close(); // закрываем поток
                await botClient.SendTextMessageAsync(message.Chat.Id, "Сохранил файл типа аудио");  // отправляем в чат боту сообщение о сохранении файла
                return;
            }
            else if (message.Video != null) // если сообщение содержит видео
            {
                Console.WriteLine("Получил видео");  // в консоль выведи сообщение о получении видео

                string fileId = update.Message.Video.FileId;    //  сохраняем Id файла аудио
                Telegram.Bot.Types.File fileInfo = await botClient.GetFileAsync(fileId);    // забираем файл по Id файла
                string filePath = fileInfo.FilePath;    // сохраняем путь к файлу на сервере телеграма
                string fileUniqueId = update.Message.Video.FileUniqueId;    // сохраняем уникальный Id файла

                string destinationFilePath = $@"C:\Users\Dartem\Documents\С#\Видео по С#\Исходники\Исходники модуль 9\Theme_09\Example_931\Example_941\bin\Debug\downloads\{fileUniqueId}.mp4";  // сохраним путь куда будем качать файл

                FileStream fileStream = new FileStream(destinationFilePath, FileMode.Create);   // создаём поток для файла с путём сохранения

                await botClient.DownloadFileAsync(  // загружаем файл на диск (по пути из потока) используя путь к файлу на сервере телеграма. Скачиваем файл с сервера телеграма на локальный компьютер. 
                    filePath: filePath,
                    destination: fileStream);
                fileStream.Close(); // закрываем поток

                await botClient.SendTextMessageAsync(message.Chat.Id, "Сохранил файл типа видео");  // отправляем в чат боту сообщение о сохранении файла
                return;
            }
            else if (message.Document != null)  // если сообщение содержит документ
            {   
                Console.WriteLine("Получил документ");  // в консоль выведи сообщение о получении документа
                string fileId = update.Message.Document.FileId; //  сохраняем Id файла документ
                Telegram.Bot.Types.File fileInfo = await botClient.GetFileAsync(fileId);    // забираем файл по Id файла
                string filePath = fileInfo.FilePath;    // сохраняем путь к файлу на сервере телеграма
                string fileName = update.Message.Document.FileName; // сохраняем имя файла

                string destinationFilePath = $@"C:\Users\Dartem\Documents\С#\Видео по С#\Исходники\Исходники модуль 9\Theme_09\Example_931\Example_941\bin\Debug\downloads\{fileName}";   // сохраним путь куда будем качать файл

                FileStream fileStream = new FileStream(destinationFilePath, FileMode.Create);   // создаём поток для файла с путём сохранения

                await botClient.DownloadFileAsync(  // загружаем файл на диск (по пути из потока) используя путь к файлу на сервере телеграма. Скачиваем файл с сервера телеграма на локальный компьютер. 
                    filePath: filePath,
                    destination: fileStream);
                fileStream.Close(); // закрываем поток

                await botClient.SendTextMessageAsync(message.Chat.Id, "Сохранил файл типа документ");   // отправляем в чат боту сообщение о сохранении файла                
               
                return;
            }            
        }

        private static Task Error(ITelegramBotClient arg1, Exception arg2, CancellationToken arg3)
        {
            throw new NotImplementedException();
        }
        #endregion

    }      
    }
