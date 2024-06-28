using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudiVari
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void cmdStaticStackTraceTest_Click(object sender, EventArgs e)
        {
            try {
                StackTraceTest.ExceptionFromStaticMethod();
            }
            catch(Exception ex) {
                var message = $"ERR: {ex.Message}/r/n {ex.StackTrace}";
                MessageBox.Show(message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cmdDirectStackTraceTest_Click(object sender, EventArgs e)
        {
            try {
                var obj = new StackTraceTest();
                obj.DirectException();
            }
            catch (Exception ex) {
                var message = $"ERR: {ex.Message}/r/n {ex.StackTrace}";
                MessageBox.Show(message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cmdNestedStackTraceTest_Click(object sender, EventArgs e)
        {
            try {
                var obj = new StackTraceTest();
                obj.NestedException();
            }
            catch (Exception ex) {
                var message = $"ERR: {ex.Message}/r/n {ex.StackTrace}";
                MessageBox.Show(message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cmdRethrownStackTraceTest_Click(object sender, EventArgs e)
        {
            try {
                var obj = new StackTraceTest();
                obj.ReThrownException();
            }
            catch (Exception ex) {
                var message = $"ERR: {ex.Message}/r/n {ex.StackTrace}";
                MessageBox.Show(message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cmdClassComparer_Click(object sender, EventArgs e)
        {
            Comparable o1 = new Comparable() {
                AString = "Ciao",
                ALong = 11L,
                ADouble = 123.456,
                ADateTime = new DateTime(2020, 5, 17)
            };

            Comparable o2 = new Comparable() {
                AString = "Ciao",
                ALong = 10L,
                ADouble = 123.456,
                ADateTime = new DateTime(2020, 5, 15)
            };

            var result = Comparable.GetChanges<Comparable>(o1, o2);

            StringBuilder builder = new StringBuilder();
            foreach(var pair in result) {
                builder.Append(pair.Key);
                builder.Append(":");
                builder.Append(pair.Value);
                builder.Append("\n");
            }

            MessageBox.Show(builder.ToString());
        }
    }
}
