using System.Windows;
using System.Windows.Controls;

namespace Konter
{
    /// <summary>
    /// Interaction logic for MngrLaporan.xaml
    /// </summary>
    public partial class MngrLaporan : UserControl
    {
        //objek class controller
        Controller.MngrLaporanController control;
        // deklarasi variabel tambahan
        private bool hasil;
        public MngrLaporan()
        {
            InitializeComponent();
            control = new Controller.MngrLaporanController(this);
            TampilData();
        }

        public void TampilData()
        {
            control.SelectMngrLaporan();
        }

        private void btnPrint_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            PrintDialog printDlg = new PrintDialog();
            printDlg.PrintVisual(dtgLaporan, "Riwayat Transaksi Penjualan Pulsa");
        }

        private void btnRest_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            hasil = control.ResetLaporan();
            if (hasil == true)
            {
                MessageBox.Show("Semua Data Berhasil Dihapus");
            }
            else
            {
                MessageBox.Show("Semua Data Gagal Dihapus");
            }
            TampilData();
        }
    }
}
