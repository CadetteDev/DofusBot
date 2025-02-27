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
    using DofusBot.Protocol.Network.Types.Game.Data.Items;
    using System.Collections.Generic;
    using DofusBot.Protocol.Network.Messages;
    using DofusBot.Protocol.Network.Types;
    using DofusBot.Protocol;
    
    
    public class GoldAddedMessage : NetworkMessage
    {
        
        public const int ProtocolId = 6030;
        
        public override int MessageID
        {
            get
            {
                return ProtocolId;
            }
        }
        
        private GoldItem m_gold;
        
        public virtual GoldItem Gold
        {
            get
            {
                return m_gold;
            }
            set
            {
                m_gold = value;
            }
        }
        
        public GoldAddedMessage(GoldItem gold)
        {
            m_gold = gold;
        }
        
        public GoldAddedMessage()
        {
        }
        
        public override void Serialize(IDataWriter writer)
        {
            m_gold.Serialize(writer);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            m_gold = new GoldItem();
            m_gold.Deserialize(reader);
        }
    }
}
