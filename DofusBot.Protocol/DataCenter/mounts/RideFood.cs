//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DofusBot.Protocol.DataCenter
{
    using System.Collections.Generic;
    using DofusBot.Protocol;
    using System;
    
    
    [Serializable()]
    public class RideFood : IData
    {
        
        public virtual uint Gid
        {
            get
            {
                return mGid;
            }
            set
            {
                mGid = value;
            }
        }
        
        private uint mGid;
        
        public virtual uint TypeId
        {
            get
            {
                return mTypeId;
            }
            set
            {
                mTypeId = value;
            }
        }
        
        private uint mTypeId;
        
        public RideFood()
        {
        }
    }
}
