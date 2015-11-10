using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Ringdroid.Soundfile {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.ringdroid.soundfile']/class[@name='MP4Header']"
	[global::Android.Runtime.Register ("com/ringdroid/soundfile/MP4Header", DoNotGenerateAcw=true)]
	public partial class MP4Header : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/ringdroid/soundfile/MP4Header", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (MP4Header); }
		}

		protected MP4Header (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_IIarrayII;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.ringdroid.soundfile']/class[@name='MP4Header']/constructor[@name='MP4Header' and count(parameter)=4 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='int[]'] and parameter[4][@type='int']]"
		[Register (".ctor", "(II[II)V", "")]
		public unsafe MP4Header (int p0, int p1, int[] p2, int p3)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			IntPtr native_p2 = JNIEnv.NewArray (p2);
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (native_p2);
				__args [3] = new JValue (p3);
				if (GetType () != typeof (MP4Header)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(II[II)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(II[II)V", __args);
					return;
				}

				if (id_ctor_IIarrayII == IntPtr.Zero)
					id_ctor_IIarrayII = JNIEnv.GetMethodID (class_ref, "<init>", "(II[II)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_IIarrayII, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_IIarrayII, __args);
			} finally {
				if (p2 != null) {
					JNIEnv.CopyArray (native_p2, p2);
					JNIEnv.DeleteLocalRef (native_p2);
				}
			}
		}

		static Delegate cb_getMP4Header;
#pragma warning disable 0169
		static Delegate GetGetMP4HeaderHandler ()
		{
			if (cb_getMP4Header == null)
				cb_getMP4Header = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetMP4Header);
			return cb_getMP4Header;
		}

		static IntPtr n_GetMP4Header (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Ringdroid.Soundfile.MP4Header __this = global::Java.Lang.Object.GetObject<global::Com.Ringdroid.Soundfile.MP4Header> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.GetMP4Header ());
		}
#pragma warning restore 0169

		static IntPtr id_getMP4Header;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.ringdroid.soundfile']/class[@name='MP4Header']/method[@name='getMP4Header' and count(parameter)=0]"
		[Register ("getMP4Header", "()[B", "GetGetMP4HeaderHandler")]
		public virtual unsafe byte[] GetMP4Header ()
		{
			if (id_getMP4Header == IntPtr.Zero)
				id_getMP4Header = JNIEnv.GetMethodID (class_ref, "getMP4Header", "()[B");
			try {

				if (GetType () == ThresholdType)
					return (byte[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod  (Handle, id_getMP4Header), JniHandleOwnership.TransferLocalRef, typeof (byte));
				else
					return (byte[]) JNIEnv.GetArray (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getMP4Header", "()[B")), JniHandleOwnership.TransferLocalRef, typeof (byte));
			} finally {
			}
		}

		static IntPtr id_getMP4Header_IIarrayII;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.ringdroid.soundfile']/class[@name='MP4Header']/method[@name='getMP4Header' and count(parameter)=4 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='int[]'] and parameter[4][@type='int']]"
		[Register ("getMP4Header", "(II[II)[B", "")]
		public static unsafe byte[] GetMP4Header (int p0, int p1, int[] p2, int p3)
		{
			if (id_getMP4Header_IIarrayII == IntPtr.Zero)
				id_getMP4Header_IIarrayII = JNIEnv.GetStaticMethodID (class_ref, "getMP4Header", "(II[II)[B");
			IntPtr native_p2 = JNIEnv.NewArray (p2);
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (native_p2);
				__args [3] = new JValue (p3);
				byte[] __ret = (byte[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_getMP4Header_IIarrayII, __args), JniHandleOwnership.TransferLocalRef, typeof (byte));
				return __ret;
			} finally {
				if (p2 != null) {
					JNIEnv.CopyArray (native_p2, p2);
					JNIEnv.DeleteLocalRef (native_p2);
				}
			}
		}

	}
}
