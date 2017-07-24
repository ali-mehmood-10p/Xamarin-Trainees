package md5d725f66a778500a2ca727bf49332af18;


public class WMSLabelRenderer
	extends md5b60ffeb829f638581ab2bb9b1a7f4f3f.LabelRenderer
	implements
		mono.android.IGCUserPeer
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"";
		mono.android.Runtime.register ("WMS.iOS.CustomRenderer.WMSLabelRenderer, WMS.Droid, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", WMSLabelRenderer.class, __md_methods);
	}


	public WMSLabelRenderer (android.content.Context p0, android.util.AttributeSet p1, int p2) throws java.lang.Throwable
	{
		super (p0, p1, p2);
		if (getClass () == WMSLabelRenderer.class)
			mono.android.TypeManager.Activate ("WMS.iOS.CustomRenderer.WMSLabelRenderer, WMS.Droid, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "Android.Content.Context, Mono.Android, Version=0.0.0.0, Culture=neutral, PublicKeyToken=84e04ff9cfb79065:Android.Util.IAttributeSet, Mono.Android, Version=0.0.0.0, Culture=neutral, PublicKeyToken=84e04ff9cfb79065:System.Int32, mscorlib, Version=2.0.5.0, Culture=neutral, PublicKeyToken=7cec85d7bea7798e", this, new java.lang.Object[] { p0, p1, p2 });
	}


	public WMSLabelRenderer (android.content.Context p0, android.util.AttributeSet p1) throws java.lang.Throwable
	{
		super (p0, p1);
		if (getClass () == WMSLabelRenderer.class)
			mono.android.TypeManager.Activate ("WMS.iOS.CustomRenderer.WMSLabelRenderer, WMS.Droid, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "Android.Content.Context, Mono.Android, Version=0.0.0.0, Culture=neutral, PublicKeyToken=84e04ff9cfb79065:Android.Util.IAttributeSet, Mono.Android, Version=0.0.0.0, Culture=neutral, PublicKeyToken=84e04ff9cfb79065", this, new java.lang.Object[] { p0, p1 });
	}


	public WMSLabelRenderer (android.content.Context p0) throws java.lang.Throwable
	{
		super (p0);
		if (getClass () == WMSLabelRenderer.class)
			mono.android.TypeManager.Activate ("WMS.iOS.CustomRenderer.WMSLabelRenderer, WMS.Droid, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "Android.Content.Context, Mono.Android, Version=0.0.0.0, Culture=neutral, PublicKeyToken=84e04ff9cfb79065", this, new java.lang.Object[] { p0 });
	}

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
