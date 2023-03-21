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
		[CalledBy(Type = typeof(UpdateSessionModificationOptionsInternal), Member = "Set")]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(Helper), Member = "TryMarshalSet")]
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

	[CalledBy(Type = typeof(SessionsInterface), Member = "UpdateSessionModification")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UpdateSessionModificationOptionsInternal), Member = "set_SessionName")]
	[CallsDeduplicatedMethods(Count = 1)]
	public void Set(object other)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Helper), Member = "TryMarshalDispose")]
	[CallsDeduplicatedMethods(Count = 1)]
	public void Dispose()
	{
	}
}
