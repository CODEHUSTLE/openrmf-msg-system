// Copyright (c) Cingulara 2019. All rights reserved.
// Licensed under the GNU GENERAL PUBLIC LICENSE Version 3, 29 June 2007 license. See LICENSE file in the project root for full license information.
using MongoDB.Driver;
using openrmf_msg_system.Models;

namespace openrmf_msg_system.Data
{
    public class SystemGroupContext
    {
        private readonly IMongoDatabase _database = null;

        public SystemGroupContext(Settings settings)
        {
            var client = new MongoClient(settings.ConnectionString);
            if (client != null)
                _database = client.GetDatabase(settings.Database);
        }

        public IMongoCollection<SystemGroup> SystemGroups
        {
            get
            {
                return _database.GetCollection<SystemGroup>("SystemGroups");
            }
        }
    }
}