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
        int D = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private int getN()
        {
            int p = int.Parse(pTextBox.Text);
            int q = int.Parse(qTextBox.Text);

            int n = p * q;

            return n;
        }

        private int getFi()
        {
           int p = int.Parse(pTextBox.Text);
           int q = int.Parse(qTextBox.Text);
           int Fi = (p - 1) * (q - 1);

            return Fi;
        }

        private static List<int> getPrimeNum(int num)
        {
            List<int> primeNum = new List<int>();
            for (int i = 2; i <= num; i++)
            {
                int counter = 0;
                for (int j = 2; j <= i / 2; j++)
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
            int e = 0;
            int Fi = getFi();
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
           int e = getE();
           int Fi = getFi();
            while (D * e % Fi != 1)
            {
                D++;
            }
            return D;
        }
        private List<int> publicKey()
        {
            int e = 0;
            int p = int.Parse(pTextBox.Text);
            int q = int.Parse(qTextBox.Text);
            int n = getN();
            n = p * q;

            int Fi = (p - 1) * (q - 1);


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
                msg.Add(l);
            }

            foreach (int n in msg)
            {
                BigInteger bi = BigInteger.Pow(n, publicKey[1]);
                int enc = (int)(bi % publicKey[0]);
                encryptedMsg.Add(enc);
            }

            return encryptedMsg;
        }

        private List<int> Decryption()
        {
            int n = getN();
            int D = privateKey();
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
                encryptedMsg.Add(l);
            }


            List<int> decryptedMsgInt = new List<int>();
            foreach (int num in encryptedMsg)
            {
                BigInteger bi = BigInteger.Pow(num, D);
                int dec = (int)(bi % n);
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
                byte[] numbs = { (byte)a };
                messageEnc += (char)a;
            }
            File.WriteAllText(@"C:\Users\njusp\OneDrive - Vilniaus kolegija\2 kursas\Informacijos Saugumas\RSA\text.txt", messageEnc);
            EncryptedResultBox.Text = messageEnc;
            eLabel.Text = getE().ToString();
            nLabel.Text = getN().ToString();
            FiLabel.Text = getFi().ToString();
            DLabel.Text = privateKey().ToString();

        }

        private void DecryptButton_Click(object sender, EventArgs e)
        {
            List<int> decryptedMsg = Decryption();
            string message = null;

            foreach (int a in decryptedMsg)
            {
                byte[] num = { (byte)a }; 
                message += encoding.GetString(num);
            }
            DecryptedResultBox.Text = message;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string text = File.ReadAllText(@"C:\Users\njusp\OneDrive - Vilniaus kolegija\2 kursas\Informacijos Saugumas\RSA\text.txt");
            EncryptedTextBox.Text = text;
        }

        private void ClearKeyFile_Click(object sender, EventArgs e)
        {
            File.WriteAllText(@"C:\Users\njusp\OneDrive - Vilniaus kolegija\2 kursas\Informacijos Saugumas\RSA\key.txt", String.Empty);
        }

        private void ClearTextFile_Click(object sender, EventArgs e)
        {
            File.WriteAllText(@"C:\Users\njusp\OneDrive - Vilniaus kolegija\2 kursas\Informacijos Saugumas\RSA\text.txt", String.Empty);

        }
    }
}
