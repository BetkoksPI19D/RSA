using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;
using System.Diagnostics;
using System.IO;

namespace RSAAlgorithm
{
    public partial class Form1 : Form
    {
        Encoding encoding = Encoding.GetEncoding("437");
        List<int> encryptedMsg;
        int p;
        int q;
        int D = 0;
        int e = 0;
        int n = 0;
        int Fi = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private int getN()
        {
            p = int.Parse(pTextBox.Text);
            q = int.Parse(qTextBox.Text);

            n = p * q;

            return n;
        }

        private int getFi()
        {
            p = int.Parse(pTextBox.Text);
            q = int.Parse(qTextBox.Text);
            Fi = (p - 1) * (q - 1);

            return Fi;
        }

        private static List<int> getPrimeNum(int num)
        {
            List<int> primeNum = new List<int>();
            for (int i = 1; i <= num; i++)
            {
                int counter = 0;
                for (int j = 1; j <= i / 2; j++)
                {
                    if (i % j == 0)
                    {
                        counter++;
                        break;
                    }
                }

                if (counter == 0 && i != 1)
                {
                    Console.WriteLine("{0} ", i);
                    primeNum.Add(i);
                }
            }
            return primeNum;
        }
        private static int DBD(int x, int y)
        {

            if (x == 0)
                return y;
            if (y == 0)
                return x;

            if (x == y)
                return x;

            if (x > y)
                return DBD(x - y, y);
            return DBD(x, y - x);

        }
        private int getE()
        {
            Fi = getFi();
            List<int> primeList = getPrimeNum(Fi);

            foreach (int num in primeList)
            {
                if (DBD(num, Fi) == 1)
                {
                    e = num;
                    break;
                }
            }

            return e;
        }
        private int privateKey()
        {
            e = getE();
            Fi = getFi();
            while (D * e % Fi != 1)
            {
                D++;
            }
            return D;
        }
        private List<int> publicKey()
        {
            e = 0;
            p = int.Parse(pTextBox.Text);
            q = int.Parse(qTextBox.Text);
            int n = getN();
            n = p * q;

            Fi = (p - 1) * (q - 1);


            List<int> primeList = getPrimeNum(Fi);

            foreach (int num in primeList)
            {
                if (DBD(num, Fi) == 1)
                {
                    e = num;
                    break;
                }
            }

            List<int> publicKey = new List<int>();
            publicKey.Add(n);
            publicKey.Add(e);

            foreach (int a in publicKey)
            {
                using (StreamWriter writer = new StreamWriter(@"C:\Users\njusp\OneDrive - Vilniaus kolegija\2 kursas\Informacijos Saugumas\RSA\key.txt", true))
                {
                    writer.WriteLine(a);
                }
            }

            return publicKey;
        }

        private List<int> Encryption()
        {
            List<int> msg = new List<int>();
            List<int> encryptedMsg = new List<int>();
            List<int> publicKey = new List<int>();
            string line;

            StreamReader file = new StreamReader(@"C:\Users\njusp\OneDrive - Vilniaus kolegija\2 kursas\Informacijos Saugumas\RSA\key.txt");
            while ((line = file.ReadLine()) != null)
            {
                publicKey.Add(Convert.ToInt32(line));

            }

            foreach (char l in PrimaryTextBox.Text)
            {
                msg.Add(l % 128);
            }

            foreach (int n in msg)
            {
                BigInteger big = BigInteger.Pow(n, publicKey[1]);
                int enc = (int)(big % publicKey[0]);
                encryptedMsg.Add(enc);
            }

            return encryptedMsg;
        }

        private List<int> Decryption()
        {
            n = getN();
            D = privateKey();
            string line;
            string messg = null;
            List<int> encryptedMsg = new List<int>();
            StreamReader file = new StreamReader(@"C:\Users\njusp\OneDrive - Vilniaus kolegija\2 kursas\Informacijos Saugumas\RSA\text.txt");
            while ((line = file.ReadLine()) != null)
            {
                messg = line;

            }

            foreach (char l in messg)
            {
                encryptedMsg.Add(l % 128);
            }


            List<int> decryptedMsgInt = new List<int>();
            foreach (int num in encryptedMsg)
            {
                BigInteger big = BigInteger.Pow(num, D);
                int dec = (int)(big % n);
                decryptedMsgInt.Add(dec);
            }

            return decryptedMsgInt;
        }

        private void EncryptButton_Click(object sender, EventArgs e)
        {
            List<int> publicKeys = publicKey();
            encryptedMsg = Encryption();
            string messageEnc = null;

            foreach (int a in encryptedMsg)
            {
                byte[] numbers = { (byte)a };
                messageEnc += encoding.GetString(numbers);
            }
            File.WriteAllText(@"C:\Users\njusp\OneDrive - Vilniaus kolegija\2 kursas\Informacijos Saugumas\RSA\text.txt", messageEnc);
            EncryptedResultBox.Text = messageEnc;
        }
    }
}
