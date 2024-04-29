using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DBPROJECT
{
    public partial class frmEditCustomer : Form
    {
        long custid = 0;
        public frmEditCustomer(long customerID)
        {
            InitializeComponent();

            this.custid = customerID;

            this.btnSave.Enabled = false;
        }
        public long custoid
        {
            get { return this.custid; }
            set { this.custid = value; }
        }

        private void txtEmail_KeyDown(object sender, KeyEventArgs e)
        {
            this.btnSave.Enabled = true; ;
            if (e.KeyCode == Keys.Enter)
            {
                if (this.GetNextControl(ActiveControl, true) != null)
                {
                    e.Handled = true;
                    e.SuppressKeyPress = true; // PUT THE DING OFF
                    this.GetNextControl(ActiveControl, true).Focus();
                }
            }
        }

        private void frmEditCustomer_Load(object sender, EventArgs e)
        {
            this.RefreshData();
            this.btnSave.Enabled = false;
            this.txtEmail.Focus();
        }

        private void RefreshData()
        {
            String ccusname = "", ccusemail = "";
            String ccusaddress= "", ccuscontact = "";

            // load photo here
            this.GetUserPhotofromField();

            this.GetProfile(this.custid, ref ccusname, ref ccusemail, ref ccusaddress,
                 ref ccuscontact);

            this.txtCusName.Text = ccusname;

            this.txtEmail.Text = ccusemail;

            this.btnSave.Enabled = false;
        }

        private void GetProfile(long ciduser,
            ref String ccname, ref String ccemail, ref String ccaddress,
            ref String cccontact)
        {
            if (Globals.glOpenSqlConn())
            {
                SqlCommand cmd = new SqlCommand("spGetCustomerProfile",
                    Globals.sqlconn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@custID", ciduser);

                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    ccname = reader["nameCustomer"].ToString();
                    ccemail = reader["emailCustomer"].ToString().ToUpper();
                    ccaddress = reader["addressCustomer"].ToString().ToUpper();
                    cccontact = reader["contactCustomer"].ToString();

                }
                else csMessageBox.Show("No such User ID:" + this.custid.ToString() + " is found!", "Warning",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            Globals.glCloseSqlConn();
        }

        void GetUserPhotofromField()
        {

            if (Globals.glOpenSqlConn())
            {
                String qrystr = "Select isnull(photo,'') as photo from dbo.customers where id=" + this.custid.ToString();
                SqlCommand cmd = new SqlCommand(qrystr, Globals.sqlconn);

                SqlDataAdapter UserAdapter = new SqlDataAdapter(cmd);

                DataTable UserTable = new DataTable();
                UserAdapter.Fill(UserTable);

                if (UserTable.Rows[0][0] != null)
                {

                    //byte[] UserImg = (byte[])UserTable.Rows[0][0];
                    byte[] UserImg = (byte[])UserTable.Rows[0][0];
                    MemoryStream imgstream = new MemoryStream(UserImg);

                    if (imgstream.Length > 0)
                        this.pictBoxUser.Image = Image.FromStream(imgstream);
                }
                UserAdapter.Dispose();
            }
            Globals.glCloseSqlConn();
        }
    }
}
