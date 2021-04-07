﻿using System;
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

namespace TelegramWPF
{
    /// <summary>
    /// Interaction logic for UserControl1.xaml
    /// </summary>
    public partial class UserControl1 : UserControl
    {
        public UserControl1()
        {
            InitializeComponent();
        }
        public string NameLabel
        {
            get { return NameLbl.Content.ToString(); }
            set { NameLbl.Content = value; }
        }
        public string MessageLabel
        {
            get { return MessageLbl.Content.ToString(); }
            set { MessageLbl.Content = value; }
        }
        public ImageSource image
        {
            get { return ImageBox.ImageSource; }
            set { ImageBox.ImageSource = value; }
        }
    }
}
