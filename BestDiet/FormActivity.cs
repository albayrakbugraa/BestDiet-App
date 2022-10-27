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
    public partial class FormActivity : Form
    {
        Exercise exercise;
        User user;
        DateTime dateTime;
        ExerciseService exerciseService;
        ExerciseDetail exerciseDetail;
        ExerciseDetailService exerciseDetailService;
        SportService sportService;
        List<Sport> sportList;
        List<ExerciseDetail> exerciseDetails;


        public FormActivity(Exercise _exercise,User _user,DateTime _dateTime)
        {
            InitializeComponent();
            exercise = _exercise;
            user = _user;
            dateTime=_dateTime;
            sportService = new SportService();
            exerciseService = new ExerciseService();
            exerciseDetailService = new ExerciseDetailService();
        }

        private void FormActivity_Load(object sender, EventArgs e)
        {
            Helper.ClearControls(Controls);
            sportList = sportService.GetSports();
            if (exercise!=null)
            {
                
                ListAddedActivities();
            }
           
            ListActivities();
            
        }

        void ListActivities()
        {
            lvAktiviteler.Items.Clear();
            ListViewItem lvitem;
            foreach (Sport item in sportList)
            {
                lvitem = new ListViewItem();
                lvitem.Text = item.SportName;
                lvitem.SubItems.Add(item.BurningCalori.ToString());
                lvitem.Tag = item.SportID;
                lvAktiviteler.Items.Add(lvitem);
            }
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            if (lvAktiviteler.SelectedItems.Count <= 0) return;
            else
            {
                
                if (exercise==null)
                {
                    exercise = new Exercise();
                    exercise.User = user;
                    exercise.UserID = user.UserID;
                    exercise.ExerciseDate = dateTime.Date;
                    exerciseService.Insert(exercise);  
                }

                int sportID = (int)lvAktiviteler.SelectedItems[0].Tag;
                Sport sport = sportService.GetBySportID(sportID);
                try
                {
                    exerciseDetail = new ExerciseDetail();
                    exerciseDetail.ExerciseID = exercise.ExerciseID;
                    exerciseDetail.SportID = sportID;
                    exerciseDetail.BurningCalori = sport.BurningCalori/60*(int)nudMinute.Value;
                    exerciseDetail.Minute = (int)nudMinute.Value;
                    if (exerciseDetailService.Insert(exerciseDetail))
                    {                        
                        MessageBox.Show("Egzersiz eklendi");
                    }
                    else throw new Exception("Ekleme sırasında hata oluştu");
                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                
            }
            ListAddedActivities();
        }

        void ListAddedActivities()
        {
            lvEklenenAktiviteler.Items.Clear();
            ListViewItem lvitem;
            exerciseDetails = exerciseDetailService.GetSportsByExercise(exercise.UserID, exercise.ExerciseDate);
            lblAktiviteToplamKalori.Text = exerciseDetailService.GetSumCalori(exercise.UserID, exercise.ExerciseDate).ToString();

            if (exerciseDetails!=null)
            {
                foreach (ExerciseDetail item in exerciseDetails)
                {
                    lvitem = new ListViewItem();
                    lvitem.Text = item.Sport.SportName;
                    lvitem.SubItems.Add(item.BurningCalori.ToString());
                    lvitem.SubItems.Add(item.Minute.ToString());
                    lvitem.Tag = item.ExerciseDetailID;
                    lvEklenenAktiviteler.Items.Add(lvitem);
                }
            }
            
        }

        private void btnAktiviteEkle_Click(object sender, EventArgs e)
        {
            FormActivityAdd formActivityAdd = new FormActivityAdd();
            formActivityAdd.ShowDialog();
        }

        private void txtAktiviteAra_TextChanged(object sender, EventArgs e)
        {
            lvAktiviteler.Items.Clear();
            List<Sport> sports = new List<Sport>();
            sports = sportService.GetFoodsByText(txtAktiviteAra.Text);
            ListViewItem lvi;

            foreach (Sport item in sports)
            {
                lvi = new ListViewItem();
                lvi.Text = item.SportName;
                lvi.SubItems.Add(item.BurningCalori.ToString());
                lvi.Tag = item.SportID;
                lvAktiviteler.Items.Add(lvi);
            }
        }

        private void btnDuzenle_Click(object sender, EventArgs e)
        {
            if (lvAktiviteler.SelectedItems.Count <= 0) return;
            else
            {
                int exerciseDetailID = (int)lvEklenenAktiviteler.SelectedItems[0].Tag;
                ExerciseDetail exerciseDetail=exerciseDetailService.GetExerciseDetailById(exerciseDetailID);
                if (exerciseDetail != null)
                {
                    exerciseDetail.Minute = (int)nudMinute.Value;
                    bool check = exerciseDetailService.Update(exerciseDetail);

                    MessageBox.Show(check ? "Güncelleme başarılı !" : "Güncellenemedi !!!");
                }

            }
            ListAddedActivities();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (lvAktiviteler.SelectedItems.Count <= 0) return;
            else
            {
                int exerciseDetailID = (int)lvEklenenAktiviteler.SelectedItems[0].Tag;
                bool check = exerciseDetailService.Delete(exerciseDetailID);
                MessageBox.Show(check ? "Aktivite Silindi.." : "Silme işlemi başarısız !");
            }
            ListAddedActivities();
        }

        private void lvEklenenAktiviteler_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (lvAktiviteler.SelectedItems.Count <= 0) return;
            else
            {
                int exerciseDetailID = (int)lvEklenenAktiviteler.SelectedItems[0].Tag;
                ExerciseDetail exerciseDetail = exerciseDetailService.GetExerciseDetailById(exerciseDetailID);
                if (exerciseDetail != null)
                {
                    nudMinute.Value = exerciseDetail.Minute;
                }
                else throw new Exception("Listeden eklenen aktiviteyi seçiniz.");
            }
        }
    }
}
