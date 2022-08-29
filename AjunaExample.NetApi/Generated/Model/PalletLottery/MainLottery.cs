//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Ajuna.NetApi;
using Ajuna.NetApi.Model.Extrinsics;
using Ajuna.NetApi.Model.Meta;
using Ajuna.NetApi.Model.Types;
using Ajuna.NetApi.Model.Types.Base;
using Ajuna.NetApi.Model.Types.Primitive;
using SubstrateNET.NetApi.Generated.Model.NodeRuntime;
using SubstrateNET.NetApi.Generated.Model.PalletLottery;
using SubstrateNET.NetApi.Generated.Model.SpCore;
using SubstrateNET.NetApi.Generated.Model.SpRuntime;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;


namespace SubstrateNET.NetApi.Generated.Model.PalletLottery
{
    
    
    public sealed class LotteryStorage
    {
        
        // Substrate client for the storage calls.
        private SubstrateClientExt _client;
        
        public LotteryStorage(SubstrateClientExt client)
        {
            this._client = client;
            _client.StorageKeyDict.Add(new System.Tuple<string, string>("Lottery", "LotteryIndex"), new System.Tuple<Ajuna.NetApi.Model.Meta.Storage.Hasher[], System.Type, System.Type>(null, null, typeof(Ajuna.NetApi.Model.Types.Primitive.U32)));
            _client.StorageKeyDict.Add(new System.Tuple<string, string>("Lottery", "Lottery"), new System.Tuple<Ajuna.NetApi.Model.Meta.Storage.Hasher[], System.Type, System.Type>(null, null, typeof(SubstrateNET.NetApi.Generated.Model.PalletLottery.LotteryConfig)));
            _client.StorageKeyDict.Add(new System.Tuple<string, string>("Lottery", "Participants"), new System.Tuple<Ajuna.NetApi.Model.Meta.Storage.Hasher[], System.Type, System.Type>(new Ajuna.NetApi.Model.Meta.Storage.Hasher[] {
                            Ajuna.NetApi.Model.Meta.Storage.Hasher.Twox64Concat}, typeof(SubstrateNET.NetApi.Generated.Model.SpCore.AccountId32), typeof(BaseTuple<Ajuna.NetApi.Model.Types.Primitive.U32,SubstrateNET.NetApi.Generated.Model.SpRuntime.BoundedVecT31>)));
            _client.StorageKeyDict.Add(new System.Tuple<string, string>("Lottery", "TicketsCount"), new System.Tuple<Ajuna.NetApi.Model.Meta.Storage.Hasher[], System.Type, System.Type>(null, null, typeof(Ajuna.NetApi.Model.Types.Primitive.U32)));
            _client.StorageKeyDict.Add(new System.Tuple<string, string>("Lottery", "Tickets"), new System.Tuple<Ajuna.NetApi.Model.Meta.Storage.Hasher[], System.Type, System.Type>(new Ajuna.NetApi.Model.Meta.Storage.Hasher[] {
                            Ajuna.NetApi.Model.Meta.Storage.Hasher.Twox64Concat}, typeof(Ajuna.NetApi.Model.Types.Primitive.U32), typeof(SubstrateNET.NetApi.Generated.Model.SpCore.AccountId32)));
            _client.StorageKeyDict.Add(new System.Tuple<string, string>("Lottery", "CallIndices"), new System.Tuple<Ajuna.NetApi.Model.Meta.Storage.Hasher[], System.Type, System.Type>(null, null, typeof(SubstrateNET.NetApi.Generated.Model.SpRuntime.BoundedVecT31)));
        }
        
        /// <summary>
        /// >> LotteryIndexParams
        /// </summary>
        public static string LotteryIndexParams()
        {
            return RequestGenerator.GetStorage("Lottery", "LotteryIndex", Ajuna.NetApi.Model.Meta.Storage.Type.Plain);
        }
        
        /// <summary>
        /// >> LotteryIndex
        /// </summary>
        public async Task<Ajuna.NetApi.Model.Types.Primitive.U32> LotteryIndex(CancellationToken token)
        {
            string parameters = LotteryStorage.LotteryIndexParams();
            return await _client.GetStorageAsync<Ajuna.NetApi.Model.Types.Primitive.U32>(parameters, token);
        }
        
        /// <summary>
        /// >> LotteryParams
        ///  The configuration for the current lottery.
        /// </summary>
        public static string LotteryParams()
        {
            return RequestGenerator.GetStorage("Lottery", "Lottery", Ajuna.NetApi.Model.Meta.Storage.Type.Plain);
        }
        
        /// <summary>
        /// >> Lottery
        ///  The configuration for the current lottery.
        /// </summary>
        public async Task<SubstrateNET.NetApi.Generated.Model.PalletLottery.LotteryConfig> Lottery(CancellationToken token)
        {
            string parameters = LotteryStorage.LotteryParams();
            return await _client.GetStorageAsync<SubstrateNET.NetApi.Generated.Model.PalletLottery.LotteryConfig>(parameters, token);
        }
        
        /// <summary>
        /// >> ParticipantsParams
        ///  Users who have purchased a ticket. (Lottery Index, Tickets Purchased)
        /// </summary>
        public static string ParticipantsParams(SubstrateNET.NetApi.Generated.Model.SpCore.AccountId32 key)
        {
            return RequestGenerator.GetStorage("Lottery", "Participants", Ajuna.NetApi.Model.Meta.Storage.Type.Map, new Ajuna.NetApi.Model.Meta.Storage.Hasher[] {
                        Ajuna.NetApi.Model.Meta.Storage.Hasher.Twox64Concat}, new Ajuna.NetApi.Model.Types.IType[] {
                        key});
        }
        
        /// <summary>
        /// >> Participants
        ///  Users who have purchased a ticket. (Lottery Index, Tickets Purchased)
        /// </summary>
        public async Task<BaseTuple<Ajuna.NetApi.Model.Types.Primitive.U32,SubstrateNET.NetApi.Generated.Model.SpRuntime.BoundedVecT31>> Participants(SubstrateNET.NetApi.Generated.Model.SpCore.AccountId32 key, CancellationToken token)
        {
            string parameters = LotteryStorage.ParticipantsParams(key);
            return await _client.GetStorageAsync<BaseTuple<Ajuna.NetApi.Model.Types.Primitive.U32,SubstrateNET.NetApi.Generated.Model.SpRuntime.BoundedVecT31>>(parameters, token);
        }
        
        /// <summary>
        /// >> TicketsCountParams
        ///  Total number of tickets sold.
        /// </summary>
        public static string TicketsCountParams()
        {
            return RequestGenerator.GetStorage("Lottery", "TicketsCount", Ajuna.NetApi.Model.Meta.Storage.Type.Plain);
        }
        
        /// <summary>
        /// >> TicketsCount
        ///  Total number of tickets sold.
        /// </summary>
        public async Task<Ajuna.NetApi.Model.Types.Primitive.U32> TicketsCount(CancellationToken token)
        {
            string parameters = LotteryStorage.TicketsCountParams();
            return await _client.GetStorageAsync<Ajuna.NetApi.Model.Types.Primitive.U32>(parameters, token);
        }
        
        /// <summary>
        /// >> TicketsParams
        ///  Each ticket's owner.
        /// 
        ///  May have residual storage from previous lotteries. Use `TicketsCount` to see which ones
        ///  are actually valid ticket mappings.
        /// </summary>
        public static string TicketsParams(Ajuna.NetApi.Model.Types.Primitive.U32 key)
        {
            return RequestGenerator.GetStorage("Lottery", "Tickets", Ajuna.NetApi.Model.Meta.Storage.Type.Map, new Ajuna.NetApi.Model.Meta.Storage.Hasher[] {
                        Ajuna.NetApi.Model.Meta.Storage.Hasher.Twox64Concat}, new Ajuna.NetApi.Model.Types.IType[] {
                        key});
        }
        
        /// <summary>
        /// >> Tickets
        ///  Each ticket's owner.
        /// 
        ///  May have residual storage from previous lotteries. Use `TicketsCount` to see which ones
        ///  are actually valid ticket mappings.
        /// </summary>
        public async Task<SubstrateNET.NetApi.Generated.Model.SpCore.AccountId32> Tickets(Ajuna.NetApi.Model.Types.Primitive.U32 key, CancellationToken token)
        {
            string parameters = LotteryStorage.TicketsParams(key);
            return await _client.GetStorageAsync<SubstrateNET.NetApi.Generated.Model.SpCore.AccountId32>(parameters, token);
        }
        
        /// <summary>
        /// >> CallIndicesParams
        ///  The calls stored in this pallet to be used in an active lottery if configured
        ///  by `Config::ValidateCall`.
        /// </summary>
        public static string CallIndicesParams()
        {
            return RequestGenerator.GetStorage("Lottery", "CallIndices", Ajuna.NetApi.Model.Meta.Storage.Type.Plain);
        }
        
        /// <summary>
        /// >> CallIndices
        ///  The calls stored in this pallet to be used in an active lottery if configured
        ///  by `Config::ValidateCall`.
        /// </summary>
        public async Task<SubstrateNET.NetApi.Generated.Model.SpRuntime.BoundedVecT31> CallIndices(CancellationToken token)
        {
            string parameters = LotteryStorage.CallIndicesParams();
            return await _client.GetStorageAsync<SubstrateNET.NetApi.Generated.Model.SpRuntime.BoundedVecT31>(parameters, token);
        }
    }
    
    public sealed class LotteryCalls
    {
        
        /// <summary>
        /// >> buy_ticket
        /// Contains one variant per dispatchable that can be called by an extrinsic.
        /// </summary>
        public static Method BuyTicket(SubstrateNET.NetApi.Generated.Model.NodeRuntime.EnumNodeCall call)
        {
            System.Collections.Generic.List<byte> byteArray = new List<byte>();
            byteArray.AddRange(call.Encode());
            return new Method(38, "Lottery", 0, "buy_ticket", byteArray.ToArray());
        }
        
        /// <summary>
        /// >> set_calls
        /// Contains one variant per dispatchable that can be called by an extrinsic.
        /// </summary>
        public static Method SetCalls(BaseVec<SubstrateNET.NetApi.Generated.Model.NodeRuntime.EnumNodeCall> calls)
        {
            System.Collections.Generic.List<byte> byteArray = new List<byte>();
            byteArray.AddRange(calls.Encode());
            return new Method(38, "Lottery", 1, "set_calls", byteArray.ToArray());
        }
        
        /// <summary>
        /// >> start_lottery
        /// Contains one variant per dispatchable that can be called by an extrinsic.
        /// </summary>
        public static Method StartLottery(Ajuna.NetApi.Model.Types.Primitive.U128 price, Ajuna.NetApi.Model.Types.Primitive.U32 length, Ajuna.NetApi.Model.Types.Primitive.U32 delay, Ajuna.NetApi.Model.Types.Primitive.Bool repeat)
        {
            System.Collections.Generic.List<byte> byteArray = new List<byte>();
            byteArray.AddRange(price.Encode());
            byteArray.AddRange(length.Encode());
            byteArray.AddRange(delay.Encode());
            byteArray.AddRange(repeat.Encode());
            return new Method(38, "Lottery", 2, "start_lottery", byteArray.ToArray());
        }
        
        /// <summary>
        /// >> stop_repeat
        /// Contains one variant per dispatchable that can be called by an extrinsic.
        /// </summary>
        public static Method StopRepeat()
        {
            System.Collections.Generic.List<byte> byteArray = new List<byte>();
            return new Method(38, "Lottery", 3, "stop_repeat", byteArray.ToArray());
        }
    }
    
    public enum LotteryErrors
    {
        
        /// <summary>
        /// >> NotConfigured
        /// A lottery has not been configured.
        /// </summary>
        NotConfigured,
        
        /// <summary>
        /// >> InProgress
        /// A lottery is already in progress.
        /// </summary>
        InProgress,
        
        /// <summary>
        /// >> AlreadyEnded
        /// A lottery has already ended.
        /// </summary>
        AlreadyEnded,
        
        /// <summary>
        /// >> InvalidCall
        /// The call is not valid for an open lottery.
        /// </summary>
        InvalidCall,
        
        /// <summary>
        /// >> AlreadyParticipating
        /// You are already participating in the lottery with this call.
        /// </summary>
        AlreadyParticipating,
        
        /// <summary>
        /// >> TooManyCalls
        /// Too many calls for a single lottery.
        /// </summary>
        TooManyCalls,
        
        /// <summary>
        /// >> EncodingFailed
        /// Failed to encode calls
        /// </summary>
        EncodingFailed,
    }
}
