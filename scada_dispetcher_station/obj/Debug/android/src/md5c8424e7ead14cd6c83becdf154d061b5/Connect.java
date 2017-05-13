package md5c8424e7ead14cd6c83becdf154d061b5;


public class Connect
	extends android.app.Activity
	implements
		mono.android.IGCUserPeer
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_onCreate:(Landroid/os/Bundle;)V:GetOnCreate_Landroid_os_Bundle_Handler\n" +
			"";
		mono.android.Runtime.register ("scada_dispetcher_station.Connect, scada_dispetcher_station, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", Connect.class, __md_methods);
	}


	public Connect () throws java.lang.Throwable
	{
		super ();
		if (getClass () == Connect.class)
			mono.android.TypeManager.Activate ("scada_dispetcher_station.Connect, scada_dispetcher_station, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "", this, new java.lang.Object[] {  });
	}


	public void onCreate (android.os.Bundle p0)
	{
		n_onCreate (p0);
	}

	private native void n_onCreate (android.os.Bundle p0);

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
