//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DofusBot.Protocol.Network.Messages.Game.Inventory.Exchanges
{
    using System.Collections.Generic;
    using DofusBot.Protocol.Network.Messages;
    using DofusBot.Protocol.Network.Types;
    using DofusBot.Protocol;
    
    
    public class ExchangeReplayCountModifiedMessage : NetworkMessage
    {
        
        public const int ProtocolId = 6023;
        
        public override int MessageID
        {
            get
            {
                return ProtocolId;
            }
        }
        
        private int m_count;
        
        public virtual int Count
        {
            get
            {
                return m_count;
            }
            set
            {
                m_count = value;
            }
        }
        
        public ExchangeReplayCountModifiedMessage(int count)
        {
            m_count = count;
        }
        
        public ExchangeReplayCountModifiedMessage()
        {
        }
        
        public override void Serialize(IDataWriter writer)
        {
            writer.WriteVarInt(m_count);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            m_count = reader.ReadVarInt();
        }
    }
}
