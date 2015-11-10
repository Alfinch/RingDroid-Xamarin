using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Ringdroid {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.ringdroid']/class[@name='AfterSaveActionDialog']"
	[global::Android.Runtime.Register ("com/ringdroid/AfterSaveActionDialog", DoNotGenerateAcw=true)]
	public partial class AfterSaveActionDialog : global::Android.App.Dialog {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/ringdroid/AfterSaveActionDialog", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (AfterSaveActionDialog); }
		}

		protected AfterSaveActionDialog (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Landroid_content_Context_Landroid_os_Message_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.ringdroid']/class[@name='AfterSaveActionDialog']/constructor[@name='AfterSaveActionDialog' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='android.os.Message']]"
		[Register (".ctor", "(Landroid/content/Context;Landroid/os/Message;)V", "")]
		public unsafe AfterSaveActionDialog (global::Android.Content.Context p0, global::Android.OS.Message p1)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				if (GetType () != typeof (AfterSaveActionDialog)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Landroid/content/Context;Landroid/os/Message;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Landroid/content/Context;Landroid/os/Message;)V", __args);
					return;
				}

				if (id_ctor_Landroid_content_Context_Landroid_os_Message_ == IntPtr.Zero)
					id_ctor_Landroid_content_Context_Landroid_os_Message_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/content/Context;Landroid/os/Message;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_content_Context_Landroid_os_Message_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Landroid_content_Context_Landroid_os_Message_, __args);
			} finally {
			}
		}

	}
}
