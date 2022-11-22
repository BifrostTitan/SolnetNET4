using Newtonsoft.Json;
using Solnet.KeyStore.Model;

namespace Solnet.KeyStore.Serialization
{
    public static class JsonKeyStoreScryptSerializer
    {
        public static string SerializeScrypt(KeyStore<ScryptParams> scryptKeyStore)
        {
            return JsonConvert.SerializeObject(scryptKeyStore);
        }

        public static KeyStore<ScryptParams> DeserializeScrypt(string json)
        {
            return JsonConvert.DeserializeObject<KeyStore<ScryptParams>>(json);
        }
    }
}