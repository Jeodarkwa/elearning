using System.Text;
using System.IO;
using System.Security.Cryptography;



namespace ElearningPlatform.Core
{
    public static class CommonFiles
    {

        public static string RoleToString(int Role)
        {
            string UserRole = null; 
            switch (Role)
            {
                case 2:
                    UserRole = "Administrator"; 
                    break;
                case 3:
                    UserRole = "Teacher";
                    break;

                case 4:
                    UserRole = "Student";
                    break;

                case 5:
                    UserRole = "Others"; 
                    break;
            }

            return UserRole; 
        }


        public static string ExamsState(int StateId)
        {
            string ExamsState = null;
            switch (StateId)
            {
                case 1:
                    ExamsState = "Not Yet";
                    break;
                case 2:
                    ExamsState = "Done";
                    break;

                case 3:
                    ExamsState = "Saved";
                    break;

                case 5:
                    ExamsState = "Others";
                    break;
            }

            return ExamsState;
        }

        public static string EncryptToString(string plainText)
        {
            string v_result = "";

            
            byte[] v_bytes = EncryptText(plainText);
            int x;

            for (x = 0; x <= v_bytes.Length - 1; x++)
            {
                v_result = v_result + System.Convert.ToString(v_bytes[x]) + ".";
            }
            v_result = v_result.Substring(0, v_result.Length - 1);

            return "#" + v_result;
        }


        private static byte[] EncryptText(string plainText)
        {

            // Declare a UTF8Encoding object so we may use the GetByte 
            // method to transform the plainText into a Byte array. 
            UTF8Encoding utf8encoder = new UTF8Encoding();

            byte[] inputInBytes = utf8encoder.GetBytes(plainText);

            // Create a new TripleDES service provider 
            TripleDESCryptoServiceProvider tdesProvider = new TripleDESCryptoServiceProvider();

            // The ICryptTransform interface uses the TripleDES 
            // crypt provider along with encryption key and init vector 
            // information 
         //commented by Joe   ICryptoTransform cryptoTransform = tdesProvider.CreateEncryptor(this.key, this.iv); 
            ICryptoTransform cryptoTransform = tdesProvider.CreateEncryptor(key, iv);
         
            // All cryptographic functions need a stream to output the 
            // encrypted information. Here we declare a memory stream 
            // for this purpose. 
            MemoryStream encryptedStream = new MemoryStream();
            CryptoStream cryptStream = new CryptoStream(encryptedStream, cryptoTransform, CryptoStreamMode.Write);

            // Write the encrypted information to the stream. Flush the information 
            // when done to ensure everything is out of the buffer. 
            cryptStream.Write(inputInBytes, 0, inputInBytes.Length);
            cryptStream.FlushFinalBlock();
            encryptedStream.Position = 0;

            // Read the stream back into a Byte array and return it to the calling 
            // method. 
            byte[] result = new byte[encryptedStream.Length];
            encryptedStream.Read(result, 0, System.Convert.ToInt32(encryptedStream.Length));
            cryptStream.Close();
            return result;

        }



        private static string Decrypt(byte[] inputInBytes)
        {
            // UTFEncoding is used to transform the decrypted Byte Array 
            // information back into a string. 
            UTF8Encoding utf8encoder = new UTF8Encoding();
            TripleDESCryptoServiceProvider tdesProvider = new TripleDESCryptoServiceProvider();

            // As before we must provide the encryption/decryption key along with 
            // the init vector. 

            
            ICryptoTransform cryptoTransform = tdesProvider.CreateDecryptor(key, iv);
         //   ICryptoTransform cryptoTransform = tdesProvider.CreateDecryptor(); 
           
          

            // Provide a memory stream to decrypt information into 
            MemoryStream decryptedStream = new MemoryStream();
            CryptoStream cryptStream = new CryptoStream(decryptedStream, cryptoTransform, CryptoStreamMode.Write);
            cryptStream.Write(inputInBytes, 0, inputInBytes.Length);
            cryptStream.FlushFinalBlock();
            decryptedStream.Position = 0;

            // Read the memory stream and convert it back into a string 
            byte[] result = new byte[decryptedStream.Length];
            decryptedStream.Read(result, 0, System.Convert.ToInt32(decryptedStream.Length));
            cryptStream.Close();
            UTF8Encoding myutf = new UTF8Encoding();
            return myutf.GetString(result);

        }

        public static string decryptString(string p_string)
        {

            if (p_string == "")
            {
                return "";
            }

            if (p_string.StartsWith("#"))
            {
                p_string = p_string.Substring(1);
            }

            int x = 0;
            string[] v_string_array = p_string.Split('.');


            byte[] v_bytes = new byte[v_string_array.Length];

            for (x = 0; x <= v_string_array.Length - 1; x++)
            {
                v_bytes[x] = System.Convert.ToByte(int.Parse(v_string_array[x]));
            }

           
            return Decrypt(v_bytes);

        }

        private static byte[] key = {7, 4, 6, 6, 3, 3, 7, 4, 6, 8,
                             3, 7, 8, 6, 3, 6, 8, 7, 0, 0, 
                             6, 2, 8, 8};

        public static byte[] iv = { 19, 97, 2, 20, 08, 200, 200, 219 };

    }

    public class PatrickClass
    {
        

    }


}

