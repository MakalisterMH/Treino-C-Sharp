using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;
using System;
using System.Linq;
using System.Net;
using System.Threading;
using WindowsInput;
using WindowsInput.Native;
using System;
using System.IO;
using System.Threading.Tasks;
using iTextSharp.text.pdf;

namespace SeleniumAutomation
{
    class Program
    {
        [STAThread] // Necessário para enviar teclas
        static void Main(string[] args)
        {




            // Diretório de origem
            string sourceDirectory = @"C:\Users\LocalAdmin\Downloads";

            // Diretório de destino
            string destinationDirectory = @"C:\Users\LocalAdmin\Desktop\auxiliar";

            // Verificar se o diretório de origem existe
            if (!Directory.Exists(sourceDirectory))
            {
                Console.WriteLine($"O diretório de origem '{sourceDirectory}' não existe.");
                return;
            }

            // Criar o diretório de destino se não existir
            if (!Directory.Exists(destinationDirectory))
            {
                Directory.CreateDirectory(destinationDirectory);
            }

            // Obter todos os arquivos do diretório de origem
            string[] files = Directory.GetFiles(sourceDirectory);

            foreach (var filePath in files)
            {
                // Obter o nome do arquivo
                string fileName = Path.GetFileName(filePath);

                // Caminho de destino para o arquivo
                string destFilePath = Path.Combine(destinationDirectory, fileName);

                try
                {
                    // Mover o arquivo
                    File.Move(filePath, destFilePath);
                    Console.WriteLine($"Arquivo movido: {fileName}");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Erro ao mover o arquivo {fileName}: {ex.Message}");
                }
            }

            Console.WriteLine("Todos os arquivos foram movidos com sucesso!");



            Console.WriteLine("Agora vamos baixar os jornais");

            





            // Obter a data e hora atual
            DateTime agora = DateTime.Now;

            // Formatando a data no formato dd/MM/yyyy
            string dataOriginal = agora.ToString("dd/MM/yyyy");

            // Substituir "/" por "-"
            string dataFormatada = dataOriginal.Replace("/", "-");




            // Configurar o caminho para o GeckoDriver
            string geckoDriverPath = @"C:\WebDriver";

            // Inicializar o FirefoxDriver
            FirefoxDriverService service = FirefoxDriverService.CreateDefaultService(geckoDriverPath);
            IWebDriver driver = new FirefoxDriver(service);

            // Navegar para a página
            driver.Navigate().GoToUrl("https://dje-consulta.tse.jus.br/#/dje/calendario");

            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));

            for (int i = 2; i < 29; i++)
            {
                // Esperar até que o primeiro elemento esteja clicável e clicar nele
                IWebElement element = wait.Until(drv => drv.FindElement(By.XPath("/html/body/app-root/div/app-calendario/div/div[1]/div[1]/div/div[1]/mat-form-field/div/div[1]/div")));
                element.Click();

                // Esperar até que o segundo elemento esteja clicável e clicar nele
                string xpathSecondElement = $"/html/body/div[4]/div[2]/div/div/div/mat-option[{i}]/span";
                IWebElement secondElement = wait.Until(drv => drv.FindElement(By.XPath(xpathSecondElement)));
                secondElement.Click();

                for (int y = 2; y < 6; y++)
                {
                    try
                    {
                        Thread.Sleep(1000);

                        // Esperar até que o terceiro elemento esteja clicável e clicar nele
                        string xpathTerceiroElement = $"/html/body/app-root/div/app-calendario/div/div[1]/div[2]/div[{y}]/button/span/mat-icon";
                        IWebElement terceiroElement = wait.Until(drv => drv.FindElement(By.XPath(xpathTerceiroElement)));
                        terceiroElement.Click();

                        // Esperar até que a nova janela esteja disponível
                        wait.Until(drv => drv.WindowHandles.Count > 1);

                        // Obter a janela atual e a nova janela
                        string mainWindowHandle = driver.CurrentWindowHandle;
                        string newWindowHandle = driver.WindowHandles.First(handle => handle != mainWindowHandle);

                        // Alternar para a nova janela
                        driver.SwitchTo().Window(newWindowHandle);

                        Thread.Sleep(1000);

                        // Esperar até que o quarto elemento esteja clicável e clicar nele
                        string xpathQuartoElement = "//*[@id='download']";
                        IWebElement quartoElement = wait.Until(drv => drv.FindElement(By.XPath(xpathQuartoElement)));
                        quartoElement.Click();

                        // Esperar até que a janela de diálogo esteja ativa
                        Thread.Sleep(6000); // Aguarde um pouco para garantir que a janela esteja ativa

                        // Usar InputSimulator para enviar texto
                        var simulator = new InputSimulator();
                        simulator.Keyboard.TextEntry($"jornal{i}-{y}-{dataFormatada}.pdf");

                        Thread.Sleep(1000); // Aguarde um pouco para garantir que a janela esteja ativa

                        simulator.Keyboard.KeyPress(VirtualKeyCode.RETURN); // Pressiona Enter para salvar

                        Thread.Sleep(2000);

                        // Fechar a nova janela e voltar para a janela principal
                        driver.Close();
                        driver.SwitchTo().Window(mainWindowHandle);
                    }
                    catch (Exception ex)
                    {
                        // Lidar com exceções
                        Console.WriteLine($"Erro ao processar o elemento {y}: {ex.Message}");
                        // Se desejar continuar com o próximo y, adicione um continue aqui, se apropriado
                    }
                }
            }

            // Fechar o navegador
            driver.Quit();





    }
    }
}
