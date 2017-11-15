﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NationalismV13
{
    public partial class mainForm : Form
    {
        string selectedItems;
        int selectedIndexes;
        string s;   // selected item from the checked listbox.
        int i;      // selected index from the checked listbox.
        public mainForm()
        {
            InitializeComponent();
        }

        private void getItemBtn_Click(object sender, EventArgs e)
        {
            selectedItemListBox.Items.Clear();
            foreach(string s in checkedListBoxContinents.CheckedItems) //a foreach loop that iterates through all the selected items (string-value of the selected items.
          //  { <-- a single line of code after a loop, so the curly brackets (squiqlywigglies) are not required.
                selectedItemListBox.Items.Add(s);
           // }
        }

        private void getIndexBtn_Click(object sender, EventArgs e)
        {
            selectedIndexListBox.Items.Clear(); //clears the current items in the listbox
            for(i = 0; i < checkedListBoxContinents.CheckedIndices.Count;i++) // a forloop that iterates through all the selected items (index)
            {
                selectedIndexListBox.Items.Add(checkedListBoxContinents.CheckedIndices[i]);
                selectedIndexes = i;
            }
        }

        private void goNextFormBtn_Click(object sender, EventArgs e)
        {
            if (trainRadioBtn.Checked == true)
            {

            }
            if (testRadioBtn.Checked == true)
            {

            }
            else
            {
                MessageBox.Show("Please select a (or multiple) continents");
            }
        }
    }
}
