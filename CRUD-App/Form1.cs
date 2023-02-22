using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRUD_App
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection(@"Data Source=.;Initial Catalog=EtudiantDB;Integrated Security=True");
        SqlCommand cmd;
        DataTable table = new DataTable();
        SqlDataAdapter sda;

        public void ListeEtudiants()
        {
            con.Open();
            sda = new SqlDataAdapter("select Matricule,Nom,Prenom as 'Prénom',Filiere as 'Filiére',Groupe,DateNaissance as 'Date de naissance' from Etudiant", con);
            table.Clear();
            sda.Fill(table);
            DGVEtudiants.DataSource = table;
            con.Close();
        }

        public void Vider()
        {
            TxtMatricule.Text = TxtNom.Text = TxtPrenom.Text = TxtFiliere.Text = "";
            CmbGroupe.SelectedIndex = 0;
            DPNaissance.Value = DateTime.Now;
        }

        private void BtnAjouter_Click(object sender, EventArgs e)
        {
            if (TxtNom.Text != "" || TxtPrenom.Text != "" || TxtFiliere.Text != "" || CmbGroupe.Text != "- Choisir le Group -")
            {
                if (DPNaissance.Value.Year <= DateTime.Now.Year)
                {
                    con.Open();
                    cmd = new SqlCommand("insert into Etudiant values(@Nom,@Prenom,@Filiere,@Groupe,@DateNaissance)", con);
                    cmd.Parameters.AddWithValue("@Nom", TxtNom.Text);
                    cmd.Parameters.AddWithValue("@Prenom", TxtPrenom.Text);
                    cmd.Parameters.AddWithValue("@Filiere", TxtFiliere.Text);
                    cmd.Parameters.AddWithValue("@Groupe", CmbGroupe.Text);
                    cmd.Parameters.AddWithValue("@DateNaissance",DateTime.Parse(DPNaissance.Value.ToShortDateString()));
                    cmd.ExecuteNonQuery();
                    con.Close();

                    ListeEtudiants();

                    MessageBox.Show("Etudiant est bien ajouter !", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    Vider();
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ListeEtudiants();
            CmbGroupe.SelectedIndex = 0;
        }

        private void DGVEtudiants_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (DGVEtudiants.SelectedRows.Count > 0)
            {
                TxtMatricule.Text = DGVEtudiants.SelectedRows[0].Cells[0].Value.ToString();
                TxtNom.Text = DGVEtudiants.SelectedRows[0].Cells[1].Value.ToString();
                TxtPrenom.Text = DGVEtudiants.SelectedRows[0].Cells[2].Value.ToString();
                TxtFiliere.Text = DGVEtudiants.SelectedRows[0].Cells[3].Value.ToString();
                CmbGroupe.Text = DGVEtudiants.SelectedRows[0].Cells[4].Value.ToString();
                DPNaissance.Value = DateTime.Parse(DGVEtudiants.SelectedRows[0].Cells[5].Value.ToString());
            }
        }

        private void BtnModifier_Click(object sender, EventArgs e)
        {
            if (TxtNom.Text != "" || TxtPrenom.Text != "" || TxtFiliere.Text != "" || CmbGroupe.Text != "- Choisir le Group -")
            {
                if (DPNaissance.Value.Year <= DateTime.Now.Year)
                {
                    con.Open();
                    cmd = new SqlCommand("update Etudiant set Nom=@Nom,Prenom=@Prenom,Filiere=@Filiere,Groupe=@Groupe,DateNaissance=@DateNaissance where Matricule=@Matricule", con);
                    cmd.Parameters.AddWithValue("@Matricule", TxtMatricule.Text);
                    cmd.Parameters.AddWithValue("@Nom", TxtNom.Text);
                    cmd.Parameters.AddWithValue("@Prenom", TxtPrenom.Text);
                    cmd.Parameters.AddWithValue("@Filiere", TxtFiliere.Text);
                    cmd.Parameters.AddWithValue("@Groupe", CmbGroupe.Text);
                    cmd.Parameters.AddWithValue("@DateNaissance", DPNaissance.Value.ToShortDateString());
                    cmd.ExecuteNonQuery();
                    con.Close();

                    ListeEtudiants();

                    MessageBox.Show("Etudiant est bien modifier !", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    Vider();
                }
            }
        }

        private void BtnSupprimer_Click(object sender, EventArgs e)
        {
            if (DGVEtudiants.SelectedRows.Count > 0)
            {
                DialogResult dr = (MessageBox.Show("Voulez-vous vraiment supprimer cette étdudiant ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question));
                if (dr == DialogResult.Yes)
                {
                    con.Open();
                    cmd = new SqlCommand("delete from Etudiant where Matricule=@Matricule", con);
                    cmd.Parameters.AddWithValue("@Matricule", DGVEtudiants.SelectedRows[0].Cells[0].Value.ToString());
                    cmd.ExecuteNonQuery();
                    con.Close();

                    ListeEtudiants();

                    MessageBox.Show("Etudiant est bien supprimer !", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    Vider();
                }
            }
        }
    }
}
