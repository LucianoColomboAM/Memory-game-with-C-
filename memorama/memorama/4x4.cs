/*
 * Created by SharpDevelop.
 * User: Luciano
 * Date: 6/8/2018
 * Time: 16:16
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace memorama
{
	/// <summary>
	/// Description of _4x4.
	/// </summary>
	public partial class _4x4 : Form
	{
			public class memorama{
			//esta variable es para guardar la ruta de las imagenes
			string dirImagenes= Application.StartupPath+"\\img\\";
			
			//creo la matriz que contiene las direcciones de las imagenes
			public String [,] matrizImagenes = new string[4,4];
			
			//este metodo sirve para cargar la matriz en vacio
			public void IniciarMatrizImagenes()
			{
				for (int i = 0; i < 4; i++) {
					for (int k = 0; k < 4; k++) {
						matrizImagenes[i,k] = "";
					}
				}
			}
			//este metodo usa un vector para guardar las imagenes y despues
			//pasarlas a la matriz de manera aleatoria
			public void cargarMatrizImagenes()
			{
				//crea un vector y le guardo las direcciones de las imagenes, hay 2 de cada una
				string[] vectorImagenes = { 
					dirImagenes+"1_.jpg",dirImagenes+"1_.jpg",dirImagenes+"2_.jpg",dirImagenes+"2_.jpg", 
					dirImagenes+"3_.jpg",dirImagenes+"3_.jpg",dirImagenes+"4_.jpg",dirImagenes+"4_.jpg",
					dirImagenes+"5_.jpg",dirImagenes+"5_.jpg",dirImagenes+"6_.jpg",dirImagenes+"6_.jpg",
					dirImagenes+"7_.jpg",dirImagenes+"7_.jpg",dirImagenes+"8_.jpg",dirImagenes+"8_.jpg", };
				
				//creo el objeto random
				Random rnd = new Random();
				bool continuar;
				
				//recorro el vector de imagenes e inserto la imagen en la matriz
				for (int i = 0; i < 16; i++) {
					int f,c = 0;
					
					//hago un while para iterar todas las veces que sea necesario
					//puesto que al generar una posicicion al azar puede que ya este ocupada y hay que
					//generar una nueva posicion, asi hasta encontrar una posicion vacia
					do{
						continuar = false;
						f = rnd.Next(4); //genera un numero al azar entre 0-3
						c = rnd.Next(4); //genera un numero al azar entre 0-3
						if (matrizImagenes[f,c] == ""){
							matrizImagenes[f,c] = vectorImagenes[i];
						}else{
							continuar = true;
						}
					}while(continuar);
				}
			}
		}
		//aqui termina la clase memorama
		
		
		//creo el objeto memorama
		public memorama mimemorama = new memorama();
		
		//estas variables sirven para saber cual fue el ultimo boton clickeado
		public string ultimaImagenClickeada = "";
		public Button ultimoBotonClickeado;
		public string ultimoBotonTag = "";
		
		//este metodo sirve para obtener la imagen del boton
		//se le pasa un numero entre 1 y 16 y devuelve la direccion de la imagen para ese boton
		public string ObtenerImagen(string btnTag)
		{
			if (btnTag=="1"){return  mimemorama.matrizImagenes[0,0];}
			else if (btnTag=="2"){return  mimemorama.matrizImagenes[0,1];}
			else if (btnTag=="3"){return  mimemorama.matrizImagenes[0,2];}
			else if (btnTag=="4"){return  mimemorama.matrizImagenes[0,3];}
			else if (btnTag=="5"){return  mimemorama.matrizImagenes[1,0];}
			else if (btnTag=="6"){return  mimemorama.matrizImagenes[1,1];}
			else if (btnTag=="7"){return  mimemorama.matrizImagenes[1,2];}
			else if (btnTag=="8"){return  mimemorama.matrizImagenes[1,3];}
			else if (btnTag=="9"){return  mimemorama.matrizImagenes[2,0];}
			else if (btnTag=="10"){return mimemorama.matrizImagenes[2,1];}
			else if (btnTag=="11"){return mimemorama.matrizImagenes[2,2];}
			else if (btnTag=="12"){return mimemorama.matrizImagenes[2,3];}
			else if (btnTag=="13"){return mimemorama.matrizImagenes[3,0];}
			else if (btnTag=="14"){return mimemorama.matrizImagenes[3,1];}
			else if (btnTag=="15"){return mimemorama.matrizImagenes[3,2];}
			else if (btnTag=="16"){return mimemorama.matrizImagenes[3,3];}
			else{ return "";}
		}
		
		
		//este metodo pone la imagen de fondo a todos
		//a excepcion de aquellas que ya estan volteadas y que fueron acertadas
		//para saber si esta o no acertada la imagen, se utiliza el .tag del boton
		//si el tag es cero es por que esta acertada y no se le pone la imagen de fondo
		public void LimpiarImagenes()
		{
			string dirImagenes= Application.StartupPath+"\\img\\";
			
			if (button1.Tag.ToString()!="0"){
				button1.BackgroundImage = Image.FromFile(dirImagenes+"fondo.jpg");			
			}
			if (button2.Tag.ToString()!="0"){button2.BackgroundImage  =Image.FromFile(dirImagenes+"fondo.jpg"); }
			if (button3.Tag.ToString()!="0"){button3.BackgroundImage  =Image.FromFile(dirImagenes+"fondo.jpg"); }
			if (button4.Tag.ToString()!="0"){button4.BackgroundImage  =Image.FromFile(dirImagenes+"fondo.jpg"); }
			if (button5.Tag.ToString()!="0"){button5.BackgroundImage  =Image.FromFile(dirImagenes+"fondo.jpg"); }
			if (button6.Tag.ToString()!="0"){button6.BackgroundImage  =Image.FromFile(dirImagenes+"fondo.jpg"); }
			if (button7.Tag.ToString()!="0"){button7.BackgroundImage  =Image.FromFile(dirImagenes+"fondo.jpg"); }
			if (button8.Tag.ToString()!="0"){button8.BackgroundImage  =Image.FromFile(dirImagenes+"fondo.jpg"); }
			if (button9.Tag.ToString()!="0"){button9.BackgroundImage  =Image.FromFile(dirImagenes+"fondo.jpg"); }
			if (button10.Tag.ToString()!="0"){button10.BackgroundImage =Image.FromFile(dirImagenes+"fondo.jpg"); }
			if (button11.Tag.ToString()!="0"){button11.BackgroundImage =Image.FromFile(dirImagenes+"fondo.jpg"); }
			if (button12.Tag.ToString()!="0"){button12.BackgroundImage =Image.FromFile(dirImagenes+"fondo.jpg"); }
			if (button13.Tag.ToString()!="0"){button13.BackgroundImage =Image.FromFile(dirImagenes+"fondo.jpg"); }
			if (button14.Tag.ToString()!="0"){button14.BackgroundImage =Image.FromFile(dirImagenes+"fondo.jpg"); }
			if (button15.Tag.ToString()!="0"){button15.BackgroundImage =Image.FromFile(dirImagenes+"fondo.jpg"); }
			if (button16.Tag.ToString()!="0"){button16.BackgroundImage =Image.FromFile(dirImagenes+"fondo.jpg"); }
		}
		

		public _4x4()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		void BtnIniciarClick(object sender, EventArgs e)
		{			
			mimemorama.IniciarMatrizImagenes();
			mimemorama.cargarMatrizImagenes();
			button1.Tag = "1";
			button2.Tag = "2";
			button3.Tag = "3";
			button4.Tag = "4";
			button5.Tag = "5";
			button6.Tag = "6";
			button7.Tag = "7";
			button8.Tag = "8";
			button9.Tag = "9";
			button10.Tag = "10";
			button11.Tag = "11";
			button12.Tag = "12";
			button13.Tag = "13";
			button14.Tag = "14";
			button15.Tag = "15";
			button16.Tag = "16";
			
			button1.Enabled = true;
			button2.Enabled = true;
			button3.Enabled = true;
			button4.Enabled = true;
			button5.Enabled = true;
			button6.Enabled = true;
			button7.Enabled = true;
			button8.Enabled = true;
			button9.Enabled = true;
			button10.Enabled = true;
			button11.Enabled = true;
			button12.Enabled = true;
			button13.Enabled = true;
			button14.Enabled = true;
			button15.Enabled = true;
			button16.Enabled = true;
			LimpiarImagenes();
			ultimaImagenClickeada="";
			ultimoBotonTag="";
			mtotal=0;
			cpunt1=0;
			label1.Text=("Puntos "+cpunt1);
			label3.Text=("Movimientos "+mtotal);
			btnIniciar.Text=("Reiniciar");
		
			
		}
		
		//este evento es un metodo que esta en todos los eventos "onClick" de los botones
		//es complicado de explicar, pero basicmaente al hacer click en cualquier boton, se ejecuta siempre este evento
		int mtotal=0;
		int cpunt1=0;
		void ButtonClick(object sender, EventArgs e)
		{
			mtotal=mtotal+1;
			label3.Text=("Movimientos "+mtotal);
			string dirImagenes= Application.StartupPath+"\\img\\";
			
			//esta linea puede no llegar a entenderse, pero sirve para guardar el boton en una variable
			//para luego poder usuarla, en este caso creo una variable llamada "btn" que es de la clase 
			//button y guardo el boton que se hizo click			
			Button btn = (Button)sender;
			//este es un control para evitar que la imagen sea clickeada 2 veces seguidas
			if (ultimoBotonTag != btn.Tag.ToString()){
				//obtengo la imagen que correspone a la posicion 0,1
				//MessageBox.Show(ObtenerImagen(btn.Tag.ToString()));
				btn.BackgroundImage = Image.FromFile(ObtenerImagen(btn.Tag.ToString()));
				
				if (ObtenerImagen(btn.Tag.ToString()) == ultimaImagenClickeada){
					MessageBox.Show("Acerto");//muestra un msj de acierto
					btn.Tag="0";
					ultimoBotonClickeado.Tag = "0";
					//bloquea las 2 imagenes acertadas para que no se les pueda clickear mas
					ultimoBotonClickeado.Enabled = false;					
					btn.Enabled =false;					
					ultimaImagenClickeada= "";
					cpunt1=cpunt1+1;
					label1.Text=("Puntos "+cpunt1);
					if (cpunt1==8){
					MessageBox.Show("Ganaste" +Environment.NewLine + "Si quieres seguir jugando este nivel presiona reiniciar" +Environment.NewLine + "Si quieres probar otra modalidad cierra la ventana actual");
					}
			
					
					
					//falta hacer : aqui deberia sumar un punto al jugador correspondiete
										
					LimpiarImagenes();
				}else{
					if (ultimaImagenClickeada == ""){
						ultimaImagenClickeada = ObtenerImagen(btn.Tag.ToString());//guardo la imagen para saber cual fue la ultima
					}else{
						//esto codigo es para que espere 1 seg antes de voltear las imagenes
						Application.DoEvents(); 
						System.Threading.Thread.Sleep(1000);
						
						//vuelve a poner la imagen de fondo a los 2 botones ultimos clickeados
						ultimoBotonClickeado.BackgroundImage = Image.FromFile(dirImagenes+"fondo.jpg");
						btn.BackgroundImage = Image.FromFile(dirImagenes+"fondo.jpg");
						ultimaImagenClickeada = "";
					}
				}
				
					
			}
				//guardo el boton como ultimo boton clickeado
				ultimoBotonClickeado= (Button)sender;
				ultimoBotonTag = btn.Tag.ToString();
			}
		
		
		
		
		void _4x4Load(object sender, EventArgs e)
		{
			mimemorama.IniciarMatrizImagenes();
			mimemorama.cargarMatrizImagenes();
			button1.Tag = "1";
			button2.Tag = "2";
			button3.Tag = "3";
			button4.Tag = "4";
			button5.Tag = "5";
			button6.Tag = "6";
			button7.Tag = "7";
			button8.Tag = "8";
			button9.Tag = "9";
			button10.Tag = "10";
			button11.Tag = "11";
			button12.Tag = "12";
			button13.Tag = "13";
			button14.Tag = "14";
			button15.Tag = "15";
			button16.Tag = "16";
			
			button1.Enabled = true;
			button2.Enabled = true;
			button3.Enabled = true;
			button4.Enabled = true;
			button5.Enabled = true;
			button6.Enabled = true;
			button7.Enabled = true;
			button8.Enabled = true;
			button9.Enabled = true;
			button10.Enabled = true;
			button11.Enabled = true;
			button12.Enabled = true;
			button13.Enabled = true;
			button14.Enabled = true;
			button15.Enabled = true;
			button16.Enabled = true;
			LimpiarImagenes();
			ultimaImagenClickeada="";
			ultimoBotonTag="";
			mtotal=0;
			cpunt1=0;
			label1.Text=("Puntos "+cpunt1);
			label3.Text=("Movimientos "+mtotal);
			btnIniciar.Text=("Reiniciar");	
		}
		}
	}