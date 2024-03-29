﻿using System.Collections;
using System.Windows.Forms;

class Sorter : System.Collections.IComparer
{
    public int Column = 0;
    public System.Windows.Forms.SortOrder Order = SortOrder.Ascending;
    public int Compare(object x, object y) // IComparer Member
    {
        if (!(x is ListViewItem))
            return (0);
        if (!(y is ListViewItem))
            return (0);

        ListViewItem l1 = (ListViewItem)x;
        ListViewItem l2 = (ListViewItem)y;

        if (l1.ListView.Columns[Column].Tag == null)
        {
            l1.ListView.Columns[Column].Tag = "Text";
        }

        if (l1.ListView.Columns[Column].Tag.ToString() == "Num")
        {
            int fl1 = int.Parse(l1.SubItems[Column].Text);
            int fl2 = int.Parse(l2.SubItems[Column].Text);

            if (Order == SortOrder.Ascending)
            {
                return fl1.CompareTo(fl2);
            }
            else
            {
                return fl2.CompareTo(fl1);
            }
        }
        else
        {
            string str1 = l1.SubItems[Column].Text;
            string str2 = l2.SubItems[Column].Text;

            if (Order == SortOrder.Ascending)
            {
                return str1.CompareTo(str2);
            }
            else
            {
                return str2.CompareTo(str1);
            }
        }
    }
}