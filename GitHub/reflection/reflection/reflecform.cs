using System;
using System.Windows.Forms;
using System.Reflection;

namespace reflection
{
    public partial class reflecform : Form
    {
        public reflecform()
        {
            InitializeComponent();
        }

        private void btnclick_Click(object sender, EventArgs e)
        {
            Type tp = typeof(test);
            FieldInfo[] arFI = tp.GetFields();
            foreach(FieldInfo fi in arFI)
            {
                MessageBox.Show(fi.Name);
            }
            PropertyInfo[] pr = tp.GetProperties();
            foreach(PropertyInfo pi in pr)
            {
                MessageBox.Show(pi.Name);
            }
            MethodInfo[] met = tp.GetMethods();
            foreach (MethodInfo mi in met)
            {
                MessageBox.Show(mi.Name);
            }
        }
         class test
        {
          public void disp(int a, string s)
            {
                MessageBox.Show(a + " " + s);
            }
            public int field1;
            public int prop1
            {
                get
                {
                    return field1;
                }
                set
                {
                    field1= value;
                }
                
            }
                
        }
    }
}
