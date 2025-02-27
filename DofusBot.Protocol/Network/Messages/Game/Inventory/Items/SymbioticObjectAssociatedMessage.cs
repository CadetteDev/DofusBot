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
    using System.Collections.Generic;
    using DofusBot.Protocol.Network.Messages;
    using DofusBot.Protocol.Network.Types;
    using DofusBot.Protocol;
    
    
    public class SymbioticObjectAssociatedMessage : NetworkMessage
    {
        
        public const int ProtocolId = 6527;
        
        public override int MessageID
        {
            get
            {
                return ProtocolId;
            }
        }
        
        private uint m_hostUID;
        
        public virtual uint HostUID
        {
            get
            {
                return m_hostUID;
            }
            set
            {
                m_hostUID = value;
            }
        }
        
        public SymbioticObjectAssociatedMessage(uint hostUID)
        {
            m_hostUID = hostUID;
        }
        
        public SymbioticObjectAssociatedMessage()
        {
        }
        
        public override void Serialize(IDataWriter writer)
        {
            writer.WriteVarUhInt(m_hostUID);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            m_hostUID = reader.ReadVarUhInt();
        }
    }
}
