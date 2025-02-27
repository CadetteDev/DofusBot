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
    
    
    public class ExchangeShopStockMovementRemovedMessage : NetworkMessage
    {
        
        public const int ProtocolId = 5907;
        
        public override int MessageID
        {
            get
            {
                return ProtocolId;
            }
        }
        
        private uint m_objectId;
        
        public virtual uint ObjectId
        {
            get
            {
                return m_objectId;
            }
            set
            {
                m_objectId = value;
            }
        }
        
        public ExchangeShopStockMovementRemovedMessage(uint objectId)
        {
            m_objectId = objectId;
        }
        
        public ExchangeShopStockMovementRemovedMessage()
        {
        }
        
        public override void Serialize(IDataWriter writer)
        {
            writer.WriteVarUhInt(m_objectId);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            m_objectId = reader.ReadVarUhInt();
        }
    }
}
