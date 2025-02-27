//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DofusBot.Protocol.Network.Messages.Game.Shortcut
{
    using System.Collections.Generic;
    using DofusBot.Protocol.Network.Messages;
    using DofusBot.Protocol.Network.Types;
    using DofusBot.Protocol;
    
    
    public class ShortcutBarRemoveRequestMessage : NetworkMessage
    {
        
        public const int ProtocolId = 6228;
        
        public override int MessageID
        {
            get
            {
                return ProtocolId;
            }
        }
        
        private byte m_barType;
        
        public virtual byte BarType
        {
            get
            {
                return m_barType;
            }
            set
            {
                m_barType = value;
            }
        }
        
        private byte m_slot;
        
        public virtual byte Slot
        {
            get
            {
                return m_slot;
            }
            set
            {
                m_slot = value;
            }
        }
        
        public ShortcutBarRemoveRequestMessage(byte barType, byte slot)
        {
            m_barType = barType;
            m_slot = slot;
        }
        
        public ShortcutBarRemoveRequestMessage()
        {
        }
        
        public override void Serialize(IDataWriter writer)
        {
            writer.WriteByte(m_barType);
            writer.WriteByte(m_slot);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            m_barType = reader.ReadByte();
            m_slot = reader.ReadByte();
        }
    }
}
