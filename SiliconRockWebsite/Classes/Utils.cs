namespace SiliconRockWebsite.Classes
{
    public static class Utils
    {
        public static async Task<string[]> InitializeStringsAsync(string text)
        {
            return await Task.Run(() => text.Split('|'));
        }
    }
}
