//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DofusBot.Protocol.Network.Messages.Game.Guild.Tax
{
    using DofusBot.Protocol.Network.Types.Game.Character;
    using System.Collections.Generic;
    using DofusBot.Protocol.Network.Messages;
    using DofusBot.Protocol.Network.Types;
    using DofusBot.Protocol;
    
    
    public class GuildFightPlayersEnemiesListMessage : NetworkMessage
    {
        
        public const int ProtocolId = 5928;
        
        public override int MessageID
        {
            get
            {
                return ProtocolId;
            }
        }
        
        private List<CharacterMinimalPlusLookInformations> m_playerInfo;
        
        public virtual List<CharacterMinimalPlusLookInformations> PlayerInfo
        {
            get
            {
                return m_playerInfo;
            }
            set
            {
                m_playerInfo = value;
            }
        }
        
        private int m_fightId;
        
        public virtual int FightId
        {
            get
            {
                return m_fightId;
            }
            set
            {
                m_fightId = value;
            }
        }
        
        public GuildFightPlayersEnemiesListMessage(List<CharacterMinimalPlusLookInformations> playerInfo, int fightId)
        {
            m_playerInfo = playerInfo;
            m_fightId = fightId;
        }
        
        public GuildFightPlayersEnemiesListMessage()
        {
        }
        
        public override void Serialize(IDataWriter writer)
        {
            writer.WriteShort(((short)(m_playerInfo.Count)));
            int playerInfoIndex;
            for (playerInfoIndex = 0; (playerInfoIndex < m_playerInfo.Count); playerInfoIndex = (playerInfoIndex + 1))
            {
                CharacterMinimalPlusLookInformations objectToSend = m_playerInfo[playerInfoIndex];
                objectToSend.Serialize(writer);
            }
            writer.WriteInt(m_fightId);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            int playerInfoCount = reader.ReadUShort();
            int playerInfoIndex;
            m_playerInfo = new System.Collections.Generic.List<CharacterMinimalPlusLookInformations>();
            for (playerInfoIndex = 0; (playerInfoIndex < playerInfoCount); playerInfoIndex = (playerInfoIndex + 1))
            {
                CharacterMinimalPlusLookInformations objectToAdd = new CharacterMinimalPlusLookInformations();
                objectToAdd.Deserialize(reader);
                m_playerInfo.Add(objectToAdd);
            }
            m_fightId = reader.ReadInt();
        }
    }
}
