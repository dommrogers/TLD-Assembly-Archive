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
		[CalledBy(Type = typeof(UpdateSessionOptionsInternal), Member = "Set")]
		[CalledBy(Type = typeof(UpdateSessionOptionsInternal), Member = "Set")]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(Helper), Member = "TryMarshalSet")]
		[CallsDeduplicatedMethods(Count = 1)]
		set
		{
		}
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UpdateSessionOptionsInternal), Member = "set_SessionModificationHandle")]
	public void Set(UpdateSessionOptions other)
	{
	}

	[CalledBy(Type = typeof(SessionsInterface), Member = "UpdateSession")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UpdateSessionOptionsInternal), Member = "set_SessionModificationHandle")]
	[CallsDeduplicatedMethods(Count = 1)]
	public void Set(object other)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 7)]
	public void Dispose()
	{
	}
}
