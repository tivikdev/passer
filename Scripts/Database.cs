﻿using System.Collections.Generic;
using System.IO;
using System.Security.Cryptography;
using WinPasser.Scripts;

namespace WinPasser
{
    internal class Database
    {
        public List<Entry> entries = new List<Entry>()
        {
            new Entry()
            {
                Invisible = true, // to be able to save even an empty database
            }
        };

        internal bool TryDecryptJson(string path)
        {
            string jsonLines;
            using (StreamReader reader = new StreamReader(path))
            {
                jsonLines = reader.ReadToEnd();
            }

            if (!string.IsNullOrEmpty(jsonLines))
            {
                try
                {
                    SaltedBytes saltedBytes = Newtonsoft.Json.JsonConvert.DeserializeObject<SaltedBytes>(jsonLines);
                    string decryptedEntriesString = CryptoTools.DecryptStringFromBytes_Aes(saltedBytes.bytes,
                        CryptoTools.HashBytes(DataBank.Key), saltedBytes.IV);
                    entries = Newtonsoft.Json.JsonConvert.DeserializeObject<List<Entry>>(decryptedEntriesString);
                }
                catch (System.Exception)
                {
                    return false;
                    throw;
                }
            }
            return true;
        }

        internal void LoadFromJson(string path)
        {
            string jsonLines;
            using (StreamReader reader = new StreamReader(path))
            {
                jsonLines = reader.ReadToEnd();
            }

            if (!string.IsNullOrEmpty(jsonLines))
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
            }
        }
    }
}
