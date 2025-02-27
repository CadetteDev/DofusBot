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
    using DofusBot.Protocol.Network.Types.Game.Data.Items;
    using System.Collections.Generic;
    using DofusBot.Protocol.Network.Messages;
    using DofusBot.Protocol.Network.Types;
    using DofusBot.Protocol;
    
    
    public class ExchangeShopStockMovementUpdatedMessage : NetworkMessage
    {
        
        public const int ProtocolId = 5909;
        
        public override int MessageID
        {
            get
            {
                return ProtocolId;
            }
        }
        
        private ObjectItemToSell m_objectInfo;
        
        public virtual ObjectItemToSell ObjectInfo
        {
            get
            {
                return m_objectInfo;
            }
            set
            {
                m_objectInfo = value;
            }
        }
        
        public ExchangeShopStockMovementUpdatedMessage(ObjectItemToSell objectInfo)
        {
            m_objectInfo = objectInfo;
        }
        
        public ExchangeShopStockMovementUpdatedMessage()
        {
        }
        
        public override void Serialize(IDataWriter writer)
        {
            m_objectInfo.Serialize(writer);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            m_objectInfo = new ObjectItemToSell();
            m_objectInfo.Deserialize(reader);
        }
    }
}
