using ExerciseOnSolid.Networks;

namespace ExerciseOnSolid.NetworkServices
{
    public interface IPlaceVideoCall
    {
        NetworkStatus PlaceVideoCall(string phoneNumber);
    }
}