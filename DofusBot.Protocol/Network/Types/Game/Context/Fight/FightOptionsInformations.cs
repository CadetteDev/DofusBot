//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DofusBot.Protocol.Network.Types.Game.Context.Fight
{
    using System.Collections.Generic;
    using DofusBot.Protocol.Network.Messages;
    using DofusBot.Protocol.Network.Types;
    using DofusBot.Protocol;
    
    
    public class FightOptionsInformations : NetworkType
    {
        
        public const int ProtocolId = 20;
        
        public override int TypeID
        {
            get
            {
                return ProtocolId;
            }
        }
        
        private bool m_isSecret;
        
        public virtual bool IsSecret
        {
            get
            {
                return m_isSecret;
            }
            set
            {
                m_isSecret = value;
            }
        }
        
        private bool m_isRestrictedToPartyOnly;
        
        public virtual bool IsRestrictedToPartyOnly
        {
            get
            {
                return m_isRestrictedToPartyOnly;
            }
            set
            {
                m_isRestrictedToPartyOnly = value;
            }
        }
        
        private bool m_isClosed;
        
        public virtual bool IsClosed
        {
            get
            {
                return m_isClosed;
            }
            set
            {
                m_isClosed = value;
            }
        }
        
        private bool m_isAskingForHelp;
        
        public virtual bool IsAskingForHelp
        {
            get
            {
                return m_isAskingForHelp;
            }
            set
            {
                m_isAskingForHelp = value;
            }
        }
        
        public FightOptionsInformations(bool isSecret, bool isRestrictedToPartyOnly, bool isClosed, bool isAskingForHelp)
        {
            m_isSecret = isSecret;
            m_isRestrictedToPartyOnly = isRestrictedToPartyOnly;
            m_isClosed = isClosed;
            m_isAskingForHelp = isAskingForHelp;
        }
        
        public FightOptionsInformations()
        {
        }
        
        public override void Serialize(IDataWriter writer)
        {
            byte flag = new byte();
            BooleanByteWrapper.SetFlag(0, flag, m_isSecret);
            BooleanByteWrapper.SetFlag(1, flag, m_isRestrictedToPartyOnly);
            BooleanByteWrapper.SetFlag(2, flag, m_isClosed);
            BooleanByteWrapper.SetFlag(3, flag, m_isAskingForHelp);
            writer.WriteByte(flag);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            byte flag = reader.ReadByte();
            m_isSecret = BooleanByteWrapper.GetFlag(flag, 0);
            m_isRestrictedToPartyOnly = BooleanByteWrapper.GetFlag(flag, 1);
            m_isClosed = BooleanByteWrapper.GetFlag(flag, 2);
            m_isAskingForHelp = BooleanByteWrapper.GetFlag(flag, 3);
        }
    }
}
