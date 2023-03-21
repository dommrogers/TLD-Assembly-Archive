using System;
using System.Runtime.InteropServices;
using Cpp2ILInjected.CallAnalysis;

namespace Epic.OnlineServices.Sessions;

[StructLayout(0, Pack = 8, Size = 16)]
internal struct UpdateSessionModificationOptionsInternal : ISettable, IDisposable
{
	private int m_ApiVersion;

	private IntPtr m_SessionName;

	public string SessionName
	{
		[CalledBy(Type = typeof(UpdateSessionModificationOptionsInternal), Member = "Set")]
		[Calls(Type = typeof(Helper), Member = "TryMarshalSet")]
		[CalledBy(Type = typeof(UpdateSessionModificationOptionsInternal), Member = "Set")]
		[CallerCount(Count = 2)]
		[CallsDeduplicatedMethods(Count = 1)]
		set
		{
		}
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UpdateSessionModificationOptionsInternal), Member = "set_SessionName")]
	public void Set(UpdateSessionModificationOptions other)
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(UpdateSessionModificationOptionsInternal), Member = "set_SessionName")]
	[CalledBy(Type = typeof(SessionsInterface), Member = "UpdateSessionModification")]
	public void Set(object other)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Helper), Member = "TryMarshalDispose")]
	public void Dispose()
	{
	}
}
