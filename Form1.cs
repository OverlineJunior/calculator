namespace calculator;

public partial class Form1 : Form {
    private void btnClickMe_Click(object? sender, EventArgs e) {
        MessageBox.Show("Button Clicked!");
    }

    public Form1() {
        Button btnClickMe = new Button();
        btnClickMe.Text = "Click Me";
        btnClickMe.Location = new System.Drawing.Point(50, 50);
        btnClickMe.Click += new EventHandler(btnClickMe_Click);

        Controls.Add(btnClickMe);

        InitializeComponent();
    }
}
