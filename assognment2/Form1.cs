using System.Globalization;

namespace assognment2
{
    public partial class Form1 : Form
    {
        private Double calculateRevenue(int a_seats_number, int b_seats_number, int c_seats_number)
        {
            Double price_of_a_seats = calculateRevenuePerClass(a_seats_number, "A");
            Double price_of_b_seats = calculateRevenuePerClass(b_seats_number, "B");
            Double price_of_c_seats = calculateRevenuePerClass(c_seats_number, "C");
            return price_of_a_seats + price_of_b_seats + price_of_c_seats;
        }
        private Double calculateRevenuePerClass(int number_of_seats, String className)
        {
            if(className == "A")
            {
                return Convert.ToDouble(number_of_seats * A.price);
            }
            else if(className == "B") {
                return Convert.ToDouble(number_of_seats * B.price);
            }
            else if(className == "C")
            {
                return Convert.ToDouble(number_of_seats * C.price);
            }
            else
            {
                return 0;
            }
        }

        private Int32 checkIfInputIsNumeric(String number)
        {
            try
            {
                Int32 castedNumber = Int32.Parse(number);
                return castedNumber;
            }
            catch
            {
                label2.Text = "Your number is inccorect. Please try again";
                return 0;
            }
        }

        private void clearAllInputs()
        {
            TextBox[] all_inputs = new TextBox[] { textBox1, textBox2, textBox3, textBox4, textBox5, textBox6, textBox7}; 

            foreach(TextBox input in all_inputs)
            {
                input.Clear();
            }


        }
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Int32 a_seat_number = checkIfInputIsNumeric(textBox1.Text);
            Int32 b_seat_number = checkIfInputIsNumeric(textBox2.Text);
            Int32 c_seat_number = checkIfInputIsNumeric(textBox3.Text);

            textBox6.Text = calculateRevenuePerClass(a_seat_number, "A").ToString("C3", CultureInfo.CreateSpecificCulture("en-US"));
            textBox5.Text = calculateRevenuePerClass(b_seat_number, "B").ToString("C3", CultureInfo.CreateSpecificCulture("en-US"));
            textBox4.Text = calculateRevenuePerClass(c_seat_number, "C").ToString("C3", CultureInfo.CreateSpecificCulture("en-US"));

            textBox7.Text = calculateRevenue(a_seat_number, b_seat_number, c_seat_number).ToString("C3", CultureInfo.CreateSpecificCulture("en-US"));
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            clearAllInputs();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }
    }

    public class A
    {
        public const int price = 15;
    }

    public class B
    {
        public const int price = 12;
    }

    public class C
    {
        public const int price = 9;
    }
}