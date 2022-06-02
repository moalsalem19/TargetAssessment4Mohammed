using ExerciseOnSolid.Networks;
using ExerciseOnSolid.NetworkServices;

namespace ExerciseOnSolid.Devices
{
    public class SmartPhone : IDevice, ICall, IPlaceVideoCall, ITextMessage, IBrowseInternet
    {
        private readonly INetwork _cellularNetwork;
        public SmartPhone(INetwork network) => _cellularNetwork = network;
        public NetworkStatus PlaceCall(string phoneNumber) => _cellularNetwork.PlaceCall(phoneNumber);
        public NetworkStatus PlaceVideoCall(string phoneNumber) => _cellularNetwork.PlaceVideoCall(phoneNumber);
        public NetworkStatus SendTextMessage(string phoneNumber, string message) => _cellularNetwork.SendTextMessage(phoneNumber, message);
        public NetworkStatus BrowseInternet(string url) => _cellularNetwork.BrowseInternet(url);
        public string PhoneNumber => _cellularNetwork.DevicePhoneNumber;
    }
}