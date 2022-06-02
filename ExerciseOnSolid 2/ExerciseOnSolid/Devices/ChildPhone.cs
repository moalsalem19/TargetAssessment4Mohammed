using ExerciseOnSolid.Networks;
using ExerciseOnSolid.NetworkServices;

namespace ExerciseOnSolid.Devices
{
    public class ChildPhone : IDevice, ICall
    {
        private readonly INetwork _cellularNetwork;
        public ChildPhone(INetwork network) => _cellularNetwork = network;
        public NetworkStatus PlaceCall(string phoneNumber) => _cellularNetwork.PlaceCall(phoneNumber);
        public string PhoneNumber => _cellularNetwork.DevicePhoneNumber;
    }
}