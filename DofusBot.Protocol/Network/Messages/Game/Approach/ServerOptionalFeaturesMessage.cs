﻿ 
using System.Collections.Generic;

namespace DofusBot.Protocol.Network.Messages.Game.Approach
{
    class ServerOptionalFeaturesMessage : NetworkMessage
    {
        public const int ProtocolId = 6305;
        public override int MessageID { get { return ProtocolId; } }

        public List<byte> Features;

        public ServerOptionalFeaturesMessage() { }

        public ServerOptionalFeaturesMessage(List<byte> features)
        {
            Features = features;
        }

        public override void Serialize(IDataWriter writer)
        {
            writer.WriteShort((short)Features.Count);
            for (int i = 0; i < Features.Count; i++)
            {
                writer.WriteByte(Features[i]);
            }
        }

        public override void Deserialize(IDataReader reader)
        {
            ushort lenght = reader.ReadUShort();
            Features = new List<byte>();
            for (int i = 0; i < lenght; i++)
            {
                Features.Add(reader.ReadByte());
            }
        }
    }
}
