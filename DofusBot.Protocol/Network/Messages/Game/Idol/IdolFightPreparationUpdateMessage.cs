//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DofusBot.Protocol.Network.Messages.Game.Idol
{
    using DofusBot.Protocol.Network.Types.Game.Idol;
    using DofusBot.Protocol.Network;
    using System.Collections.Generic;
    using DofusBot.Protocol.Network.Messages;
    using DofusBot.Protocol.Network.Types;
    using DofusBot.Protocol;
    
    
    public class IdolFightPreparationUpdateMessage : NetworkMessage
    {
        
        public const int ProtocolId = 6586;
        
        public override int MessageID
        {
            get
            {
                return ProtocolId;
            }
        }
        
        private List<Idol> m_idols;
        
        public virtual List<Idol> Idols
        {
            get
            {
                return m_idols;
            }
            set
            {
                m_idols = value;
            }
        }
        
        private byte m_idolSource;
        
        public virtual byte IdolSource
        {
            get
            {
                return m_idolSource;
            }
            set
            {
                m_idolSource = value;
            }
        }
        
        public IdolFightPreparationUpdateMessage(List<Idol> idols, byte idolSource)
        {
            m_idols = idols;
            m_idolSource = idolSource;
        }
        
        public IdolFightPreparationUpdateMessage()
        {
        }
        
        public override void Serialize(IDataWriter writer)
        {
            writer.WriteShort(((short)(m_idols.Count)));
            int idolsIndex;
            for (idolsIndex = 0; (idolsIndex < m_idols.Count); idolsIndex = (idolsIndex + 1))
            {
                Idol objectToSend = m_idols[idolsIndex];
                writer.WriteUShort(((ushort)(objectToSend.TypeID)));
                objectToSend.Serialize(writer);
            }
            writer.WriteByte(m_idolSource);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            int idolsCount = reader.ReadUShort();
            int idolsIndex;
            m_idols = new System.Collections.Generic.List<Idol>();
            for (idolsIndex = 0; (idolsIndex < idolsCount); idolsIndex = (idolsIndex + 1))
            {
                Idol objectToAdd = ProtocolManager.GetTypeInstance<Idol>(reader.ReadUShort());
                objectToAdd.Deserialize(reader);
                m_idols.Add(objectToAdd);
            }
            m_idolSource = reader.ReadByte();
        }
    }
}
