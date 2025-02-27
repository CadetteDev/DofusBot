//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DofusBot.Protocol.Network.Messages.Game.Context.Roleplay.Havenbag
{
    using System.Collections.Generic;
    using DofusBot.Protocol.Network.Messages;
    using DofusBot.Protocol.Network.Types;
    using DofusBot.Protocol;
    
    
    public class EnterHavenBagRequestMessage : NetworkMessage
    {
        
        public const int ProtocolId = 6636;
        
        public override int MessageID
        {
            get
            {
                return ProtocolId;
            }
        }
        
        private ulong m_havenBagOwner;
        
        public virtual ulong HavenBagOwner
        {
            get
            {
                return m_havenBagOwner;
            }
            set
            {
                m_havenBagOwner = value;
            }
        }
        
        public EnterHavenBagRequestMessage(ulong havenBagOwner)
        {
            m_havenBagOwner = havenBagOwner;
        }
        
        public EnterHavenBagRequestMessage()
        {
        }
        
        public override void Serialize(IDataWriter writer)
        {
            writer.WriteVarUhLong(m_havenBagOwner);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            m_havenBagOwner = reader.ReadVarUhLong();
        }
    }
}
