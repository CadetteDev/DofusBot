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
    public class ServerCommunity : IData
    {
        
        public virtual int Id
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
        
        private int mId;
        
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
        
        public virtual string ShortId
        {
            get
            {
                return mShortId;
            }
            set
            {
                mShortId = value;
            }
        }
        
        private string mShortId;
        
        public virtual List<String> DefaultCountries
        {
            get
            {
                return mDefaultCountries;
            }
            set
            {
                mDefaultCountries = value;
            }
        }
        
        private List<String> mDefaultCountries = new List<String>();
        
        public virtual List<int> SupportedLangIds
        {
            get
            {
                return mSupportedLangIds;
            }
            set
            {
                mSupportedLangIds = value;
            }
        }
        
        private List<int> mSupportedLangIds = new List<int>();
        
        public virtual int NamingRulePlayerNameId
        {
            get
            {
                return mNamingRulePlayerNameId;
            }
            set
            {
                mNamingRulePlayerNameId = value;
            }
        }
        
        private int mNamingRulePlayerNameId;
        
        public virtual int NamingRuleGuildNameId
        {
            get
            {
                return mNamingRuleGuildNameId;
            }
            set
            {
                mNamingRuleGuildNameId = value;
            }
        }
        
        private int mNamingRuleGuildNameId;
        
        public virtual int NamingRuleAllianceNameId
        {
            get
            {
                return mNamingRuleAllianceNameId;
            }
            set
            {
                mNamingRuleAllianceNameId = value;
            }
        }
        
        private int mNamingRuleAllianceNameId;
        
        public virtual int NamingRuleAllianceTagId
        {
            get
            {
                return mNamingRuleAllianceTagId;
            }
            set
            {
                mNamingRuleAllianceTagId = value;
            }
        }
        
        private int mNamingRuleAllianceTagId;
        
        public virtual int NamingRulePartyNameId
        {
            get
            {
                return mNamingRulePartyNameId;
            }
            set
            {
                mNamingRulePartyNameId = value;
            }
        }
        
        private int mNamingRulePartyNameId;
        
        public virtual int NamingRuleMountNameId
        {
            get
            {
                return mNamingRuleMountNameId;
            }
            set
            {
                mNamingRuleMountNameId = value;
            }
        }
        
        private int mNamingRuleMountNameId;
        
        public virtual int NamingRuleNameGeneratorId
        {
            get
            {
                return mNamingRuleNameGeneratorId;
            }
            set
            {
                mNamingRuleNameGeneratorId = value;
            }
        }
        
        private int mNamingRuleNameGeneratorId;
        
        public virtual int NamingRuleAdminId
        {
            get
            {
                return mNamingRuleAdminId;
            }
            set
            {
                mNamingRuleAdminId = value;
            }
        }
        
        private int mNamingRuleAdminId;
        
        public virtual int NamingRuleModoId
        {
            get
            {
                return mNamingRuleModoId;
            }
            set
            {
                mNamingRuleModoId = value;
            }
        }
        
        private int mNamingRuleModoId;
        
        public ServerCommunity()
        {
        }
    }
}
