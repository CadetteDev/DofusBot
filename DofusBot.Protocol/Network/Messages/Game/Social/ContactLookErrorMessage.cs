//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DofusBot.Protocol.Network.Messages.Game.Social
{
    using System.Collections.Generic;
    using DofusBot.Protocol.Network.Messages;
    using DofusBot.Protocol.Network.Types;
    using DofusBot.Protocol;
    
    
    public class ContactLookErrorMessage : NetworkMessage
    {
        
        public const int ProtocolId = 6045;
        
        public override int MessageID
        {
            get
            {
                return ProtocolId;
            }
        }
        
        private uint m_requestId;
        
        public virtual uint RequestId
        {
            get
            {
                return m_requestId;
            }
            set
            {
                m_requestId = value;
            }
        }
        
        public ContactLookErrorMessage(uint requestId)
        {
            m_requestId = requestId;
        }
        
        public ContactLookErrorMessage()
        {
        }
        
        public override void Serialize(IDataWriter writer)
        {
            writer.WriteVarUhInt(m_requestId);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            m_requestId = reader.ReadVarUhInt();
        }
    }
}
