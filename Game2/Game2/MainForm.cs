
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Game2
{
	public partial class MainForm : Form
	{
		public MainForm()
		{
			InitializeComponent();
			//carrinho
			picbox_carrinho.Parent = picbox_estrada;
			picbox_carrinho.Left = 0;
			picbox_carrinho.Top = -20;
			picbox_carrinho.BackColor = Color.Transparent;
			Timer1.Interval = 25;
			
			//arvore
			picbox_arvore.Parent = picbox_estrada;
			picbox_arvore.Left = 670;
			picbox_arvore.Top = 2;
			picbox_arvore.BackColor = Color.Transparent;
		}
		void Button1Click(object sender, EventArgs e)
		{
			picbox_carrinho.Left = 0;
			picbox_carrinho.Load("Lamborghini2.png");
			Timer1.Enabled = true;
		}
		void Timer1Tick(object sender, EventArgs e)
		{
			picbox_carrinho.Left += 10;
			if(picbox_carrinho.Left >= 900)
				Timer1.Enabled = false;
			
			//teste de colisão
			if(picbox_carrinho.Bounds.IntersectsWith(picbox_arvore.Bounds))
			{
				Timer1.Enabled = false;
				picbox_carrinho.Load("carroAmassado2.png");
				picbox_carrinho.Left -= 5;
				
				MessageBox.Show("Colisão");
			}
		}
	}
}
