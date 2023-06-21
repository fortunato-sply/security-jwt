namespace Security.Jwt;
using System.IO;

public class FilePasswordProvider : IPasswordProvider
{
  string password;
  public FilePasswordProvider(string path)
  {

  }
  public string ProvidePassword()
  {
    throw new System.NotImplementedException();
  }
}