using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TTT
{
    public partial class PlayGame : System.Web.UI.Page
    {
        public static string playerTurn = "1"; //default Player 1 start
        HttpCookie cookie = HttpContext.Current.Request.Cookies["playerTurn"];

        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack){
                if (cookie == null)
                {
                    cookie = new HttpCookie("playerTurn");
                    cookie.Value = "1";
                    HttpContext.Current.Response.Cookies.Add(cookie);
                }
            }
            displayPlayerTurn();
        }

        protected void btn11_OnClick(object sender, EventArgs e)
        {
            playerTurn = GetPlayerTurn();
            if (literal11.Text.ToString() == "" && result.Text == "")
            {
                if (playerTurn == "1")
                {
                    literal11.Text = "<img src='./Images/1.png' />";

                    cookie.Value = "2";
                    HttpContext.Current.Response.Cookies.Add(cookie);
                }
                else
                {
                    literal11.Text = "<img src='./Images/2.png' />";
                    cookie.Value = "1";
                    HttpContext.Current.Response.Cookies.Add(cookie);
                }
                btn11.Visible = false;
                checker();
            }
        }

        protected void btn12_OnClick(object sender, EventArgs e)
        {
            playerTurn = GetPlayerTurn();
            if (literal12.Text.ToString() == "" && result.Text == "")
            {
                if (playerTurn == "1")
                {
                    literal12.Text = "<img src='./Images/1.png' />";

                    cookie.Value = "2";
                    HttpContext.Current.Response.Cookies.Add(cookie);
                }
                else
                {
                    literal12.Text = "<img src='./Images/2.png' />";
                    cookie.Value = "1";
                    HttpContext.Current.Response.Cookies.Add(cookie);
                }
                btn12.Visible = false;
                checker();
            }
        }

        protected void btn13_OnClick(object sender, EventArgs e)
        {
            playerTurn = GetPlayerTurn();
            if (literal13.Text.ToString() == "" && result.Text == "")
            {
                if (playerTurn == "1")
                {
                    literal13.Text = "<img src='./Images/1.png' />";

                    cookie.Value = "2";
                    HttpContext.Current.Response.Cookies.Add(cookie);
                }
                else
                {
                    literal13.Text = "<img src='./Images/2.png' />";
                    cookie.Value = "1";
                    HttpContext.Current.Response.Cookies.Add(cookie);
                }
                btn13.Visible = false;
                checker();
            }
        }

        protected void btn21_OnClick(object sender, EventArgs e)
        {
            playerTurn = GetPlayerTurn();
            if (literal21.Text.ToString() == "" && result.Text == "")
            {
                if (playerTurn == "1")
                {
                    literal21.Text = "<img src='./Images/1.png' />";

                    cookie.Value = "2";
                    HttpContext.Current.Response.Cookies.Add(cookie);
                }
                else
                {
                    literal21.Text = "<img src='./Images/2.png' />";
                    cookie.Value = "1";
                    HttpContext.Current.Response.Cookies.Add(cookie);
                }
                btn21.Visible = false;
                checker();
            }
        }

        protected void btn22_OnClick(object sender, EventArgs e)
        {
            playerTurn = GetPlayerTurn();
            if (literal22.Text.ToString() == "" && result.Text == "")
            {
                if (playerTurn == "1")
                {
                    literal22.Text = "<img src='./Images/1.png' />";

                    cookie.Value = "2";
                    HttpContext.Current.Response.Cookies.Add(cookie);
                }
                else
                {
                    literal22.Text = "<img src='./Images/2.png' />";
                    cookie.Value = "1";
                    HttpContext.Current.Response.Cookies.Add(cookie);
                }
                btn22.Visible = false;
                checker();
            }
        }

        protected void btn23_OnClick(object sender, EventArgs e)
        {
            playerTurn = GetPlayerTurn();
            if (literal23.Text.ToString() == "" && result.Text == "")
            {
                if (playerTurn == "1")
                {
                    literal23.Text = "<img src='./Images/1.png' />";

                    cookie.Value = "2";
                    HttpContext.Current.Response.Cookies.Add(cookie);
                }
                else
                {
                    literal23.Text = "<img src='./Images/2.png' />";
                    cookie.Value = "1";
                    HttpContext.Current.Response.Cookies.Add(cookie);
                }
                btn23.Visible = false;
                checker();
            }
        }

        protected void btn31_OnClick(object sender, EventArgs e)
        {
            playerTurn = GetPlayerTurn();
            if (literal31.Text.ToString() == "" && result.Text == "")
            {
                if (playerTurn == "1")
                {
                    literal31.Text = "<img src='./Images/1.png' />";

                    cookie.Value = "2";
                    HttpContext.Current.Response.Cookies.Add(cookie);
                }
                else
                {
                    literal31.Text = "<img src='./Images/2.png' />";
                    cookie.Value = "1";
                    HttpContext.Current.Response.Cookies.Add(cookie);
                }
                btn31.Visible = false;
                checker();
            }
        }

        protected void btn32_OnClick(object sender, EventArgs e)
        {
            playerTurn = GetPlayerTurn();
            if (literal32.Text.ToString() == "" && result.Text == "")
            {
                if (playerTurn == "1")
                {
                    literal32.Text = "<img src='./Images/1.png' />";

                    cookie.Value = "2";
                    HttpContext.Current.Response.Cookies.Add(cookie);
                }
                else
                {
                    literal32.Text = "<img src='./Images/2.png' />";
                    cookie.Value = "1";
                    HttpContext.Current.Response.Cookies.Add(cookie);
                }
                btn32.Visible = false;
                checker();
            }
        }

        protected void btn33_OnClick(object sender, EventArgs e)
        {
            playerTurn = GetPlayerTurn();
            if (literal33.Text.ToString() == "" && result.Text == "")
            {
                if (playerTurn == "1")
                {
                    literal33.Text = "<img src='./Images/1.png' />";

                    cookie.Value = "2";
                    HttpContext.Current.Response.Cookies.Add(cookie);
                }
                else
                {
                    literal33.Text = "<img src='./Images/2.png' />";
                    cookie.Value = "1";
                    HttpContext.Current.Response.Cookies.Add(cookie);
                }
                btn33.Visible = false;
                checker();
            }
        }

        protected string GetPlayerTurn()
        {
            //check cookie
            if (cookie == null)
            {
                cookie = new HttpCookie("playerTurn");
                playerTurn = "1";
            }
            else
            {
                playerTurn = cookie.Value;
            }

            return playerTurn;
        }

        protected void displayPlayerTurn()
        {
            playerTurn = GetPlayerTurn();
            if (playerTurn == "1")
                DisplayTurn.Text = "Player <img src='./Images/1.png' />";
            else
                DisplayTurn.Text = "Player <img src='./Images/2.png' />";
        }

        protected bool checker()
        {
            if (literal11.Text != "" && literal11.Text == literal12.Text && literal11.Text == literal13.Text)
            {
                result.Text = "Player " + literal11.Text + " Won";
                return true;
            }
            else if (literal21.Text != "" && literal21.Text == literal22.Text && literal21.Text == literal23.Text)
            {
                result.Text = "Player " + literal21.Text + " Won";
                return true;
            }
            else if (literal31.Text != "" && literal31.Text == literal32.Text && literal31.Text == literal33.Text)
            {
                result.Text = "Player " + literal31.Text + " Won";
                return true;
            }
            if (literal11.Text != "" && literal11.Text == literal21.Text && literal11.Text == literal31.Text)
            {
                result.Text = "Player " + literal11.Text + " Won";
                return true;
            }
            else if (literal12.Text != "" && literal12.Text == literal22.Text && literal12.Text == literal32.Text)
            {
                result.Text = "Player " + literal12.Text + " Won";
                return true;
            }
            else if (literal13.Text != "" && literal13.Text == literal23.Text && literal13.Text == literal33.Text)
            {
                result.Text = "Player " + literal13.Text + " Won";
                return true;
            }
            else if (literal11.Text != "" && literal11.Text == literal22.Text && literal11.Text == literal33.Text)
            {
                result.Text = "Player " + literal11.Text + " Won";
                return true;
            }
            else if (literal13.Text != "" && literal13.Text == literal22.Text && literal13.Text == literal31.Text)
            {
                result.Text = "Player " + literal13.Text + " Won";
                return true;
            }

            displayPlayerTurn();
            return false;
        }

        protected void reset_OnClick(object sender, EventArgs e)
        {
            btn11.Visible = true;
            btn12.Visible = true;
            btn13.Visible = true;
            btn21.Visible = true;
            btn22.Visible = true;
            btn23.Visible = true;
            btn31.Visible = true;
            btn32.Visible = true;
            btn33.Visible = true;

            literal11.Text = "";
            literal12.Text = "";
            literal13.Text = "";
            literal21.Text = "";
            literal22.Text = "";
            literal23.Text = "";
            literal31.Text = "";
            literal32.Text = "";
            literal33.Text = "";

            result.Text = "";

            cookie = new HttpCookie("playerTurn");
            cookie.Value = "1";
            HttpContext.Current.Response.Cookies.Add(cookie);
            playerTurn = "1";
            displayPlayerTurn();
        }
    }
}