using System;
using System.Threading.Tasks;
using SeleniumAutomacao;

namespace SeleniumAutomation
{
    class Program
    {
        [STAThread]
        static async Task Main(string[] args)
        {
            Download download = new Download();
            Renomear renomear = new Renomear();
            DownloadTrts trts = new DownloadTrts();

            //download.BaixarJornal();
            //renomear.RenomearJornais();
            //await SalvarImportar.SalvarImportarJornal();



            //DownloadTrts.baixarADM();
            DownloadTrts.baixarJUD();
        }
    }
}
