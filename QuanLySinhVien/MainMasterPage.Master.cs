using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace QuanLySinhVien
{
    public partial class MainMasterPage : System.Web.UI.MasterPage
    {
        private List<TheUseCase> lstTheUC = StaticVariable.LIST_UC;

        public List<TheUseCase> LstTheUC
        {
            get
            {
                return lstTheUC;
            }

            private set
            {
                lstTheUC = value;
            }
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            if (false)
                try
                {
                    if ((Session["TheUser"].ToString() == null || Session["TheUser"].ToString() == ""))
                        Response.Redirect("Login.aspx");
                }
                catch
                {
                    Session["TheUser"] = "";
                    Response.Redirect("Login.aspx");
                }
        }
    }
    public class TheUseCase
    {
        private string linkPage;
        private string titlePage;
        private int theID;

        public string LinkPage
        {
            get
            {
                return linkPage;
            }

            set
            {
                linkPage = value;
            }
        }

        public string TitlePage
        {
            get
            {
                return titlePage;
            }

            set
            {
                titlePage = value;
            }
        }

        public int TheID
        {
            get
            {
                return theID;
            }

            set
            {
                theID = value;
            }
        }
    }

}