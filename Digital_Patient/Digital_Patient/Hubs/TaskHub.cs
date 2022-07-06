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

            await Clients.All.SendAsync("ReceiveInitializeUserList", list);
        }




        public async Task Update(string UserId, int TaskId)
        {



            string name = Context.User.Identity.Name;

            if (string.IsNullOrEmpty(UserId)) // If All selected
            {
                var users = _connections.GetUsers();

                foreach (var user in users)
                {
                    foreach (var connectionId in _connections.GetConnections(user))
                    {
                        await Clients.User(connectionId).SendAsync("UpdateTask", TaskId);
                    }
                }
            }
            else
            {
                foreach (var connectionId in _connections.GetConnections(UserId))
                {
                    await Clients.User(connectionId).SendAsync("UpdateTask", TaskId);
                }
            }











            //var userIdentifier = (from _connectedUser in connectedUsers
            //                      where _connectedUser.Name == UserId
            //                      select _connectedUser.UserIdentifier).FirstOrDefault();



            //await Clients.User(userIdentifier).SendAsync("UpdateTask", TaskId);
            //await Clients.User(UserId.ToString().ToUpper()).SendAsync("UpdateTask", TaskId.ToString().ToUpper());
            //await Clients.User("PATIENT1@GMAIL.COM").SendAsync("UpdateTask",1 );
            //await Clients.All.SendAsync("UpdateTask", TaskId);

        }




        public override async Task OnDisconnectedAsync(Exception exception)
        {

           

            string name = Context.User.Identity.Name;

            _connections.Remove(name, Context.ConnectionId);

            var list = _connections.GetUsers();

            await Clients.All.SendAsync("ReceiveInitializeUserList", list);

            await Clients.All.SendAsync("MessageBoard",
                        $"{Context.User.Identity.Name}  has left");

        }










        public override async Task OnConnectedAsync()
        {              
            string name = Context.User.Identity.Name;

            _connections.Add(name, Context.ConnectionId);

            await Clients.All.SendAsync("MessageBoard", $"{Context.User.Identity.Name}  has joined");

            await Clients.Client(Context.ConnectionId).SendAsync("ReceiveUserName", Context.User.Identity.Name);

            await Task.CompletedTask;


        }
    }
}












