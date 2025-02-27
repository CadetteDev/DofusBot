//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DofusBot.Protocol.Network.Messages.Game.Context.Roleplay.Lockable
{
    using System.Collections.Generic;
    using DofusBot.Protocol.Network.Messages;
    using DofusBot.Protocol.Network.Types;
    using DofusBot.Protocol;
    
    
    public class LockableStateUpdateHouseDoorMessage : LockableStateUpdateAbstractMessage
    {
        
        public const int ProtocolId = 5668;
        
        public override int MessageID
        {
            get
            {
                return ProtocolId;
            }
        }
        
        private uint m_houseId;
        
        public virtual uint HouseId
        {
            get
            {
                return m_houseId;
            }
            set
            {
                m_houseId = value;
            }
        }
        
        private int m_instanceId;
        
        public virtual int InstanceId
        {
            get
            {
                return m_instanceId;
            }
            set
            {
                m_instanceId = value;
            }
        }
        
        private bool m_secondHand;
        
        public virtual bool SecondHand
        {
            get
            {
                return m_secondHand;
            }
            set
            {
                m_secondHand = value;
            }
        }
        
        public LockableStateUpdateHouseDoorMessage(uint houseId, int instanceId, bool secondHand)
        {
            m_houseId = houseId;
            m_instanceId = instanceId;
            m_secondHand = secondHand;
        }
        
        public LockableStateUpdateHouseDoorMessage()
        {
        }
        
        public override void Serialize(IDataWriter writer)
        {
            base.Serialize(writer);
            writer.WriteVarUhInt(m_houseId);
            writer.WriteInt(m_instanceId);
            writer.WriteBoolean(m_secondHand);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            base.Deserialize(reader);
            m_houseId = reader.ReadVarUhInt();
            m_instanceId = reader.ReadInt();
            m_secondHand = reader.ReadBoolean();
        }
    }
}
