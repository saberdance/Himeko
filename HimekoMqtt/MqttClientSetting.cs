using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HimekoMqtt
{
    public class MqttClientSetting
    {
        public string Username { get; set; } = "admin";
        public string Password { get; set; } = "admin";
        public string ServerIp { get; set; } = "127.0.0.1";
        public int Port { get; set; } = 1883;
        public int BufferSize { get; set; } = 128 * 1024;
        public int KeepAliveSecs { get; set; } = 30;
        public int WaitTimeoutSecs { get; set; } = 10;
    }
}
