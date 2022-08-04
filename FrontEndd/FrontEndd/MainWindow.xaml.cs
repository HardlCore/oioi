using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;


namespace FrontEndd
{
    /// <summary>
    /// Interação lógica para MainWindow.xam
    /// </summary>
    /// 
    
    public partial class MainWindow : Window
    {
        bool click = true;
        int op = 0;



        public MainWindow()
        {
            InitializeComponent();

        }

        public object Telas { get; private set; }

        private void Alterar(object sender, SelectionChangedEventArgs e)
            


        {

            op = Esconder.SelectedIndex;
            if (op >= 0) ;
            switch (op)
            {
                case 0:
                    Telas.Children.Clear();
                    Telas.Children.Add(new Tela());

                    break; 
            }
                

                


        }
       




          

        
    }
       
    }

