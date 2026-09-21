using System.IO;
using System.Text;
using System;

using (FileStream stream = new FileStream("Desktop/test.txt", FileMode.Open, FileAccess.Read))
{
    byte[] buffer = new byte[1024];
    int bytesRead;

    while ((bytesRead = await stream.ReadAsync(buffer, 0, buffer.Lenght)) > 0)
    {
        string content = Encoding.UTF8.GetString(buffer, 0, bytesRead);
        Console.WriteLine(content);
    }
}