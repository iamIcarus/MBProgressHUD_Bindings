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
	[Protocol (Name = "MBProgressHUD", WrapperType = typeof (MTMBProgressHUDWrapper))]
	public interface IMTMBProgressHUD : INativeObject, IDisposable
	{
	}
	
	public static partial class MTMBProgressHUD_Extensions {
		[CompilerGenerated]
		public static void Show (this IMTMBProgressHUD This, bool animated)
		{
			ApiDefinition.Messaging.void_objc_msgSend_bool (This.Handle, Selector.GetHandle ("show:"), animated);
		}
		
		[CompilerGenerated]
		public static void Hide (this IMTMBProgressHUD This, bool animated)
		{
			ApiDefinition.Messaging.void_objc_msgSend_bool (This.Handle, Selector.GetHandle ("hide:"), animated);
		}
		
		[CompilerGenerated]
		public static void Hide (this IMTMBProgressHUD This, bool animated, global::System.Double delay)
		{
			ApiDefinition.Messaging.void_objc_msgSend_bool_Double (This.Handle, Selector.GetHandle ("hide:afterDelay:"), animated, delay);
		}
		
		[CompilerGenerated]
		public static void Show (this IMTMBProgressHUD This, Selector method, NSObject target, NSObject aObject, bool animated)
		{
			if (method == null)
				throw new ArgumentNullException ("method");
			if (target == null)
				throw new ArgumentNullException ("target");
			ApiDefinition.Messaging.void_objc_msgSend_IntPtr_IntPtr_IntPtr_bool (This.Handle, Selector.GetHandle ("showWhileExecuting:onTarget:withObject:animated:"), method.Handle, target.Handle, aObject == null ? IntPtr.Zero : aObject.Handle, animated);
		}
		
		[CompilerGenerated]
		public unsafe static void Show (this IMTMBProgressHUD This, bool animated, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDNSDispatchHandlerT))]NSDispatchHandlerT whileExecutingHandler)
		{
			if (whileExecutingHandler == null)
				throw new ArgumentNullException ("whileExecutingHandler");
			BlockLiteral *block_ptr_whileExecutingHandler;
			BlockLiteral block_whileExecutingHandler;
			block_whileExecutingHandler = new BlockLiteral ();
			block_ptr_whileExecutingHandler = &block_whileExecutingHandler;
			block_whileExecutingHandler.SetupBlock (Trampolines.SDNSDispatchHandlerT.Handler, whileExecutingHandler);
			
			ApiDefinition.Messaging.void_objc_msgSend_bool_IntPtr (This.Handle, Selector.GetHandle ("showAnimated:whileExecutingBlock:"), animated, (IntPtr) block_ptr_whileExecutingHandler);
			block_ptr_whileExecutingHandler->CleanupBlock ();
			
		}
		
		[CompilerGenerated]
		public unsafe static void Show (this IMTMBProgressHUD This, bool animated, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDNSDispatchHandlerT))]NSDispatchHandlerT whileExecutingHandler, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDMBProgressHUDCompletionHandler))]MBProgressHUDCompletionHandler completionHandler)
		{
			if (whileExecutingHandler == null)
				throw new ArgumentNullException ("whileExecutingHandler");
			if (completionHandler == null)
				throw new ArgumentNullException ("completionHandler");
			BlockLiteral *block_ptr_whileExecutingHandler;
			BlockLiteral block_whileExecutingHandler;
			block_whileExecutingHandler = new BlockLiteral ();
			block_ptr_whileExecutingHandler = &block_whileExecutingHandler;
			block_whileExecutingHandler.SetupBlock (Trampolines.SDNSDispatchHandlerT.Handler, whileExecutingHandler);
			BlockLiteral *block_ptr_completionHandler;
			BlockLiteral block_completionHandler;
			block_completionHandler = new BlockLiteral ();
			block_ptr_completionHandler = &block_completionHandler;
			block_completionHandler.SetupBlock (Trampolines.SDMBProgressHUDCompletionHandler.Handler, completionHandler);
			
			ApiDefinition.Messaging.void_objc_msgSend_bool_IntPtr_IntPtr (This.Handle, Selector.GetHandle ("showAnimated:whileExecutingBlock:completionBlock:"), animated, (IntPtr) block_ptr_whileExecutingHandler, (IntPtr) block_ptr_completionHandler);
			block_ptr_whileExecutingHandler->CleanupBlock ();
			block_ptr_completionHandler->CleanupBlock ();
			
		}
		
		[CompilerGenerated]
		public unsafe static void Show (this IMTMBProgressHUD This, bool animated, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDNSDispatchHandlerT))]NSDispatchHandlerT whileExecutingHandler, global::CoreFoundation.DispatchQueue queue)
		{
			if (whileExecutingHandler == null)
				throw new ArgumentNullException ("whileExecutingHandler");
			if (queue == null)
				throw new ArgumentNullException ("queue");
			BlockLiteral *block_ptr_whileExecutingHandler;
			BlockLiteral block_whileExecutingHandler;
			block_whileExecutingHandler = new BlockLiteral ();
			block_ptr_whileExecutingHandler = &block_whileExecutingHandler;
			block_whileExecutingHandler.SetupBlock (Trampolines.SDNSDispatchHandlerT.Handler, whileExecutingHandler);
			
			ApiDefinition.Messaging.void_objc_msgSend_bool_IntPtr_IntPtr (This.Handle, Selector.GetHandle ("showAnimated:whileExecutingBlock:onQueue:"), animated, (IntPtr) block_ptr_whileExecutingHandler, queue.Handle);
			block_ptr_whileExecutingHandler->CleanupBlock ();
			
		}
		
		[CompilerGenerated]
		public unsafe static void Show (this IMTMBProgressHUD This, bool animated, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDNSDispatchHandlerT))]NSDispatchHandlerT whileExecutingHandler, global::CoreFoundation.DispatchQueue queue, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDMBProgressHUDCompletionHandler))]MBProgressHUDCompletionHandler completionHandler)
		{
			if (whileExecutingHandler == null)
				throw new ArgumentNullException ("whileExecutingHandler");
			if (queue == null)
				throw new ArgumentNullException ("queue");
			if (completionHandler == null)
				throw new ArgumentNullException ("completionHandler");
			BlockLiteral *block_ptr_whileExecutingHandler;
			BlockLiteral block_whileExecutingHandler;
			block_whileExecutingHandler = new BlockLiteral ();
			block_ptr_whileExecutingHandler = &block_whileExecutingHandler;
			block_whileExecutingHandler.SetupBlock (Trampolines.SDNSDispatchHandlerT.Handler, whileExecutingHandler);
			BlockLiteral *block_ptr_completionHandler;
			BlockLiteral block_completionHandler;
			block_completionHandler = new BlockLiteral ();
			block_ptr_completionHandler = &block_completionHandler;
			block_completionHandler.SetupBlock (Trampolines.SDMBProgressHUDCompletionHandler.Handler, completionHandler);
			
			ApiDefinition.Messaging.void_objc_msgSend_bool_IntPtr_IntPtr_IntPtr (This.Handle, Selector.GetHandle ("showAnimated:whileExecutingBlock:onQueue:completionBlock:"), animated, (IntPtr) block_ptr_whileExecutingHandler, queue.Handle, (IntPtr) block_ptr_completionHandler);
			block_ptr_whileExecutingHandler->CleanupBlock ();
			block_ptr_completionHandler->CleanupBlock ();
			
		}
		
		[CompilerGenerated]
		public unsafe static MBProgressHUDCompletionHandler GetCompletionHandler (this IMTMBProgressHUD This)
		{
			BlockLiteral *ret;
			ret = (BlockLiteral *)ApiDefinition.Messaging.IntPtr_objc_msgSend (This.Handle, Selector.GetHandle ("completionBlock"));
			if (ret == null)
				return null;
			return (MBProgressHUDCompletionHandler) (ret->Target);
		}
		
		[CompilerGenerated]
		public unsafe static void SetCompletionHandler (this IMTMBProgressHUD This, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDMBProgressHUDCompletionHandler))]MBProgressHUDCompletionHandler value)
		{
			if (value == null)
				throw new ArgumentNullException ("value");
			BlockLiteral *block_ptr_value;
			BlockLiteral block_value;
			block_value = new BlockLiteral ();
			block_ptr_value = &block_value;
			block_value.SetupBlock (Trampolines.SDMBProgressHUDCompletionHandler.Handler, value);
			
			ApiDefinition.Messaging.void_objc_msgSend_IntPtr (This.Handle, Selector.GetHandle ("setCompletionBlock:"), (IntPtr) block_ptr_value);
			block_ptr_value->CleanupBlock ();
			
		}
		
		[CompilerGenerated]
		public static MBProgressHUDMode GetMode (this IMTMBProgressHUD This)
		{
			return (MBProgressHUDMode) ApiDefinition.Messaging.int_objc_msgSend (This.Handle, Selector.GetHandle ("mode"));
		}
		
		[CompilerGenerated]
		public static void SetMode (this IMTMBProgressHUD This, MBProgressHUDMode value)
		{
			ApiDefinition.Messaging.void_objc_msgSend_int (This.Handle, Selector.GetHandle ("setMode:"), (int)value);
		}
		
		[CompilerGenerated]
		public static MBProgressHUDAnimation GetAnimationType (this IMTMBProgressHUD This)
		{
			return (MBProgressHUDAnimation) ApiDefinition.Messaging.int_objc_msgSend (This.Handle, Selector.GetHandle ("animationType"));
		}
		
		[CompilerGenerated]
		public static void SetAnimationType (this IMTMBProgressHUD This, MBProgressHUDAnimation value)
		{
			ApiDefinition.Messaging.void_objc_msgSend_int (This.Handle, Selector.GetHandle ("setAnimationType:"), (int)value);
		}
		
		[CompilerGenerated]
		public static global::UIKit.UIView GetCustomView (this IMTMBProgressHUD This)
		{
			return  Runtime.GetNSObject<global::UIKit.UIView> (ApiDefinition.Messaging.IntPtr_objc_msgSend (This.Handle, Selector.GetHandle ("customView")));
		}
		
		[CompilerGenerated]
		public static void SetCustomView (this IMTMBProgressHUD This, global::UIKit.UIView value)
		{
			if (value == null)
				throw new ArgumentNullException ("value");
			ApiDefinition.Messaging.void_objc_msgSend_IntPtr (This.Handle, Selector.GetHandle ("setCustomView:"), value.Handle);
		}
		
		[CompilerGenerated]
		public static NSObject GetWeakDelegate (this IMTMBProgressHUD This)
		{
			return Runtime.GetNSObject (ApiDefinition.Messaging.IntPtr_objc_msgSend (This.Handle, Selector.GetHandle ("delegate")));
		}
		
		[CompilerGenerated]
		public static void SetWeakDelegate (this IMTMBProgressHUD This, NSObject value)
		{
			if (value == null)
				throw new ArgumentNullException ("value");
			ApiDefinition.Messaging.void_objc_msgSend_IntPtr (This.Handle, Selector.GetHandle ("setDelegate:"), value.Handle);
		}
		
		[CompilerGenerated]
		public static string GetLabelText (this IMTMBProgressHUD This)
		{
			return NSString.FromHandle (ApiDefinition.Messaging.IntPtr_objc_msgSend (This.Handle, Selector.GetHandle ("labelText")));
		}
		
		[CompilerGenerated]
		public static void SetLabelText (this IMTMBProgressHUD This, string value)
		{
			if (value == null)
				throw new ArgumentNullException ("value");
			var nsvalue = NSString.CreateNative (value);
			
			ApiDefinition.Messaging.void_objc_msgSend_IntPtr (This.Handle, Selector.GetHandle ("setLabelText:"), nsvalue);
			NSString.ReleaseNative (nsvalue);
			
		}
		
		[CompilerGenerated]
		public static string GetDetailsLabelText (this IMTMBProgressHUD This)
		{
			return NSString.FromHandle (ApiDefinition.Messaging.IntPtr_objc_msgSend (This.Handle, Selector.GetHandle ("detailsLabelText")));
		}
		
		[CompilerGenerated]
		public static void SetDetailsLabelText (this IMTMBProgressHUD This, string value)
		{
			if (value == null)
				throw new ArgumentNullException ("value");
			var nsvalue = NSString.CreateNative (value);
			
			ApiDefinition.Messaging.void_objc_msgSend_IntPtr (This.Handle, Selector.GetHandle ("setDetailsLabelText:"), nsvalue);
			NSString.ReleaseNative (nsvalue);
			
		}
		
		[CompilerGenerated]
		public static float GetOpacity (this IMTMBProgressHUD This)
		{
			return ApiDefinition.Messaging.float_objc_msgSend (This.Handle, Selector.GetHandle ("opacity"));
		}
		
		[CompilerGenerated]
		public static void SetOpacity (this IMTMBProgressHUD This, float value)
		{
			ApiDefinition.Messaging.void_objc_msgSend_float (This.Handle, Selector.GetHandle ("setOpacity:"), value);
		}
		
		[CompilerGenerated]
		public static global::UIKit.UIColor GetColor (this IMTMBProgressHUD This)
		{
			return  Runtime.GetNSObject<global::UIKit.UIColor> (ApiDefinition.Messaging.IntPtr_objc_msgSend (This.Handle, Selector.GetHandle ("color")));
		}
		
		[CompilerGenerated]
		public static void SetColor (this IMTMBProgressHUD This, global::UIKit.UIColor value)
		{
			if (value == null)
				throw new ArgumentNullException ("value");
			ApiDefinition.Messaging.void_objc_msgSend_IntPtr (This.Handle, Selector.GetHandle ("setColor:"), value.Handle);
		}
		
		[CompilerGenerated]
		public static float GetXOffset (this IMTMBProgressHUD This)
		{
			return ApiDefinition.Messaging.float_objc_msgSend (This.Handle, Selector.GetHandle ("xOffset"));
		}
		
		[CompilerGenerated]
		public static void SetXOffset (this IMTMBProgressHUD This, float value)
		{
			ApiDefinition.Messaging.void_objc_msgSend_float (This.Handle, Selector.GetHandle ("setXOffset:"), value);
		}
		
		[CompilerGenerated]
		public static float GetYOffset (this IMTMBProgressHUD This)
		{
			return ApiDefinition.Messaging.float_objc_msgSend (This.Handle, Selector.GetHandle ("yOffset"));
		}
		
		[CompilerGenerated]
		public static void SetYOffset (this IMTMBProgressHUD This, float value)
		{
			ApiDefinition.Messaging.void_objc_msgSend_float (This.Handle, Selector.GetHandle ("setYOffset:"), value);
		}
		
		[CompilerGenerated]
		public static float GetMargin (this IMTMBProgressHUD This)
		{
			return ApiDefinition.Messaging.float_objc_msgSend (This.Handle, Selector.GetHandle ("margin"));
		}
		
		[CompilerGenerated]
		public static void SetMargin (this IMTMBProgressHUD This, float value)
		{
			ApiDefinition.Messaging.void_objc_msgSend_float (This.Handle, Selector.GetHandle ("setMargin:"), value);
		}
		
		[CompilerGenerated]
		public static float GetCornerRadius (this IMTMBProgressHUD This)
		{
			return ApiDefinition.Messaging.float_objc_msgSend (This.Handle, Selector.GetHandle ("cornerRadius"));
		}
		
		[CompilerGenerated]
		public static void SetCornerRadius (this IMTMBProgressHUD This, float value)
		{
			ApiDefinition.Messaging.void_objc_msgSend_float (This.Handle, Selector.GetHandle ("setCornerRadius:"), value);
		}
		
		[CompilerGenerated]
		public static bool GetDimBackground (this IMTMBProgressHUD This)
		{
			return ApiDefinition.Messaging.bool_objc_msgSend (This.Handle, Selector.GetHandle ("dimBackground"));
		}
		
		[CompilerGenerated]
		public static void SetDimBackground (this IMTMBProgressHUD This, bool value)
		{
			ApiDefinition.Messaging.void_objc_msgSend_bool (This.Handle, Selector.GetHandle ("setDimBackground:"), value);
		}
		
		[CompilerGenerated]
		public static float GetGraceTime (this IMTMBProgressHUD This)
		{
			return ApiDefinition.Messaging.float_objc_msgSend (This.Handle, Selector.GetHandle ("graceTime"));
		}
		
		[CompilerGenerated]
		public static void SetGraceTime (this IMTMBProgressHUD This, float value)
		{
			ApiDefinition.Messaging.void_objc_msgSend_float (This.Handle, Selector.GetHandle ("setGraceTime:"), value);
		}
		
		[CompilerGenerated]
		public static float GetMinShowTime (this IMTMBProgressHUD This)
		{
			return ApiDefinition.Messaging.float_objc_msgSend (This.Handle, Selector.GetHandle ("minShowTime"));
		}
		
		[CompilerGenerated]
		public static void SetMinShowTime (this IMTMBProgressHUD This, float value)
		{
			ApiDefinition.Messaging.void_objc_msgSend_float (This.Handle, Selector.GetHandle ("setMinShowTime:"), value);
		}
		
		[CompilerGenerated]
		public static bool GetTaskInProgress (this IMTMBProgressHUD This)
		{
			return ApiDefinition.Messaging.bool_objc_msgSend (This.Handle, Selector.GetHandle ("taskInProgress"));
		}
		
		[CompilerGenerated]
		public static void SetTaskInProgress (this IMTMBProgressHUD This, bool value)
		{
			ApiDefinition.Messaging.void_objc_msgSend_bool (This.Handle, Selector.GetHandle ("setTaskInProgress:"), value);
		}
		
		[CompilerGenerated]
		public static bool GetRemoveFromSuperViewOnHide (this IMTMBProgressHUD This)
		{
			return ApiDefinition.Messaging.bool_objc_msgSend (This.Handle, Selector.GetHandle ("removeFromSuperViewOnHide"));
		}
		
		[CompilerGenerated]
		public static void SetRemoveFromSuperViewOnHide (this IMTMBProgressHUD This, bool value)
		{
			ApiDefinition.Messaging.void_objc_msgSend_bool (This.Handle, Selector.GetHandle ("setRemoveFromSuperViewOnHide:"), value);
		}
		
		[CompilerGenerated]
		public static global::UIKit.UIFont GetLabelFont (this IMTMBProgressHUD This)
		{
			return  Runtime.GetNSObject<global::UIKit.UIFont> (ApiDefinition.Messaging.IntPtr_objc_msgSend (This.Handle, Selector.GetHandle ("labelFont")));
		}
		
		[CompilerGenerated]
		public static void SetLabelFont (this IMTMBProgressHUD This, global::UIKit.UIFont value)
		{
			if (value == null)
				throw new ArgumentNullException ("value");
			ApiDefinition.Messaging.void_objc_msgSend_IntPtr (This.Handle, Selector.GetHandle ("setLabelFont:"), value.Handle);
		}
		
		[CompilerGenerated]
		public static global::UIKit.UIColor GetLabelColor (this IMTMBProgressHUD This)
		{
			return  Runtime.GetNSObject<global::UIKit.UIColor> (ApiDefinition.Messaging.IntPtr_objc_msgSend (This.Handle, Selector.GetHandle ("labelColor")));
		}
		
		[CompilerGenerated]
		public static void SetLabelColor (this IMTMBProgressHUD This, global::UIKit.UIColor value)
		{
			if (value == null)
				throw new ArgumentNullException ("value");
			ApiDefinition.Messaging.void_objc_msgSend_IntPtr (This.Handle, Selector.GetHandle ("setLabelColor:"), value.Handle);
		}
		
		[CompilerGenerated]
		public static global::UIKit.UIFont GetDetailsLabelFont (this IMTMBProgressHUD This)
		{
			return  Runtime.GetNSObject<global::UIKit.UIFont> (ApiDefinition.Messaging.IntPtr_objc_msgSend (This.Handle, Selector.GetHandle ("detailsLabelFont")));
		}
		
		[CompilerGenerated]
		public static void SetDetailsLabelFont (this IMTMBProgressHUD This, global::UIKit.UIFont value)
		{
			if (value == null)
				throw new ArgumentNullException ("value");
			ApiDefinition.Messaging.void_objc_msgSend_IntPtr (This.Handle, Selector.GetHandle ("setDetailsLabelFont:"), value.Handle);
		}
		
		[CompilerGenerated]
		public static global::UIKit.UIColor GetDetailsLabelColor (this IMTMBProgressHUD This)
		{
			return  Runtime.GetNSObject<global::UIKit.UIColor> (ApiDefinition.Messaging.IntPtr_objc_msgSend (This.Handle, Selector.GetHandle ("detailsLabelColor")));
		}
		
		[CompilerGenerated]
		public static void SetDetailsLabelColor (this IMTMBProgressHUD This, global::UIKit.UIColor value)
		{
			if (value == null)
				throw new ArgumentNullException ("value");
			ApiDefinition.Messaging.void_objc_msgSend_IntPtr (This.Handle, Selector.GetHandle ("setDetailsLabelColor:"), value.Handle);
		}
		
		[CompilerGenerated]
		public static float GetProgress (this IMTMBProgressHUD This)
		{
			return ApiDefinition.Messaging.float_objc_msgSend (This.Handle, Selector.GetHandle ("progress"));
		}
		
		[CompilerGenerated]
		public static void SetProgress (this IMTMBProgressHUD This, float value)
		{
			ApiDefinition.Messaging.void_objc_msgSend_float (This.Handle, Selector.GetHandle ("setProgress:"), value);
		}
		
		[CompilerGenerated]
		public static global::System.Drawing.SizeF GetMinSize (this IMTMBProgressHUD This)
		{
			global::System.Drawing.SizeF ret;
			if (Runtime.Arch == Arch.DEVICE) {
				if (IntPtr.Size == 8) {
					ret = ApiDefinition.Messaging.SizeF_objc_msgSend (This.Handle, Selector.GetHandle ("minSize"));
				} else {
					ApiDefinition.Messaging.SizeF_objc_msgSend_stret (out ret, This.Handle, Selector.GetHandle ("minSize"));
				}
			} else if (IntPtr.Size == 8) {
				ret = ApiDefinition.Messaging.SizeF_objc_msgSend (This.Handle, Selector.GetHandle ("minSize"));
			} else {
				ret = ApiDefinition.Messaging.SizeF_objc_msgSend (This.Handle, Selector.GetHandle ("minSize"));
			}
			return ret;
		}
		
		[CompilerGenerated]
		public static void SetMinSize (this IMTMBProgressHUD This, global::System.Drawing.SizeF value)
		{
			ApiDefinition.Messaging.void_objc_msgSend_SizeF (This.Handle, Selector.GetHandle ("setMinSize:"), value);
		}
		
		[CompilerGenerated]
		public static bool GetSquare (this IMTMBProgressHUD This)
		{
			return ApiDefinition.Messaging.bool_objc_msgSend (This.Handle, Selector.GetHandle ("square"));
		}
		
		[CompilerGenerated]
		public static void SetSquare (this IMTMBProgressHUD This, bool value)
		{
			ApiDefinition.Messaging.void_objc_msgSend_bool (This.Handle, Selector.GetHandle ("setSquare:"), value);
		}
		
	}
	
	internal sealed class MTMBProgressHUDWrapper : BaseWrapper, IMTMBProgressHUD {
		public MTMBProgressHUDWrapper (IntPtr handle)
			: base (handle, false)
		{
		}
		
		[Preserve (Conditional = true)]
		public MTMBProgressHUDWrapper (IntPtr handle, bool owns)
			: base (handle, owns)
		{
		}
		
	}
}
namespace MBProgressHUD {
	[Protocol]
	[Register("MBProgressHUD", true)]
	public unsafe partial class MTMBProgressHUD : global::UIKit.UIView, IMTMBProgressHUD {
		
		[CompilerGenerated]
		static readonly IntPtr class_ptr = Class.GetHandle ("MBProgressHUD");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public MTMBProgressHUD () : base (NSObjectFlag.Empty)
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
		public MTMBProgressHUD (NSCoder coder) : base (NSObjectFlag.Empty)
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
		protected MTMBProgressHUD (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal MTMBProgressHUD (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[Export ("initWithWindow:")]
		[CompilerGenerated]
		public MTMBProgressHUD (global::UIKit.UIWindow window)
			: base (NSObjectFlag.Empty)
		{
			if (window == null)
				throw new ArgumentNullException ("window");
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
			if (IsDirectBinding) {
				InitializeHandle (ApiDefinition.Messaging.IntPtr_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("initWithWindow:"), window.Handle), "initWithWindow:");
			} else {
				InitializeHandle (ApiDefinition.Messaging.IntPtr_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("initWithWindow:"), window.Handle), "initWithWindow:");
			}
		}
		
		[Export ("initWithView:")]
		[CompilerGenerated]
		public MTMBProgressHUD (global::UIKit.UIView view)
			: base (NSObjectFlag.Empty)
		{
			if (view == null)
				throw new ArgumentNullException ("view");
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
			if (IsDirectBinding) {
				InitializeHandle (ApiDefinition.Messaging.IntPtr_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("initWithView:"), view.Handle), "initWithView:");
			} else {
				InitializeHandle (ApiDefinition.Messaging.IntPtr_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("initWithView:"), view.Handle), "initWithView:");
			}
		}
		
		[Export ("allHUDsForView:")]
		[CompilerGenerated]
		public static MTMBProgressHUD[] AllHUDsForView (global::UIKit.UIView view)
		{
			if (view == null)
				throw new ArgumentNullException ("view");
			return NSArray.ArrayFromHandle<MBProgressHUD.MTMBProgressHUD>(ApiDefinition.Messaging.IntPtr_objc_msgSend_IntPtr (class_ptr, Selector.GetHandle ("allHUDsForView:"), view.Handle));
		}
		
		[Export ("hide:")]
		[CompilerGenerated]
		public virtual void Hide (bool animated)
		{
			if (IsDirectBinding) {
				ApiDefinition.Messaging.void_objc_msgSend_bool (this.Handle, Selector.GetHandle ("hide:"), animated);
			} else {
				ApiDefinition.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, Selector.GetHandle ("hide:"), animated);
			}
		}
		
		[Export ("hide:afterDelay:")]
		[CompilerGenerated]
		public virtual void Hide (bool animated, global::System.Double delay)
		{
			if (IsDirectBinding) {
				ApiDefinition.Messaging.void_objc_msgSend_bool_Double (this.Handle, Selector.GetHandle ("hide:afterDelay:"), animated, delay);
			} else {
				ApiDefinition.Messaging.void_objc_msgSendSuper_bool_Double (this.SuperHandle, Selector.GetHandle ("hide:afterDelay:"), animated, delay);
			}
		}
		
		[Export ("hideAllHUDsForView:animated:")]
		[CompilerGenerated]
		public static global::System.UInt32 HideAllHUDs (global::UIKit.UIView view, bool animated)
		{
			if (view == null)
				throw new ArgumentNullException ("view");
			return ApiDefinition.Messaging.UInt32_objc_msgSend_IntPtr_bool (class_ptr, Selector.GetHandle ("hideAllHUDsForView:animated:"), view.Handle, animated);
		}
		
		[Export ("hideHUDForView:animated:")]
		[CompilerGenerated]
		public static bool HideHUD (global::UIKit.UIView view, bool animated)
		{
			if (view == null)
				throw new ArgumentNullException ("view");
			return ApiDefinition.Messaging.bool_objc_msgSend_IntPtr_bool (class_ptr, Selector.GetHandle ("hideHUDForView:animated:"), view.Handle, animated);
		}
		
		[Export ("HUDForView:")]
		[CompilerGenerated]
		public static MTMBProgressHUD HUDForView (global::UIKit.UIView view)
		{
			if (view == null)
				throw new ArgumentNullException ("view");
			return  Runtime.GetNSObject<MTMBProgressHUD> (ApiDefinition.Messaging.IntPtr_objc_msgSend_IntPtr (class_ptr, Selector.GetHandle ("HUDForView:"), view.Handle));
		}
		
		[Export ("show:")]
		[CompilerGenerated]
		public virtual void Show (bool animated)
		{
			if (IsDirectBinding) {
				ApiDefinition.Messaging.void_objc_msgSend_bool (this.Handle, Selector.GetHandle ("show:"), animated);
			} else {
				ApiDefinition.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, Selector.GetHandle ("show:"), animated);
			}
		}
		
		[Export ("showWhileExecuting:onTarget:withObject:animated:")]
		[CompilerGenerated]
		public virtual void Show (Selector method, NSObject target, NSObject aObject, bool animated)
		{
			if (method == null)
				throw new ArgumentNullException ("method");
			if (target == null)
				throw new ArgumentNullException ("target");
			if (IsDirectBinding) {
				ApiDefinition.Messaging.void_objc_msgSend_IntPtr_IntPtr_IntPtr_bool (this.Handle, Selector.GetHandle ("showWhileExecuting:onTarget:withObject:animated:"), method.Handle, target.Handle, aObject == null ? IntPtr.Zero : aObject.Handle, animated);
			} else {
				ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr_IntPtr_IntPtr_bool (this.SuperHandle, Selector.GetHandle ("showWhileExecuting:onTarget:withObject:animated:"), method.Handle, target.Handle, aObject == null ? IntPtr.Zero : aObject.Handle, animated);
			}
		}
		
		[Export ("showAnimated:whileExecutingBlock:")]
		[CompilerGenerated]
		public unsafe virtual void Show (bool animated, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDNSDispatchHandlerT))]NSDispatchHandlerT whileExecutingHandler)
		{
			if (whileExecutingHandler == null)
				throw new ArgumentNullException ("whileExecutingHandler");
			BlockLiteral *block_ptr_whileExecutingHandler;
			BlockLiteral block_whileExecutingHandler;
			block_whileExecutingHandler = new BlockLiteral ();
			block_ptr_whileExecutingHandler = &block_whileExecutingHandler;
			block_whileExecutingHandler.SetupBlock (Trampolines.SDNSDispatchHandlerT.Handler, whileExecutingHandler);
			
			if (IsDirectBinding) {
				ApiDefinition.Messaging.void_objc_msgSend_bool_IntPtr (this.Handle, Selector.GetHandle ("showAnimated:whileExecutingBlock:"), animated, (IntPtr) block_ptr_whileExecutingHandler);
			} else {
				ApiDefinition.Messaging.void_objc_msgSendSuper_bool_IntPtr (this.SuperHandle, Selector.GetHandle ("showAnimated:whileExecutingBlock:"), animated, (IntPtr) block_ptr_whileExecutingHandler);
			}
			block_ptr_whileExecutingHandler->CleanupBlock ();
			
		}
		
		[Export ("showAnimated:whileExecutingBlock:completionBlock:")]
		[CompilerGenerated]
		public unsafe virtual void Show (bool animated, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDNSDispatchHandlerT))]NSDispatchHandlerT whileExecutingHandler, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDMBProgressHUDCompletionHandler))]MBProgressHUDCompletionHandler completionHandler)
		{
			if (whileExecutingHandler == null)
				throw new ArgumentNullException ("whileExecutingHandler");
			if (completionHandler == null)
				throw new ArgumentNullException ("completionHandler");
			BlockLiteral *block_ptr_whileExecutingHandler;
			BlockLiteral block_whileExecutingHandler;
			block_whileExecutingHandler = new BlockLiteral ();
			block_ptr_whileExecutingHandler = &block_whileExecutingHandler;
			block_whileExecutingHandler.SetupBlock (Trampolines.SDNSDispatchHandlerT.Handler, whileExecutingHandler);
			BlockLiteral *block_ptr_completionHandler;
			BlockLiteral block_completionHandler;
			block_completionHandler = new BlockLiteral ();
			block_ptr_completionHandler = &block_completionHandler;
			block_completionHandler.SetupBlock (Trampolines.SDMBProgressHUDCompletionHandler.Handler, completionHandler);
			
			if (IsDirectBinding) {
				ApiDefinition.Messaging.void_objc_msgSend_bool_IntPtr_IntPtr (this.Handle, Selector.GetHandle ("showAnimated:whileExecutingBlock:completionBlock:"), animated, (IntPtr) block_ptr_whileExecutingHandler, (IntPtr) block_ptr_completionHandler);
			} else {
				ApiDefinition.Messaging.void_objc_msgSendSuper_bool_IntPtr_IntPtr (this.SuperHandle, Selector.GetHandle ("showAnimated:whileExecutingBlock:completionBlock:"), animated, (IntPtr) block_ptr_whileExecutingHandler, (IntPtr) block_ptr_completionHandler);
			}
			block_ptr_whileExecutingHandler->CleanupBlock ();
			block_ptr_completionHandler->CleanupBlock ();
			
		}
		
		[Export ("showAnimated:whileExecutingBlock:onQueue:")]
		[CompilerGenerated]
		public unsafe virtual void Show (bool animated, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDNSDispatchHandlerT))]NSDispatchHandlerT whileExecutingHandler, global::CoreFoundation.DispatchQueue queue)
		{
			if (whileExecutingHandler == null)
				throw new ArgumentNullException ("whileExecutingHandler");
			if (queue == null)
				throw new ArgumentNullException ("queue");
			BlockLiteral *block_ptr_whileExecutingHandler;
			BlockLiteral block_whileExecutingHandler;
			block_whileExecutingHandler = new BlockLiteral ();
			block_ptr_whileExecutingHandler = &block_whileExecutingHandler;
			block_whileExecutingHandler.SetupBlock (Trampolines.SDNSDispatchHandlerT.Handler, whileExecutingHandler);
			
			if (IsDirectBinding) {
				ApiDefinition.Messaging.void_objc_msgSend_bool_IntPtr_IntPtr (this.Handle, Selector.GetHandle ("showAnimated:whileExecutingBlock:onQueue:"), animated, (IntPtr) block_ptr_whileExecutingHandler, queue.Handle);
			} else {
				ApiDefinition.Messaging.void_objc_msgSendSuper_bool_IntPtr_IntPtr (this.SuperHandle, Selector.GetHandle ("showAnimated:whileExecutingBlock:onQueue:"), animated, (IntPtr) block_ptr_whileExecutingHandler, queue.Handle);
			}
			block_ptr_whileExecutingHandler->CleanupBlock ();
			
		}
		
		[Export ("showAnimated:whileExecutingBlock:onQueue:completionBlock:")]
		[CompilerGenerated]
		public unsafe virtual void Show (bool animated, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDNSDispatchHandlerT))]NSDispatchHandlerT whileExecutingHandler, global::CoreFoundation.DispatchQueue queue, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDMBProgressHUDCompletionHandler))]MBProgressHUDCompletionHandler completionHandler)
		{
			if (whileExecutingHandler == null)
				throw new ArgumentNullException ("whileExecutingHandler");
			if (queue == null)
				throw new ArgumentNullException ("queue");
			if (completionHandler == null)
				throw new ArgumentNullException ("completionHandler");
			BlockLiteral *block_ptr_whileExecutingHandler;
			BlockLiteral block_whileExecutingHandler;
			block_whileExecutingHandler = new BlockLiteral ();
			block_ptr_whileExecutingHandler = &block_whileExecutingHandler;
			block_whileExecutingHandler.SetupBlock (Trampolines.SDNSDispatchHandlerT.Handler, whileExecutingHandler);
			BlockLiteral *block_ptr_completionHandler;
			BlockLiteral block_completionHandler;
			block_completionHandler = new BlockLiteral ();
			block_ptr_completionHandler = &block_completionHandler;
			block_completionHandler.SetupBlock (Trampolines.SDMBProgressHUDCompletionHandler.Handler, completionHandler);
			
			if (IsDirectBinding) {
				ApiDefinition.Messaging.void_objc_msgSend_bool_IntPtr_IntPtr_IntPtr (this.Handle, Selector.GetHandle ("showAnimated:whileExecutingBlock:onQueue:completionBlock:"), animated, (IntPtr) block_ptr_whileExecutingHandler, queue.Handle, (IntPtr) block_ptr_completionHandler);
			} else {
				ApiDefinition.Messaging.void_objc_msgSendSuper_bool_IntPtr_IntPtr_IntPtr (this.SuperHandle, Selector.GetHandle ("showAnimated:whileExecutingBlock:onQueue:completionBlock:"), animated, (IntPtr) block_ptr_whileExecutingHandler, queue.Handle, (IntPtr) block_ptr_completionHandler);
			}
			block_ptr_whileExecutingHandler->CleanupBlock ();
			block_ptr_completionHandler->CleanupBlock ();
			
		}
		
		[Export ("showHUDAddedTo:animated:")]
		[CompilerGenerated]
		public static MTMBProgressHUD ShowHUD (global::UIKit.UIView view, bool animated)
		{
			if (view == null)
				throw new ArgumentNullException ("view");
			return  Runtime.GetNSObject<MTMBProgressHUD> (ApiDefinition.Messaging.IntPtr_objc_msgSend_IntPtr_bool (class_ptr, Selector.GetHandle ("showHUDAddedTo:animated:"), view.Handle, animated));
		}
		
		[CompilerGenerated]
		public virtual MBProgressHUDAnimation AnimationType {
			[Export ("animationType", ArgumentSemantic.UnsafeUnretained)]
			get {
				if (IsDirectBinding) {
					return (MBProgressHUDAnimation) ApiDefinition.Messaging.int_objc_msgSend (this.Handle, Selector.GetHandle ("animationType"));
				} else {
					return (MBProgressHUDAnimation) ApiDefinition.Messaging.int_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("animationType"));
				}
			}
			
			[Export ("setAnimationType:", ArgumentSemantic.UnsafeUnretained)]
			set {
				if (IsDirectBinding) {
					ApiDefinition.Messaging.void_objc_msgSend_int (this.Handle, Selector.GetHandle ("setAnimationType:"), (int)value);
				} else {
					ApiDefinition.Messaging.void_objc_msgSendSuper_int (this.SuperHandle, Selector.GetHandle ("setAnimationType:"), (int)value);
				}
			}
		}
		
		[CompilerGenerated]
		object __mt_Color_var;
		[CompilerGenerated]
		public virtual global::UIKit.UIColor Color {
			[Export ("color", ArgumentSemantic.Retain)]
			get {
				global::UIKit.UIColor ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<global::UIKit.UIColor> (ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("color")));
				} else {
					ret =  Runtime.GetNSObject<global::UIKit.UIColor> (ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("color")));
				}
				if (!IsNewRefcountEnabled ())
					__mt_Color_var = ret;
				return ret;
			}
			
			[Export ("setColor:", ArgumentSemantic.Retain)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				if (IsDirectBinding) {
					ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setColor:"), value.Handle);
				} else {
					ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setColor:"), value.Handle);
				}
				if (!IsNewRefcountEnabled ())
					__mt_Color_var = value;
			}
		}
		
		[CompilerGenerated]
		public unsafe virtual MBProgressHUDCompletionHandler CompletionHandler {
			[Export ("completionBlock", ArgumentSemantic.Copy)]
			get {
				BlockLiteral *ret;
				if (IsDirectBinding) {
					ret = (BlockLiteral *)ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("completionBlock"));
				} else {
					ret = (BlockLiteral *)ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("completionBlock"));
				}
				if (ret == null)
					return null;
				return (MBProgressHUDCompletionHandler) (ret->Target);
			}
			
			[Export ("setCompletionBlock:", ArgumentSemantic.Copy)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				BlockLiteral *block_ptr_value;
				BlockLiteral block_value;
				block_value = new BlockLiteral ();
				block_ptr_value = &block_value;
				block_value.SetupBlock (Trampolines.SDMBProgressHUDCompletionHandler.Handler, value);
				
				if (IsDirectBinding) {
					ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setCompletionBlock:"), (IntPtr) block_ptr_value);
				} else {
					ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setCompletionBlock:"), (IntPtr) block_ptr_value);
				}
				block_ptr_value->CleanupBlock ();
				
			}
		}
		
		[CompilerGenerated]
		public virtual float CornerRadius {
			[Export ("cornerRadius", ArgumentSemantic.UnsafeUnretained)]
			get {
				if (IsDirectBinding) {
					return ApiDefinition.Messaging.float_objc_msgSend (this.Handle, Selector.GetHandle ("cornerRadius"));
				} else {
					return ApiDefinition.Messaging.float_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("cornerRadius"));
				}
			}
			
			[Export ("setCornerRadius:", ArgumentSemantic.UnsafeUnretained)]
			set {
				if (IsDirectBinding) {
					ApiDefinition.Messaging.void_objc_msgSend_float (this.Handle, Selector.GetHandle ("setCornerRadius:"), value);
				} else {
					ApiDefinition.Messaging.void_objc_msgSendSuper_float (this.SuperHandle, Selector.GetHandle ("setCornerRadius:"), value);
				}
			}
		}
		
		[CompilerGenerated]
		object __mt_CustomView_var;
		[CompilerGenerated]
		public virtual global::UIKit.UIView CustomView {
			[Export ("customView", ArgumentSemantic.Retain)]
			get {
				global::UIKit.UIView ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<global::UIKit.UIView> (ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("customView")));
				} else {
					ret =  Runtime.GetNSObject<global::UIKit.UIView> (ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("customView")));
				}
				if (!IsNewRefcountEnabled ())
					__mt_CustomView_var = ret;
				return ret;
			}
			
			[Export ("setCustomView:", ArgumentSemantic.Retain)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				if (IsDirectBinding) {
					ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setCustomView:"), value.Handle);
				} else {
					ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setCustomView:"), value.Handle);
				}
				if (!IsNewRefcountEnabled ())
					__mt_CustomView_var = value;
			}
		}
		
		[CompilerGenerated]
		public MBProgressHUDDelegate Delegate {
			get {
				return WeakDelegate as /**/MBProgressHUDDelegate;
			}
			set {
				WeakDelegate = value;
			}
		}
		
		[CompilerGenerated]
		object __mt_DetailsLabelColor_var;
		[CompilerGenerated]
		public virtual global::UIKit.UIColor DetailsLabelColor {
			[Export ("detailsLabelColor", ArgumentSemantic.Retain)]
			get {
				global::UIKit.UIColor ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<global::UIKit.UIColor> (ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("detailsLabelColor")));
				} else {
					ret =  Runtime.GetNSObject<global::UIKit.UIColor> (ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("detailsLabelColor")));
				}
				if (!IsNewRefcountEnabled ())
					__mt_DetailsLabelColor_var = ret;
				return ret;
			}
			
			[Export ("setDetailsLabelColor:", ArgumentSemantic.Retain)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				if (IsDirectBinding) {
					ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setDetailsLabelColor:"), value.Handle);
				} else {
					ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setDetailsLabelColor:"), value.Handle);
				}
				if (!IsNewRefcountEnabled ())
					__mt_DetailsLabelColor_var = value;
			}
		}
		
		[CompilerGenerated]
		object __mt_DetailsLabelFont_var;
		[CompilerGenerated]
		public virtual global::UIKit.UIFont DetailsLabelFont {
			[Export ("detailsLabelFont", ArgumentSemantic.Retain)]
			get {
				global::UIKit.UIFont ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<global::UIKit.UIFont> (ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("detailsLabelFont")));
				} else {
					ret =  Runtime.GetNSObject<global::UIKit.UIFont> (ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("detailsLabelFont")));
				}
				if (!IsNewRefcountEnabled ())
					__mt_DetailsLabelFont_var = ret;
				return ret;
			}
			
			[Export ("setDetailsLabelFont:", ArgumentSemantic.Retain)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				if (IsDirectBinding) {
					ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setDetailsLabelFont:"), value.Handle);
				} else {
					ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setDetailsLabelFont:"), value.Handle);
				}
				if (!IsNewRefcountEnabled ())
					__mt_DetailsLabelFont_var = value;
			}
		}
		
		[CompilerGenerated]
		public virtual string DetailsLabelText {
			[Export ("detailsLabelText", ArgumentSemantic.Copy)]
			get {
				if (IsDirectBinding) {
					return NSString.FromHandle (ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("detailsLabelText")));
				} else {
					return NSString.FromHandle (ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("detailsLabelText")));
				}
			}
			
			[Export ("setDetailsLabelText:", ArgumentSemantic.Copy)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				var nsvalue = NSString.CreateNative (value);
				
				if (IsDirectBinding) {
					ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setDetailsLabelText:"), nsvalue);
				} else {
					ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setDetailsLabelText:"), nsvalue);
				}
				NSString.ReleaseNative (nsvalue);
				
			}
		}
		
		[CompilerGenerated]
		public virtual bool DimBackground {
			[Export ("dimBackground", ArgumentSemantic.UnsafeUnretained)]
			get {
				if (IsDirectBinding) {
					return ApiDefinition.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("dimBackground"));
				} else {
					return ApiDefinition.Messaging.bool_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("dimBackground"));
				}
			}
			
			[Export ("setDimBackground:", ArgumentSemantic.UnsafeUnretained)]
			set {
				if (IsDirectBinding) {
					ApiDefinition.Messaging.void_objc_msgSend_bool (this.Handle, Selector.GetHandle ("setDimBackground:"), value);
				} else {
					ApiDefinition.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, Selector.GetHandle ("setDimBackground:"), value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual float GraceTime {
			[Export ("graceTime", ArgumentSemantic.UnsafeUnretained)]
			get {
				if (IsDirectBinding) {
					return ApiDefinition.Messaging.float_objc_msgSend (this.Handle, Selector.GetHandle ("graceTime"));
				} else {
					return ApiDefinition.Messaging.float_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("graceTime"));
				}
			}
			
			[Export ("setGraceTime:", ArgumentSemantic.UnsafeUnretained)]
			set {
				if (IsDirectBinding) {
					ApiDefinition.Messaging.void_objc_msgSend_float (this.Handle, Selector.GetHandle ("setGraceTime:"), value);
				} else {
					ApiDefinition.Messaging.void_objc_msgSendSuper_float (this.SuperHandle, Selector.GetHandle ("setGraceTime:"), value);
				}
			}
		}
		
		[CompilerGenerated]
		object __mt_LabelColor_var;
		[CompilerGenerated]
		public virtual global::UIKit.UIColor LabelColor {
			[Export ("labelColor", ArgumentSemantic.Retain)]
			get {
				global::UIKit.UIColor ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<global::UIKit.UIColor> (ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("labelColor")));
				} else {
					ret =  Runtime.GetNSObject<global::UIKit.UIColor> (ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("labelColor")));
				}
				if (!IsNewRefcountEnabled ())
					__mt_LabelColor_var = ret;
				return ret;
			}
			
			[Export ("setLabelColor:", ArgumentSemantic.Retain)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				if (IsDirectBinding) {
					ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setLabelColor:"), value.Handle);
				} else {
					ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setLabelColor:"), value.Handle);
				}
				if (!IsNewRefcountEnabled ())
					__mt_LabelColor_var = value;
			}
		}
		
		[CompilerGenerated]
		object __mt_LabelFont_var;
		[CompilerGenerated]
		public virtual global::UIKit.UIFont LabelFont {
			[Export ("labelFont", ArgumentSemantic.Retain)]
			get {
				global::UIKit.UIFont ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<global::UIKit.UIFont> (ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("labelFont")));
				} else {
					ret =  Runtime.GetNSObject<global::UIKit.UIFont> (ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("labelFont")));
				}
				if (!IsNewRefcountEnabled ())
					__mt_LabelFont_var = ret;
				return ret;
			}
			
			[Export ("setLabelFont:", ArgumentSemantic.Retain)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				if (IsDirectBinding) {
					ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setLabelFont:"), value.Handle);
				} else {
					ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setLabelFont:"), value.Handle);
				}
				if (!IsNewRefcountEnabled ())
					__mt_LabelFont_var = value;
			}
		}
		
		[CompilerGenerated]
		public virtual string LabelText {
			[Export ("labelText", ArgumentSemantic.Copy)]
			get {
				if (IsDirectBinding) {
					return NSString.FromHandle (ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("labelText")));
				} else {
					return NSString.FromHandle (ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("labelText")));
				}
			}
			
			[Export ("setLabelText:", ArgumentSemantic.Copy)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				var nsvalue = NSString.CreateNative (value);
				
				if (IsDirectBinding) {
					ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setLabelText:"), nsvalue);
				} else {
					ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setLabelText:"), nsvalue);
				}
				NSString.ReleaseNative (nsvalue);
				
			}
		}
		
		[CompilerGenerated]
		public virtual float Margin {
			[Export ("margin", ArgumentSemantic.UnsafeUnretained)]
			get {
				if (IsDirectBinding) {
					return ApiDefinition.Messaging.float_objc_msgSend (this.Handle, Selector.GetHandle ("margin"));
				} else {
					return ApiDefinition.Messaging.float_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("margin"));
				}
			}
			
			[Export ("setMargin:", ArgumentSemantic.UnsafeUnretained)]
			set {
				if (IsDirectBinding) {
					ApiDefinition.Messaging.void_objc_msgSend_float (this.Handle, Selector.GetHandle ("setMargin:"), value);
				} else {
					ApiDefinition.Messaging.void_objc_msgSendSuper_float (this.SuperHandle, Selector.GetHandle ("setMargin:"), value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual float MinShowTime {
			[Export ("minShowTime", ArgumentSemantic.UnsafeUnretained)]
			get {
				if (IsDirectBinding) {
					return ApiDefinition.Messaging.float_objc_msgSend (this.Handle, Selector.GetHandle ("minShowTime"));
				} else {
					return ApiDefinition.Messaging.float_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("minShowTime"));
				}
			}
			
			[Export ("setMinShowTime:", ArgumentSemantic.UnsafeUnretained)]
			set {
				if (IsDirectBinding) {
					ApiDefinition.Messaging.void_objc_msgSend_float (this.Handle, Selector.GetHandle ("setMinShowTime:"), value);
				} else {
					ApiDefinition.Messaging.void_objc_msgSendSuper_float (this.SuperHandle, Selector.GetHandle ("setMinShowTime:"), value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual global::System.Drawing.SizeF MinSize {
			[Export ("minSize", ArgumentSemantic.UnsafeUnretained)]
			get {
				global::System.Drawing.SizeF ret;
				if (IsDirectBinding) {
					if (Runtime.Arch == Arch.DEVICE) {
						if (IntPtr.Size == 8) {
							ret = ApiDefinition.Messaging.SizeF_objc_msgSend (this.Handle, Selector.GetHandle ("minSize"));
						} else {
							ApiDefinition.Messaging.SizeF_objc_msgSend_stret (out ret, this.Handle, Selector.GetHandle ("minSize"));
						}
					} else if (IntPtr.Size == 8) {
						ret = ApiDefinition.Messaging.SizeF_objc_msgSend (this.Handle, Selector.GetHandle ("minSize"));
					} else {
						ret = ApiDefinition.Messaging.SizeF_objc_msgSend (this.Handle, Selector.GetHandle ("minSize"));
					}
				} else {
					if (Runtime.Arch == Arch.DEVICE) {
						if (IntPtr.Size == 8) {
							ret = ApiDefinition.Messaging.SizeF_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("minSize"));
						} else {
							ApiDefinition.Messaging.SizeF_objc_msgSendSuper_stret (out ret, this.SuperHandle, Selector.GetHandle ("minSize"));
						}
					} else if (IntPtr.Size == 8) {
						ret = ApiDefinition.Messaging.SizeF_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("minSize"));
					} else {
						ret = ApiDefinition.Messaging.SizeF_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("minSize"));
					}
				}
				return ret;
			}
			
			[Export ("setMinSize:", ArgumentSemantic.UnsafeUnretained)]
			set {
				if (IsDirectBinding) {
					ApiDefinition.Messaging.void_objc_msgSend_SizeF (this.Handle, Selector.GetHandle ("setMinSize:"), value);
				} else {
					ApiDefinition.Messaging.void_objc_msgSendSuper_SizeF (this.SuperHandle, Selector.GetHandle ("setMinSize:"), value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual MBProgressHUDMode Mode {
			[Export ("mode", ArgumentSemantic.UnsafeUnretained)]
			get {
				if (IsDirectBinding) {
					return (MBProgressHUDMode) ApiDefinition.Messaging.int_objc_msgSend (this.Handle, Selector.GetHandle ("mode"));
				} else {
					return (MBProgressHUDMode) ApiDefinition.Messaging.int_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("mode"));
				}
			}
			
			[Export ("setMode:", ArgumentSemantic.UnsafeUnretained)]
			set {
				if (IsDirectBinding) {
					ApiDefinition.Messaging.void_objc_msgSend_int (this.Handle, Selector.GetHandle ("setMode:"), (int)value);
				} else {
					ApiDefinition.Messaging.void_objc_msgSendSuper_int (this.SuperHandle, Selector.GetHandle ("setMode:"), (int)value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual float Opacity {
			[Export ("opacity", ArgumentSemantic.UnsafeUnretained)]
			get {
				if (IsDirectBinding) {
					return ApiDefinition.Messaging.float_objc_msgSend (this.Handle, Selector.GetHandle ("opacity"));
				} else {
					return ApiDefinition.Messaging.float_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("opacity"));
				}
			}
			
			[Export ("setOpacity:", ArgumentSemantic.UnsafeUnretained)]
			set {
				if (IsDirectBinding) {
					ApiDefinition.Messaging.void_objc_msgSend_float (this.Handle, Selector.GetHandle ("setOpacity:"), value);
				} else {
					ApiDefinition.Messaging.void_objc_msgSendSuper_float (this.SuperHandle, Selector.GetHandle ("setOpacity:"), value);
				}
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
		public virtual bool RemoveFromSuperViewOnHide {
			[Export ("removeFromSuperViewOnHide", ArgumentSemantic.UnsafeUnretained)]
			get {
				if (IsDirectBinding) {
					return ApiDefinition.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("removeFromSuperViewOnHide"));
				} else {
					return ApiDefinition.Messaging.bool_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("removeFromSuperViewOnHide"));
				}
			}
			
			[Export ("setRemoveFromSuperViewOnHide:", ArgumentSemantic.UnsafeUnretained)]
			set {
				if (IsDirectBinding) {
					ApiDefinition.Messaging.void_objc_msgSend_bool (this.Handle, Selector.GetHandle ("setRemoveFromSuperViewOnHide:"), value);
				} else {
					ApiDefinition.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, Selector.GetHandle ("setRemoveFromSuperViewOnHide:"), value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual bool Square {
			[Export ("isSquare", ArgumentSemantic.UnsafeUnretained)]
			get {
				if (IsDirectBinding) {
					return ApiDefinition.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("isSquare"));
				} else {
					return ApiDefinition.Messaging.bool_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("isSquare"));
				}
			}
			
			[Export ("setSquare:", ArgumentSemantic.UnsafeUnretained)]
			set {
				if (IsDirectBinding) {
					ApiDefinition.Messaging.void_objc_msgSend_bool (this.Handle, Selector.GetHandle ("setSquare:"), value);
				} else {
					ApiDefinition.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, Selector.GetHandle ("setSquare:"), value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual bool TaskInProgress {
			[Export ("taskInProgress", ArgumentSemantic.UnsafeUnretained)]
			get {
				if (IsDirectBinding) {
					return ApiDefinition.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("taskInProgress"));
				} else {
					return ApiDefinition.Messaging.bool_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("taskInProgress"));
				}
			}
			
			[Export ("setTaskInProgress:", ArgumentSemantic.UnsafeUnretained)]
			set {
				if (IsDirectBinding) {
					ApiDefinition.Messaging.void_objc_msgSend_bool (this.Handle, Selector.GetHandle ("setTaskInProgress:"), value);
				} else {
					ApiDefinition.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, Selector.GetHandle ("setTaskInProgress:"), value);
				}
			}
		}
		
		[CompilerGenerated]
		object __mt_WeakDelegate_var;
		[CompilerGenerated]
		public virtual NSObject WeakDelegate {
			[Export ("delegate", ArgumentSemantic.UnsafeUnretained)]
			get {
				NSObject ret;
				if (IsDirectBinding) {
					ret = Runtime.GetNSObject (ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("delegate")));
				} else {
					ret = Runtime.GetNSObject (ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("delegate")));
				}
				MarkDirty ();
				__mt_WeakDelegate_var = ret;
				return ret;
			}
			
			[Export ("setDelegate:", ArgumentSemantic.UnsafeUnretained)]
			set {
				if (IsDirectBinding) {
					ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setDelegate:"), value == null ? IntPtr.Zero : value.Handle);
				} else {
					ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setDelegate:"), value == null ? IntPtr.Zero : value.Handle);
				}
				MarkDirty ();
				__mt_WeakDelegate_var = value;
			}
		}
		
		[CompilerGenerated]
		public virtual float XOffset {
			[Export ("xOffset", ArgumentSemantic.UnsafeUnretained)]
			get {
				if (IsDirectBinding) {
					return ApiDefinition.Messaging.float_objc_msgSend (this.Handle, Selector.GetHandle ("xOffset"));
				} else {
					return ApiDefinition.Messaging.float_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("xOffset"));
				}
			}
			
			[Export ("setXOffset:", ArgumentSemantic.UnsafeUnretained)]
			set {
				if (IsDirectBinding) {
					ApiDefinition.Messaging.void_objc_msgSend_float (this.Handle, Selector.GetHandle ("setXOffset:"), value);
				} else {
					ApiDefinition.Messaging.void_objc_msgSendSuper_float (this.SuperHandle, Selector.GetHandle ("setXOffset:"), value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual float YOffset {
			[Export ("yOffset", ArgumentSemantic.UnsafeUnretained)]
			get {
				if (IsDirectBinding) {
					return ApiDefinition.Messaging.float_objc_msgSend (this.Handle, Selector.GetHandle ("yOffset"));
				} else {
					return ApiDefinition.Messaging.float_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("yOffset"));
				}
			}
			
			[Export ("setYOffset:", ArgumentSemantic.UnsafeUnretained)]
			set {
				if (IsDirectBinding) {
					ApiDefinition.Messaging.void_objc_msgSend_float (this.Handle, Selector.GetHandle ("setYOffset:"), value);
				} else {
					ApiDefinition.Messaging.void_objc_msgSendSuper_float (this.SuperHandle, Selector.GetHandle ("setYOffset:"), value);
				}
			}
		}
		
		//
		// Events and properties from the delegate
		//
		
		_MBProgressHUDDelegate EnsureMBProgressHUDDelegate ()
		{
			var del = Delegate;
			if (del == null || (!(del is _MBProgressHUDDelegate))){
				del = new _MBProgressHUDDelegate ();
				Delegate = del;
			}
			return (_MBProgressHUDDelegate) del;
		}
		
		#pragma warning disable 672
		[Register]
		sealed class _MBProgressHUDDelegate : MBProgressHUD.MBProgressHUDDelegate { 
			public _MBProgressHUDDelegate () { IsDirectBinding = false; }
			
			internal EventHandler hudWasHidden;
			[Preserve (Conditional = true)]
			public override void HudWasHidden (MBProgressHUD.MTMBProgressHUD hud)
			{
				EventHandler handler = hudWasHidden;
				if (handler != null){
					handler (hud, EventArgs.Empty);
				}
			}
			
		}
		#pragma warning restore 672
		
		public event EventHandler DidHide {
			add { EnsureMBProgressHUDDelegate ().hudWasHidden += value; }
			remove { EnsureMBProgressHUDDelegate ().hudWasHidden -= value; }
		}
		
		[CompilerGenerated]
		protected override void Dispose (bool disposing)
		{
			base.Dispose (disposing);
			if (Handle == IntPtr.Zero) {
				__mt_Color_var = null;
				__mt_CustomView_var = null;
				__mt_DetailsLabelColor_var = null;
				__mt_DetailsLabelFont_var = null;
				__mt_LabelColor_var = null;
				__mt_LabelFont_var = null;
				__mt_WeakDelegate_var = null;
			}
		}
	} /* class MTMBProgressHUD */
}
