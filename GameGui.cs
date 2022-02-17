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
namespace Lab4GameOfLife
{
    public partial class GameGui : Form
    {
        private const int GRID_WIDTH = 450;
        private const int BUTTON_WIDTH = 25;
        private const int CELLS = GRID_WIDTH / BUTTON_WIDTH;
        private static Color CELLS_COLOUR;
        private GameEngine engine = null;

        public GameGui()
        {
            InitializeComponent();

            engine = new GameEngine(CELLS, CELLS);


        }


        private void GameGui_Load(object sender, EventArgs e)
        {
            for (var j = 0; j + BUTTON_WIDTH <= GRID_WIDTH; j += BUTTON_WIDTH)
                for (var i = 0; i + BUTTON_WIDTH <= GRID_WIDTH; i += BUTTON_WIDTH)
                {
                    Button newButton = new Button();
                    newButton.Size = new Size(BUTTON_WIDTH, BUTTON_WIDTH);
                    newButton.Location = new Point(i, j);
                    newButton.Click += NewButton_Click;
                    mainGroupBox.Controls.Add(newButton);
                }
            CELLS_COLOUR = Color.Red;
            pauseButton.Enabled = false;
            saveButton.Enabled = false;

            UpdateColours();
        }
           

        private void UpdateColours()
        {
            for (var i = 0; i < mainGroupBox.Controls.Count; i++)
            {
                var y = i / engine.Height;
                var x = i % engine.Width;

                var yt = y;
                var xt = x;
                var index = 0;
                int R = 0, G = 0, B = 0;

                if (engine[y, x].A == 0)
                    mainGroupBox.Controls[i].BackColor = Color.LightGray;


                else if (engine[y, x].A == 255)
                {


                    mainGroupBox.Controls[i].BackColor = engine[y, x];
                }
            }
        }

        private void NewButton_Click(object sender, EventArgs e)
        {
            if (timer.Enabled == true)
            {
                return;
            }
            var i = mainGroupBox.Controls.IndexOf(sender as Button);
            var y = i / engine.Height;
            var x = i % engine.Width;

            if (engine[y, x].A == 0)
                {

                engine[y, x] = CELLS_COLOUR;
                mainGroupBox.Controls[i].BackColor = CELLS_COLOUR;

                //   mainGroupBox.Controls[i].BackColor = CELLS_COLOUR;

                /*    if (CELLS_COLOUR == Color.Red)
                    {
                        engine[y, x] = Color.FromArgb(255, 255, 0, 0);
                        mainGroupBox.Controls[i].BackColor = CELLS_COLOUR;
                    }

                    if (CELLS_COLOUR == Color.Green)
                    {
                        engine[y, x] = Color.FromArgb(255, 0, 255, 0);
                        mainGroupBox.Controls[i].BackColor = CELLS_COLOUR;
                    }

                    if (CELLS_COLOUR == Color.Blue)
                    {
                        engine[y, x] = Color.FromArgb(255, 0, 0, 255);
                        mainGroupBox.Controls[i].BackColor = CELLS_COLOUR;
                    }*/
            }
                else if (engine[y, x].A == 255)
                {
                    engine[y, x] = Color.FromArgb(0, 0, 0, 0); 
                    mainGroupBox.Controls[i].BackColor = Color.LightGray;
                }

        }

        private void timer_Tick(object sender, EventArgs e)
        {
            engine.Tick();
            genTextBox.Text = engine.Ticks.ToString();
            UpdateColours();
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            timer.Start();
            startButton.Enabled = false;
            pauseButton.Enabled = true;
            saveButton.Enabled = false;

        }

        private void pauseButton_Click(object sender, EventArgs e)
        {
            timer.Stop();
            pauseButton.Enabled = false;
            startButton.Enabled = true;
            saveButton.Enabled = true;


        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            timer.Stop();
            pauseButton.Enabled = false;
            startButton.Enabled = true;
            

            engine = new GameEngine(engine.Height, engine.Width);
            genTextBox.Text = engine.Ticks.ToString();

            UpdateColours();
        }


        private void radioColorRed_CheckedChanged(object sender, EventArgs e)
        {
            CELLS_COLOUR = Color.Red;
        }

        private void radioColorGreen_CheckedChanged(object sender, EventArgs e)
        {
            CELLS_COLOUR = Color.Green;
        }

        private void radioColorBlue_CheckedChanged(object sender, EventArgs e)
        {
            CELLS_COLOUR = Color.Blue;
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            StreamWriter outputFile;

            SaveFileDialog saveFileDialog1 = new SaveFileDialog();

            saveFileDialog1.Filter = "PPM Image formate (*-ppm)|*-ppm";
            saveFileDialog1.RestoreDirectory = true;

                
            //      bmp = mainGroupBox  ;
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    outputFile = File.CreateText($"{saveFileDialog1.FileName}.ppm");

                    outputFile.WriteLine("P3");
                    outputFile.WriteLine("# Game of Life");
                    outputFile.WriteLine($"180 180");
                    outputFile.WriteLine("255");

                    for (int y = 0; y < 180; y++)
                        for (int x = 0; x < 180; x++)
                        {
                            if (engine[y / 10, x / 10].A == 0)
                                outputFile.Write("255 255 255 ");
                            if(engine[y / 10, x / 10].A == 255)
                                outputFile.Write($"{engine[y/10, x/10].R} {engine[y/10, x/10].G} {engine[y/10, x/10].B} ");
                        }
                    


                    //   for (var i = 0; i < mainGroupBox.Controls.Count; i++s)
                    // {
               //     for (var y = 0; y + BUTTON_WIDTH <= GRID_WIDTH; y += BUTTON_WIDTH)
                    //x              for (var x = 0; x + BUTTON_WIDTH <= GRID_WIDTH; x += BUTTON_WIDTH)
                 
                      //  for (int i = 0; i < 18; i++)
                   /*     //x              for (var x = 0; x + BUTTON_WIDTH <= GRID_WIDTH; x += BUTTON_WIDTH)
                        {
                            for (int y = 0; y < 180; y++)
                                for (int x = 0; x < 3240; x++)
                                {
                                    index = i * 18 + x / 180;
                                
                                {
                                    if (mainGroupBox.Controls[index].BackColor == Color.LightGray)
                                        outputFile.Write("211 211 211 ");
                                    if (mainGroupBox.Controls[index].BackColor == Color.Red)
                                        outputFile.Write("255 0 0 ");
                                    if (mainGroupBox.Controls[index].BackColor == Color.Green)
                                        outputFile.Write("0 255 0 ");
                                    if (mainGroupBox.Controls[index].BackColor == Color.Blue)
                                        outputFile.Write("0 0 255 ");
                                }
                                    
                                }

                        }*/

                        outputFile.Close();

                    
                }
                catch (Exception ex)
                {
                    MessageBox.Show(this, ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

     
    }
}

