using System.Text.Json;

namespace ModNote
{
    public partial class Form1 : Form
    {
        public class Note
        {
            public string Model { get; set; }
            public string Content { get; set; }
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        public static List<Note> Notes = new List<Note>();

        private void Form1_Load(object sender, EventArgs e)
        {
            if (!File.Exists("List.json"))
            {
                File.Create("List.json").Close();
            }
            string json = File.ReadAllText("List.json");
            if (string.IsNullOrEmpty(json) || json.Length < 10) json = "[{\"Model\":\"Note\",\"Content\":\"Content1\"},{\"Model\":\"Note\",\"Content\":\"Content2\"}]";
            //[{"Model":"Note","Content":"Content1"},{"Model":"Note","Content":"Content2"}]
            var list = JsonDocument.Parse(json).RootElement.EnumerateArray();
            foreach (var item in list)
            {
                string model = item.GetProperty("Model").GetString() ?? "Unknown";
                string content = item.GetProperty("Content").GetString() ?? "No Content";
                Notes.Add(new Note { Model = model, Content = content });
                ModListBox.Items.Add($"{model}");
            }
        }

        private void ModListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ModListBox.SelectedItem != null)
            {
                string selectedModel = ModListBox.SelectedItem.ToString();
                Note? foundNote = Notes.FirstOrDefault(n => n.Model == selectedModel);
                string description = foundNote?.Content ?? "未找到描述";
                ModContextBox.Text = description;
            }
            else return;
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            var addForm = new
            {
                Model = ModeNameBox?.Text ?? "Unknown",
                Content = UserModContextBox?.Text ?? "No Content"
            };
            Notes.Add(new Note { Model = addForm.Model, Content = addForm.Content });
            ModListBox.Items.Add(addForm.Model);
            string json = JsonSerializer.Serialize(Notes);
            File.WriteAllText("List.json", json);
            MessageBox.Show("添加成功！");
        }

        private void ItemDelectButton_Click(object sender, EventArgs e)
        {
            Note? foundNote = Notes.FirstOrDefault(n => n.Model.Contains(SearchBox.Text));
            if (foundNote != null)
            {
                Notes.Remove(foundNote);
                ModListBox.Items.Remove(ModListBox.SelectedItem);
                string json = JsonSerializer.Serialize(Notes);
                File.WriteAllText("List.json", json);
                MessageBox.Show("删除成功！");
            }
            else return;
        }

        private void OutputJsonButton_Click(object sender, EventArgs e)
        {
            try
            {
                File.Copy("List.json", "C:/Output.json", true);
                MessageBox.Show("导出成功！");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
