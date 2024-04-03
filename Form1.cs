using System;
using System.Windows.Forms;
using MusicCollection.Data;
using MusicCollection.Models;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TrackBar;

namespace MusicCollection
{
    public partial class Form1 : Form
    {
        private readonly MusicRepository _repository;

        public Form1()
        {
            InitializeComponent();
            _repository = new MusicRepository();
        }

        private void btnAddTrack_Click(object sender, EventArgs e)
        {

            using (var context = new MusicDbContext())
            {
                context.Database.EnsureCreated();
            }

            var track = new MusicTrack
            {
                Title = txtTitle.Text,
                Artist = txtArtist.Text,
                Album = txtAlbum.Text,
                Year = Convert.ToInt32(txtYear.Text)
            };

            _repository.AddTrack(track);
            MessageBox.Show("Track added successfully!");
            RefreshDataGridView();
        }

        private void btnRemoveAllTracks_Click(object sender, EventArgs e)
        {
            var dbContextFactory = new MusicDbContext();
            dbContextFactory.RemoveAllTracks();
            RefreshDataGridView();
        }

        private void RefreshDataGridView()
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = _repository.GetAllTracks();
        }

    }
}
