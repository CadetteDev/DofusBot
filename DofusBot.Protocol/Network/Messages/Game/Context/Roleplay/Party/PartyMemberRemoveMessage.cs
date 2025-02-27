//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DofusBot.Protocol.Network.Messages.Game.Context.Roleplay.Party
{
    using System.Collections.Generic;
    using DofusBot.Protocol.Network.Messages;
    using DofusBot.Protocol.Network.Types;
    using DofusBot.Protocol;
    
    
    public class PartyMemberRemoveMessage : AbstractPartyEventMessage
    {
        
        public const int ProtocolId = 5579;
        
        public override int MessageID
        {
            get
            {
                return ProtocolId;
            }
        }
        
        private ulong m_leavingPlayerId;
        
        public virtual ulong LeavingPlayerId
        {
            get
            {
                return m_leavingPlayerId;
            }
            set
            {
                m_leavingPlayerId = value;
            }
        }
        
        public PartyMemberRemoveMessage(ulong leavingPlayerId)
        {
            m_leavingPlayerId = leavingPlayerId;
        }
        
        public PartyMemberRemoveMessage()
        {
        }
        
        public override void Serialize(IDataWriter writer)
        {
            base.Serialize(writer);
            writer.WriteVarUhLong(m_leavingPlayerId);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            base.Deserialize(reader);
            m_leavingPlayerId = reader.ReadVarUhLong();
        }
    }
}
