using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PluginTextFigure
{
    public class Command
    {
        ToolStripSplitButton tp;
        ToolStripSplitButton wdth;
        ToolStripSplitButton clr;
        ToolStripSeparator sel;
        ToolStripSplitButton txtClr;
        ToolStripSplitButton fntText;
        ToolStripSplitButton sizeTxt;
        ToolStripSplitButton alignText;

        PProperty pr;
        bool isExist = false;
        public void ChangeColor()
        {
            ColorDialog dlgColor = new ColorDialog();
            if (dlgColor.ShowDialog() == DialogResult.OK)
            {

            }
        }
        public void ChangeType(String type)
        {

        }
        public void ChangeWidth(int width)
        {

        }
        public void ChangeTextColor()
        {
            ColorDialog dlgColor = new ColorDialog();
            if (dlgColor.ShowDialog() == DialogResult.OK)
            {

            }
        }
        public void ChangeFontText(String font)
        {

        }
        public void ChangeTextSize(int size)
        {

        }
        public void ChangeTextAlign(String align)
        {

        }
        public void AddMenu(ToolStrip stripMenu, GroupBox property)
        {
            if (isExist)
                return;

            sel = new ToolStripSeparator();
            tp = new ToolStripSplitButton("Type");
            tp.DropDownItems.Add(new ToolStripMenuItem("Rectangle", null, delegate { ChangeType("Rectangle"); }));
            tp.DropDownItems.Add(new ToolStripMenuItem("Ellipse", null, delegate { ChangeType("Ellipse"); }));
            tp.DropDownItems.Add(new ToolStripMenuItem("Line", null, delegate { ChangeType("Line"); }));
            tp.DropDownItems.Add(new ToolStripMenuItem("RoundRect", null, delegate { ChangeType("RoundRect"); }));
            clr = new ToolStripSplitButton("Color", null, delegate { ChangeColor(); });
            wdth = new ToolStripSplitButton("Width");
            wdth.DropDownItems.Add(new ToolStripMenuItem("1", null, delegate { ChangeWidth(1); }));
            wdth.DropDownItems.Add(new ToolStripMenuItem("3", null, delegate { ChangeWidth(3); }));
            wdth.DropDownItems.Add(new ToolStripMenuItem("5", null, delegate { ChangeWidth(5); }));
            wdth.DropDownItems.Add(new ToolStripMenuItem("7", null, delegate { ChangeWidth(7); }));
            wdth.DropDownItems.Add(new ToolStripMenuItem("10", null, delegate { ChangeWidth(10); }));
            wdth.DropDownItems.Add(new ToolStripMenuItem("15", null, delegate { ChangeWidth(15); }));
            wdth.DropDownItems.Add(new ToolStripMenuItem("20", null, delegate { ChangeWidth(20); }));
            wdth.DropDownItems.Add(new ToolStripMenuItem("25", null, delegate { ChangeWidth(25); }));

            fntText = new ToolStripSplitButton("Font");
            fntText.DropDownItems.Add(new ToolStripMenuItem("Times New Roman", null, delegate { ChangeFontText("Times New Roman"); }));
            fntText.DropDownItems.Add(new ToolStripMenuItem("Arial", null, delegate { ChangeFontText("Ellipse"); }));
            fntText.DropDownItems.Add(new ToolStripMenuItem("Calibri", null, delegate { ChangeFontText("Line"); }));

            sizeTxt = new ToolStripSplitButton("Text Size");
            sizeTxt.DropDownItems.Add(new ToolStripMenuItem("8", null, delegate { ChangeTextSize(8); }));
            sizeTxt.DropDownItems.Add(new ToolStripMenuItem("12", null, delegate { ChangeTextSize(12); }));
            sizeTxt.DropDownItems.Add(new ToolStripMenuItem("14", null, delegate { ChangeTextSize(14); }));
            sizeTxt.DropDownItems.Add(new ToolStripMenuItem("16", null, delegate { ChangeTextSize(16); }));
            sizeTxt.DropDownItems.Add(new ToolStripMenuItem("20", null, delegate { ChangeTextSize(20); }));
            sizeTxt.DropDownItems.Add(new ToolStripMenuItem("24", null, delegate { ChangeTextSize(24); }));

            alignText = new ToolStripSplitButton("Text Align");
            alignText.DropDownItems.Add(new ToolStripMenuItem("Left", null, delegate { ChangeTextAlign("Left"); }));
            alignText.DropDownItems.Add(new ToolStripMenuItem("Right", null, delegate { ChangeTextAlign("Right"); }));
            alignText.DropDownItems.Add(new ToolStripMenuItem("Center", null, delegate { ChangeTextAlign("Center"); }));
            alignText.DropDownItems.Add(new ToolStripMenuItem("Up", null, delegate { ChangeTextAlign("Up"); }));
            alignText.DropDownItems.Add(new ToolStripMenuItem("Down", null, delegate { ChangeTextAlign("Down"); }));

            txtClr = new ToolStripSplitButton("TextColor", null, delegate { ChangeTextColor(); });

            stripMenu.Items.Add(sel);
            stripMenu.Items.Add(wdth);
            stripMenu.Items.Add(tp);
            stripMenu.Items.Add(clr);

            stripMenu.Items.Add(fntText);
            stripMenu.Items.Add(sizeTxt);
            stripMenu.Items.Add(alignText);
            stripMenu.Items.Add(txtClr);

            pr = new PProperty();
            property.Controls.Add(pr);
            isExist = true;
        }
        public void DelMenu(ToolStrip stripMenu, GroupBox property)
        {
            stripMenu.Items.Remove(sel);
            stripMenu.Items.Remove(tp);
            stripMenu.Items.Remove(wdth);
            stripMenu.Items.Remove(clr);
            stripMenu.Items.Remove(txtClr);
            stripMenu.Items.Remove(fntText);
            stripMenu.Items.Remove(alignText);
            stripMenu.Items.Remove(sizeTxt);
            property.Controls.Remove(pr);

            isExist = false;
        }

    }
}
