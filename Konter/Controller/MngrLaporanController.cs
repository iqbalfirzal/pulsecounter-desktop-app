using System;
using System.Data;

namespace Konter.Controller
{
    class MngrLaporanController
    {
        private Model.MngrLaporanModel modelMngrLaporan;
        private MngrLaporan viewMngrLaporan;
        public MngrLaporanController(MngrLaporan viewMngrLaporan)
        {
            this.viewMngrLaporan = viewMngrLaporan;
            modelMngrLaporan = new Model.MngrLaporanModel();
        }
        // fungsi menampilkan data
        public void SelectMngrLaporan()
        {
            DataSet data = modelMngrLaporan.SelectedLaporan();
            viewMngrLaporan.dtgLaporan.ItemsSource = data.Tables[0].DefaultView;
        }
        // fungsi mereset data
        public Boolean ResetLaporan()
        {
            Boolean hasil = modelMngrLaporan.ResetedLaporan();
            return hasil;
        }
    }
}
