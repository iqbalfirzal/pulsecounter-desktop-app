// header untuk menggunakan library yang berkaitan dengan database
using System;
using System.Data;


namespace Konter.Controller
{
    class MngrPulsaController
    {
        private Model.MngrPulsaModel modelMngrPulsa;
        private MngrPulsa viewMngrPulsa;
        public MngrPulsaController(MngrPulsa viewMngrPulsa)
        {
            this.viewMngrPulsa = viewMngrPulsa;
            modelMngrPulsa = new Model.MngrPulsaModel();
        }
        // fungsi menampilkan data
        public void SelectMngrPulsa()
        {
            DataSet data = modelMngrPulsa.SelectedPulsa();
            viewMngrPulsa.dtgPulsa.ItemsSource = data.Tables[0].DefaultView;
            // get kode jenis pulsa
            DataSet dataCmbJenisPulsa = modelMngrPulsa.SelectedJenisPulsa();
            viewMngrPulsa.cmbJenisPulsa.DataContext = dataCmbJenisPulsa.Tables[0].DefaultView;
            viewMngrPulsa.cmbJenisPulsa.DisplayMemberPath = dataCmbJenisPulsa.Tables[0].Columns[1].ToString();
            viewMngrPulsa.cmbJenisPulsa.SelectedValuePath = dataCmbJenisPulsa.Tables[0].Columns[0].ToString();
            // get kode provider
            DataSet dataCmbProvider = modelMngrPulsa.SelectedProvider();
            viewMngrPulsa.cmbProvider.DataContext = dataCmbProvider.Tables[0].DefaultView;
            viewMngrPulsa.cmbProvider.DisplayMemberPath = dataCmbProvider.Tables[0].Columns[1].ToString();
            viewMngrPulsa.cmbProvider.SelectedValuePath = dataCmbProvider.Tables[0].Columns[0].ToString();
        }
        // fungsi menambahkan data
        public Boolean InsertMngrPulsa()
        {
            modelMngrPulsa.SetKd_Pulsa(viewMngrPulsa.txtKodePulsa.Text);
            modelMngrPulsa.SetHarga(viewMngrPulsa.txtHarga.Text);
            modelMngrPulsa.SetNominal(viewMngrPulsa.txtNominal.Text);
            modelMngrPulsa.SetKeterangan(viewMngrPulsa.txtKeterangan.Text);
            modelMngrPulsa.SetNama_Jenis(viewMngrPulsa.cmbJenisPulsa.SelectedValue.ToString());
            modelMngrPulsa.SetNama_Provider(viewMngrPulsa.cmbProvider.SelectedValue.ToString());
            Boolean hasil = modelMngrPulsa.InsertedPulsa();
            return hasil;
        }
        // fungsi mengubah data
        public Boolean UpdateMngrPulsa()
        {
            modelMngrPulsa.SetKd_Pulsa(viewMngrPulsa.txtKodePulsa.Text);
            modelMngrPulsa.SetHarga(viewMngrPulsa.txtHarga.Text);
            modelMngrPulsa.SetNominal(viewMngrPulsa.txtNominal.Text);
            modelMngrPulsa.SetKeterangan(viewMngrPulsa.txtKeterangan.Text);
            modelMngrPulsa.SetNama_Jenis(viewMngrPulsa.cmbJenisPulsa.SelectedValue.ToString());
            modelMngrPulsa.SetNama_Provider(viewMngrPulsa.cmbProvider.SelectedValue.ToString());
            Boolean hasil = modelMngrPulsa.UpdatedPulsa();
            return hasil;
        }
        // fungsi menghapus data
        public Boolean DeleteMngrPulsa()
        {
            modelMngrPulsa.SetKd_Pulsa(viewMngrPulsa.txtGetKdPulsa.Text);
            Boolean hasil = modelMngrPulsa.DeletedPulsa();
            return hasil;
        }
    }
}
