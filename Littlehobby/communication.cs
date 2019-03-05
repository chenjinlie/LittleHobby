using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.WebSockets;
using System.Threading;
using System.Threading.Tasks;

namespace Littlehobby
{
    public class Communication
    {
        private WebSocket socket = null;
        //创建链接
        public async Task Connect(HttpContext context, Func<Task> n)
        {
            try
            {
                //执行接收
                WebSocket socket = await context.WebSockets.AcceptWebSocketAsync();
                this.socket = socket;
                //执行监听
                await EchoLoop();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        /// <summary>
        /// 响应处理
        /// </summary>
        /// <returns></returns>
        async Task EchoLoop()
        {
            var buffer = new byte[1024];
            var seg = new ArraySegment<byte>(buffer);
            while (this.socket.State == WebSocketState.Open)
            {
                var incoming = await this.socket.ReceiveAsync(seg, CancellationToken.None);

                byte[] backInfo = System.Text.UTF8Encoding.Default.GetBytes("服务端相应内容");
                var outgoing = new ArraySegment<byte>(backInfo, 0, incoming.Count);
                await this.socket.SendAsync(outgoing, WebSocketMessageType.Text, true, CancellationToken.None);
            }
        }
    }
}
