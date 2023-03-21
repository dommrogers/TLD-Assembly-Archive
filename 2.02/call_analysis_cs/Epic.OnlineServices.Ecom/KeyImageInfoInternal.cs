using System;
using System.Runtime.InteropServices;
using Cpp2ILInjected.CallAnalysis;

namespace Epic.OnlineServices.Ecom;

[StructLayout(0, Pack = 8, Size = 32)]
internal struct KeyImageInfoInternal : ISettable, IDisposable
{
	private int m_ApiVersion;

	private IntPtr m_Type;

	private IntPtr m_Url;

	private uint m_Width;

	private uint m_Height;

	public string Type
	{
		[CalledBy(Type = typeof(KeyImageInfo), Member = "Set")]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(Helper), Member = "TryMarshalGet")]
		[CallsDeduplicatedMethods(Count = 1)]
		get
		{
			return null;
		}
		[CalledBy(Type = typeof(KeyImageInfoInternal), Member = "Set")]
		[CalledBy(Type = typeof(KeyImageInfoInternal), Member = "Set")]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(Helper), Member = "TryMarshalSet")]
		[CallsDeduplicatedMethods(Count = 1)]
		set
		{
		}
	}

	public string Url
	{
		[CalledBy(Type = typeof(KeyImageInfo), Member = "Set")]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(Helper), Member = "TryMarshalGet")]
		[CallsDeduplicatedMethods(Count = 1)]
		get
		{
			return null;
		}
		[CalledBy(Type = typeof(KeyImageInfoInternal), Member = "Set")]
		[CalledBy(Type = typeof(KeyImageInfoInternal), Member = "Set")]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(Helper), Member = "TryMarshalSet")]
		[CallsDeduplicatedMethods(Count = 1)]
		set
		{
		}
	}

	public uint Width
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 8)]
		get
		{
			return 0u;
		}
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		set
		{
		}
	}

	public uint Height
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		get
		{
			return 0u;
		}
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		set
		{
		}
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(KeyImageInfoInternal), Member = "set_Type")]
	[Calls(Type = typeof(KeyImageInfoInternal), Member = "set_Url")]
	public void Set(KeyImageInfo other)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(KeyImageInfoInternal), Member = "set_Type")]
	[Calls(Type = typeof(KeyImageInfoInternal), Member = "set_Url")]
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
