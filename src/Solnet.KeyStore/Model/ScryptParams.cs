using Newtonsoft.Json;

namespace Solnet.KeyStore.Model
{
    public class ScryptParams : KdfParams
    {
        [JsonProperty("n")]
        public int N { get; init; }

        [JsonProperty("r")]
        public int R { get; init; }

        [JsonProperty("p")]
        public int P { get; init; }
    }
}