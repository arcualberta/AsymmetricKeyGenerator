// See https://aka.ms/new-console-template for more information

using System.Runtime.CompilerServices;
using System.Security.Cryptography;

using RSA rsa = RSA.Create();

string private_key = $"-----Private key-----{Environment.NewLine}{Convert.ToBase64String(rsa.ExportRSAPrivateKey())}{Environment.NewLine}";
string public_key = $"-----Public key-----{Environment.NewLine}{Convert.ToBase64String(rsa.ExportRSAPublicKey())}";
//string private_key = $"{Environment.NewLine}{Convert.ToBase64String(rsa.ExportRSAPrivateKey())}";
//string public_key = $"{Environment.NewLine}{Convert.ToBase64String(rsa.ExportRSAPublicKey())}";

Console.WriteLine(private_key);
Console.WriteLine(public_key);

string out_filder = @"C:\AsymmetricKeys\";
Directory.CreateDirectory(out_filder); ;
string filename_prefix = out_filder + "rsa_" + DateTime.Now.ToString("yyyy-MM-dd_HH-mm-ss");

File.WriteAllText(filename_prefix + "_private", private_key);
File.WriteAllText(filename_prefix + "_public", public_key);

File.WriteAllText(@"D:\_RSA_Keys\rsa_private", private_key);
File.WriteAllText(@"D:\_RSA_Keys\rsa_public", public_key);
