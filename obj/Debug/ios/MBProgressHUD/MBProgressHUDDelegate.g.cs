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
	[Protocol (Name = "MBProgressHUDDelegate", WrapperType = typeof (MBProgressHUDDelegateWrapper))]
	public interface IMBProgressHUDDelegate : INativeObject, IDisposable
	{
	}
	
	public static partial class MBProgressHUDDelegate_Extensions {
		[CompilerGenerated]
		public static void HudWasHidden (this IMBProgressHUDDelegate This, MTMBProgressHUD hud)
		{
			if (hud == null)
				throw new ArgumentNullException ("hud");
			ApiDefinition.Messaging.void_objc_msgSend_IntPtr (This.Handle, Selector.GetHandle ("hudWasHidden:"), hud.Handle);
		}
		
	}
	
	internal sealed class MBProgressHUDDelegateWrapper : BaseWrapper, IMBProgressHUDDelegate {
		public MBProgressHUDDelegateWrapper (IntPtr handle)
			: base (handle, false)
		{
		}
		
		[Preserve (Conditional = true)]
		public MBProgressHUDDelegateWrapper (IntPtr handle, bool owns)
			: base (handle, owns)
		{
		}
		
	}
}
namespace MBProgressHUD {
	[Protocol]
	[Register("MBProgressHUDDelegate", false)]
	[Model]
	public unsafe partial class MBProgressHUDDelegate : NSObject, IMBProgressHUDDelegate {
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public MBProgressHUDDelegate () : base (NSObjectFlag.Empty)
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
		protected MBProgressHUDDelegate (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal MBProgressHUDDelegate (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[Export ("hudWasHidden:")]
		[CompilerGenerated]
		public virtual void HudWasHidden (MTMBProgressHUD hud)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
	} /* class MBProgressHUDDelegate */
}
