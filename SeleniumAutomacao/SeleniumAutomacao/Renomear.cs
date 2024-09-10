using iText.Kernel.Pdf;
using iText.Kernel.Pdf.Canvas.Parser;
using iText.Kernel.Pdf.Canvas.Parser.Listener;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text.RegularExpressions;
using System.Collections.Generic;
using System.IO;
using System.Text.RegularExpressions;
using iText.Kernel.Pdf;
using iText.Kernel.Pdf.Canvas.Parser;
using iText.Kernel.Pdf.Canvas.Parser.Listener;
using System.Security.Cryptography.X509Certificates;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text.RegularExpressions;
using iText.Kernel.Pdf;
using iText.Kernel.Pdf.Canvas.Parser;
using iText.Kernel.Pdf.Canvas.Parser.Listener;

namespace SeleniumAutomacao
{
    public class Renomear
    {







            // Dicionário que mapeia os nomes completos dos tribunais para suas siglas
            private static readonly Dictionary<string, string> TribunalAbbreviations = new Dictionary<string, string>
        {
            { "TRIBUNAL REGIONAL ELEITORAL DO ACRE", "TRE-AC" },
            { "TRIBUNAL REGIONAL ELEITORAL DE ALAGOAS", "TRE-AL" },
            { "TRIBUNAL REGIONAL ELEITORAL DO AMAZONAS", "TRE-AM" },
            { "TRIBUNAL REGIONAL ELEITORAL DO AMAPÁ", "TRE-AP" },
            { "TRIBUNAL REGIONAL ELEITORAL DA BAHIA", "TRE-BA" },
            { "TRIBUNAL REGIONAL ELEITORAL DO CEARÁ", "TRE-CE" },
            { "TRIBUNAL REGIONAL ELEITORAL DO DISTRITO", "TRE-DFT" },
            { "TRIBUNAL REGIONAL ELEITORAL DO ESPÍRITO SANTO", "TRE-ES" },
            { "TRIBUNAL REGIONAL ELEITORAL DE GOIÁS", "TRE-GO" },
            { "TRIBUNAL REGIONAL ELEITORAL DO MARANHÃO", "TRE-MA" },
            { "TRIBUNAL REGIONAL ELEITORAL DO MATO GROSSO\\s*DO SUL", "TRE-MS" }, // Expressão regular para lidar com quebras de linha e espaços
            { "TRIBUNAL REGIONAL ELEITORAL DO MATO GROSSO", "TRE-MT" },
            { "TRIBUNAL REGIONAL ELEITORAL DE MINAS GERAIS", "TRE-MG" },
            { "TRIBUNAL REGIONAL ELEITORAL DO PARÁ", "TRE-PA" },
            { "TRIBUNAL REGIONAL ELEITORAL DA PARAÍBA", "TRE-PB" },
            { "TRIBUNAL REGIONAL ELEITORAL DO PARANÁ", "TRE-PR" },
            { "TRIBUNAL REGIONAL ELEITORAL DE PERNAMBUCO", "TRE-PE" },
            { "TRIBUNAL REGIONAL ELEITORAL DO PIAUÍ", "TRE-PI" },
            { "TRIBUNAL REGIONAL ELEITORAL DO RIO DE JANEIRO", "TRE-RJ" },
            { "TRIBUNAL REGIONAL ELEITORAL DO RIO GRANDE DO\\s*NORTE", "TRE-RN" },
            { "TRIBUNAL REGIONAL ELEITORAL DO RIO GRANDE DO\\s*SUL", "TRE-RS" },
            { "TRIBUNAL REGIONAL ELEITORAL DE RONDÔNIA", "TRE-RO" },
            { "TRIBUNAL REGIONAL ELEITORAL DE RORAIMA", "TRE-RR" },
            { "TRIBUNAL REGIONAL ELEITORAL DE SANTA CATARINA", "TRE-SC" },
            { "TRIBUNAL REGIONAL ELEITORAL DE SÃO PAULO", "TRE-SP" },
            { "TRIBUNAL REGIONAL ELEITORAL DE SERGIPE", "TRE-SE" },
            { "TRIBUNAL REGIONAL ELEITORAL DO TOCANTINS", "TRE-TO" }
        };

            // Dicionário que mapeia os nomes dos meses para seus números correspondentes
            private static readonly Dictionary<string, string> MonthToNumeric = new Dictionary<string, string>
        {
            { "janeiro", "01" },
            { "fevereiro", "02" },
            { "março", "03" },
            { "abril", "04" },
            { "maio", "05" },
            { "junho", "06" },
            { "julho", "07" },
            { "agosto", "08" },
            { "setembro", "09" },
            { "outubro", "10" },
            { "novembro", "11" },
            { "dezembro", "12" }
        };

            public void RenomearJornais()
            {
                // Diretório onde os arquivos PDF estão localizados
                string sourceDirectory = @"F:\Makalister Update\TRE-ADMIN\DOWNLOADS";

                // Verifica se o diretório especificado existe
                if (!Directory.Exists(sourceDirectory))
                {
                    Console.WriteLine($"O diretório '{sourceDirectory}' não existe.");
                    return;
                }

                // Obtém todos os arquivos PDF no diretório
                string[] files = Directory.GetFiles(sourceDirectory, "*.pdf");

                // Itera sobre cada arquivo PDF encontrado
                foreach (string file in files)
                {
                    try
                    {
                        // Variáveis para armazenar dados extraídos do PDF
                        string edicao = string.Empty;
                        string disponibilizacaoDay = string.Empty;
                        string publicacaoDay = string.Empty;
                        string tribunalAbbreviation = string.Empty;
                        string mesDis = string.Empty;
                        string mesPub = string.Empty;
                        string anoDis = string.Empty;
                        string anoPub = string.Empty;

                        // Abre o arquivo PDF para leitura
                        using (PdfReader pdfReader = new PdfReader(file))
                        {
                            using (PdfDocument pdfDoc = new PdfDocument(pdfReader))
                            {
                                // Verifica se o PDF contém pelo menos uma página
                                if (pdfDoc.GetNumberOfPages() > 0)
                                {
                                    // Obtém a primeira página do PDF
                                    var page = pdfDoc.GetPage(1);
                                    // Extrai o texto da primeira página
                                    string text = ExtractTextFromPage(page);

                                    // Verifica o tipo de edição e extrai o valor da edição
                                    edicao = ExtractEdition(text);

                                    // Extrai o dia de disponibilização e publicação
                                    disponibilizacaoDay = ExtractDay(text, "Disponibilização:");
                                    publicacaoDay = ExtractDay(text, "Publicação:");

                                    // Obtém a sigla do tribunal
                                    tribunalAbbreviation = GetTribunalAbbreviation(text);

                                    // Extrai o mês e ano de disponibilização e publicação
                                    mesDis = ExtractMonth(text, "Disponibilização:");
                                    mesPub = ExtractMonth(text, "Publicação:");
                                    anoDis = ExtractYear(text, "Disponibilização:");
                                    anoPub = ExtractYear(text, "Publicação:");
                                }
                                else
                                {
                                    Console.WriteLine($"O arquivo {Path.GetFileName(file)} está vazio.");
                                    continue;
                                }
                            }
                        }

                        // Obtém o mês numérico a partir do nome do mês
                        string mesDisNumerico = MonthToNumeric.ContainsKey(mesDis.ToLower()) ? MonthToNumeric[mesDis.ToLower()] : "00";
                        string mesPubNumerico = MonthToNumeric.ContainsKey(mesPub.ToLower()) ? MonthToNumeric[mesPub.ToLower()] : "00";

                        // Cria o novo nome do arquivo no formato desejado
                        string novoNome = $"{tribunalAbbreviation}_{anoPub}{mesPubNumerico}{publicacaoDay}_{edicao}_Judiciário_{anoDis}{mesDisNumerico}{disponibilizacaoDay}0000.pdf";

                        // Define o caminho completo para o novo nome do arquivo
                        string novoCaminho = Path.Combine(sourceDirectory, novoNome);
                        // Renomeia o arquivo
                        File.Move(file, novoCaminho);

                        // Exibe informações sobre o arquivo processado
                        Console.WriteLine($"Arquivo: {Path.GetFileName(file)}");
                        Console.WriteLine($"Novo Nome: {novoNome}");
                        Console.WriteLine(new string('-', 80));
                    }
                    catch (Exception ex)
                    {
                        // Exibe erros que ocorrem durante o processamento
                        Console.WriteLine($"Erro ao processar o arquivo {Path.GetFileName(file)}: {ex.Message}");
                    }
                }

                // Mensagem final indicando que o processamento foi concluído
                Console.WriteLine("Processamento concluído.");
            }

            // Método para extrair o texto de uma página do PDF
            private static string ExtractTextFromPage(iText.Kernel.Pdf.PdfPage page)
            {
                // Define a estratégia de extração de texto
                var strategy = new SimpleTextExtractionStrategy();
                // Extrai o texto da página usando a estratégia definida
                var text = PdfTextExtractor.GetTextFromPage(page, strategy);
                return text;
            }

            // Método para extrair a edição do texto
            private static string ExtractEdition(string text)
            {
                // Verifica se o texto contém "Edição Extraordinária"
                if (text.Contains("Edição Extraordinária"))
                {
                    // Encontra a posição de "nº" e "Edição Extraordinária" no texto
                    var indiceN = text.IndexOf("nº");
                    var indiceDis = text.IndexOf("Edição Extraordinária", indiceN);
                    // Extrai a edição entre essas posições
                    if (indiceN != -1 && indiceDis != -1)
                    {
                        var edicao = text.Substring(indiceN + 2, indiceDis - indiceN - 2).Trim();
                        return Regex.Replace(edicao, @"\s", "");
                    }
                }
                // Verifica se o texto contém "Edição Eleitoral"
                else if (text.Contains("Edição Eleitoral"))
                {
                    // Encontra a posição de "nº" e "Edição Eleitoral" no texto
                    var indiceN = text.IndexOf("nº");
                    var indiceDis = text.IndexOf("Edição Eleitoral", indiceN);
                    // Extrai a edição entre essas posições
                    if (indiceN != -1 && indiceDis != -1)
                    {
                        var edicao = text.Substring(indiceN + 2, indiceDis - indiceN - 2).Trim();
                        return Regex.Replace(edicao, @"\s", "");
                    }
                }
                else
                {
                    // Para outros casos, tenta extrair o valor da edição
                    var indiceN = text.IndexOf("nº");
                    var indiceDis = text.IndexOf("Disponibilização", indiceN);
                    if (indiceN != -1 && indiceDis != -1)
                    {
                        var edicao = text.Substring(indiceN + 2, indiceDis - indiceN - 2).Trim();
                        return Regex.Replace(edicao, @"\s", "");
                    }
                }

                return string.Empty;
            }

            // Método para extrair o dia de uma data a partir do texto
            private static string ExtractDay(string text, string context)
            {
                // Define o padrão para extrair o dia
                var dayPattern = $@"{context}.*?(\d{{2}}) de \w+ de \d{{4}}";
                var match = Regex.Match(text, dayPattern, RegexOptions.IgnoreCase);
                return match.Success ? match.Groups[1].Value : string.Empty;
            }

            // Método para extrair o mês de uma data a partir do texto
            private static string ExtractMonth(string text, string context)
            {
                // Define o padrão para extrair o mês
                var monthPattern = $@"{context}.*?de (\w+) de \d{{4}}";
                var match = Regex.Match(text, monthPattern, RegexOptions.IgnoreCase);
                return match.Success ? match.Groups[1].Value : string.Empty;
            }

            // Método para extrair o ano de uma data a partir do texto
            private static string ExtractYear(string text, string context)
            {
                // Define o padrão para extrair o ano
                var yearPattern = $@"{context}.*?de \w+ de (\d{{4}})";
                var match = Regex.Match(text, yearPattern, RegexOptions.IgnoreCase);
                return match.Success ? match.Groups[1].Value : string.Empty;
            }

            // Método para obter a sigla do tribunal a partir do texto
            private static string GetTribunalAbbreviation(string text)
            {
                // Itera sobre cada par chave-valor do dicionário de siglas
                foreach (var pair in TribunalAbbreviations)
                {
                    // Usa expressão regular para verificar se o texto contém o nome completo do tribunal
                    if (Regex.IsMatch(text, pair.Key, RegexOptions.IgnoreCase | RegexOptions.Multiline))
                    {
                        // Retorna a sigla correspondente
                        return pair.Value;
                    }
                }
                return string.Empty;
            }
        }
    }
