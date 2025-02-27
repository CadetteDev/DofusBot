//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DofusBot.Protocol.Network.Types.Game.Context.Roleplay.Party.Companion
{
    using DofusBot.Protocol.Network.Types.Game.Look;
    using System.Collections.Generic;
    using DofusBot.Protocol.Network.Messages;
    using DofusBot.Protocol.Network.Types;
    using DofusBot.Protocol;
    
    
    public class PartyCompanionMemberInformations : PartyCompanionBaseInformations
    {
        
        public const int ProtocolId = 452;
        
        public override int TypeID
        {
            get
            {
                return ProtocolId;
            }
        }
        
        private ushort m_initiative;
        
        public virtual ushort Initiative
        {
            get
            {
                return m_initiative;
            }
            set
            {
                m_initiative = value;
            }
        }
        
        private uint m_lifePoints;
        
        public virtual uint LifePoints
        {
            get
            {
                return m_lifePoints;
            }
            set
            {
                m_lifePoints = value;
            }
        }
        
        private uint m_maxLifePoints;
        
        public virtual uint MaxLifePoints
        {
            get
            {
                return m_maxLifePoints;
            }
            set
            {
                m_maxLifePoints = value;
            }
        }
        
        private ushort m_prospecting;
        
        public virtual ushort Prospecting
        {
            get
            {
                return m_prospecting;
            }
            set
            {
                m_prospecting = value;
            }
        }
        
        private sbyte m_regenRate;
        
        public virtual sbyte RegenRate
        {
            get
            {
                return m_regenRate;
            }
            set
            {
                m_regenRate = value;
            }
        }
        
        public PartyCompanionMemberInformations(ushort initiative, uint lifePoints, uint maxLifePoints, ushort prospecting, sbyte regenRate)
        {
            m_initiative = initiative;
            m_lifePoints = lifePoints;
            m_maxLifePoints = maxLifePoints;
            m_prospecting = prospecting;
            m_regenRate = regenRate;
        }
        
        public PartyCompanionMemberInformations()
        {
        }
        
        public override void Serialize(IDataWriter writer)
        {
            base.Serialize(writer);
            writer.WriteVarUhShort(m_initiative);
            writer.WriteVarUhInt(m_lifePoints);
            writer.WriteVarUhInt(m_maxLifePoints);
            writer.WriteVarUhShort(m_prospecting);
            writer.WriteSByte(m_regenRate);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            base.Deserialize(reader);
            m_initiative = reader.ReadVarUhShort();
            m_lifePoints = reader.ReadVarUhInt();
            m_maxLifePoints = reader.ReadVarUhInt();
            m_prospecting = reader.ReadVarUhShort();
            m_regenRate = reader.ReadSByte();
        }
    }
}
