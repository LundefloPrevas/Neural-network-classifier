using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Neural_network_classifier.NewFolder1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //Input numbers
        int[] inputArray = new int[25];
        //box1 numbers
        int[] box1Array = new int[25];
        //box2 numbers
        int[] box2Array = new int[25];
        //box2 numbers
        int[] box3Array = new int[25];
        //box2 numbers
        int[] box4Array = new int[25];
        //box2 numbers
        int[] box5Array = new int[25];
        //box2 numbers
        int[] box6Array = new int[25];

        //Bitmap boxes
        Bitmap bmp1 = new Bitmap(100, 100);
        Bitmap bmp2 = new Bitmap(100, 100);
        Bitmap bmp3 = new Bitmap(100, 100);
        Bitmap bmp4 = new Bitmap(100, 100);
        Bitmap bmp5 = new Bitmap(100, 100);
        Bitmap bmp6 = new Bitmap(100, 100);

        //Creating Bitmap Image
        Random rand = new Random();

        //Color Values
        int blueValue1 = 0;
        int greenValue1 = 0;
        int blueValue2 = 0;
        int greenValue2 = 0;
        int blueValue3 = 0;
        int greenValue3 = 0;
        int blueValue4 = 0;
        int greenValue4 = 0;
        int blueValue5 = 0;
        int greenValue5 = 0;
        int blueValue6 = 0;
        int greenValue6 = 0;

        //Text on input buttons
        private string InputText(string theButton)
        {
            switch (theButton)
            {
                case "0":
                    return "1";
                case "1":
                    return "-1";
                case "-1":
                    return "0";
                default:
                    return "0";
            }
        }

        //Color on input buttons
        private Color InputColor(string theButton)
        {
            switch (theButton)
            {
                case "0":
                    return Color.LightGray;
                case "1":
                    return Color.LightSkyBlue;
                case "-1":
                    return Color.LightGreen;
                default:
                    return Color.LightGray;
            }
        }

        //Value of input buttons
        private int InputNumber(string theButton)
        {
            switch (theButton)
            {
                case "0":
                    return 0;
                case "1":
                    return 1;
                case "-1":
                    return -1;
                default:
                    return 0;
            }
        }


        private void CreateBoxes()  //Fill boxes with randomized tiles
        {
            //Create Box 1
            pictureBox1.Image = bmp1;
            for (int y = 0; y < 100; y = y + 20)
            {
                for (int x = 0; x < 100; x = x + 20)
                {
                    Color choosenColor = Color.LightGray;
                    int colorPick = rand.Next(2);

                    switch (colorPick)  //Blue
                    {
                        case 0:
                            choosenColor = Color.LightGray;
                            break;
                        case 1:
                            choosenColor = Color.LightSkyBlue;
                            break;
                    }

                    for (int c = 0; c < 20; c++)
                    {
                        for (int f = 0; f < 20; f++)
                        {
                            bmp1.SetPixel(x + c, f + y, choosenColor);
                        }
                    }
                }
            }

            //Create Box 2
            pictureBox2.Image = bmp2;
            for (int y = 0; y < 100; y = y + 20)
            {
                for (int x = 0; x < 100; x = x + 20)
                {
                    Color choosenColor = Color.LightGray;
                    int colorPick = rand.Next(2);

                    switch (colorPick)  //Green
                    {
                        case 0:
                            choosenColor = Color.LightGray;
                            break;
                        case 1:
                            choosenColor = Color.LightGreen;
                            break;
                    }

                    for (int c = 0; c < 20; c++)
                    {
                        for (int f = 0; f < 20; f++)
                        {
                            bmp2.SetPixel(x + c, f + y, choosenColor);
                        }
                    }
                }
            }

            //Create Box 3
            pictureBox3.Image = bmp3;
            for (int y = 0; y < 100; y = y + 20)
            {
                for (int x = 0; x < 100; x = x + 20)
                {
                    Color choosenColor = Color.LightGray;
                    int colorPick = rand.Next(2);

                    switch (colorPick)  //Blue
                    {
                        case 0:
                            choosenColor = Color.LightGray;
                            break;
                        case 1:
                            choosenColor = Color.LightSkyBlue;
                            break;
                    }

                    for (int c = 0; c < 20; c++)
                    {
                        for (int f = 0; f < 20; f++)
                        {
                            bmp3.SetPixel(x + c, f + y, choosenColor);
                        }
                    }
                }
            }

            //Create Box 4
            pictureBox4.Image = bmp4;
            for (int y = 0; y < 100; y = y + 20)
            {
                for (int x = 0; x < 100; x = x + 20)
                {
                    Color choosenColor = Color.LightGray;
                    int colorPick = rand.Next(2);

                    switch (colorPick)  //Green
                    {
                        case 0:
                            choosenColor = Color.LightGray;
                            break;
                        case 1:
                            choosenColor = Color.LightGreen;
                            break;
                    }

                    for (int c = 0; c < 20; c++)
                    {
                        for (int f = 0; f < 20; f++)
                        {
                            bmp4.SetPixel(x + c, f + y, choosenColor);
                        }
                    }
                }
            }

            //Create Box 5
            pictureBox5.Image = bmp5;
            for (int y = 0; y < 100; y = y + 20)
            {
                for (int x = 0; x < 100; x = x + 20)
                {
                    Color choosenColor = Color.LightGray;
                    int colorPick = rand.Next(2);

                    switch (colorPick)  //Blue
                    {
                        case 0:
                            choosenColor = Color.LightGray;
                            break;
                        case 1:
                            choosenColor = Color.LightSkyBlue;
                            break;
                    }

                    for (int c = 0; c < 20; c++)
                    {
                        for (int f = 0; f < 20; f++)
                        {
                            bmp5.SetPixel(x + c, f + y, choosenColor);
                        }
                    }
                }
            }

            //Create Box 6
            pictureBox6.Image = bmp6;
            for (int y = 0; y < 100; y = y + 20)
            {
                for (int x = 0; x < 100; x = x + 20)
                {
                    Color choosenColor = Color.LightGray;
                    int colorPick = rand.Next(2);

                    switch (colorPick)  //Green
                    {
                        case 0:
                            choosenColor = Color.LightGray;
                            break;
                        case 1:
                            choosenColor = Color.LightGreen;
                            break;
                    }

                    for (int c = 0; c < 20; c++)
                    {
                        for (int f = 0; f < 20; f++)
                        {
                            bmp6.SetPixel(x + c, f + y, choosenColor);
                        }
                    }
                }
            }
        }

        private void CheckColors()  //Checks the values of the colors int the boxes
        {
            //Get color values for Box 1
            int box1count = 0;
            for (int y = 0; y < 100; y = y + 20)
            {
                for (int x = 0; x < 100; x = x + 20)
                {
                    Color theColor = bmp1.GetPixel(x, y);
                    switch (theColor.R)
                    {
                        case 211:
                            box1Array[box1count] = 0;
                            break;
                        case 135:
                            box1Array[box1count] = 1;
                            break;
                        case 144:
                            box1Array[box1count] = -1;
                            break;
                    }
                    //Console.WriteLine(theColor1);
                    box1count = box1count + 1;
                }
            }

            //Get color values for Box 2
            int box2count = 0;
            for (int y = 0; y < 100; y = y + 20)
            {
                for (int x = 0; x < 100; x = x + 20)
                {
                    Color theColor = bmp2.GetPixel(x, y);
                    switch (theColor.R)
                    {
                        case 211:
                            box2Array[box2count] = 0;
                            break;
                        case 135:
                            box2Array[box2count] = 1;
                            break;
                        case 144:
                            box2Array[box2count] = -1;
                            break;
                    }
                    //Console.WriteLine(theColor2);
                    box2count = box2count + 1;
                }
            }

            //Get color values for Box 3
            int box3count = 0;
            for (int y = 0; y < 100; y = y + 20)
            {
                for (int x = 0; x < 100; x = x + 20)
                {
                    Color theColor = bmp3.GetPixel(x, y);
                    switch (theColor.R)
                    {
                        case 211:
                            box3Array[box3count] = 0;
                            break;
                        case 135:
                            box3Array[box3count] = 1;
                            break;
                        case 144:
                            box3Array[box3count] = -1;
                            break;
                    }
                    //Console.WriteLine(theColor2);
                    box3count = box3count + 1;
                }
            }

            //Get color values for Box 4
            int box4count = 0;
            for (int y = 0; y < 100; y = y + 20)
            {
                for (int x = 0; x < 100; x = x + 20)
                {
                    Color theColor = bmp4.GetPixel(x, y);
                    switch (theColor.R)
                    {
                        case 211:
                            box4Array[box4count] = 0;
                            break;
                        case 135:
                            box4Array[box4count] = 1;
                            break;
                        case 144:
                            box4Array[box4count] = -1;
                            break;
                    }
                    //Console.WriteLine(theColor2);
                    box4count = box4count + 1;
                }
            }

            //Get color values for Box 5
            int box5count = 0;
            for (int y = 0; y < 100; y = y + 20)
            {
                for (int x = 0; x < 100; x = x + 20)
                {
                    Color theColor = bmp5.GetPixel(x, y);
                    switch (theColor.R)
                    {
                        case 211:
                            box5Array[box5count] = 0;
                            break;
                        case 135:
                            box5Array[box5count] = 1;
                            break;
                        case 144:
                            box5Array[box5count] = -1;
                            break;
                    }
                    //Console.WriteLine(theColor2);
                    box5count = box5count + 1;
                }
            }

            //Get color values for Box 6
            int box6count = 0;
            for (int y = 0; y < 100; y = y + 20)
            {
                for (int x = 0; x < 100; x = x + 20)
                {
                    Color theColor = bmp6.GetPixel(x, y);
                    switch (theColor.R)
                    {
                        case 211:
                            box6Array[box6count] = 0;
                            break;
                        case 135:
                            box6Array[box6count] = 1;
                            break;
                        case 144:
                            box6Array[box6count] = -1;
                            break;
                    }
                    //Console.WriteLine(theColor2);
                    box6count = box6count + 1;
                }
            }
        }

        private void CompareValues()    //Compares the input values and the values in the boxes
        {
            //Blue or Green value?    //BOX 1
            blueValue1 = 0;
            greenValue1 = 0;
            //Checks Blue value
            for (int i = 0; i < inputArray.Length; i++)
            {
                if (inputArray[i] == 1 && box1Array[i] == 1)
                {
                    blueValue1 = blueValue1 + 1;
                }
            }
            //Checks Green value
            for (int i = 0; i < inputArray.Length; i++)
            {
                if (inputArray[i] == -1 && box1Array[i] == 1)
                {
                    blueValue1 = blueValue1 - 1;
                }
            }

            //Blue or Green value?      //BOX 2
            blueValue2 = 0;
            greenValue2 = 0;
            //Checks Blue value
            for (int i = 0; i < inputArray.Length; i++)
            {
                if (inputArray[i] == 1 && box2Array[i] == -1)
                {
                    greenValue2 = greenValue2 - 1;
                }
            }
            //Checks Green value
            for (int i = 0; i < inputArray.Length; i++)
            {
                if (inputArray[i] == -1 && box2Array[i] == -1)
                {
                    greenValue2 = greenValue2 + 1;
                }
            }

            //Blue or Green value?      //BOX 3
            blueValue3 = 0;
            greenValue3 = 0;
            //Checks Blue value
            for (int i = 0; i < inputArray.Length; i++)
            {
                if (inputArray[i] == 1 && box3Array[i] == 1)
                {
                    blueValue3 = blueValue3 + 1;
                }
            }
            //Checks Green value
            for (int i = 0; i < inputArray.Length; i++)
            {
                if (inputArray[i] == -1 && box3Array[i] == 1)
                {
                    blueValue3 = blueValue3 - 1;
                }
            }

            //Blue or Green value?      //BOX 4
            blueValue4 = 0;
            greenValue4 = 0;
            //Checks Blue value
            for (int i = 0; i < inputArray.Length; i++)
            {
                if (inputArray[i] == 1 && box4Array[i] == -1)
                {
                    greenValue4 = greenValue4 - 1;
                }
            }
            //Checks Green value
            for (int i = 0; i < inputArray.Length; i++)
            {
                if (inputArray[i] == -1 && box4Array[i] == -1)
                {
                    greenValue4 = greenValue4 + 1;
                }
            }

            //Blue or Green value?      //BOX 5
            blueValue5 = 0;
            greenValue5 = 0;
            //Checks Blue value
            for (int i = 0; i < inputArray.Length; i++)
            {
                if (inputArray[i] == 1 && box5Array[i] == 1)
                {
                    blueValue5 = blueValue5 + 1;
                }
            }
            //Checks Green value
            for (int i = 0; i < inputArray.Length; i++)
            {
                if (inputArray[i] == -1 && box5Array[i] == 1)
                {
                    blueValue5 = blueValue5 - 1;
                }
            }

            //Blue or Green value?      //BOX 6
            blueValue6 = 0;
            greenValue6 = 0;
            //Checks Blue value
            for (int i = 0; i < inputArray.Length; i++)
            {
                if (inputArray[i] == 1 && box6Array[i] == -1)
                {
                    greenValue6 = greenValue6 - 1;
                }
            }
            //Checks Green value
            for (int i = 0; i < inputArray.Length; i++)
            {
                if (inputArray[i] == -1 && box6Array[i] == -1)
                {
                    greenValue6 = greenValue6 + 1;
                }
            }
        }

        //UI

        private void Form1_Load(object sender, EventArgs e)
        {
            //Fill boxes with randomized tiles
            CreateBoxes();

            //Checks if the randomization is solveable
            CheckColors();

            //Check the values of the tiles in the boxes
            CompareValues();

        }


        private void button_input1_Click(object sender, EventArgs e)
        {
            this.button_input1.Text = InputText(this.button_input1.Text);
            this.button_input1.BackColor = InputColor(this.button_input1.Text);
            inputArray[0] = InputNumber(this.button_input1.Text);
        }

        private void button_input2_Click(object sender, EventArgs e)
        {
            this.button_input2.Text = InputText(this.button_input2.Text);
            this.button_input2.BackColor = InputColor(this.button_input2.Text);
            inputArray[1] = InputNumber(this.button_input2.Text);
        }

        private void button_input3_Click(object sender, EventArgs e)
        {
            this.button_input3.Text = InputText(this.button_input3.Text);
            this.button_input3.BackColor = InputColor(this.button_input3.Text);
            inputArray[2] = InputNumber(this.button_input3.Text);
        }

        private void button_input4_Click(object sender, EventArgs e)
        {
            this.button_input4.Text = InputText(this.button_input4.Text);
            this.button_input4.BackColor = InputColor(this.button_input4.Text);
            inputArray[3] = InputNumber(this.button_input4.Text);
        }

        private void button_input5_Click(object sender, EventArgs e)
        {
            this.button_input5.Text = InputText(this.button_input5.Text);
            this.button_input5.BackColor = InputColor(this.button_input5.Text);
            inputArray[4] = InputNumber(this.button_input5.Text);
        }

        private void button_input6_Click(object sender, EventArgs e)
        {
            this.button_input6.Text = InputText(this.button_input6.Text);
            this.button_input6.BackColor = InputColor(this.button_input6.Text);
            inputArray[5] = InputNumber(this.button_input6.Text);
        }

        private void button_input7_Click(object sender, EventArgs e)
        {
            this.button_input7.Text = InputText(this.button_input7.Text);
            this.button_input7.BackColor = InputColor(this.button_input7.Text);
            inputArray[6] = InputNumber(this.button_input7.Text);
        }

        private void button_input8_Click(object sender, EventArgs e)
        {
            this.button_input8.Text = InputText(this.button_input8.Text);
            this.button_input8.BackColor = InputColor(this.button_input8.Text);
            inputArray[7] = InputNumber(this.button_input8.Text);
        }

        private void button_input9_Click(object sender, EventArgs e)
        {
            this.button_input9.Text = InputText(this.button_input9.Text);
            this.button_input9.BackColor = InputColor(this.button_input9.Text);
            inputArray[8] = InputNumber(this.button_input9.Text);
        }

        private void button_input10_Click(object sender, EventArgs e)
        {
            this.button_input10.Text = InputText(this.button_input10.Text);
            this.button_input10.BackColor = InputColor(this.button_input10.Text);
            inputArray[9] = InputNumber(this.button_input10.Text);
        }

        private void button_input11_Click(object sender, EventArgs e)
        {
            this.button_input11.Text = InputText(this.button_input11.Text);
            this.button_input11.BackColor = InputColor(this.button_input11.Text);
            inputArray[10] = InputNumber(this.button_input11.Text);
        }

        private void button_input12_Click(object sender, EventArgs e)
        {
            this.button_input12.Text = InputText(this.button_input12.Text);
            this.button_input12.BackColor = InputColor(this.button_input12.Text);
            inputArray[11] = InputNumber(this.button_input12.Text);
        }

        private void button_input13_Click(object sender, EventArgs e)
        {
            this.button_input13.Text = InputText(this.button_input13.Text);
            this.button_input13.BackColor = InputColor(this.button_input13.Text);
            inputArray[12] = InputNumber(this.button_input13.Text);
        }

        private void button_input14_Click(object sender, EventArgs e)
        {
            this.button_input14.Text = InputText(this.button_input14.Text);
            this.button_input14.BackColor = InputColor(this.button_input14.Text);
            inputArray[13] = InputNumber(this.button_input14.Text);
        }

        private void button_input15_Click(object sender, EventArgs e)
        {
            this.button_input15.Text = InputText(this.button_input15.Text);
            this.button_input15.BackColor = InputColor(this.button_input15.Text);
            inputArray[14] = InputNumber(this.button_input15.Text);
        }

        private void button_input16_Click(object sender, EventArgs e)
        {
            this.button_input16.Text = InputText(this.button_input16.Text);
            this.button_input16.BackColor = InputColor(this.button_input16.Text);
            inputArray[15] = InputNumber(this.button_input16.Text);
        }

        private void button_input17_Click(object sender, EventArgs e)
        {
            this.button_input17.Text = InputText(this.button_input17.Text);
            this.button_input17.BackColor = InputColor(this.button_input17.Text);
            inputArray[16] = InputNumber(this.button_input17.Text);
        }

        private void button_input18_Click(object sender, EventArgs e)
        {
            this.button_input18.Text = InputText(this.button_input18.Text);
            this.button_input18.BackColor = InputColor(this.button_input18.Text);
            inputArray[17] = InputNumber(this.button_input18.Text);
        }

        private void button_input19_Click(object sender, EventArgs e)
        {
            this.button_input19.Text = InputText(this.button_input19.Text);
            this.button_input19.BackColor = InputColor(this.button_input19.Text);
            inputArray[18] = InputNumber(this.button_input19.Text);
        }

        private void button_input20_Click(object sender, EventArgs e)
        {
            this.button_input20.Text = InputText(this.button_input20.Text);
            this.button_input20.BackColor = InputColor(this.button_input20.Text);
            inputArray[19] = InputNumber(this.button_input20.Text);
        }

        private void button_input21_Click(object sender, EventArgs e)
        {
            this.button_input21.Text = InputText(this.button_input21.Text);
            this.button_input21.BackColor = InputColor(this.button_input21.Text);
            inputArray[20] = InputNumber(this.button_input21.Text);
        }

        private void button_input22_Click(object sender, EventArgs e)
        {
            this.button_input22.Text = InputText(this.button_input22.Text);
            this.button_input22.BackColor = InputColor(this.button_input22.Text);
            inputArray[21] = InputNumber(this.button_input22.Text);
        }

        private void button_input23_Click(object sender, EventArgs e)
        {
            this.button_input23.Text = InputText(this.button_input23.Text);
            this.button_input23.BackColor = InputColor(this.button_input23.Text);
            inputArray[22] = InputNumber(this.button_input23.Text);
        }

        private void button_input24_Click(object sender, EventArgs e)
        {
            this.button_input24.Text = InputText(this.button_input24.Text);
            this.button_input24.BackColor = InputColor(this.button_input24.Text);
            inputArray[23] = InputNumber(this.button_input24.Text);
        }

        private void button_input25_Click(object sender, EventArgs e)
        {
            this.button_input25.Text = InputText(this.button_input25.Text);
            this.button_input25.BackColor = InputColor(this.button_input25.Text);
            inputArray[24] = InputNumber(this.button_input25.Text);
            
        }

        private void button_checkResult_Click(object sender, EventArgs e)
        {
            //Get Color values form boxes

            CheckColors();

            //Compares the input values and the values in the boxes
            CompareValues();

            //Changes the lables under the boxes
            if (blueValue1 > greenValue1)
                this.label_result1.Text = "Blue";
            else if (greenValue1 > blueValue1)
                this.label_result1.Text = "Green";
            else
                this.label_result1.Text = "Grey";

            if (blueValue2 > greenValue2)
                this.label_result2.Text = "Blue";
            else if (greenValue2 > blueValue2)
                this.label_result2.Text = "Green";
            else
                this.label_result2.Text = "Grey";

            if (blueValue3 > greenValue3)
                this.label_result3.Text = "Blue";
            else if (greenValue3 > blueValue3)
                this.label_result3.Text = "Green";
            else
                this.label_result3.Text = "Grey";

            if (blueValue4 > greenValue4)
                this.label_result4.Text = "Blue";
            else if (greenValue4 > blueValue4)
                this.label_result4.Text = "Green";
            else
                this.label_result4.Text = "Grey";

            if (blueValue5 > greenValue5)
                this.label_result5.Text = "Blue";
            else if (greenValue5 > blueValue5)
                this.label_result5.Text = "Green";
            else
                this.label_result5.Text = "Grey";

            if (blueValue6 > greenValue6)
                this.label_result6.Text = "Blue";
            else if (greenValue6 > blueValue6)
                this.label_result6.Text = "Green";
            else
                this.label_result6.Text = "Grey";

            //Check if all boxes are solved
            if (this.label_result1.Text == "Blue" && this.label_result2.Text == "Green" && this.label_result3.Text == "Blue" &&
                this.label_result4.Text == "Green" && this.label_result5.Text == "Blue" && this.label_result6.Text == "Green")
            {
                Console.WriteLine("Success!");
            }
            else
                Console.WriteLine("Fail, try again!");
        }

        

        private void button_reset_Click(object sender, EventArgs e)
        {

            //Fill boxes with randomized tiles
            CreateBoxes();

            //Check if solveable
            CheckColors();
        }
    }
}
