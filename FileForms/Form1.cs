namespace FileForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Write_Click(object sender, EventArgs e)
        {
            string filePath = FilePath.Text;
            string content = FileContentWrite.Text;
            FileOperator.WriteToFile(filePath, content);
        }

        private void Read_Click(object sender, EventArgs e)
        {
            string filePath = FilePath.Text;
            FileContent.Text = FileOperator.ReadFileContents(filePath);
        }
    }
}
