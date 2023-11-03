using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace LabelSortingImages
{
    internal class AddImagesSorted
    {
        private List<string>? images = new List<string>();
        private string folderPath;
        Char[] _col = new char[4];
        private int counter = 0;

        public AddImagesSorted(string? FolderPath)
        {
            if (FolderPath == null)
                throw new ArgumentNullException(nameof(FolderPath));
            this.folderPath = FolderPath;
            Console.WriteLine(this.folderPath);
            _col[0] = 'A';
            _col[1] = 'A';
            _col[2] = 'A';
            _col[3] = 'A';
            
        }

        public void RenameSortedImages()
        {
            int columIndex = 3;
            foreach (string imageName in Directory.EnumerateFiles(folderPath, "*.jpg"))
            {
                if((++counter)%25==0)
                {
                    columIndex -= 1;
                    counter = 0;
                }

                _col[columIndex] = (Char)(Convert.ToUInt16(_col[columIndex]+1));

                String dest = this.folderPath + "\\" + new string(_col) + ".jpg";

                File.Move(imageName, dest);
            }
        }

        public void addImages(string index)  
        {
            int columIndex = 3;
            foreach (string imageName in Directory.EnumerateFiles(folderPath, "*.jpg"))
            {
                if ((++counter) % 25 == 0)
                {
                    columIndex -= 1;
                    counter = 0;
                }

                _col[columIndex] = (Char)(Convert.ToUInt16(_col[columIndex] + 1));
                string columId = new string(_col);

                if(columId==index)
                {
                    foreach (string newImages in Directory.EnumerateFiles(folderPath+ "\\toAdd", "*.jpg"))
                    {
                        if ((++counter) % 25 == 0)
                        {
                            columIndex -= 1;
                            counter = 0;
                        }
                        _col[columIndex] = (Char)(Convert.ToUInt16(_col[columIndex] + 1));
                         columId = new string(_col);

                        String dest2 = this.folderPath + "\\temp\\" + columId + ".jpg";

                        File.Move(newImages, dest2);
                    }

                    if ((++counter) % 25 == 0)
                    {
                        columIndex -= 1;
                        counter = 0;
                    }
                    _col[columIndex] = (Char)(Convert.ToUInt16(_col[columIndex] + 1));
                    columId = new string(_col);

                    String dest1 = this.folderPath + "\\temp\\" + columId + ".jpg";

                    File.Move(imageName, dest1);

                    continue;
                }

                String dest = this.folderPath + "\\temp\\" + columId + ".jpg";

                File.Move(imageName, dest);
            }
        }
    }
}
