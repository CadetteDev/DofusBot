//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DofusBot.Protocol.Network.Messages.Game.Guild
{
    using DofusBot.Protocol.Network.Types.Game.Context.Roleplay;
    using DofusBot.Protocol.Network.Types.Game.Social;
    using DofusBot.Protocol.Network.Types.Game.Character;
    using System.Collections.Generic;
    using DofusBot.Protocol.Network.Messages;
    using DofusBot.Protocol.Network.Types;
    using DofusBot.Protocol;
    
    
    public class GuildInAllianceFactsMessage : GuildFactsMessage
    {
        
        public const int ProtocolId = 6422;
        
        public override int MessageID
        {
            get
            {
                return ProtocolId;
            }
        }
        
        private BasicNamedAllianceInformations m_allianceInfos;
        
        public virtual BasicNamedAllianceInformations AllianceInfos
        {
            get
            {
                return m_allianceInfos;
            }
            set
            {
                m_allianceInfos = value;
            }
        }
        
        public GuildInAllianceFactsMessage(BasicNamedAllianceInformations allianceInfos)
        {
            m_allianceInfos = allianceInfos;
        }
        
        public GuildInAllianceFactsMessage()
        {
        }
        
        public override void Serialize(IDataWriter writer)
        {
            base.Serialize(writer);
            m_allianceInfos.Serialize(writer);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            base.Deserialize(reader);
            m_allianceInfos = new BasicNamedAllianceInformations();
            m_allianceInfos.Deserialize(reader);
        }
    }
}
