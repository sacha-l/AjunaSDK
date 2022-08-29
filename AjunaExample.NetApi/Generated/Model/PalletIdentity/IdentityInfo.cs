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
using SubstrateNET.NetApi.Generated.Model.Base;
using SubstrateNET.NetApi.Generated.Model.PalletIdentity;
using SubstrateNET.NetApi.Generated.Model.SpRuntime;
using System.Collections.Generic;


namespace SubstrateNET.NetApi.Generated.Model.PalletIdentity
{
    
    
    /// <summary>
    /// >> 275 - Composite[pallet_identity.types.IdentityInfo]
    /// </summary>
    [AjunaNodeType(TypeDefEnum.Composite)]
    public sealed class IdentityInfo : BaseType
    {
        
        /// <summary>
        /// >> additional
        /// </summary>
        private SubstrateNET.NetApi.Generated.Model.SpRuntime.BoundedVecT6 _additional;
        
        /// <summary>
        /// >> display
        /// </summary>
        private SubstrateNET.NetApi.Generated.Model.PalletIdentity.EnumData _display;
        
        /// <summary>
        /// >> legal
        /// </summary>
        private SubstrateNET.NetApi.Generated.Model.PalletIdentity.EnumData _legal;
        
        /// <summary>
        /// >> web
        /// </summary>
        private SubstrateNET.NetApi.Generated.Model.PalletIdentity.EnumData _web;
        
        /// <summary>
        /// >> riot
        /// </summary>
        private SubstrateNET.NetApi.Generated.Model.PalletIdentity.EnumData _riot;
        
        /// <summary>
        /// >> email
        /// </summary>
        private SubstrateNET.NetApi.Generated.Model.PalletIdentity.EnumData _email;
        
        /// <summary>
        /// >> pgp_fingerprint
        /// </summary>
        private BaseOpt<SubstrateNET.NetApi.Generated.Model.Base.Arr20U8> _pgpFingerprint;
        
        /// <summary>
        /// >> image
        /// </summary>
        private SubstrateNET.NetApi.Generated.Model.PalletIdentity.EnumData _image;
        
        /// <summary>
        /// >> twitter
        /// </summary>
        private SubstrateNET.NetApi.Generated.Model.PalletIdentity.EnumData _twitter;
        
        public SubstrateNET.NetApi.Generated.Model.SpRuntime.BoundedVecT6 Additional
        {
            get
            {
                return this._additional;
            }
            set
            {
                this._additional = value;
            }
        }
        
        public SubstrateNET.NetApi.Generated.Model.PalletIdentity.EnumData Display
        {
            get
            {
                return this._display;
            }
            set
            {
                this._display = value;
            }
        }
        
        public SubstrateNET.NetApi.Generated.Model.PalletIdentity.EnumData Legal
        {
            get
            {
                return this._legal;
            }
            set
            {
                this._legal = value;
            }
        }
        
        public SubstrateNET.NetApi.Generated.Model.PalletIdentity.EnumData Web
        {
            get
            {
                return this._web;
            }
            set
            {
                this._web = value;
            }
        }
        
        public SubstrateNET.NetApi.Generated.Model.PalletIdentity.EnumData Riot
        {
            get
            {
                return this._riot;
            }
            set
            {
                this._riot = value;
            }
        }
        
        public SubstrateNET.NetApi.Generated.Model.PalletIdentity.EnumData Email
        {
            get
            {
                return this._email;
            }
            set
            {
                this._email = value;
            }
        }
        
        public BaseOpt<SubstrateNET.NetApi.Generated.Model.Base.Arr20U8> PgpFingerprint
        {
            get
            {
                return this._pgpFingerprint;
            }
            set
            {
                this._pgpFingerprint = value;
            }
        }
        
        public SubstrateNET.NetApi.Generated.Model.PalletIdentity.EnumData Image
        {
            get
            {
                return this._image;
            }
            set
            {
                this._image = value;
            }
        }
        
        public SubstrateNET.NetApi.Generated.Model.PalletIdentity.EnumData Twitter
        {
            get
            {
                return this._twitter;
            }
            set
            {
                this._twitter = value;
            }
        }
        
        public override string TypeName()
        {
            return "IdentityInfo";
        }
        
        public override byte[] Encode()
        {
            var result = new List<byte>();
            result.AddRange(Additional.Encode());
            result.AddRange(Display.Encode());
            result.AddRange(Legal.Encode());
            result.AddRange(Web.Encode());
            result.AddRange(Riot.Encode());
            result.AddRange(Email.Encode());
            result.AddRange(PgpFingerprint.Encode());
            result.AddRange(Image.Encode());
            result.AddRange(Twitter.Encode());
            return result.ToArray();
        }
        
        public override void Decode(byte[] byteArray, ref int p)
        {
            var start = p;
            Additional = new SubstrateNET.NetApi.Generated.Model.SpRuntime.BoundedVecT6();
            Additional.Decode(byteArray, ref p);
            Display = new SubstrateNET.NetApi.Generated.Model.PalletIdentity.EnumData();
            Display.Decode(byteArray, ref p);
            Legal = new SubstrateNET.NetApi.Generated.Model.PalletIdentity.EnumData();
            Legal.Decode(byteArray, ref p);
            Web = new SubstrateNET.NetApi.Generated.Model.PalletIdentity.EnumData();
            Web.Decode(byteArray, ref p);
            Riot = new SubstrateNET.NetApi.Generated.Model.PalletIdentity.EnumData();
            Riot.Decode(byteArray, ref p);
            Email = new SubstrateNET.NetApi.Generated.Model.PalletIdentity.EnumData();
            Email.Decode(byteArray, ref p);
            PgpFingerprint = new BaseOpt<SubstrateNET.NetApi.Generated.Model.Base.Arr20U8>();
            PgpFingerprint.Decode(byteArray, ref p);
            Image = new SubstrateNET.NetApi.Generated.Model.PalletIdentity.EnumData();
            Image.Decode(byteArray, ref p);
            Twitter = new SubstrateNET.NetApi.Generated.Model.PalletIdentity.EnumData();
            Twitter.Decode(byteArray, ref p);
            TypeSize = p - start;
        }
    }
}
