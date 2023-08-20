using Microsoft.AspNetCore.Mvc;

namespace LeituraApostila.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class LerApostilaController : ControllerBase
    {
        public LerApostilaController()
        {
        }

        private readonly ILogger<LerApostilaController> _logger;

        public LerApostilaController(ILogger<LerApostilaController> logger)
        {
            _logger = logger;
        }
        [HttpGet(Name = "GetLerArquivo")]
        public IEnumerable<LerArquivoResponse> Get()
        {
            return null;
        }
    }
}
