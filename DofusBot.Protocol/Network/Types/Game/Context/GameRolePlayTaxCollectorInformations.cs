//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DofusBot.Protocol.Network.Types.Game.Context
{
    using DofusBot.Protocol.Network.Types.Game.Context.Roleplay;
    using DofusBot.Protocol.Network.Types.Game.Look;
    using DofusBot.Protocol.Network;
    using System.Collections.Generic;
    using DofusBot.Protocol.Network.Messages;
    using DofusBot.Protocol.Network.Types;
    using DofusBot.Protocol;
    
    
    public class GameRolePlayTaxCollectorInformations : GameRolePlayActorInformations
    {
        
        public const int ProtocolId = 148;
        
        public override int TypeID
        {
            get
            {
                return ProtocolId;
            }
        }
        
        private TaxCollectorStaticInformations m_identification;
        
        public virtual TaxCollectorStaticInformations Identification
        {
            get
            {
                return m_identification;
            }
            set
            {
                m_identification = value;
            }
        }
        
        private sbyte m_guildLevel;
        
        public virtual sbyte GuildLevel
        {
            get
            {
                return m_guildLevel;
            }
            set
            {
                m_guildLevel = value;
            }
        }
        
        private int m_taxCollectorAttack;
        
        public virtual int TaxCollectorAttack
        {
            get
            {
                return m_taxCollectorAttack;
            }
            set
            {
                m_taxCollectorAttack = value;
            }
        }
        
        public GameRolePlayTaxCollectorInformations(TaxCollectorStaticInformations identification, sbyte guildLevel, int taxCollectorAttack)
        {
            m_identification = identification;
            m_guildLevel = guildLevel;
            m_taxCollectorAttack = taxCollectorAttack;
        }
        
        public GameRolePlayTaxCollectorInformations()
        {
        }
        
        public override void Serialize(IDataWriter writer)
        {
            base.Serialize(writer);
            writer.WriteUShort(((ushort)(m_identification.TypeID)));
            m_identification.Serialize(writer);
            writer.WriteSByte(m_guildLevel);
            writer.WriteInt(m_taxCollectorAttack);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            base.Deserialize(reader);
            m_identification = ProtocolManager.GetTypeInstance<TaxCollectorStaticInformations>(reader.ReadUShort());
            m_identification.Deserialize(reader);
            m_guildLevel = reader.ReadSByte();
            m_taxCollectorAttack = reader.ReadInt();
        }
    }
}
