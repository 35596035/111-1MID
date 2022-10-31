using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _111_1MID {
    public partial class Q2_Sub : System.Web.UI.Page {
        protected void Page_Load(object sender, EventArgs e) {
            string[] s_Get = new string[] { "tb_Num", "rbl_Phone", "txt_Phone", "dpl_City", "dpl_Area" };
            string[] s_Menu = new string[] { "保單編號: ", "通訊種類: ", "通訊號碼: ", "所在城市: ", "所在區域: " };
            for (int i_Ct = 0; i_Ct < s_Get.Length; i_Ct++)
            {
                if (Request.Form.Get(s_Get[2]) == "")
                {
                    Response.Write("0");
                }
                lb_Msg.Text += s_Menu[i_Ct] + Request.Form.Get(s_Get[i_Ct]) + "<br />";
                // + "<br />"
            }
            /*
            Response.Write("---------");
            string[] s = Request.Form.AllKeys;
            for (int i = 0; i < s.Length; i++)
            {
                Response.Write(s[i] + "<br />");
            }*/
        }
    }
}