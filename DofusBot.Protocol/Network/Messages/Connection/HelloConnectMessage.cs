﻿ 

namespace DofusBot.Protocol.Network.Messages.Connection
{
    public class HelloConnectMessage : NetworkMessage
    {
        public const int ProtocolId = 3;
        public override int MessageID { get { return ProtocolId; } }

        public string salt;
        public sbyte[] key;

        public HelloConnectMessage() { }

        public HelloConnectMessage(string salt, sbyte[] key)
        {
            this.salt = salt;
            this.key = key;
        }

        public override void Serialize(IDataWriter writer)
        {
            writer.WriteUTF(this.salt);
            writer.WriteVarInt((int)(ushort)this.key.Length);
            foreach (sbyte @byte in this.key)
                writer.WriteSByte(@byte);
        }

        public override void Deserialize(IDataReader reader)
        {
            this.salt = reader.ReadUTF();
            ushort num = (ushort)reader.ReadVarInt();
            this.key = new sbyte[(int)num];
            for (int index = 0; index < (int)num; ++index)
                this.key[index] = reader.ReadSByte();
        }
    }
}
