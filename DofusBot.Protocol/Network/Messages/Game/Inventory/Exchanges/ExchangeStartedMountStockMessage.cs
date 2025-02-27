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
    
    
    public class ExchangeStartedMountStockMessage : NetworkMessage
    {
        
        public const int ProtocolId = 5984;
        
        public override int MessageID
        {
            get
            {
                return ProtocolId;
            }
        }
        
        private List<ObjectItem> m_objectsInfos;
        
        public virtual List<ObjectItem> ObjectsInfos
        {
            get
            {
                return m_objectsInfos;
            }
            set
            {
                m_objectsInfos = value;
            }
        }
        
        public ExchangeStartedMountStockMessage(List<ObjectItem> objectsInfos)
        {
            m_objectsInfos = objectsInfos;
        }
        
        public ExchangeStartedMountStockMessage()
        {
        }
        
        public override void Serialize(IDataWriter writer)
        {
            writer.WriteShort(((short)(m_objectsInfos.Count)));
            int objectsInfosIndex;
            for (objectsInfosIndex = 0; (objectsInfosIndex < m_objectsInfos.Count); objectsInfosIndex = (objectsInfosIndex + 1))
            {
                ObjectItem objectToSend = m_objectsInfos[objectsInfosIndex];
                objectToSend.Serialize(writer);
            }
        }
        
        public override void Deserialize(IDataReader reader)
        {
            int objectsInfosCount = reader.ReadUShort();
            int objectsInfosIndex;
            m_objectsInfos = new System.Collections.Generic.List<ObjectItem>();
            for (objectsInfosIndex = 0; (objectsInfosIndex < objectsInfosCount); objectsInfosIndex = (objectsInfosIndex + 1))
            {
                ObjectItem objectToAdd = new ObjectItem();
                objectToAdd.Deserialize(reader);
                m_objectsInfos.Add(objectToAdd);
            }
        }
    }
}
