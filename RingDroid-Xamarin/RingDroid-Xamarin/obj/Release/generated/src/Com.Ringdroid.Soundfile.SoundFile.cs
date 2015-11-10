using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Ringdroid.Soundfile {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.ringdroid.soundfile']/class[@name='SoundFile']"
	[global::Android.Runtime.Register ("com/ringdroid/soundfile/SoundFile", DoNotGenerateAcw=true)]
	public partial class SoundFile : global::Java.Lang.Object {

		// Metadata.xml XPath class reference: path="/api/package[@name='com.ringdroid.soundfile']/class[@name='SoundFile.InvalidInputException']"
		[global::Android.Runtime.Register ("com/ringdroid/soundfile/SoundFile$InvalidInputException", DoNotGenerateAcw=true)]
		public partial class InvalidInputException : global::Java.Lang.Exception {

			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/ringdroid/soundfile/SoundFile$InvalidInputException", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (InvalidInputException); }
			}

			protected InvalidInputException (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor_Lcom_ringdroid_soundfile_SoundFile_Ljava_lang_String_;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.ringdroid.soundfile']/class[@name='SoundFile.InvalidInputException']/constructor[@name='SoundFile.InvalidInputException' and count(parameter)=2 and parameter[1][@type='com.ringdroid.soundfile.SoundFile'] and parameter[2][@type='java.lang.String']]"
			[Register (".ctor", "(Lcom/ringdroid/soundfile/SoundFile;Ljava/lang/String;)V", "")]
			public unsafe InvalidInputException (global::Com.Ringdroid.Soundfile.SoundFile __self, string p1)
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (Handle != IntPtr.Zero)
					return;

				IntPtr native_p1 = JNIEnv.NewString (p1);
				try {
					JValue* __args = stackalloc JValue [2];
					__args [0] = new JValue (__self);
					__args [1] = new JValue (native_p1);
					if (GetType () != typeof (InvalidInputException)) {
						SetHandle (
								global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(L" + global::Android.Runtime.JNIEnv.GetJniName (GetType ().DeclaringType) + ";Ljava/lang/String;)V", __args),
								JniHandleOwnership.TransferLocalRef);
						global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(L" + global::Android.Runtime.JNIEnv.GetJniName (GetType ().DeclaringType) + ";Ljava/lang/String;)V", __args);
						return;
					}

					if (id_ctor_Lcom_ringdroid_soundfile_SoundFile_Ljava_lang_String_ == IntPtr.Zero)
						id_ctor_Lcom_ringdroid_soundfile_SoundFile_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lcom/ringdroid/soundfile/SoundFile;Ljava/lang/String;)V");
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lcom_ringdroid_soundfile_SoundFile_Ljava_lang_String_, __args),
							JniHandleOwnership.TransferLocalRef);
					JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Lcom_ringdroid_soundfile_SoundFile_Ljava_lang_String_, __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_p1);
				}
			}

		}

		// Metadata.xml XPath interface reference: path="/api/package[@name='com.ringdroid.soundfile']/interface[@name='SoundFile.ProgressListener']"
		[Register ("com/ringdroid/soundfile/SoundFile$ProgressListener", "", "Com.Ringdroid.Soundfile.SoundFile/IProgressListenerInvoker")]
		public partial interface IProgressListener : IJavaObject {

			// Metadata.xml XPath method reference: path="/api/package[@name='com.ringdroid.soundfile']/interface[@name='SoundFile.ProgressListener']/method[@name='reportProgress' and count(parameter)=1 and parameter[1][@type='double']]"
			[Register ("reportProgress", "(D)Z", "GetReportProgress_DHandler:Com.Ringdroid.Soundfile.SoundFile/IProgressListenerInvoker, RingDroid-Xamarin")]
			bool ReportProgress (double p0);

		}

		[global::Android.Runtime.Register ("com/ringdroid/soundfile/SoundFile$ProgressListener", DoNotGenerateAcw=true)]
		internal class IProgressListenerInvoker : global::Java.Lang.Object, IProgressListener {

			static IntPtr java_class_ref = JNIEnv.FindClass ("com/ringdroid/soundfile/SoundFile$ProgressListener");
			IntPtr class_ref;

			public static IProgressListener GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<IProgressListener> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "com.ringdroid.soundfile.SoundFile.ProgressListener"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public IProgressListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (IProgressListenerInvoker); }
			}

			static Delegate cb_reportProgress_D;
#pragma warning disable 0169
			static Delegate GetReportProgress_DHandler ()
			{
				if (cb_reportProgress_D == null)
					cb_reportProgress_D = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, double, bool>) n_ReportProgress_D);
				return cb_reportProgress_D;
			}

			static bool n_ReportProgress_D (IntPtr jnienv, IntPtr native__this, double p0)
			{
				global::Com.Ringdroid.Soundfile.SoundFile.IProgressListener __this = global::Java.Lang.Object.GetObject<global::Com.Ringdroid.Soundfile.SoundFile.IProgressListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return __this.ReportProgress (p0);
			}
#pragma warning restore 0169

			IntPtr id_reportProgress_D;
			public unsafe bool ReportProgress (double p0)
			{
				if (id_reportProgress_D == IntPtr.Zero)
					id_reportProgress_D = JNIEnv.GetMethodID (class_ref, "reportProgress", "(D)Z");
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				return JNIEnv.CallBooleanMethod (Handle, id_reportProgress_D, __args);
			}

		}

		public partial class ProgressEventArgs : global::System.EventArgs {

			public ProgressEventArgs (bool handled, double p0)
			{
				this.handled = handled;
				this.p0 = p0;
			}

			bool handled;
			public bool Handled {
				get { return handled; }
				set { handled = value; }
			}

			double p0;
			public double P0 {
				get { return p0; }
			}
		}

		[global::Android.Runtime.Register ("mono/com/ringdroid/soundfile/SoundFile_ProgressListenerImplementor")]
		internal sealed partial class IProgressListenerImplementor : global::Java.Lang.Object, IProgressListener {

			object sender;

			public IProgressListenerImplementor (object sender)
				: base (
					global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/com/ringdroid/soundfile/SoundFile_ProgressListenerImplementor", "()V"),
					JniHandleOwnership.TransferLocalRef)
			{
				global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "()V");
				this.sender = sender;
			}

#pragma warning disable 0649
			public EventHandler<ProgressEventArgs> Handler;
#pragma warning restore 0649

			public bool ReportProgress (double p0)
			{
				var __h = Handler;
				if (__h == null)
					return false;
				var __e = new ProgressEventArgs (true, p0);
				__h (sender, __e);
				return __e.Handled;
			}

			internal static bool __IsEmpty (IProgressListenerImplementor value)
			{
				return value.Handler == null;
			}
		}


		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/ringdroid/soundfile/SoundFile", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (SoundFile); }
		}

		protected SoundFile (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static Delegate cb_getAvgBitrateKbps;
#pragma warning disable 0169
		static Delegate GetGetAvgBitrateKbpsHandler ()
		{
			if (cb_getAvgBitrateKbps == null)
				cb_getAvgBitrateKbps = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetAvgBitrateKbps);
			return cb_getAvgBitrateKbps;
		}

		static int n_GetAvgBitrateKbps (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Ringdroid.Soundfile.SoundFile __this = global::Java.Lang.Object.GetObject<global::Com.Ringdroid.Soundfile.SoundFile> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.AvgBitrateKbps;
		}
#pragma warning restore 0169

		static IntPtr id_getAvgBitrateKbps;
		public virtual unsafe int AvgBitrateKbps {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ringdroid.soundfile']/class[@name='SoundFile']/method[@name='getAvgBitrateKbps' and count(parameter)=0]"
			[Register ("getAvgBitrateKbps", "()I", "GetGetAvgBitrateKbpsHandler")]
			get {
				if (id_getAvgBitrateKbps == IntPtr.Zero)
					id_getAvgBitrateKbps = JNIEnv.GetMethodID (class_ref, "getAvgBitrateKbps", "()I");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallIntMethod  (Handle, id_getAvgBitrateKbps);
					else
						return JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getAvgBitrateKbps", "()I"));
				} finally {
				}
			}
		}

		static Delegate cb_getChannels;
#pragma warning disable 0169
		static Delegate GetGetChannelsHandler ()
		{
			if (cb_getChannels == null)
				cb_getChannels = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetChannels);
			return cb_getChannels;
		}

		static int n_GetChannels (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Ringdroid.Soundfile.SoundFile __this = global::Java.Lang.Object.GetObject<global::Com.Ringdroid.Soundfile.SoundFile> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Channels;
		}
#pragma warning restore 0169

		static IntPtr id_getChannels;
		public virtual unsafe int Channels {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ringdroid.soundfile']/class[@name='SoundFile']/method[@name='getChannels' and count(parameter)=0]"
			[Register ("getChannels", "()I", "GetGetChannelsHandler")]
			get {
				if (id_getChannels == IntPtr.Zero)
					id_getChannels = JNIEnv.GetMethodID (class_ref, "getChannels", "()I");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallIntMethod  (Handle, id_getChannels);
					else
						return JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getChannels", "()I"));
				} finally {
				}
			}
		}

		static Delegate cb_getFileSizeBytes;
#pragma warning disable 0169
		static Delegate GetGetFileSizeBytesHandler ()
		{
			if (cb_getFileSizeBytes == null)
				cb_getFileSizeBytes = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetFileSizeBytes);
			return cb_getFileSizeBytes;
		}

		static int n_GetFileSizeBytes (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Ringdroid.Soundfile.SoundFile __this = global::Java.Lang.Object.GetObject<global::Com.Ringdroid.Soundfile.SoundFile> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.FileSizeBytes;
		}
#pragma warning restore 0169

		static IntPtr id_getFileSizeBytes;
		public virtual unsafe int FileSizeBytes {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ringdroid.soundfile']/class[@name='SoundFile']/method[@name='getFileSizeBytes' and count(parameter)=0]"
			[Register ("getFileSizeBytes", "()I", "GetGetFileSizeBytesHandler")]
			get {
				if (id_getFileSizeBytes == IntPtr.Zero)
					id_getFileSizeBytes = JNIEnv.GetMethodID (class_ref, "getFileSizeBytes", "()I");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallIntMethod  (Handle, id_getFileSizeBytes);
					else
						return JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getFileSizeBytes", "()I"));
				} finally {
				}
			}
		}

		static Delegate cb_getFiletype;
#pragma warning disable 0169
		static Delegate GetGetFiletypeHandler ()
		{
			if (cb_getFiletype == null)
				cb_getFiletype = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetFiletype);
			return cb_getFiletype;
		}

		static IntPtr n_GetFiletype (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Ringdroid.Soundfile.SoundFile __this = global::Java.Lang.Object.GetObject<global::Com.Ringdroid.Soundfile.SoundFile> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Filetype);
		}
#pragma warning restore 0169

		static IntPtr id_getFiletype;
		public virtual unsafe string Filetype {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ringdroid.soundfile']/class[@name='SoundFile']/method[@name='getFiletype' and count(parameter)=0]"
			[Register ("getFiletype", "()Ljava/lang/String;", "GetGetFiletypeHandler")]
			get {
				if (id_getFiletype == IntPtr.Zero)
					id_getFiletype = JNIEnv.GetMethodID (class_ref, "getFiletype", "()Ljava/lang/String;");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getFiletype), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getFiletype", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getNumFrames;
#pragma warning disable 0169
		static Delegate GetGetNumFramesHandler ()
		{
			if (cb_getNumFrames == null)
				cb_getNumFrames = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetNumFrames);
			return cb_getNumFrames;
		}

		static int n_GetNumFrames (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Ringdroid.Soundfile.SoundFile __this = global::Java.Lang.Object.GetObject<global::Com.Ringdroid.Soundfile.SoundFile> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.NumFrames;
		}
#pragma warning restore 0169

		static IntPtr id_getNumFrames;
		public virtual unsafe int NumFrames {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ringdroid.soundfile']/class[@name='SoundFile']/method[@name='getNumFrames' and count(parameter)=0]"
			[Register ("getNumFrames", "()I", "GetGetNumFramesHandler")]
			get {
				if (id_getNumFrames == IntPtr.Zero)
					id_getNumFrames = JNIEnv.GetMethodID (class_ref, "getNumFrames", "()I");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallIntMethod  (Handle, id_getNumFrames);
					else
						return JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getNumFrames", "()I"));
				} finally {
				}
			}
		}

		static Delegate cb_getNumSamples;
#pragma warning disable 0169
		static Delegate GetGetNumSamplesHandler ()
		{
			if (cb_getNumSamples == null)
				cb_getNumSamples = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetNumSamples);
			return cb_getNumSamples;
		}

		static int n_GetNumSamples (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Ringdroid.Soundfile.SoundFile __this = global::Java.Lang.Object.GetObject<global::Com.Ringdroid.Soundfile.SoundFile> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.NumSamples;
		}
#pragma warning restore 0169

		static IntPtr id_getNumSamples;
		public virtual unsafe int NumSamples {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ringdroid.soundfile']/class[@name='SoundFile']/method[@name='getNumSamples' and count(parameter)=0]"
			[Register ("getNumSamples", "()I", "GetGetNumSamplesHandler")]
			get {
				if (id_getNumSamples == IntPtr.Zero)
					id_getNumSamples = JNIEnv.GetMethodID (class_ref, "getNumSamples", "()I");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallIntMethod  (Handle, id_getNumSamples);
					else
						return JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getNumSamples", "()I"));
				} finally {
				}
			}
		}

		static Delegate cb_getSampleRate;
#pragma warning disable 0169
		static Delegate GetGetSampleRateHandler ()
		{
			if (cb_getSampleRate == null)
				cb_getSampleRate = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetSampleRate);
			return cb_getSampleRate;
		}

		static int n_GetSampleRate (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Ringdroid.Soundfile.SoundFile __this = global::Java.Lang.Object.GetObject<global::Com.Ringdroid.Soundfile.SoundFile> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.SampleRate;
		}
#pragma warning restore 0169

		static IntPtr id_getSampleRate;
		public virtual unsafe int SampleRate {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ringdroid.soundfile']/class[@name='SoundFile']/method[@name='getSampleRate' and count(parameter)=0]"
			[Register ("getSampleRate", "()I", "GetGetSampleRateHandler")]
			get {
				if (id_getSampleRate == IntPtr.Zero)
					id_getSampleRate = JNIEnv.GetMethodID (class_ref, "getSampleRate", "()I");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallIntMethod  (Handle, id_getSampleRate);
					else
						return JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getSampleRate", "()I"));
				} finally {
				}
			}
		}

		static Delegate cb_getSamples;
#pragma warning disable 0169
		static Delegate GetGetSamplesHandler ()
		{
			if (cb_getSamples == null)
				cb_getSamples = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetSamples);
			return cb_getSamples;
		}

		static IntPtr n_GetSamples (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Ringdroid.Soundfile.SoundFile __this = global::Java.Lang.Object.GetObject<global::Com.Ringdroid.Soundfile.SoundFile> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Samples);
		}
#pragma warning restore 0169

		static IntPtr id_getSamples;
		public virtual unsafe global::Java.Nio.ShortBuffer Samples {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ringdroid.soundfile']/class[@name='SoundFile']/method[@name='getSamples' and count(parameter)=0]"
			[Register ("getSamples", "()Ljava/nio/ShortBuffer;", "GetGetSamplesHandler")]
			get {
				if (id_getSamples == IntPtr.Zero)
					id_getSamples = JNIEnv.GetMethodID (class_ref, "getSamples", "()Ljava/nio/ShortBuffer;");
				try {

					if (GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Java.Nio.ShortBuffer> (JNIEnv.CallObjectMethod  (Handle, id_getSamples), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Java.Nio.ShortBuffer> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getSamples", "()Ljava/nio/ShortBuffer;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getSamplesPerFrame;
#pragma warning disable 0169
		static Delegate GetGetSamplesPerFrameHandler ()
		{
			if (cb_getSamplesPerFrame == null)
				cb_getSamplesPerFrame = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetSamplesPerFrame);
			return cb_getSamplesPerFrame;
		}

		static int n_GetSamplesPerFrame (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Ringdroid.Soundfile.SoundFile __this = global::Java.Lang.Object.GetObject<global::Com.Ringdroid.Soundfile.SoundFile> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.SamplesPerFrame;
		}
#pragma warning restore 0169

		static IntPtr id_getSamplesPerFrame;
		public virtual unsafe int SamplesPerFrame {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ringdroid.soundfile']/class[@name='SoundFile']/method[@name='getSamplesPerFrame' and count(parameter)=0]"
			[Register ("getSamplesPerFrame", "()I", "GetGetSamplesPerFrameHandler")]
			get {
				if (id_getSamplesPerFrame == IntPtr.Zero)
					id_getSamplesPerFrame = JNIEnv.GetMethodID (class_ref, "getSamplesPerFrame", "()I");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallIntMethod  (Handle, id_getSamplesPerFrame);
					else
						return JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getSamplesPerFrame", "()I"));
				} finally {
				}
			}
		}

		static Delegate cb_WriteFile_Ljava_io_File_FF;
#pragma warning disable 0169
		static Delegate GetWriteFile_Ljava_io_File_FFHandler ()
		{
			if (cb_WriteFile_Ljava_io_File_FF == null)
				cb_WriteFile_Ljava_io_File_FF = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, float, float>) n_WriteFile_Ljava_io_File_FF);
			return cb_WriteFile_Ljava_io_File_FF;
		}

		static void n_WriteFile_Ljava_io_File_FF (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, float p1, float p2)
		{
			global::Com.Ringdroid.Soundfile.SoundFile __this = global::Java.Lang.Object.GetObject<global::Com.Ringdroid.Soundfile.SoundFile> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.IO.File p0 = global::Java.Lang.Object.GetObject<global::Java.IO.File> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.WriteFile (p0, p1, p2);
		}
#pragma warning restore 0169

		static IntPtr id_WriteFile_Ljava_io_File_FF;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.ringdroid.soundfile']/class[@name='SoundFile']/method[@name='WriteFile' and count(parameter)=3 and parameter[1][@type='java.io.File'] and parameter[2][@type='float'] and parameter[3][@type='float']]"
		[Register ("WriteFile", "(Ljava/io/File;FF)V", "GetWriteFile_Ljava_io_File_FFHandler")]
		public virtual unsafe void WriteFile (global::Java.IO.File p0, float p1, float p2)
		{
			if (id_WriteFile_Ljava_io_File_FF == IntPtr.Zero)
				id_WriteFile_Ljava_io_File_FF = JNIEnv.GetMethodID (class_ref, "WriteFile", "(Ljava/io/File;FF)V");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_WriteFile_Ljava_io_File_FF, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "WriteFile", "(Ljava/io/File;FF)V"), __args);
			} finally {
			}
		}

		static Delegate cb_WriteFile_Ljava_io_File_II;
#pragma warning disable 0169
		static Delegate GetWriteFile_Ljava_io_File_IIHandler ()
		{
			if (cb_WriteFile_Ljava_io_File_II == null)
				cb_WriteFile_Ljava_io_File_II = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, int, int>) n_WriteFile_Ljava_io_File_II);
			return cb_WriteFile_Ljava_io_File_II;
		}

		static void n_WriteFile_Ljava_io_File_II (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1, int p2)
		{
			global::Com.Ringdroid.Soundfile.SoundFile __this = global::Java.Lang.Object.GetObject<global::Com.Ringdroid.Soundfile.SoundFile> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.IO.File p0 = global::Java.Lang.Object.GetObject<global::Java.IO.File> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.WriteFile (p0, p1, p2);
		}
#pragma warning restore 0169

		static IntPtr id_WriteFile_Ljava_io_File_II;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.ringdroid.soundfile']/class[@name='SoundFile']/method[@name='WriteFile' and count(parameter)=3 and parameter[1][@type='java.io.File'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
		[Register ("WriteFile", "(Ljava/io/File;II)V", "GetWriteFile_Ljava_io_File_IIHandler")]
		public virtual unsafe void WriteFile (global::Java.IO.File p0, int p1, int p2)
		{
			if (id_WriteFile_Ljava_io_File_II == IntPtr.Zero)
				id_WriteFile_Ljava_io_File_II = JNIEnv.GetMethodID (class_ref, "WriteFile", "(Ljava/io/File;II)V");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_WriteFile_Ljava_io_File_II, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "WriteFile", "(Ljava/io/File;II)V"), __args);
			} finally {
			}
		}

		static Delegate cb_WriteWAVFile_Ljava_io_File_FF;
#pragma warning disable 0169
		static Delegate GetWriteWAVFile_Ljava_io_File_FFHandler ()
		{
			if (cb_WriteWAVFile_Ljava_io_File_FF == null)
				cb_WriteWAVFile_Ljava_io_File_FF = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, float, float>) n_WriteWAVFile_Ljava_io_File_FF);
			return cb_WriteWAVFile_Ljava_io_File_FF;
		}

		static void n_WriteWAVFile_Ljava_io_File_FF (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, float p1, float p2)
		{
			global::Com.Ringdroid.Soundfile.SoundFile __this = global::Java.Lang.Object.GetObject<global::Com.Ringdroid.Soundfile.SoundFile> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.IO.File p0 = global::Java.Lang.Object.GetObject<global::Java.IO.File> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.WriteWAVFile (p0, p1, p2);
		}
#pragma warning restore 0169

		static IntPtr id_WriteWAVFile_Ljava_io_File_FF;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.ringdroid.soundfile']/class[@name='SoundFile']/method[@name='WriteWAVFile' and count(parameter)=3 and parameter[1][@type='java.io.File'] and parameter[2][@type='float'] and parameter[3][@type='float']]"
		[Register ("WriteWAVFile", "(Ljava/io/File;FF)V", "GetWriteWAVFile_Ljava_io_File_FFHandler")]
		public virtual unsafe void WriteWAVFile (global::Java.IO.File p0, float p1, float p2)
		{
			if (id_WriteWAVFile_Ljava_io_File_FF == IntPtr.Zero)
				id_WriteWAVFile_Ljava_io_File_FF = JNIEnv.GetMethodID (class_ref, "WriteWAVFile", "(Ljava/io/File;FF)V");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_WriteWAVFile_Ljava_io_File_FF, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "WriteWAVFile", "(Ljava/io/File;FF)V"), __args);
			} finally {
			}
		}

		static Delegate cb_WriteWAVFile_Ljava_io_File_II;
#pragma warning disable 0169
		static Delegate GetWriteWAVFile_Ljava_io_File_IIHandler ()
		{
			if (cb_WriteWAVFile_Ljava_io_File_II == null)
				cb_WriteWAVFile_Ljava_io_File_II = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, int, int>) n_WriteWAVFile_Ljava_io_File_II);
			return cb_WriteWAVFile_Ljava_io_File_II;
		}

		static void n_WriteWAVFile_Ljava_io_File_II (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1, int p2)
		{
			global::Com.Ringdroid.Soundfile.SoundFile __this = global::Java.Lang.Object.GetObject<global::Com.Ringdroid.Soundfile.SoundFile> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.IO.File p0 = global::Java.Lang.Object.GetObject<global::Java.IO.File> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.WriteWAVFile (p0, p1, p2);
		}
#pragma warning restore 0169

		static IntPtr id_WriteWAVFile_Ljava_io_File_II;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.ringdroid.soundfile']/class[@name='SoundFile']/method[@name='WriteWAVFile' and count(parameter)=3 and parameter[1][@type='java.io.File'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
		[Register ("WriteWAVFile", "(Ljava/io/File;II)V", "GetWriteWAVFile_Ljava_io_File_IIHandler")]
		public virtual unsafe void WriteWAVFile (global::Java.IO.File p0, int p1, int p2)
		{
			if (id_WriteWAVFile_Ljava_io_File_II == IntPtr.Zero)
				id_WriteWAVFile_Ljava_io_File_II = JNIEnv.GetMethodID (class_ref, "WriteWAVFile", "(Ljava/io/File;II)V");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_WriteWAVFile_Ljava_io_File_II, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "WriteWAVFile", "(Ljava/io/File;II)V"), __args);
			} finally {
			}
		}

		static IntPtr id_create_Ljava_lang_String_Lcom_ringdroid_soundfile_SoundFile_ProgressListener_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.ringdroid.soundfile']/class[@name='SoundFile']/method[@name='create' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='com.ringdroid.soundfile.SoundFile.ProgressListener']]"
		[Register ("create", "(Ljava/lang/String;Lcom/ringdroid/soundfile/SoundFile$ProgressListener;)Lcom/ringdroid/soundfile/SoundFile;", "")]
		public static unsafe global::Com.Ringdroid.Soundfile.SoundFile Create (string p0, global::Com.Ringdroid.Soundfile.SoundFile.IProgressListener p1)
		{
			if (id_create_Ljava_lang_String_Lcom_ringdroid_soundfile_SoundFile_ProgressListener_ == IntPtr.Zero)
				id_create_Ljava_lang_String_Lcom_ringdroid_soundfile_SoundFile_ProgressListener_ = JNIEnv.GetStaticMethodID (class_ref, "create", "(Ljava/lang/String;Lcom/ringdroid/soundfile/SoundFile$ProgressListener;)Lcom/ringdroid/soundfile/SoundFile;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);
				global::Com.Ringdroid.Soundfile.SoundFile __ret = global::Java.Lang.Object.GetObject<global::Com.Ringdroid.Soundfile.SoundFile> (JNIEnv.CallStaticObjectMethod  (class_ref, id_create_Ljava_lang_String_Lcom_ringdroid_soundfile_SoundFile_ProgressListener_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_getFrameGains;
#pragma warning disable 0169
		static Delegate GetGetFrameGainsHandler ()
		{
			if (cb_getFrameGains == null)
				cb_getFrameGains = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetFrameGains);
			return cb_getFrameGains;
		}

		static IntPtr n_GetFrameGains (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Ringdroid.Soundfile.SoundFile __this = global::Java.Lang.Object.GetObject<global::Com.Ringdroid.Soundfile.SoundFile> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.GetFrameGains ());
		}
#pragma warning restore 0169

		static IntPtr id_getFrameGains;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.ringdroid.soundfile']/class[@name='SoundFile']/method[@name='getFrameGains' and count(parameter)=0]"
		[Register ("getFrameGains", "()[I", "GetGetFrameGainsHandler")]
		public virtual unsafe int[] GetFrameGains ()
		{
			if (id_getFrameGains == IntPtr.Zero)
				id_getFrameGains = JNIEnv.GetMethodID (class_ref, "getFrameGains", "()[I");
			try {

				if (GetType () == ThresholdType)
					return (int[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod  (Handle, id_getFrameGains), JniHandleOwnership.TransferLocalRef, typeof (int));
				else
					return (int[]) JNIEnv.GetArray (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getFrameGains", "()[I")), JniHandleOwnership.TransferLocalRef, typeof (int));
			} finally {
			}
		}

		static IntPtr id_getSupportedExtensions;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.ringdroid.soundfile']/class[@name='SoundFile']/method[@name='getSupportedExtensions' and count(parameter)=0]"
		[Register ("getSupportedExtensions", "()[Ljava/lang/String;", "")]
		public static unsafe string[] GetSupportedExtensions ()
		{
			if (id_getSupportedExtensions == IntPtr.Zero)
				id_getSupportedExtensions = JNIEnv.GetStaticMethodID (class_ref, "getSupportedExtensions", "()[Ljava/lang/String;");
			try {
				return (string[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_getSupportedExtensions), JniHandleOwnership.TransferLocalRef, typeof (string));
			} finally {
			}
		}

		static IntPtr id_isFilenameSupported_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.ringdroid.soundfile']/class[@name='SoundFile']/method[@name='isFilenameSupported' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("isFilenameSupported", "(Ljava/lang/String;)Z", "")]
		public static unsafe bool IsFilenameSupported (string p0)
		{
			if (id_isFilenameSupported_Ljava_lang_String_ == IntPtr.Zero)
				id_isFilenameSupported_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "isFilenameSupported", "(Ljava/lang/String;)Z");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				bool __ret = JNIEnv.CallStaticBooleanMethod  (class_ref, id_isFilenameSupported_Ljava_lang_String_, __args);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_record_Lcom_ringdroid_soundfile_SoundFile_ProgressListener_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.ringdroid.soundfile']/class[@name='SoundFile']/method[@name='record' and count(parameter)=1 and parameter[1][@type='com.ringdroid.soundfile.SoundFile.ProgressListener']]"
		[Register ("record", "(Lcom/ringdroid/soundfile/SoundFile$ProgressListener;)Lcom/ringdroid/soundfile/SoundFile;", "")]
		public static unsafe global::Com.Ringdroid.Soundfile.SoundFile Record (global::Com.Ringdroid.Soundfile.SoundFile.IProgressListener p0)
		{
			if (id_record_Lcom_ringdroid_soundfile_SoundFile_ProgressListener_ == IntPtr.Zero)
				id_record_Lcom_ringdroid_soundfile_SoundFile_ProgressListener_ = JNIEnv.GetStaticMethodID (class_ref, "record", "(Lcom/ringdroid/soundfile/SoundFile$ProgressListener;)Lcom/ringdroid/soundfile/SoundFile;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				global::Com.Ringdroid.Soundfile.SoundFile __ret = global::Java.Lang.Object.GetObject<global::Com.Ringdroid.Soundfile.SoundFile> (JNIEnv.CallStaticObjectMethod  (class_ref, id_record_Lcom_ringdroid_soundfile_SoundFile_ProgressListener_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

	}
}
