using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;

namespace Tugas_Akhir_6___Download
{
    class Program
    {
        static void Main(string[] args)
        {

            WebClient webClient = new WebClient();
            try
            {
                webClient.DownloadFile(new Uri("https://s-media-cache-ak0.pinimg.com/736x/34/27/28/3427283895e64f88581be95445f1dd27.jpg"), @"E:\Mphie_Hime\Mikasa.jpg");
                Console.WriteLine("Loading....\n");
            }
            catch (WebException e)
            {
                Console.WriteLine("Download Gagal");
                Console.WriteLine(e.StackTrace);
            }
            finally
            {
                Console.WriteLine("\n Download berhasil...(^ ^). gambar telah tersimpan di E :Mphie_Hime");
                Console.ReadKey();
            }
        }
    }
}
