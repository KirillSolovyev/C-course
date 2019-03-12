using System;
using System.IO;

//FileStream

namespace FILEStream{
    class Program{
        static void Main(string[] args){
            using(FileStream fs = new FileStream("text.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite)){
                // //public FileStream (string path, System.IO.FileMode mode, System.IO.FileAccess access);
                // //public FileStream (string path, System.IO.FileMode mode);
                // byte[] arr = new byte[fs.Length]; // Length returns size of data in bytes
                // Console.WriteLine("Length is {0} in bytes and {1} in integer", fs.Length, (int)fs.Length);
                // // string text = System.Text.Encoding.Default.GetBytes("FileStream text");
                // fs.Read(arr, 0, arr.Length);
                // // public override int Read (byte[] array, int offset, int count);
                // // Read(whereToWriteText, whereToStartReading, howManyBytesToRead);
                // // Read returns total number of bytes read into buffer
                // string textFromByte = System.Text.Encoding.Default.GetString(arr);
                // Console.WriteLine("FileStream text: {0}", textFromByte);
                // Console.WriteLine("\nNow some text will be added to the end of the file");
                // string text = " This was added in the end";
                // fs.Seek(0, SeekOrigin.End); // Устанавливает курсор в конец файла
                // // fs.Seek(-5, SeekOrigin.End); Устанавливает курсор 5 символов с конца файла
                // // public override long Seek (long offset, System.IO.SeekOrigin origin);
                // fs.Write(System.Text.Encoding.Default.GetBytes(text), 0, System.Text.Encoding.Default.GetByteCount(text));
                using(StreamReader sr = new StreamReader(fs)){
                    Console.WriteLine(sr.ReadToEnd());
                }
            }
            using(StreamWriter sw = new StreamWriter("text.txt")){
                    sw.WriteLine("This text was changed");
                }
        }
    }
}