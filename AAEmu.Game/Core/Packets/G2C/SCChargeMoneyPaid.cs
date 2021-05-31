﻿using AAEmu.Commons.Network;
using AAEmu.Game.Core.Network.Game;

namespace AAEmu.Game.Core.Packets.G2C
{
    internal class SCChargeMoneyPaid : GamePacket
    {
        private long _mailid;

        public SCChargeMoneyPaid(long id) : base(SCOffsets.SCChargeMoneyPaidPacket, 5)
        {
            _mailid = id;
        }

        public override PacketStream Write(PacketStream stream)
        {
            stream.Write(_mailid);
            return stream;
        }
    }
}