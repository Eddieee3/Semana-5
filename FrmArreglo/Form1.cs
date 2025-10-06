using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrmArreglo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public void agregar()
        {
            try
            {
                if (int.TryParse(tbedad.Text, out int edad) && edad > 0 && edad <= 120)
                {
                    EdadDao.edades[EdadDao.pos++] = edad;
                    int valor = (EdadDao.pos *100) / EdadDao.edades.Length; 
                }
            }

        }
    }
}
