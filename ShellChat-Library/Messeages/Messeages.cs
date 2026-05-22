using System.Net.Sockets;
using System.Text;

namespace ShellChat_Library.Messeages
{
    public class Messeages
    {
        public static class Messeage
        {
            
            public static string ReciveMesseage(TcpClient client)
            {
                Stream stream = client.GetStream();
                byte[] buffer = new byte[1024];
                int read = stream.Read(buffer, 0, buffer.Length);
                if (read == 0) return null;
                return Encoding.UTF8.GetString(buffer, 0, read);
            }
        }
    }
}