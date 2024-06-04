/*
 * Created by SharpDevelop.
 * User: razvan
 * Date: 6/4/2024
 * Time: 2:23 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace HeadTailCoinFlip
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		void MainFormLoad(object sender, EventArgs e)
		{
	
		}
		int i = 0;
		int couterHead = 0;
		int couterTail = 0;
		public void run()
		{
			Random r = new Random();
			int x = r.Next(0,1000);
			if(x%2==0){textBox1.Text="   TAIL   "; couterTail++;}
			else if(x%2!=0){textBox1.Text = "   HEAD   "; couterHead++;}
			else {textBox1.Text = "    ?????   ";;}
			//textBox2.Text +=textBox1.Text + " >> " + (i).ToString() + " -- h=" + couterHead.ToString() + ", t="+ couterTail.ToString()+" ;" ;
			textBox2.Text +=textBox1.Text + ">>" + (i).ToString()+": ";
			textBox3.Text = couterHead.ToString();
			textBox4.Text = couterTail.ToString();
			i++;
		}
		void Button1Click(object sender, EventArgs e)
		{
			run();
			
		}
	}
}
