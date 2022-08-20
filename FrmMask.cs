using System;

namespace Mask;
public partial class FrmMask : Form
{
    public FrmMask() =>  InitializeComponent();
    private void BtnGo_Click(object sender, EventArgs e)
    {
        // Usage :
        //      string s         = txtInput.Text;
        //      string m         = txtMask.Text.
        //      string Result    = s.ToMask( m );
        //        ou
        //      string Result    = s.ToMask( "___.___.___-__" );
        //      txtResult.Text   = s.ToMask( "___.___.___-__" );
        //                 or ( much better)

        txtResult.Text = (txtInput.Text).ToMask( txtMask.Text);
    }
}