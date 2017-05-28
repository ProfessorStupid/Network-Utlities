using System;
using System.Net;
using System.Net.NetworkInformation;

namespace Network_Utilties
{
    class checkInternetStatus
    {
        public checkInternetStatus()
        {
            if (canPing("8.8.8.8") == true)
                System.Threading.Thread.Sleep(300000);
            else
            {
                while(canPing("8.8.8.8") == false)
                {
                    canPing("8.8.8.8");
                    System.Threading.Thread.Sleep(10000);
                }
            }

        }

        Boolean canPing(string ipAddress)
        {
            Ping pingSender = new Ping();
            IPAddress address = IPAddress.Parse(ipAddress);

            PingReply reply = pingSender.Send(address);

            if(reply.Status == IPStatus.Success)
            {
                return true;
            } 
            else
            {
                return false;
            }
        }
    }
}
