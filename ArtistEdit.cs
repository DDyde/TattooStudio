using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Versioning;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TattooStudio
{
    public partial class ArtistEdit : Form
    {
        int rowId = 0;
        List<string> imagePath = new List<string>();
        int curentImage = 0;
        string profileImage = null;
        string fName = null;
        string workImagePath = null;

        public ArtistEdit()
        {
            InitializeComponent();
            getPosition();
        }

        public ArtistEdit(int _rowId)
        {
            InitializeComponent();
            rowId = _rowId;
            getArtist();
        }

        private void getArtist()
        {
            getPosition();

            ConnectionToDB connectionToDB = new ConnectionToDB();
            NpgsqlDataAdapter sqlDataAdapter = new NpgsqlDataAdapter
               ($@"SELECT * FROM employeeMaster
                        WHERE id_employee={rowId}", connectionToDB.GetConnection());
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            artistSurname.Text = dataTable.Rows[0][1].ToString();
            artistName.Text = dataTable.Rows[0][2].ToString();
            artistMiddlename.Text = dataTable.Rows[0][3].ToString();
            artistPosition.SelectedValue = dataTable.Rows[0][6].ToString();
            workExp.Text = dataTable.Rows[0][5].ToString();
            salary.Text = dataTable.Rows[0][7].ToString();
            profileImage = dataTable.Rows[0][8].ToString();
            fName = dataTable.Rows[0][9].ToString();
            getProfileImg(profileImage, fName);
            getImageWork();
        }

        private void getPosition()
        {
            ConnectionToDB connectionToDB = new ConnectionToDB();
            NpgsqlDataAdapter sqlDataAdapter = new NpgsqlDataAdapter(
                $@"SELECT id_position, title
                FROM Должность
                WHERE id_position >= 3", connectionToDB.GetConnection());
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            artistPosition.DataSource = dataTable;
            artistPosition.DisplayMember = "title";
            artistPosition.ValueMember = "id_position";
        }

        private void getProfileImg(string profileImageFile, string folderName)
        {
            if (profileImageFile != null)
            {
                artistProfile.ImageLocation = $@".\Photo\profile\{folderName}\{profileImageFile}";
                artistProfile.Load(artistProfile.ImageLocation);
            }
            else
            {
                artistProfile.Image = Image.FromFile(@".\Photo\profile\defultProfile.ico");
            }            
        }

        private void getImageWork()
        {
            ConnectionToDB connectionToDB = new ConnectionToDB();

            NpgsqlDataAdapter sqlDataAdapter = new NpgsqlDataAdapter
               ($@"SELECT image_work FROM employeeMaster
                        WHERE id_employee={rowId}", connectionToDB.GetConnection());
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            workImagePath = dataTable.Rows[0][0].ToString();

            var directoryImages = Directory.GetFiles(Path.GetFullPath($@".\{workImagePath}\{fName}\work\"));
            imagePath.Clear();
            foreach (var image in directoryImages)
            {
                imagePath.Add(image.ToString());
            }
            imageWork.Image = Image.FromFile(imagePath[curentImage]);

        }

        private void nextImage_Click(object sender, EventArgs e)
        {
            if (++curentImage < imagePath.Count)
            {
                var fs = File.OpenRead(imagePath[curentImage]);
                imageWork.Image = Image.FromStream(fs);
                fs.Close();
                //imageWork.ImageLocation = imagePath[curentImage];
                //imageWork.Load(imageWork.ImageLocation);
            }
            else
            {
                curentImage = 0;
                var fs = File.OpenRead(imagePath[curentImage]);
                imageWork.Image = Image.FromStream(fs);
                fs.Close();
                //imageWork.ImageLocation = imagePath[curentImage];
                //imageWork.Load(imageWork.ImageLocation);
            }
        }

        private void prevImage_Click(object sender, EventArgs e)
        {
            if (--curentImage >=0)
            {
                var fs = File.OpenRead(imagePath[curentImage]);
                imageWork.Image = Image.FromStream(fs);
                fs.Close();
            }
            else
            {
                curentImage = imagePath.Count - 1;
                var fs = File.OpenRead(imagePath[curentImage]);
                imageWork.Image = Image.FromStream(fs);
                fs.Close();
            }
        }

        private void updateImageProfile_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog()
            {
                Filter = "Image files(*.jpg; *.png; *.jpeg;)|*.jpg;*.png;*.jpeg;",
                Multiselect = false
            };

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string oldImage = artistProfile.ImageLocation;
                string directoryImg = Path.GetDirectoryName(artistProfile.ImageLocation);
                string nameImage = Path.GetFileName(openFileDialog.FileName);
                string pathImage = $@"{directoryImg}\{nameImage}";
                File.Copy(openFileDialog.FileName, pathImage);
                artistProfile.ImageLocation = pathImage;
                artistProfile.Load(artistProfile.ImageLocation);
                File.Delete(oldImage);
            }            

        }

        private void updateButton_Click(object sender, EventArgs e)
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

        private void addImageButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog()
            {
                Filter = "Image files(*.jpg; *.png; *.jpeg;)|*.jpg;*.png;*.jpeg;",
                Multiselect = false
            };

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string nameImage = Path.GetFileName(openFileDialog.FileName);
                File.Copy(openFileDialog.FileName, $@".\{workImagePath}\{fName}\work\{nameImage}");
            }
            getImageWork();
        }

        private void deleteImageButton_Click(object sender, EventArgs e)
        {
            File.Delete(imagePath[curentImage]);
            //imageWork.Image = Image.FromFile(imagePath[curentImage]);
            curentImage = 0;
            imageWork.ImageLocation = imagePath[curentImage];
            getImageWork();
        }
    }
}
