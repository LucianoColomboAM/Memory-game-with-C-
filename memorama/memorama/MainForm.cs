/*
 * Created by SharpDevelop.
 * User: Luciano
 * Date: 13/8/2018
 * Time: 11:31
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace memorama
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
		
		void Button5Click(object sender, EventArgs e)
		{
			Form1Prueba frm= new Form1Prueba();
			frm.Show();
		}
		
		
		void Button4Click(object sender, EventArgs e)
		{
			_4x4 frm1= new _4x4();
			frm1.Show();
		}
		
		void Button3Click(object sender, EventArgs e)
		{
			_6x6 frm2=new _6x6();
			frm2.Show();
		}
		
		
		
		void Button2Click(object sender, EventArgs e)
		{
			Form2Jugadores frm3= new Form2Jugadores();
			frm3.Show();
		}
	}
	
	
}
