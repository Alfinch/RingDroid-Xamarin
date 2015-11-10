using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Ringdroid {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.ringdroid']/class[@name='WaveformView']"
	[global::Android.Runtime.Register ("com/ringdroid/WaveformView", DoNotGenerateAcw=true)]
	public partial class WaveformView : global::Android.Views.View {

		// Metadata.xml XPath interface reference: path="/api/package[@name='com.ringdroid']/interface[@name='WaveformView.WaveformListener']"
		[Register ("com/ringdroid/WaveformView$WaveformListener", "", "Com.Ringdroid.WaveformView/IWaveformListenerInvoker")]
		public partial interface IWaveformListener : IJavaObject {

			// Metadata.xml XPath method reference: path="/api/package[@name='com.ringdroid']/interface[@name='WaveformView.WaveformListener']/method[@name='waveformDraw' and count(parameter)=0]"
			[Register ("waveformDraw", "()V", "GetWaveformDrawHandler:Com.Ringdroid.WaveformView/IWaveformListenerInvoker, RingDroid-Xamarin")]
			void WaveformDraw ();

			// Metadata.xml XPath method reference: path="/api/package[@name='com.ringdroid']/interface[@name='WaveformView.WaveformListener']/method[@name='waveformFling' and count(parameter)=1 and parameter[1][@type='float']]"
			[Register ("waveformFling", "(F)V", "GetWaveformFling_FHandler:Com.Ringdroid.WaveformView/IWaveformListenerInvoker, RingDroid-Xamarin")]
			void WaveformFling (float p0);

			// Metadata.xml XPath method reference: path="/api/package[@name='com.ringdroid']/interface[@name='WaveformView.WaveformListener']/method[@name='waveformTouchEnd' and count(parameter)=0]"
			[Register ("waveformTouchEnd", "()V", "GetWaveformTouchEndHandler:Com.Ringdroid.WaveformView/IWaveformListenerInvoker, RingDroid-Xamarin")]
			void WaveformTouchEnd ();

			// Metadata.xml XPath method reference: path="/api/package[@name='com.ringdroid']/interface[@name='WaveformView.WaveformListener']/method[@name='waveformTouchMove' and count(parameter)=1 and parameter[1][@type='float']]"
			[Register ("waveformTouchMove", "(F)V", "GetWaveformTouchMove_FHandler:Com.Ringdroid.WaveformView/IWaveformListenerInvoker, RingDroid-Xamarin")]
			void WaveformTouchMove (float p0);

			// Metadata.xml XPath method reference: path="/api/package[@name='com.ringdroid']/interface[@name='WaveformView.WaveformListener']/method[@name='waveformTouchStart' and count(parameter)=1 and parameter[1][@type='float']]"
			[Register ("waveformTouchStart", "(F)V", "GetWaveformTouchStart_FHandler:Com.Ringdroid.WaveformView/IWaveformListenerInvoker, RingDroid-Xamarin")]
			void WaveformTouchStart (float p0);

			// Metadata.xml XPath method reference: path="/api/package[@name='com.ringdroid']/interface[@name='WaveformView.WaveformListener']/method[@name='waveformZoomIn' and count(parameter)=0]"
			[Register ("waveformZoomIn", "()V", "GetWaveformZoomInHandler:Com.Ringdroid.WaveformView/IWaveformListenerInvoker, RingDroid-Xamarin")]
			void WaveformZoomIn ();

			// Metadata.xml XPath method reference: path="/api/package[@name='com.ringdroid']/interface[@name='WaveformView.WaveformListener']/method[@name='waveformZoomOut' and count(parameter)=0]"
			[Register ("waveformZoomOut", "()V", "GetWaveformZoomOutHandler:Com.Ringdroid.WaveformView/IWaveformListenerInvoker, RingDroid-Xamarin")]
			void WaveformZoomOut ();

		}

		[global::Android.Runtime.Register ("com/ringdroid/WaveformView$WaveformListener", DoNotGenerateAcw=true)]
		internal class IWaveformListenerInvoker : global::Java.Lang.Object, IWaveformListener {

			static IntPtr java_class_ref = JNIEnv.FindClass ("com/ringdroid/WaveformView$WaveformListener");
			IntPtr class_ref;

			public static IWaveformListener GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<IWaveformListener> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "com.ringdroid.WaveformView.WaveformListener"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public IWaveformListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (IWaveformListenerInvoker); }
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
				global::Com.Ringdroid.WaveformView.IWaveformListener __this = global::Java.Lang.Object.GetObject<global::Com.Ringdroid.WaveformView.IWaveformListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.WaveformDraw ();
			}
#pragma warning restore 0169

			IntPtr id_waveformDraw;
			public unsafe void WaveformDraw ()
			{
				if (id_waveformDraw == IntPtr.Zero)
					id_waveformDraw = JNIEnv.GetMethodID (class_ref, "waveformDraw", "()V");
				JNIEnv.CallVoidMethod (Handle, id_waveformDraw);
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
				global::Com.Ringdroid.WaveformView.IWaveformListener __this = global::Java.Lang.Object.GetObject<global::Com.Ringdroid.WaveformView.IWaveformListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.WaveformFling (p0);
			}
#pragma warning restore 0169

			IntPtr id_waveformFling_F;
			public unsafe void WaveformFling (float p0)
			{
				if (id_waveformFling_F == IntPtr.Zero)
					id_waveformFling_F = JNIEnv.GetMethodID (class_ref, "waveformFling", "(F)V");
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallVoidMethod (Handle, id_waveformFling_F, __args);
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
				global::Com.Ringdroid.WaveformView.IWaveformListener __this = global::Java.Lang.Object.GetObject<global::Com.Ringdroid.WaveformView.IWaveformListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.WaveformTouchEnd ();
			}
#pragma warning restore 0169

			IntPtr id_waveformTouchEnd;
			public unsafe void WaveformTouchEnd ()
			{
				if (id_waveformTouchEnd == IntPtr.Zero)
					id_waveformTouchEnd = JNIEnv.GetMethodID (class_ref, "waveformTouchEnd", "()V");
				JNIEnv.CallVoidMethod (Handle, id_waveformTouchEnd);
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
				global::Com.Ringdroid.WaveformView.IWaveformListener __this = global::Java.Lang.Object.GetObject<global::Com.Ringdroid.WaveformView.IWaveformListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.WaveformTouchMove (p0);
			}
#pragma warning restore 0169

			IntPtr id_waveformTouchMove_F;
			public unsafe void WaveformTouchMove (float p0)
			{
				if (id_waveformTouchMove_F == IntPtr.Zero)
					id_waveformTouchMove_F = JNIEnv.GetMethodID (class_ref, "waveformTouchMove", "(F)V");
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallVoidMethod (Handle, id_waveformTouchMove_F, __args);
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
				global::Com.Ringdroid.WaveformView.IWaveformListener __this = global::Java.Lang.Object.GetObject<global::Com.Ringdroid.WaveformView.IWaveformListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.WaveformTouchStart (p0);
			}
#pragma warning restore 0169

			IntPtr id_waveformTouchStart_F;
			public unsafe void WaveformTouchStart (float p0)
			{
				if (id_waveformTouchStart_F == IntPtr.Zero)
					id_waveformTouchStart_F = JNIEnv.GetMethodID (class_ref, "waveformTouchStart", "(F)V");
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallVoidMethod (Handle, id_waveformTouchStart_F, __args);
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
				global::Com.Ringdroid.WaveformView.IWaveformListener __this = global::Java.Lang.Object.GetObject<global::Com.Ringdroid.WaveformView.IWaveformListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.WaveformZoomIn ();
			}
#pragma warning restore 0169

			IntPtr id_waveformZoomIn;
			public unsafe void WaveformZoomIn ()
			{
				if (id_waveformZoomIn == IntPtr.Zero)
					id_waveformZoomIn = JNIEnv.GetMethodID (class_ref, "waveformZoomIn", "()V");
				JNIEnv.CallVoidMethod (Handle, id_waveformZoomIn);
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
				global::Com.Ringdroid.WaveformView.IWaveformListener __this = global::Java.Lang.Object.GetObject<global::Com.Ringdroid.WaveformView.IWaveformListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.WaveformZoomOut ();
			}
#pragma warning restore 0169

			IntPtr id_waveformZoomOut;
			public unsafe void WaveformZoomOut ()
			{
				if (id_waveformZoomOut == IntPtr.Zero)
					id_waveformZoomOut = JNIEnv.GetMethodID (class_ref, "waveformZoomOut", "()V");
				JNIEnv.CallVoidMethod (Handle, id_waveformZoomOut);
			}

		}

		public partial class WaveformFlingEventArgs : global::System.EventArgs {

			public WaveformFlingEventArgs (float p0)
			{
				this.p0 = p0;
			}

			float p0;
			public float P0 {
				get { return p0; }
			}
		}

		public partial class WaveformTouchMoveEventArgs : global::System.EventArgs {

			public WaveformTouchMoveEventArgs (float p0)
			{
				this.p0 = p0;
			}

			float p0;
			public float P0 {
				get { return p0; }
			}
		}

		public partial class WaveformTouchStartEventArgs : global::System.EventArgs {

			public WaveformTouchStartEventArgs (float p0)
			{
				this.p0 = p0;
			}

			float p0;
			public float P0 {
				get { return p0; }
			}
		}

		[global::Android.Runtime.Register ("mono/com/ringdroid/WaveformView_WaveformListenerImplementor")]
		internal sealed partial class IWaveformListenerImplementor : global::Java.Lang.Object, IWaveformListener {

			object sender;

			public IWaveformListenerImplementor (object sender)
				: base (
					global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/com/ringdroid/WaveformView_WaveformListenerImplementor", "()V"),
					JniHandleOwnership.TransferLocalRef)
			{
				global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "()V");
				this.sender = sender;
			}

#pragma warning disable 0649
			public EventHandler WaveformDrawHandler;
#pragma warning restore 0649

			public void WaveformDraw ()
			{
				var __h = WaveformDrawHandler;
				if (__h != null)
					__h (sender, new EventArgs ());
			}
#pragma warning disable 0649
			public EventHandler<WaveformFlingEventArgs> WaveformFlingHandler;
#pragma warning restore 0649

			public void WaveformFling (float p0)
			{
				var __h = WaveformFlingHandler;
				if (__h != null)
					__h (sender, new WaveformFlingEventArgs (p0));
			}
#pragma warning disable 0649
			public EventHandler WaveformTouchEndHandler;
#pragma warning restore 0649

			public void WaveformTouchEnd ()
			{
				var __h = WaveformTouchEndHandler;
				if (__h != null)
					__h (sender, new EventArgs ());
			}
#pragma warning disable 0649
			public EventHandler<WaveformTouchMoveEventArgs> WaveformTouchMoveHandler;
#pragma warning restore 0649

			public void WaveformTouchMove (float p0)
			{
				var __h = WaveformTouchMoveHandler;
				if (__h != null)
					__h (sender, new WaveformTouchMoveEventArgs (p0));
			}
#pragma warning disable 0649
			public EventHandler<WaveformTouchStartEventArgs> WaveformTouchStartHandler;
#pragma warning restore 0649

			public void WaveformTouchStart (float p0)
			{
				var __h = WaveformTouchStartHandler;
				if (__h != null)
					__h (sender, new WaveformTouchStartEventArgs (p0));
			}
#pragma warning disable 0649
			public EventHandler WaveformZoomInHandler;
#pragma warning restore 0649

			public void WaveformZoomIn ()
			{
				var __h = WaveformZoomInHandler;
				if (__h != null)
					__h (sender, new EventArgs ());
			}
#pragma warning disable 0649
			public EventHandler WaveformZoomOutHandler;
#pragma warning restore 0649

			public void WaveformZoomOut ()
			{
				var __h = WaveformZoomOutHandler;
				if (__h != null)
					__h (sender, new EventArgs ());
			}

			internal static bool __IsEmpty (IWaveformListenerImplementor value)
			{
				return value.WaveformDrawHandler == null && value.WaveformFlingHandler == null && value.WaveformTouchEndHandler == null && value.WaveformTouchMoveHandler == null && value.WaveformTouchStartHandler == null && value.WaveformZoomInHandler == null && value.WaveformZoomOutHandler == null;
			}
		}


		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/ringdroid/WaveformView", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (WaveformView); }
		}

		protected WaveformView (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.ringdroid']/class[@name='WaveformView']/constructor[@name='WaveformView' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='android.util.AttributeSet']]"
		[Register (".ctor", "(Landroid/content/Context;Landroid/util/AttributeSet;)V", "")]
		public unsafe WaveformView (global::Android.Content.Context p0, global::Android.Util.IAttributeSet p1)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				if (GetType () != typeof (WaveformView)) {
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

		static Delegate cb_getEnd;
#pragma warning disable 0169
		static Delegate GetGetEndHandler ()
		{
			if (cb_getEnd == null)
				cb_getEnd = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetEnd);
			return cb_getEnd;
		}

		static int n_GetEnd (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Ringdroid.WaveformView __this = global::Java.Lang.Object.GetObject<global::Com.Ringdroid.WaveformView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.End;
		}
#pragma warning restore 0169

		static IntPtr id_getEnd;
		public virtual unsafe int End {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ringdroid']/class[@name='WaveformView']/method[@name='getEnd' and count(parameter)=0]"
			[Register ("getEnd", "()I", "GetGetEndHandler")]
			get {
				if (id_getEnd == IntPtr.Zero)
					id_getEnd = JNIEnv.GetMethodID (class_ref, "getEnd", "()I");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallIntMethod  (Handle, id_getEnd);
					else
						return JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getEnd", "()I"));
				} finally {
				}
			}
		}

		static Delegate cb_hasSoundFile;
#pragma warning disable 0169
		static Delegate GetHasSoundFileHandler ()
		{
			if (cb_hasSoundFile == null)
				cb_hasSoundFile = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_HasSoundFile);
			return cb_hasSoundFile;
		}

		static bool n_HasSoundFile (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Ringdroid.WaveformView __this = global::Java.Lang.Object.GetObject<global::Com.Ringdroid.WaveformView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.HasSoundFile;
		}
#pragma warning restore 0169

		static IntPtr id_hasSoundFile;
		public virtual unsafe bool HasSoundFile {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ringdroid']/class[@name='WaveformView']/method[@name='hasSoundFile' and count(parameter)=0]"
			[Register ("hasSoundFile", "()Z", "GetHasSoundFileHandler")]
			get {
				if (id_hasSoundFile == IntPtr.Zero)
					id_hasSoundFile = JNIEnv.GetMethodID (class_ref, "hasSoundFile", "()Z");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod  (Handle, id_hasSoundFile);
					else
						return JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "hasSoundFile", "()Z"));
				} finally {
				}
			}
		}

		static Delegate cb_isInitialized;
#pragma warning disable 0169
		static Delegate GetIsInitializedHandler ()
		{
			if (cb_isInitialized == null)
				cb_isInitialized = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsInitialized);
			return cb_isInitialized;
		}

		static bool n_IsInitialized (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Ringdroid.WaveformView __this = global::Java.Lang.Object.GetObject<global::Com.Ringdroid.WaveformView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsInitialized;
		}
#pragma warning restore 0169

		static IntPtr id_isInitialized;
		public virtual unsafe bool IsInitialized {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ringdroid']/class[@name='WaveformView']/method[@name='isInitialized' and count(parameter)=0]"
			[Register ("isInitialized", "()Z", "GetIsInitializedHandler")]
			get {
				if (id_isInitialized == IntPtr.Zero)
					id_isInitialized = JNIEnv.GetMethodID (class_ref, "isInitialized", "()Z");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod  (Handle, id_isInitialized);
					else
						return JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isInitialized", "()Z"));
				} finally {
				}
			}
		}

		static Delegate cb_getOffset;
#pragma warning disable 0169
		static Delegate GetGetOffsetHandler ()
		{
			if (cb_getOffset == null)
				cb_getOffset = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetOffset);
			return cb_getOffset;
		}

		static int n_GetOffset (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Ringdroid.WaveformView __this = global::Java.Lang.Object.GetObject<global::Com.Ringdroid.WaveformView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Offset;
		}
#pragma warning restore 0169

		static IntPtr id_getOffset;
		public virtual unsafe int Offset {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ringdroid']/class[@name='WaveformView']/method[@name='getOffset' and count(parameter)=0]"
			[Register ("getOffset", "()I", "GetGetOffsetHandler")]
			get {
				if (id_getOffset == IntPtr.Zero)
					id_getOffset = JNIEnv.GetMethodID (class_ref, "getOffset", "()I");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallIntMethod  (Handle, id_getOffset);
					else
						return JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getOffset", "()I"));
				} finally {
				}
			}
		}

		static Delegate cb_getStart;
#pragma warning disable 0169
		static Delegate GetGetStartHandler ()
		{
			if (cb_getStart == null)
				cb_getStart = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetStart);
			return cb_getStart;
		}

		static int n_GetStart (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Ringdroid.WaveformView __this = global::Java.Lang.Object.GetObject<global::Com.Ringdroid.WaveformView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Start;
		}
#pragma warning restore 0169

		static IntPtr id_getStart;
		public virtual unsafe int Start {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ringdroid']/class[@name='WaveformView']/method[@name='getStart' and count(parameter)=0]"
			[Register ("getStart", "()I", "GetGetStartHandler")]
			get {
				if (id_getStart == IntPtr.Zero)
					id_getStart = JNIEnv.GetMethodID (class_ref, "getStart", "()I");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallIntMethod  (Handle, id_getStart);
					else
						return JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getStart", "()I"));
				} finally {
				}
			}
		}

		static Delegate cb_getZoomLevel;
#pragma warning disable 0169
		static Delegate GetGetZoomLevelHandler ()
		{
			if (cb_getZoomLevel == null)
				cb_getZoomLevel = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetZoomLevel);
			return cb_getZoomLevel;
		}

		static int n_GetZoomLevel (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Ringdroid.WaveformView __this = global::Java.Lang.Object.GetObject<global::Com.Ringdroid.WaveformView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ZoomLevel;
		}
#pragma warning restore 0169

		static Delegate cb_setZoomLevel_I;
#pragma warning disable 0169
		static Delegate GetSetZoomLevel_IHandler ()
		{
			if (cb_setZoomLevel_I == null)
				cb_setZoomLevel_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetZoomLevel_I);
			return cb_setZoomLevel_I;
		}

		static void n_SetZoomLevel_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Ringdroid.WaveformView __this = global::Java.Lang.Object.GetObject<global::Com.Ringdroid.WaveformView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ZoomLevel = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getZoomLevel;
		static IntPtr id_setZoomLevel_I;
		public virtual unsafe int ZoomLevel {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ringdroid']/class[@name='WaveformView']/method[@name='getZoomLevel' and count(parameter)=0]"
			[Register ("getZoomLevel", "()I", "GetGetZoomLevelHandler")]
			get {
				if (id_getZoomLevel == IntPtr.Zero)
					id_getZoomLevel = JNIEnv.GetMethodID (class_ref, "getZoomLevel", "()I");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallIntMethod  (Handle, id_getZoomLevel);
					else
						return JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getZoomLevel", "()I"));
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ringdroid']/class[@name='WaveformView']/method[@name='setZoomLevel' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setZoomLevel", "(I)V", "GetSetZoomLevel_IHandler")]
			set {
				if (id_setZoomLevel_I == IntPtr.Zero)
					id_setZoomLevel_I = JNIEnv.GetMethodID (class_ref, "setZoomLevel", "(I)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_setZoomLevel_I, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setZoomLevel", "(I)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_canZoomIn;
#pragma warning disable 0169
		static Delegate GetCanZoomInHandler ()
		{
			if (cb_canZoomIn == null)
				cb_canZoomIn = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_CanZoomIn);
			return cb_canZoomIn;
		}

		static bool n_CanZoomIn (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Ringdroid.WaveformView __this = global::Java.Lang.Object.GetObject<global::Com.Ringdroid.WaveformView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.CanZoomIn ();
		}
#pragma warning restore 0169

		static IntPtr id_canZoomIn;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.ringdroid']/class[@name='WaveformView']/method[@name='canZoomIn' and count(parameter)=0]"
		[Register ("canZoomIn", "()Z", "GetCanZoomInHandler")]
		public virtual unsafe bool CanZoomIn ()
		{
			if (id_canZoomIn == IntPtr.Zero)
				id_canZoomIn = JNIEnv.GetMethodID (class_ref, "canZoomIn", "()Z");
			try {

				if (GetType () == ThresholdType)
					return JNIEnv.CallBooleanMethod  (Handle, id_canZoomIn);
				else
					return JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "canZoomIn", "()Z"));
			} finally {
			}
		}

		static Delegate cb_canZoomOut;
#pragma warning disable 0169
		static Delegate GetCanZoomOutHandler ()
		{
			if (cb_canZoomOut == null)
				cb_canZoomOut = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_CanZoomOut);
			return cb_canZoomOut;
		}

		static bool n_CanZoomOut (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Ringdroid.WaveformView __this = global::Java.Lang.Object.GetObject<global::Com.Ringdroid.WaveformView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.CanZoomOut ();
		}
#pragma warning restore 0169

		static IntPtr id_canZoomOut;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.ringdroid']/class[@name='WaveformView']/method[@name='canZoomOut' and count(parameter)=0]"
		[Register ("canZoomOut", "()Z", "GetCanZoomOutHandler")]
		public virtual unsafe bool CanZoomOut ()
		{
			if (id_canZoomOut == IntPtr.Zero)
				id_canZoomOut = JNIEnv.GetMethodID (class_ref, "canZoomOut", "()Z");
			try {

				if (GetType () == ThresholdType)
					return JNIEnv.CallBooleanMethod  (Handle, id_canZoomOut);
				else
					return JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "canZoomOut", "()Z"));
			} finally {
			}
		}

		static Delegate cb_drawWaveformLine_Landroid_graphics_Canvas_IIILandroid_graphics_Paint_;
#pragma warning disable 0169
		static Delegate GetDrawWaveformLine_Landroid_graphics_Canvas_IIILandroid_graphics_Paint_Handler ()
		{
			if (cb_drawWaveformLine_Landroid_graphics_Canvas_IIILandroid_graphics_Paint_ == null)
				cb_drawWaveformLine_Landroid_graphics_Canvas_IIILandroid_graphics_Paint_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, int, int, int, IntPtr>) n_DrawWaveformLine_Landroid_graphics_Canvas_IIILandroid_graphics_Paint_);
			return cb_drawWaveformLine_Landroid_graphics_Canvas_IIILandroid_graphics_Paint_;
		}

		static void n_DrawWaveformLine_Landroid_graphics_Canvas_IIILandroid_graphics_Paint_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1, int p2, int p3, IntPtr native_p4)
		{
			global::Com.Ringdroid.WaveformView __this = global::Java.Lang.Object.GetObject<global::Com.Ringdroid.WaveformView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Graphics.Canvas p0 = global::Java.Lang.Object.GetObject<global::Android.Graphics.Canvas> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Android.Graphics.Paint p4 = global::Java.Lang.Object.GetObject<global::Android.Graphics.Paint> (native_p4, JniHandleOwnership.DoNotTransfer);
			__this.DrawWaveformLine (p0, p1, p2, p3, p4);
		}
#pragma warning restore 0169

		static IntPtr id_drawWaveformLine_Landroid_graphics_Canvas_IIILandroid_graphics_Paint_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.ringdroid']/class[@name='WaveformView']/method[@name='drawWaveformLine' and count(parameter)=5 and parameter[1][@type='android.graphics.Canvas'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='int'] and parameter[5][@type='android.graphics.Paint']]"
		[Register ("drawWaveformLine", "(Landroid/graphics/Canvas;IIILandroid/graphics/Paint;)V", "GetDrawWaveformLine_Landroid_graphics_Canvas_IIILandroid_graphics_Paint_Handler")]
		protected virtual unsafe void DrawWaveformLine (global::Android.Graphics.Canvas p0, int p1, int p2, int p3, global::Android.Graphics.Paint p4)
		{
			if (id_drawWaveformLine_Landroid_graphics_Canvas_IIILandroid_graphics_Paint_ == IntPtr.Zero)
				id_drawWaveformLine_Landroid_graphics_Canvas_IIILandroid_graphics_Paint_ = JNIEnv.GetMethodID (class_ref, "drawWaveformLine", "(Landroid/graphics/Canvas;IIILandroid/graphics/Paint;)V");
			try {
				JValue* __args = stackalloc JValue [5];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				__args [4] = new JValue (p4);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_drawWaveformLine_Landroid_graphics_Canvas_IIILandroid_graphics_Paint_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "drawWaveformLine", "(Landroid/graphics/Canvas;IIILandroid/graphics/Paint;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_maxPos;
#pragma warning disable 0169
		static Delegate GetMaxPosHandler ()
		{
			if (cb_maxPos == null)
				cb_maxPos = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_MaxPos);
			return cb_maxPos;
		}

		static int n_MaxPos (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Ringdroid.WaveformView __this = global::Java.Lang.Object.GetObject<global::Com.Ringdroid.WaveformView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.MaxPos ();
		}
#pragma warning restore 0169

		static IntPtr id_maxPos;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.ringdroid']/class[@name='WaveformView']/method[@name='maxPos' and count(parameter)=0]"
		[Register ("maxPos", "()I", "GetMaxPosHandler")]
		public virtual unsafe int MaxPos ()
		{
			if (id_maxPos == IntPtr.Zero)
				id_maxPos = JNIEnv.GetMethodID (class_ref, "maxPos", "()I");
			try {

				if (GetType () == ThresholdType)
					return JNIEnv.CallIntMethod  (Handle, id_maxPos);
				else
					return JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "maxPos", "()I"));
			} finally {
			}
		}

		static Delegate cb_millisecsToPixels_I;
#pragma warning disable 0169
		static Delegate GetMillisecsToPixels_IHandler ()
		{
			if (cb_millisecsToPixels_I == null)
				cb_millisecsToPixels_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, int>) n_MillisecsToPixels_I);
			return cb_millisecsToPixels_I;
		}

		static int n_MillisecsToPixels_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Ringdroid.WaveformView __this = global::Java.Lang.Object.GetObject<global::Com.Ringdroid.WaveformView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.MillisecsToPixels (p0);
		}
#pragma warning restore 0169

		static IntPtr id_millisecsToPixels_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.ringdroid']/class[@name='WaveformView']/method[@name='millisecsToPixels' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("millisecsToPixels", "(I)I", "GetMillisecsToPixels_IHandler")]
		public virtual unsafe int MillisecsToPixels (int p0)
		{
			if (id_millisecsToPixels_I == IntPtr.Zero)
				id_millisecsToPixels_I = JNIEnv.GetMethodID (class_ref, "millisecsToPixels", "(I)I");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					return JNIEnv.CallIntMethod  (Handle, id_millisecsToPixels_I, __args);
				else
					return JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "millisecsToPixels", "(I)I"), __args);
			} finally {
			}
		}

		static Delegate cb_pixelsToMillisecs_I;
#pragma warning disable 0169
		static Delegate GetPixelsToMillisecs_IHandler ()
		{
			if (cb_pixelsToMillisecs_I == null)
				cb_pixelsToMillisecs_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, int>) n_PixelsToMillisecs_I);
			return cb_pixelsToMillisecs_I;
		}

		static int n_PixelsToMillisecs_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Ringdroid.WaveformView __this = global::Java.Lang.Object.GetObject<global::Com.Ringdroid.WaveformView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.PixelsToMillisecs (p0);
		}
#pragma warning restore 0169

		static IntPtr id_pixelsToMillisecs_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.ringdroid']/class[@name='WaveformView']/method[@name='pixelsToMillisecs' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("pixelsToMillisecs", "(I)I", "GetPixelsToMillisecs_IHandler")]
		public virtual unsafe int PixelsToMillisecs (int p0)
		{
			if (id_pixelsToMillisecs_I == IntPtr.Zero)
				id_pixelsToMillisecs_I = JNIEnv.GetMethodID (class_ref, "pixelsToMillisecs", "(I)I");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					return JNIEnv.CallIntMethod  (Handle, id_pixelsToMillisecs_I, __args);
				else
					return JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "pixelsToMillisecs", "(I)I"), __args);
			} finally {
			}
		}

		static Delegate cb_pixelsToSeconds_I;
#pragma warning disable 0169
		static Delegate GetPixelsToSeconds_IHandler ()
		{
			if (cb_pixelsToSeconds_I == null)
				cb_pixelsToSeconds_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, double>) n_PixelsToSeconds_I);
			return cb_pixelsToSeconds_I;
		}

		static double n_PixelsToSeconds_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Ringdroid.WaveformView __this = global::Java.Lang.Object.GetObject<global::Com.Ringdroid.WaveformView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.PixelsToSeconds (p0);
		}
#pragma warning restore 0169

		static IntPtr id_pixelsToSeconds_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.ringdroid']/class[@name='WaveformView']/method[@name='pixelsToSeconds' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("pixelsToSeconds", "(I)D", "GetPixelsToSeconds_IHandler")]
		public virtual unsafe double PixelsToSeconds (int p0)
		{
			if (id_pixelsToSeconds_I == IntPtr.Zero)
				id_pixelsToSeconds_I = JNIEnv.GetMethodID (class_ref, "pixelsToSeconds", "(I)D");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					return JNIEnv.CallDoubleMethod  (Handle, id_pixelsToSeconds_I, __args);
				else
					return JNIEnv.CallNonvirtualDoubleMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "pixelsToSeconds", "(I)D"), __args);
			} finally {
			}
		}

		static Delegate cb_recomputeHeights_F;
#pragma warning disable 0169
		static Delegate GetRecomputeHeights_FHandler ()
		{
			if (cb_recomputeHeights_F == null)
				cb_recomputeHeights_F = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, float>) n_RecomputeHeights_F);
			return cb_recomputeHeights_F;
		}

		static void n_RecomputeHeights_F (IntPtr jnienv, IntPtr native__this, float p0)
		{
			global::Com.Ringdroid.WaveformView __this = global::Java.Lang.Object.GetObject<global::Com.Ringdroid.WaveformView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.RecomputeHeights (p0);
		}
#pragma warning restore 0169

		static IntPtr id_recomputeHeights_F;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.ringdroid']/class[@name='WaveformView']/method[@name='recomputeHeights' and count(parameter)=1 and parameter[1][@type='float']]"
		[Register ("recomputeHeights", "(F)V", "GetRecomputeHeights_FHandler")]
		public virtual unsafe void RecomputeHeights (float p0)
		{
			if (id_recomputeHeights_F == IntPtr.Zero)
				id_recomputeHeights_F = JNIEnv.GetMethodID (class_ref, "recomputeHeights", "(F)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_recomputeHeights_F, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "recomputeHeights", "(F)V"), __args);
			} finally {
			}
		}

		static Delegate cb_secondsToFrames_D;
#pragma warning disable 0169
		static Delegate GetSecondsToFrames_DHandler ()
		{
			if (cb_secondsToFrames_D == null)
				cb_secondsToFrames_D = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, double, int>) n_SecondsToFrames_D);
			return cb_secondsToFrames_D;
		}

		static int n_SecondsToFrames_D (IntPtr jnienv, IntPtr native__this, double p0)
		{
			global::Com.Ringdroid.WaveformView __this = global::Java.Lang.Object.GetObject<global::Com.Ringdroid.WaveformView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.SecondsToFrames (p0);
		}
#pragma warning restore 0169

		static IntPtr id_secondsToFrames_D;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.ringdroid']/class[@name='WaveformView']/method[@name='secondsToFrames' and count(parameter)=1 and parameter[1][@type='double']]"
		[Register ("secondsToFrames", "(D)I", "GetSecondsToFrames_DHandler")]
		public virtual unsafe int SecondsToFrames (double p0)
		{
			if (id_secondsToFrames_D == IntPtr.Zero)
				id_secondsToFrames_D = JNIEnv.GetMethodID (class_ref, "secondsToFrames", "(D)I");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					return JNIEnv.CallIntMethod  (Handle, id_secondsToFrames_D, __args);
				else
					return JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "secondsToFrames", "(D)I"), __args);
			} finally {
			}
		}

		static Delegate cb_secondsToPixels_D;
#pragma warning disable 0169
		static Delegate GetSecondsToPixels_DHandler ()
		{
			if (cb_secondsToPixels_D == null)
				cb_secondsToPixels_D = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, double, int>) n_SecondsToPixels_D);
			return cb_secondsToPixels_D;
		}

		static int n_SecondsToPixels_D (IntPtr jnienv, IntPtr native__this, double p0)
		{
			global::Com.Ringdroid.WaveformView __this = global::Java.Lang.Object.GetObject<global::Com.Ringdroid.WaveformView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.SecondsToPixels (p0);
		}
#pragma warning restore 0169

		static IntPtr id_secondsToPixels_D;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.ringdroid']/class[@name='WaveformView']/method[@name='secondsToPixels' and count(parameter)=1 and parameter[1][@type='double']]"
		[Register ("secondsToPixels", "(D)I", "GetSecondsToPixels_DHandler")]
		public virtual unsafe int SecondsToPixels (double p0)
		{
			if (id_secondsToPixels_D == IntPtr.Zero)
				id_secondsToPixels_D = JNIEnv.GetMethodID (class_ref, "secondsToPixels", "(D)I");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					return JNIEnv.CallIntMethod  (Handle, id_secondsToPixels_D, __args);
				else
					return JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "secondsToPixels", "(D)I"), __args);
			} finally {
			}
		}

		static Delegate cb_setListener_Lcom_ringdroid_WaveformView_WaveformListener_;
#pragma warning disable 0169
		static Delegate GetSetListener_Lcom_ringdroid_WaveformView_WaveformListener_Handler ()
		{
			if (cb_setListener_Lcom_ringdroid_WaveformView_WaveformListener_ == null)
				cb_setListener_Lcom_ringdroid_WaveformView_WaveformListener_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetListener_Lcom_ringdroid_WaveformView_WaveformListener_);
			return cb_setListener_Lcom_ringdroid_WaveformView_WaveformListener_;
		}

		static void n_SetListener_Lcom_ringdroid_WaveformView_WaveformListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Ringdroid.WaveformView __this = global::Java.Lang.Object.GetObject<global::Com.Ringdroid.WaveformView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Ringdroid.WaveformView.IWaveformListener p0 = (global::Com.Ringdroid.WaveformView.IWaveformListener)global::Java.Lang.Object.GetObject<global::Com.Ringdroid.WaveformView.IWaveformListener> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetListener (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setListener_Lcom_ringdroid_WaveformView_WaveformListener_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.ringdroid']/class[@name='WaveformView']/method[@name='setListener' and count(parameter)=1 and parameter[1][@type='com.ringdroid.WaveformView.WaveformListener']]"
		[Register ("setListener", "(Lcom/ringdroid/WaveformView$WaveformListener;)V", "GetSetListener_Lcom_ringdroid_WaveformView_WaveformListener_Handler")]
		public virtual unsafe void SetListener (global::Com.Ringdroid.WaveformView.IWaveformListener p0)
		{
			if (id_setListener_Lcom_ringdroid_WaveformView_WaveformListener_ == IntPtr.Zero)
				id_setListener_Lcom_ringdroid_WaveformView_WaveformListener_ = JNIEnv.GetMethodID (class_ref, "setListener", "(Lcom/ringdroid/WaveformView$WaveformListener;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setListener_Lcom_ringdroid_WaveformView_WaveformListener_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setListener", "(Lcom/ringdroid/WaveformView$WaveformListener;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_setParameters_III;
#pragma warning disable 0169
		static Delegate GetSetParameters_IIIHandler ()
		{
			if (cb_setParameters_III == null)
				cb_setParameters_III = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int, int, int>) n_SetParameters_III);
			return cb_setParameters_III;
		}

		static void n_SetParameters_III (IntPtr jnienv, IntPtr native__this, int p0, int p1, int p2)
		{
			global::Com.Ringdroid.WaveformView __this = global::Java.Lang.Object.GetObject<global::Com.Ringdroid.WaveformView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetParameters (p0, p1, p2);
		}
#pragma warning restore 0169

		static IntPtr id_setParameters_III;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.ringdroid']/class[@name='WaveformView']/method[@name='setParameters' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
		[Register ("setParameters", "(III)V", "GetSetParameters_IIIHandler")]
		public virtual unsafe void SetParameters (int p0, int p1, int p2)
		{
			if (id_setParameters_III == IntPtr.Zero)
				id_setParameters_III = JNIEnv.GetMethodID (class_ref, "setParameters", "(III)V");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setParameters_III, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setParameters", "(III)V"), __args);
			} finally {
			}
		}

		static Delegate cb_setPlayback_I;
#pragma warning disable 0169
		static Delegate GetSetPlayback_IHandler ()
		{
			if (cb_setPlayback_I == null)
				cb_setPlayback_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetPlayback_I);
			return cb_setPlayback_I;
		}

		static void n_SetPlayback_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Ringdroid.WaveformView __this = global::Java.Lang.Object.GetObject<global::Com.Ringdroid.WaveformView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetPlayback (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setPlayback_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.ringdroid']/class[@name='WaveformView']/method[@name='setPlayback' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setPlayback", "(I)V", "GetSetPlayback_IHandler")]
		public virtual unsafe void SetPlayback (int p0)
		{
			if (id_setPlayback_I == IntPtr.Zero)
				id_setPlayback_I = JNIEnv.GetMethodID (class_ref, "setPlayback", "(I)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setPlayback_I, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setPlayback", "(I)V"), __args);
			} finally {
			}
		}

		static Delegate cb_setSoundFile_Lcom_ringdroid_soundfile_SoundFile_;
#pragma warning disable 0169
		static Delegate GetSetSoundFile_Lcom_ringdroid_soundfile_SoundFile_Handler ()
		{
			if (cb_setSoundFile_Lcom_ringdroid_soundfile_SoundFile_ == null)
				cb_setSoundFile_Lcom_ringdroid_soundfile_SoundFile_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetSoundFile_Lcom_ringdroid_soundfile_SoundFile_);
			return cb_setSoundFile_Lcom_ringdroid_soundfile_SoundFile_;
		}

		static void n_SetSoundFile_Lcom_ringdroid_soundfile_SoundFile_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Ringdroid.WaveformView __this = global::Java.Lang.Object.GetObject<global::Com.Ringdroid.WaveformView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Ringdroid.Soundfile.SoundFile p0 = global::Java.Lang.Object.GetObject<global::Com.Ringdroid.Soundfile.SoundFile> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetSoundFile (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setSoundFile_Lcom_ringdroid_soundfile_SoundFile_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.ringdroid']/class[@name='WaveformView']/method[@name='setSoundFile' and count(parameter)=1 and parameter[1][@type='com.ringdroid.soundfile.SoundFile']]"
		[Register ("setSoundFile", "(Lcom/ringdroid/soundfile/SoundFile;)V", "GetSetSoundFile_Lcom_ringdroid_soundfile_SoundFile_Handler")]
		public virtual unsafe void SetSoundFile (global::Com.Ringdroid.Soundfile.SoundFile p0)
		{
			if (id_setSoundFile_Lcom_ringdroid_soundfile_SoundFile_ == IntPtr.Zero)
				id_setSoundFile_Lcom_ringdroid_soundfile_SoundFile_ = JNIEnv.GetMethodID (class_ref, "setSoundFile", "(Lcom/ringdroid/soundfile/SoundFile;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setSoundFile_Lcom_ringdroid_soundfile_SoundFile_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setSoundFile", "(Lcom/ringdroid/soundfile/SoundFile;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_zoomIn;
#pragma warning disable 0169
		static Delegate GetZoomInHandler ()
		{
			if (cb_zoomIn == null)
				cb_zoomIn = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_ZoomIn);
			return cb_zoomIn;
		}

		static void n_ZoomIn (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Ringdroid.WaveformView __this = global::Java.Lang.Object.GetObject<global::Com.Ringdroid.WaveformView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ZoomIn ();
		}
#pragma warning restore 0169

		static IntPtr id_zoomIn;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.ringdroid']/class[@name='WaveformView']/method[@name='zoomIn' and count(parameter)=0]"
		[Register ("zoomIn", "()V", "GetZoomInHandler")]
		public virtual unsafe void ZoomIn ()
		{
			if (id_zoomIn == IntPtr.Zero)
				id_zoomIn = JNIEnv.GetMethodID (class_ref, "zoomIn", "()V");
			try {

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_zoomIn);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "zoomIn", "()V"));
			} finally {
			}
		}

		static Delegate cb_zoomOut;
#pragma warning disable 0169
		static Delegate GetZoomOutHandler ()
		{
			if (cb_zoomOut == null)
				cb_zoomOut = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_ZoomOut);
			return cb_zoomOut;
		}

		static void n_ZoomOut (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Ringdroid.WaveformView __this = global::Java.Lang.Object.GetObject<global::Com.Ringdroid.WaveformView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ZoomOut ();
		}
#pragma warning restore 0169

		static IntPtr id_zoomOut;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.ringdroid']/class[@name='WaveformView']/method[@name='zoomOut' and count(parameter)=0]"
		[Register ("zoomOut", "()V", "GetZoomOutHandler")]
		public virtual unsafe void ZoomOut ()
		{
			if (id_zoomOut == IntPtr.Zero)
				id_zoomOut = JNIEnv.GetMethodID (class_ref, "zoomOut", "()V");
			try {

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_zoomOut);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "zoomOut", "()V"));
			} finally {
			}
		}

#region "Event implementation for Com.Ringdroid.WaveformView.IWaveformListener"

		global::Com.Ringdroid.WaveformView.IWaveformListenerImplementor __CreateIWaveformListenerImplementor ()
		{
			return new global::Com.Ringdroid.WaveformView.IWaveformListenerImplementor (this);
		}
#endregion
	}
}
