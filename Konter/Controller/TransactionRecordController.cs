using System;
using System.Data;

namespace Konter.Controller
{
    class TransactionRecordController
    {
        private Model.TransactionRecordModel modelTransactionRecord;
        private TransactionRecord viewTransactionRecord;
        private string kdKaryawan;
        public TransactionRecordController(TransactionRecord viewTransactionRecord, string kdKaryawan)
        {
            this.viewTransactionRecord = viewTransactionRecord;
            modelTransactionRecord = new Model.TransactionRecordModel();
            this.kdKaryawan = kdKaryawan;
        }
        public TransactionRecordController(TransactionRecord viewTransactionRecord)
        {
            this.viewTransactionRecord = viewTransactionRecord;
            modelTransactionRecord = new Model.TransactionRecordModel();
            
        }
        // fungsi menampilkan data
        public void SelectTransaction()
        {
            modelTransactionRecord.SetKd_Karyawan(kdKaryawan);
            DataSet data = modelTransactionRecord.SelectedTransaction();
            viewTransactionRecord.dtgTransaction.ItemsSource = data.Tables[0].DefaultView;
            // get kode pulsa
            DataSet dataCmb = modelTransactionRecord.SelectedCodePulsa();
            viewTransactionRecord.cmbJenisPulsa.DataContext = dataCmb.Tables[0].DefaultView;
            viewTransactionRecord.cmbJenisPulsa.DisplayMemberPath = dataCmb.Tables[0].Columns[1].ToString();
            viewTransactionRecord.cmbJenisPulsa.SelectedValuePath = dataCmb.Tables[0].Columns[0].ToString();
            viewTransactionRecord.cmbJenisPulsa.SelectedIndex = 0;
        }
        // menambahkan data
        public Boolean InsertTransaction()
        {
            modelTransactionRecord.SettNomor_Handphone(viewTransactionRecord.txtNomor.Text);
            modelTransactionRecord.SetKd_Pulsa(viewTransactionRecord.cmbJenisPulsa.SelectedValue.ToString());
            modelTransactionRecord.SetKd_Karyawan(viewTransactionRecord.lblKaryawan_GetCode.Text);
            Boolean hasil = modelTransactionRecord.InsertedTransaction();
            return hasil;
        }
        // fungsi menghapus data
        public Boolean DeleteTransaction()
        {
            modelTransactionRecord.SetKd_Transaksi(viewTransactionRecord.txtGetKdTransaksi.Text);
            Boolean hasil = modelTransactionRecord.DeletedTransaction();
            return hasil;
        }
    }
}
