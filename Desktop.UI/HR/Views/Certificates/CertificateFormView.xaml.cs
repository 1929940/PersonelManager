﻿using CommunicationAndCommonsLibrary.Core.Bufor;
using CommunicationAndCommonsLibrary.HR.Models;
using CommunicationAndCommonsLibrary.HR.Requests;
using Desktop.UI.Core.Helpers;
using Desktop.UI.HR.Views.Employees;
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
using System.Windows.Shapes;

namespace Desktop.UI.HR.Views.Certificates {
    public partial class CertificateFormView : Window {

        public bool EditMode { get; set; }
        public PersonelDocument Document { get; set; }
        public Bufor<PersonelDocument> Bufor { get; set; }
        public bool UseBufor { get => Bufor != null; }

        private readonly CertificateRequestHandler _handler;

        public CertificateFormView(out PersonelDocument doc, Bufor<PersonelDocument> bufor = null) {
            _handler = new CertificateRequestHandler();
            Bufor = bufor;

            InitializeComponent();
            InitHeader();
            SetDataContext();
            BindCombobox();
            MetadataHelper.Init(this, EditMode, Document);
            doc = Document;
        }

        public CertificateFormView(PersonelDocument doc, Bufor<PersonelDocument> bufor = null) {
            Bufor = bufor;
            EditMode = true;
            _handler = new CertificateRequestHandler();

            InitializeComponent();
            InitHeader();
            SetDataContext(doc);
            BindCombobox();
            MetadataHelper.Init(this, EditMode, Document);
        }


        private void InitHeader() {
            if (EditMode) {
                HeaderText.Text = "Modyfikuj Certyfikat";
            } else {
                HeaderText.Text = "Dodaj Certyfikat";
            }
        }

        private async void SaveButton_Click(object sender, RoutedEventArgs e) {
            if (ControlsHelper.AreTextboxesValid(this)) {
                if (EditMode) {
                    if (UseBufor)
                        Bufor.TransactionBufor.Modify(Document);
                    else if (DialogHelper.Save())
                        await _handler.UpdateAsync(Document.Id, Document);
                } else {
                    if (UseBufor)
                        Bufor.TransactionBufor.Add(Document);
                    else if (DialogHelper.Save())
                        await _handler.CreateAsync(Document);
                }
                this.Close();
            }
        }


        private void Close_Click(object sender, RoutedEventArgs e) {
            if (DialogHelper.Close())
                this.Close();
        }

        private void EmployeeCombobox_SelectionChanged(object sender, SelectionChangedEventArgs e) {
            Document.Employee.Id = (int)EmployeeCombobox.SelectedValue;
        }

        private void BindCombobox() {
            if (UseBufor) {
                HideEmployeeControls();
                ExpandNumberControls();
            } else if (EditMode) {
                EmployeeCombobox.IsEnabled = false;
                EmployeeCombobox.ItemsSource = ViewHelper.ConvertToDictionary(Document.Employee);
                EmployeeCombobox.SelectedIndex = 0;
            } else {
                EmployeeCombobox.ItemsSource = new EmployeeRequestHandler().GetEmployeesDictionary();
                EmployeeCombobox.SelectedIndex = ViewHelper.GetIndexOfComboboxValue(Document.Employee.Id, EmployeeCombobox);
            }
        }

        private void HideEmployeeControls() {
            EmployeeLabel.Visibility = Visibility.Collapsed;
            EmployeeCombobox.Visibility = Visibility.Collapsed;
        }
        private void ExpandNumberControls() {
            NumberTextBox.Width = 334;
            NumberLabel.Width = 60;
        }

        private void SetDataContext(PersonelDocument doc = null) {
            if (doc == null)
                Document = new PersonelDocument();
            else if (UseBufor)
                Document = doc;
            else
                Document = _handler.Get(doc.Id);
            this.DataContext = Document;
        }
    }
}
