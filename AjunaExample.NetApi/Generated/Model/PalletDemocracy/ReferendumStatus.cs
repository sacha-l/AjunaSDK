//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Ajuna.NetApi.Attributes;
using Ajuna.NetApi.Model.Types.Base;
using Ajuna.NetApi.Model.Types.Metadata.V14;
using Ajuna.NetApi.Model.Types.Primitive;
using SubstrateNET.NetApi.Generated.Model.PalletDemocracy;
using SubstrateNET.NetApi.Generated.Model.PrimitiveTypes;
using System.Collections.Generic;


namespace SubstrateNET.NetApi.Generated.Model.PalletDemocracy
{
    
    
    /// <summary>
    /// >> 448 - Composite[pallet_democracy.types.ReferendumStatus]
    /// </summary>
    [AjunaNodeType(TypeDefEnum.Composite)]
    public sealed class ReferendumStatus : BaseType
    {
        
        /// <summary>
        /// >> end
        /// </summary>
        private Ajuna.NetApi.Model.Types.Primitive.U32 _end;
        
        /// <summary>
        /// >> proposal_hash
        /// </summary>
        private SubstrateNET.NetApi.Generated.Model.PrimitiveTypes.H256 _proposalHash;
        
        /// <summary>
        /// >> threshold
        /// </summary>
        private SubstrateNET.NetApi.Generated.Model.PalletDemocracy.EnumVoteThreshold _threshold;
        
        /// <summary>
        /// >> delay
        /// </summary>
        private Ajuna.NetApi.Model.Types.Primitive.U32 _delay;
        
        /// <summary>
        /// >> tally
        /// </summary>
        private SubstrateNET.NetApi.Generated.Model.PalletDemocracy.Tally _tally;
        
        public Ajuna.NetApi.Model.Types.Primitive.U32 End
        {
            get
            {
                return this._end;
            }
            set
            {
                this._end = value;
            }
        }
        
        public SubstrateNET.NetApi.Generated.Model.PrimitiveTypes.H256 ProposalHash
        {
            get
            {
                return this._proposalHash;
            }
            set
            {
                this._proposalHash = value;
            }
        }
        
        public SubstrateNET.NetApi.Generated.Model.PalletDemocracy.EnumVoteThreshold Threshold
        {
            get
            {
                return this._threshold;
            }
            set
            {
                this._threshold = value;
            }
        }
        
        public Ajuna.NetApi.Model.Types.Primitive.U32 Delay
        {
            get
            {
                return this._delay;
            }
            set
            {
                this._delay = value;
            }
        }
        
        public SubstrateNET.NetApi.Generated.Model.PalletDemocracy.Tally Tally
        {
            get
            {
                return this._tally;
            }
            set
            {
                this._tally = value;
            }
        }
        
        public override string TypeName()
        {
            return "ReferendumStatus";
        }
        
        public override byte[] Encode()
        {
            var result = new List<byte>();
            result.AddRange(End.Encode());
            result.AddRange(ProposalHash.Encode());
            result.AddRange(Threshold.Encode());
            result.AddRange(Delay.Encode());
            result.AddRange(Tally.Encode());
            return result.ToArray();
        }
        
        public override void Decode(byte[] byteArray, ref int p)
        {
            var start = p;
            End = new Ajuna.NetApi.Model.Types.Primitive.U32();
            End.Decode(byteArray, ref p);
            ProposalHash = new SubstrateNET.NetApi.Generated.Model.PrimitiveTypes.H256();
            ProposalHash.Decode(byteArray, ref p);
            Threshold = new SubstrateNET.NetApi.Generated.Model.PalletDemocracy.EnumVoteThreshold();
            Threshold.Decode(byteArray, ref p);
            Delay = new Ajuna.NetApi.Model.Types.Primitive.U32();
            Delay.Decode(byteArray, ref p);
            Tally = new SubstrateNET.NetApi.Generated.Model.PalletDemocracy.Tally();
            Tally.Decode(byteArray, ref p);
            TypeSize = p - start;
        }
    }
}
