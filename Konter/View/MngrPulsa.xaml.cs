using System;
using System.Windows;
using System.Windows.Controls;

namespace Konter
{
    /// <summary>
    /// Interaction logic for MngrKaryawan.xaml
    /// </summary>
    public partial class MngrPulsa : UserControl
    {
        //objek class controller
        Controller.MngrPulsaController control;
        // deklarasi variabel tambahan
        private bool hasil;
        public MngrPulsa()
        {
            InitializeComponent();
            control = new Controller.MngrPulsaController(this);
            TampilData();
        }

        // fungsi untuk menampilkan data
        public void TampilData()
        {
            dtgPulsa.IsEnabled = true;
            control.SelectMngrPulsa();
            AturText(false);
            btnDelete.IsEnabled = true;
            btnCancel.IsEnabled = false;
            btnUpdate.IsEnabled = false;
            btnSimpan.IsEnabled = false;
            lblIntruction.Visibility = Visibility.Hidden;
        }

        // fungsi reset form
        public void ResetForm()
        {
            txtKodePulsa.Clear();
            txtNominal.Clear();
            txtHarga.Clear();
            txtKeterangan.Clear();
            //cmbJenisPulsa.Items.Clear();
            //cmbProvider.Items.Clear();
            lblIntruction.Visibility = Visibility.Hidden;
        }

        // fungsi menambahkan data
        public void TambahData()
        {
            hasil = control.InsertMngrPulsa();
            if (hasil == true)
            {
                MessageBox.Show("Data berhasil disimpan");
            }
            else
            {
                MessageBox.Show("Penyimpanan data gagal");
            }
        }
        // fungsi mengubah data
        public void UbahData()
        {
            hasil = control.UpdateMngrPulsa();
            if (hasil == true)
            {
                MessageBox.Show("Data berhasil diubah");
            }
            else
            {
                MessageBox.Show("Pengubahan data gagal");
            }
        }

        private void btnTambah_Click(object sender, RoutedEventArgs e)
        {
            if (txtKodePulsa.Text == "" || txtNominal.Text == "" || txtHarga.Text == "" || txtKeterangan.Text == "" || cmbJenisPulsa.SelectedItem == null || cmbProvider.SelectedItem == null)
            {
                MessageBox.Show("Mohon isi data dengan benar");
            }
            else
            {
                TambahData();
            }
            ResetForm();
            TampilData();
        }

        private void btnCancel_Click(object sender, RoutedEventArgs e)
        {
            ResetForm();
            TampilData();
        }

        private void btnDelete_Click(object sender, RoutedEventArgs e)
        {
            hasil = control.DeleteMngrPulsa();
            if (hasil == true)
            {
                MessageBox.Show("Data berhasil dihapus");
            }
            else
            {
                MessageBox.Show("Data tidak dapat dihapus");
            }
            TampilData();
        }

        private void btnTambahPulsa_Click(object sender, RoutedEventArgs e)
        {
            AturText(true);
            btnDelete.IsEnabled = false;
            btnCancel.IsEnabled = true;
            btnUpdate.IsEnabled = false;
            btnSimpan.IsEnabled = true;
            dtgPulsa.IsEnabled = false;
            ResetForm();
        }
        public void AturText(Boolean status)
        {
            txtKodePulsa.IsEnabled = status;
            txtNominal.IsEnabled = status;
            txtHarga.IsEnabled = status;
            txtKeterangan.IsEnabled = status;
            cmbJenisPulsa.IsEnabled = status;
            cmbProvider.IsEnabled = status;
        }

        private void btnUpdate_Click(object sender, RoutedEventArgs e)
        {
            if (txtGetKdPulsa.Text == "" || txtHarga.Text== "" || txtNominal.Text == "" || txtKeterangan.Text == "" ||cmbJenisPulsa.SelectedItem == null || cmbProvider.SelectedItem == null)
            {
                MessageBox.Show("Mohon isi data dengan benar");
            }
            else
            {
                UbahData();
            }
            ResetForm();
            TampilData();
        }
        private void btnUbahPulsa_Click(object sender, RoutedEventArgs e)
        {
            lblIntruction.Visibility = Visibility.Visible;
            AturText(true);
            dtgPulsa.IsEnabled = true;
            btnDelete.IsEnabled = false;
            btnCancel.IsEnabled = true;
            btnUpdate.IsEnabled = true;
            btnSimpan.IsEnabled = false;
        }
    }
}
