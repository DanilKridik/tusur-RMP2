using Android.Bluetooth;
using Android.OS;
using Android.Runtime;
using static Android.Preferences.Preference;

namespace lab2
{
    public class SavedState : BaseSavedState
    {
        public int ViewsCount { get; set; }
        public SavedState(Parcel State) : base(State)
        {
            ViewsCount = State.ReadInt();
        }


        public override void WriteToParcel(Parcel dest, [GeneratedEnum] ParcelableWriteFlags flags)
        {
            base.WriteToParcel(dest, flags);
            dest.WriteInt(ViewsCount);
        }
    }
   
}