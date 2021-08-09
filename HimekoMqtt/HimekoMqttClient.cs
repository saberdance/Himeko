using System;
using System.Threading.Tasks;
using System.Linq;
using System.Text;
using tsubasa;
using System.Net.Mqtt;

namespace HimekoMqtt
{
    public class HimekoMqttClient
    {
        private IMqttClient _client = null;
        public MqttClientSetting Setting { get; set; } = new();

        public HimekoMqttClient() { }
        public HimekoMqttClient(MqttClientSetting setting) => Setting = setting;

        public async Task<bool> Connect()
        {
            return false;
        }

    }
}
