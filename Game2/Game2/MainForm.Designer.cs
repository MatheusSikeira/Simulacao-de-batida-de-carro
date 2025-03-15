/*
 * Created by SharpDevelop.
 * User: aluno
 * Date: 10/10/2024
 * Time: 20:59
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Game2
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.PictureBox picbox_estrada;
		private System.Windows.Forms.PictureBox picbox_arvore;
		private System.Windows.Forms.PictureBox picbox_carrinho;
		private System.Windows.Forms.Timer Timer1;
		private System.Windows.Forms.Button button1;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.picbox_estrada = new System.Windows.Forms.PictureBox();
			this.picbox_arvore = new System.Windows.Forms.PictureBox();
			this.picbox_carrinho = new System.Windows.Forms.PictureBox();
			this.Timer1 = new System.Windows.Forms.Timer(this.components);
			this.button1 = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.picbox_estrada)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.picbox_arvore)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.picbox_carrinho)).BeginInit();
			this.SuspendLayout();
			// 
			// pictureBox1
			// 
			this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
			this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
			this.pictureBox1.Location = new System.Drawing.Point(0, 0);
			this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(1075, 290);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox1.TabIndex = 0;
			this.pictureBox1.TabStop = false;
			// 
			// picbox_estrada
			// 
			this.picbox_estrada.BackColor = System.Drawing.Color.Transparent;
			this.picbox_estrada.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picbox_estrada.BackgroundImage")));
			this.picbox_estrada.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.picbox_estrada.InitialImage = ((System.Drawing.Image)(resources.GetObject("picbox_estrada.InitialImage")));
			this.picbox_estrada.Location = new System.Drawing.Point(0, 256);
			this.picbox_estrada.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.picbox_estrada.Name = "picbox_estrada";
			this.picbox_estrada.Size = new System.Drawing.Size(1075, 69);
			this.picbox_estrada.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.picbox_estrada.TabIndex = 1;
			this.picbox_estrada.TabStop = false;
			// 
			// picbox_arvore
			// 
			this.picbox_arvore.Image = ((System.Drawing.Image)(resources.GetObject("picbox_arvore.Image")));
			this.picbox_arvore.Location = new System.Drawing.Point(759, 256);
			this.picbox_arvore.Name = "picbox_arvore";
			this.picbox_arvore.Size = new System.Drawing.Size(100, 50);
			this.picbox_arvore.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.picbox_arvore.TabIndex = 3;
			this.picbox_arvore.TabStop = false;
			// 
			// picbox_carrinho
			// 
			this.picbox_carrinho.BackColor = System.Drawing.Color.Transparent;
			this.picbox_carrinho.Image = ((System.Drawing.Image)(resources.GetObject("picbox_carrinho.Image")));
			this.picbox_carrinho.Location = new System.Drawing.Point(12, 235);
			this.picbox_carrinho.Name = "picbox_carrinho";
			this.picbox_carrinho.Size = new System.Drawing.Size(158, 75);
			this.picbox_carrinho.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.picbox_carrinho.TabIndex = 4;
			this.picbox_carrinho.TabStop = false;
			// 
			// Timer1
			// 
			this.Timer1.Interval = 25;
			this.Timer1.Tick += new System.EventHandler(this.Timer1Tick);
			// 
			// button1
			// 
			this.button1.BackColor = System.Drawing.Color.Transparent;
			this.button1.Location = new System.Drawing.Point(135, 23);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(98, 47);
			this.button1.TabIndex = 5;
			this.button1.Text = "Iniciar";
			this.button1.UseVisualStyleBackColor = false;
			this.button1.Click += new System.EventHandler(this.Button1Click);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.LightSkyBlue;
			this.ClientSize = new System.Drawing.Size(1071, 322);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.picbox_carrinho);
			this.Controls.Add(this.picbox_arvore);
			this.Controls.Add(this.picbox_estrada);
			this.Controls.Add(this.pictureBox1);
			this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.Name = "MainForm";
			this.Text = "Game2";
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.picbox_estrada)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.picbox_arvore)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.picbox_carrinho)).EndInit();
			this.ResumeLayout(false);

		}
	}
}
