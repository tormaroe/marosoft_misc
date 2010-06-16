using System.Net;

namespace RandomPasswordService
{
    public static class RandomDotOrg
    {
        public static string GetNewPassword()
        {
            using (var webClient = new WebClient())
            {
                return webClient
                    .DownloadString(
                    "http://www.random.org/strings/?" +
                    "num=1&len=8&digits=on&upperalpha=on" +
                    "&loweralpha=on&unique=on&format=plain&rnd=new")
                    .Trim();
            }
        }
    }
}
