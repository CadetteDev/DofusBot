//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DofusBot.Protocol.Network.Types.Game.Context.Fight
{
    using DofusBot.Protocol.Network.Types.Game.Context.Roleplay;
    using System.Collections.Generic;
    using DofusBot.Protocol.Network.Messages;
    using DofusBot.Protocol.Network.Types;
    using DofusBot.Protocol;
    
    
    public class FightResultTaxCollectorListEntry : FightResultFighterListEntry
    {
        
        public const int ProtocolId = 84;
        
        public override int TypeID
        {
            get
            {
                return ProtocolId;
            }
        }
        
        private BasicGuildInformations m_guildInfo;
        
        public virtual BasicGuildInformations GuildInfo
        {
            get
            {
                return m_guildInfo;
            }
            set
            {
                m_guildInfo = value;
            }
        }
        
        private sbyte m_level;
        
        public virtual sbyte Level
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
        
        private int m_experienceForGuild;
        
        public virtual int ExperienceForGuild
        {
            get
            {
                return m_experienceForGuild;
            }
            set
            {
                m_experienceForGuild = value;
            }
        }
        
        public FightResultTaxCollectorListEntry(BasicGuildInformations guildInfo, sbyte level, int experienceForGuild)
        {
            m_guildInfo = guildInfo;
            m_level = level;
            m_experienceForGuild = experienceForGuild;
        }
        
        public FightResultTaxCollectorListEntry()
        {
        }
        
        public override void Serialize(IDataWriter writer)
        {
            base.Serialize(writer);
            m_guildInfo.Serialize(writer);
            writer.WriteSByte(m_level);
            writer.WriteInt(m_experienceForGuild);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            base.Deserialize(reader);
            m_guildInfo = new BasicGuildInformations();
            m_guildInfo.Deserialize(reader);
            m_level = reader.ReadSByte();
            m_experienceForGuild = reader.ReadInt();
        }
    }
}
