using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace EDS.Domain
{
    internal class FileContext
    {
        public static byte[]? bufferByte = null;
        public static BigInteger[]? hashArray = null;
        public static BigInteger? EDS = null;

        // Считывает файл по байтам -> Выдаёт последовательность байт (актуально для "Чистых" файлов)
        internal static void TakeBytesFromPath(string path)
        {
            try
            {
                using (FileStream fstream = new FileStream(@$"{path}", FileMode.Open))
                {
                    byte[] buffer = new byte[fstream.Length];
                    fstream.Read(buffer, 0, buffer.Length);

                    bufferByte = buffer;
                }
            }
            catch (Exception ex)
            {
                bufferByte = null;
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static void TakeEDSFromFile(string path)
        {
            try
            {
                using (StreamReader reader = new StreamReader(path))
                {
                    string text = reader.ReadToEnd();
                    EDS = BigInteger.Parse(text);
                }

            }
            catch (Exception ex)
            {
                EDS = null;
                MessageBox.Show("Can Not Parse Data Into EDS. Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static void GetHashCodesFromByteArray(BigInteger H0, BigInteger n)
        {
            hashArray = new BigInteger[bufferByte.Length];

            if(hashArray.Length == 0)
            {
                hashArray = new BigInteger[1];
                //Значение хеш функции для пустого файла расчитанное как (Hо+0)^2 mod (r)
                //hashArray[0] = ((H0 + 0) * (H0 + 0)) % n;
                //Значение хеш функции для пустого файла расчитанное как Hо
                hashArray[0] = H0;
            }
            else
            {
                for (int i = 0; i < hashArray.Length; i++)
                {
                    hashArray[i] = ((H0 + bufferByte[i]) * (H0 + bufferByte[i])) % n;
                    H0 = hashArray[i];
                }
            }
        }

        public static void GetLink()
        {

        }

        public static void WriteLink()
        {

        }
    }
}
