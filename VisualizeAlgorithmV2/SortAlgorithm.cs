using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VisualizeAlgorithmV2
{
    public class SortAlgorithm
    {
        int[] arr;
        Graphics g;
        Bitmap bm;
        PictureBox pbSample;
        Dictionary<int, bool> highlightIndex = new Dictionary<int, bool>();
        Random rand = new Random();
        int speed;
        public string timeExecute;
        public int arrayAccesses;
        Stopwatch tw;

        public SortAlgorithm(int[] arr, PictureBox pic, int speed)
        {
            this.arr = arr;
            pbSample = pic;
            bm = new Bitmap(pic.Width, pic.Height);
            g = Graphics.FromImage(bm);
            pbSample.Image = bm;
            this.speed = speed;
            DrawPerFrame();
            arrayAccesses = 0;

        }
        public void BubbleSort(int flag)
        {
            tw = new Stopwatch();
            tw.Start();
            for(int i=0; i<arr.Length - 1;i++)
            {
                for (int j = 0; j < arr.Length - i - 1; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        if (flag == 0)
                        {
                            Swap(j, j + 1);
                        }
                        else
                        {
                            int temp = arr[j];
                            arr[j] = arr[j + 1];
                            arr[j + 1] = temp;
                            arrayAccesses++;
                        }
                    }
                }
            }
            tw.Stop();
            timeExecute = tw.ElapsedMilliseconds.ToString();
        }

        public void QuickSort(int flag, int l, int r)
        {
            if (l == 0 && r == arr.Length - 1)
            {
                tw = new Stopwatch();
                tw.Start();
            }
            if (l <= r)
            {
                int key = arr[(l + r) / 2];

                int i = l;
                int j = r;

                while (i <= j)
                {
                    while (arr[i] < key)
                        i++;
                    while (arr[j] > key)
                        j--;

                    if (i <= j)
                    {
                        if (flag == 0)
                        {
                            Swap(i, j);
                        }
                        else
                        {
                            int temp = arr[i];
                            arr[i] = arr[j];
                            arr[j] = temp;
                            arrayAccesses++;
                        }
                        i++;
                        j--;
                    }
                }

                if (l < j)
                    QuickSort(flag, l, j);
                if (r > i)
                    QuickSort(flag, i, r);
            }
            if (l == 0 && r == arr.Length - 1)
            {
                tw.Stop();
                timeExecute = tw.ElapsedMilliseconds.ToString();
            }
        }
        public void SelectionSort(int flag)
        {
            tw = new Stopwatch();
            tw.Start();
            int i, j, min_idx;
            for (i = 0; i < arr.Length - 1; i++)
            {
                min_idx = i;
                for (j = i + 1; j < arr.Length; j++)
                    if (arr[j] < arr[min_idx])
                        min_idx = j;
                if (flag == 0)
                {
                    Swap(min_idx, i);
                }
                else
                {
                    int temp = arr[min_idx];
                    arr[min_idx] = arr[i];
                    arr[i] = temp;
                    arrayAccesses++;
                }
            }
            tw.Stop();
            timeExecute = tw.ElapsedMilliseconds.ToString();
        }

        public void InterchangeSort(int flag)
        {
            tw = new Stopwatch();
            tw.Start();
            for (int i = 0; i < arr.Length - 1; i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[i] > arr[j])
                    {
                        if (flag == 0)
                        {
                            Swap(i, j);
                        }
                        else
                        {
                            int temp = arr[i];
                            arr[i] = arr[j];
                            arr[j] = temp;
                            arrayAccesses++;
                        }
                    }
                }
            }
            tw.Stop();
            timeExecute = tw.ElapsedMilliseconds.ToString();
        }
        public void insertionSort(int flag)
        {
            tw = new Stopwatch();
            tw.Start();
            int i, key, j;
            for (i = 1; i < arr.Length; i++)
            {
                key = arr[i];
                j = i - 1;

                while (j >= 0 && arr[j] > key)
                {
                    if (flag == 0)
                    {
                        SetItem(j + 1, j);
                        arrayAccesses++;
                    }
                    else
                    {
                        arr[j + 1] = arr[j];
                    }
                    j = j - 1;
                }
                arr[j + 1] = key;
            }
            tw.Stop();
            timeExecute = tw.ElapsedMilliseconds.ToString();
        }

        private void SetItem(int toIndex, int fromIndex)
        {
            arrayAccesses++;
            arr[toIndex] = arr[fromIndex];

            if (!highlightIndex.ContainsKey(toIndex))
                highlightIndex.Add(toIndex, false);
            DrawPerFrame();
        }

        private void Swap(int index1, int index2)
        {
            arrayAccesses++;
            int temp = arr[index1];
            arr[index1] = arr[index2];
            arr[index2] = temp;

            if (!highlightIndex.ContainsKey(index1))
                highlightIndex.Add(index1, false);
            if (!highlightIndex.ContainsKey(index2))
                highlightIndex.Add(index2, false);
            DrawPerFrame();
        }

        private void DrawPerFrame()
        {
            Draw();
            RefreshPictureBox(pbSample);
            highlightIndex.Clear();
            if (speed != 0)
            {
                Thread.Sleep(speed);
            }
        }

        private void Draw()
        {
            g.Clear(Color.FromArgb(240, 240, 240));
            SolidBrush blackBrush = new SolidBrush(Color.Black);
            SolidBrush redBrush = new SolidBrush(Color.Red);
            int j = 0;
            int width = (pbSample.Width / arr.Length) - 1;
            int dis = pbSample.Width / arr.Length - width;
            for (int i=0; i<arr.Length; i++)
            {
                int bottom = pbSample.Height - 5;
                int left = j;
                int right = (left + width);
                int top = (bottom - arr[i]);
                if (highlightIndex.ContainsKey(i))
                {
                    g.FillRectangle(redBrush, left, top, right - left, bottom - top);
                }
                else
                {
                    g.FillRectangle(blackBrush, left, top, right - left, bottom - top);
                }
                j += width + dis;
            }
        }

        delegate void SetControlValueCallback(Control pbSort);

        private void RefreshPictureBox(Control pbSort)
        {
            if (pbSort.InvokeRequired)
            {
                SetControlValueCallback d = new SetControlValueCallback(RefreshPictureBox);
                pbSort.Invoke(d, new object[] { pbSort });
            }
            else
            {
                pbSort.Refresh();
            }
        }

        public void finishDrawing()
        {
            g.Clear(Color.FromArgb(240, 240, 240));
            SolidBrush greenBrush = new SolidBrush(Color.Green);
            int j = 0;
            int width = (pbSample.Width / arr.Length) - 1;
            int dis = pbSample.Width / arr.Length - width;
            for (int i = 0; i < arr.Length; i++)
            {
                int bottom = pbSample.Height - 5;
                int left = j;
                int right = (left + width);
                int top = (bottom - arr[i]);
                g.FillRectangle(greenBrush, left, top, right - left, bottom - top);
                j += width + dis;
            }
            RefreshPictureBox(pbSample);
            highlightIndex.Clear();
        }
    }
}
