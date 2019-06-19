// header untuk menggunakan library yang berkaitan dengan database
using System;
using System.Data;


namespace Konter.Controller
{
    class MngrKaryawanController
    {
        private Model.MngrKaryawanModel modelMngrKaryawan;
        private MngrKaryawan viewMngrKaryawan;
        public MngrKaryawanController(MngrKaryawan viewMngrKaryawan)
        {
            this.viewMngrKaryawan = viewMngrKaryawan;
            modelMngrKaryawan = new Model.MngrKaryawanModel();
        }
        // fungsi menampilkan data
        public void SelectMngrKaryawan()
        {
            DataSet data = modelMngrKaryawan.SelectedKaryawan();
            viewMngrKaryawan.dtgKaryawan.ItemsSource = data.Tables[0].DefaultView;
        }
        // fungsi menambahkan data
        public Boolean InsertMngrKaryawan()
        {
            modelMngrKaryawan.SetKd_Karyawan(viewMngrKaryawan.txtKodeKaryawan.Text);
            modelMngrKaryawan.SetUSERNAME(viewMngrKaryawan.txtUsername.Text);
            modelMngrKaryawan.SetPASSWORD(viewMngrKaryawan.txtPassword.Text);
            modelMngrKaryawan.SetNama(viewMngrKaryawan.txtNama.Text);
            modelMngrKaryawan.SetGender(viewMngrKaryawan.txtGender.Text);
            modelMngrKaryawan.SetTempat_Lahir(viewMngrKaryawan.txtTempatLahir.Text);
            modelMngrKaryawan.SetTanggal_Lahir(viewMngrKaryawan.txtTanggalLahir.Text);
            modelMngrKaryawan.SetAlamat(viewMngrKaryawan.txtAlamat.Text);
            modelMngrKaryawan.SetNomor_Handphone(viewMngrKaryawan.txtNomorHP.Text);
            modelMngrKaryawan.SetGaji(viewMngrKaryawan.txtGaji.Text);
            Boolean hasil = modelMngrKaryawan.InsertKaryawan();
            return hasil;
        }
        // fungsi mengubah data
        public Boolean UpdateMngrKaryawan()
        {
            modelMngrKaryawan.SetKd_Karyawan(viewMngrKaryawan.txtKodeKaryawan.Text);
            modelMngrKaryawan.SetUSERNAME(viewMngrKaryawan.txtUsername.Text);
            modelMngrKaryawan.SetPASSWORD(viewMngrKaryawan.txtPassword.Text);
            modelMngrKaryawan.SetNama(viewMngrKaryawan.txtNama.Text);
            modelMngrKaryawan.SetGender(viewMngrKaryawan.txtGender.Text);
            modelMngrKaryawan.SetTempat_Lahir(viewMngrKaryawan.txtTempatLahir.Text);
            modelMngrKaryawan.SetTanggal_Lahir(viewMngrKaryawan.txtTanggalLahir.Text);
            modelMngrKaryawan.SetAlamat(viewMngrKaryawan.txtAlamat.Text);
            modelMngrKaryawan.SetNomor_Handphone(viewMngrKaryawan.txtNomorHP.Text);
            modelMngrKaryawan.SetGaji(viewMngrKaryawan.txtGaji.Text);
            Boolean hasil = modelMngrKaryawan.UpdateKaryawan();
            return hasil;
        }
        // fungsi menghapus data
        public Boolean DeleteMngrKaryawan()
        {
            modelMngrKaryawan.SetKd_Karyawan(viewMngrKaryawan.txtGetKdKaryawan.Text);
            Boolean hasil = modelMngrKaryawan.DeleteKaryawan();
            return hasil;
        }
    }
}
