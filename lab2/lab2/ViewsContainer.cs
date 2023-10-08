using Android.App;
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
        }

        protected override IParcelable OnSaveInstanceState()
        {
            SavedState state = (SavedState)base.OnSaveInstanceState();
            state.ViewsCount = viewsCount;
            return state;
        }

        protected override void OnRestoreInstanceState(IParcelable state)
        {
            if (!(state is SavedState))
            {
                base.OnRestoreInstanceState(state);
                return;
            }
            SavedState s = (SavedState)state;
            base.OnRestoreInstanceState (state);

            for (int i = 0; i < s.ViewsCount; i++)
                IncrementViews();
        }
    }
}