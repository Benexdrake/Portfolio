using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sort_Form_Demo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //------------------
        Thread th;
        ThreadStart ts;
        Graphics g;
        Graphics fG;
        Bitmap btm;
        Pen pen;
        PointF img;
        Color color;
        CancellationTokenSource cts;
        //------------------

        int[] randomArray;

        int maxNumber;
        int speed = 0;
        int height = 0;
        float lineStrength = 3f;

        object _locker;

        private void Form1_Load(object sender, EventArgs e)
        {
            _locker = new object();
            cBox_Sort.SelectedIndex = 0;
            maxNumber = trackBar_MaxNumber.Value;
            color = Color.Aqua;
            panel_Color.BackColor = color;
            lbl_Color.Text = "Color: " + color.Name;
        }

        void Menu()
        {
            if (cts != null)
                cts.Cancel();

            if (g != null)
            {
                lock(_locker)
                {
                    g.Clear(Color.Black);
                }
            }
            randomArray = Numbers.RandomNumbers(maxNumber);
            Graphicss();
            cts = new CancellationTokenSource();
            var token = cts.Token;

            switch (cBox_Sort.SelectedIndex)
            {
                case 0:
                    ts = new ThreadStart(delegate { BubbleSort(token); });
                    break;
                case 1:
                    ts = new ThreadStart(delegate { QuickSort(0, randomArray.Length - 1, token); });
                    break;
                case 2:
                    ts = new ThreadStart(delegate { SelectionSort(token); });
                    break;
                case 3:
                    ts = new ThreadStart(delegate { InsertionSort(token); });
                    break;
                case 4:
                    ts = new ThreadStart(delegate { HeapSort(token); });
                    break;
                case 5:
                    ts = new ThreadStart(delegate { ShellSort(token); });
                    break;
                case 6:
                    ts = new ThreadStart(delegate { CocktailShakerSort(token); });
                    break;
                case 7:
                    ts = new ThreadStart(delegate { GnomeSort(token); });
                    break;
            }
            if (ts != null)
            {
                th = new Thread(ts);
                th.IsBackground = true;
                th.Start();
            }
        }

        public void Draw()
        {
            pen.Color = color;

            lock (_locker)
            {
                for (int i = 1; i <= randomArray.Length; i++)
                {
                    g.DrawLine(pen, i*3, height, i*3, height-(randomArray[i - 1] + 1));
                }
                    fG.DrawImage(btm,img);
                if (speed > 0)
                {
                    Thread.Sleep(speed);
                }
            }
        }

        private void trackBar_MaxNumber_ValueChanged(object sender, EventArgs e)
        {
            tBox_MaxNumber.Text = trackBar_MaxNumber.Value.ToString();
            maxNumber = trackBar_MaxNumber.Value;
        }

        private void btn_Start_Click(object sender, EventArgs e)
        {
            Menu();
        }

        void Graphicss()
        {
            pen = new Pen(color, lineStrength);
            img = new PointF(10, 10);
            btm = new Bitmap(1400, 600);
            g = Graphics.FromImage(btm);
            fG = CreateGraphics();
            height = maxNumber+10;
        }

        private void btn_Stop_Click(object sender, EventArgs e)
        {
            if (cts != null)
                cts.Cancel();
        }

        private void trackBar1_ValueChanged(object sender, EventArgs e)
        {
            tBox_MaxSpeed.Text = trackBar_MaxSpeed.Value.ToString();
            speed = trackBar_MaxSpeed.Value;
        }

        private void panel_Color_MouseClick(object sender, MouseEventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();

            colorDialog.AllowFullOpen = true;
            colorDialog.ShowHelp = false;

            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                panel_Color.BackColor = colorDialog.Color;
                color = colorDialog.Color;
                lbl_Color.Text = "Color: " + color.Name;
            }
        }

        // --------------------------------------------------------------------------------------------------


        // Bubble Sort
        private void BubbleSort(CancellationToken token)
        {
            for (int i = 0; i < randomArray.Length; i++)
            {
                for (int j = i + 1; j < randomArray.Length; j++)
                {
                    int a1 = randomArray[i];
                    int a2 = randomArray[j];
                    if (a1 > a2)
                    {
                        if (token.IsCancellationRequested)
                        {
                            return;
                        }
                        int temp = randomArray[i];
                        randomArray[i] = randomArray[j];
                        randomArray[j] = temp;
                    }   
                }
                Draw();
                lock (_locker)
                {
                    g.Clear(Color.Black);
                }
            }
        }

        // Quick Sort
        private void QuickSort(int left, int right, CancellationToken token)
        {

            Panel panelTemp = new Panel();

            int i = left;
            int j = right;

            int pivot = randomArray[(left + right) / 2];

            while (i <= j)
            {
                if (token.IsCancellationRequested)
                {
                    return;
                }

                while (randomArray[i] < pivot)
                {
                    i++;
                }
                while (randomArray[j] > pivot)
                {
                    j--;
                }

                if (i <= j)
                {
                    int temp = randomArray[i];

                    randomArray[i] = randomArray[j];

                    randomArray[j] = temp;

                    Draw();
                    lock (_locker)
                    {
                        g.Clear(Color.Black);
                    }

                    i++;
                    j--;
                }
            }
            
            if (left < j)
            {
                QuickSort(left, j, token);
            }
            if (i < right)
            {
                QuickSort(i, right, token);
            }
        }

        // Selection Sort

        private void SelectionSort(CancellationToken token)
        {
            int smallest;

            Panel panelTemp = new Panel();

            for (int i = 0; i < randomArray.Length - 1; i++)
            {
                if (token.IsCancellationRequested)
                {
                    return;
                }
                
                smallest = i;
                for (int j = i; j < randomArray.Length; j++)
                {
                    if (randomArray[j] < randomArray[smallest])
                    {
                        smallest = j;
                    }
                }

                int temp = randomArray[smallest];

                randomArray[smallest] = randomArray[i];

                randomArray[i] = temp;

                Draw();
                lock (_locker)
                {
                    g.Clear(Color.Black);
                }
            }
        }

        // Insertion Sort

        private void InsertionSort(CancellationToken token)
        {
            int n = randomArray.Length, i, j, flag;
            Panel panelTemp = new Panel();

            for (i = 1; i < n; i++)
            {
                if (token.IsCancellationRequested)
                {
                    return;
                }

                int temp = randomArray[i];
                
                flag = 0;

                for (j = i - 1; j >= 0 && flag != 1;)
                {
                    if (temp > randomArray[j])
                    {
                        randomArray[j + 1] = randomArray[j];
                        
                        j--;
                        
                        randomArray[j + 1] = temp;
                    }
                    else
                    {
                        flag = 1;
                    }
                }
                Draw();
                lock (_locker)
                {
                    g.Clear(Color.Black);
                }
            }
        }



        // Heap Sort

        private void HeapSort(CancellationToken token)
        {
            int n = randomArray.Length;

            int temp;

            for (int i = n / 2 - 1; i >= 0; i--)
                heapify(n, i);
            for (int i = n - 1; i >= 0; i--)
            {
                if (token.IsCancellationRequested)
                {
                    return;
                }
                
                temp = randomArray[0];
                randomArray[0] = randomArray[i];
                randomArray[i] = temp;

                Draw();
                lock (_locker)
                {
                    g.Clear(Color.Black);
                }

                heapify(i, 0);
            }

            void heapify(int n, int i)
            {
                int temp;
                int largest = i;
                int left = 2 * i + 1;
                int right = 2 * i + 2;
                if (left < n && randomArray[left] > randomArray[largest])
                {
                    largest = left;
                }
                if (right < n && randomArray[right] > randomArray[largest])
                {
                    largest = right;
                }
                if (largest != i)
                {
                    temp = randomArray[i];
                    randomArray[i] = randomArray[largest];
                    randomArray[largest] = temp;

                    heapify(n, largest);
                }
            }
        }

        // Shell Sort

        private void ShellSort(CancellationToken token)
        {
            int temp;
            int j = 0;
            int inc = 3;
            while (inc > 0)
            {
                for (int i = 0; i < randomArray.Length; i++)
                {
                    if (token.IsCancellationRequested)
                    {
                        return;
                    }
                    j = i;
                    temp = randomArray[i];
                    while ((j >= inc) && (randomArray[j - inc] > temp))
                    {
                        randomArray[j] = randomArray[j - inc];
                        j = j - inc;
                    }
                    randomArray[j] = temp;
                    Draw();
                    lock (_locker)
                    {
                        g.Clear(Color.Black);
                    }
                }
                if (inc / 2 != 0)
                    inc = inc / 2;
                else if (inc == 1)
                    inc = 0;
                else
                    inc = 1;
            }
        }

        // Cocktail Shaker Sort

        private void CocktailShakerSort(CancellationToken token)
        {
            bool isSwapped = true;
            int start = 0;
            int end = randomArray.Length;

            int temp;

            while (isSwapped == true)
            {
                
                isSwapped = false;

                for (int i = start; i < end - 1; ++i)
                {
                    if (token.IsCancellationRequested)
                    {
                        return;
                    }

                    if (randomArray[i] > randomArray[i + 1])
                    {
                        temp = randomArray[i];
                        randomArray[i] = randomArray[i+1];
                        randomArray[i+1] = temp;

                        isSwapped = true;
                    }
                }
                Draw();
                lock (_locker)
                {
                    g.Clear(Color.Black);
                }
                if (isSwapped == false)
                    break;

                isSwapped = false;

                end = end - 1;

                for (int i = end - 1; i >= start; i--)
                {
                    if (token.IsCancellationRequested)
                    {
                        return;
                    }
                    if (randomArray[i] > randomArray[i + 1])
                    {
                        temp = randomArray[i];
                        randomArray[i] = randomArray[i + 1];
                        randomArray[i + 1] = temp;

                        isSwapped = true;
                    }
                }
                Draw();
                lock (_locker)
                {
                    g.Clear(Color.Black);
                }
                start = start + 1;
            }
        }

        // Gnome Sort
        private async Task GnomeSort(CancellationToken token)
        {
            int index = 0;

            while (index < randomArray.Length)
            { //If there is no pot next to the gnome, he is done.
                if (index == 0) //If the gnome is at the start of the line...
                {
                    index++;//he steps forward
                }

                //If the pots next to the gnome are in the correct order...
                if (randomArray[index] >= randomArray[index - 1])
                {
                    index++;//he goes to the next pot
                }
                else //If the pots are in the wrong order, he switches them.
                {
                    int temp = 0;
                    temp = randomArray[index];
                    randomArray[index] = randomArray[index - 1];
                    randomArray[index - 1] = temp;
                    index--;
                }
                if(index % 2 == 0)
                {
                    Draw();
                    lock (_locker)
                    {
                        g.Clear(Color.Black);
                    }
                }
                
            }
        }
    }
}