
using libNetRtfTree.Core;
using libNetRtfTree.Util;


namespace TestRtf
{

    // https://stackoverflow.com/questions/43019832/auto-versioning-in-visual-studio-2017-net-core
    // https://github.com/BalassaMarton/MSBump
    // https://www.codeproject.com/Articles/11306/NRTFTree-A-class-library-for-RTF-processing-in-C
    // https://www.codeproject.com/Articles/98062/RTF-Document-Constructor-Library
    // https://github.com/sgolivernet/jrtftree
    class Program
    {

        public static void Create()
        {
            RtfDocument doc = new RtfDocument(System.Text.Encoding.UTF8);



            RtfCharFormat format = new RtfCharFormat();
            format.Size = 20;
            format.Bold = true;
            format.Underline = true;

            format.Color = System.Drawing.Color.Red;


            doc.AddText("Title", format);
            doc.AddNewLine();
            doc.AddNewLine();

            format.Size = 12;
            format.Bold = false;
            format.Underline = false;

            doc.AddText("This is a test.", format);
            doc.AddText("This is a text.");

            doc.AddNewLine();

            // doc.AddImage("test.png", 50, 50);

            doc.Save(@"D:\rtfdoc.rtf");
        }
        public static void Append()
        {
            RtfDocument doc = new RtfDocument(@"D:\rtfdoc.rtf", System.Text.Encoding.UTF8);


            RtfCharFormat format = new RtfCharFormat();
            format.Size = 12;
            format.Bold = false;
            format.Underline = false;
            format.Color = System.Drawing.Color.Blue;

            doc.AddText("This is a test.", format);
            doc.AddText("This is a {bad} text.");


            doc.Save(@"D:\rtfdoc1.rtf");
        }


        public static void LoadTree()
        {
            RtfTree tree = new RtfTree();

            //Load and parse RTF document
            tree.LoadRtfFile(@"D:\rtfdoc.rtf");

            tree.SaveRtf("path");
        }

        public static void Main(string[] args)
        {
            //Create();
            Append();
            System.Console.WriteLine("Hello World!");
        }


    }


}
