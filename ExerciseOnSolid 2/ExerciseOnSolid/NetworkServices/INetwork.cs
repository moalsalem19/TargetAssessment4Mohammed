using ExerciseOnSolid.Networks;

namespace ExerciseOnSolid.NetworkServices
{
    public interface INetwork
    {
        string CarrierName {get; init;}
        string DevicePhoneNumber {get; init;}
        NetworkStatus PlaceCall(string phoneNumber);
        NetworkStatus PlaceVideoCall(string phoneNumber);
        NetworkStatus SendTextMessage(string phoneNumber, string message);
        NetworkStatus BrowseInternet(string url);
    }
}
