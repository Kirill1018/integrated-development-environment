using Microsoft.VisualBasic;
using System.Diagnostics;
using System.Threading.Tasks;
namespace Integrated_development_environment
{
    public partial class Form1 : Form
    {
        public static string way = string.Empty, continuation = string.Empty, contents = string.Empty;
        public static bool cancellation = false;
        public Form1()
        {
            InitializeComponent();
        }
        public static string[] keyWords = { "abstract ", "as ", "base ",
            "bool ", "break ", "byte ",
            "case ", "catch ", "char ",
            "checked ", "class ", "const ",
            "continue ", "decimal ", "default ",
            "delegate ", "do ", "double ",
            "else ", "enum ", "event ",
            "explicit ", "extern ", "false ",
            "finally ", "fixed ", "float ",
            "for ", "foreach ", "goto ",
            "if ", "implicit ", "in ",
            "int ", "interface ", "internal ",
            "is ", "lock ", "long ",
            "namespace ", "new ", "null ",
            "object ", "operator ", "out ",
            "override ", "params ", "private ",
            "protected ", "public ", "readonly ",
            "ref ", "return ", "sbyte ",
            "sealed ", "short ", "sizeof ",
            "stackalloc ", "static ", "string ",
            "struct ", "switch ", "this ",
            "throw ", "true ", "try ",
            "typeof ", "uint ", "ulong ",
            "unchecked ", "unsafe ", "ushort ",
            "using ", "virtual ", "void ",
            "volatile ", "while " };
        public async Task Save(string textual)
        {
            Stream stream;
            SaveFileDialog dialog = new SaveFileDialog();
            dialog.Filter = "All files (*)|*.*|cs files (*.cs)|*.cs|doc files (*.doc)|*.doc|rtf files (*.rtf)|*.rtf|txt files (*.txt)|*.txt";
            dialog.FilterIndex = 2;
            dialog.RestoreDirectory = true;
            dialog.FileName = way;
            cancellation = true;
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                if ((stream = dialog.OpenFile()) != null) await Task.Run(() => stream.Close());
                await Task.Run(() => File.WriteAllText(dialog.FileName, textual));
                cancellation = false;
            }
            way = dialog.FileName;
        }
        private void codeSpace_TextChanged(object sender, EventArgs e)
        {
            for (int wordInd = 0; wordInd < keyWords.Length; wordInd++)
            {
                int posSave = codeSpace.SelectionStart, i = 0;//итератор
                while (i <= codeSpace.Text.Length - keyWords[wordInd].Length)
                {
                    i = codeSpace.Text.IndexOf(keyWords[wordInd], i);
                    if (i < 0) break;
                    codeSpace.SelectionStart = i;
                    codeSpace.SelectionLength = keyWords[wordInd].Length;
                    codeSpace.SelectionColor = Color.BlueViolet;
                    codeSpace.SelectionStart = posSave;
                    codeSpace.SelectionColor = Color.Black;
                    i += keyWords[wordInd].Length;
                }
            }
        }

        private async void saving_Click(object sender, EventArgs e) => await Save(codeSpace.Text);

        private async void opening_Click(object sender, EventArgs e)
        {
            var content = string.Empty;
            var path = string.Empty;
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "All files (*)|*.*|cs files (*.cs)|*.cs|doc files (*.doc)|*.doc|rtf files (*.rtf)|*.rtf|txt files (*.txt)|*.txt";
            dialog.FilterIndex = 1;
            dialog.RestoreDirectory = true;
            if (dialog.ShowDialog() == DialogResult.OK) await Task.Run(() => codeSpace
            .Invoke(() => codeSpace.Text = File.ReadAllText(dialog.FileName)));
            else dialog.FileName = this.Text;
            way = dialog.FileName;
            this.Text = way;
        }

        private async void seek_Click(object sender, EventArgs e)
        {
            if (codeSpace.Text.Contains(search.Text))
            {
                await Task.Run(() => codeSpace.Invoke(() => codeSpace.SelectionStart = codeSpace.Find(search.Text)));
                codeSpace.SelectionLength = search.TextLength;
                await Task.Run(() => codeSpace.Invoke(() => codeSpace.Focus()));
            }
        }

        private async void conservation_Click(object sender, EventArgs e)
        {
            if (way == string.Empty) await Save(codeSpace.Text);
            contents = codeSpace.Text;
            await Task.Run(() => File.WriteAllText(way, contents));
        }

        private void rollBack_Click(object sender, EventArgs e)
        {
            if (way == string.Empty || contents == string.Empty) return;
            codeSpace.Text = contents;
        }

        private void rollForw_Click(object sender, EventArgs e)
        {
            if (continuation == string.Empty) return;
            codeSpace.Text = continuation;
        }

        private void codeSpace_KeyDown(object sender, KeyEventArgs e) { if (e.KeyCode == Keys.Enter) continuation = codeSpace.Text; }

        private async void projMak_Click(object sender, EventArgs e)
        {
            string wording = string.Empty;
            await Save(wording);
            if (cancellation == true) return;
            await Task.Run(() => File.Open(way, FileMode.Open));
        }
    }
}