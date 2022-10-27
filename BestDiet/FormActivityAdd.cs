using BusinessLogicLayer.Services;
using Model.Entites;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BestDiet
{
    public partial class FormActivityAdd : Form
    {
        SportService sportService;
        int activityID=0;
        public FormActivityAdd()
        {
            InitializeComponent();
            sportService = new SportService();
        }
        public FormActivityAdd(int _activityID)
        {
            InitializeComponent();
            sportService = new SportService();
            activityID = _activityID;
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if(activityID == 0)
            {
                try
                {
                    Sport sport = new Sport();
                    sport.SportName = txtAktiviteAdi.Text;
                    sport.BurningCalori = Convert.ToInt32(nudKalori.Value);
                    sport.IsActive = true;

                    if (sportService.Insert(sport)) MessageBox.Show("Yeni aktivite eklendi");
                    else throw new Exception("Aktivite ekleme esnasında bir hata oluştu :(");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                Sport sport = sportService.GetBySportID(activityID);
                if (sport != null)
                {
                    sport.SportName=txtAktiviteAdi.Text;
                    sport.BurningCalori = (int)nudKalori.Value;
                    if (sportService.Update(sport))
                        MessageBox.Show("Başarıyla güncellendi");
                    else MessageBox.Show("Güncellenirken bir hata oluştu");
                }
            }
            
        }
    }
}
