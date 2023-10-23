
using LabelSortingImages;

Console.WriteLine("Image Handler For TD/ 41SP TVs");

Console.WriteLine("Enter the path of the image folder.");

string path = "C:\\Users\\peter\\Pictures\\Saved Pictures\\photos October_new";//Console.ReadLine();

AddImagesSorted addImages = new(path);

//addImages.renameSortedImages();


bool showMenu = true;
while (showMenu)
{
    showMenu = MainMenu();
}

bool MainMenu()
{
    Console.Clear();
    Console.WriteLine("Choose an option:");
    Console.WriteLine("1) Rename all images");
    Console.WriteLine("2) Add images at a specific index");
    Console.WriteLine("3) Exit");
    Console.Write("\r\nSelect an option: ");

    switch (Console.ReadLine())
    {
        case "1":
            RenameAll();
            return true;
        case "2":
            EnterByIndex();
            return true;
        case "3":
            return false;
        default:
            return true;
    }
}

string CaptureInput()
{
    return Console.ReadLine();
}

void EnterByIndex()
{
    Console.Clear();
    Console.WriteLine("Enter the path of the images.");
    path = CaptureInput();

    Console.Clear();
    Console.WriteLine("Enter index.");
    addImages.addImages(CaptureInput());
}

void RenameAll()
{
    Console.Clear();
    Console.WriteLine("Enter the path of the images.");
    path = CaptureInput();

    addImages.renameSortedImages();
}
