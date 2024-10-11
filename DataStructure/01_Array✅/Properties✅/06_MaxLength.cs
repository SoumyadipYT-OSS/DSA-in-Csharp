using System;

/*
    Namespace: System;
    Class: Array;

    Property Value: Int32; Gets the maximum number of elements in all the dimensions of the Array.
    Remarks: MaxLength property comes from `System.Array` class.
*/

using System;
using System.Windows.Forms;

public class MaxLengthExample : Form {
    private TextBox textBox;

    public MaxLengthExample() {
        textBox = new TextBox();
        textBox.MaxLength = 10; // Set the maximum length to 10 characters
        textBox.Location = new System.Drawing.Point(10, 10);
        this.Controls.Add(textBox);
    }

    [STAThread]
    static void Main() {
        Application.EnableVisualStyles();
        Application.Run(new MaxLengthExample());
    }
}


// The MaxLength property returns the maximum number of elements in all the dimensions of the Array.