using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace VisualizeAlgorithmV2
{
    public partial class Form1 : Form
    {
        int[] arr;
        int n;
        Graphics g;
        Bitmap bm;
        static Random rand = new Random();
        Thread thread;

        public Form1()
        {
            InitializeComponent();
            Control.CheckForIllegalCrossThreadCalls = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {   
            cbNelements.SelectedIndex = cbNelements.Items.IndexOf("10");
            cbSortList.SelectedIndex = cbSortList.Items.IndexOf("Bubble Sort");
        }

        private void RandomArr(int[] arr)
        {
            for(int i=0; i<arr.Length; i++)
            {
                arr[i] = rand.Next(1, 500);
            }
        }

        private void PrepareToSort()
        {
            bm = new Bitmap(pbSort.Width, pbSort.Height);
            g = Graphics.FromImage(bm);
            pbSort.Image = bm;
            arr = new int[n];
            RandomArr(arr);
        }

        private void btSort_Click(object sender, EventArgs e)
        {
            TimeExecute.Text = "Run time: 0 ms";
            ArrayAccesses.Text = "Array Accesses: ";
            btStop.Enabled = true;
            btFinish.Enabled = true;
            if(thread != null)
            {

                thread.Abort();
                thread.Join();
            }

            PrepareToSort();

            SortAlgorithm sa = new SortAlgorithm(arr, pbSort, tbSpeed.Value);
            int k = cbSortList.SelectedIndex;
            ThreadStart ts = delegate ()
            {
                switch (k)
                {
                    case 0:
                        sa.BubbleSort(0);
                        break;
                    case 1:
                        sa.QuickSort(0, 0, arr.Length - 1);
                        break;
                    case 2:
                        sa.SelectionSort(0);
                        break;
                    case 3:
                        sa.insertionSort(0);
                        break;
                    case 4:
                        sa.InterchangeSort(0);
                        break;
                }
                sa.finishDrawing();
                TimeExecute.Text = "Run time: " + sa.timeExecute + " milisecond";
                ArrayAccesses.Text = "Array Accesses: " + sa.arrayAccesses.ToString();
            };
            thread = new Thread(ts);
            thread.Start();

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Environment.Exit(0);
        }

        private void btStop_Click(object sender, EventArgs e)
        {
            thread.Abort();
        }

        private void cbNelements_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cbNelements.SelectedIndex == 0)
            {
                n = 10;
            }
            if (cbNelements.SelectedIndex == 1)
            {
                n = 100;
            }
            if (cbNelements.SelectedIndex == 2)
            {
                n = 600;
            }
        }

        private void btFinish_Click(object sender, EventArgs e)
        {
            thread.Abort();
            int k = cbSortList.SelectedIndex;
            SortAlgorithm sa = new SortAlgorithm(arr, pbSort, 0);
            switch (k)
            {
                case 0:
                    sa.BubbleSort(1);
                    break;
                case 1:
                    sa.QuickSort(1, 0, arr.Length - 1);
                    break;
                case 2:
                    sa.SelectionSort(1);
                    break;
                case 3:
                    sa.insertionSort(1);
                    break;
                case 4:
                    sa.InterchangeSort(1);
                    break;
            }
            sa.finishDrawing();
            TimeExecute.Text = "Run time: " + sa.timeExecute + " ms";
            ArrayAccesses.Text = "Array Accesses: " + sa.arrayAccesses.ToString();

        }

        private void tbSpeed_Scroll(object sender, EventArgs e)
        {
            label3.Text = "Delay: " + tbSpeed.Value.ToString() + "%";
        }
    }
}
