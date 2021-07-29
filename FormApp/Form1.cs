using System;
using System.Drawing;
using System.IO;
using System.Text.Encodings.Web;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.Text.Json;

namespace FormApp
{
    public partial class Form1 : Form
    {
        public string Gender { get; set; }
        public DateTime Date { get; set; }
        public User User { get; set; }

        public Form1()
        {
            InitializeComponent();
        }

        public void SerializeUser()
        {
            User = new User(firstNameTxtBox.Text, lastNameTxtBox.Text, usernameTxtBox.Text, phoneTxtBox.Text, Date, Gender, agrmtCheckBox.Checked);
            var fileName = usernameTxtBox.Text + ".json";
            var options = new JsonSerializerOptions
            {
                WriteIndented = true,
                Encoder = JavaScriptEncoder.UnsafeRelaxedJsonEscaping
            };
            var jsonString = JsonSerializer.Serialize(User, options);
            File.WriteAllText(fileName, jsonString);
        }

        public User DeserializeUser()
        {
            var fileName = filenameTxtBox.Text + ".json";
            string jsonString = File.ReadAllText(fileName);
            User = JsonSerializer.Deserialize<User>(jsonString);

            firstNameTxtBox.Text = User.FirstName;
            lastNameTxtBox.Text = User.LastName;
            usernameTxtBox.Text = User.Username;
            phoneTxtBox.Text = User.Phone;
            dateTimePicker.Value = User.DateTime;
            if (User.Gender == "M")
            {
                maleRadBtn.Checked = true;
            }
            else
            {
                femaleRadBtn.Checked = true;
            }
            agrmtCheckBox.Checked = User.Agreement;
            return User;
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            Gender = maleRadBtn.Checked ? "M" : "F";
            Date = dateTimePicker.Value;


            firstNameTxtBox.FocusedState.BorderColor = Color.FromArgb(15, 10, 10);
            if (!Regex.Match(firstNameTxtBox.Text, "^[A-Z][a-zA-Z]*$").Success)
            {
                // first name was incorrect  
                MessageBox.Show("Invalid first name", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                firstNameTxtBox.Focus();
                firstNameTxtBox.FocusedState.BorderColor = Color.FromArgb(255, 204, 213);
                return;
            }

            lastNameTxtBox.FocusedState.BorderColor = Color.FromArgb(15, 10, 10);
            if (!Regex.Match(lastNameTxtBox.Text, "^[A-Z][a-zA-Z]*$").Success)
            {
                // last name was incorrect
                MessageBox.Show("Invalid last name", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                lastNameTxtBox.Focus();
                lastNameTxtBox.FocusedState.BorderColor = Color.FromArgb(255, 204, 213);
                return;
            }

            phoneTxtBox.FocusedState.BorderColor = Color.FromArgb(15, 10, 10);
            if (!Regex.Match(phoneTxtBox.Text, @"^\+994(55|99|50|51|70|77)([0-9]){7}$").Success)
            {
                // phone number was incorrect  
                MessageBox.Show("Invalid phone number", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                phoneTxtBox.Focus();
                phoneTxtBox.FocusedState.BorderColor = Color.FromArgb(255, 204, 213);
                return;
            }
            SerializeUser();
        }



        private void loadBtn_Click(object sender, EventArgs e)
        {
            //var fileName = usernameTxtBox.Text + ".json";
            filenameTxtBox.FocusedState.BorderColor = Color.FromArgb(15, 10, 10);
            var userJson = new FileInfo(filenameTxtBox.Text + ".json");
            if (!userJson.Exists)
            {
                MessageBox.Show("File doesn't exist", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                filenameTxtBox.Focus();
                filenameTxtBox.FocusedState.BorderColor = Color.FromArgb(255, 204, 213);
                return;
            }
            User = DeserializeUser();
        }

        private void clrBtn_Click(object sender, EventArgs e)
        {
            filenameTxtBox.Text = String.Empty;
            firstNameTxtBox.Text = String.Empty;
            lastNameTxtBox.Text = String.Empty;
            usernameTxtBox.Text = String.Empty;
            phoneTxtBox.Text = String.Empty;
            dateTimePicker.Value = DateTime.Now;
            maleRadBtn.Checked = false;
            femaleRadBtn.Checked = false;
            agrmtCheckBox.Checked = false;
        }
    }
}
