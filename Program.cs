using System;

namespace Encriptacion
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingresa una contraseña");
            String pass = Console.ReadLine();
            string Base64Decode = HashHelper.Base64Decode(pass);
            string Base64Encode = HashHelper.Base64Encode(pass);
            string MD5 = HashHelper.MD5(pass);
            string SHA1 = HashHelper.SHA1(pass);
            string SHA256 = HashHelper.SHA256(pass);
            string SHA384 = HashHelper.SHA384(pass);
            string SHA512 = HashHelper.SHA512(pass);
            Console.WriteLine("Base Decode " + Base64Decode+"\n" +
                "Base Encode " + Base64Encode + "\n" +
                "MD5 " + MD5 + "\n" +
                "SHA1 " + SHA1+"\n" +
                "SHA256 " + SHA256 + "\n"+
                "SHA384 " + SHA384 + "\n"+
                "SHA512 " + SHA512 + "\n") ;
        }
    }
}
