using System.Threading.Tasks;

namespace ConsoleApplication
{
    internal static class AutoDownloadAll
    {
        public static async Task<int> RunAsync()
        {
            await ClothesDownloader.DownloadClothesAsync();
            await FurnidataDownloader.DownloadFurnidata();
            await ProductDataDownloader.DownloadProductDataAsync();
            await NitroFurnitureDownloader.DownloadFurnitureAsync();
            await VariablesDownloader.DownloadVariablesAsync();
            await TextsDownloader.DownloadTextsAsync();
            await IconDownloader.DownloadIcons();
            await Badges.DownloadBadgesAsync();
            await EffectsDownloader.DownloadEffectsAsync();
            return 0;
        }
    }
}
