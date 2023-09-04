namespace calculator;

public class NumberButton {
    public const int BUTTON_SIZE = 100;
    public const int MARGIN = 3;
    public readonly Button Button;

    public NumberButton(string text) {
        Button = new Button();
        Button.Text = text;
        Button.Size = new Size(BUTTON_SIZE, BUTTON_SIZE);
        Button.Margin = new Padding(MARGIN);
    }
}

public class ButtonPanel {
    public const int MAX_ROWS = 4;
    public const int MAX_COLUMNS = 3;
    public const int BUTTON_SIZE = 100;
    public const int MARGIN = 3;
    public readonly FlowLayoutPanel Layout;

    public ButtonPanel() {
        Layout = new FlowLayoutPanel();
        Layout.Size = new Size(
            BUTTON_SIZE * MAX_COLUMNS + MAX_COLUMNS * 2 * MARGIN,
            BUTTON_SIZE * MAX_ROWS + MAX_ROWS * 2 * MARGIN
        );
        Layout.BackColor = Color.Aqua;
        Layout.Margin = new Padding(MARGIN);
        Layout.FlowDirection = FlowDirection.RightToLeft;

        AddButtons();
    }

    private void AddButtons() {
        Layout.Controls.AddRange(new Control[] {
            new NumberButton("9").Button,
            new NumberButton("8").Button,
            new NumberButton("7").Button,
            new NumberButton("6").Button,
            new NumberButton("5").Button,
            new NumberButton("4").Button,
            new NumberButton("3").Button,
            new NumberButton("2").Button,
            new NumberButton("1").Button,
            new NumberButton("X").Button, // TEMP
            new NumberButton("0").Button,
            new NumberButton("=").Button, // TEMP
        });
    }
}

public partial class Form1 : Form {
    public Form1() {
        ButtonPanel buttonPanel = new();
        Controls.Add(buttonPanel.Layout);

        InitializeComponent();
    }
}
