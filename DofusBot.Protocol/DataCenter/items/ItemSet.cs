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
    public class ItemSet : IData
    {
        
        public virtual uint Id
        {
            get
            {
                return mId;
            }
            set
            {
                mId = value;
            }
        }
        
        private uint mId;
        
        public virtual List<uint> Items
        {
            get
            {
                return mItems;
            }
            set
            {
                mItems = value;
            }
        }
        
        private List<uint> mItems = new List<uint>();
        
        public virtual uint NameId
        {
            get
            {
                return mNameId;
            }
            set
            {
                mNameId = value;
            }
        }
        
        private uint mNameId;
        
        public virtual List<List<EffectInstance>> Effects
        {
            get
            {
                return mEffects;
            }
            set
            {
                mEffects = value;
            }
        }
        
        private List<List<EffectInstance>> mEffects = new List<List<EffectInstance>>();
        
        public virtual bool BonusIsSecret
        {
            get
            {
                return mBonusIsSecret;
            }
            set
            {
                mBonusIsSecret = value;
            }
        }
        
        private bool mBonusIsSecret;
        
        public ItemSet()
        {
        }
    }
}
