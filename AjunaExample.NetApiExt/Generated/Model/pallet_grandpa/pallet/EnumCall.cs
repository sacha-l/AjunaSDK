//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Ajuna.NetApi.Model.Types.Base;
using System.Collections.Generic;


namespace AjunaExample.NetApiExt.Generated.Model.pallet_grandpa.pallet
{
    
    
    public enum Call
    {
        
        report_equivocation = 0,
        
        report_equivocation_unsigned = 1,
        
        note_stalled = 2,
    }
    
    /// <summary>
    /// >> 79 - Variant[pallet_grandpa.pallet.Call]
    /// Contains one variant per dispatchable that can be called by an extrinsic.
    /// </summary>
    public sealed class EnumCall : BaseEnumExt<Call, BaseTuple<AjunaExample.NetApiExt.Generated.Model.sp_finality_grandpa.EquivocationProof, Ajuna.NetApi.Model.Types.Base.BaseVoid>, BaseTuple<AjunaExample.NetApiExt.Generated.Model.sp_finality_grandpa.EquivocationProof, Ajuna.NetApi.Model.Types.Base.BaseVoid>, BaseTuple<Ajuna.NetApi.Model.Types.Primitive.U32, Ajuna.NetApi.Model.Types.Primitive.U32>>
    {
    }
}
