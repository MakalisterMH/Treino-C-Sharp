using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;


namespace SeleniumAutomacao
{
    internal class SalvarImportar
    {

            private static readonly HttpClient client = new HttpClient();

        public static async Task SalvarImportarJornal()
        {

            {
                // Obtém a data atual no formato yyyy-MM-dd
                string dataAtual = DateTime.Now.ToString("yyyy-MM-dd");

                // Diretório onde os PDFs estão localizados
                string pdfDirectory = @"F:\Makalister Update\TRE-ADMIN\DOWNLOADS";

                string diretorioImportador = @"F:\APRODUÇÃO\CLIPAGEM\Importação-PDF";

                string diretorioJornaisBaixados = @"F:\Makalister Update\TRE-ADMIN\TRES-2024";

                // Obter todos os nomes de jornais existentes no banco
                var nomesExistentes = await ObterNomesExistentesAsync();

                if (nomesExistentes == null || nomesExistentes.Count == 0)
                {
                    Console.WriteLine("Não foi possível obter a lista de nomes existentes ou a lista está vazia.");
                }

                // Obter todos os arquivos PDF do diretório
                string[] pdfFiles = Directory.GetFiles(pdfDirectory, "*.pdf");
                var nomesParaSalvar = new List<string>();

                foreach (var filePath in pdfFiles)
                {
                    // Obter o nome do arquivo sem a extensão
                    string fileName = Path.GetFileNameWithoutExtension(filePath).Trim();

                    // Normalizar o nome do arquivo
                    string nomeNormalizado = fileName.Replace(" ", "").Replace("_", "");

                    // Verificar se o nome já existe na lista
                    if (nomesExistentes.Contains(nomeNormalizado))
                    {
                        // Excluir o arquivo PDF se o nome já existir
                        try
                        {
                            File.Delete(filePath);
                            Console.WriteLine($"Arquivo excluído: {fileName}");
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine($"Erro ao excluir o arquivo {fileName}: {ex.Message}");
                        }
                    }
                    else
                    {
                        Console.WriteLine($"Nome não encontrado no banco, mantido: {fileName}");
                        nomesParaSalvar.Add(nomeNormalizado);
                    }
                }

                // Salvar os nomes mantidos no banco de dados
                foreach (var nome in nomesParaSalvar)
                {
                    var sucesso = await SalvarNomeAsync(nome);
                    if (sucesso)
                    {
                        Console.WriteLine($"Nome salvo com sucesso: {nome}");
                    }
                    else
                    {
                        Console.WriteLine($"Erro ao salvar o nome {nome}");
                    }


                    // Cria o caminho completo da pasta com a data atual dentro do diretório de jornais baixados
                    string diretorioDataAtual = Path.Combine(diretorioJornaisBaixados, dataAtual);

                    // Verifica se o diretório da data atual já existe, caso contrário, cria-o
                    if (!Directory.Exists(diretorioDataAtual))
                    {
                        Directory.CreateDirectory(diretorioDataAtual);
                    }

                    // Faz uma cópia de cada arquivo PDF Para os diretorios e dps exclui
                    foreach (var nomeArquivo in pdfFiles)
                    {
                        try
                        {

                            // Cria o caminho completo do arquivo de destino para o diretório da data atual
                            string destinoArquivo1 = Path.Combine(diretorioDataAtual, Path.GetFileName(nomeArquivo));
                            File.Copy(nomeArquivo, destinoArquivo1, true); // 'true' permite sobrescrever arquivos existentes


                            // Cria o caminho completo do arquivo de destino para o importador de PDF
                            string destinoArquivo2 = Path.Combine(diretorioImportador, Path.GetFileName(nomeArquivo));
                            File.Move(nomeArquivo, destinoArquivo2, true); // 'true' permite sobrescrever arquivos existentes



                            Console.WriteLine($"Arquivo movidos: {nomeArquivo}, para os diretórios: {diretorioImportador} e {diretorioDataAtual}");


                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine($"Erro ao mover o arquivo {nomeArquivo}: {ex.Message}");
                        }
                    }


                }




            }
        }


            private static async Task<List<string>> ObterNomesExistentesAsync()
            {
                try
                {
                    var response = await client.GetAsync("http://191.252.192.235:8080/Jornais");

                    if (response.IsSuccessStatusCode)
                    {
                        var jsonResponse = await response.Content.ReadAsStringAsync();
                        Console.WriteLine($"Resposta JSON: {jsonResponse}");

                        var jornais = JsonConvert.DeserializeObject<List<Jornal>>(jsonResponse);

                        if (jornais == null)
                        {
                            Console.WriteLine("A desserialização da resposta JSON falhou.");
                            return null;
                        }

                        var listaNomes = new List<string>();

                        foreach (var jornal in jornais)
                        {
                            if (!string.IsNullOrEmpty(jornal.Nome))
                            {
                                listaNomes.Add(jornal.Nome);
                            }
                        }

                        return listaNomes;
                    }
                    else
                    {
                        Console.WriteLine($"Erro ao obter nomes existentes: {response.StatusCode}");
                    }
                }
                catch (JsonException jsonEx)
                {
                    Console.WriteLine($"Erro ao desserializar JSON: {jsonEx.Message}");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Erro ao obter nomes existentes: {ex.Message}");
                }

                return null;
            }

            private static async Task<bool> SalvarNomeAsync(string nome)
            {
                try
                {
                    var requestBody = new { nome = nome };
                    var content = new StringContent(JsonConvert.SerializeObject(requestBody), System.Text.Encoding.UTF8, "application/json");

                    var response = await client.PostAsync("http://191.252.192.235:8080/Jornais", content);

                    if (response.IsSuccessStatusCode)
                    {
                        return true;
                    }
                    else
                    {
                        Console.WriteLine($"Erro ao salvar nome: {response.StatusCode}");
                        return false;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Erro ao salvar nome: {ex.Message}");
                    return false;
                }
            }

            private class Jornal
            {
                public string Nome { get; set; }
            }
        }
    }




