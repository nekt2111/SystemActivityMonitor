using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SystemActivityMonitor.Procceses
{
    class ListViewItemCompare : IComparer
    {
        private int _columntIndex;

        public int ColumnIndex
        {
            get
            {
                return _columntIndex;
            }
            set
            {
                _columntIndex = value;
            }
        }



        private SortOrder _sortDirection;

        public SortOrder SortDirection
        {
            get
            {
                return _sortDirection;
            }
            set
            {
                _sortDirection = value;
            }
        }

        public ListViewItemCompare()
        {
            _sortDirection = SortOrder.None;
        }


        public int Compare(object x, object y)
        {
            ListViewItem listViewItemX = x as ListViewItem;
            ListViewItem listViewItemY = y as ListViewItem;

            int result;

            switch (_columntIndex)
            {
                case 0:
                    result = string.Compare(listViewItemX.SubItems[_columntIndex].Text,
                        listViewItemY.SubItems[_columntIndex].Text, false);
                    break;
                case 1:
                    double valueX = double.Parse(listViewItemX.SubItems[_columntIndex].Text);
                    double valueY = double.Parse(listViewItemY.SubItems[_columntIndex].Text);
                    result = valueX.CompareTo(valueY);
                    break;
                default:
                    result = string.Compare(listViewItemX.SubItems[_columntIndex].Text,
                        listViewItemY.SubItems[_columntIndex].Text, false);
                    break;
            }
            if (_sortDirection == SortOrder.Descending)
            {
                return -result;
            }
            else
            {
                return result;
            }

        }
    }
}
