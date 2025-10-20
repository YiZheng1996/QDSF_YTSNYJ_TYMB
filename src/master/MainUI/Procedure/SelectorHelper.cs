using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.Drawing;
using RW.UI.Controls;

namespace MainUI.Procedure
{
    public static class SelectorHelper
    {
        public static DialogResult ShowDialog(object sender)
        {
            return ShowDialog(sender, 2);
        }

        public static DialogResult ShowDialog(object sender, int columns)
        {
            return ShowDialog(sender, columns, new Size(230, 35), true);
        }

        public static DialogResult ShowDialog(object sender, Size itemSize)
        {
            return ShowDialog(sender, 2, new Size(230, 35), true);
        }

        public static DialogResult ShowDialog(object sender, int columns, Size itemSize, bool cancelButton)
        {
            if (sender is ComboBox)
            {
                ListItemSelector selector = new();
                ComboBox box = sender as ComboBox;

                int count = box.Items.Count + (cancelButton ? 1 : 0);
                //double value = Math.Sqrt(count);
                //int columns = (int)Math.Ceiling(value);
                selector.Columns = columns;//默认指定为2列，基本上能显示20+不唐突
                selector.ItemSize = itemSize;
                selector.DisplayCancelButton = cancelButton;

                foreach (object item in box.Items)
                {
                    selector.Add(box.DisplayMember, box.ValueMember);
                    //selector.Add(item, box.DisplayMember, box.ValueMember);
                }
                selector.ItemSelector += delegate(object s2, EventArgs e)
                {
                    box.SelectedItem = selector.SelectedItem;
                };
                return selector.ShowDialog();
            }
            else
            {
                return NumInputHelper.ShowDialog(sender);
            }
        }

        //public static DialogResult ShowDialog(object sender, ListItemSelector selector)
        //{

        //}
    }
}
