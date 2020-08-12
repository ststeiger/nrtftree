
namespace System.Drawing.Imaging
{
    public class ImageFormat
    {
        protected System.Guid m_guid;

        public ImageFormat(System.Guid uid)
        {
            this.m_guid = uid;
        }


        private static ImageFormat memoryBMP = new ImageFormat(new Guid("{b96b3caa-0728-11d3-9d7b-0000f81ef32e}"));
        private static ImageFormat bmp = new ImageFormat(new Guid("{b96b3cab-0728-11d3-9d7b-0000f81ef32e}"));
        private static ImageFormat emf = new ImageFormat(new Guid("{b96b3cac-0728-11d3-9d7b-0000f81ef32e}"));
        private static ImageFormat wmf = new ImageFormat(new Guid("{b96b3cad-0728-11d3-9d7b-0000f81ef32e}"));
        private static ImageFormat jpeg = new ImageFormat(new Guid("{b96b3cae-0728-11d3-9d7b-0000f81ef32e}"));
        private static ImageFormat png = new ImageFormat(new Guid("{b96b3caf-0728-11d3-9d7b-0000f81ef32e}"));
        private static ImageFormat gif = new ImageFormat(new Guid("{b96b3cb0-0728-11d3-9d7b-0000f81ef32e}"));
        private static ImageFormat tiff = new ImageFormat(new Guid("{b96b3cb1-0728-11d3-9d7b-0000f81ef32e}"));
        private static ImageFormat exif = new ImageFormat(new Guid("{b96b3cb2-0728-11d3-9d7b-0000f81ef32e}"));
        private static ImageFormat photoCD = new ImageFormat(new Guid("{b96b3cb3-0728-11d3-9d7b-0000f81ef32e}"));
        private static ImageFormat flashPIX = new ImageFormat(new Guid("{b96b3cb4-0728-11d3-9d7b-0000f81ef32e}"));
        private static ImageFormat icon = new ImageFormat(new Guid("{b96b3cb5-0728-11d3-9d7b-0000f81ef32e}"));

        public Guid Guid
        {
            get { return this.m_guid; }
        }

        public static ImageFormat MemoryBmp
        {
            get { return memoryBMP; }
        }

        public static ImageFormat Bmp
        {
            get { return bmp; }
        }

        public static ImageFormat Emf
        {
            get { return emf; }
        }

        public static ImageFormat Wmf
        {
            get { return wmf; }
        }
        public static ImageFormat Gif
        {
            get { return gif; }
        }

        public static ImageFormat Jpeg
        {
            get { return jpeg; }
        }
        public static ImageFormat Png
        {
            get { return png; }
        }

        public static ImageFormat Tiff
        {
            get { return tiff; }
        }
        public static ImageFormat Exif
        {
            get { return exif; }
        }

        public static ImageFormat Icon
        {
            get { return icon; }
        }
    }
}




namespace System.Drawing
{

    public class Image
    {
        public int Width
        {
            get
            {
                return 0;
            }
        }

        public int Height
        {
            get
            {
                return 0;
            }
        }


        public static Image FromFile(string path)
        {
            return null;
        }


        public void Save(string path, Imaging.ImageFormat format)
        { 
            
        }

    }


    public class Bitmap
        : Image
    {

        public Bitmap()
        { }

        public Bitmap(System.IO.Stream strm)
        { }

    }
}
