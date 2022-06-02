using ExerciseOnSolid.Networks;
using ExerciseOnSolid.NetworkServices;


namespace ExerciseOnSolid.Devices
{
    public class CellularSmartWatch : IDevice, ICall, ITextMessage
    {
        private readonly INetwork _cellularNetwork;
        public CellularSmartWatch(INetwork network) => _cellularNetwork = network;
        public NetworkStatus PlaceCall(string phoneNumber) => _cellularNetwork.PlaceCall(phoneNumber);
        public NetworkStatus SendTextMessage(string phoneNumber, string message) => _cellularNetwork.SendTextMessage(phoneNumber, message);
        public string PhoneNumber => _cellularNetwork.DevicePhoneNumber;
    }
}