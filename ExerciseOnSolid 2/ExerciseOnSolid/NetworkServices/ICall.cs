using ExerciseOnSolid.Networks;

namespace ExerciseOnSolid.NetworkServices
{
    public interface ICall
    {
        NetworkStatus PlaceCall(string phoneNumber);
    }
}