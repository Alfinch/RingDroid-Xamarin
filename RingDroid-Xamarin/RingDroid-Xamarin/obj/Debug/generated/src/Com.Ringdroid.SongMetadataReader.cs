using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Ringdroid {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.ringdroid']/class[@name='SongMetadataReader']"
	[global::Android.Runtime.Register ("com/ringdroid/SongMetadataReader", DoNotGenerateAcw=true)]
	public partial class SongMetadataReader : global::Java.Lang.Object {


		static IntPtr GENRES_URI_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.ringdroid']/class[@name='SongMetadataReader']/field[@name='GENRES_URI']"
		[Register ("GENRES_URI")]
		public global::Android.Net.Uri GenresUri {
			get {
				if (GENRES_URI_jfieldId == IntPtr.Zero)
					GENRES_URI_jfieldId = JNIEnv.GetFieldID (class_ref, "GENRES_URI", "Landroid/net/Uri;");
				IntPtr __ret = JNIEnv.GetObjectField (Handle, GENRES_URI_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Android.Net.Uri> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (GENRES_URI_jfieldId == IntPtr.Zero)
					GENRES_URI_jfieldId = JNIEnv.GetFieldID (class_ref, "GENRES_URI", "Landroid/net/Uri;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (Handle, GENRES_URI_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr mActivity_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.ringdroid']/class[@name='SongMetadataReader']/field[@name='mActivity']"
		[Register ("mActivity")]
		public global::Android.App.Activity MActivity {
			get {
				if (mActivity_jfieldId == IntPtr.Zero)
					mActivity_jfieldId = JNIEnv.GetFieldID (class_ref, "mActivity", "Landroid/app/Activity;");
				IntPtr __ret = JNIEnv.GetObjectField (Handle, mActivity_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Android.App.Activity> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (mActivity_jfieldId == IntPtr.Zero)
					mActivity_jfieldId = JNIEnv.GetFieldID (class_ref, "mActivity", "Landroid/app/Activity;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (Handle, mActivity_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr mAlbum_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.ringdroid']/class[@name='SongMetadataReader']/field[@name='mAlbum']"
		[Register ("mAlbum")]
		public string MAlbum {
			get {
				if (mAlbum_jfieldId == IntPtr.Zero)
					mAlbum_jfieldId = JNIEnv.GetFieldID (class_ref, "mAlbum", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetObjectField (Handle, mAlbum_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (mAlbum_jfieldId == IntPtr.Zero)
					mAlbum_jfieldId = JNIEnv.GetFieldID (class_ref, "mAlbum", "Ljava/lang/String;");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JNIEnv.SetField (Handle, mAlbum_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr mArtist_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.ringdroid']/class[@name='SongMetadataReader']/field[@name='mArtist']"
		[Register ("mArtist")]
		public string MArtist {
			get {
				if (mArtist_jfieldId == IntPtr.Zero)
					mArtist_jfieldId = JNIEnv.GetFieldID (class_ref, "mArtist", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetObjectField (Handle, mArtist_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (mArtist_jfieldId == IntPtr.Zero)
					mArtist_jfieldId = JNIEnv.GetFieldID (class_ref, "mArtist", "Ljava/lang/String;");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JNIEnv.SetField (Handle, mArtist_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr mFilename_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.ringdroid']/class[@name='SongMetadataReader']/field[@name='mFilename']"
		[Register ("mFilename")]
		public string MFilename {
			get {
				if (mFilename_jfieldId == IntPtr.Zero)
					mFilename_jfieldId = JNIEnv.GetFieldID (class_ref, "mFilename", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetObjectField (Handle, mFilename_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (mFilename_jfieldId == IntPtr.Zero)
					mFilename_jfieldId = JNIEnv.GetFieldID (class_ref, "mFilename", "Ljava/lang/String;");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JNIEnv.SetField (Handle, mFilename_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr mGenre_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.ringdroid']/class[@name='SongMetadataReader']/field[@name='mGenre']"
		[Register ("mGenre")]
		public string MGenre {
			get {
				if (mGenre_jfieldId == IntPtr.Zero)
					mGenre_jfieldId = JNIEnv.GetFieldID (class_ref, "mGenre", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetObjectField (Handle, mGenre_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (mGenre_jfieldId == IntPtr.Zero)
					mGenre_jfieldId = JNIEnv.GetFieldID (class_ref, "mGenre", "Ljava/lang/String;");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JNIEnv.SetField (Handle, mGenre_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr mTitle_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.ringdroid']/class[@name='SongMetadataReader']/field[@name='mTitle']"
		[Register ("mTitle")]
		public string MTitle {
			get {
				if (mTitle_jfieldId == IntPtr.Zero)
					mTitle_jfieldId = JNIEnv.GetFieldID (class_ref, "mTitle", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetObjectField (Handle, mTitle_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (mTitle_jfieldId == IntPtr.Zero)
					mTitle_jfieldId = JNIEnv.GetFieldID (class_ref, "mTitle", "Ljava/lang/String;");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JNIEnv.SetField (Handle, mTitle_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr mYear_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.ringdroid']/class[@name='SongMetadataReader']/field[@name='mYear']"
		[Register ("mYear")]
		public int MYear {
			get {
				if (mYear_jfieldId == IntPtr.Zero)
					mYear_jfieldId = JNIEnv.GetFieldID (class_ref, "mYear", "I");
				return JNIEnv.GetIntField (Handle, mYear_jfieldId);
			}
			set {
				if (mYear_jfieldId == IntPtr.Zero)
					mYear_jfieldId = JNIEnv.GetFieldID (class_ref, "mYear", "I");
				try {
					JNIEnv.SetField (Handle, mYear_jfieldId, value);
				} finally {
				}
			}
		}
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/ringdroid/SongMetadataReader", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (SongMetadataReader); }
		}

		protected SongMetadataReader (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

	}
}
