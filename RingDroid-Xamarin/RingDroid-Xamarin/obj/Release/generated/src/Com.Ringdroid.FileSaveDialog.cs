using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Ringdroid {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.ringdroid']/class[@name='FileSaveDialog']"
	[global::Android.Runtime.Register ("com/ringdroid/FileSaveDialog", DoNotGenerateAcw=true)]
	public partial class FileSaveDialog : global::Android.App.Dialog {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.ringdroid']/class[@name='FileSaveDialog']/field[@name='FILE_KIND_ALARM']"
		[Register ("FILE_KIND_ALARM")]
		public const int FileKindAlarm = (int) 1;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.ringdroid']/class[@name='FileSaveDialog']/field[@name='FILE_KIND_MUSIC']"
		[Register ("FILE_KIND_MUSIC")]
		public const int FileKindMusic = (int) 0;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.ringdroid']/class[@name='FileSaveDialog']/field[@name='FILE_KIND_NOTIFICATION']"
		[Register ("FILE_KIND_NOTIFICATION")]
		public const int FileKindNotification = (int) 2;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.ringdroid']/class[@name='FileSaveDialog']/field[@name='FILE_KIND_RINGTONE']"
		[Register ("FILE_KIND_RINGTONE")]
		public const int FileKindRingtone = (int) 3;
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/ringdroid/FileSaveDialog", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (FileSaveDialog); }
		}

		protected FileSaveDialog (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Landroid_content_Context_Landroid_content_res_Resources_Ljava_lang_String_Landroid_os_Message_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.ringdroid']/class[@name='FileSaveDialog']/constructor[@name='FileSaveDialog' and count(parameter)=4 and parameter[1][@type='android.content.Context'] and parameter[2][@type='android.content.res.Resources'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='android.os.Message']]"
		[Register (".ctor", "(Landroid/content/Context;Landroid/content/res/Resources;Ljava/lang/String;Landroid/os/Message;)V", "")]
		public unsafe FileSaveDialog (global::Android.Content.Context p0, global::Android.Content.Res.Resources p1, string p2, global::Android.OS.Message p3)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			IntPtr native_p2 = JNIEnv.NewString (p2);
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (native_p2);
				__args [3] = new JValue (p3);
				if (GetType () != typeof (FileSaveDialog)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Landroid/content/Context;Landroid/content/res/Resources;Ljava/lang/String;Landroid/os/Message;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Landroid/content/Context;Landroid/content/res/Resources;Ljava/lang/String;Landroid/os/Message;)V", __args);
					return;
				}

				if (id_ctor_Landroid_content_Context_Landroid_content_res_Resources_Ljava_lang_String_Landroid_os_Message_ == IntPtr.Zero)
					id_ctor_Landroid_content_Context_Landroid_content_res_Resources_Ljava_lang_String_Landroid_os_Message_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/content/Context;Landroid/content/res/Resources;Ljava/lang/String;Landroid/os/Message;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_content_Context_Landroid_content_res_Resources_Ljava_lang_String_Landroid_os_Message_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Landroid_content_Context_Landroid_content_res_Resources_Ljava_lang_String_Landroid_os_Message_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p2);
			}
		}

		static IntPtr id_KindToName_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.ringdroid']/class[@name='FileSaveDialog']/method[@name='KindToName' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("KindToName", "(I)Ljava/lang/String;", "")]
		public static unsafe string KindToName (int p0)
		{
			if (id_KindToName_I == IntPtr.Zero)
				id_KindToName_I = JNIEnv.GetStaticMethodID (class_ref, "KindToName", "(I)Ljava/lang/String;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				return JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_KindToName_I, __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}
}
