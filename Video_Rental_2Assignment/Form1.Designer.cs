namespace Video_Rental_2Assignment
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
            this.choose_movies = new System.Windows.Forms.RadioButton();
            this.choose_customers = new System.Windows.Forms.RadioButton();
            this.Issued_movies = new System.Windows.Forms.RadioButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.rental_cus_name = new System.Windows.Forms.TextBox();
            this.customer_name = new System.Windows.Forms.Label();
            this.Date_issued = new System.Windows.Forms.Label();
            this.movie_name = new System.Windows.Forms.Label();
            this.Date_returned = new System.Windows.Forms.Label();
            this.mov_rental_name = new System.Windows.Forms.TextBox();
            this.BookingDate = new System.Windows.Forms.DateTimePicker();
            this.returnDate = new System.Windows.Forms.DateTimePicker();
            this.now_issue_btn = new System.Windows.Forms.Button();
            this.return_btn = new System.Windows.Forms.Button();
            this.popular_customer = new System.Windows.Forms.Button();
            this.popular_movie = new System.Windows.Forms.Button();
            this.delete_movon_rentals = new System.Windows.Forms.Button();
            this.Rentals = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.mov_delete = new System.Windows.Forms.Button();
            this.mov_update = new System.Windows.Forms.Button();
            this.add_mov = new System.Windows.Forms.Button();
            this.points = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.stars = new System.Windows.Forms.Label();
            this.mov_name = new System.Windows.Forms.TextBox();
            this.Yearpermov = new System.Windows.Forms.TextBox();
            this.costpermovie = new System.Windows.Forms.Label();
            this.genres = new System.Windows.Forms.TextBox();
            this.genre = new System.Windows.Forms.Label();
            this.Costs = new System.Windows.Forms.TextBox();
            this.copies = new System.Windows.Forms.Label();
            this.Cost = new System.Windows.Forms.Label();
            this.text_copies = new System.Windows.Forms.TextBox();
            this.contact = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.age = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.nameofcustomer = new System.Windows.Forms.TextBox();
            this.customer_del = new System.Windows.Forms.Button();
            this.customer_update = new System.Windows.Forms.Button();
            this.customer_add = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // choose_movies
            // 
            this.choose_movies.AutoSize = true;
            this.choose_movies.BackColor = System.Drawing.Color.White;
            this.choose_movies.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.choose_movies.Location = new System.Drawing.Point(24, 12);
            this.choose_movies.Name = "choose_movies";
            this.choose_movies.Size = new System.Drawing.Size(76, 24);
            this.choose_movies.TabIndex = 0;
            this.choose_movies.TabStop = true;
            this.choose_movies.Text = "Movies";
            this.choose_movies.UseVisualStyleBackColor = false;
            this.choose_movies.CheckedChanged += new System.EventHandler(this.choose_movies_CheckedChanged);
            // 
            // choose_customers
            // 
            this.choose_customers.AutoSize = true;
            this.choose_customers.BackColor = System.Drawing.Color.White;
            this.choose_customers.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.choose_customers.Location = new System.Drawing.Point(136, 12);
            this.choose_customers.Name = "choose_customers";
            this.choose_customers.Size = new System.Drawing.Size(104, 24);
            this.choose_customers.TabIndex = 1;
            this.choose_customers.TabStop = true;
            this.choose_customers.Text = "Customers";
            this.choose_customers.UseVisualStyleBackColor = false;
            this.choose_customers.CheckedChanged += new System.EventHandler(this.choose_customers_CheckedChanged);
            // 
            // Issued_movies
            // 
            this.Issued_movies.AutoSize = true;
            this.Issued_movies.BackColor = System.Drawing.Color.White;
            this.Issued_movies.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Issued_movies.Location = new System.Drawing.Point(273, 12);
            this.Issued_movies.Name = "Issued_movies";
            this.Issued_movies.Size = new System.Drawing.Size(128, 24);
            this.Issued_movies.TabIndex = 2;
            this.Issued_movies.TabStop = true;
            this.Issued_movies.Text = "Issued Movies";
            this.Issued_movies.UseVisualStyleBackColor = false;
            this.Issued_movies.CheckedChanged += new System.EventHandler(this.Issued_movies_CheckedChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(24, 59);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(662, 284);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // rental_cus_name
            // 
            this.rental_cus_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rental_cus_name.Location = new System.Drawing.Point(902, 78);
            this.rental_cus_name.Name = "rental_cus_name";
            this.rental_cus_name.Size = new System.Drawing.Size(100, 24);
            this.rental_cus_name.TabIndex = 5;
            // 
            // customer_name
            // 
            this.customer_name.AutoSize = true;
            this.customer_name.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customer_name.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.customer_name.Location = new System.Drawing.Point(712, 78);
            this.customer_name.Name = "customer_name";
            this.customer_name.Size = new System.Drawing.Size(177, 25);
            this.customer_name.TabIndex = 6;
            this.customer_name.Text = "Customer Name";
            // 
            // Date_issued
            // 
            this.Date_issued.AutoSize = true;
            this.Date_issued.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Date_issued.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Date_issued.Location = new System.Drawing.Point(712, 170);
            this.Date_issued.Name = "Date_issued";
            this.Date_issued.Size = new System.Drawing.Size(152, 25);
            this.Date_issued.TabIndex = 7;
            this.Date_issued.Text = "Date of Issue";
            // 
            // movie_name
            // 
            this.movie_name.AutoSize = true;
            this.movie_name.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.movie_name.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.movie_name.Location = new System.Drawing.Point(712, 126);
            this.movie_name.Name = "movie_name";
            this.movie_name.Size = new System.Drawing.Size(145, 25);
            this.movie_name.TabIndex = 8;
            this.movie_name.Text = "Movie Name";
            // 
            // Date_returned
            // 
            this.Date_returned.AutoSize = true;
            this.Date_returned.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Date_returned.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Date_returned.Location = new System.Drawing.Point(712, 212);
            this.Date_returned.Name = "Date_returned";
            this.Date_returned.Size = new System.Drawing.Size(173, 25);
            this.Date_returned.TabIndex = 9;
            this.Date_returned.Text = "Date of Return";
            // 
            // mov_rental_name
            // 
            this.mov_rental_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mov_rental_name.Location = new System.Drawing.Point(902, 126);
            this.mov_rental_name.Name = "mov_rental_name";
            this.mov_rental_name.Size = new System.Drawing.Size(100, 24);
            this.mov_rental_name.TabIndex = 10;
            // 
            // BookingDate
            // 
            this.BookingDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.BookingDate.Location = new System.Drawing.Point(902, 170);
            this.BookingDate.Name = "BookingDate";
            this.BookingDate.Size = new System.Drawing.Size(100, 20);
            this.BookingDate.TabIndex = 11;
            // 
            // returnDate
            // 
            this.returnDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.returnDate.Location = new System.Drawing.Point(902, 212);
            this.returnDate.Name = "returnDate";
            this.returnDate.Size = new System.Drawing.Size(100, 20);
            this.returnDate.TabIndex = 12;
            // 
            // now_issue_btn
            // 
            this.now_issue_btn.BackColor = System.Drawing.Color.Maroon;
            this.now_issue_btn.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.now_issue_btn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.now_issue_btn.Location = new System.Drawing.Point(692, 276);
            this.now_issue_btn.Name = "now_issue_btn";
            this.now_issue_btn.Size = new System.Drawing.Size(124, 48);
            this.now_issue_btn.TabIndex = 13;
            this.now_issue_btn.Text = "Issue Movie";
            this.now_issue_btn.UseVisualStyleBackColor = false;
            this.now_issue_btn.Click += new System.EventHandler(this.now_issue_btn_Click);
            // 
            // return_btn
            // 
            this.return_btn.BackColor = System.Drawing.Color.Maroon;
            this.return_btn.Font = new System.Drawing.Font("Modern No. 20", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.return_btn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.return_btn.Location = new System.Drawing.Point(822, 276);
            this.return_btn.Name = "return_btn";
            this.return_btn.Size = new System.Drawing.Size(111, 48);
            this.return_btn.TabIndex = 14;
            this.return_btn.Text = "Return Movie";
            this.return_btn.UseVisualStyleBackColor = false;
            this.return_btn.Click += new System.EventHandler(this.return_btn_Click);
            // 
            // popular_customer
            // 
            this.popular_customer.BackColor = System.Drawing.Color.Maroon;
            this.popular_customer.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.popular_customer.ForeColor = System.Drawing.SystemColors.Control;
            this.popular_customer.Location = new System.Drawing.Point(614, 0);
            this.popular_customer.Name = "popular_customer";
            this.popular_customer.Size = new System.Drawing.Size(138, 56);
            this.popular_customer.TabIndex = 16;
            this.popular_customer.Text = "Popular Customer";
            this.popular_customer.UseVisualStyleBackColor = false;
            this.popular_customer.Click += new System.EventHandler(this.popular_customer_Click);
            // 
            // popular_movie
            // 
            this.popular_movie.BackColor = System.Drawing.Color.Maroon;
            this.popular_movie.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.popular_movie.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.popular_movie.Location = new System.Drawing.Point(468, 0);
            this.popular_movie.Name = "popular_movie";
            this.popular_movie.Size = new System.Drawing.Size(118, 56);
            this.popular_movie.TabIndex = 15;
            this.popular_movie.Text = "Popular Movie";
            this.popular_movie.UseVisualStyleBackColor = false;
            this.popular_movie.Click += new System.EventHandler(this.popular_movie_Click);
            // 
            // delete_movon_rentals
            // 
            this.delete_movon_rentals.BackColor = System.Drawing.Color.Maroon;
            this.delete_movon_rentals.Font = new System.Drawing.Font("Calisto MT", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delete_movon_rentals.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.delete_movon_rentals.Location = new System.Drawing.Point(939, 273);
            this.delete_movon_rentals.Name = "delete_movon_rentals";
            this.delete_movon_rentals.Size = new System.Drawing.Size(114, 48);
            this.delete_movon_rentals.TabIndex = 17;
            this.delete_movon_rentals.Text = "Delete";
            this.delete_movon_rentals.UseVisualStyleBackColor = false;
            this.delete_movon_rentals.Click += new System.EventHandler(this.delete_movon_rentals_Click);
            // 
            // Rentals
            // 
            this.Rentals.AutoSize = true;
            this.Rentals.BackColor = System.Drawing.Color.White;
            this.Rentals.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Rentals.Location = new System.Drawing.Point(817, 23);
            this.Rentals.Name = "Rentals";
            this.Rentals.Size = new System.Drawing.Size(93, 25);
            this.Rentals.TabIndex = 4;
            this.Rentals.Text = "Rentals";
            this.Rentals.Click += new System.EventHandler(this.Rentals_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.DimGray;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(19, 361);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(309, 25);
            this.label1.TabIndex = 18;
            this.label1.Text = "Add/ Update/ Delete Movies";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.DimGray;
            this.label2.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(712, 361);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(341, 25);
            this.label2.TabIndex = 19;
            this.label2.Text = "Add/ Update/ Delete Customers";
            // 
            // mov_delete
            // 
            this.mov_delete.BackColor = System.Drawing.Color.Maroon;
            this.mov_delete.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mov_delete.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.mov_delete.Location = new System.Drawing.Point(433, 535);
            this.mov_delete.Name = "mov_delete";
            this.mov_delete.Size = new System.Drawing.Size(111, 36);
            this.mov_delete.TabIndex = 26;
            this.mov_delete.Text = "Delete";
            this.mov_delete.UseVisualStyleBackColor = false;
            this.mov_delete.Click += new System.EventHandler(this.mov_delete_Click);
            // 
            // mov_update
            // 
            this.mov_update.BackColor = System.Drawing.Color.Maroon;
            this.mov_update.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mov_update.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.mov_update.Location = new System.Drawing.Point(260, 535);
            this.mov_update.Name = "mov_update";
            this.mov_update.Size = new System.Drawing.Size(111, 36);
            this.mov_update.TabIndex = 25;
            this.mov_update.Text = "Update";
            this.mov_update.UseVisualStyleBackColor = false;
            this.mov_update.Click += new System.EventHandler(this.mov_update_Click);
            // 
            // add_mov
            // 
            this.add_mov.BackColor = System.Drawing.Color.Maroon;
            this.add_mov.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add_mov.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.add_mov.Location = new System.Drawing.Point(71, 535);
            this.add_mov.Name = "add_mov";
            this.add_mov.Size = new System.Drawing.Size(111, 36);
            this.add_mov.TabIndex = 24;
            this.add_mov.Text = "Add";
            this.add_mov.UseVisualStyleBackColor = false;
            this.add_mov.Click += new System.EventHandler(this.add_mov_Click);
            // 
            // points
            // 
            this.points.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.points.Location = new System.Drawing.Point(236, 452);
            this.points.Name = "points";
            this.points.Size = new System.Drawing.Size(124, 24);
            this.points.TabIndex = 23;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(28, 407);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(145, 25);
            this.label3.TabIndex = 22;
            this.label3.Text = "Movie Name";
            // 
            // stars
            // 
            this.stars.AutoSize = true;
            this.stars.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stars.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.stars.Location = new System.Drawing.Point(28, 450);
            this.stars.Name = "stars";
            this.stars.Size = new System.Drawing.Size(81, 25);
            this.stars.TabIndex = 21;
            this.stars.Text = "Points";
            // 
            // mov_name
            // 
            this.mov_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mov_name.Location = new System.Drawing.Point(236, 409);
            this.mov_name.Name = "mov_name";
            this.mov_name.Size = new System.Drawing.Size(124, 24);
            this.mov_name.TabIndex = 20;
            // 
            // Yearpermov
            // 
            this.Yearpermov.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Yearpermov.Location = new System.Drawing.Point(236, 489);
            this.Yearpermov.Name = "Yearpermov";
            this.Yearpermov.Size = new System.Drawing.Size(124, 24);
            this.Yearpermov.TabIndex = 28;
            this.Yearpermov.TextChanged += new System.EventHandler(this.Yearpermov_TextChanged);
            // 
            // costpermovie
            // 
            this.costpermovie.AutoSize = true;
            this.costpermovie.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.costpermovie.ForeColor = System.Drawing.SystemColors.Control;
            this.costpermovie.Location = new System.Drawing.Point(28, 487);
            this.costpermovie.Name = "costpermovie";
            this.costpermovie.Size = new System.Drawing.Size(63, 25);
            this.costpermovie.TabIndex = 27;
            this.costpermovie.Text = "Year";
            // 
            // genres
            // 
            this.genres.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.genres.Location = new System.Drawing.Point(553, 491);
            this.genres.Name = "genres";
            this.genres.Size = new System.Drawing.Size(133, 24);
            this.genres.TabIndex = 34;
            // 
            // genre
            // 
            this.genre.AutoSize = true;
            this.genre.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.genre.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.genre.Location = new System.Drawing.Point(377, 487);
            this.genre.Name = "genre";
            this.genre.Size = new System.Drawing.Size(75, 25);
            this.genre.TabIndex = 33;
            this.genre.Text = "Genre";
            // 
            // Costs
            // 
            this.Costs.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Costs.Location = new System.Drawing.Point(553, 454);
            this.Costs.Name = "Costs";
            this.Costs.Size = new System.Drawing.Size(133, 24);
            this.Costs.TabIndex = 32;
            // 
            // copies
            // 
            this.copies.AutoSize = true;
            this.copies.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.copies.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.copies.Location = new System.Drawing.Point(377, 407);
            this.copies.Name = "copies";
            this.copies.Size = new System.Drawing.Size(80, 25);
            this.copies.TabIndex = 31;
            this.copies.Text = "Copies";
            // 
            // Cost
            // 
            this.Cost.AutoSize = true;
            this.Cost.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cost.ForeColor = System.Drawing.SystemColors.Control;
            this.Cost.Location = new System.Drawing.Point(377, 450);
            this.Cost.Name = "Cost";
            this.Cost.Size = new System.Drawing.Size(55, 25);
            this.Cost.TabIndex = 30;
            this.Cost.Text = "Cost";
            // 
            // text_copies
            // 
            this.text_copies.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_copies.Location = new System.Drawing.Point(553, 409);
            this.text_copies.Name = "text_copies";
            this.text_copies.Size = new System.Drawing.Size(133, 24);
            this.text_copies.TabIndex = 29;
            // 
            // contact
            // 
            this.contact.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contact.Location = new System.Drawing.Point(976, 491);
            this.contact.Name = "contact";
            this.contact.Size = new System.Drawing.Size(100, 24);
            this.contact.TabIndex = 40;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label9.Location = new System.Drawing.Point(744, 489);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(91, 25);
            this.label9.TabIndex = 39;
            this.label9.Text = "Contact";
            // 
            // age
            // 
            this.age.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.age.Location = new System.Drawing.Point(976, 454);
            this.age.Name = "age";
            this.age.Size = new System.Drawing.Size(100, 24);
            this.age.TabIndex = 38;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label10.Location = new System.Drawing.Point(744, 409);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(177, 25);
            this.label10.TabIndex = 37;
            this.label10.Text = "Customer Name";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label11.Location = new System.Drawing.Point(744, 452);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(52, 25);
            this.label11.TabIndex = 36;
            this.label11.Text = "Age";
            // 
            // nameofcustomer
            // 
            this.nameofcustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameofcustomer.Location = new System.Drawing.Point(976, 411);
            this.nameofcustomer.Name = "nameofcustomer";
            this.nameofcustomer.Size = new System.Drawing.Size(100, 24);
            this.nameofcustomer.TabIndex = 35;
            this.nameofcustomer.TextChanged += new System.EventHandler(this.nameofcustomer_TextChanged);
            // 
            // customer_del
            // 
            this.customer_del.BackColor = System.Drawing.Color.Maroon;
            this.customer_del.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customer_del.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.customer_del.Location = new System.Drawing.Point(960, 535);
            this.customer_del.Name = "customer_del";
            this.customer_del.Size = new System.Drawing.Size(111, 36);
            this.customer_del.TabIndex = 43;
            this.customer_del.Text = "Delete";
            this.customer_del.UseVisualStyleBackColor = false;
            this.customer_del.Click += new System.EventHandler(this.customer_del_Click);
            // 
            // customer_update
            // 
            this.customer_update.BackColor = System.Drawing.Color.Maroon;
            this.customer_update.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customer_update.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.customer_update.Location = new System.Drawing.Point(843, 535);
            this.customer_update.Name = "customer_update";
            this.customer_update.Size = new System.Drawing.Size(111, 36);
            this.customer_update.TabIndex = 42;
            this.customer_update.Text = " Update";
            this.customer_update.UseVisualStyleBackColor = false;
            this.customer_update.Click += new System.EventHandler(this.customer_update_Click);
            // 
            // customer_add
            // 
            this.customer_add.BackColor = System.Drawing.Color.Maroon;
            this.customer_add.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customer_add.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.customer_add.Location = new System.Drawing.Point(726, 535);
            this.customer_add.Name = "customer_add";
            this.customer_add.Size = new System.Drawing.Size(111, 36);
            this.customer_add.TabIndex = 41;
            this.customer_add.Text = "Add";
            this.customer_add.UseVisualStyleBackColor = false;
            this.customer_add.Click += new System.EventHandler(this.customer_add_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Black;
            this.pictureBox1.Location = new System.Drawing.Point(692, 352);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(10, 209);
            this.pictureBox1.TabIndex = 44;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Black;
            this.pictureBox2.Location = new System.Drawing.Point(-1, 348);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(1088, 10);
            this.pictureBox2.TabIndex = 45;
            this.pictureBox2.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Red;
            this.ClientSize = new System.Drawing.Size(1088, 583);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.customer_del);
            this.Controls.Add(this.customer_update);
            this.Controls.Add(this.customer_add);
            this.Controls.Add(this.contact);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.age);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.nameofcustomer);
            this.Controls.Add(this.genres);
            this.Controls.Add(this.genre);
            this.Controls.Add(this.Costs);
            this.Controls.Add(this.copies);
            this.Controls.Add(this.Cost);
            this.Controls.Add(this.text_copies);
            this.Controls.Add(this.Yearpermov);
            this.Controls.Add(this.costpermovie);
            this.Controls.Add(this.mov_delete);
            this.Controls.Add(this.mov_update);
            this.Controls.Add(this.add_mov);
            this.Controls.Add(this.points);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.stars);
            this.Controls.Add(this.mov_name);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.delete_movon_rentals);
            this.Controls.Add(this.popular_customer);
            this.Controls.Add(this.popular_movie);
            this.Controls.Add(this.return_btn);
            this.Controls.Add(this.now_issue_btn);
            this.Controls.Add(this.returnDate);
            this.Controls.Add(this.BookingDate);
            this.Controls.Add(this.mov_rental_name);
            this.Controls.Add(this.Date_returned);
            this.Controls.Add(this.movie_name);
            this.Controls.Add(this.Date_issued);
            this.Controls.Add(this.customer_name);
            this.Controls.Add(this.rental_cus_name);
            this.Controls.Add(this.Rentals);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Issued_movies);
            this.Controls.Add(this.choose_customers);
            this.Controls.Add(this.choose_movies);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton choose_movies;
        private System.Windows.Forms.RadioButton choose_customers;
        private System.Windows.Forms.RadioButton Issued_movies;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox rental_cus_name;
        private System.Windows.Forms.Label customer_name;
        private System.Windows.Forms.Label Date_issued;
        private System.Windows.Forms.Label movie_name;
        private System.Windows.Forms.Label Date_returned;
        private System.Windows.Forms.TextBox mov_rental_name;
        private System.Windows.Forms.DateTimePicker BookingDate;
        private System.Windows.Forms.DateTimePicker returnDate;
        private System.Windows.Forms.Button now_issue_btn;
        private System.Windows.Forms.Button return_btn;
        private System.Windows.Forms.Button popular_customer;
        private System.Windows.Forms.Button popular_movie;
        private System.Windows.Forms.Button delete_movon_rentals;
        private System.Windows.Forms.Label Rentals;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button mov_delete;
        private System.Windows.Forms.Button mov_update;
        private System.Windows.Forms.Button add_mov;
        private System.Windows.Forms.TextBox points;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label stars;
        private System.Windows.Forms.TextBox mov_name;
        private System.Windows.Forms.TextBox Yearpermov;
        private System.Windows.Forms.Label costpermovie;
        private System.Windows.Forms.TextBox genres;
        private System.Windows.Forms.Label genre;
        private System.Windows.Forms.TextBox Costs;
        private System.Windows.Forms.Label copies;
        private System.Windows.Forms.Label Cost;
        private System.Windows.Forms.TextBox text_copies;
        private System.Windows.Forms.TextBox contact;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox age;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox nameofcustomer;
        private System.Windows.Forms.Button customer_del;
        private System.Windows.Forms.Button customer_update;
        private System.Windows.Forms.Button customer_add;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}

