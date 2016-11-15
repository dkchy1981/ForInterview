using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ForInterview
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            test.MyStaticProp = 10;

            iA cc = new c();
            int a = cc.Sum(1, 2);

            iB cc1 = new c();

            int d = cc1.Sum(10, 20);

            c dd = new d();
            int aa=dd.test(10);

            dd = new c();
            aa = dd.test(10);

        }
    }

    interface iA
    {
        int Sum(int a, int b);
    }
    interface iB
    {
        int Sum(int a, int b);
    }
    public class c : iA, iB
    {
        int iA.Sum(int a, int b)
        {
            return a + b;
        }

        int iB.Sum(int a, int b)
        {
            return a + b;
        }

        public virtual int test(int i)
        {
            return i;
        }
    }

    public class d : c
    {
        public override int  test(int a)
        {
            int aa=base.test(a);
            return a + 1;
        }
    }

    public class test
    {

        public static int MyStaticProp { get; set; }
    }

}