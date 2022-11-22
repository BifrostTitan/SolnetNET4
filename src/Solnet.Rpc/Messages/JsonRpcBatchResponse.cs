using System.Collections.Generic;

namespace Solnet.Rpc.Messages
{
    /// <summary>
    /// This class represents the response from a request containing a batch of JSON RPC requests
    /// </summary>
    public class JsonRpcBatchResponse : List<JsonRpcBatchResponseItem>
    {
    }
}
