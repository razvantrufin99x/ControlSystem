namespace ControlSystem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public MeasurementsSystem ms = new MeasurementsSystem();

        private void Form1_Load(object sender, EventArgs e)
        {
            ms.mq.Value = 100.0f;

            ms.si.IsOn = true;

            ms.ss.expectedValue = 90.9f;
            ms.ss.maxError = 5.0f;
            ms.ss.minError = 3.0f;
            ms.ss.procentualError = 1.0f;

            ms.sc.expectedValue = 99.9f;
            ms.sc.maxError = 6.0f;
            ms.sc.minError = 5.0f;
            ms.sc.procentualError = 0.1f;

            ms.se.isOn = true;

            ms.voq.Value = 109.0f;


        }
    }
}