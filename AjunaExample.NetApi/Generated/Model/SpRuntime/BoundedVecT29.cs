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
using SubstrateNET.NetApi.Generated.Model.PalletProxy;
using System.Collections.Generic;


namespace SubstrateNET.NetApi.Generated.Model.SpRuntime
{
    
    
    /// <summary>
    /// >> 549 - Composite[sp_runtime.bounded.bounded_vec.BoundedVecT29]
    /// </summary>
    [AjunaNodeType(TypeDefEnum.Composite)]
    public sealed class BoundedVecT29 : BaseType
    {
        
        /// <summary>
        /// >> value
        /// </summary>
        private BaseVec<SubstrateNET.NetApi.Generated.Model.PalletProxy.Announcement> _value;
        
        public BaseVec<SubstrateNET.NetApi.Generated.Model.PalletProxy.Announcement> Value
        {
            get
            {
                return this._value;
            }
            set
            {
                this._value = value;
            }
        }
        
        public override string TypeName()
        {
            return "BoundedVecT29";
        }
        
        public override byte[] Encode()
        {
            var result = new List<byte>();
            result.AddRange(Value.Encode());
            return result.ToArray();
        }
        
        public override void Decode(byte[] byteArray, ref int p)
        {
            var start = p;
            Value = new BaseVec<SubstrateNET.NetApi.Generated.Model.PalletProxy.Announcement>();
            Value.Decode(byteArray, ref p);
            TypeSize = p - start;
        }
    }
}
