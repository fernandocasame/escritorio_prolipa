namespace Prolipa.vistas
{
    partial class Principal
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
            this.components = new System.ComponentModel.Container();
            AnimatorNS.Animation animation5 = new AnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Principal));
            AnimatorNS.Animation animation6 = new AnimatorNS.Animation();
            this.AnimacionSidebarBack = new AnimatorNS.Animator(this.components);
            this.SidebarWrapper = new System.Windows.Forms.Panel();
            this.Sidebar = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.btnPlanificaciones = new System.Windows.Forms.Button();
            this.btnMaterial = new System.Windows.Forms.Button();
            this.btnPlanlector = new System.Windows.Forms.Button();
            this.guiaSubMenu = new System.Windows.Forms.Panel();
            this.button10 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.btnGuias = new System.Windows.Forms.Button();
            this.cuadernoSubMenu = new System.Windows.Forms.Panel();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.btnCuaderno = new System.Windows.Forms.Button();
            this.libroSubMenu = new System.Windows.Forms.Panel();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnLibro = new System.Windows.Forms.Button();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.LineaSidebar = new Bunifu.Framework.UI.BunifuSeparator();
            this.logo = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Wrapper = new System.Windows.Forms.Panel();
            this.libro = new System.Windows.Forms.Panel();
            this.check = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.label11 = new System.Windows.Forms.Label();
            this.descarga = new System.Windows.Forms.Panel();
            this.login = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.ingresar = new Bunifu.Framework.UI.BunifuThinButton2();
            this.password = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.usuario = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.AnimacionSidebar = new AnimatorNS.Animator(this.components);
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuElipse2 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuElipse3 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.SidebarWrapper.SuspendLayout();
            this.Sidebar.SuspendLayout();
            this.guiaSubMenu.SuspendLayout();
            this.cuadernoSubMenu.SuspendLayout();
            this.libroSubMenu.SuspendLayout();
            this.panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.Wrapper.SuspendLayout();
            this.libro.SuspendLayout();
            this.descarga.SuspendLayout();
            this.login.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // AnimacionSidebarBack
            // 
            this.AnimacionSidebarBack.AnimationType = AnimatorNS.AnimationType.HorizSlide;
            this.AnimacionSidebarBack.Cursor = null;
            animation5.AnimateOnlyDifferences = true;
            animation5.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation5.BlindCoeff")));
            animation5.LeafCoeff = 0F;
            animation5.MaxTime = 1F;
            animation5.MinTime = 0F;
            animation5.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation5.MosaicCoeff")));
            animation5.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation5.MosaicShift")));
            animation5.MosaicSize = 0;
            animation5.Padding = new System.Windows.Forms.Padding(0);
            animation5.RotateCoeff = 0F;
            animation5.RotateLimit = 0F;
            animation5.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation5.ScaleCoeff")));
            animation5.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation5.SlideCoeff")));
            animation5.TimeCoeff = 0F;
            animation5.TransparencyCoeff = 0F;
            this.AnimacionSidebarBack.DefaultAnimation = animation5;
            // 
            // SidebarWrapper
            // 
            this.SidebarWrapper.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.SidebarWrapper.Controls.Add(this.Sidebar);
            this.AnimacionSidebar.SetDecoration(this.SidebarWrapper, AnimatorNS.DecorationType.None);
            this.AnimacionSidebarBack.SetDecoration(this.SidebarWrapper, AnimatorNS.DecorationType.None);
            this.SidebarWrapper.Dock = System.Windows.Forms.DockStyle.Left;
            this.SidebarWrapper.Location = new System.Drawing.Point(0, 0);
            this.SidebarWrapper.Name = "SidebarWrapper";
            this.SidebarWrapper.Size = new System.Drawing.Size(267, 694);
            this.SidebarWrapper.TabIndex = 5;
            // 
            // Sidebar
            // 
            this.Sidebar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.Sidebar.AutoScroll = true;
            this.Sidebar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(41)))), ((int)(((byte)(61)))));
            this.Sidebar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Sidebar.BackgroundImage")));
            this.Sidebar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Sidebar.Controls.Add(this.btnPlanificaciones);
            this.Sidebar.Controls.Add(this.btnMaterial);
            this.Sidebar.Controls.Add(this.btnPlanlector);
            this.Sidebar.Controls.Add(this.guiaSubMenu);
            this.Sidebar.Controls.Add(this.btnGuias);
            this.Sidebar.Controls.Add(this.cuadernoSubMenu);
            this.Sidebar.Controls.Add(this.btnCuaderno);
            this.Sidebar.Controls.Add(this.libroSubMenu);
            this.Sidebar.Controls.Add(this.btnLibro);
            this.Sidebar.Controls.Add(this.panelLogo);
            this.AnimacionSidebar.SetDecoration(this.Sidebar, AnimatorNS.DecorationType.None);
            this.AnimacionSidebarBack.SetDecoration(this.Sidebar, AnimatorNS.DecorationType.None);
            this.Sidebar.GradientBottomLeft = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(41)))), ((int)(((byte)(61)))));
            this.Sidebar.GradientBottomRight = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(41)))), ((int)(((byte)(61)))));
            this.Sidebar.GradientTopLeft = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(41)))), ((int)(((byte)(61)))));
            this.Sidebar.GradientTopRight = System.Drawing.Color.DodgerBlue;
            this.Sidebar.Location = new System.Drawing.Point(8, 24);
            this.Sidebar.Name = "Sidebar";
            this.Sidebar.Quality = 20;
            this.Sidebar.Size = new System.Drawing.Size(251, 658);
            this.Sidebar.TabIndex = 0;
            this.Sidebar.Paint += new System.Windows.Forms.PaintEventHandler(this.Sidebar_Paint);
            // 
            // btnPlanificaciones
            // 
            this.btnPlanificaciones.BackColor = System.Drawing.Color.Transparent;
            this.AnimacionSidebarBack.SetDecoration(this.btnPlanificaciones, AnimatorNS.DecorationType.None);
            this.AnimacionSidebar.SetDecoration(this.btnPlanificaciones, AnimatorNS.DecorationType.None);
            this.btnPlanificaciones.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnPlanificaciones.FlatAppearance.BorderSize = 0;
            this.btnPlanificaciones.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(32)))));
            this.btnPlanificaciones.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(22)))), ((int)(((byte)(34)))));
            this.btnPlanificaciones.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPlanificaciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlanificaciones.ForeColor = System.Drawing.Color.White;
            this.btnPlanificaciones.Image = global::Prolipa.Properties.Resources.plani;
            this.btnPlanificaciones.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPlanificaciones.Location = new System.Drawing.Point(0, 684);
            this.btnPlanificaciones.Name = "btnPlanificaciones";
            this.btnPlanificaciones.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnPlanificaciones.Size = new System.Drawing.Size(234, 45);
            this.btnPlanificaciones.TabIndex = 11;
            this.btnPlanificaciones.Text = "  Planificaciones";
            this.btnPlanificaciones.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPlanificaciones.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPlanificaciones.UseVisualStyleBackColor = false;
            this.btnPlanificaciones.Click += new System.EventHandler(this.BunifuFlatButton10_Click);
            // 
            // btnMaterial
            // 
            this.btnMaterial.BackColor = System.Drawing.Color.Transparent;
            this.AnimacionSidebarBack.SetDecoration(this.btnMaterial, AnimatorNS.DecorationType.None);
            this.AnimacionSidebar.SetDecoration(this.btnMaterial, AnimatorNS.DecorationType.None);
            this.btnMaterial.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMaterial.FlatAppearance.BorderSize = 0;
            this.btnMaterial.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(32)))));
            this.btnMaterial.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(22)))), ((int)(((byte)(34)))));
            this.btnMaterial.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMaterial.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMaterial.ForeColor = System.Drawing.Color.White;
            this.btnMaterial.Image = global::Prolipa.Properties.Resources.material;
            this.btnMaterial.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMaterial.Location = new System.Drawing.Point(0, 639);
            this.btnMaterial.Name = "btnMaterial";
            this.btnMaterial.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnMaterial.Size = new System.Drawing.Size(234, 45);
            this.btnMaterial.TabIndex = 10;
            this.btnMaterial.Text = "  Material de Apoyo";
            this.btnMaterial.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMaterial.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnMaterial.UseVisualStyleBackColor = false;
            this.btnMaterial.Click += new System.EventHandler(this.BunifuFlatButton5_Click);
            // 
            // btnPlanlector
            // 
            this.btnPlanlector.BackColor = System.Drawing.Color.Transparent;
            this.AnimacionSidebarBack.SetDecoration(this.btnPlanlector, AnimatorNS.DecorationType.None);
            this.AnimacionSidebar.SetDecoration(this.btnPlanlector, AnimatorNS.DecorationType.None);
            this.btnPlanlector.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnPlanlector.FlatAppearance.BorderSize = 0;
            this.btnPlanlector.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(32)))));
            this.btnPlanlector.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(22)))), ((int)(((byte)(34)))));
            this.btnPlanlector.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPlanlector.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlanlector.ForeColor = System.Drawing.Color.White;
            this.btnPlanlector.Image = global::Prolipa.Properties.Resources.plan;
            this.btnPlanlector.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPlanlector.Location = new System.Drawing.Point(0, 594);
            this.btnPlanlector.Name = "btnPlanlector";
            this.btnPlanlector.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnPlanlector.Size = new System.Drawing.Size(234, 45);
            this.btnPlanlector.TabIndex = 9;
            this.btnPlanlector.Text = "  Plan Lector";
            this.btnPlanlector.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPlanlector.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPlanlector.UseVisualStyleBackColor = false;
            this.btnPlanlector.Click += new System.EventHandler(this.BunifuFlatButton4_Click);
            // 
            // guiaSubMenu
            // 
            this.guiaSubMenu.BackColor = System.Drawing.Color.Transparent;
            this.guiaSubMenu.Controls.Add(this.button10);
            this.guiaSubMenu.Controls.Add(this.button12);
            this.guiaSubMenu.Controls.Add(this.button13);
            this.AnimacionSidebar.SetDecoration(this.guiaSubMenu, AnimatorNS.DecorationType.None);
            this.AnimacionSidebarBack.SetDecoration(this.guiaSubMenu, AnimatorNS.DecorationType.None);
            this.guiaSubMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.guiaSubMenu.Location = new System.Drawing.Point(0, 470);
            this.guiaSubMenu.Name = "guiaSubMenu";
            this.guiaSubMenu.Size = new System.Drawing.Size(234, 124);
            this.guiaSubMenu.TabIndex = 8;
            // 
            // button10
            // 
            this.AnimacionSidebarBack.SetDecoration(this.button10, AnimatorNS.DecorationType.None);
            this.AnimacionSidebar.SetDecoration(this.button10, AnimatorNS.DecorationType.None);
            this.button10.Dock = System.Windows.Forms.DockStyle.Top;
            this.button10.FlatAppearance.BorderSize = 0;
            this.button10.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(38)))), ((int)(((byte)(46)))));
            this.button10.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(38)))), ((int)(((byte)(46)))));
            this.button10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button10.ForeColor = System.Drawing.Color.White;
            this.button10.Location = new System.Drawing.Point(0, 80);
            this.button10.Name = "button10";
            this.button10.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.button10.Size = new System.Drawing.Size(234, 40);
            this.button10.TabIndex = 2;
            this.button10.Text = "Pdf guía didáctica";
            this.button10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.Button10_Click);
            // 
            // button12
            // 
            this.AnimacionSidebarBack.SetDecoration(this.button12, AnimatorNS.DecorationType.None);
            this.AnimacionSidebar.SetDecoration(this.button12, AnimatorNS.DecorationType.None);
            this.button12.Dock = System.Windows.Forms.DockStyle.Top;
            this.button12.FlatAppearance.BorderSize = 0;
            this.button12.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(38)))), ((int)(((byte)(46)))));
            this.button12.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(38)))), ((int)(((byte)(46)))));
            this.button12.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button12.ForeColor = System.Drawing.Color.White;
            this.button12.Location = new System.Drawing.Point(0, 40);
            this.button12.Name = "button12";
            this.button12.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.button12.Size = new System.Drawing.Size(234, 40);
            this.button12.TabIndex = 1;
            this.button12.Text = "Pdf con guía";
            this.button12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button12.UseVisualStyleBackColor = true;
            this.button12.Click += new System.EventHandler(this.Button12_Click);
            // 
            // button13
            // 
            this.AnimacionSidebarBack.SetDecoration(this.button13, AnimatorNS.DecorationType.None);
            this.AnimacionSidebar.SetDecoration(this.button13, AnimatorNS.DecorationType.None);
            this.button13.Dock = System.Windows.Forms.DockStyle.Top;
            this.button13.FlatAppearance.BorderSize = 0;
            this.button13.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(38)))), ((int)(((byte)(46)))));
            this.button13.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(38)))), ((int)(((byte)(46)))));
            this.button13.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button13.ForeColor = System.Drawing.Color.White;
            this.button13.Location = new System.Drawing.Point(0, 0);
            this.button13.Name = "button13";
            this.button13.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.button13.Size = new System.Drawing.Size(234, 40);
            this.button13.TabIndex = 0;
            this.button13.Text = "Pdf sin guía";
            this.button13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button13.UseVisualStyleBackColor = true;
            this.button13.Click += new System.EventHandler(this.Button13_Click);
            // 
            // btnGuias
            // 
            this.btnGuias.BackColor = System.Drawing.Color.Transparent;
            this.AnimacionSidebarBack.SetDecoration(this.btnGuias, AnimatorNS.DecorationType.None);
            this.AnimacionSidebar.SetDecoration(this.btnGuias, AnimatorNS.DecorationType.None);
            this.btnGuias.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnGuias.FlatAppearance.BorderSize = 0;
            this.btnGuias.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(32)))));
            this.btnGuias.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(22)))), ((int)(((byte)(34)))));
            this.btnGuias.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuias.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuias.ForeColor = System.Drawing.Color.White;
            this.btnGuias.Image = global::Prolipa.Properties.Resources.guia;
            this.btnGuias.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGuias.Location = new System.Drawing.Point(0, 425);
            this.btnGuias.Name = "btnGuias";
            this.btnGuias.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnGuias.Size = new System.Drawing.Size(234, 45);
            this.btnGuias.TabIndex = 7;
            this.btnGuias.Text = "  Guías";
            this.btnGuias.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGuias.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnGuias.UseVisualStyleBackColor = false;
            this.btnGuias.Click += new System.EventHandler(this.BunifuFlatButton3_Click);
            // 
            // cuadernoSubMenu
            // 
            this.cuadernoSubMenu.BackColor = System.Drawing.Color.Transparent;
            this.cuadernoSubMenu.Controls.Add(this.button7);
            this.cuadernoSubMenu.Controls.Add(this.button8);
            this.cuadernoSubMenu.Controls.Add(this.button9);
            this.AnimacionSidebar.SetDecoration(this.cuadernoSubMenu, AnimatorNS.DecorationType.None);
            this.AnimacionSidebarBack.SetDecoration(this.cuadernoSubMenu, AnimatorNS.DecorationType.None);
            this.cuadernoSubMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.cuadernoSubMenu.Location = new System.Drawing.Point(0, 302);
            this.cuadernoSubMenu.Name = "cuadernoSubMenu";
            this.cuadernoSubMenu.Size = new System.Drawing.Size(234, 123);
            this.cuadernoSubMenu.TabIndex = 5;
            // 
            // button7
            // 
            this.AnimacionSidebarBack.SetDecoration(this.button7, AnimatorNS.DecorationType.None);
            this.AnimacionSidebar.SetDecoration(this.button7, AnimatorNS.DecorationType.None);
            this.button7.Dock = System.Windows.Forms.DockStyle.Top;
            this.button7.FlatAppearance.BorderSize = 0;
            this.button7.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(38)))), ((int)(((byte)(46)))));
            this.button7.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(38)))), ((int)(((byte)(46)))));
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.ForeColor = System.Drawing.Color.White;
            this.button7.Location = new System.Drawing.Point(0, 80);
            this.button7.Name = "button7";
            this.button7.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.button7.Size = new System.Drawing.Size(234, 40);
            this.button7.TabIndex = 2;
            this.button7.Text = "Pdf guía didáctica";
            this.button7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.Button7_Click);
            // 
            // button8
            // 
            this.AnimacionSidebarBack.SetDecoration(this.button8, AnimatorNS.DecorationType.None);
            this.AnimacionSidebar.SetDecoration(this.button8, AnimatorNS.DecorationType.None);
            this.button8.Dock = System.Windows.Forms.DockStyle.Top;
            this.button8.FlatAppearance.BorderSize = 0;
            this.button8.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(38)))), ((int)(((byte)(46)))));
            this.button8.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(38)))), ((int)(((byte)(46)))));
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button8.ForeColor = System.Drawing.Color.White;
            this.button8.Location = new System.Drawing.Point(0, 40);
            this.button8.Name = "button8";
            this.button8.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.button8.Size = new System.Drawing.Size(234, 40);
            this.button8.TabIndex = 1;
            this.button8.Text = "Pdf con guía";
            this.button8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.Button8_Click);
            // 
            // button9
            // 
            this.AnimacionSidebarBack.SetDecoration(this.button9, AnimatorNS.DecorationType.None);
            this.AnimacionSidebar.SetDecoration(this.button9, AnimatorNS.DecorationType.None);
            this.button9.Dock = System.Windows.Forms.DockStyle.Top;
            this.button9.FlatAppearance.BorderSize = 0;
            this.button9.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(38)))), ((int)(((byte)(46)))));
            this.button9.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(38)))), ((int)(((byte)(46)))));
            this.button9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button9.ForeColor = System.Drawing.Color.White;
            this.button9.Location = new System.Drawing.Point(0, 0);
            this.button9.Name = "button9";
            this.button9.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.button9.Size = new System.Drawing.Size(234, 40);
            this.button9.TabIndex = 0;
            this.button9.Text = "Pdf sin guía";
            this.button9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.Button9_Click);
            // 
            // btnCuaderno
            // 
            this.btnCuaderno.BackColor = System.Drawing.Color.Transparent;
            this.AnimacionSidebarBack.SetDecoration(this.btnCuaderno, AnimatorNS.DecorationType.None);
            this.AnimacionSidebar.SetDecoration(this.btnCuaderno, AnimatorNS.DecorationType.None);
            this.btnCuaderno.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCuaderno.FlatAppearance.BorderSize = 0;
            this.btnCuaderno.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(32)))));
            this.btnCuaderno.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(22)))), ((int)(((byte)(34)))));
            this.btnCuaderno.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCuaderno.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCuaderno.ForeColor = System.Drawing.Color.White;
            this.btnCuaderno.Image = global::Prolipa.Properties.Resources.cuaderno;
            this.btnCuaderno.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCuaderno.Location = new System.Drawing.Point(0, 257);
            this.btnCuaderno.Name = "btnCuaderno";
            this.btnCuaderno.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnCuaderno.Size = new System.Drawing.Size(234, 45);
            this.btnCuaderno.TabIndex = 4;
            this.btnCuaderno.Text = "  Cuaderno";
            this.btnCuaderno.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCuaderno.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCuaderno.UseVisualStyleBackColor = false;
            this.btnCuaderno.Click += new System.EventHandler(this.BunifuFlatButton2_Click);
            // 
            // libroSubMenu
            // 
            this.libroSubMenu.BackColor = System.Drawing.Color.Transparent;
            this.libroSubMenu.Controls.Add(this.button4);
            this.libroSubMenu.Controls.Add(this.button3);
            this.libroSubMenu.Controls.Add(this.button2);
            this.AnimacionSidebar.SetDecoration(this.libroSubMenu, AnimatorNS.DecorationType.None);
            this.AnimacionSidebarBack.SetDecoration(this.libroSubMenu, AnimatorNS.DecorationType.None);
            this.libroSubMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.libroSubMenu.Location = new System.Drawing.Point(0, 137);
            this.libroSubMenu.Name = "libroSubMenu";
            this.libroSubMenu.Size = new System.Drawing.Size(234, 120);
            this.libroSubMenu.TabIndex = 3;
            // 
            // button4
            // 
            this.AnimacionSidebarBack.SetDecoration(this.button4, AnimatorNS.DecorationType.None);
            this.AnimacionSidebar.SetDecoration(this.button4, AnimatorNS.DecorationType.None);
            this.button4.Dock = System.Windows.Forms.DockStyle.Top;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(38)))), ((int)(((byte)(46)))));
            this.button4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(38)))), ((int)(((byte)(46)))));
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Location = new System.Drawing.Point(0, 80);
            this.button4.Name = "button4";
            this.button4.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.button4.Size = new System.Drawing.Size(234, 40);
            this.button4.TabIndex = 2;
            this.button4.Text = "Pdf guía didáctica";
            this.button4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.Button4_Click);
            // 
            // button3
            // 
            this.AnimacionSidebarBack.SetDecoration(this.button3, AnimatorNS.DecorationType.None);
            this.AnimacionSidebar.SetDecoration(this.button3, AnimatorNS.DecorationType.None);
            this.button3.Dock = System.Windows.Forms.DockStyle.Top;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(38)))), ((int)(((byte)(46)))));
            this.button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(38)))), ((int)(((byte)(46)))));
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(0, 40);
            this.button3.Name = "button3";
            this.button3.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.button3.Size = new System.Drawing.Size(234, 40);
            this.button3.TabIndex = 1;
            this.button3.Text = "Pdf con guía";
            this.button3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.Button3_Click);
            // 
            // button2
            // 
            this.AnimacionSidebarBack.SetDecoration(this.button2, AnimatorNS.DecorationType.None);
            this.AnimacionSidebar.SetDecoration(this.button2, AnimatorNS.DecorationType.None);
            this.button2.Dock = System.Windows.Forms.DockStyle.Top;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(38)))), ((int)(((byte)(46)))));
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(38)))), ((int)(((byte)(46)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(0, 0);
            this.button2.Name = "button2";
            this.button2.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.button2.Size = new System.Drawing.Size(234, 40);
            this.button2.TabIndex = 0;
            this.button2.Text = "Pdf sin guía";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // btnLibro
            // 
            this.btnLibro.BackColor = System.Drawing.Color.Transparent;
            this.AnimacionSidebarBack.SetDecoration(this.btnLibro, AnimatorNS.DecorationType.None);
            this.AnimacionSidebar.SetDecoration(this.btnLibro, AnimatorNS.DecorationType.None);
            this.btnLibro.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnLibro.FlatAppearance.BorderSize = 0;
            this.btnLibro.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(32)))));
            this.btnLibro.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(22)))), ((int)(((byte)(34)))));
            this.btnLibro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLibro.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLibro.ForeColor = System.Drawing.Color.White;
            this.btnLibro.Image = global::Prolipa.Properties.Resources.libro;
            this.btnLibro.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLibro.Location = new System.Drawing.Point(0, 92);
            this.btnLibro.Name = "btnLibro";
            this.btnLibro.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnLibro.Size = new System.Drawing.Size(234, 45);
            this.btnLibro.TabIndex = 2;
            this.btnLibro.Text = "  Libro";
            this.btnLibro.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLibro.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLibro.UseVisualStyleBackColor = false;
            this.btnLibro.Click += new System.EventHandler(this.BunifuFlatButton1_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.BackColor = System.Drawing.Color.Transparent;
            this.panelLogo.Controls.Add(this.LineaSidebar);
            this.panelLogo.Controls.Add(this.logo);
            this.panelLogo.Controls.Add(this.pictureBox1);
            this.AnimacionSidebar.SetDecoration(this.panelLogo, AnimatorNS.DecorationType.None);
            this.AnimacionSidebarBack.SetDecoration(this.panelLogo, AnimatorNS.DecorationType.None);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(234, 92);
            this.panelLogo.TabIndex = 1;
            // 
            // LineaSidebar
            // 
            this.LineaSidebar.BackColor = System.Drawing.Color.Transparent;
            this.AnimacionSidebar.SetDecoration(this.LineaSidebar, AnimatorNS.DecorationType.None);
            this.AnimacionSidebarBack.SetDecoration(this.LineaSidebar, AnimatorNS.DecorationType.None);
            this.LineaSidebar.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.LineaSidebar.LineThickness = 1;
            this.LineaSidebar.Location = new System.Drawing.Point(0, 76);
            this.LineaSidebar.Name = "LineaSidebar";
            this.LineaSidebar.Size = new System.Drawing.Size(251, 10);
            this.LineaSidebar.TabIndex = 7;
            this.LineaSidebar.Transparency = 255;
            this.LineaSidebar.Vertical = false;
            // 
            // logo
            // 
            this.logo.AutoSize = true;
            this.logo.BackColor = System.Drawing.Color.Transparent;
            this.AnimacionSidebarBack.SetDecoration(this.logo, AnimatorNS.DecorationType.None);
            this.AnimacionSidebar.SetDecoration(this.logo, AnimatorNS.DecorationType.None);
            this.logo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logo.ForeColor = System.Drawing.SystemColors.Control;
            this.logo.Location = new System.Drawing.Point(92, 34);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(96, 24);
            this.logo.TabIndex = 15;
            this.logo.Text = "PROLIPA";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.AnimacionSidebarBack.SetDecoration(this.pictureBox1, AnimatorNS.DecorationType.None);
            this.AnimacionSidebar.SetDecoration(this.pictureBox1, AnimatorNS.DecorationType.None);
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(18, 18);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(49, 57);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            // 
            // Wrapper
            // 
            this.Wrapper.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.Wrapper.Controls.Add(this.libro);
            this.AnimacionSidebar.SetDecoration(this.Wrapper, AnimatorNS.DecorationType.None);
            this.AnimacionSidebarBack.SetDecoration(this.Wrapper, AnimatorNS.DecorationType.None);
            this.Wrapper.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Wrapper.Location = new System.Drawing.Point(267, 0);
            this.Wrapper.Name = "Wrapper";
            this.Wrapper.Size = new System.Drawing.Size(766, 694);
            this.Wrapper.TabIndex = 6;
            // 
            // libro
            // 
            this.libro.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.libro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(41)))), ((int)(((byte)(61)))));
            this.libro.Controls.Add(this.check);
            this.libro.Controls.Add(this.label2);
            this.libro.Controls.Add(this.button1);
            this.libro.Controls.Add(this.flowLayoutPanel1);
            this.libro.Controls.Add(this.checkedListBox1);
            this.libro.Controls.Add(this.label11);
            this.AnimacionSidebar.SetDecoration(this.libro, AnimatorNS.DecorationType.None);
            this.AnimacionSidebarBack.SetDecoration(this.libro, AnimatorNS.DecorationType.None);
            this.libro.Location = new System.Drawing.Point(6, 24);
            this.libro.Name = "libro";
            this.libro.Size = new System.Drawing.Size(748, 658);
            this.libro.TabIndex = 4;
            // 
            // check
            // 
            this.check.AutoSize = true;
            this.AnimacionSidebarBack.SetDecoration(this.check, AnimatorNS.DecorationType.None);
            this.AnimacionSidebar.SetDecoration(this.check, AnimatorNS.DecorationType.None);
            this.check.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.check.Location = new System.Drawing.Point(25, 50);
            this.check.Name = "check";
            this.check.Size = new System.Drawing.Size(106, 17);
            this.check.TabIndex = 24;
            this.check.Text = "Seleccionar todo";
            this.check.UseVisualStyleBackColor = true;
            this.check.CheckedChanged += new System.EventHandler(this.Check_CheckedChanged);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.AnimacionSidebarBack.SetDecoration(this.label2, AnimatorNS.DecorationType.None);
            this.AnimacionSidebar.SetDecoration(this.label2, AnimatorNS.DecorationType.None);
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Window;
            this.label2.Location = new System.Drawing.Point(459, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 20);
            this.label2.TabIndex = 23;
            this.label2.Text = "Descargas";
            // 
            // button1
            // 
            this.button1.Activecolor = System.Drawing.Color.Transparent;
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.BackColor = System.Drawing.Color.DarkGreen;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.BorderRadius = 7;
            this.button1.ButtonText = "      SINCRONIZAR";
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AnimacionSidebar.SetDecoration(this.button1, AnimatorNS.DecorationType.None);
            this.AnimacionSidebarBack.SetDecoration(this.button1, AnimatorNS.DecorationType.None);
            this.button1.DisabledColor = System.Drawing.Color.Gray;
            this.button1.Iconcolor = System.Drawing.Color.Transparent;
            this.button1.Iconimage = global::Prolipa.Properties.Resources.path108;
            this.button1.Iconimage_right = null;
            this.button1.Iconimage_right_Selected = null;
            this.button1.Iconimage_Selected = null;
            this.button1.IconMarginLeft = 0;
            this.button1.IconMarginRight = 0;
            this.button1.IconRightVisible = true;
            this.button1.IconRightZoom = 0D;
            this.button1.IconVisible = true;
            this.button1.IconZoom = 40D;
            this.button1.IsTab = false;
            this.button1.Location = new System.Drawing.Point(538, 594);
            this.button1.Name = "button1";
            this.button1.Normalcolor = System.Drawing.Color.DarkGreen;
            this.button1.OnHovercolor = System.Drawing.Color.Transparent;
            this.button1.OnHoverTextColor = System.Drawing.Color.White;
            this.button1.selected = false;
            this.button1.Size = new System.Drawing.Size(199, 48);
            this.button1.TabIndex = 22;
            this.button1.Text = "      SINCRONIZAR";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Textcolor = System.Drawing.Color.White;
            this.button1.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(41)))), ((int)(((byte)(61)))));
            this.AnimacionSidebar.SetDecoration(this.flowLayoutPanel1, AnimatorNS.DecorationType.None);
            this.AnimacionSidebarBack.SetDecoration(this.flowLayoutPanel1, AnimatorNS.DecorationType.None);
            this.flowLayoutPanel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.flowLayoutPanel1.ForeColor = System.Drawing.Color.DarkBlue;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(279, 73);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(455, 512);
            this.flowLayoutPanel1.TabIndex = 21;
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.checkedListBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(41)))), ((int)(((byte)(61)))));
            this.checkedListBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.checkedListBox1.CheckOnClick = true;
            this.AnimacionSidebar.SetDecoration(this.checkedListBox1, AnimatorNS.DecorationType.None);
            this.AnimacionSidebarBack.SetDecoration(this.checkedListBox1, AnimatorNS.DecorationType.None);
            this.checkedListBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkedListBox1.ForeColor = System.Drawing.SystemColors.Window;
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.HorizontalScrollbar = true;
            this.checkedListBox1.Location = new System.Drawing.Point(24, 72);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(238, 512);
            this.checkedListBox1.TabIndex = 18;
            this.checkedListBox1.ThreeDCheckBoxes = true;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.AnimacionSidebarBack.SetDecoration(this.label11, AnimatorNS.DecorationType.None);
            this.AnimacionSidebar.SetDecoration(this.label11, AnimatorNS.DecorationType.None);
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.Window;
            this.label11.Location = new System.Drawing.Point(28, 20);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(58, 20);
            this.label11.TabIndex = 17;
            this.label11.Text = "Libros";
            // 
            // descarga
            // 
            this.descarga.Controls.Add(this.Wrapper);
            this.descarga.Controls.Add(this.SidebarWrapper);
            this.AnimacionSidebar.SetDecoration(this.descarga, AnimatorNS.DecorationType.None);
            this.AnimacionSidebarBack.SetDecoration(this.descarga, AnimatorNS.DecorationType.None);
            this.descarga.Dock = System.Windows.Forms.DockStyle.Fill;
            this.descarga.Location = new System.Drawing.Point(0, 0);
            this.descarga.Name = "descarga";
            this.descarga.Size = new System.Drawing.Size(1033, 694);
            this.descarga.TabIndex = 8;
            // 
            // login
            // 
            this.login.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.login.Controls.Add(this.panel1);
            this.AnimacionSidebar.SetDecoration(this.login, AnimatorNS.DecorationType.None);
            this.AnimacionSidebarBack.SetDecoration(this.login, AnimatorNS.DecorationType.None);
            this.login.Dock = System.Windows.Forms.DockStyle.Fill;
            this.login.Location = new System.Drawing.Point(0, 0);
            this.login.Name = "login";
            this.login.Size = new System.Drawing.Size(1033, 694);
            this.login.TabIndex = 9;
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(41)))), ((int)(((byte)(61)))));
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.linkLabel1);
            this.panel1.Controls.Add(this.ingresar);
            this.panel1.Controls.Add(this.password);
            this.panel1.Controls.Add(this.usuario);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.label12);
            this.AnimacionSidebar.SetDecoration(this.panel1, AnimatorNS.DecorationType.None);
            this.AnimacionSidebarBack.SetDecoration(this.panel1, AnimatorNS.DecorationType.None);
            this.panel1.Location = new System.Drawing.Point(290, 82);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(453, 530);
            this.panel1.TabIndex = 17;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.AnimacionSidebarBack.SetDecoration(this.pictureBox2, AnimatorNS.DecorationType.None);
            this.AnimacionSidebar.SetDecoration(this.pictureBox2, AnimatorNS.DecorationType.None);
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(56, 68);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(347, 103);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 11;
            this.pictureBox2.TabStop = false;
            // 
            // linkLabel1
            // 
            this.linkLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.linkLabel1.AutoSize = true;
            this.AnimacionSidebarBack.SetDecoration(this.linkLabel1, AnimatorNS.DecorationType.None);
            this.AnimacionSidebar.SetDecoration(this.linkLabel1, AnimatorNS.DecorationType.None);
            this.linkLabel1.LinkColor = System.Drawing.Color.White;
            this.linkLabel1.Location = new System.Drawing.Point(160, 395);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(139, 13);
            this.linkLabel1.TabIndex = 16;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "He olvidado mi contraseña?";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkLabel1_LinkClicked);
            // 
            // ingresar
            // 
            this.ingresar.ActiveBorderThickness = 1;
            this.ingresar.ActiveCornerRadius = 20;
            this.ingresar.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.ingresar.ActiveForecolor = System.Drawing.SystemColors.Window;
            this.ingresar.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.ingresar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.ingresar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(41)))), ((int)(((byte)(61)))));
            this.ingresar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ingresar.BackgroundImage")));
            this.ingresar.ButtonText = "Ingresar";
            this.ingresar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AnimacionSidebar.SetDecoration(this.ingresar, AnimatorNS.DecorationType.None);
            this.AnimacionSidebarBack.SetDecoration(this.ingresar, AnimatorNS.DecorationType.None);
            this.ingresar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ingresar.ForeColor = System.Drawing.Color.SeaGreen;
            this.ingresar.IdleBorderThickness = 1;
            this.ingresar.IdleCornerRadius = 20;
            this.ingresar.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.ingresar.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.ingresar.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.ingresar.Location = new System.Drawing.Point(30, 430);
            this.ingresar.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.ingresar.Name = "ingresar";
            this.ingresar.Size = new System.Drawing.Size(399, 41);
            this.ingresar.TabIndex = 7;
            this.ingresar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ingresar.Click += new System.EventHandler(this.ingresar_Click);
            // 
            // password
            // 
            this.password.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.password.BorderColorFocused = System.Drawing.Color.DodgerBlue;
            this.password.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.password.BorderColorMouseHover = System.Drawing.Color.DodgerBlue;
            this.password.BorderThickness = 3;
            this.password.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.AnimacionSidebarBack.SetDecoration(this.password, AnimatorNS.DecorationType.None);
            this.AnimacionSidebar.SetDecoration(this.password, AnimatorNS.DecorationType.None);
            this.password.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.password.ForeColor = System.Drawing.Color.White;
            this.password.isPassword = true;
            this.password.Location = new System.Drawing.Point(57, 334);
            this.password.Margin = new System.Windows.Forms.Padding(4);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(345, 39);
            this.password.TabIndex = 14;
            this.password.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // usuario
            // 
            this.usuario.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.usuario.BorderColorFocused = System.Drawing.Color.DodgerBlue;
            this.usuario.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.usuario.BorderColorMouseHover = System.Drawing.Color.DodgerBlue;
            this.usuario.BorderThickness = 3;
            this.usuario.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.AnimacionSidebarBack.SetDecoration(this.usuario, AnimatorNS.DecorationType.None);
            this.AnimacionSidebar.SetDecoration(this.usuario, AnimatorNS.DecorationType.None);
            this.usuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.usuario.ForeColor = System.Drawing.Color.White;
            this.usuario.isPassword = false;
            this.usuario.Location = new System.Drawing.Point(57, 233);
            this.usuario.Margin = new System.Windows.Forms.Padding(4);
            this.usuario.Name = "usuario";
            this.usuario.Size = new System.Drawing.Size(345, 39);
            this.usuario.TabIndex = 13;
            this.usuario.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label13
            // 
            this.label13.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label13.AutoSize = true;
            this.AnimacionSidebarBack.SetDecoration(this.label13, AnimatorNS.DecorationType.None);
            this.AnimacionSidebar.SetDecoration(this.label13, AnimatorNS.DecorationType.None);
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.SystemColors.Window;
            this.label13.Location = new System.Drawing.Point(196, 193);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(67, 18);
            this.label13.TabIndex = 9;
            this.label13.Text = "Usuario";
            // 
            // label12
            // 
            this.label12.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label12.AutoSize = true;
            this.AnimacionSidebarBack.SetDecoration(this.label12, AnimatorNS.DecorationType.None);
            this.AnimacionSidebar.SetDecoration(this.label12, AnimatorNS.DecorationType.None);
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.SystemColors.Window;
            this.label12.Location = new System.Drawing.Point(182, 294);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(95, 18);
            this.label12.TabIndex = 10;
            this.label12.Text = "Contraseña";
            // 
            // AnimacionSidebar
            // 
            this.AnimacionSidebar.AnimationType = AnimatorNS.AnimationType.HorizBlind;
            this.AnimacionSidebar.Cursor = null;
            animation6.AnimateOnlyDifferences = true;
            animation6.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation6.BlindCoeff")));
            animation6.LeafCoeff = 0F;
            animation6.MaxTime = 1F;
            animation6.MinTime = 0F;
            animation6.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation6.MosaicCoeff")));
            animation6.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation6.MosaicShift")));
            animation6.MosaicSize = 0;
            animation6.Padding = new System.Windows.Forms.Padding(0);
            animation6.RotateCoeff = 0F;
            animation6.RotateLimit = 0F;
            animation6.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation6.ScaleCoeff")));
            animation6.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation6.SlideCoeff")));
            animation6.TimeCoeff = 0F;
            animation6.TransparencyCoeff = 0F;
            this.AnimacionSidebar.DefaultAnimation = animation6;
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 50;
            this.bunifuElipse1.TargetControl = this.panel1;
            // 
            // bunifuElipse2
            // 
            this.bunifuElipse2.ElipseRadius = 20;
            this.bunifuElipse2.TargetControl = this.Sidebar;
            // 
            // bunifuElipse3
            // 
            this.bunifuElipse3.ElipseRadius = 20;
            this.bunifuElipse3.TargetControl = this.libro;
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1033, 694);
            this.Controls.Add(this.descarga);
            this.Controls.Add(this.login);
            this.AnimacionSidebarBack.SetDecoration(this, AnimatorNS.DecorationType.None);
            this.AnimacionSidebar.SetDecoration(this, AnimatorNS.DecorationType.None);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Principal";
            this.SidebarWrapper.ResumeLayout(false);
            this.Sidebar.ResumeLayout(false);
            this.guiaSubMenu.ResumeLayout(false);
            this.cuadernoSubMenu.ResumeLayout(false);
            this.libroSubMenu.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            this.panelLogo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.Wrapper.ResumeLayout(false);
            this.libro.ResumeLayout(false);
            this.libro.PerformLayout();
            this.descarga.ResumeLayout(false);
            this.login.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private AnimatorNS.Animator AnimacionSidebarBack;
        private AnimatorNS.Animator AnimacionSidebar;
        private System.Windows.Forms.Panel SidebarWrapper;
        private Bunifu.Framework.UI.BunifuGradientPanel Sidebar;
        private System.Windows.Forms.Panel Wrapper;
        private System.Windows.Forms.Label logo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel libro;
        public System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private Bunifu.Framework.UI.BunifuFlatButton button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel descarga;
        private System.Windows.Forms.Panel login;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private Bunifu.Framework.UI.BunifuMetroTextbox password;
        private Bunifu.Framework.UI.BunifuMetroTextbox usuario;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        public Bunifu.Framework.UI.BunifuThinButton2 ingresar;
        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Label label11;
        private Bunifu.Framework.UI.BunifuSeparator LineaSidebar;
        private System.Windows.Forms.Button btnPlanificaciones;
        private System.Windows.Forms.Button btnMaterial;
        private System.Windows.Forms.Button btnPlanlector;
        private System.Windows.Forms.Panel guiaSubMenu;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.Button btnGuias;
        private System.Windows.Forms.Panel cuadernoSubMenu;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button btnCuaderno;
        private System.Windows.Forms.Panel libroSubMenu;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnLibro;
        private System.Windows.Forms.Panel panelLogo;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse2;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse3;
        private System.Windows.Forms.CheckBox check;
    }
}