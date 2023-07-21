namespace Example
{
    public partial class DangNhap : Form
    {
        public DangNhap()
        {
            InitializeComponent();
        }

        private void blogin_Click(object sender, EventArgs e)
        {
            String txtuser = tuser.Text.ToString();
            String txtpass = tpass.Text.ToString();
            if (txtuser == "phat" && txtpass == "123456")
            {
                Menu objMenu = new Menu();
                objMenu.ShowDialog();
            }
        }

        private void bexit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}