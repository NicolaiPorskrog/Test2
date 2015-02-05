using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace App1
{
    class Class1
    {
        int hej;
        public Class1()
        {
            this.hej = 2;
        }

        public Class1(int newHej)
        {
            this.hej = 3;
        }
        public int TheValueOfHej()
        {
            return this.hej;
        }

        public void doubleValueOfHej()
        {
            this.hej = this.hej*2;
        }
    }
}