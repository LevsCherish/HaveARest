using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace HaveARest
{
    class LayOutSet
    {
        private int widthSize;
        private int heightSize;
        public LayOutSet(int width, int height)
        {
            this.widthSize = width;
            this.heightSize = height;
        }

        private int getXLocation(int w)
        {
            return (widthSize - w) / 2;
        }

        public void setXCenter(Button button)
        {
            button.Location = new Point(getXLocation(button.Size.Width), button.Location.Y);
        }

        public void setXCenter(Label label)
        {
            label.Location = new Point(getXLocation(label.Size.Width), label.Location.Y);
        }

        public void setXCenter(TextBox textBox)
        {
            textBox.Location = new Point(getXLocation(textBox.Size.Width), textBox.Location.Y);
        }
    }
}
