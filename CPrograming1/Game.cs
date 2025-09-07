using SkiaSharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Text;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Schema;

namespace CPrograming1
{
    public class Bottle
    {
        public int maxWater = 10;
        //item1 = color, item2 = amount
        public List<(Color, int)> waters = new List<(Color, int)>();
        public Bottle()
        {
            
        }
        public Bottle(List<(Color, int)> addedWaters)
        {
            waters = addedWaters;
        }

        public void AddWater(Bottle anotherBottle)
        {
            //check if another bottle has water or not
            if(anotherBottle.waters.Count < 1)
            {
                return;
            }

            (Color, int) anotherLastWater = anotherBottle.waters[anotherBottle.waters.Count - 1];

            //check if this bottle has space
            if (getWaterAmount() == 0)
            {
                this.waters.Add(anotherLastWater);
                anotherBottle.waters.RemoveAt(anotherBottle.waters.Count - 1);
            } else if (!IsFull())
            {
                (Color, int) thisLastWater = this.waters[this.waters.Count - 1];
                //get the transfer amount
                int space = maxWater - getWaterAmount();
                int transferAmount = Math.Min(space, anotherLastWater.Item2);

                //transfer the water
                if (thisLastWater.Item1 == anotherLastWater.Item1)
                    this.waters[this.waters.Count - 1] = (thisLastWater.Item1, thisLastWater.Item2 + transferAmount);
                else
                    this.waters.Add((anotherLastWater.Item1, transferAmount));

                //update another bottles
                if (transferAmount == anotherLastWater.Item2)
                    anotherBottle.waters.RemoveAt(anotherBottle.waters.Count - 1);
                else
                    anotherBottle.waters[anotherBottle.waters.Count - 1] = (anotherLastWater.Item1, anotherLastWater.Item2 - transferAmount);
            }
        }

        private bool IsFull()
        {
            if(getWaterAmount() >= maxWater)return true;
            return false;
        }

        public (Color,int)[] getWaters()
        {
            return waters.ToArray();
        }

        public int getWaterAmount()
        {
            int total = 0;
            foreach (var water in waters)
            {
                total += water.Item2;
            }
            return total;
        }
    }

    public class Game
    {
        private Wave wave = new Wave();
        private System.Windows.Forms.Timer timer;
        private static Random random = new Random();

        private static Color[] colors = new Color[] { Color.Red, Color.Blue, Color.Yellow, Color.Green, Color.Purple, Color.Orange, Color.Brown, Color.Pink, Color.Black };
        private int currentBottleIndex = -1;
        private List<Bottle> bottles = new List<Bottle>();
        private List<PictureBox> pictureBoxes = new List<PictureBox>();

        public Game()
        {
            
        }

        public void start()
        {
            removeComponents();
            int bottleCount = random.Next(3, 6);
            Color[] newColors = colors.OrderBy(x => random.Next()).ToArray();
            List<(Color, int)> newWaters = new List<(Color, int)> { };
            for (int i = 0; i < bottleCount; i++)
            {
                newWaters.Add((newColors[i], 10));
            }
        }

        public void initialize(MainForm form, System.ComponentModel.IContainer container)
        {
            timer = new System.Windows.Forms.Timer(container);
            timer.Tick += new System.EventHandler(tick);
            bottles.Add(new Bottle());
            bottles.Add(new Bottle(new List<(Color, int)>() { (Color.Red, 4), (Color.Blue, 2) }));
            bottles.Add(new Bottle(new List<(Color, int)>() { (Color.Yellow, 2), (Color.Blue, 7) }));
            bottles.Add(new Bottle(new List<(Color, int)>() { (Color.Red, 7), (Color.Yellow, 2) }));

            foreach (Bottle bottle in bottles)
            {
                pictureBoxes.Add(new PictureBox());
            }

            for (int i = 0; i < bottles.Count; i++)
            {
                ((System.ComponentModel.ISupportInitialize)pictureBoxes[i]).BeginInit();
                pictureBoxes[i].Location = new System.Drawing.Point(50 + i * 100, 100);
                pictureBoxes[i].Name = "pictureBox" + i.ToString();
                pictureBoxes[i].Size = new System.Drawing.Size(50, 100);
                pictureBoxes[i].TabIndex = i + bottles.Count;
                pictureBoxes[i].TabStop = false;
                pictureBoxes[i].Click += new System.EventHandler(this.pictureBox_Click);
                ((System.ComponentModel.ISupportInitialize)pictureBoxes[i]).EndInit();

                form.Controls.Add(pictureBoxes[i]);
            }
            timer.Enabled = true;
        }

        private void pictureBox_Click(object sender, EventArgs e)
        {
            PictureBox clickedPicture = sender as PictureBox;
            int clickedIndex = pictureBoxes.IndexOf(clickedPicture);
            // ----- choiced bottle
            if (currentBottleIndex == -1)
            {
                currentBottleIndex = clickedIndex;
                pictureBoxes[clickedIndex].Location = new Point(50 + clickedIndex * 100, 80);
            }
            // ----- cancel current bottle
            else if (currentBottleIndex == clickedIndex)
            {
                pictureBoxes[currentBottleIndex].Location = new Point(50 + currentBottleIndex * 100, 100);
                currentBottleIndex = -1;
            }
            // ----- add water
            else
            {
                pictureBoxes[currentBottleIndex].Location = new Point(50 + currentBottleIndex * 100, 100);
                bottles[clickedIndex].AddWater(bottles[currentBottleIndex]);
                currentBottleIndex = -1;
                update();
            }
        }
        private void tick(object sender, EventArgs e)
        {
            wave.updateImage();
            for(int i = 0; i < bottles.Count; i++)
            {
                //if (bottles[i].waters.Count < 1) continue;
                //-----create new bitmap for empty bottle

                SKImageInfo info = new SKImageInfo(wave.width, wave.height);
                SKSurface surface = SKSurface.Create(info);

                //-----draw each water bitmap on bottle bitmap
                using (var canvas = surface.Canvas)
                using (var paint = new SKPaint())
                {
                    paint.Color = SKColors.White;
                    canvas.Clear(paint.Color);
                    paint.IsAntialias = true;
                    float currentWaterAmount = bottles[i].getWaterAmount();
                    for(int j = bottles[i].waters.Count - 1; j >= 0; j--)
                    {
                        (Color, int) water = bottles[i].waters[j];
                        float heightpercent = currentWaterAmount / (float)bottles[i].maxWater;
                        SKBitmap waterBitmap = wave.getColorCoverBitmap(water.Item1, heightpercent);
                        canvas.DrawBitmap(waterBitmap, 0, pictureBoxes[i].Height - waterBitmap.Height, paint);
                        currentWaterAmount -= water.Item2;
                    }
                }

                //-----output final bitmap and setup picture
                using (SKImage image = surface.Snapshot())
                using (SKData data = image.Encode(SKEncodedImageFormat.Png, 100))
                using (MemoryStream mStream = new MemoryStream(data.ToArray()))
                {
                    pictureBoxes[i].Image = new Bitmap(mStream, false);
                }
            }
        }

        private void update()
        {
            bool isWin = true;
            for (int i = 0; i < bottles.Count; i++)
            {
                if (bottles[i].waters.Count > 1) isWin = false;
            }
            if (isWin)
            {
                MessageBox.Show("You Win!");
                //start();
            }
        }

        //remove buttons from form controls
        public void removeComponents()
        {
            foreach (var pictureBox in pictureBoxes)
            {
                pictureBox.Dispose();
            }
            bottles = new List<Bottle>();
            pictureBoxes = new List<PictureBox>();
        }

        public void endGame()
        {
            if(timer != null)
            {
                timer.Enabled = false;
                removeComponents();
                timer.Dispose();
            }
        }
    }
}
