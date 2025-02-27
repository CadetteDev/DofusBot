//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DofusBot.Protocol.Network.Types.Game.Shortcut
{
    using System.Collections.Generic;
    using DofusBot.Protocol.Network.Messages;
    using DofusBot.Protocol.Network.Types;
    using DofusBot.Protocol;
    
    
    public class ShortcutEmote : Shortcut
    {
        
        public const int ProtocolId = 389;
        
        public override int TypeID
        {
            get
            {
                return ProtocolId;
            }
        }
        
        private sbyte m_emoteId;
        
        public virtual sbyte EmoteId
        {
            get
            {
                return m_emoteId;
            }
            set
            {
                m_emoteId = value;
            }
        }
        
        public ShortcutEmote(sbyte emoteId)
        {
            m_emoteId = emoteId;
        }
        
        public ShortcutEmote()
        {
        }
        
        public override void Serialize(IDataWriter writer)
        {
            base.Serialize(writer);
            writer.WriteSByte(m_emoteId);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            base.Deserialize(reader);
            m_emoteId = reader.ReadSByte();
        }
    }
}
