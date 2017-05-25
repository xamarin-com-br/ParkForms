using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ParkApp.Telas
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MasterMenuMaster : ContentPage
    {
        public ListView ListView;

        public MasterMenuMaster()
        {
            InitializeComponent();

            BindingContext = new MasterMenuMasterViewModel();
            ListView = MenuItemsListView;
        }

        class MasterMenuMasterViewModel : INotifyPropertyChanged
        {
            public ObservableCollection<MasterMenuMenuItem> MenuItems { get; set; }

            public MasterMenuMasterViewModel()
            {
                MenuItems = new ObservableCollection<MasterMenuMenuItem>(new[]
                {
                    new MasterMenuMenuItem { Id = 0, Title = "Home",TargetType = new MenuInicial().GetType(),Foto ="icon.png" },
                    new MasterMenuMenuItem { Id = 1, Title = "Login",TargetType = new Login().GetType(),Foto="contacts.png"},
                    new MasterMenuMenuItem { Id = 2, Title ="Usuário",TargetType = new CadastroUsuarioXAML().GetType() },
                    new MasterMenuMenuItem { Id = 3, Title = "Vagas",TargetType = new CadastroDeVagas().GetType() },
                    
                });
            }

            #region INotifyPropertyChanged Implementation
            public event PropertyChangedEventHandler PropertyChanged;
            void OnPropertyChanged([CallerMemberName] string propertyName = "")
            {
                if (PropertyChanged == null)
                    return;

                PropertyChanged.Invoke(this, new PropertyChangedEventArgs(propertyName));
            }
            #endregion
        }
    }
}