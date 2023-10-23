
using LabelSortingImages;

Console.WriteLine("Image Handler For TD/ 41SP TVs");

Console.WriteLine("Enter the path of the image folder.");

string path = "C:\\Users\\peter\\Pictures\\Saved Pictures\\photos October_new";//Console.ReadLine();

AddImagesSorted addImages = new(path);

//addImages.renameSortedImages();
addImages.addImages("AAAC");

