﻿using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace brännbollapp;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{


    // Skapa variablerna för
    int poängInne = 0;
    int poängUte = 0;


    public MainWindow()
    {
        InitializeComponent();
    }

    private void klickFrivarv(object sender, RoutedEventArgs e)
    {
        
        poängInne +=5;

        // Skriv ut poången
        txbInne.Text = $"{poängInne}";
        

    }

}