using Christmas.Abstractions;
using Christmas.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Christmas
{
    public partial class Form1 : Form
    {
        private List<Toy> _Toys = new List<Toy>();
        private Toy _nextToy;

        private IToyFactory _factory;
        public IToyFactory Factory
        {
            get { return _factory; }
            set { _factory = value;
                DisplayNext();
            }
        }
        public Form1()
        {
            InitializeComponent();
            Factory = new BallFactory();
            
        }

        private void conveyorTimer_Tick(object sender, EventArgs e)
        {
            var maxPosition = 0;
            foreach (var Toy in _Toys)
            {
                Toy.MoveToy();
                if (Toy.Left > maxPosition)
                    maxPosition = Toy.Left;
            }

            if (maxPosition > 1000)
            {
                var oldestToy = _Toys[0];
                mainPanel.Controls.Remove(oldestToy);
                _Toys.Remove(oldestToy);
            }
        }

        private void createTimer_Tick(object sender, EventArgs e)
        {
            var Toy = Factory.CreateNew();
            _Toys.Add(Toy);
            Toy.Left = -Toy.Width;
            mainPanel.Controls.Add(Toy);
        }

        private void buttonSelectCar_Click(object sender, EventArgs e)
        {
            Factory = new CarFactory();
        }

        private void buttonSelectBall_Click(object sender, EventArgs e)
        {
            Factory = new BallFactory
            {
                BallColor = button1.BackColor
            };
        }

        private void DisplayNext()
        {
            if (_nextToy != null)
                Controls.Remove(_nextToy);
            _nextToy = Factory.CreateNew();
            _nextToy.Top = label1.Top + label1.Height + 20;
            _nextToy.Left = label1.Left;
            Controls.Add(_nextToy);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var button = (Button)sender;
            var colorPicker = new ColorDialog();

            colorPicker.Color = button.BackColor;
            if (colorPicker.ShowDialog() != DialogResult.OK)
                return;
            button.BackColor = colorPicker.Color;
        }
    }
}
