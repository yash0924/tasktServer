﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.WebSockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace tasktServer.Models
{
    public static class WorkForceManagement
    {

        private static List<RobotClient> ConnectedClients = new List<RobotClient>();

        public static List<RobotClient> GetClients()
        {
            return ConnectedClients;
        }
        public static void AddClient(RobotClient newClient)
        {
            ConnectedClients.Add(newClient);
        }
        public static RobotClient FindClientByIP(string ipAddress)
        {
            var requiredClient = ConnectedClients.Where(itm => itm.IPAddress == ipAddress).FirstOrDefault();
            if (requiredClient != null)
            {
                return requiredClient;
            }
            else
            {
                return null;
            }
        }
        public static RobotClient FindClientByPublicKey(string publicKey)
        {
            var requiredClient = ConnectedClients.Where(itm => itm.PublicKey == publicKey).FirstOrDefault();
            if (requiredClient != null)
            {
                return requiredClient;
            }
            else
            {
                return null;
            }
        }
        public static RobotClient FindClientByID(string id)
        {
            var requiredClient = ConnectedClients.Where(itm => itm.id == id).FirstOrDefault();
            if (requiredClient != null)
            {
                return requiredClient;
            }
            else
            {
                return null;
            }
        }
        //public static RobotClient FindClientByConnectionID(string connectionID)
        //{
        //    var requiredClient = ConnectedClients.Where(itm => itm.ConnectionID == connectionID).FirstOrDefault();
        //    if (requiredClient != null)
        //    {
        //        return requiredClient;
        //    }
        //    else
        //    {
        //        return null;
        //    }
        //}
       

    }
}
