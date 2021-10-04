using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PetShop
{
    public partial class FrmBasePersona : FrmBase
    {

        protected static int indexRow;
        protected static int idActual;


        protected int IndexRow
        {
            get { return indexRow; }
            set { indexRow = value; }
        }

        protected int IdActual
        {
            get { return idActual; }
            set { idActual = value; }
        }

        public FrmBasePersona()
        {
            InitializeComponent();
        }

     

     
    }
}
