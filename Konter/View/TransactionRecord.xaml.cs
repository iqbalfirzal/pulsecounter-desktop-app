using System.Windows;
using System.Text.RegularExpressions;

namespace Konter
{
    /// <summary>
    /// Interaction logic for TransactionRecord.xaml
    /// </summary>
    public partial class TransactionRecord : Window
    {
        //objek class controller
        Controller.TransactionRecordController control;
        // deklarasi variabel tambahan
        private bool hasil;
        private string KdKaryawan;
        public TransactionRecord()
        {
            InitializeComponent();
            this.Closing += new System.ComponentModel.CancelEventHandler(WindowBoder_Closing);
            control = new Controller.TransactionRecordController(this);
            TampilData();
        }
        public TransactionRecord(string _kdKaryawan)
        {
            this.KdKaryawan = _kdKaryawan;
            InitializeComponent();
            this.Closing += new System.ComponentModel.CancelEventHandler(WindowBoder_Closing);
            control = new Controller.TransactionRecordController(this, _kdKaryawan);
            TampilData();
        }

        void WindowBoder_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            e.Cancel = true;
        }

        // fungsi untuk menampilkan data
        public void TampilData()
        {
            lblKaryawan_GetCode.Text = this.KdKaryawan;
            control.SelectTransaction();
        }
        // fungsi menambahkan data
        public void TambahData()
        {
            hasil = control.InsertTransaction();
            if (hasil == true)
            {
                MessageBox.Show("Data berhasil disimpan");
            }
            else
            {
                MessageBox.Show("Penyimpanan data gagal");
            }
        }

        private void btnExit_Click(object sender, RoutedEventArgs e)
        {
            if (MessageBox.Show("Keluar Dari Aplikasi?", "Exit Confirmation", MessageBoxButton.OKCancel, MessageBoxImage.Warning) == MessageBoxResult.OK)
            {
                Application.Current.Shutdown();
            }             
        }

        private void btnReset_Click(object sender, RoutedEventArgs e)
        {
            txtNomor.Clear();
            cmbJenisPulsa.SelectedValue="";
        }

        private void btnDelete_Click(object sender, RoutedEventArgs e)
        {
            hasil = control.DeleteTransaction();
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

        private void btnSave_Click(object sender, RoutedEventArgs e)
        {
            if (txtNomor.Text == "" || cmbJenisPulsa.SelectedItem == null)
            {
                MessageBox.Show("Mohon isi data dengan benar");
            }
            else
            {
                TambahData();
            }
            TampilData();
        }

        private void txtNomor_PreviewTextInput(object sender, System.Windows.Input.TextCompositionEventArgs e)
        {
            Regex regex = new Regex("[^0-9]+");
            e.Handled = regex.IsMatch(e.Text);
        }

        private void btnHistory_Click(object sender, RoutedEventArgs e)
        {
            if (btnDelete.Visibility == Visibility.Hidden)
                {
                    btnHistory.Content = "Tutup Riwayat";
                    btnDelete.Visibility = Visibility.Visible;
                    dtgTransaction.IsEnabled = true;
                }
            else
                {
                    btnHistory.Content = "Lihat Riwayat";
                    btnDelete.Visibility = Visibility.Hidden;
                    dtgTransaction.IsEnabled = false;
            }
        }
    }
}