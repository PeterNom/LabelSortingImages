
using LabelSortingImages;
using System.Globalization;

Console.WriteLine("Image Handler For TD/ 41SP TVs");

Console.WriteLine("Enter the path of the image folder.");

string path = "C:\\Users\\peter\\Pictures\\Saved Pictures\\photos October_new";


bool showMenu = true;
while (showMenu)
{
    showMenu = MainMenu();
}

bool MainMenu()
{
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
    String? capturedInput = null;

    do
    {
        capturedInput = Console.ReadLine();

    } while (capturedInput == null);

    return capturedInput;
}

void EnterByIndex()
{
    Console.WriteLine("Enter the path of the images.");
    try
    {
        path = CaptureInput();
        Path.GetFullPath(path);
    }
    catch(Exception ex)
    {
        Console.WriteLine("Something is wrong with the path you entered.\n");
        Console.WriteLine(ex.ToString());
        return;
    }

    AddImagesSorted addImages = new(path);
    Console.WriteLine("Enter index.");
    addImages.addImages(CaptureInput());
}

void RenameAll()
{
    Console.WriteLine("Enter the path of the images.");

    try
    {
        path = CaptureInput();
        Path.GetFullPath(path);
    }
    catch (Exception ex)
    {
        Console.WriteLine("Something is wrong with the path you entered.\n");
        Console.WriteLine(ex.ToString());
        return;
    }

    AddImagesSorted addImages = new(path);
    addImages.RenameSortedImages();
}
