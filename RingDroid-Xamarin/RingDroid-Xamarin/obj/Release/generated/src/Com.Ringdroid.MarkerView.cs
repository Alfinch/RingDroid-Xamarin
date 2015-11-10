using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Ringdroid {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.ringdroid']/class[@name='MarkerView']"
	[global::Android.Runtime.Register ("com/ringdroid/MarkerView", DoNotGenerateAcw=true)]
	public partial class MarkerView : global::Android.Widget.ImageView {

		// Metadata.xml XPath interface reference: path="/api/package[@name='com.ringdroid']/interface[@name='MarkerView.MarkerListener']"
		[Register ("com/ringdroid/MarkerView$MarkerListener", "", "Com.Ringdroid.MarkerView/IMarkerListenerInvoker")]
		public partial interface IMarkerListener : IJavaObject {

			// Metadata.xml XPath method reference: path="/api/package[@name='com.ringdroid']/interface[@name='MarkerView.MarkerListener']/method[@name='markerDraw' and count(parameter)=0]"
			[Register ("markerDraw", "()V", "GetMarkerDrawHandler:Com.Ringdroid.MarkerView/IMarkerListenerInvoker, RingDroid-Xamarin")]
			void MarkerDraw ();

			// Metadata.xml XPath method reference: path="/api/package[@name='com.ringdroid']/interface[@name='MarkerView.MarkerListener']/method[@name='markerEnter' and count(parameter)=1 and parameter[1][@type='com.ringdroid.MarkerView']]"
			[Register ("markerEnter", "(Lcom/ringdroid/MarkerView;)V", "GetMarkerEnter_Lcom_ringdroid_MarkerView_Handler:Com.Ringdroid.MarkerView/IMarkerListenerInvoker, RingDroid-Xamarin")]
			void MarkerEnter (global::Com.Ringdroid.MarkerView p0);

			// Metadata.xml XPath method reference: path="/api/package[@name='com.ringdroid']/interface[@name='MarkerView.MarkerListener']/method[@name='markerFocus' and count(parameter)=1 and parameter[1][@type='com.ringdroid.MarkerView']]"
			[Register ("markerFocus", "(Lcom/ringdroid/MarkerView;)V", "GetMarkerFocus_Lcom_ringdroid_MarkerView_Handler:Com.Ringdroid.MarkerView/IMarkerListenerInvoker, RingDroid-Xamarin")]
			void MarkerFocus (global::Com.Ringdroid.MarkerView p0);

			// Metadata.xml XPath method reference: path="/api/package[@name='com.ringdroid']/interface[@name='MarkerView.MarkerListener']/method[@name='markerKeyUp' and count(parameter)=0]"
			[Register ("markerKeyUp", "()V", "GetMarkerKeyUpHandler:Com.Ringdroid.MarkerView/IMarkerListenerInvoker, RingDroid-Xamarin")]
			void MarkerKeyUp ();

			// Metadata.xml XPath method reference: path="/api/package[@name='com.ringdroid']/interface[@name='MarkerView.MarkerListener']/method[@name='markerLeft' and count(parameter)=2 and parameter[1][@type='com.ringdroid.MarkerView'] and parameter[2][@type='int']]"
			[Register ("markerLeft", "(Lcom/ringdroid/MarkerView;I)V", "GetMarkerLeft_Lcom_ringdroid_MarkerView_IHandler:Com.Ringdroid.MarkerView/IMarkerListenerInvoker, RingDroid-Xamarin")]
			void MarkerLeft (global::Com.Ringdroid.MarkerView p0, int p1);

			// Metadata.xml XPath method reference: path="/api/package[@name='com.ringdroid']/interface[@name='MarkerView.MarkerListener']/method[@name='markerRight' and count(parameter)=2 and parameter[1][@type='com.ringdroid.MarkerView'] and parameter[2][@type='int']]"
			[Register ("markerRight", "(Lcom/ringdroid/MarkerView;I)V", "GetMarkerRight_Lcom_ringdroid_MarkerView_IHandler:Com.Ringdroid.MarkerView/IMarkerListenerInvoker, RingDroid-Xamarin")]
			void MarkerRight (global::Com.Ringdroid.MarkerView p0, int p1);

			// Metadata.xml XPath method reference: path="/api/package[@name='com.ringdroid']/interface[@name='MarkerView.MarkerListener']/method[@name='markerTouchEnd' and count(parameter)=1 and parameter[1][@type='com.ringdroid.MarkerView']]"
			[Register ("markerTouchEnd", "(Lcom/ringdroid/MarkerView;)V", "GetMarkerTouchEnd_Lcom_ringdroid_MarkerView_Handler:Com.Ringdroid.MarkerView/IMarkerListenerInvoker, RingDroid-Xamarin")]
			void MarkerTouchEnd (global::Com.Ringdroid.MarkerView p0);

			// Metadata.xml XPath method reference: path="/api/package[@name='com.ringdroid']/interface[@name='MarkerView.MarkerListener']/method[@name='markerTouchMove' and count(parameter)=2 and parameter[1][@type='com.ringdroid.MarkerView'] and parameter[2][@type='float']]"
			[Register ("markerTouchMove", "(Lcom/ringdroid/MarkerView;F)V", "GetMarkerTouchMove_Lcom_ringdroid_MarkerView_FHandler:Com.Ringdroid.MarkerView/IMarkerListenerInvoker, RingDroid-Xamarin")]
			void MarkerTouchMove (global::Com.Ringdroid.MarkerView p0, float p1);

			// Metadata.xml XPath method reference: path="/api/package[@name='com.ringdroid']/interface[@name='MarkerView.MarkerListener']/method[@name='markerTouchStart' and count(parameter)=2 and parameter[1][@type='com.ringdroid.MarkerView'] and parameter[2][@type='float']]"
			[Register ("markerTouchStart", "(Lcom/ringdroid/MarkerView;F)V", "GetMarkerTouchStart_Lcom_ringdroid_MarkerView_FHandler:Com.Ringdroid.MarkerView/IMarkerListenerInvoker, RingDroid-Xamarin")]
			void MarkerTouchStart (global::Com.Ringdroid.MarkerView p0, float p1);

		}

		[global::Android.Runtime.Register ("com/ringdroid/MarkerView$MarkerListener", DoNotGenerateAcw=true)]
		internal class IMarkerListenerInvoker : global::Java.Lang.Object, IMarkerListener {

			static IntPtr java_class_ref = JNIEnv.FindClass ("com/ringdroid/MarkerView$MarkerListener");
			IntPtr class_ref;

			public static IMarkerListener GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<IMarkerListener> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "com.ringdroid.MarkerView.MarkerListener"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public IMarkerListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (IMarkerListenerInvoker); }
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
				global::Com.Ringdroid.MarkerView.IMarkerListener __this = global::Java.Lang.Object.GetObject<global::Com.Ringdroid.MarkerView.IMarkerListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.MarkerDraw ();
			}
#pragma warning restore 0169

			IntPtr id_markerDraw;
			public unsafe void MarkerDraw ()
			{
				if (id_markerDraw == IntPtr.Zero)
					id_markerDraw = JNIEnv.GetMethodID (class_ref, "markerDraw", "()V");
				JNIEnv.CallVoidMethod (Handle, id_markerDraw);
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
				global::Com.Ringdroid.MarkerView.IMarkerListener __this = global::Java.Lang.Object.GetObject<global::Com.Ringdroid.MarkerView.IMarkerListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Com.Ringdroid.MarkerView p0 = global::Java.Lang.Object.GetObject<global::Com.Ringdroid.MarkerView> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.MarkerEnter (p0);
			}
#pragma warning restore 0169

			IntPtr id_markerEnter_Lcom_ringdroid_MarkerView_;
			public unsafe void MarkerEnter (global::Com.Ringdroid.MarkerView p0)
			{
				if (id_markerEnter_Lcom_ringdroid_MarkerView_ == IntPtr.Zero)
					id_markerEnter_Lcom_ringdroid_MarkerView_ = JNIEnv.GetMethodID (class_ref, "markerEnter", "(Lcom/ringdroid/MarkerView;)V");
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallVoidMethod (Handle, id_markerEnter_Lcom_ringdroid_MarkerView_, __args);
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
				global::Com.Ringdroid.MarkerView.IMarkerListener __this = global::Java.Lang.Object.GetObject<global::Com.Ringdroid.MarkerView.IMarkerListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Com.Ringdroid.MarkerView p0 = global::Java.Lang.Object.GetObject<global::Com.Ringdroid.MarkerView> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.MarkerFocus (p0);
			}
#pragma warning restore 0169

			IntPtr id_markerFocus_Lcom_ringdroid_MarkerView_;
			public unsafe void MarkerFocus (global::Com.Ringdroid.MarkerView p0)
			{
				if (id_markerFocus_Lcom_ringdroid_MarkerView_ == IntPtr.Zero)
					id_markerFocus_Lcom_ringdroid_MarkerView_ = JNIEnv.GetMethodID (class_ref, "markerFocus", "(Lcom/ringdroid/MarkerView;)V");
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallVoidMethod (Handle, id_markerFocus_Lcom_ringdroid_MarkerView_, __args);
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
				global::Com.Ringdroid.MarkerView.IMarkerListener __this = global::Java.Lang.Object.GetObject<global::Com.Ringdroid.MarkerView.IMarkerListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.MarkerKeyUp ();
			}
#pragma warning restore 0169

			IntPtr id_markerKeyUp;
			public unsafe void MarkerKeyUp ()
			{
				if (id_markerKeyUp == IntPtr.Zero)
					id_markerKeyUp = JNIEnv.GetMethodID (class_ref, "markerKeyUp", "()V");
				JNIEnv.CallVoidMethod (Handle, id_markerKeyUp);
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
				global::Com.Ringdroid.MarkerView.IMarkerListener __this = global::Java.Lang.Object.GetObject<global::Com.Ringdroid.MarkerView.IMarkerListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Com.Ringdroid.MarkerView p0 = global::Java.Lang.Object.GetObject<global::Com.Ringdroid.MarkerView> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.MarkerLeft (p0, p1);
			}
#pragma warning restore 0169

			IntPtr id_markerLeft_Lcom_ringdroid_MarkerView_I;
			public unsafe void MarkerLeft (global::Com.Ringdroid.MarkerView p0, int p1)
			{
				if (id_markerLeft_Lcom_ringdroid_MarkerView_I == IntPtr.Zero)
					id_markerLeft_Lcom_ringdroid_MarkerView_I = JNIEnv.GetMethodID (class_ref, "markerLeft", "(Lcom/ringdroid/MarkerView;I)V");
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				JNIEnv.CallVoidMethod (Handle, id_markerLeft_Lcom_ringdroid_MarkerView_I, __args);
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
				global::Com.Ringdroid.MarkerView.IMarkerListener __this = global::Java.Lang.Object.GetObject<global::Com.Ringdroid.MarkerView.IMarkerListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Com.Ringdroid.MarkerView p0 = global::Java.Lang.Object.GetObject<global::Com.Ringdroid.MarkerView> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.MarkerRight (p0, p1);
			}
#pragma warning restore 0169

			IntPtr id_markerRight_Lcom_ringdroid_MarkerView_I;
			public unsafe void MarkerRight (global::Com.Ringdroid.MarkerView p0, int p1)
			{
				if (id_markerRight_Lcom_ringdroid_MarkerView_I == IntPtr.Zero)
					id_markerRight_Lcom_ringdroid_MarkerView_I = JNIEnv.GetMethodID (class_ref, "markerRight", "(Lcom/ringdroid/MarkerView;I)V");
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				JNIEnv.CallVoidMethod (Handle, id_markerRight_Lcom_ringdroid_MarkerView_I, __args);
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
				global::Com.Ringdroid.MarkerView.IMarkerListener __this = global::Java.Lang.Object.GetObject<global::Com.Ringdroid.MarkerView.IMarkerListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Com.Ringdroid.MarkerView p0 = global::Java.Lang.Object.GetObject<global::Com.Ringdroid.MarkerView> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.MarkerTouchEnd (p0);
			}
#pragma warning restore 0169

			IntPtr id_markerTouchEnd_Lcom_ringdroid_MarkerView_;
			public unsafe void MarkerTouchEnd (global::Com.Ringdroid.MarkerView p0)
			{
				if (id_markerTouchEnd_Lcom_ringdroid_MarkerView_ == IntPtr.Zero)
					id_markerTouchEnd_Lcom_ringdroid_MarkerView_ = JNIEnv.GetMethodID (class_ref, "markerTouchEnd", "(Lcom/ringdroid/MarkerView;)V");
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallVoidMethod (Handle, id_markerTouchEnd_Lcom_ringdroid_MarkerView_, __args);
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
				global::Com.Ringdroid.MarkerView.IMarkerListener __this = global::Java.Lang.Object.GetObject<global::Com.Ringdroid.MarkerView.IMarkerListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Com.Ringdroid.MarkerView p0 = global::Java.Lang.Object.GetObject<global::Com.Ringdroid.MarkerView> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.MarkerTouchMove (p0, p1);
			}
#pragma warning restore 0169

			IntPtr id_markerTouchMove_Lcom_ringdroid_MarkerView_F;
			public unsafe void MarkerTouchMove (global::Com.Ringdroid.MarkerView p0, float p1)
			{
				if (id_markerTouchMove_Lcom_ringdroid_MarkerView_F == IntPtr.Zero)
					id_markerTouchMove_Lcom_ringdroid_MarkerView_F = JNIEnv.GetMethodID (class_ref, "markerTouchMove", "(Lcom/ringdroid/MarkerView;F)V");
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				JNIEnv.CallVoidMethod (Handle, id_markerTouchMove_Lcom_ringdroid_MarkerView_F, __args);
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
				global::Com.Ringdroid.MarkerView.IMarkerListener __this = global::Java.Lang.Object.GetObject<global::Com.Ringdroid.MarkerView.IMarkerListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Com.Ringdroid.MarkerView p0 = global::Java.Lang.Object.GetObject<global::Com.Ringdroid.MarkerView> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.MarkerTouchStart (p0, p1);
			}
#pragma warning restore 0169

			IntPtr id_markerTouchStart_Lcom_ringdroid_MarkerView_F;
			public unsafe void MarkerTouchStart (global::Com.Ringdroid.MarkerView p0, float p1)
			{
				if (id_markerTouchStart_Lcom_ringdroid_MarkerView_F == IntPtr.Zero)
					id_markerTouchStart_Lcom_ringdroid_MarkerView_F = JNIEnv.GetMethodID (class_ref, "markerTouchStart", "(Lcom/ringdroid/MarkerView;F)V");
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				JNIEnv.CallVoidMethod (Handle, id_markerTouchStart_Lcom_ringdroid_MarkerView_F, __args);
			}

		}

		public partial class MarkerEnterEventArgs : global::System.EventArgs {

			public MarkerEnterEventArgs (global::Com.Ringdroid.MarkerView p0)
			{
				this.p0 = p0;
			}

			global::Com.Ringdroid.MarkerView p0;
			public global::Com.Ringdroid.MarkerView P0 {
				get { return p0; }
			}
		}

		public partial class MarkerFocusEventArgs : global::System.EventArgs {

			public MarkerFocusEventArgs (global::Com.Ringdroid.MarkerView p0)
			{
				this.p0 = p0;
			}

			global::Com.Ringdroid.MarkerView p0;
			public global::Com.Ringdroid.MarkerView P0 {
				get { return p0; }
			}
		}

		public partial class MarkerLeftEventArgs : global::System.EventArgs {

			public MarkerLeftEventArgs (global::Com.Ringdroid.MarkerView p0, int p1)
			{
				this.p0 = p0;
				this.p1 = p1;
			}

			global::Com.Ringdroid.MarkerView p0;
			public global::Com.Ringdroid.MarkerView P0 {
				get { return p0; }
			}

			int p1;
			public int P1 {
				get { return p1; }
			}
		}

		public partial class MarkerRightEventArgs : global::System.EventArgs {

			public MarkerRightEventArgs (global::Com.Ringdroid.MarkerView p0, int p1)
			{
				this.p0 = p0;
				this.p1 = p1;
			}

			global::Com.Ringdroid.MarkerView p0;
			public global::Com.Ringdroid.MarkerView P0 {
				get { return p0; }
			}

			int p1;
			public int P1 {
				get { return p1; }
			}
		}

		public partial class MarkerTouchEndEventArgs : global::System.EventArgs {

			public MarkerTouchEndEventArgs (global::Com.Ringdroid.MarkerView p0)
			{
				this.p0 = p0;
			}

			global::Com.Ringdroid.MarkerView p0;
			public global::Com.Ringdroid.MarkerView P0 {
				get { return p0; }
			}
		}

		public partial class MarkerTouchMoveEventArgs : global::System.EventArgs {

			public MarkerTouchMoveEventArgs (global::Com.Ringdroid.MarkerView p0, float p1)
			{
				this.p0 = p0;
				this.p1 = p1;
			}

			global::Com.Ringdroid.MarkerView p0;
			public global::Com.Ringdroid.MarkerView P0 {
				get { return p0; }
			}

			float p1;
			public float P1 {
				get { return p1; }
			}
		}

		public partial class MarkerTouchStartEventArgs : global::System.EventArgs {

			public MarkerTouchStartEventArgs (global::Com.Ringdroid.MarkerView p0, float p1)
			{
				this.p0 = p0;
				this.p1 = p1;
			}

			global::Com.Ringdroid.MarkerView p0;
			public global::Com.Ringdroid.MarkerView P0 {
				get { return p0; }
			}

			float p1;
			public float P1 {
				get { return p1; }
			}
		}

		[global::Android.Runtime.Register ("mono/com/ringdroid/MarkerView_MarkerListenerImplementor")]
		internal sealed partial class IMarkerListenerImplementor : global::Java.Lang.Object, IMarkerListener {

			object sender;

			public IMarkerListenerImplementor (object sender)
				: base (
					global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/com/ringdroid/MarkerView_MarkerListenerImplementor", "()V"),
					JniHandleOwnership.TransferLocalRef)
			{
				global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "()V");
				this.sender = sender;
			}

#pragma warning disable 0649
			public EventHandler MarkerDrawHandler;
#pragma warning restore 0649

			public void MarkerDraw ()
			{
				var __h = MarkerDrawHandler;
				if (__h != null)
					__h (sender, new EventArgs ());
			}
#pragma warning disable 0649
			public EventHandler<MarkerEnterEventArgs> MarkerEnterHandler;
#pragma warning restore 0649

			public void MarkerEnter (global::Com.Ringdroid.MarkerView p0)
			{
				var __h = MarkerEnterHandler;
				if (__h != null)
					__h (sender, new MarkerEnterEventArgs (p0));
			}
#pragma warning disable 0649
			public EventHandler<MarkerFocusEventArgs> MarkerFocusHandler;
#pragma warning restore 0649

			public void MarkerFocus (global::Com.Ringdroid.MarkerView p0)
			{
				var __h = MarkerFocusHandler;
				if (__h != null)
					__h (sender, new MarkerFocusEventArgs (p0));
			}
#pragma warning disable 0649
			public EventHandler MarkerKeyUpHandler;
#pragma warning restore 0649

			public void MarkerKeyUp ()
			{
				var __h = MarkerKeyUpHandler;
				if (__h != null)
					__h (sender, new EventArgs ());
			}
#pragma warning disable 0649
			public EventHandler<MarkerLeftEventArgs> MarkerLeftHandler;
#pragma warning restore 0649

			public void MarkerLeft (global::Com.Ringdroid.MarkerView p0, int p1)
			{
				var __h = MarkerLeftHandler;
				if (__h != null)
					__h (sender, new MarkerLeftEventArgs (p0, p1));
			}
#pragma warning disable 0649
			public EventHandler<MarkerRightEventArgs> MarkerRightHandler;
#pragma warning restore 0649

			public void MarkerRight (global::Com.Ringdroid.MarkerView p0, int p1)
			{
				var __h = MarkerRightHandler;
				if (__h != null)
					__h (sender, new MarkerRightEventArgs (p0, p1));
			}
#pragma warning disable 0649
			public EventHandler<MarkerTouchEndEventArgs> MarkerTouchEndHandler;
#pragma warning restore 0649

			public void MarkerTouchEnd (global::Com.Ringdroid.MarkerView p0)
			{
				var __h = MarkerTouchEndHandler;
				if (__h != null)
					__h (sender, new MarkerTouchEndEventArgs (p0));
			}
#pragma warning disable 0649
			public EventHandler<MarkerTouchMoveEventArgs> MarkerTouchMoveHandler;
#pragma warning restore 0649

			public void MarkerTouchMove (global::Com.Ringdroid.MarkerView p0, float p1)
			{
				var __h = MarkerTouchMoveHandler;
				if (__h != null)
					__h (sender, new MarkerTouchMoveEventArgs (p0, p1));
			}
#pragma warning disable 0649
			public EventHandler<MarkerTouchStartEventArgs> MarkerTouchStartHandler;
#pragma warning restore 0649

			public void MarkerTouchStart (global::Com.Ringdroid.MarkerView p0, float p1)
			{
				var __h = MarkerTouchStartHandler;
				if (__h != null)
					__h (sender, new MarkerTouchStartEventArgs (p0, p1));
			}

			internal static bool __IsEmpty (IMarkerListenerImplementor value)
			{
				return value.MarkerDrawHandler == null && value.MarkerEnterHandler == null && value.MarkerFocusHandler == null && value.MarkerKeyUpHandler == null && value.MarkerLeftHandler == null && value.MarkerRightHandler == null && value.MarkerTouchEndHandler == null && value.MarkerTouchMoveHandler == null && value.MarkerTouchStartHandler == null;
			}
		}


		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/ringdroid/MarkerView", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (MarkerView); }
		}

		protected MarkerView (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.ringdroid']/class[@name='MarkerView']/constructor[@name='MarkerView' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='android.util.AttributeSet']]"
		[Register (".ctor", "(Landroid/content/Context;Landroid/util/AttributeSet;)V", "")]
		public unsafe MarkerView (global::Android.Content.Context p0, global::Android.Util.IAttributeSet p1)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				if (GetType () != typeof (MarkerView)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Landroid/content/Context;Landroid/util/AttributeSet;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Landroid/content/Context;Landroid/util/AttributeSet;)V", __args);
					return;
				}

				if (id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_ == IntPtr.Zero)
					id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_, __args);
			} finally {
			}
		}

		static Delegate cb_setListener_Lcom_ringdroid_MarkerView_MarkerListener_;
#pragma warning disable 0169
		static Delegate GetSetListener_Lcom_ringdroid_MarkerView_MarkerListener_Handler ()
		{
			if (cb_setListener_Lcom_ringdroid_MarkerView_MarkerListener_ == null)
				cb_setListener_Lcom_ringdroid_MarkerView_MarkerListener_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetListener_Lcom_ringdroid_MarkerView_MarkerListener_);
			return cb_setListener_Lcom_ringdroid_MarkerView_MarkerListener_;
		}

		static void n_SetListener_Lcom_ringdroid_MarkerView_MarkerListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Ringdroid.MarkerView __this = global::Java.Lang.Object.GetObject<global::Com.Ringdroid.MarkerView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Ringdroid.MarkerView.IMarkerListener p0 = (global::Com.Ringdroid.MarkerView.IMarkerListener)global::Java.Lang.Object.GetObject<global::Com.Ringdroid.MarkerView.IMarkerListener> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetListener (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setListener_Lcom_ringdroid_MarkerView_MarkerListener_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.ringdroid']/class[@name='MarkerView']/method[@name='setListener' and count(parameter)=1 and parameter[1][@type='com.ringdroid.MarkerView.MarkerListener']]"
		[Register ("setListener", "(Lcom/ringdroid/MarkerView$MarkerListener;)V", "GetSetListener_Lcom_ringdroid_MarkerView_MarkerListener_Handler")]
		public virtual unsafe void SetListener (global::Com.Ringdroid.MarkerView.IMarkerListener p0)
		{
			if (id_setListener_Lcom_ringdroid_MarkerView_MarkerListener_ == IntPtr.Zero)
				id_setListener_Lcom_ringdroid_MarkerView_MarkerListener_ = JNIEnv.GetMethodID (class_ref, "setListener", "(Lcom/ringdroid/MarkerView$MarkerListener;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setListener_Lcom_ringdroid_MarkerView_MarkerListener_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setListener", "(Lcom/ringdroid/MarkerView$MarkerListener;)V"), __args);
			} finally {
			}
		}

#region "Event implementation for Com.Ringdroid.MarkerView.IMarkerListener"

		global::Com.Ringdroid.MarkerView.IMarkerListenerImplementor __CreateIMarkerListenerImplementor ()
		{
			return new global::Com.Ringdroid.MarkerView.IMarkerListenerImplementor (this);
		}
#endregion
	}
}
