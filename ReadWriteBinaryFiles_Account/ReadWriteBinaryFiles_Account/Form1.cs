/* Ana Mendes
 * anamendes23@gmail.com
 * github.com/anamendes23
 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace ReadWriteBinaryFiles_Account
{
    public partial class Form1 : Form
    {
        List<Account> accList = new List<Account>();

        string filePath = "acc.dat";
        string listFilePath = "accList.dat";

        public Form1()
        {
            InitializeComponent();
        }
        //-------------------EVENTS---------------------------
        private void Form1_Load(object sender, EventArgs e)
        {
            //reload accList
            FileStream fs = null;
            BinaryReader br = null;
            try
            {
                //1: open file for reading
                //      and create a binaryreader
                fs = new FileStream(listFilePath, FileMode.Open, FileAccess.Read);
                br = new BinaryReader(fs);
                //2. read the file
                //  read each acc data, create a acc object
                //  and save it to the list
                while (br.BaseStream.Position != br.BaseStream.Length)
                {
                    //read each car data, create a car object
                    //and save it to the carlist
                    //read data in the same order it was written
                    string accNumber = br.ReadString();
                    decimal balance = br.ReadDecimal();
                    long binLocal = br.ReadInt64();
                    DateTime dateCreated = DateTime.FromBinary(binLocal);
                    string bankName = br.ReadString();

                    Account acc = new Account
                    {
                        AccountNumber = accNumber,
                        Balance = balance,
                        DateCreated = dateCreated,
                        BankName = bankName
                    };
                    accList.Add(acc);
                }
            }
            catch (FileNotFoundException fne)
            {
                MessageBox.Show(fne.Message);
            }
            catch (IOException ioe)
            {
                MessageBox.Show(ioe.Message);
            }
            finally
            {
                //3. close the strem
                if (fs != null) fs.Close();
                if (br != null) br.Close();
            }
        }

        private void BtnSaveToFile_Click(object sender, EventArgs e)
        {
            //save each new acc append to existent file
            FileStream fs = null;
            BinaryWriter bw = null;

            try
            {
                //Open - Create File
                fs = new FileStream(filePath, FileMode.Append, FileAccess.Write);
                //Write
                bw = new BinaryWriter(fs);
                //get data
                string accNumber = txtAccNumber.Text;
                decimal balance = decimal.Parse(txtBalance.Text);
                DateTime dateCreated = dtpDateCreated.Value;
                long binLocal = dateCreated.ToBinary();
                string bankName = txtBank.Text;

                //create acc object
                Account acc = new Account
                {
                    AccountNumber = accNumber,
                    Balance = balance,
                    DateCreated = dateCreated,
                    BankName = bankName
                };
                //save to list
                accList.Add(acc);

                //write to file
                bw.Write(accNumber);
                bw.Write(balance);
                bw.Write(binLocal);
                bw.Write(bankName);
                //user message
                MessageBox.Show("Account data was saved to file");
            }
            catch(IOException ioe)
            {
                MessageBox.Show(ioe.Message);
            }
            catch(FormatException foe)
            {
                MessageBox.Show(foe.Message);
            }
            finally
            {
                //close streams
                if (fs != null) fs.Close();
                if (bw != null) bw.Close();
            }
        }

        private void BtnSaveAccList_Click(object sender, EventArgs e)
        {
            //save accList to file
            FileStream fs = null;
            BinaryWriter bw = null;

            try
            {
                if (File.Exists(listFilePath))
                {
                    //delete file if it exists
                    File.Delete(listFilePath);
                }
                //1. Open file for appending
                fs = new FileStream(listFilePath, FileMode.Append, FileAccess.Write);
                //create binarywriter
                bw = new BinaryWriter(fs);
                //2. write acc in carList
                foreach (Account acc in accList)
                {
                    //now save or write it to file
                    bw.Write(acc.AccountNumber);
                    bw.Write(acc.Balance);
                    bw.Write(acc.DateCreated.ToBinary());
                    bw.Write(acc.BankName);
                }
            }
            catch (IOException ioe)
            {
                MessageBox.Show(ioe.Message);
            }
            finally
            {
                //3. close streams
                if (fs != null) fs.Close();
                if (bw != null) bw.Close();
            }
        }

        private void BtnReadAccs_Click(object sender, EventArgs e)
        {
            //read file and display on richtextbox1
            FileStream fs = null;
            BinaryReader br = null;

            try
            {
                fs = new FileStream(filePath, FileMode.Open, FileAccess.Read);
                br = new BinaryReader(fs);

                while(br.BaseStream.Position != br.BaseStream.Length)
                {
                    string accNumber = br.ReadString();
                    decimal balance = br.ReadDecimal();
                    long binLocal = br.ReadInt64();
                    DateTime dateCreated = DateTime.FromBinary(binLocal);
                    string bankName = br.ReadString();
                    //display
                    richTextBox1.AppendText(
                        $"{accNumber} {balance:c} {dateCreated.ToShortDateString()} {bankName}");
                }
            }
            catch (FileNotFoundException fne)
            {
                MessageBox.Show(fne.Message);
            }
            catch (IOException ioe)
            {
                MessageBox.Show(ioe.Message);
            }
            finally
            {
                if (fs != null) fs.Close();
                if (br != null) br.Close();
            }
        }

        private void BtnReadFromList_Click(object sender, EventArgs e)
        {
            //read file and display on listview1
            FileStream fs = null;
            BinaryReader br = null;

            listView1.Items.Clear();

            try
            {
                fs = new FileStream(listFilePath, FileMode.Open, FileAccess.Read);
                br = new BinaryReader(fs);

                while (br.BaseStream.Position != br.BaseStream.Length)
                {
                    string accNumber = br.ReadString();
                    decimal balance = br.ReadDecimal();
                    long binLocal = br.ReadInt64();
                    DateTime dateCreated = DateTime.FromBinary(binLocal);
                    string bankName = br.ReadString();
                    //display
                    string[] row = { accNumber, balance.ToString("c"), dateCreated.ToShortDateString(), bankName };
                    ListViewItem lvi = new ListViewItem(row);
                    listView1.Items.Add(lvi);
                }
            }
            catch (FileNotFoundException fne)
            {
                MessageBox.Show(fne.Message);
            }
            catch (IOException ioe)
            {
                MessageBox.Show(ioe.Message);
            }
            finally
            {
                if (fs != null) fs.Close();
                if (br != null) br.Close();
            }
        }
    }
}
