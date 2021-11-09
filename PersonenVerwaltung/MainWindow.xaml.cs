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

namespace PersonenVerwaltung
{
    /// <summary>
    /// Interaktionslogik für MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<Person> people = new List<Person>();
        public MainWindow()
        {
            InitializeComponent();
            Person pers = new Person(1,"Wehner","Tobias","09092000","Männlich","Schmiedewinkel 8",8,"51580","DE","0123456789","0123456789","tobias@wehner.de");
            List<Person> tmpList =new List<Person>();
            people.Add(pers);

            RefreshDataGrid();
        }
        private void datagrid1_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (datagrid1.SelectedIndex >= 0)
            {
                Person tmpPers = (Person)datagrid1.Items[datagrid1.SelectedIndex];
                textbox1.Text = tmpPers.Name;
                textbox2.Text = tmpPers.Vorname;
                textbox3.Text = tmpPers.Geburtstag;
                combobox1.SelectedIndex = WhatGender(tmpPers.Geschlecht);
                textbox4.Text = tmpPers.Straße;
                textbox5.Text = "" + tmpPers.Hausnummer;
                textbox6.Text = tmpPers.PLZ;
                textbox7.Text = tmpPers.Land;
                textbox8.Text = tmpPers.Tel;
                textbox9.Text = tmpPers.Mobil;
                textbox10.Text = tmpPers.EMail;
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)//Hinzufügen
        {
            Person tmpPers = new Person(people.Count + 1, textbox1.Text, textbox2.Text, textbox3.Text, combobox1.Text, textbox4.Text, 8, textbox6.Text, textbox7.Text, textbox8.Text, textbox9.Text, textbox10.Text);
            people.Add(tmpPers);
            RefreshDataGrid();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)//Ändern
        {
            if (datagrid1.SelectedIndex >= 0)
            {
                people[datagrid1.SelectedIndex].Name = textbox1.Text;
                people[datagrid1.SelectedIndex].Vorname = textbox2.Text;
                people[datagrid1.SelectedIndex].Geburtstag = textbox3.Text;
                people[datagrid1.SelectedIndex].Geschlecht = combobox1.Text;
                people[datagrid1.SelectedIndex].Straße = textbox4.Text;
                people[datagrid1.SelectedIndex].Hausnummer = int.Parse(textbox5.Text);
                people[datagrid1.SelectedIndex].PLZ = textbox6.Text;
                people[datagrid1.SelectedIndex].Land = textbox7.Text;
                people[datagrid1.SelectedIndex].Tel = textbox8.Text;
                people[datagrid1.SelectedIndex].Mobil = textbox9.Text;
                people[datagrid1.SelectedIndex].EMail = textbox10.Text;
            }
            RefreshDataGrid();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)//Löschen
        {
            if(datagrid1.SelectedIndex >= 0)
            {
                people.RemoveAt(datagrid1.SelectedIndex);
            }
            RefreshDataGrid();
        }

        private void RefreshDataGrid()
        {
            datagrid1.ItemsSource = null;
            datagrid1.ItemsSource = people;
        }

        private int WhatGender(string Geschlecht)
        {
            int gender = 0;
            
            if(Geschlecht == "Diverse")
            {
                gender = 0;
            }
            else if(Geschlecht == "Männlich")
            {
                gender = 1;
            }
            else if (Geschlecht == "Weiblich")
            {
                gender = 2;
            }
            else
            {
                gender = 0;
            }
            return gender;
        }
    }
}
