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

namespace CRUDTIDAKSEDERHANA
{
    public partial class Form1: Form
    {
        private string connectionString =
            "Data Source=SYNZENN\\SYNZENN;Initial Catalog=OrganisasiMahasiswa;Integrated Security=True";


        public Form1()
        {
            InitializeComponent();
        }
        private void ClearForm()
        {
            txtNIM.Clear();
            txtNama.Clear();
            txtEmail.Clear();
            txtTelepon.Clear();
            txtAlamat.Clear();

            // Fokus kembali ke NIM agar user siap memasukkan data baru
            txtNIM.Focus();
        }

        