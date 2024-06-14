using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Smart
{
    public interface IDevice
    {
        string Room { get; set; }
        string Name { get; set; }
        Light Light { get; set; }
        AirConditioner AirConditioner { get; set; }

        void TurnOn();
        void TurnOff();
    }

    public class AirConditioner : IDevice
    {
        public string Room { get; set; }
        public string Name { get; set; }

        private PictureBox pictureBox;
        private Image onImage;
        private Image offImage;

        public AirConditioner(string room, string name, PictureBox pictureBox, Image onImage, Image offImage)
        {
            Room = room;
            Name = name;
            this.pictureBox = pictureBox;
            this.onImage = onImage;
            this.offImage = offImage;
        }

        public void TurnOn()
        {
            pictureBox.Image = onImage;
        }

        public void TurnOff()
        {
            pictureBox.Image = offImage;
        }
    }

    public class Light : IDevice
    {
        public string Room { get; set; }
        public string Name { get; set; }

        private Label label;
        private Color onColor;
        private Color offColor;

        public Light(string room, string name, Label label, Color onColor, Color offColor)
        {
            Room = room;
            Name = name;
            this.label = label;
            this.onColor = onColor;
            this.offColor = offColor;
        }

        public void TurnOn()
        {
            label.BackColor = onColor;
        }

        public void TurnOff()
        {
            label.BackColor = offColor;
        }
    }
}
