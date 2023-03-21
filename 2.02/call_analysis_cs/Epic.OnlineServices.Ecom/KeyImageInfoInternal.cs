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
		[CallerCount(Count = 1)]
		[CallsDeduplicatedMethods(Count = 1)]
		[Calls(Type = typeof(Helper), Member = "TryMarshalGet")]
		[CalledBy(Type = typeof(KeyImageInfo), Member = "Set")]
		get
		{
			return null;
		}
		[CallerCount(Count = 2)]
		[CallsDeduplicatedMethods(Count = 1)]
		[Calls(Type = typeof(Helper), Member = "TryMarshalSet")]
		[CalledBy(Type = typeof(KeyImageInfoInternal), Member = "Set")]
		[CalledBy(Type = typeof(KeyImageInfoInternal), Member = "Set")]
		set
		{
		}
	}

	public string Url
	{
		[CalledBy(Type = typeof(KeyImageInfo), Member = "Set")]
		[Calls(Type = typeof(Helper), Member = "TryMarshalGet")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallerCount(Count = 1)]
		get
		{
			return null;
		}
		[CallerCount(Count = 2)]
		[CallsDeduplicatedMethods(Count = 1)]
		[Calls(Type = typeof(Helper), Member = "TryMarshalSet")]
		[CalledBy(Type = typeof(KeyImageInfoInternal), Member = "Set")]
		[CalledBy(Type = typeof(KeyImageInfoInternal), Member = "Set")]
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
			return default(uint);
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
			return default(uint);
		}
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
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
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(KeyImageInfoInternal), Member = "set_Type")]
	[Calls(Type = typeof(KeyImageInfoInternal), Member = "set_Url")]
	public void Set(object other)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Helper), Member = "TryMarshalDispose")]
	[Calls(Type = typeof(Helper), Member = "TryMarshalDispose")]
	public void Dispose()
	{
	}
}
