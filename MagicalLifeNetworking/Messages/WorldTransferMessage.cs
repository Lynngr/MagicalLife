﻿using MagicalLifeAPI.Networking.Serialization;

namespace MagicalLifeAPI.Networking.Messages
{
    /// <summary>
    /// Generally used to transfer the world over to the client.
    /// </summary>
    [ProtoBuf.ProtoContract]
    public class WorldTransferMessage : BaseMessage
    {
        [ProtoBuf.ProtoMember(1)]
        public World.Data.World World;

        public WorldTransferMessage(World.Data.World world) : base(2)
        {
            this.World = world;
        }

        public WorldTransferMessage() : base(2)
        {
        }
    }
}