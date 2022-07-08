using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.SignalR;
using Microsoft.AspNetCore.Identity;
using System.Security.Claims;
using System.Net.Http.Headers;
using Microsoft.AspNetCore.Http.Connections;
using Microsoft.IdentityModel.Tokens;

using Microsoft.IdentityModel;

using System.Net.Http;
using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.AspNetCore.Authentication;
using System.Net.Http.Json;
using Digital_Patient.Hubs;

namespace Digital_Patient.Hubs
{


   [Authorize()]
    public class TaskHub : Hub
    {
       

        //private static List<ConnectedUser> connectedUsers = new List<ConnectedUser>();

        private readonly static ConnectionMapping<string> _connections = new ConnectionMapping<string>();


        public async Task InitializeUserList()
        {
            var list = _connections.GetUsers();

            //await Clients.All.SendAsync("ReceiveInitializeUserList", list);
        }




        public async Task Update(string UserEmail, string Message)
        {



            string name = Context.User.Identity.Name;

            if (!string.IsNullOrEmpty(UserEmail)) // If All selected
            {
                string ConnectionId = _connections.GetConnections(UserEmail).FirstOrDefault();

                if(ConnectionId!=null)
                {
               await Clients.User(ConnectionId).SendAsync("UpdateTask", Message+" "+name);
                }
              
            }
               

        }



        //public async Task Update2(string UserEmail, int TaskId)
        //{



        
               
        //            await Clients.All.SendAsync("UpdateTask2", TaskId);
               

            


        //}





        public override async Task OnDisconnectedAsync(Exception exception)
        {

           

            string name = Context.User.Identity.Name;
            

            _connections.Remove(name, Context.ConnectionId);

            var list = _connections.GetUsers();

           

        }










        public override async Task OnConnectedAsync()
        {              
            string name = Context.User.Identity.Name;

            string x = Context.UserIdentifier;

            string y = Context.ConnectionId;

            //_connections.Add(name, Context.ConnectionId);

            _connections.Add(name, x);

            await Task.CompletedTask;


        }
    }
}












