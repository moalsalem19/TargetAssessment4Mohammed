using ExerciseOnSolid.Networks;

namespace ExerciseOnSolid.NetworkServices
{
    public interface IBrowseInternet
    {
        NetworkStatus BrowseInternet(string url);
    }
}