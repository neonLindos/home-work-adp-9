

using home_work_adp_9.task1;
using home_work_adp_9.task1.device;
using home_work_adp_9.task2;

void TestTask1()
{
    var tv = new TV();
    var audio = new AudioSystem();
    var dvd = new DVDPlayer();
    var console = new GameConsole();

    var homeTheater = new HomeTheaterFacade(tv, audio, dvd, console);

    homeTheater.WatchMovie();
    homeTheater.SetVolume(70);
    homeTheater.EndMovie();

    homeTheater.PlayGame("Cyberpunk 2077");
    homeTheater.StopGame();

    homeTheater.ListenToMusic();
    homeTheater.PowerOffAll();
}

void TestTask2()
{
    // Создаём файлы
    var file1 = new FFile("readme.txt", 10);
    var file2 = new FFile("report.pdf", 120);
    var file3 = new FFile("photo.png", 250);
    var file4 = new FFile("music.mp3", 5000);

    // Создаём директории
    var root = new DDirectory("Root");
    var docs = new DDirectory("Documents");
    var images = new DDirectory("Images");
    var music = new DDirectory("Music");

    // Строим иерархию
    docs.Add(file1);
    docs.Add(file2);
    images.Add(file3);
    music.Add(file4);

    root.Add(docs);
    root.Add(images);
    root.Add(music);

    // Вывод содержимого
    Console.WriteLine("📁 Структура файловой системы:\n");
    root.Display();

    // Подсчёт размера
    Console.WriteLine($"\nОбщий размер папки Root: {root.GetSize()} KB");
}


TestTask1();
TestTask2();