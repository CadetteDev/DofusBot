﻿ 

namespace DofusBot.Protocol.Network.Messages.Connection
{
    public class CredentialsAcknowledgementMessage : NetworkMessage
    {
        public const int ProtocolId = 6314;
        public override int MessageID { get { return ProtocolId; } }

        public CredentialsAcknowledgementMessage() { }

        public override void Serialize(IDataWriter writer)
        {
            //
        }

        public override void Deserialize(IDataReader reader)
        {
            //
        }
    }
}