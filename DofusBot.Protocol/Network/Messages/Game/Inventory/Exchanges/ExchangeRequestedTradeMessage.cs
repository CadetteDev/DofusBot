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
    
    
    public class ExchangeRequestedTradeMessage : ExchangeRequestedMessage
    {
        
        public const int ProtocolId = 5523;
        
        public override int MessageID
        {
            get
            {
                return ProtocolId;
            }
        }
        
        private ulong m_source;
        
        public virtual ulong Source
        {
            get
            {
                return m_source;
            }
            set
            {
                m_source = value;
            }
        }
        
        private ulong m_target;
        
        public virtual ulong Target
        {
            get
            {
                return m_target;
            }
            set
            {
                m_target = value;
            }
        }
        
        public ExchangeRequestedTradeMessage(ulong source, ulong target)
        {
            m_source = source;
            m_target = target;
        }
        
        public ExchangeRequestedTradeMessage()
        {
        }
        
        public override void Serialize(IDataWriter writer)
        {
            base.Serialize(writer);
            writer.WriteVarUhLong(m_source);
            writer.WriteVarUhLong(m_target);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            base.Deserialize(reader);
            m_source = reader.ReadVarUhLong();
            m_target = reader.ReadVarUhLong();
        }
    }
}
