//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DofusBot.Protocol.Network.Messages.Web.Ankabox
{
    using System.Collections.Generic;
    using DofusBot.Protocol.Network.Messages;
    using DofusBot.Protocol.Network.Types;
    using DofusBot.Protocol;
    
    
    public class MailStatusMessage : NetworkMessage
    {
        
        public const int ProtocolId = 6275;
        
        public override int MessageID
        {
            get
            {
                return ProtocolId;
            }
        }
        
        private ushort m_unread;
        
        public virtual ushort Unread
        {
            get
            {
                return m_unread;
            }
            set
            {
                m_unread = value;
            }
        }
        
        private ushort m_total;
        
        public virtual ushort Total
        {
            get
            {
                return m_total;
            }
            set
            {
                m_total = value;
            }
        }
        
        public MailStatusMessage(ushort unread, ushort total)
        {
            m_unread = unread;
            m_total = total;
        }
        
        public MailStatusMessage()
        {
        }
        
        public override void Serialize(IDataWriter writer)
        {
            writer.WriteVarUhShort(m_unread);
            writer.WriteVarUhShort(m_total);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            m_unread = reader.ReadVarUhShort();
            m_total = reader.ReadVarUhShort();
        }
    }
}
