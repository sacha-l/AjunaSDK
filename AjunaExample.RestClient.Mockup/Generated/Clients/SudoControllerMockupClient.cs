//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AjunaExample.RestClient.Mockup.Generated.Clients
{
   using System;
   using System.Threading.Tasks;
   using System.Net.Http;
   using AjunaExample.NetApiExt.Generated.Model.sp_core.crypto;
   using AjunaExample.RestClient.Mockup.Generated.Interfaces;
   
   public sealed class SudoControllerMockupClient : MockupBaseClient, ISudoControllerMockupClient
   {
      private HttpClient _httpClient;
      public SudoControllerMockupClient(HttpClient httpClient)
      {
         _httpClient = httpClient;
      }
      public async Task<bool> SetKey(AccountId32 value)
      {
         return await SendMockupRequestAsync(_httpClient, "Sudo/Key", value.Encode(), AjunaExample.NetApiExt.Generated.Storage.SudoStorage.KeyParams());
      }
   }
}
