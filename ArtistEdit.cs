using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Versioning;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TattooStudio.Report;

namespace TattooStudio
{
    public partial class ArtistEdit : Form
    {
        int rowId = 0;
        List<string> imagePath = new List<string>();
        int curentImage = 0;
        string fName = null;
        int rule = AccessLevel.rule;

        public ArtistEdit()
        {
            InitializeComponent();
            getPosition();
            addButton.Visible = true;
            nickNameBox.Visible = true;
        }

        public ArtistEdit(int _rowId)
        {
            InitializeComponent();
            rowId = _rowId;
            getArtist();
            updateButton.Visible = true;
            deleteButton.Visible = true;
        }

        private void getArtist()
        {
            getPosition();

            ConnectionToDB connectionToDB = new ConnectionToDB();
            NpgsqlDataAdapter sqlDataAdapter = new NpgsqlDataAdapter
               ($@"SELECT * FROM employeemaster
                        WHERE id_employee={rowId}", connectionToDB.GetConnection());
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            artistSurname.Text = dataTable.Rows[0][1].ToString();
            artistName.Text = dataTable.Rows[0][2].ToString();
            artistMiddlename.Text = dataTable.Rows[0][3].ToString();
            workExp.Text = dataTable.Rows[0][5].ToString();
            artistPosition.SelectedValue = dataTable.Rows[0][6];
            salary.Text = dataTable.Rows[0][7].ToString();
            string profileImage = dataTable.Rows[0][8].ToString();
            fName = dataTable.Rows[0][9].ToString();
            getProfileImg(profileImage, fName);
            getImageWork(fName);
        }

        private void getPosition()
        {
            ConnectionToDB connectionToDB = new ConnectionToDB();
            NpgsqlDataAdapter sqlDataAdapter = new NpgsqlDataAdapter(
                $@"SELECT id_position, title
                FROM Должность
                WHERE title LIKE '%_ату%' OR title LIKE '%_ирсинг%' OR title LIKE '%_атуаж%'", connectionToDB.GetConnection());
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            artistPosition.DataSource = dataTable;
            artistPosition.DisplayMember = "title";
            artistPosition.ValueMember = "id_position";
        }

        private void getProfileImg(string profileImageFile, string folderName)
        {
            if (profileImageFile != "")
            {
                var fs = File.OpenRead($@".\Photo\profile\{folderName}\{profileImageFile}");
                artistProfile.ImageLocation = fs.Name;
                fs.Close();
            }
            else
            {
                var fs = File.OpenRead(@".\Photo\profile\defultProfile.jpg");
                artistProfile.Image = Image.FromStream(fs);
                fs.Close();
            }
        }

        private void getImageWork(string workFolder)
        {
            var directoryImages = Directory.GetFiles($@".\Photo\profile\{workFolder}\work\");
            imagePath.Clear();
            if (directoryImages.Length != 0)
            {
                foreach (var image in directoryImages)
                {
                    imagePath.Add(image.ToString());
                }
                var fs = File.OpenRead(imagePath[curentImage]);
                imageWork.ImageLocation = fs.Name;
                fs.Close();
            }

        }

        private void nextImage_Click(object sender, EventArgs e)
        {
            if (++curentImage < imagePath.Count)
            {
                var fs = File.OpenRead(imagePath[curentImage]);
                imageWork.ImageLocation = fs.Name;
                fs.Close();
            }
            else
            {
                curentImage = 0;
                if (imagePath.Count != 0)
                {
                    var fs = File.OpenRead(imagePath[curentImage]);
                    imageWork.ImageLocation = fs.Name;
                    fs.Close();
                }
            }
        }

        private void prevImage_Click(object sender, EventArgs e)
        {
            if (--curentImage >= 0)
            {
                var fs = File.OpenRead(imagePath[curentImage]);
                imageWork.ImageLocation = fs.Name;
                fs.Close();
            }
            else
            {
                curentImage = imagePath.Count - 1;
                if (imagePath.Count != 0)
                {
                    var fs = File.OpenRead(imagePath[curentImage]);
                    imageWork.ImageLocation = fs.Name;
                    fs.Close();
                }
            }
        }

        private void updateImageProfile_Click(object sender, EventArgs e)
        {
            if (rule == 1 || rule == 2)
            {
                OpenFileDialog openFileDialog = new OpenFileDialog()
                {
                    Filter = "Image files(*.jpg; *.png; *.jpeg;)|*.jpg;*.png;*.jpeg;",
                    Multiselect = false
                };

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string oldImage = artistProfile.ImageLocation;
                    string directoryImg = $@".\Photo\profile\{fName}";

                    if (directoryImg != "")
                    {
                        string nameImage = Path.GetFileName(openFileDialog.FileName);
                        string pathImage = $@"{directoryImg}\{nameImage}";
                        File.Copy(openFileDialog.FileName, pathImage);

                        var fs = File.OpenRead(pathImage);
                        artistProfile.ImageLocation = fs.Name;
                        fs.Close();
                        if (oldImage != "")
                        {
                            File.Delete(oldImage);
                        }

                        ConnectionToDB connectionToDB = new ConnectionToDB();
                        string newImageName = Path.GetFileName(artistProfile.ImageLocation);

                        NpgsqlCommand sqlCommand = new NpgsqlCommand($@"UPDATE Сотрудник SET 
                                                                        image_employee=@profileImageArtist
                                                                        WHERE id_employee='{rowId}'", connectionToDB.GetConnection());
                        sqlCommand.Parameters.AddWithValue("@profileImageArtist", newImageName);

                        NpgsqlDataAdapter sqlDataAdapter = new NpgsqlDataAdapter(sqlCommand);
                        DataTable dataTable = new DataTable();
                        sqlDataAdapter.Fill(dataTable);
                    }
                    else
                    {
                        MessageBox.Show("Добавь мастера");
                    }
                }
            }
            else
            {
                MessageBox.Show("Недостаточный уровень доступа");
            }

        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            if (rule == 1 || rule == 2)
            {
                ConnectionToDB connectionToDB = new ConnectionToDB();
                string newImageName = Path.GetFileName(artistProfile.ImageLocation);

                NpgsqlCommand sqlCommand = new NpgsqlCommand($@"UPDATE Сотрудник SET surname='{artistSurname.Text}', name='{artistName.Text}', middlename='{artistMiddlename.Text}', 
                    id_position='{artistPosition.SelectedValue}', work_experience='{workExp.Text}', salary='{salary.Text}', 
                    image_employee=@profileImageArtist
                    WHERE id_employee='{rowId}'", connectionToDB.GetConnection());
                sqlCommand.Parameters.AddWithValue("@profileImageArtist", newImageName);

                NpgsqlDataAdapter sqlDataAdapter = new NpgsqlDataAdapter(sqlCommand);
                DataTable dataTable = new DataTable();
                sqlDataAdapter.Fill(dataTable);
            }
            else
            {
                MessageBox.Show("Недостаточный уровень доступа");
            }
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            if (rule == 1 || rule == 2)
            {
                ConnectionToDB connectionToDB = new ConnectionToDB();
                string newImageName = Path.GetFileName(artistProfile.ImageLocation);
                Directory.CreateDirectory($@".\Photo\profile\{nickNameBox.Text}\");
                Directory.CreateDirectory($@".\Photo\profile\{nickNameBox.Text}\work\");

                NpgsqlCommand sqlCommand = new NpgsqlCommand($@"INSERT INTO Сотрудник (surname, name, middlename, id_position, work_experience, salary, image_employee, nickname)
                                                            VALUES ('{artistSurname.Text}', '{artistName.Text}', '{artistMiddlename.Text}', '{artistPosition.SelectedValue}',
                                                            '{workExp.Text}', '{salary.Text}', @profileImageArtist, @nickName)", connectionToDB.GetConnection());
                sqlCommand.Parameters.AddWithValue("@profileImageArtist", newImageName);
                sqlCommand.Parameters.AddWithValue("@nickName", nickNameBox.Text);

                fName = nickNameBox.Text;

                NpgsqlDataAdapter sqlDataAdapter = new NpgsqlDataAdapter(sqlCommand);
                DataTable dataTable = new DataTable();
                sqlDataAdapter.Fill(dataTable);

                NpgsqlCommand command = new NpgsqlCommand(@"SELECT max(id_employee)
                                                        FROM employeemaster", connectionToDB.GetConnection());
                NpgsqlDataAdapter data = new NpgsqlDataAdapter(command);
                DataTable dataTable1 = new DataTable();
                data.Fill(dataTable1);
                rowId = Int16.Parse(dataTable1.Rows[0][0].ToString());
                nickNameBox.Visible = false;
                updateButton.Visible = true;
                deleteButton.Visible = true;
                addButton.Visible = false;
            }
            else
            {
                MessageBox.Show("Недостаточный уровень доступа");
            }
        }

        private void addImageButton_Click(object sender, EventArgs e)
        {
            if (rule == 1 || rule == 2)
            {

                OpenFileDialog openFileDialog = new OpenFileDialog()
                {
                    Filter = "Image files(*.jpg; *.png; *.jpeg;)|*.jpg;*.png;*.jpeg;",
                    Multiselect = false
                };

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    if (fName != null)
                    {
                        string nameImage = Path.GetFileName(openFileDialog.FileName);
                        File.Copy(openFileDialog.FileName, $@".\Photo\profile\{fName}\work\{nameImage}");
                        getImageWork(fName);
                    }

                }
            }
            else
            {
                MessageBox.Show("Недостаточный уровень доступа");
            }
        }

        private void deleteImageButton_Click(object sender, EventArgs e)
        {
            if (rule == 1 || rule == 2)
            {
                if (imagePath.Count != 0)
                {
                    File.Delete(imagePath[curentImage]);
                    curentImage = 0;
                    getImageWork(fName);
                }
            }
            else
            {
                MessageBox.Show("Недостаточный уровень доступа");
            }

        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (rule == 1 || rule == 2)
            {
                ConnectionToDB connectionToDB = new ConnectionToDB();
                NpgsqlDataAdapter sqlDataAdapter = new NpgsqlDataAdapter(
                    $@"DELETE FROM Сотрудник WHERE id_employee={rowId}", connectionToDB.GetConnection());
                DataTable dataTable = new DataTable();

                Directory.Delete($@".\Photo\profile\{fName}", true);
                sqlDataAdapter.Fill(dataTable);
            }
            else
            {
                MessageBox.Show("Недостаточный уровень доступа");
            }

        }

        private void reportButton_Click(object sender, EventArgs e)
        {
            ArtistPaymentForm artistPayment = new ArtistPaymentForm(rowId);
            artistPayment.ShowDialog();
        }
    }
}
