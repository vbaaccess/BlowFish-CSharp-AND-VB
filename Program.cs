using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
using VbLegacy;

namespace EncryptionF
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Encryption using algorytm BlowFish.vb ");

            string Mykey = "DowolnyCiagZnakowKtoryJestKluczemPotzrebnymDoOdszyfrowaniaWiadomosciWczesniejZaszyfrowanejTymKluczem.ImCiagJestDluzszyTymChybaLepiej";
            string MyMessage = "";
            string DecryptMsg = "";
            string EncryptMsg = "";
           
            // Test 1 - Szyfrowania
            
            MyMessage = "Siala baba mak, nie wiedziala jak";
            EncryptMsg = "";
            
            EncryptMsg = PasswordHelper.BlowFishEncryp(MyMessage, Mykey);
            Console.WriteLine("\nSTEP 1.1 - My Message: {0}", MyMessage);
            Console.WriteLine("\nSTEP 1.2 - Encrypt Message: {0}", EncryptMsg);

            // Test 2 - Deszyfrowania
            EncryptMsg = "44FE287FD1DCC6F90B4CC7C6E94F0698F0ADF7EF99AE1C44489D99BC36C3C52F789687B86B5C69F6";
            DecryptMsg = "";

            DecryptMsg = PasswordHelper.BlowFishDecrypt(EncryptMsg, Mykey);
            Console.WriteLine("\nSTEP 2.1 - Encrypt Message: {0} ...", EncryptMsg.Substring(1, 10));
            Console.WriteLine("\nSTEP 2.2 - Decrypt Message: {0}", DecryptMsg);

            // koniec - czekaj na ENTER
            Console.WriteLine("\nPRESS ENTER to END");
            Console.ReadLine();
        }
    }
}
