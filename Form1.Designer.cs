namespace MusicCollection
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            btnAddTrack = new Button();
            txtTitle = new TextBox();
            txtArtist = new TextBox();
            txtAlbum = new TextBox();
            txtYear = new TextBox();
            lblTitle = new Label();
            lblArtist = new Label();
            lblAlbum = new Label();
            lblYear = new Label();
            dataGridView1 = new DataGridView();
            idDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            titleDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            artistDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            albumDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            yearDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            musicTrackBindingSource = new BindingSource(components);
            btnRemoveAllTracks = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)musicTrackBindingSource).BeginInit();
            SuspendLayout();
            // 
            // btnAddTrack
            // 
            btnAddTrack.Location = new Point(15, 150);
            btnAddTrack.Margin = new Padding(4, 3, 4, 3);
            btnAddTrack.Name = "btnAddTrack";
            btnAddTrack.Size = new Size(88, 27);
            btnAddTrack.TabIndex = 0;
            btnAddTrack.Text = "Add Track";
            btnAddTrack.UseVisualStyleBackColor = true;
            btnAddTrack.Click += btnAddTrack_Click;
            // 
            // txtTitle
            // 
            txtTitle.Location = new Point(70, 15);
            txtTitle.Margin = new Padding(4, 3, 4, 3);
            txtTitle.Name = "txtTitle";
            txtTitle.Size = new Size(116, 23);
            txtTitle.TabIndex = 1;
            // 
            // txtArtist
            // 
            txtArtist.Location = new Point(70, 45);
            txtArtist.Margin = new Padding(4, 3, 4, 3);
            txtArtist.Name = "txtArtist";
            txtArtist.Size = new Size(116, 23);
            txtArtist.TabIndex = 2;
            // 
            // txtAlbum
            // 
            txtAlbum.Location = new Point(70, 75);
            txtAlbum.Margin = new Padding(4, 3, 4, 3);
            txtAlbum.Name = "txtAlbum";
            txtAlbum.Size = new Size(116, 23);
            txtAlbum.TabIndex = 3;
            // 
            // txtYear
            // 
            txtYear.Location = new Point(70, 105);
            txtYear.Margin = new Padding(4, 3, 4, 3);
            txtYear.Name = "txtYear";
            txtYear.Size = new Size(116, 23);
            txtYear.TabIndex = 4;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Location = new Point(15, 15);
            lblTitle.Margin = new Padding(4, 0, 4, 0);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(29, 15);
            lblTitle.TabIndex = 5;
            lblTitle.Text = "Title";
            // 
            // lblArtist
            // 
            lblArtist.AutoSize = true;
            lblArtist.Location = new Point(15, 45);
            lblArtist.Margin = new Padding(4, 0, 4, 0);
            lblArtist.Name = "lblArtist";
            lblArtist.Size = new Size(35, 15);
            lblArtist.TabIndex = 6;
            lblArtist.Text = "Artist";
            // 
            // lblAlbum
            // 
            lblAlbum.AutoSize = true;
            lblAlbum.Location = new Point(15, 75);
            lblAlbum.Margin = new Padding(4, 0, 4, 0);
            lblAlbum.Name = "lblAlbum";
            lblAlbum.Size = new Size(43, 15);
            lblAlbum.TabIndex = 7;
            lblAlbum.Text = "Album";
            // 
            // lblYear
            // 
            lblYear.AutoSize = true;
            lblYear.Location = new Point(15, 105);
            lblYear.Margin = new Padding(4, 0, 4, 0);
            lblYear.Name = "lblYear";
            lblYear.Size = new Size(29, 15);
            lblYear.TabIndex = 8;
            lblYear.Text = "Year";
            // 
            // dataGridView1
            // 
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { idDataGridViewTextBoxColumn, titleDataGridViewTextBoxColumn, artistDataGridViewTextBoxColumn, albumDataGridViewTextBoxColumn, yearDataGridViewTextBoxColumn });
            dataGridView1.DataSource = musicTrackBindingSource;
            dataGridView1.Location = new Point(220, 15);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(394, 157);
            dataGridView1.TabIndex = 11;
            // 
            // idDataGridViewTextBoxColumn
            // 
            idDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            idDataGridViewTextBoxColumn.HeaderText = "Id";
            idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            // 
            // titleDataGridViewTextBoxColumn
            // 
            titleDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            titleDataGridViewTextBoxColumn.DataPropertyName = "Title";
            titleDataGridViewTextBoxColumn.HeaderText = "Title";
            titleDataGridViewTextBoxColumn.Name = "titleDataGridViewTextBoxColumn";
            // 
            // artistDataGridViewTextBoxColumn
            // 
            artistDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            artistDataGridViewTextBoxColumn.DataPropertyName = "Artist";
            artistDataGridViewTextBoxColumn.HeaderText = "Artist";
            artistDataGridViewTextBoxColumn.Name = "artistDataGridViewTextBoxColumn";
            // 
            // albumDataGridViewTextBoxColumn
            // 
            albumDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            albumDataGridViewTextBoxColumn.DataPropertyName = "Album";
            albumDataGridViewTextBoxColumn.HeaderText = "Album";
            albumDataGridViewTextBoxColumn.Name = "albumDataGridViewTextBoxColumn";
            // 
            // yearDataGridViewTextBoxColumn
            // 
            yearDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            yearDataGridViewTextBoxColumn.DataPropertyName = "Year";
            yearDataGridViewTextBoxColumn.HeaderText = "Year";
            yearDataGridViewTextBoxColumn.Name = "yearDataGridViewTextBoxColumn";
            // 
            // musicTrackBindingSource
            // 
            musicTrackBindingSource.DataSource = typeof(Models.MusicTrack);
            // 
            // btnRemoveAllTracks
            // 
            btnRemoveAllTracks.Location = new Point(111, 150);
            btnRemoveAllTracks.Margin = new Padding(4, 3, 4, 3);
            btnRemoveAllTracks.Name = "btnRemoveAllTracks";
            btnRemoveAllTracks.Size = new Size(88, 27);
            btnRemoveAllTracks.TabIndex = 12;
            btnRemoveAllTracks.Text = "Remove All";
            btnRemoveAllTracks.UseVisualStyleBackColor = true;
            btnRemoveAllTracks.Click += btnRemoveAllTracks_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(645, 203);
            Controls.Add(btnRemoveAllTracks);
            Controls.Add(dataGridView1);
            Controls.Add(lblYear);
            Controls.Add(lblAlbum);
            Controls.Add(lblArtist);
            Controls.Add(lblTitle);
            Controls.Add(txtYear);
            Controls.Add(txtAlbum);
            Controls.Add(txtArtist);
            Controls.Add(txtTitle);
            Controls.Add(btnAddTrack);
            Margin = new Padding(4, 3, 4, 3);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Music Collection";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)musicTrackBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Button btnAddTrack;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.TextBox txtArtist;
        private System.Windows.Forms.TextBox txtAlbum;
        private System.Windows.Forms.TextBox txtYear;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblArtist;
        private System.Windows.Forms.Label lblAlbum;
        private System.Windows.Forms.Label lblYear;
        private DataGridView dataGridView1;
        private BindingSource musicTrackBindingSource;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn titleDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn artistDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn albumDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn yearDataGridViewTextBoxColumn;
        private Button btnRemoveAllTracks;
    }
}
