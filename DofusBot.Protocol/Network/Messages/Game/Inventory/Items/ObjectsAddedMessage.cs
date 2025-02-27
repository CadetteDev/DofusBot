//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DofusBot.Protocol.Network.Messages.Game.Inventory.Items
{
    using DofusBot.Protocol.Network.Types.Game.Data.Items;
    using System.Collections.Generic;
    using DofusBot.Protocol.Network.Messages;
    using DofusBot.Protocol.Network.Types;
    using DofusBot.Protocol;
    
    
    public class ObjectsAddedMessage : NetworkMessage
    {
        
        public const int ProtocolId = 6033;
        
        public override int MessageID
        {
            get
            {
                return ProtocolId;
            }
        }
        
        private List<ObjectItem> m_object;
        
        public virtual List<ObjectItem> Object
        {
            get
            {
                return m_object;
            }
            set
            {
                m_object = value;
            }
        }
        
        public ObjectsAddedMessage(List<ObjectItem> @object)
        {
            m_object = @object;
        }
        
        public ObjectsAddedMessage()
        {
        }
        
        public override void Serialize(IDataWriter writer)
        {
            writer.WriteShort(((short)(m_object.Count)));
            int objectIndex;
            for (objectIndex = 0; (objectIndex < m_object.Count); objectIndex = (objectIndex + 1))
            {
                ObjectItem objectToSend = m_object[objectIndex];
                objectToSend.Serialize(writer);
            }
        }
        
        public override void Deserialize(IDataReader reader)
        {
            int objectCount = reader.ReadUShort();
            int objectIndex;
            m_object = new System.Collections.Generic.List<ObjectItem>();
            for (objectIndex = 0; (objectIndex < objectCount); objectIndex = (objectIndex + 1))
            {
                ObjectItem objectToAdd = new ObjectItem();
                objectToAdd.Deserialize(reader);
                m_object.Add(objectToAdd);
            }
        }
    }
}
