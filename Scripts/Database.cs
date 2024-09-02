using System.Collections.Generic;
using System.IO;
using System.Security.Cryptography;
using WinPasser.Scripts;

namespace WinPasser
{
    internal class Database
    {
        public List<Entry> entries = new List<Entry>();

        internal void LoadFromJson(string path)
        {
            string jsonLines;
            using (StreamReader reader = new StreamReader(path))
            {
                jsonLines = reader.ReadToEnd();
                reader.Close();
                reader.Dispose();
            }

            if (jsonLines != string.Empty)
            {
                SaltedBytes saltedBytes = Newtonsoft.Json.JsonConvert.DeserializeObject<SaltedBytes>(jsonLines);
                string decryptedEntriesString = CryptoTools.DecryptStringFromBytes_Aes(saltedBytes.bytes,
                    CryptoTools.HashBytes(DataBank.Key), saltedBytes.IV);
                entries = Newtonsoft.Json.JsonConvert.DeserializeObject<List<Entry>>(decryptedEntriesString);
            }
        }

        internal void SaveToJson(string jsonPath)
        {
            string jsonLines = (string)Newtonsoft.Json.JsonConvert.SerializeObject(entries);
            SaltedBytes saltedBytes = new SaltedBytes();
            using (Aes myAes = Aes.Create())
            {
                myAes.Key = CryptoTools.HashBytes(DataBank.Key);
                byte[] encryptedBytes = CryptoTools.EncryptStringToBytes_Aes(jsonLines, myAes.Key, myAes.IV);
                saltedBytes = new SaltedBytes()
                {
                    IV = myAes.IV,
                    bytes = encryptedBytes
                };
            }
            string encryptedLines = Newtonsoft.Json.JsonConvert.SerializeObject(saltedBytes);
            using (StreamWriter writer = new StreamWriter(path: jsonPath, append: false))
            {
                writer.WriteLine(encryptedLines);
                writer.Close();
                writer.Dispose();
            }
        }
    }
}
