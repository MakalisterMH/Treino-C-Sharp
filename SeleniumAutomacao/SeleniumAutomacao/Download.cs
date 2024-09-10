using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium;
using System;
using System.Linq;
using System.Threading;
using System.IO;
using System.Security.Cryptography.X509Certificates;

namespace SeleniumAutomacao
{
    public class Download
    {



            public void BaixarJornal() {


                // Configurações de diretórios (removidas por brevidade)

                // Obter a data e hora atual
                DateTime agora = DateTime.Now;
                // Formatando a data no formato dd/MM/yyyy
                string dataOriginal = agora.ToString("dd/MM/yyyy");
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
                    driver.Navigate().GoToUrl("https://dje-consulta.tse.jus.br/#/dje/calendario");

                    WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(5)); // Aumentando o tempo de espera

                    for (int i = 2; i < 29; i++)
                    {
                        try
                        {
                            // Esperar até que o primeiro elemento esteja clicável e clicar nele
                            IWebElement element = wait.Until(drv => drv.FindElement(By.XPath("/html/body/app-root/div/app-calendario/div/div[1]/div[1]/div/div[1]/mat-form-field/div/div[1]/div")));
                            element.Click();

                            // Esperar até que o segundo elemento esteja clicável e clicar nele
                            string xpathSecondElement = $"/html/body/div[4]/div[2]/div/div/div/mat-option[{i}]/span";
                            IWebElement secondElement = wait.Until(drv => drv.FindElement(By.XPath(xpathSecondElement)));
                            secondElement.Click();

                            for (int y = 2; y < 7; y++)
                            {
                                try
                                {
                                    Thread.Sleep(1000);

                                    // Usar o seletor CSS para encontrar o elemento
                                    string cssSelectorTerceiroElement = $"body > app-root > div > app-calendario > div > div:nth-child(1) > div.coluna-recentes > div:nth-child({y}) > button";
                                    IWebElement terceiroElement = wait.Until(drv => drv.FindElement(By.CssSelector(cssSelectorTerceiroElement)));

                                    // Obter o texto do elemento
                                    string textoElemento = terceiroElement.Text;

                                    // Manipular o texto (se necessário)
                                    textoElemento = textoElemento.Replace(" ", "").Replace("get_app", "");

                                    // Imprimir o texto manipulado no console
                                    Console.WriteLine($"Elemento: {textoElemento}");

                                    // Clicar no elemento
                                    terceiroElement.Click();

                                    // Esperar até que a nova janela esteja disponível
                                    wait.Until(drv => drv.WindowHandles.Count > 1);

                                    // Obter a janela atual e a nova janela
                                    string mainWindowHandle = driver.CurrentWindowHandle;
                                    string newWindowHandle = driver.WindowHandles.FirstOrDefault(handle => handle != mainWindowHandle);

                                    // Verifique se a nova janela ainda existe
                                    if (newWindowHandle == null || !driver.WindowHandles.Contains(newWindowHandle))
                                    {
                                        Console.WriteLine("A nova janela foi fechada ou descartada antes que o Selenium pudesse interagir com ela.");
                                        continue; // Pular para o próximo ciclo
                                    }

                                    // Alternar para a nova janela
                                    driver.SwitchTo().Window(newWindowHandle);

                                    // O Firefox configurado deve iniciar o download automaticamente
                                    Console.WriteLine("PDF deve estar sendo baixado automaticamente.");

                                    // Aguardar alguns segundos para garantir que o download seja concluído
                                    Thread.Sleep(5000); // Ajuste o tempo conforme necessário

                                    // Fechar a nova janela
                                    driver.Close();
                                    // Alternar de volta para a janela principal
                                    driver.SwitchTo().Window(mainWindowHandle);
                                }
                                catch (NoSuchWindowException ex)
                                {
                                    Console.WriteLine($"A janela foi fechada ou descartada: {ex.Message}");
                                }
                                catch (WebDriverTimeoutException ex)
                                {
                                    Console.WriteLine($"Tempo esgotado ao processar o elemento {y}: {ex.Message}");
                                }
                                catch (Exception ex)
                                {
                                    Console.WriteLine($"Erro ao processar o elemento {y}: {ex.Message}");
                                }
                            }
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine($"Erro ao processar a seleção de datas {i}: {ex.Message}");
                        }
                    }
                }
                finally
                {
                    // Fechar o navegador
                    driver.Quit();
                }
            }
        }
}

