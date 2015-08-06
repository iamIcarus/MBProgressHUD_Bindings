//
// Auto-generated from generator.cs, do not edit
//
// We keep references to objects, so warning 414 is expected

#pragma warning disable 414

using System;
using System.Drawing;
using System.Diagnostics;
using System.ComponentModel;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using UIKit;
using GLKit;
using MapKit;
using Security;
using SceneKit;
using CoreVideo;
using CoreMedia;
using QuickLook;
using Foundation;
using CoreMotion;
using ObjCRuntime;
using AddressBook;
using CoreGraphics;
using CoreLocation;
using NewsstandKit;
using AVFoundation;
using CoreAnimation;
using CoreFoundation;

namespace MBProgressHUD {
	[Protocol (Name = "MBRoundProgressView", WrapperType = typeof (MBRoundProgressViewWrapper))]
	public interface IMBRoundProgressView : INativeObject, IDisposable
	{
	}
	
	public static partial class MBRoundProgressView_Extensions {
		[CompilerGenerated]
		public static float GetProgress (this IMBRoundProgressView This)
		{
			return ApiDefinition.Messaging.float_objc_msgSend (This.Handle, Selector.GetHandle ("progress"));
		}
		
		[CompilerGenerated]
		public static void SetProgress (this IMBRoundProgressView This, float value)
		{
			ApiDefinition.Messaging.void_objc_msgSend_float (This.Handle, Selector.GetHandle ("setProgress:"), value);
		}
		
		[CompilerGenerated]
		public static global::UIKit.UIColor GetProgressTintColor (this IMBRoundProgressView This)
		{
			return  Runtime.GetNSObject<global::UIKit.UIColor> (ApiDefinition.Messaging.IntPtr_objc_msgSend (This.Handle, Selector.GetHandle ("progressTintColor")));
		}
		
		[CompilerGenerated]
		public static void SetProgressTintColor (this IMBRoundProgressView This, global::UIKit.UIColor value)
		{
			if (value == null)
				throw new ArgumentNullException ("value");
			ApiDefinition.Messaging.void_objc_msgSend_IntPtr (This.Handle, Selector.GetHandle ("setProgressTintColor:"), value.Handle);
		}
		
		[CompilerGenerated]
		public static global::UIKit.UIColor GetBackgroundTintColor (this IMBRoundProgressView This)
		{
			return  Runtime.GetNSObject<global::UIKit.UIColor> (ApiDefinition.Messaging.IntPtr_objc_msgSend (This.Handle, Selector.GetHandle ("backgroundTintColor")));
		}
		
		[CompilerGenerated]
		public static void SetBackgroundTintColor (this IMBRoundProgressView This, global::UIKit.UIColor value)
		{
			if (value == null)
				throw new ArgumentNullException ("value");
			ApiDefinition.Messaging.void_objc_msgSend_IntPtr (This.Handle, Selector.GetHandle ("setBackgroundTintColor:"), value.Handle);
		}
		
		[CompilerGenerated]
		public static bool GetAnnular (this IMBRoundProgressView This)
		{
			return ApiDefinition.Messaging.bool_objc_msgSend (This.Handle, Selector.GetHandle ("annular"));
		}
		
		[CompilerGenerated]
		public static void SetAnnular (this IMBRoundProgressView This, bool value)
		{
			ApiDefinition.Messaging.void_objc_msgSend_bool (This.Handle, Selector.GetHandle ("setAnnular:"), value);
		}
		
	}
	
	internal sealed class MBRoundProgressViewWrapper : BaseWrapper, IMBRoundProgressView {
		public MBRoundProgressViewWrapper (IntPtr handle)
			: base (handle, false)
		{
		}
		
		[Preserve (Conditional = true)]
		public MBRoundProgressViewWrapper (IntPtr handle, bool owns)
			: base (handle, owns)
		{
		}
		
	}
}
namespace MBProgressHUD {
	[Protocol]
	[Register("MBRoundProgressView", true)]
	public unsafe partial class MBRoundProgressView : global::UIKit.UIView, IMBRoundProgressView {
		
		[CompilerGenerated]
		static readonly IntPtr class_ptr = Class.GetHandle ("MBRoundProgressView");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public MBRoundProgressView () : base (NSObjectFlag.Empty)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
			if (IsDirectBinding) {
				InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, global::ObjCRuntime.Selector.GetHandle ("init")), "init");
			} else {
				InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, global::ObjCRuntime.Selector.GetHandle ("init")), "init");
			}
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("initWithCoder:")]
		public MBRoundProgressView (NSCoder coder) : base (NSObjectFlag.Empty)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;

			if (IsDirectBinding) {
				InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("initWithCoder:"), coder.Handle), "initWithCoder:");
			} else {
				InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("initWithCoder:"), coder.Handle), "initWithCoder:");
			}
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected MBRoundProgressView (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal MBRoundProgressView (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		public virtual bool Annular {
			[Export ("isAnnular", ArgumentSemantic.UnsafeUnretained)]
			get {
				if (IsDirectBinding) {
					return ApiDefinition.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("isAnnular"));
				} else {
					return ApiDefinition.Messaging.bool_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("isAnnular"));
				}
			}
			
			[Export ("setAnnular:", ArgumentSemantic.UnsafeUnretained)]
			set {
				if (IsDirectBinding) {
					ApiDefinition.Messaging.void_objc_msgSend_bool (this.Handle, Selector.GetHandle ("setAnnular:"), value);
				} else {
					ApiDefinition.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, Selector.GetHandle ("setAnnular:"), value);
				}
			}
		}
		
		[CompilerGenerated]
		object __mt_BackgroundTintColor_var;
		[CompilerGenerated]
		public virtual global::UIKit.UIColor BackgroundTintColor {
			[Export ("backgroundTintColor", ArgumentSemantic.Retain)]
			get {
				global::UIKit.UIColor ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<global::UIKit.UIColor> (ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("backgroundTintColor")));
				} else {
					ret =  Runtime.GetNSObject<global::UIKit.UIColor> (ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("backgroundTintColor")));
				}
				if (!IsNewRefcountEnabled ())
					__mt_BackgroundTintColor_var = ret;
				return ret;
			}
			
			[Export ("setBackgroundTintColor:", ArgumentSemantic.Retain)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				if (IsDirectBinding) {
					ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setBackgroundTintColor:"), value.Handle);
				} else {
					ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setBackgroundTintColor:"), value.Handle);
				}
				if (!IsNewRefcountEnabled ())
					__mt_BackgroundTintColor_var = value;
			}
		}
		
		[CompilerGenerated]
		public virtual float Progress {
			[Export ("progress", ArgumentSemantic.UnsafeUnretained)]
			get {
				if (IsDirectBinding) {
					return ApiDefinition.Messaging.float_objc_msgSend (this.Handle, Selector.GetHandle ("progress"));
				} else {
					return ApiDefinition.Messaging.float_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("progress"));
				}
			}
			
			[Export ("setProgress:", ArgumentSemantic.UnsafeUnretained)]
			set {
				if (IsDirectBinding) {
					ApiDefinition.Messaging.void_objc_msgSend_float (this.Handle, Selector.GetHandle ("setProgress:"), value);
				} else {
					ApiDefinition.Messaging.void_objc_msgSendSuper_float (this.SuperHandle, Selector.GetHandle ("setProgress:"), value);
				}
			}
		}
		
		[CompilerGenerated]
		object __mt_ProgressTintColor_var;
		[CompilerGenerated]
		public virtual global::UIKit.UIColor ProgressTintColor {
			[Export ("progressTintColor", ArgumentSemantic.Retain)]
			get {
				global::UIKit.UIColor ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<global::UIKit.UIColor> (ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("progressTintColor")));
				} else {
					ret =  Runtime.GetNSObject<global::UIKit.UIColor> (ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("progressTintColor")));
				}
				if (!IsNewRefcountEnabled ())
					__mt_ProgressTintColor_var = ret;
				return ret;
			}
			
			[Export ("setProgressTintColor:", ArgumentSemantic.Retain)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				if (IsDirectBinding) {
					ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setProgressTintColor:"), value.Handle);
				} else {
					ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setProgressTintColor:"), value.Handle);
				}
				if (!IsNewRefcountEnabled ())
					__mt_ProgressTintColor_var = value;
			}
		}
		
		[CompilerGenerated]
		protected override void Dispose (bool disposing)
		{
			base.Dispose (disposing);
			if (Handle == IntPtr.Zero) {
				__mt_BackgroundTintColor_var = null;
				__mt_ProgressTintColor_var = null;
			}
		}
	} /* class MBRoundProgressView */
}
