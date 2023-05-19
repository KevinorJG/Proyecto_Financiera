﻿using Financiera.AppCore.IServices;
using Financiera.Commons.Processes;
using Financiera.Domain.Entities;
using Financiera.Domain.Enums;
using System;
using System.Windows.Forms;

namespace Financiera.Presentation.Forms.UsControls
{
    public partial class UsAccounts : UserControl
    {
        protected IAccountServices AccountServices;
        protected string Identi = string.Empty;
        protected string STATUS = string.Empty;
        public UsAccounts()
        {
            InitializeComponent();
        }

        private void UsCounts_Load(object sender, EventArgs e)
        {
          
            if (User.Rol == Roles.Administrador.ToString())
            {
                this.btDeleteAcc.Enabled = true;
            }
            else if (User.Rol == Roles.Empleado.ToString())
            {
                this.btDeleteAcc.Enabled = false;
            }
            cbTypeCoin.DataSource = Enum.GetValues(typeof(TypeCoin));
            cbTyCount.DataSource = Enum.GetValues(typeof(TypeCounts));
            GetAccounts();
        }

        private void txtDniClient_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter)
            {
                if (txtDniClient.Texts != string.Empty)
                {
                    var cl = AccountServices.GetClientByDni(txtDniClient.Texts);
                    if (cl != null)
                    {                       
                        Identi = cl.Identification;
                        MessageBox.Show($"Nombre: {cl.Names + " " + cl.LastNames}\nCedula: " +
                                        $"{cl.Identification}", "Informacion", 
                                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else { MessageBox.Show(Domain.ContextDB.Message.Exception, "Sin resultados", MessageBoxButtons.OK, MessageBoxIcon.Error); }
                }
            }
        }
        public void SetServices(IAccountServices accountServices)
        {
            this.AccountServices = accountServices;
        }

        private void GetAccounts()
        {
            dgvAccounts.DataSource = AccountServices.GetAccounts();
        }

        private async void btAgg_Click(object sender, EventArgs e)
        {
            Object lockinsert = new object();
            Account account = new Account()
            {
                Identi = Identi,
                OpenDate = DateTime.Parse(pickerDate.Text),
                TypeAccount = cbTyCount.SelectedItem.ToString(),
                TypeCoin = cbTypeCoin.SelectedItem.ToString(),
                IdHideline =  1,
                Status = STATUS,
                Saldo = 0
            };
            var result = AccountServices.InsertAccount(account);
            await result;
            lock (lockinsert)
            {
                if (result.IsCompleted) { GetAccounts(); }
            }
        }

        private void dgvAccounts_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                var identi = int.Parse(dgvAccounts.Rows[e.RowIndex].Cells[0].Value.ToString());
                Reports.FormReports.FmAccountReport Reporte = new Reports.FormReports.FmAccountReport(identi, Connection.StringConnection);
                Reporte.Show();
            }
            catch (Exception ex)
            {

            }
        }

        private void tgStatus_CheckedChanged(object sender, EventArgs e)
        {
            if(tgStatus.CheckState == CheckState.Checked) { STATUS = "Habilitado"; }   
            if(tgStatus.CheckState == CheckState.Unchecked) { STATUS = "Deshabilitado"; }
            lbStatus.Text = STATUS;
        }

        private void btSearchAcc_Click(object sender, EventArgs e)
        {
            try
            {
                var ls = AccountServices.GetAccountsByDni(txtSearch.Texts);
                if (ls != null)
                {
                    dgvAccounts.DataSource = ls;
                }
                else
                {
                    MessageBox.Show(Domain.ContextDB.Message.Exception, "Sin resultados", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
              
            }          
        }
    }
}
