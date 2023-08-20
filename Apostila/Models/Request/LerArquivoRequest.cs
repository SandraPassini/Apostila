using Apostila.Models.Enum;
using Microsoft.AspNetCore.Mvc;
using System.Text.Json.Serialization;

namespace LeituraApostila
{
    public class LerArquivoRequest
    {
        [FromRoute]
        [JsonPropertyName("id_apostila")]
        public int IdApostila { get; set; }

        [FromQuery]
        [JsonPropertyName("comando_ler")]
        public ComandoLeituraEnum ComandoLer { get; set; }

        [FromQuery]
        [JsonPropertyName("numero_pagina_atual")]
        public int NumeroPaginaAtual { get; set; }

        [FromQuery]
        [JsonPropertyName("numero_pagina_deseja_ler")]
        public int NumeroPaginaLer { get; set; }
    }
}