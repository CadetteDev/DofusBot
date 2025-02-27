//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DofusBot.Protocol.Network.Messages.Game.Interactive
{
    using DofusBot.Protocol.Network.Types.Game.Interactive;
    using System.Collections.Generic;
    using DofusBot.Protocol.Network.Messages;
    using DofusBot.Protocol.Network.Types;
    using DofusBot.Protocol;
    
    
    public class InteractiveElementUpdatedMessage : NetworkMessage
    {
        
        public const int ProtocolId = 5708;
        
        public override int MessageID
        {
            get
            {
                return ProtocolId;
            }
        }
        
        private InteractiveElement m_interactiveElement;
        
        public virtual InteractiveElement InteractiveElement
        {
            get
            {
                return m_interactiveElement;
            }
            set
            {
                m_interactiveElement = value;
            }
        }
        
        public InteractiveElementUpdatedMessage(InteractiveElement interactiveElement)
        {
            m_interactiveElement = interactiveElement;
        }
        
        public InteractiveElementUpdatedMessage()
        {
        }
        
        public override void Serialize(IDataWriter writer)
        {
            m_interactiveElement.Serialize(writer);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            m_interactiveElement = new InteractiveElement();
            m_interactiveElement.Deserialize(reader);
        }
    }
}
