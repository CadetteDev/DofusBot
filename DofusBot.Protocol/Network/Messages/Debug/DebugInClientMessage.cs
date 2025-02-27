//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DofusBot.Protocol.Network.Messages.Debug
{
    using System.Collections.Generic;
    using DofusBot.Protocol.Network.Messages;
    using DofusBot.Protocol.Network.Types;
    using DofusBot.Protocol;
    
    
    public class DebugInClientMessage : NetworkMessage
    {
        
        public const int ProtocolId = 6028;
        
        public override int MessageID
        {
            get
            {
                return ProtocolId;
            }
        }
        
        private byte m_level;
        
        public virtual byte Level
        {
            get
            {
                return m_level;
            }
            set
            {
                m_level = value;
            }
        }
        
        private string m_message;
        
        public virtual string Message
        {
            get
            {
                return m_message;
            }
            set
            {
                m_message = value;
            }
        }
        
        public DebugInClientMessage(byte level, string message)
        {
            m_level = level;
            m_message = message;
        }
        
        public DebugInClientMessage()
        {
        }
        
        public override void Serialize(IDataWriter writer)
        {
            writer.WriteByte(m_level);
            writer.WriteUTF(m_message);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            m_level = reader.ReadByte();
            m_message = reader.ReadUTF();
        }
    }
}
