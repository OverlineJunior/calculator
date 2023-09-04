namespace calculator;

public partial class Form1 : Form {
    public const int MAX_ROWS = 4;
    public const int MAX_COLUMNS = 3;
    public const int BUTTON_SIZE = 100;
    public const int MARGIN = 3;

    public Form1() {
        FlowLayoutPanel panel = new();
        panel.Size = new Size(
            BUTTON_SIZE * MAX_COLUMNS + MAX_COLUMNS * 2 * MARGIN,
            BUTTON_SIZE * MAX_ROWS + MAX_ROWS * 2 * MARGIN
        );
        panel.BackColor = Color.Aqua;
        panel.Margin = new Padding(MARGIN);
        panel.FlowDirection = FlowDirection.RightToLeft;

        for (int i = 0; i <= 9; i++) {
            panel.Controls.Add(B(i.ToString()));
        }

        Controls.Add(panel);

        InitializeComponent();
    }

    public Button B(string text) {
        Button b = new Button();
        b.Text = text;
        b.Size = new Size(BUTTON_SIZE, BUTTON_SIZE);
        b.Margin = new Padding(MARGIN);

        return b;
    }
}
