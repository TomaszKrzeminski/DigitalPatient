using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.SignalR;
using Syncfusion.Blazor.Charts.Chart.Internal;

namespace Digital_Patient.Hubs
{
    public class TaskHub : Hub
    {


        public async Task Update(string UserId, int TaskId)
        {

            await Clients.User(UserId).SendAsync("UpdateTask", TaskId);

        }


    }
}
