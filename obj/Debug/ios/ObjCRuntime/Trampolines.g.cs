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

namespace ObjCRuntime {
	
	[CompilerGenerated]
	static partial class Trampolines {
		
		[DllImport ("/usr/lib/libobjc.dylib")]
		static extern IntPtr _Block_copy (IntPtr ptr);
		
		[DllImport ("/usr/lib/libobjc.dylib")]
		static extern void _Block_release (IntPtr ptr);
		
		[UnmanagedFunctionPointerAttribute (CallingConvention.Cdecl)]
		internal delegate void DNSDispatchHandlerT (IntPtr block);
		
		//
		// This class bridges native block invocations that call into C#
		//
		static internal class SDNSDispatchHandlerT {
			static internal readonly DNSDispatchHandlerT Handler = Invoke;
			
			[MonoPInvokeCallback (typeof (DNSDispatchHandlerT))]
			static unsafe void Invoke (IntPtr block) {
				var descriptor = (BlockLiteral *) block;
				var del = (global::MBProgressHUD.NSDispatchHandlerT) (descriptor->Target);
				if (del != null)
					del ();
			}
		} /* class SDNSDispatchHandlerT */
		
		internal class NIDNSDispatchHandlerT {
			IntPtr blockPtr;
			DNSDispatchHandlerT invoker;
			
			[Preserve (Conditional=true)]
			public unsafe NIDNSDispatchHandlerT (BlockLiteral *block)
			{
				blockPtr = _Block_copy ((IntPtr) block);
				invoker = block->GetDelegateForBlock<DNSDispatchHandlerT> ();
			}
			
			[Preserve (Conditional=true)]
			~NIDNSDispatchHandlerT ()
			{
				_Block_release (blockPtr);
			}
			
			[Preserve (Conditional=true)]
			public unsafe static global::MBProgressHUD.NSDispatchHandlerT Create (IntPtr block)
			{
				return new NIDNSDispatchHandlerT ((BlockLiteral *) block).Invoke;
			}
			
			[Preserve (Conditional=true)]
			unsafe void Invoke ()
			{
				invoker (blockPtr);
			}
		} /* class NIDNSDispatchHandlerT */
		
		[UnmanagedFunctionPointerAttribute (CallingConvention.Cdecl)]
		internal delegate void DMBProgressHUDCompletionHandler (IntPtr block);
		
		//
		// This class bridges native block invocations that call into C#
		//
		static internal class SDMBProgressHUDCompletionHandler {
			static internal readonly DMBProgressHUDCompletionHandler Handler = Invoke;
			
			[MonoPInvokeCallback (typeof (DMBProgressHUDCompletionHandler))]
			static unsafe void Invoke (IntPtr block) {
				var descriptor = (BlockLiteral *) block;
				var del = (global::MBProgressHUD.MBProgressHUDCompletionHandler) (descriptor->Target);
				if (del != null)
					del ();
			}
		} /* class SDMBProgressHUDCompletionHandler */
		
		internal class NIDMBProgressHUDCompletionHandler {
			IntPtr blockPtr;
			DMBProgressHUDCompletionHandler invoker;
			
			[Preserve (Conditional=true)]
			public unsafe NIDMBProgressHUDCompletionHandler (BlockLiteral *block)
			{
				blockPtr = _Block_copy ((IntPtr) block);
				invoker = block->GetDelegateForBlock<DMBProgressHUDCompletionHandler> ();
			}
			
			[Preserve (Conditional=true)]
			~NIDMBProgressHUDCompletionHandler ()
			{
				_Block_release (blockPtr);
			}
			
			[Preserve (Conditional=true)]
			public unsafe static global::MBProgressHUD.MBProgressHUDCompletionHandler Create (IntPtr block)
			{
				return new NIDMBProgressHUDCompletionHandler ((BlockLiteral *) block).Invoke;
			}
			
			[Preserve (Conditional=true)]
			unsafe void Invoke ()
			{
				invoker (blockPtr);
			}
		} /* class NIDMBProgressHUDCompletionHandler */
	}
}
