using DataSimulator;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Web.aspx
{
    public partial class tk : System.Web.UI.Page
    {
        DataSet ds;
        protected void Page_Load(object sender, EventArgs e)
        {
            select();
        }

        public void select()
        {
            string con = "server = bds30911160.my3w.com; database = bds30911160_db; uid = bds30911160; pwd = chenjinlie123";
            DbHelperSQL.connectionString = con;

            string sql = "select top 20 Id,C_content,PD_1,PD_2,PD_3,PD_4,DN,newid() random from [dbo].[Content_tk] order by random";
            ds = DbHelperSQL.Query(sql);
            ds.Tables[0].Columns.Add("ksid", typeof(int));
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                int j = i + 1;
                ds.Tables[0].Rows[i]["ksid"] = j;
            }
            rep1.DataSource = ds;
            rep1.DataBind();
        }

        protected string DN()
        {
            string li = "";
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                li = li + (i + 1) + ": " + ds.Tables[0].Rows[i]["DN"].ToString() + ",";
            }
            return li;
        }
    }
}