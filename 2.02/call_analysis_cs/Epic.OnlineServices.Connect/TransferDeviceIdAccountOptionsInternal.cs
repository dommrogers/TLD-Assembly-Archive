using System;
using System.Runtime.InteropServices;
using Cpp2ILInjected.CallAnalysis;

namespace Epic.OnlineServices.Connect;

[StructLayout(0, Pack = 8, Size = 32)]
internal struct TransferDeviceIdAccountOptionsInternal : ISettable, IDisposable
{
	private int m_ApiVersion;

	private IntPtr m_PrimaryLocalUserId;

	private IntPtr m_LocalDeviceUserId;

	private IntPtr m_ProductUserIdToPreserve;

	public ProductUserId PrimaryLocalUserId
	{
		[CalledBy(Type = typeof(TransferDeviceIdAccountOptionsInternal), Member = "Set")]
		[CalledBy(Type = typeof(TransferDeviceIdAccountOptionsInternal), Member = "Set")]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(Helper), Member = "TryMarshalSet")]
		[CallsDeduplicatedMethods(Count = 1)]
		set
		{
		}
	}

	public ProductUserId LocalDeviceUserId
	{
		[CalledBy(Type = typeof(TransferDeviceIdAccountOptionsInternal), Member = "Set")]
		[CalledBy(Type = typeof(TransferDeviceIdAccountOptionsInternal), Member = "Set")]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(Helper), Member = "TryMarshalSet")]
		[CallsDeduplicatedMethods(Count = 1)]
		set
		{
		}
	}

	public ProductUserId ProductUserIdToPreserve
	{
		[CalledBy(Type = typeof(TransferDeviceIdAccountOptionsInternal), Member = "Set")]
		[CalledBy(Type = typeof(TransferDeviceIdAccountOptionsInternal), Member = "Set")]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(Helper), Member = "TryMarshalSet")]
		[CallsDeduplicatedMethods(Count = 1)]
		set
		{
		}
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TransferDeviceIdAccountOptionsInternal), Member = "set_PrimaryLocalUserId")]
	[Calls(Type = typeof(TransferDeviceIdAccountOptionsInternal), Member = "set_LocalDeviceUserId")]
	[Calls(Type = typeof(TransferDeviceIdAccountOptionsInternal), Member = "set_ProductUserIdToPreserve")]
	public void Set(TransferDeviceIdAccountOptions other)
	{
	}

	[CalledBy(Type = typeof(ConnectInterface), Member = "TransferDeviceIdAccount")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(TransferDeviceIdAccountOptionsInternal), Member = "set_PrimaryLocalUserId")]
	[Calls(Type = typeof(TransferDeviceIdAccountOptionsInternal), Member = "set_LocalDeviceUserId")]
	[Calls(Type = typeof(TransferDeviceIdAccountOptionsInternal), Member = "set_ProductUserIdToPreserve")]
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
