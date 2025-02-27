//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DofusBot.Protocol.Network.Types.Game.Inventory.Preset
{
    using System.Collections.Generic;
    using DofusBot.Protocol.Network.Messages;
    using DofusBot.Protocol.Network.Types;
    using DofusBot.Protocol;
    
    
    public class IdolsPreset : NetworkType
    {
        
        public const int ProtocolId = 491;
        
        public override int TypeID
        {
            get
            {
                return ProtocolId;
            }
        }
        
        private List<System.UInt16> m_idolId;
        
        public virtual List<System.UInt16> IdolId
        {
            get
            {
                return m_idolId;
            }
            set
            {
                m_idolId = value;
            }
        }
        
        private byte m_presetId;
        
        public virtual byte PresetId
        {
            get
            {
                return m_presetId;
            }
            set
            {
                m_presetId = value;
            }
        }
        
        private byte m_symbolId;
        
        public virtual byte SymbolId
        {
            get
            {
                return m_symbolId;
            }
            set
            {
                m_symbolId = value;
            }
        }
        
        public IdolsPreset(List<System.UInt16> idolId, byte presetId, byte symbolId)
        {
            m_idolId = idolId;
            m_presetId = presetId;
            m_symbolId = symbolId;
        }
        
        public IdolsPreset()
        {
        }
        
        public override void Serialize(IDataWriter writer)
        {
            writer.WriteShort(((short)(m_idolId.Count)));
            int idolIdIndex;
            for (idolIdIndex = 0; (idolIdIndex < m_idolId.Count); idolIdIndex = (idolIdIndex + 1))
            {
                writer.WriteVarUhShort(m_idolId[idolIdIndex]);
            }
            writer.WriteByte(m_presetId);
            writer.WriteByte(m_symbolId);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            int idolIdCount = reader.ReadUShort();
            int idolIdIndex;
            m_idolId = new System.Collections.Generic.List<ushort>();
            for (idolIdIndex = 0; (idolIdIndex < idolIdCount); idolIdIndex = (idolIdIndex + 1))
            {
                m_idolId.Add(reader.ReadVarUhShort());
            }
            m_presetId = reader.ReadByte();
            m_symbolId = reader.ReadByte();
        }
    }
}
