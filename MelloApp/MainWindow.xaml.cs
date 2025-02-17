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

namespace MelloApp;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{

    int antalRöd = 0;
    int antalBlå = 0;
    int antalGrön = 0;
    int antalGul = 0;
    int antalLila = 0;

    public MainWindow()
    {
        InitializeComponent();
    }
    
    private void KlickRösta(object sender, RoutedEventArgs e)
    {
        
        //Vem klickade

        if (sender == Röd)
        {
            antalRöd++;

        }
        else if(sender == Blå)
        {
            antalBlå++;
        }
        else if(sender == Grön)
        {
            antalGrön++;
        }
        else if(sender == Gul)
        {
            antalGul++;
        }
        else if(sender == Lila)
        {
            antalLila++;
        }
        else if(sender == Rensa)
        {
            antalRöd = 0;
            antalBlå = 0;
            antalGrön = 0;
            antalGul = 0;
            antalLila = 0;

        }
        
        txbResultat.Text = $"Röd: {antalRöd} | Blå: {antalBlå} | Grön: {antalGrön} | Gul: {antalGul} | Lila: {antalLila}";
    }
}