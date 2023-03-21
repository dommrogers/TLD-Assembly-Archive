using System;
using System.Runtime.InteropServices;
using Cpp2ILInjected.CallAnalysis;

namespace Epic.OnlineServices.Sessions;

[StructLayout(0, Pack = 8, Size = 16)]
internal struct UpdateSessionOptionsInternal : ISettable, IDisposable
{
	private int m_ApiVersion;

	private IntPtr m_SessionModificationHandle;

	public SessionModification SessionModificationHandle
	{
		[CallerCount(Count = 2)]
		[CallsDeduplicatedMethods(Count = 1)]
		[Calls(Type = typeof(Helper), Member = "TryMarshalSet")]
		[CalledBy(Type = typeof(UpdateSessionOptionsInternal), Member = "Set")]
		[CalledBy(Type = typeof(UpdateSessionOptionsInternal), Member = "Set")]
		set
		{
		}
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UpdateSessionOptionsInternal), Member = "set_SessionModificationHandle")]
	public void Set(UpdateSessionOptions other)
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(UpdateSessionOptionsInternal), Member = "set_SessionModificationHandle")]
	[CalledBy(Type = typeof(SessionsInterface), Member = "UpdateSession")]
	public void Set(object other)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 2)]
	public void Dispose()
	{
	}
}
