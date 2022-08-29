//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AjunaExample.RestClient.Generated.Clients
{
   using System;
   using System.Threading.Tasks;
   using System.Net.Http;
   using Ajuna.NetApi.Model.Types.Primitive;
   using AjunaExample.RestClient.Generated.Interfaces;
   
   public sealed class TimestampControllerClient : BaseClient, ITimestampControllerClient
   {
      private HttpClient _httpClient;
      private BaseSubscriptionClient _subscriptionClient;
      public TimestampControllerClient(HttpClient httpClient, BaseSubscriptionClient subscriptionClient)
      {
         _httpClient = httpClient;
         _subscriptionClient = subscriptionClient;
      }
      public async Task<U64> GetNow()
      {
         return await SendRequestAsync<U64>(_httpClient, "timestamp/now");
      }
      public async Task<bool> SubscribeNow()
      {
         return await _subscriptionClient.SubscribeAsync("Timestamp.Now");
      }
      public async Task<Bool> GetDidUpdate()
      {
         return await SendRequestAsync<Bool>(_httpClient, "timestamp/didupdate");
      }
      public async Task<bool> SubscribeDidUpdate()
      {
         return await _subscriptionClient.SubscribeAsync("Timestamp.DidUpdate");
      }
   }
}
