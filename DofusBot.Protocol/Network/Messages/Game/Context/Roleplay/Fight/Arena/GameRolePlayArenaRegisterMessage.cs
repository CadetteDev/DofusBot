//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DofusBot.Protocol.Network.Messages.Game.Context.Roleplay.Fight.Arena
{
    using System.Collections.Generic;
    using DofusBot.Protocol.Network.Messages;
    using DofusBot.Protocol.Network.Types;
    using DofusBot.Protocol;
    
    
    public class GameRolePlayArenaRegisterMessage : NetworkMessage
    {
        
        public const int ProtocolId = 6280;
        
        public override int MessageID
        {
            get
            {
                return ProtocolId;
            }
        }
        
        private int m_battleMode;
        
        public virtual int BattleMode
        {
            get
            {
                return m_battleMode;
            }
            set
            {
                m_battleMode = value;
            }
        }
        
        public GameRolePlayArenaRegisterMessage(int battleMode)
        {
            m_battleMode = battleMode;
        }
        
        public GameRolePlayArenaRegisterMessage()
        {
        }
        
        public override void Serialize(IDataWriter writer)
        {
            writer.WriteInt(m_battleMode);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            m_battleMode = reader.ReadInt();
        }
    }
}
