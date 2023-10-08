package crc646aa85f209dbc8b68;


public class SavedState
	extends android.preference.Preference.BaseSavedState
	implements
		mono.android.IGCUserPeer
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_writeToParcel:(Landroid/os/Parcel;I)V:GetWriteToParcel_Landroid_os_Parcel_IHandler\n" +
			"";
		mono.android.Runtime.register ("lab2.SavedState, lab2", SavedState.class, __md_methods);
	}


	public SavedState (android.os.Parcel p0)
	{
		super (p0);
		if (getClass () == SavedState.class) {
			mono.android.TypeManager.Activate ("lab2.SavedState, lab2", "Android.OS.Parcel, Mono.Android", this, new java.lang.Object[] { p0 });
		}
	}


	public SavedState (android.os.Parcelable p0)
	{
		super (p0);
		if (getClass () == SavedState.class) {
			mono.android.TypeManager.Activate ("lab2.SavedState, lab2", "Android.OS.IParcelable, Mono.Android", this, new java.lang.Object[] { p0 });
		}
	}


	public void writeToParcel (android.os.Parcel p0, int p1)
	{
		n_writeToParcel (p0, p1);
	}

	private native void n_writeToParcel (android.os.Parcel p0, int p1);

	private java.util.ArrayList refList;
	public void monodroidAddReference (java.lang.Object obj)
	{
		if (refList == null)
			refList = new java.util.ArrayList ();
		refList.add (obj);
	}

	public void monodroidClearReferences ()
	{
		if (refList != null)
			refList.clear ();
	}
}
