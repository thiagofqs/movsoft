using Newtonsoft.Json;

namespace MovSoft.Classes
{
    internal class CepModel
    {
        [JsonProperty(PropertyName = "Cep")]
        public string Cep { get; set; }

        [JsonProperty(PropertyName = "Logradouro")]
        public string Logradouro { get; set; }

        [JsonProperty(PropertyName = "Bairro")]
        public string Bairro { get; set; }


        [JsonProperty(PropertyName = "Complemento")]
        public string Complemento { get; set; }

        [JsonProperty(PropertyName = "Localidade")]
        public string Localidade { get; set; }

        [JsonProperty(PropertyName = "Uf")]
        public string Uf { get; set; }
    }
}