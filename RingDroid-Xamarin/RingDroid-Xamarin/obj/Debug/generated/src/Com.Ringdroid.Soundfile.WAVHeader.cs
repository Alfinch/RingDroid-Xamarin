using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Ringdroid.Soundfile {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.ringdroid.soundfile']/class[@name='WAVHeader']"
	[global::Android.Runtime.Register ("com/ringdroid/soundfile/WAVHeader", DoNotGenerateAcw=true)]
	public partial class WAVHeader : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/ringdroid/soundfile/WAVHeader", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (WAVHeader); }
		}

		protected WAVHeader (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_III;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.ringdroid.soundfile']/class[@name='WAVHeader']/constructor[@name='WAVHeader' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
		[Register (".ctor", "(III)V", "")]
		public unsafe WAVHeader (int p0, int p1, int p2)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				if (GetType () != typeof (WAVHeader)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(III)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(III)V", __args);
					return;
				}

				if (id_ctor_III == IntPtr.Zero)
					id_ctor_III = JNIEnv.GetMethodID (class_ref, "<init>", "(III)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_III, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_III, __args);
			} finally {
			}
		}

		static Delegate cb_getWAVHeader;
#pragma warning disable 0169
		static Delegate GetGetWAVHeaderHandler ()
		{
			if (cb_getWAVHeader == null)
				cb_getWAVHeader = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetWAVHeader);
			return cb_getWAVHeader;
		}

		static IntPtr n_GetWAVHeader (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Ringdroid.Soundfile.WAVHeader __this = global::Java.Lang.Object.GetObject<global::Com.Ringdroid.Soundfile.WAVHeader> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.GetWAVHeader ());
		}
#pragma warning restore 0169

		static IntPtr id_getWAVHeader;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.ringdroid.soundfile']/class[@name='WAVHeader']/method[@name='getWAVHeader' and count(parameter)=0]"
		[Register ("getWAVHeader", "()[B", "GetGetWAVHeaderHandler")]
		public virtual unsafe byte[] GetWAVHeader ()
		{
			if (id_getWAVHeader == IntPtr.Zero)
				id_getWAVHeader = JNIEnv.GetMethodID (class_ref, "getWAVHeader", "()[B");
			try {

				if (GetType () == ThresholdType)
					return (byte[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod  (Handle, id_getWAVHeader), JniHandleOwnership.TransferLocalRef, typeof (byte));
				else
					return (byte[]) JNIEnv.GetArray (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getWAVHeader", "()[B")), JniHandleOwnership.TransferLocalRef, typeof (byte));
			} finally {
			}
		}

		static IntPtr id_getWAVHeader_III;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.ringdroid.soundfile']/class[@name='WAVHeader']/method[@name='getWAVHeader' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
		[Register ("getWAVHeader", "(III)[B", "")]
		public static unsafe byte[] GetWAVHeader (int p0, int p1, int p2)
		{
			if (id_getWAVHeader_III == IntPtr.Zero)
				id_getWAVHeader_III = JNIEnv.GetStaticMethodID (class_ref, "getWAVHeader", "(III)[B");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				return (byte[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_getWAVHeader_III, __args), JniHandleOwnership.TransferLocalRef, typeof (byte));
			} finally {
			}
		}

	}
}
