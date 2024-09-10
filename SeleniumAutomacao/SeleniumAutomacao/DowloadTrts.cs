using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium;
using System;
using iText.Layout.Element;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;
using System.Linq;
using System.Threading;
using System.IO;
using System.Security.Cryptography.X509Certificates;
using static iText.StyledXmlParser.Jsoup.Select.Evaluator;
using SeleniumExtras.WaitHelpers;
using SeleniumAutomacao;



namespace SeleniumAutomation
{
    internal class DownloadTrts
    {
        
            public static void baixarADM()
            {

                // Configurações de diretórios (removidas por brevidade)

                // Obter a data e hora atual
                DateTime agora = DateTime.Now;
                // Formatando a data no formato dd/MM/yyyy
                string dataOriginal = agora.ToString("ddMMyyyy");
                // Substituir "/" por "-"
                string dataFormatada = dataOriginal.Replace("/", "-");

                // Configurar o caminho para o GeckoDriver
                string geckoDriverPath = @"F:\Makalister Update\TRE-ADMIN";

                // Configurar o FirefoxDriver para lidar com downloads e executar em modo headless
                FirefoxOptions options = new FirefoxOptions();
                options.AddArgument("--headless");

                // Configurar o perfil do Firefox
                FirefoxProfile profile = new FirefoxProfile();
                profile.SetPreference("browser.download.folderList", 2); // Usar o diretório especificado
                profile.SetPreference("browser.download.dir", @"F:\Makalister Update\TRE-ADMIN\DOWNLOADS"); // Diretório para downloads
                profile.SetPreference("browser.helperApps.neverAsk.saveToDisk", "application/pdf"); // Tipo MIME para PDFs
                profile.SetPreference("pdfjs.disabled", true); // Desabilitar o visualizador interno de PDFs

                options.Profile = profile;

                // Inicializar o FirefoxDriver
                FirefoxDriverService service = FirefoxDriverService.CreateDefaultService(geckoDriverPath);
                IWebDriver driver = new FirefoxDriver(service, options);

                try
                {
                    // Navegar para a página
                    driver.Navigate().GoToUrl("https://dejt.jt.jus.br/dejt/f/n/diariocon");

                    WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10)); // Aumentando o tempo de espera

                    // Data início
                    IWebElement elementoDataInicio = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.XPath("//*[@id='corpo:formulario:dataIni']")));
                    elementoDataInicio.Click();
                    elementoDataInicio.SendKeys(dataOriginal);

                    // Data fim
                    IWebElement elementoDataFim = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.XPath("//*[@id='corpo:formulario:dataFim']")));
                    elementoDataFim.Click();
                    elementoDataFim.SendKeys(dataOriginal);

                    // Cadernos ADM
                    IWebElement elementoCadAdm = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.XPath("//*[@id='corpo:formulario:tipoCaderno:_0']")));
                    elementoCadAdm.Click();

                    // BuscarCadernosAdm
                    IWebElement elementoBuscar = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.CssSelector("#corpo\\:formulario\\:botaoAcaoPesquisar")));
                    elementoBuscar.Click();

                    int i = 2;



                    while (i < 30)
                    {
                        IWebElement Baixar = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.XPath($"/html/body/div[1]/div[4]/form/span[1]/span[3]/div[1]/div[3]/span/span[1]/fieldset/table/tbody/tr[{i}]/td[3]/a/i")));
                        Baixar.Click();

                    Console.WriteLine("Baixando adm posição" + i );

                        i++;

                    }

                    
                }

                catch (Exception ex)
                {
                    Console.WriteLine($"Erro ao baixar jornais Adm: {ex.Message}");
                }

            driver.Quit();

        }
       

            public static void baixarJUD()
            {

                // Configurações de diretórios (removidas por brevidade)

                // Obter a data e hora atual
                DateTime agora = DateTime.Now;
                // Formatando a data no formato dd/MM/yyyy
                string dataOriginal = agora.ToString("ddMMyyyy");
                // Substituir "/" por "-"
                string dataFormatada = dataOriginal.Replace("/", "-");

                // Configurar o caminho para o GeckoDriver
                string geckoDriverPath = @"F:\Makalister Update\TRE-ADMIN";

                // Configurar o FirefoxDriver para lidar com downloads e executar em modo headless
                FirefoxOptions options = new FirefoxOptions();
                //options.AddArgument("--headless");

                // Configurar o perfil do Firefox
                FirefoxProfile profile = new FirefoxProfile();
                profile.SetPreference("browser.download.folderList", 2); // Usar o diretório especificado
                profile.SetPreference("browser.download.dir", @"F:\Makalister Update\TRE-ADMIN\DOWNLOADS"); // Diretório para downloads
                profile.SetPreference("browser.helperApps.neverAsk.saveToDisk", "application/pdf"); // Tipo MIME para PDFs
                profile.SetPreference("pdfjs.disabled", true); // Desabilitar o visualizador interno de PDFs

                options.Profile = profile;

                // Inicializar o FirefoxDriver
                FirefoxDriverService service = FirefoxDriverService.CreateDefaultService(geckoDriverPath);
                IWebDriver driver = new FirefoxDriver(service, options);

                try

                {

                    // Navegar para a página
                    driver.Navigate().GoToUrl("https://dejt.jt.jus.br/dejt/f/n/diariocon");

                    WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(15)); // Aumentando o tempo de espera

                    // Data início
                    IWebElement elementoDataInicio = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.XPath("//*[@id='corpo:formulario:dataIni']")));
                    elementoDataInicio.Click();
                    elementoDataInicio.SendKeys(dataOriginal);

                    // Data fim
                    IWebElement elementoDataFim = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.XPath("//*[@id='corpo:formulario:dataFim']")));
                    elementoDataFim.Click();
                    elementoDataFim.SendKeys(dataOriginal);

                    // Cadernos Jud
                    IWebElement elementoCadJud = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.XPath("//*[@id=\"corpo:formulario:tipoCaderno:_1\"]")));
                    elementoCadJud.Click();

                    // BuscarCadernosJud
                    IWebElement elementoBuscar = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.CssSelector("#corpo\\:formulario\\:botaoAcaoPesquisar")));
                    elementoBuscar.Click();


                    int x = 2;

                    while (x < 30)
                    {


                        IWebElement Baixar2 = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.XPath($"/html/body/div[1]/div[4]/form/span[1]/span[3]/div[1]/div[3]/span/span[1]/fieldset/table/tbody/tr[{x}]/td[3]/a/i")));
                        Baixar2.Click();

                        Console.WriteLine("Baixando jud posição" + x);

                        x++;

                    }
                }

                catch (Exception ex)
                {
                    Console.WriteLine($"Erro ao baixar jornais Adm: {ex.Message}");

                }
            }

        
        
    }
}