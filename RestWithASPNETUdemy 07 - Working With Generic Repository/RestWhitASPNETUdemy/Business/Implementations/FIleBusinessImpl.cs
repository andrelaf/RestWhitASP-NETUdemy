using System.IO;

namespace RestWhitASPNETUdemy.Busines.Implementations
{
    public class FileBusinessImpl : IFileBusiness
    {
        public byte[] GetPDFFile()
        {

            string path = Directory.GetCurrentDirectory();
            var fulPath = path + "\\Other\\Aula-08-Docker-CLI.pdf";
            return File.ReadAllBytes(fulPath);

        }
    }
}
