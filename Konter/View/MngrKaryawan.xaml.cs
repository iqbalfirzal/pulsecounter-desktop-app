using System;
using System.Windows;
using System.Windows.Controls;

namespace Konter
{
    /// <summary>
    /// Interaction logic for MngrKaryawan.xaml
    /// </summary>
    public partial class MngrKaryawan : UserControl
    {
        //objek class controller
        Controller.MngrKaryawanController control;
        // deklarasi variabel tambahan
        private bool hasil;
        public MngrKaryawan()
        {
            InitializeComponent();
            control = new Controller.MngrKaryawanController(this);
            TampilData();
        }

        // fungsi untuk menampilkan data
        public void TampilData()
        {
            dtgKaryawan.IsEnabled = true;
            control.SelectMngrKaryawan();
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
            txtKodeKaryawan.Clear();
            txtUsername.Clear();
            txtPassword.Clear();
            txtNama.Clear();
            txtTanggalLahir.Clear();
            txtTempatLahir.Clear();
            txtAlamat.Clear();
            txtNomorHP.Clear();
            txtGaji.Clear();
            lblIntruction.Visibility = Visibility.Hidden;
        }

        //fungsi set nilai radiobutton
        public void SetRadioButtonValue()
        {
            if (rdbLaki.IsChecked == true)
            {
                txtGender.Text = "L";
            }
            else
            {
                txtGender.Text = "P";
            }
        }
        // fungsi menambahkan data
        public void TambahData()
        {
            SetRadioButtonValue();
            hasil = control.InsertMngrKaryawan();
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
            SetRadioButtonValue();
            hasil = control.UpdateMngrKaryawan();
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
            if (txtKodeKaryawan.Text == "" || txtUsername.Text == "" || txtPassword.Text == "" || txtNama.Text == "" || txtGaji.Text == "")
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
            hasil = control.DeleteMngrKaryawan();
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

        private void btnTambahKaryawan_Click(object sender, RoutedEventArgs e)
        {
            AturText(true);
            btnDelete.IsEnabled = false;
            btnCancel.IsEnabled = true;
            btnUpdate.IsEnabled = false;
            btnSimpan.IsEnabled = true;
            dtgKaryawan.IsEnabled = false;
            ResetForm();
        }
        public void AturText(Boolean status)
        {
            txtKodeKaryawan.IsEnabled = status;
            txtUsername.IsEnabled = status;
            txtPassword.IsEnabled = status;
            txtNama.IsEnabled = status;
            rdbLaki.IsEnabled = status;
            rdbWanita.IsEnabled = status;
            txtTempatLahir.IsEnabled = status;
            txtTanggalLahir.IsEnabled = status;
            txtAlamat.IsEnabled = status;
            txtNomorHP.IsEnabled = status;
            txtGaji.IsEnabled = status;
        }

        private void btnUpdate_Click(object sender, RoutedEventArgs e)
        {
            if (txtKodeKaryawan.Text == "" || txtUsername.Text == "" || txtPassword.Text == "" || txtNama.Text == "" || txtTempatLahir.Text == "" || txtTempatLahir.Text == "" || txtNomorHP.Text == "" || txtAlamat.Text == "" || txtGaji.Text == "" )
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
        private void btnUbahKaryawan_Click(object sender, RoutedEventArgs e)
        {
            lblIntruction.Visibility = Visibility.Visible;
            AturText(true);
            dtgKaryawan.IsEnabled = true;
            btnDelete.IsEnabled = false;
            btnCancel.IsEnabled = true;
            btnUpdate.IsEnabled = true;
            btnSimpan.IsEnabled = false;
        }
    }
}
