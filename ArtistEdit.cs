using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
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
            getProfileImg(profileImage);
            getImageWork();
            getPosition();
        }

        private void getPosition()
        {
            ConnectionToDB connectionToDB = new ConnectionToDB();
            NpgsqlDataAdapter sqlDataAdapter = new NpgsqlDataAdapter(
                $@"SELECT id_position, title
                FROM Должность", connectionToDB.GetConnection());
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            artistPosition.DataSource = dataTable;
            artistPosition.DisplayMember = "title";
            artistPosition.ValueMember = "id_position";
        }

        private void getProfileImg(string profileImagePath)
        {
            if (profileImagePath != null)
            {
                artistProfile.ImageLocation = $@".\Photo\profile\{profileImagePath}";
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
            string workImagePath = dataTable.Rows[0][0].ToString();

            var directoryImages = Directory.GetFiles(Path.GetFullPath($@"." + workImagePath));

            foreach (var image in directoryImages)
            {
                imagePath.Add(image.ToString());
            }

        }

        private void nextImage_Click(object sender, EventArgs e)
        {
            if (++curentImage < imagePath.Count)
            {
                imageWork.Image = Image.FromFile(imagePath[curentImage]);
            }
            else
            {
                curentImage = 0;
                imageWork.Image = Image.FromFile(imagePath[curentImage]);
            }
        }

        private void prevImage_Click(object sender, EventArgs e)
        {
            if (--curentImage >=0)
            {
                imageWork.Image = Image.FromFile(imagePath[curentImage]);                
            }
            else
            {
                curentImage = imagePath.Count - 1;
                imageWork.Image = Image.FromFile(imagePath[curentImage]);
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
            //ConnectionToDB connectionToDB = new ConnectionToDB();

            //NpgsqlDataAdapter sqlDataAdapter = new NpgsqlDataAdapter
            //   ($@"UPDATE Сотрудник SET surname='{employeeSurname.Text}', name='{employeeName.Text}', middlename='{employeeMiddlename.Text}', 
            //        id_position='{positionBox.SelectedValue}', work_experience='{workExp.Value.ToString()}', salary='{salary.Value.ToString()}'
            //        WHERE id_employee='{rowId}'", connectionToDB.GetConnection());
            //DataTable dataTable = new DataTable();
            //sqlDataAdapter.Fill(dataTable);
        }
    }
}
