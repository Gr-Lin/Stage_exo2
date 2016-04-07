package md58f75dc7c525d5fa4cea9bef25d7951f2;


public class MoonActivity
	extends md5f30f4d946912a4f29e1131fe923d1dd9.ActivityBase
	implements
		mono.android.IGCUserPeer
{
	static final String __md_methods;
	static {
		__md_methods = 
			"n_onCreate:(Landroid/os/Bundle;)V:GetOnCreate_Landroid_os_Bundle_Handler\n" +
			"";
		mono.android.Runtime.register ("Sky.Activities.MoonActivity, Sky, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", MoonActivity.class, __md_methods);
	}


	public MoonActivity () throws java.lang.Throwable
	{
		super ();
		if (getClass () == MoonActivity.class)
			mono.android.TypeManager.Activate ("Sky.Activities.MoonActivity, Sky, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "", this, new java.lang.Object[] {  });
	}


	public void onCreate (android.os.Bundle p0)
	{
		n_onCreate (p0);
	}

	private native void n_onCreate (android.os.Bundle p0);

	java.util.ArrayList refList;
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
