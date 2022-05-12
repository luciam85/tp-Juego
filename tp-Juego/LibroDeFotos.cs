using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tp_Juego
{
    using System;

    public class PhotoBookTest
    {
        public static void Main()
        {
            PhotoBook myPhotoBook1 = new PhotoBook();
            Console.WriteLine(myPhotoBook1.GetNumberPages());

            PhotoBook myPhotoBook2 = new PhotoBook(24);
            Console.WriteLine(myPhotoBook2.GetNumberPages());

            BigPhotoBook myBigPhotoBook = new BigPhotoBook();
            Console.WriteLine(myBigPhotoBook.GetNumberPages());
        }
    }

    public class PhotoBook
    {
        protected int numPages;

        public PhotoBook()
        {
            numPages = 16;
        }

        public PhotoBook(int numPages)
        {
            this.numPages = numPages;
        }

        public int GetNumberPages()
        {
            return numPages;
        }
    }

    public class BigPhotoBook : PhotoBook
    {
        public BigPhotoBook()
        {
            numPages = 64;
        }
    }
}
