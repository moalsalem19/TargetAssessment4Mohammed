using ExerciseOnSolid.Networks;

namespace ExerciseOnSolid.NetworkServices
{
    public interface ITextMessage
    {
        NetworkStatus SendTextMessage(string phoneNumber, string message);
    }
}