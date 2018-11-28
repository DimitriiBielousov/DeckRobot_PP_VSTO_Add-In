using Microsoft.Office.Interop.PowerPoint;
using Microsoft.Office.Tools.Ribbon;
using System.Drawing;

namespace DeckRobot_PP_VSTO_Add_In
{
    public partial class TestRibbon
    {
        private void MyRibbon_Load(object sender, RibbonUIEventArgs e)
        {
        }

        private void ToRightBoldRed_Button_Click(object sender, RibbonControlEventArgs e)
        {
            Application presentation = Globals.ThisAddIn.Application;
            int offset = 10;

            foreach (Slide slide in presentation.ActiveWindow.Selection.SlideRange)
            {
                foreach (Shape shape in slide.Shapes)
                {
                    if (shape.HasTextFrame == Microsoft.Office.Core.MsoTriState.msoTrue &&
                        shape.TextFrame.HasText == Microsoft.Office.Core.MsoTriState.msoTrue &&
                        shape.Left + shape.Width + offset <= presentation.ActiveWindow.Presentation.PageSetup.SlideWidth)
                    {
                        shape.Left += offset;
                        shape.TextFrame.TextRange.Font.Bold = Microsoft.Office.Core.MsoTriState.msoTrue;
                        shape.TextFrame.TextRange.Font.Color.RGB = ColorTranslator.ToWin32(Color.Red);
                    }
                }
            }
        }
    }
}
