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


namespace AjunaExample.NetApiExt.Generated.Model.pallet_template.pallet
{
    
    
    public enum Event
    {
        
        SomethingStored = 0,
    }
    
    /// <summary>
    /// >> 39 - Variant[pallet_template.pallet.Event]
    /// 
    ///			The [event](https://docs.substrate.io/main-docs/build/events-errors/) emitted
    ///			by this pallet.
    ///			
    /// </summary>
    public sealed class EnumEvent : BaseEnumExt<Event, BaseTuple<Ajuna.NetApi.Model.Types.Primitive.U32, AjunaExample.NetApiExt.Generated.Model.sp_core.crypto.AccountId32>>
    {
    }
}
