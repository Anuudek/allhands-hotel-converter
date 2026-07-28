using System.Threading.Tasks;
using Habbo_Downloader.Compiler;

namespace ConsoleApplication
{
    internal static class AutoConvertAll
    {
        public static async Task<int> RunAsync()
        {
            await SWF_Furni_To_Nitro.ConvertSwfFilesAsync();
            await SWF_clothes_To_Nitro.ConvertSwfFilesAsync();
            await SWF_Effects_To_Nitro.ConvertSwfFilesAsync();
            return 0;
        }
    }
}
