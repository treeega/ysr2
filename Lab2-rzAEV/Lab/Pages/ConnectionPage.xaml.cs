using Lab.Method;
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

namespace Lab.Pages
{
    /// <summary>
    /// Логика взаимодействия для SettingCon.xaml
    /// </summary>
    public partial class ConnectionPage:Page
    {

        ConnectionSetting con;
        public ConnectionPage()
        {
            InitializeComponent();
            con = new ConnectionSetting();
            GetDataProperties();
        }

        //Кнопка ПРОВЕРКА СОЕДИНЕНИЯ
        private void ButtonCheckConnection_Click(object sender, RoutedEventArgs e)
        {
            System.Windows.MessageBox.Show("Стату соединения: " + CheckConnection().ToString());
        }

        //Проверка связь с сервером
        public bool CheckConnection()
        {
            bool integratesecur = false;
            if (ComboBoxTypeConnection.SelectedIndex == 0)
                integratesecur = true;

            return con.CheckConnection(TextBoxServer.Text, TextBoxDataBase.Text, integratesecur, TextBoxLogin.Text, TextBoxPassword.Text);
        }

        //Видимость логина и пароля( в зависимости от типа проверки безопасни)
        private void ComboBoxTypeConnection_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (LoginPassword != null)
            {
                if (ComboBoxTypeConnection.SelectedIndex == 1)
                {
                    LoginPassword.Visibility = Visibility.Visible;
                }
                if (ComboBoxTypeConnection.SelectedIndex == 0)
                {
                    LoginPassword.Visibility = Visibility.Collapsed;
                }
            }
        }

        //получить текущую строку подключения
        public void GetDataProperties()
        {
            con.GetConnection();
            TextBoxServer.Text = con.ServerName;
            TextBoxDataBase.Text = con.CatalogName;
            TextBoxLogin.Text = con.Login;
            TextBoxPassword.Text = con.Password;
            if (con.IntegratedSecurity)
                ComboBoxTypeConnection.SelectedIndex = 0;
        }

        //Кнопка СОЕДИНИТЬ
        private void ButtonCreatConnection_Click(object sender, RoutedEventArgs e)
        {
            bool integratesecur = false;
            if (ComboBoxTypeConnection.SelectedIndex == 0)
                integratesecur = true;
            if (CheckConnection())
            {
                con.SetConnection(TextBoxServer.Text, TextBoxDataBase.Text, integratesecur, TextBoxLogin.Text, TextBoxPassword.Text);
                System.Windows.MessageBox.Show("Новое соединение установлено");
               
            }
            else
            {
                System.Windows.MessageBox.Show("Стату соединения: " + CheckConnection().ToString());
             
            }
        }

        ////Обновление шрифтов
        //public void UpdateFont()
        //{
        //    FontEditor fontEditor = new FontEditor(this);
        //    fontEditor.Open();
        //}

        //private void Page_Loaded(object sender, RoutedEventArgs e)
        //{
        //    UpdateFont();
        //}
    }
}
