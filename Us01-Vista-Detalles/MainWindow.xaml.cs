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

namespace Us01_Vista_Detalles
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void carga(object sender, RoutedEventArgs e)
        {
            Model.VO.ClientVO client1 = new Model.VO.ClientVO("33333", "Melmac SA", "5553291", "ALF", "gondonsanwey@melmac.com");
            Model.VO.ClientVO client2 = new Model.VO.ClientVO("33311133", "Lost", "1212315", "Jonh Locke", "jonhlocke@lost.com");
            this.lstClients.Items.Add(client1);
            this.lstClients.Items.Add(client2);
            this.lstClients.Items.Add(new Model.VO.ClientVO("39192", "Todo Poderosos", "4129301", "Carlos Cansado", "cansado@todopoderosos.com"));
            this.lstClients.DisplayMemberPath = "name";
            try
            {
                this.lstClients.SelectedIndex = 0;
            }
            catch (Exception ex) { }


        }
        private void cambioseleccionado(object sender, SelectionChangedEventArgs e)
        {
            if (e.AddedItems.Count > 0)
            {

                Model.VO.ClientVO selectedClient = (Model.VO.ClientVO)e.AddedItems[0];
                this.lblCIF.Content = selectedClient.CIF;
                this.lblName.Content = selectedClient.name;
                this.lblPhone.Content = selectedClient.phone;
                this.lblContactPerson.Content = selectedClient.contactPerson;
                this.lblEmail.Content = selectedClient.email;

            }
        }
    }
}
