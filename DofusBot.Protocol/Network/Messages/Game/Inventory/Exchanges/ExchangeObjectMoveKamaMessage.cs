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
    
    
    public class ExchangeObjectMoveKamaMessage : NetworkMessage
    {
        
        public const int ProtocolId = 5520;
        
        public override int MessageID
        {
            get
            {
                return ProtocolId;
            }
        }
        
        private long m_quantity;
        
        public virtual long Quantity
        {
            get
            {
                return m_quantity;
            }
            set
            {
                m_quantity = value;
            }
        }
        
        public ExchangeObjectMoveKamaMessage(long quantity)
        {
            m_quantity = quantity;
        }
        
        public ExchangeObjectMoveKamaMessage()
        {
        }
        
        public override void Serialize(IDataWriter writer)
        {
            writer.WriteVarLong(m_quantity);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            m_quantity = reader.ReadVarLong();
        }
    }
}
