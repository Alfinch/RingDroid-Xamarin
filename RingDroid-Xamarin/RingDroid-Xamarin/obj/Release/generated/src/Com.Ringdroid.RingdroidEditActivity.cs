using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Ringdroid {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.ringdroid']/class[@name='RingdroidEditActivity']"
	[global::Android.Runtime.Register ("com/ringdroid/RingdroidEditActivity", DoNotGenerateAcw=true)]
	public partial class RingdroidEditActivity : global::Android.App.Activity, global::Com.Ringdroid.MarkerView.IMarkerListener, global::Com.Ringdroid.WaveformView.IWaveformListener {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.ringdroid']/class[@name='RingdroidEditActivity']/field[@name='EDIT']"
		[Register ("EDIT")]
		public const string Edit = (string) "com.ringdroid.action.EDIT";
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/ringdroid/RingdroidEditActivity", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (RingdroidEditActivity); }
		}

		protected RingdroidEditActivity (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.ringdroid']/class[@name='RingdroidEditActivity']/constructor[@name='RingdroidEditActivity' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe RingdroidEditActivity ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (RingdroidEditActivity)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "()V"),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "()V");
					return;
				}

				if (id_ctor == IntPtr.Zero)
					id_ctor = JNIEnv.GetMethodID (class_ref, "<init>", "()V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor);
			} finally {
			}
		}

		static Delegate cb_markerDraw;
#pragma warning disable 0169
		static Delegate GetMarkerDrawHandler ()
		{
			if (cb_markerDraw == null)
				cb_markerDraw = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_MarkerDraw);
			return cb_markerDraw;
		}

		static void n_MarkerDraw (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Ringdroid.RingdroidEditActivity __this = global::Java.Lang.Object.GetObject<global::Com.Ringdroid.RingdroidEditActivity> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.MarkerDraw ();
		}
#pragma warning restore 0169

		static IntPtr id_markerDraw;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.ringdroid']/class[@name='RingdroidEditActivity']/method[@name='markerDraw' and count(parameter)=0]"
		[Register ("markerDraw", "()V", "GetMarkerDrawHandler")]
		public virtual unsafe void MarkerDraw ()
		{
			if (id_markerDraw == IntPtr.Zero)
				id_markerDraw = JNIEnv.GetMethodID (class_ref, "markerDraw", "()V");
			try {

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_markerDraw);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "markerDraw", "()V"));
			} finally {
			}
		}

		static Delegate cb_markerEnter_Lcom_ringdroid_MarkerView_;
#pragma warning disable 0169
		static Delegate GetMarkerEnter_Lcom_ringdroid_MarkerView_Handler ()
		{
			if (cb_markerEnter_Lcom_ringdroid_MarkerView_ == null)
				cb_markerEnter_Lcom_ringdroid_MarkerView_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_MarkerEnter_Lcom_ringdroid_MarkerView_);
			return cb_markerEnter_Lcom_ringdroid_MarkerView_;
		}

		static void n_MarkerEnter_Lcom_ringdroid_MarkerView_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Ringdroid.RingdroidEditActivity __this = global::Java.Lang.Object.GetObject<global::Com.Ringdroid.RingdroidEditActivity> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Ringdroid.MarkerView p0 = global::Java.Lang.Object.GetObject<global::Com.Ringdroid.MarkerView> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.MarkerEnter (p0);
		}
#pragma warning restore 0169

		static IntPtr id_markerEnter_Lcom_ringdroid_MarkerView_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.ringdroid']/class[@name='RingdroidEditActivity']/method[@name='markerEnter' and count(parameter)=1 and parameter[1][@type='com.ringdroid.MarkerView']]"
		[Register ("markerEnter", "(Lcom/ringdroid/MarkerView;)V", "GetMarkerEnter_Lcom_ringdroid_MarkerView_Handler")]
		public virtual unsafe void MarkerEnter (global::Com.Ringdroid.MarkerView p0)
		{
			if (id_markerEnter_Lcom_ringdroid_MarkerView_ == IntPtr.Zero)
				id_markerEnter_Lcom_ringdroid_MarkerView_ = JNIEnv.GetMethodID (class_ref, "markerEnter", "(Lcom/ringdroid/MarkerView;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_markerEnter_Lcom_ringdroid_MarkerView_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "markerEnter", "(Lcom/ringdroid/MarkerView;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_markerFocus_Lcom_ringdroid_MarkerView_;
#pragma warning disable 0169
		static Delegate GetMarkerFocus_Lcom_ringdroid_MarkerView_Handler ()
		{
			if (cb_markerFocus_Lcom_ringdroid_MarkerView_ == null)
				cb_markerFocus_Lcom_ringdroid_MarkerView_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_MarkerFocus_Lcom_ringdroid_MarkerView_);
			return cb_markerFocus_Lcom_ringdroid_MarkerView_;
		}

		static void n_MarkerFocus_Lcom_ringdroid_MarkerView_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Ringdroid.RingdroidEditActivity __this = global::Java.Lang.Object.GetObject<global::Com.Ringdroid.RingdroidEditActivity> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Ringdroid.MarkerView p0 = global::Java.Lang.Object.GetObject<global::Com.Ringdroid.MarkerView> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.MarkerFocus (p0);
		}
#pragma warning restore 0169

		static IntPtr id_markerFocus_Lcom_ringdroid_MarkerView_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.ringdroid']/class[@name='RingdroidEditActivity']/method[@name='markerFocus' and count(parameter)=1 and parameter[1][@type='com.ringdroid.MarkerView']]"
		[Register ("markerFocus", "(Lcom/ringdroid/MarkerView;)V", "GetMarkerFocus_Lcom_ringdroid_MarkerView_Handler")]
		public virtual unsafe void MarkerFocus (global::Com.Ringdroid.MarkerView p0)
		{
			if (id_markerFocus_Lcom_ringdroid_MarkerView_ == IntPtr.Zero)
				id_markerFocus_Lcom_ringdroid_MarkerView_ = JNIEnv.GetMethodID (class_ref, "markerFocus", "(Lcom/ringdroid/MarkerView;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_markerFocus_Lcom_ringdroid_MarkerView_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "markerFocus", "(Lcom/ringdroid/MarkerView;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_markerKeyUp;
#pragma warning disable 0169
		static Delegate GetMarkerKeyUpHandler ()
		{
			if (cb_markerKeyUp == null)
				cb_markerKeyUp = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_MarkerKeyUp);
			return cb_markerKeyUp;
		}

		static void n_MarkerKeyUp (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Ringdroid.RingdroidEditActivity __this = global::Java.Lang.Object.GetObject<global::Com.Ringdroid.RingdroidEditActivity> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.MarkerKeyUp ();
		}
#pragma warning restore 0169

		static IntPtr id_markerKeyUp;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.ringdroid']/class[@name='RingdroidEditActivity']/method[@name='markerKeyUp' and count(parameter)=0]"
		[Register ("markerKeyUp", "()V", "GetMarkerKeyUpHandler")]
		public virtual unsafe void MarkerKeyUp ()
		{
			if (id_markerKeyUp == IntPtr.Zero)
				id_markerKeyUp = JNIEnv.GetMethodID (class_ref, "markerKeyUp", "()V");
			try {

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_markerKeyUp);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "markerKeyUp", "()V"));
			} finally {
			}
		}

		static Delegate cb_markerLeft_Lcom_ringdroid_MarkerView_I;
#pragma warning disable 0169
		static Delegate GetMarkerLeft_Lcom_ringdroid_MarkerView_IHandler ()
		{
			if (cb_markerLeft_Lcom_ringdroid_MarkerView_I == null)
				cb_markerLeft_Lcom_ringdroid_MarkerView_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, int>) n_MarkerLeft_Lcom_ringdroid_MarkerView_I);
			return cb_markerLeft_Lcom_ringdroid_MarkerView_I;
		}

		static void n_MarkerLeft_Lcom_ringdroid_MarkerView_I (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1)
		{
			global::Com.Ringdroid.RingdroidEditActivity __this = global::Java.Lang.Object.GetObject<global::Com.Ringdroid.RingdroidEditActivity> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Ringdroid.MarkerView p0 = global::Java.Lang.Object.GetObject<global::Com.Ringdroid.MarkerView> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.MarkerLeft (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_markerLeft_Lcom_ringdroid_MarkerView_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.ringdroid']/class[@name='RingdroidEditActivity']/method[@name='markerLeft' and count(parameter)=2 and parameter[1][@type='com.ringdroid.MarkerView'] and parameter[2][@type='int']]"
		[Register ("markerLeft", "(Lcom/ringdroid/MarkerView;I)V", "GetMarkerLeft_Lcom_ringdroid_MarkerView_IHandler")]
		public virtual unsafe void MarkerLeft (global::Com.Ringdroid.MarkerView p0, int p1)
		{
			if (id_markerLeft_Lcom_ringdroid_MarkerView_I == IntPtr.Zero)
				id_markerLeft_Lcom_ringdroid_MarkerView_I = JNIEnv.GetMethodID (class_ref, "markerLeft", "(Lcom/ringdroid/MarkerView;I)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_markerLeft_Lcom_ringdroid_MarkerView_I, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "markerLeft", "(Lcom/ringdroid/MarkerView;I)V"), __args);
			} finally {
			}
		}

		static Delegate cb_markerRight_Lcom_ringdroid_MarkerView_I;
#pragma warning disable 0169
		static Delegate GetMarkerRight_Lcom_ringdroid_MarkerView_IHandler ()
		{
			if (cb_markerRight_Lcom_ringdroid_MarkerView_I == null)
				cb_markerRight_Lcom_ringdroid_MarkerView_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, int>) n_MarkerRight_Lcom_ringdroid_MarkerView_I);
			return cb_markerRight_Lcom_ringdroid_MarkerView_I;
		}

		static void n_MarkerRight_Lcom_ringdroid_MarkerView_I (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1)
		{
			global::Com.Ringdroid.RingdroidEditActivity __this = global::Java.Lang.Object.GetObject<global::Com.Ringdroid.RingdroidEditActivity> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Ringdroid.MarkerView p0 = global::Java.Lang.Object.GetObject<global::Com.Ringdroid.MarkerView> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.MarkerRight (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_markerRight_Lcom_ringdroid_MarkerView_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.ringdroid']/class[@name='RingdroidEditActivity']/method[@name='markerRight' and count(parameter)=2 and parameter[1][@type='com.ringdroid.MarkerView'] and parameter[2][@type='int']]"
		[Register ("markerRight", "(Lcom/ringdroid/MarkerView;I)V", "GetMarkerRight_Lcom_ringdroid_MarkerView_IHandler")]
		public virtual unsafe void MarkerRight (global::Com.Ringdroid.MarkerView p0, int p1)
		{
			if (id_markerRight_Lcom_ringdroid_MarkerView_I == IntPtr.Zero)
				id_markerRight_Lcom_ringdroid_MarkerView_I = JNIEnv.GetMethodID (class_ref, "markerRight", "(Lcom/ringdroid/MarkerView;I)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_markerRight_Lcom_ringdroid_MarkerView_I, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "markerRight", "(Lcom/ringdroid/MarkerView;I)V"), __args);
			} finally {
			}
		}

		static Delegate cb_markerTouchEnd_Lcom_ringdroid_MarkerView_;
#pragma warning disable 0169
		static Delegate GetMarkerTouchEnd_Lcom_ringdroid_MarkerView_Handler ()
		{
			if (cb_markerTouchEnd_Lcom_ringdroid_MarkerView_ == null)
				cb_markerTouchEnd_Lcom_ringdroid_MarkerView_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_MarkerTouchEnd_Lcom_ringdroid_MarkerView_);
			return cb_markerTouchEnd_Lcom_ringdroid_MarkerView_;
		}

		static void n_MarkerTouchEnd_Lcom_ringdroid_MarkerView_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Ringdroid.RingdroidEditActivity __this = global::Java.Lang.Object.GetObject<global::Com.Ringdroid.RingdroidEditActivity> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Ringdroid.MarkerView p0 = global::Java.Lang.Object.GetObject<global::Com.Ringdroid.MarkerView> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.MarkerTouchEnd (p0);
		}
#pragma warning restore 0169

		static IntPtr id_markerTouchEnd_Lcom_ringdroid_MarkerView_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.ringdroid']/class[@name='RingdroidEditActivity']/method[@name='markerTouchEnd' and count(parameter)=1 and parameter[1][@type='com.ringdroid.MarkerView']]"
		[Register ("markerTouchEnd", "(Lcom/ringdroid/MarkerView;)V", "GetMarkerTouchEnd_Lcom_ringdroid_MarkerView_Handler")]
		public virtual unsafe void MarkerTouchEnd (global::Com.Ringdroid.MarkerView p0)
		{
			if (id_markerTouchEnd_Lcom_ringdroid_MarkerView_ == IntPtr.Zero)
				id_markerTouchEnd_Lcom_ringdroid_MarkerView_ = JNIEnv.GetMethodID (class_ref, "markerTouchEnd", "(Lcom/ringdroid/MarkerView;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_markerTouchEnd_Lcom_ringdroid_MarkerView_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "markerTouchEnd", "(Lcom/ringdroid/MarkerView;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_markerTouchMove_Lcom_ringdroid_MarkerView_F;
#pragma warning disable 0169
		static Delegate GetMarkerTouchMove_Lcom_ringdroid_MarkerView_FHandler ()
		{
			if (cb_markerTouchMove_Lcom_ringdroid_MarkerView_F == null)
				cb_markerTouchMove_Lcom_ringdroid_MarkerView_F = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, float>) n_MarkerTouchMove_Lcom_ringdroid_MarkerView_F);
			return cb_markerTouchMove_Lcom_ringdroid_MarkerView_F;
		}

		static void n_MarkerTouchMove_Lcom_ringdroid_MarkerView_F (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, float p1)
		{
			global::Com.Ringdroid.RingdroidEditActivity __this = global::Java.Lang.Object.GetObject<global::Com.Ringdroid.RingdroidEditActivity> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Ringdroid.MarkerView p0 = global::Java.Lang.Object.GetObject<global::Com.Ringdroid.MarkerView> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.MarkerTouchMove (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_markerTouchMove_Lcom_ringdroid_MarkerView_F;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.ringdroid']/class[@name='RingdroidEditActivity']/method[@name='markerTouchMove' and count(parameter)=2 and parameter[1][@type='com.ringdroid.MarkerView'] and parameter[2][@type='float']]"
		[Register ("markerTouchMove", "(Lcom/ringdroid/MarkerView;F)V", "GetMarkerTouchMove_Lcom_ringdroid_MarkerView_FHandler")]
		public virtual unsafe void MarkerTouchMove (global::Com.Ringdroid.MarkerView p0, float p1)
		{
			if (id_markerTouchMove_Lcom_ringdroid_MarkerView_F == IntPtr.Zero)
				id_markerTouchMove_Lcom_ringdroid_MarkerView_F = JNIEnv.GetMethodID (class_ref, "markerTouchMove", "(Lcom/ringdroid/MarkerView;F)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_markerTouchMove_Lcom_ringdroid_MarkerView_F, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "markerTouchMove", "(Lcom/ringdroid/MarkerView;F)V"), __args);
			} finally {
			}
		}

		static Delegate cb_markerTouchStart_Lcom_ringdroid_MarkerView_F;
#pragma warning disable 0169
		static Delegate GetMarkerTouchStart_Lcom_ringdroid_MarkerView_FHandler ()
		{
			if (cb_markerTouchStart_Lcom_ringdroid_MarkerView_F == null)
				cb_markerTouchStart_Lcom_ringdroid_MarkerView_F = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, float>) n_MarkerTouchStart_Lcom_ringdroid_MarkerView_F);
			return cb_markerTouchStart_Lcom_ringdroid_MarkerView_F;
		}

		static void n_MarkerTouchStart_Lcom_ringdroid_MarkerView_F (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, float p1)
		{
			global::Com.Ringdroid.RingdroidEditActivity __this = global::Java.Lang.Object.GetObject<global::Com.Ringdroid.RingdroidEditActivity> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Ringdroid.MarkerView p0 = global::Java.Lang.Object.GetObject<global::Com.Ringdroid.MarkerView> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.MarkerTouchStart (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_markerTouchStart_Lcom_ringdroid_MarkerView_F;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.ringdroid']/class[@name='RingdroidEditActivity']/method[@name='markerTouchStart' and count(parameter)=2 and parameter[1][@type='com.ringdroid.MarkerView'] and parameter[2][@type='float']]"
		[Register ("markerTouchStart", "(Lcom/ringdroid/MarkerView;F)V", "GetMarkerTouchStart_Lcom_ringdroid_MarkerView_FHandler")]
		public virtual unsafe void MarkerTouchStart (global::Com.Ringdroid.MarkerView p0, float p1)
		{
			if (id_markerTouchStart_Lcom_ringdroid_MarkerView_F == IntPtr.Zero)
				id_markerTouchStart_Lcom_ringdroid_MarkerView_F = JNIEnv.GetMethodID (class_ref, "markerTouchStart", "(Lcom/ringdroid/MarkerView;F)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_markerTouchStart_Lcom_ringdroid_MarkerView_F, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "markerTouchStart", "(Lcom/ringdroid/MarkerView;F)V"), __args);
			} finally {
			}
		}

		static IntPtr id_onAbout_Landroid_app_Activity_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.ringdroid']/class[@name='RingdroidEditActivity']/method[@name='onAbout' and count(parameter)=1 and parameter[1][@type='android.app.Activity']]"
		[Register ("onAbout", "(Landroid/app/Activity;)V", "")]
		public static unsafe void OnAbout (global::Android.App.Activity p0)
		{
			if (id_onAbout_Landroid_app_Activity_ == IntPtr.Zero)
				id_onAbout_Landroid_app_Activity_ = JNIEnv.GetStaticMethodID (class_ref, "onAbout", "(Landroid/app/Activity;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_onAbout_Landroid_app_Activity_, __args);
			} finally {
			}
		}

		static Delegate cb_onCreate_Landroid_os_Bundle_;
#pragma warning disable 0169
		static Delegate GetOnCreate_Landroid_os_Bundle_Handler ()
		{
			if (cb_onCreate_Landroid_os_Bundle_ == null)
				cb_onCreate_Landroid_os_Bundle_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnCreate_Landroid_os_Bundle_);
			return cb_onCreate_Landroid_os_Bundle_;
		}

		static void n_OnCreate_Landroid_os_Bundle_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Ringdroid.RingdroidEditActivity __this = global::Java.Lang.Object.GetObject<global::Com.Ringdroid.RingdroidEditActivity> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.Bundle p0 = global::Java.Lang.Object.GetObject<global::Android.OS.Bundle> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnCreate (p0);
		}
#pragma warning restore 0169

		static IntPtr id_onCreate_Landroid_os_Bundle_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.ringdroid']/class[@name='RingdroidEditActivity']/method[@name='onCreate' and count(parameter)=1 and parameter[1][@type='android.os.Bundle']]"
		[Register ("onCreate", "(Landroid/os/Bundle;)V", "GetOnCreate_Landroid_os_Bundle_Handler")]
		public virtual unsafe void OnCreate (global::Android.OS.Bundle p0)
		{
			if (id_onCreate_Landroid_os_Bundle_ == IntPtr.Zero)
				id_onCreate_Landroid_os_Bundle_ = JNIEnv.GetMethodID (class_ref, "onCreate", "(Landroid/os/Bundle;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_onCreate_Landroid_os_Bundle_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onCreate", "(Landroid/os/Bundle;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_waveformDraw;
#pragma warning disable 0169
		static Delegate GetWaveformDrawHandler ()
		{
			if (cb_waveformDraw == null)
				cb_waveformDraw = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_WaveformDraw);
			return cb_waveformDraw;
		}

		static void n_WaveformDraw (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Ringdroid.RingdroidEditActivity __this = global::Java.Lang.Object.GetObject<global::Com.Ringdroid.RingdroidEditActivity> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.WaveformDraw ();
		}
#pragma warning restore 0169

		static IntPtr id_waveformDraw;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.ringdroid']/class[@name='RingdroidEditActivity']/method[@name='waveformDraw' and count(parameter)=0]"
		[Register ("waveformDraw", "()V", "GetWaveformDrawHandler")]
		public virtual unsafe void WaveformDraw ()
		{
			if (id_waveformDraw == IntPtr.Zero)
				id_waveformDraw = JNIEnv.GetMethodID (class_ref, "waveformDraw", "()V");
			try {

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_waveformDraw);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "waveformDraw", "()V"));
			} finally {
			}
		}

		static Delegate cb_waveformFling_F;
#pragma warning disable 0169
		static Delegate GetWaveformFling_FHandler ()
		{
			if (cb_waveformFling_F == null)
				cb_waveformFling_F = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, float>) n_WaveformFling_F);
			return cb_waveformFling_F;
		}

		static void n_WaveformFling_F (IntPtr jnienv, IntPtr native__this, float p0)
		{
			global::Com.Ringdroid.RingdroidEditActivity __this = global::Java.Lang.Object.GetObject<global::Com.Ringdroid.RingdroidEditActivity> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.WaveformFling (p0);
		}
#pragma warning restore 0169

		static IntPtr id_waveformFling_F;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.ringdroid']/class[@name='RingdroidEditActivity']/method[@name='waveformFling' and count(parameter)=1 and parameter[1][@type='float']]"
		[Register ("waveformFling", "(F)V", "GetWaveformFling_FHandler")]
		public virtual unsafe void WaveformFling (float p0)
		{
			if (id_waveformFling_F == IntPtr.Zero)
				id_waveformFling_F = JNIEnv.GetMethodID (class_ref, "waveformFling", "(F)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_waveformFling_F, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "waveformFling", "(F)V"), __args);
			} finally {
			}
		}

		static Delegate cb_waveformTouchEnd;
#pragma warning disable 0169
		static Delegate GetWaveformTouchEndHandler ()
		{
			if (cb_waveformTouchEnd == null)
				cb_waveformTouchEnd = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_WaveformTouchEnd);
			return cb_waveformTouchEnd;
		}

		static void n_WaveformTouchEnd (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Ringdroid.RingdroidEditActivity __this = global::Java.Lang.Object.GetObject<global::Com.Ringdroid.RingdroidEditActivity> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.WaveformTouchEnd ();
		}
#pragma warning restore 0169

		static IntPtr id_waveformTouchEnd;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.ringdroid']/class[@name='RingdroidEditActivity']/method[@name='waveformTouchEnd' and count(parameter)=0]"
		[Register ("waveformTouchEnd", "()V", "GetWaveformTouchEndHandler")]
		public virtual unsafe void WaveformTouchEnd ()
		{
			if (id_waveformTouchEnd == IntPtr.Zero)
				id_waveformTouchEnd = JNIEnv.GetMethodID (class_ref, "waveformTouchEnd", "()V");
			try {

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_waveformTouchEnd);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "waveformTouchEnd", "()V"));
			} finally {
			}
		}

		static Delegate cb_waveformTouchMove_F;
#pragma warning disable 0169
		static Delegate GetWaveformTouchMove_FHandler ()
		{
			if (cb_waveformTouchMove_F == null)
				cb_waveformTouchMove_F = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, float>) n_WaveformTouchMove_F);
			return cb_waveformTouchMove_F;
		}

		static void n_WaveformTouchMove_F (IntPtr jnienv, IntPtr native__this, float p0)
		{
			global::Com.Ringdroid.RingdroidEditActivity __this = global::Java.Lang.Object.GetObject<global::Com.Ringdroid.RingdroidEditActivity> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.WaveformTouchMove (p0);
		}
#pragma warning restore 0169

		static IntPtr id_waveformTouchMove_F;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.ringdroid']/class[@name='RingdroidEditActivity']/method[@name='waveformTouchMove' and count(parameter)=1 and parameter[1][@type='float']]"
		[Register ("waveformTouchMove", "(F)V", "GetWaveformTouchMove_FHandler")]
		public virtual unsafe void WaveformTouchMove (float p0)
		{
			if (id_waveformTouchMove_F == IntPtr.Zero)
				id_waveformTouchMove_F = JNIEnv.GetMethodID (class_ref, "waveformTouchMove", "(F)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_waveformTouchMove_F, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "waveformTouchMove", "(F)V"), __args);
			} finally {
			}
		}

		static Delegate cb_waveformTouchStart_F;
#pragma warning disable 0169
		static Delegate GetWaveformTouchStart_FHandler ()
		{
			if (cb_waveformTouchStart_F == null)
				cb_waveformTouchStart_F = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, float>) n_WaveformTouchStart_F);
			return cb_waveformTouchStart_F;
		}

		static void n_WaveformTouchStart_F (IntPtr jnienv, IntPtr native__this, float p0)
		{
			global::Com.Ringdroid.RingdroidEditActivity __this = global::Java.Lang.Object.GetObject<global::Com.Ringdroid.RingdroidEditActivity> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.WaveformTouchStart (p0);
		}
#pragma warning restore 0169

		static IntPtr id_waveformTouchStart_F;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.ringdroid']/class[@name='RingdroidEditActivity']/method[@name='waveformTouchStart' and count(parameter)=1 and parameter[1][@type='float']]"
		[Register ("waveformTouchStart", "(F)V", "GetWaveformTouchStart_FHandler")]
		public virtual unsafe void WaveformTouchStart (float p0)
		{
			if (id_waveformTouchStart_F == IntPtr.Zero)
				id_waveformTouchStart_F = JNIEnv.GetMethodID (class_ref, "waveformTouchStart", "(F)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_waveformTouchStart_F, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "waveformTouchStart", "(F)V"), __args);
			} finally {
			}
		}

		static Delegate cb_waveformZoomIn;
#pragma warning disable 0169
		static Delegate GetWaveformZoomInHandler ()
		{
			if (cb_waveformZoomIn == null)
				cb_waveformZoomIn = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_WaveformZoomIn);
			return cb_waveformZoomIn;
		}

		static void n_WaveformZoomIn (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Ringdroid.RingdroidEditActivity __this = global::Java.Lang.Object.GetObject<global::Com.Ringdroid.RingdroidEditActivity> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.WaveformZoomIn ();
		}
#pragma warning restore 0169

		static IntPtr id_waveformZoomIn;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.ringdroid']/class[@name='RingdroidEditActivity']/method[@name='waveformZoomIn' and count(parameter)=0]"
		[Register ("waveformZoomIn", "()V", "GetWaveformZoomInHandler")]
		public virtual unsafe void WaveformZoomIn ()
		{
			if (id_waveformZoomIn == IntPtr.Zero)
				id_waveformZoomIn = JNIEnv.GetMethodID (class_ref, "waveformZoomIn", "()V");
			try {

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_waveformZoomIn);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "waveformZoomIn", "()V"));
			} finally {
			}
		}

		static Delegate cb_waveformZoomOut;
#pragma warning disable 0169
		static Delegate GetWaveformZoomOutHandler ()
		{
			if (cb_waveformZoomOut == null)
				cb_waveformZoomOut = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_WaveformZoomOut);
			return cb_waveformZoomOut;
		}

		static void n_WaveformZoomOut (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Ringdroid.RingdroidEditActivity __this = global::Java.Lang.Object.GetObject<global::Com.Ringdroid.RingdroidEditActivity> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.WaveformZoomOut ();
		}
#pragma warning restore 0169

		static IntPtr id_waveformZoomOut;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.ringdroid']/class[@name='RingdroidEditActivity']/method[@name='waveformZoomOut' and count(parameter)=0]"
		[Register ("waveformZoomOut", "()V", "GetWaveformZoomOutHandler")]
		public virtual unsafe void WaveformZoomOut ()
		{
			if (id_waveformZoomOut == IntPtr.Zero)
				id_waveformZoomOut = JNIEnv.GetMethodID (class_ref, "waveformZoomOut", "()V");
			try {

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_waveformZoomOut);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "waveformZoomOut", "()V"));
			} finally {
			}
		}

	}
}
