using BllPalindrome;
using ClassLibraryWord;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinPalindrome
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnReadFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog myOFD = new OpenFileDialog();
            DialogResult result = myOFD.ShowDialog();
            if (result== DialogResult.OK)
            {
                PalindromeManagement myBLL = new PalindromeManagement();
                List<string> myList = myBLL.GetListPalindromeFromFile(myOFD.FileName);
                LstAll.DataSource = myList;
            }
        }

        private void LstAll_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void BtnFilter_Click(object sender, EventArgs e)
        {
            LstPalindrome.Items.Clear();
            LstNotPalindrome.Items.Clear();
            Palindrome myPalindrome = new Palindrome();
            foreach ( string word in LstAll.Items)
            {
                bool result = myPalindrome.IsPalindrome(word);
                if (result)
                {
                    LstPalindrome.Items.Add(word);
                }
                else
                {
                    LstNotPalindrome.Items.Add(word);
                }
                    
            }
        }
    }
}
