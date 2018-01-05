using System;
using System.Collections.Generic;
using System.ComponentModel;
using System;
using System.Windows.Forms;
using System.IO;

namespace DXFImporter
{
    public partial class TestMe : Form
    {
        public TestMe()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Directory.Exists("c:\\testDir1"))
            {
                //shows message if testdir1 exist 
                MessageBox.Show("Directory 'testDir' Exist ");
            }
            else
            {
                //create the directory testDir1 
                Directory.CreateDirectory("c:\\testDir1");
                MessageBox.Show("testDir1 created ! ");
                //create the directory testDir2 
                Directory.CreateDirectory("c:\\testDir1\\testDir2");
                MessageBox.Show("testDir2 created ! ");
                //move the directory testDir2 as testDir in c:\ 
                Directory.Move("c:\\testDir1\\testDir2", "c:\\testDir");
                MessageBox.Show("testDir2 moved ");
                //delete the directory testDir1 
                Directory.Delete("c:\\testDir1");
                MessageBox.Show("testDir1 deleted ");
            }
        }
    }
}
