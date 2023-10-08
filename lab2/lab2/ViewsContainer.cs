﻿using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Util;
using Android.Views;
using Android.Widget;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace lab2
{
    public class ViewsContainer : View
    {

        private int viewsCount = 0;
        public ViewsContainer(Context context, IAttributeSet attrs) :
            base(context, attrs)
        {
            Initialize();
        }

        public ViewsContainer(Context context, IAttributeSet attrs, int defStyle) :
            base(context, attrs, defStyle)
        {
            Initialize();
        }

        private void Initialize()
        {
        }

        public void IncrementViews()
        {
            TextView textView = new TextView(Context);
            textView.SetText(viewsCount.ToString(), TextView.BufferType.Normal);
            viewsCount++;
            AddView(textView);
        }
    }
}