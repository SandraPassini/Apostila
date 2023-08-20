using System.Text.Json.Serialization;

namespace LeituraApostila
{
    public class LerArquivoResponse
    {
        [JsonPropertyName("data_leitura")]
        public DateTime DataLeitura { get; set; }

        [JsonPropertyName("numero_pagina_atual")]
        public int NumeroPaginaAtual { get; set; }

        [JsonPropertyName("numero_pagina_mostrar")]
        public int NumeroPaginaMostrar => NumeroPaginaAtual + 11;

        [JsonPropertyName("numero_pagina_total")]
        public int NumeroPaginaTotal { get; set; }
    }
}