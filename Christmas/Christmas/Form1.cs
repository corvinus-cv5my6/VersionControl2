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

        private IToyFactory _factory;
        public IToyFactory Factory
        {
            get { return _factory; }
            set { _factory = value; }
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
    }
}
