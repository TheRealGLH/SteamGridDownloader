using System.Net;
public class FileDownloader 
{
    static WebClient client = new WebClient();
    public static void SaveImage(String uri, String fileName)
    {
        client.DownloadFile(uri, fileName);
    }


}
