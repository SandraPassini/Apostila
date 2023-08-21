using Microsoft.AspNetCore.Mvc;
using System.ComponentModel;

namespace LeituraApostila.Controllers
{
    [ApiController]
    [Route("lerapostila/{id_apostila}")]
    public class LerApostilaController : ControllerBase
    {

        private readonly ILogger<LerApostilaController> _logger;

        public LerApostilaController(ILogger<LerApostilaController> logger)
        {
            _logger = logger;
        }
        [HttpGet(Name = "GetLerArquivo")]
        public IEnumerable<LerArquivoResponse, LerArquivoRequest> Get()
        {
            //declarando a variavel do tipo StreamWriter
            StreamReader x;

            //Colocando o caminho fisico
            string Caminho = @"C:\Users\sandr\OneDrive\Documentos\Estudo Sandra\AWS Lambda.txt";
            //abrindo um arquivo texto
            x = new StreamReader(Caminho);
            x.ReadLine();
            //x = File.OpenText();

            //enquanto nao retornar valor booleano true
            while (x.EndOfStream != true)//quer dizer que não chegou no fim do
                                         //arquivo
            {
                //le conteúdo da linha
                string linha = x.ReadLine();
                //escreve na tela o conteúdo da linha
             //   if (linha == "11")
             //   {
             //       x.ReadLine();
                    Console.WriteLine(linha);
              //  }
            }
            //após sair do while, é porque leu todo o conteúdo, então
            //temos que fechar o arquivo texto que está aberto
            x.Close();

            Console.ReadKey();//esse comando é para não fechar a tela do console
                              //fechar so após o usuário clicar em uma tecla do
                              //teclado
            return null;
        }
    }
}
