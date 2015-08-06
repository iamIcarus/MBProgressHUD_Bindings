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
	[Protocol (Name = "MBBarProgressView", WrapperType = typeof (MBBarProgressViewWrapper))]
	public interface IMBBarProgressView : INativeObject, IDisposable
	{
	}
	
	public static partial class MBBarProgressView_Extensions {
		[CompilerGenerated]
		public static float GetProgress (this IMBBarProgressView This)
		{
			return ApiDefinition.Messaging.float_objc_msgSend (This.Handle, Selector.GetHandle ("progress"));
		}
		
		[CompilerGenerated]
		public static void SetProgress (this IMBBarProgressView This, float value)
		{
			ApiDefinition.Messaging.void_objc_msgSend_float (This.Handle, Selector.GetHandle ("setProgress:"), value);
		}
		
		[CompilerGenerated]
		public static global::UIKit.UIColor GetLineColor (this IMBBarProgressView This)
		{
			return  Runtime.GetNSObject<global::UIKit.UIColor> (ApiDefinition.Messaging.IntPtr_objc_msgSend (This.Handle, Selector.GetHandle ("lineColor")));
		}
		
		[CompilerGenerated]
		public static void SetLineColor (this IMBBarProgressView This, global::UIKit.UIColor value)
		{
			if (value == null)
				throw new ArgumentNullException ("value");
			ApiDefinition.Messaging.void_objc_msgSend_IntPtr (This.Handle, Selector.GetHandle ("setLineColor:"), value.Handle);
		}
		
		[CompilerGenerated]
		public static global::UIKit.UIColor GetProgressRemainingColor (this IMBBarProgressView This)
		{
			return  Runtime.GetNSObject<global::UIKit.UIColor> (ApiDefinition.Messaging.IntPtr_objc_msgSend (This.Handle, Selector.GetHandle ("progressRemainingColor")));
		}
		
		[CompilerGenerated]
		public static void SetProgressRemainingColor (this IMBBarProgressView This, global::UIKit.UIColor value)
		{
			if (value == null)
				throw new ArgumentNullException ("value");
			ApiDefinition.Messaging.void_objc_msgSend_IntPtr (This.Handle, Selector.GetHandle ("setProgressRemainingColor:"), value.Handle);
		}
		
		[CompilerGenerated]
		public static global::UIKit.UIColor GetProgressColor (this IMBBarProgressView This)
		{
			return  Runtime.GetNSObject<global::UIKit.UIColor> (ApiDefinition.Messaging.IntPtr_objc_msgSend (This.Handle, Selector.GetHandle ("progressColor")));
		}
		
		[CompilerGenerated]
		public static void SetProgressColor (this IMBBarProgressView This, global::UIKit.UIColor value)
		{
			if (value == null)
				throw new ArgumentNullException ("value");
			ApiDefinition.Messaging.void_objc_msgSend_IntPtr (This.Handle, Selector.GetHandle ("setProgressColor:"), value.Handle);
		}
		
	}
	
	internal sealed class MBBarProgressViewWrapper : BaseWrapper, IMBBarProgressView {
		public MBBarProgressViewWrapper (IntPtr handle)
			: base (handle, false)
		{
		}
		
		[Preserve (Conditional = true)]
		public MBBarProgressViewWrapper (IntPtr handle, bool owns)
			: base (handle, owns)
		{
		}
		
	}
}
namespace MBProgressHUD {
	[Protocol]
	[Register("MBBarProgressView", true)]
	public unsafe partial class MBBarProgressView : global::UIKit.UIView, IMBBarProgressView {
		
		[CompilerGenerated]
		static readonly IntPtr class_ptr = Class.GetHandle ("MBBarProgressView");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public MBBarProgressView () : base (NSObjectFlag.Empty)
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
		public MBBarProgressView (NSCoder coder) : base (NSObjectFlag.Empty)
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
		protected MBBarProgressView (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal MBBarProgressView (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		object __mt_LineColor_var;
		[CompilerGenerated]
		public virtual global::UIKit.UIColor LineColor {
			[Export ("lineColor", ArgumentSemantic.Retain)]
			get {
				global::UIKit.UIColor ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<global::UIKit.UIColor> (ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("lineColor")));
				} else {
					ret =  Runtime.GetNSObject<global::UIKit.UIColor> (ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("lineColor")));
				}
				if (!IsNewRefcountEnabled ())
					__mt_LineColor_var = ret;
				return ret;
			}
			
			[Export ("setLineColor:", ArgumentSemantic.Retain)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				if (IsDirectBinding) {
					ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setLineColor:"), value.Handle);
				} else {
					ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setLineColor:"), value.Handle);
				}
				if (!IsNewRefcountEnabled ())
					__mt_LineColor_var = value;
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
		object __mt_ProgressColor_var;
		[CompilerGenerated]
		public virtual global::UIKit.UIColor ProgressColor {
			[Export ("progressColor", ArgumentSemantic.Retain)]
			get {
				global::UIKit.UIColor ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<global::UIKit.UIColor> (ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("progressColor")));
				} else {
					ret =  Runtime.GetNSObject<global::UIKit.UIColor> (ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("progressColor")));
				}
				if (!IsNewRefcountEnabled ())
					__mt_ProgressColor_var = ret;
				return ret;
			}
			
			[Export ("setProgressColor:", ArgumentSemantic.Retain)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				if (IsDirectBinding) {
					ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setProgressColor:"), value.Handle);
				} else {
					ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setProgressColor:"), value.Handle);
				}
				if (!IsNewRefcountEnabled ())
					__mt_ProgressColor_var = value;
			}
		}
		
		[CompilerGenerated]
		object __mt_ProgressRemainingColor_var;
		[CompilerGenerated]
		public virtual global::UIKit.UIColor ProgressRemainingColor {
			[Export ("progressRemainingColor", ArgumentSemantic.Retain)]
			get {
				global::UIKit.UIColor ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<global::UIKit.UIColor> (ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("progressRemainingColor")));
				} else {
					ret =  Runtime.GetNSObject<global::UIKit.UIColor> (ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("progressRemainingColor")));
				}
				if (!IsNewRefcountEnabled ())
					__mt_ProgressRemainingColor_var = ret;
				return ret;
			}
			
			[Export ("setProgressRemainingColor:", ArgumentSemantic.Retain)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				if (IsDirectBinding) {
					ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setProgressRemainingColor:"), value.Handle);
				} else {
					ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setProgressRemainingColor:"), value.Handle);
				}
				if (!IsNewRefcountEnabled ())
					__mt_ProgressRemainingColor_var = value;
			}
		}
		
		[CompilerGenerated]
		protected override void Dispose (bool disposing)
		{
			base.Dispose (disposing);
			if (Handle == IntPtr.Zero) {
				__mt_LineColor_var = null;
				__mt_ProgressColor_var = null;
				__mt_ProgressRemainingColor_var = null;
			}
		}
	} /* class MBBarProgressView */
}
