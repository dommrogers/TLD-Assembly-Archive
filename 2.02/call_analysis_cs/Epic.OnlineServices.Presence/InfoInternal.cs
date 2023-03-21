using System;
using System.Runtime.InteropServices;
using Cpp2ILInjected.CallAnalysis;

namespace Epic.OnlineServices.Presence;

[StructLayout(0, Pack = 8, Size = 72)]
internal struct InfoInternal : ISettable, IDisposable
{
	private int m_ApiVersion;

	private Status m_Status;

	private IntPtr m_UserId;

	private IntPtr m_ProductId;

	private IntPtr m_ProductVersion;

	private IntPtr m_Platform;

	private IntPtr m_RichText;

	private int m_RecordsCount;

	private IntPtr m_Records;

	private IntPtr m_ProductName;

	public Status Status
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		get
		{
			return default(Status);
		}
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		set
		{
		}
	}

	public EpicAccountId UserId
	{
		[CallerCount(Count = 1)]
		[CallsDeduplicatedMethods(Count = 2)]
		[CalledBy(Type = typeof(Info), Member = "Set")]
		get
		{
			return null;
		}
		[CallerCount(Count = 1)]
		[CallsDeduplicatedMethods(Count = 1)]
		[Calls(Type = typeof(Helper), Member = "TryMarshalSet")]
		[CalledBy(Type = typeof(InfoInternal), Member = "Set")]
		set
		{
		}
	}

	public string ProductId
	{
		[CallerCount(Count = 1)]
		[CallsDeduplicatedMethods(Count = 1)]
		[Calls(Type = typeof(Helper), Member = "TryMarshalGet")]
		[CalledBy(Type = typeof(Info), Member = "Set")]
		get
		{
			return null;
		}
		[CalledBy(Type = typeof(InfoInternal), Member = "Set")]
		[Calls(Type = typeof(Helper), Member = "TryMarshalSet")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallerCount(Count = 1)]
		set
		{
		}
	}

	public string ProductVersion
	{
		[CalledBy(Type = typeof(Info), Member = "Set")]
		[Calls(Type = typeof(Helper), Member = "TryMarshalGet")]
		[CallerCount(Count = 1)]
		[CallsDeduplicatedMethods(Count = 1)]
		get
		{
			return null;
		}
		[CallerCount(Count = 1)]
		[CallsDeduplicatedMethods(Count = 1)]
		[Calls(Type = typeof(Helper), Member = "TryMarshalSet")]
		[CalledBy(Type = typeof(InfoInternal), Member = "Set")]
		set
		{
		}
	}

	public string Platform
	{
		[CallerCount(Count = 1)]
		[CallsDeduplicatedMethods(Count = 1)]
		[Calls(Type = typeof(Helper), Member = "TryMarshalGet")]
		[CalledBy(Type = typeof(Info), Member = "Set")]
		get
		{
			return null;
		}
		[Calls(Type = typeof(Helper), Member = "TryMarshalSet")]
		[CalledBy(Type = typeof(InfoInternal), Member = "Set")]
		[CallerCount(Count = 1)]
		[CallsDeduplicatedMethods(Count = 1)]
		set
		{
		}
	}

	public string RichText
	{
		[CallerCount(Count = 1)]
		[CallsDeduplicatedMethods(Count = 1)]
		[Calls(Type = typeof(Helper), Member = "TryMarshalGet")]
		[CalledBy(Type = typeof(Info), Member = "Set")]
		get
		{
			return null;
		}
		[CallerCount(Count = 1)]
		[CallsDeduplicatedMethods(Count = 1)]
		[Calls(Type = typeof(Helper), Member = "TryMarshalSet")]
		[CalledBy(Type = typeof(InfoInternal), Member = "Set")]
		set
		{
		}
	}

	public DataRecord[] Records
	{
		[CallerCount(Count = 1)]
		[CallsDeduplicatedMethods(Count = 5)]
		[CalledBy(Type = typeof(Info), Member = "Set")]
		get
		{
			return null;
		}
		[CalledBy(Type = typeof(InfoInternal), Member = "Set")]
		[CallsUnknownMethods(Count = 1)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallerCount(Count = 1)]
		set
		{
		}
	}

	public string ProductName
	{
		[CallerCount(Count = 1)]
		[CallsDeduplicatedMethods(Count = 1)]
		[Calls(Type = typeof(Helper), Member = "TryMarshalGet")]
		[CalledBy(Type = typeof(Info), Member = "Set")]
		get
		{
			return null;
		}
		[CalledBy(Type = typeof(InfoInternal), Member = "Set")]
		[CallerCount(Count = 1)]
		[CallsDeduplicatedMethods(Count = 1)]
		[Calls(Type = typeof(Helper), Member = "TryMarshalSet")]
		set
		{
		}
	}

	[Calls(Type = typeof(InfoInternal), Member = "set_Records")]
	[Calls(Type = typeof(InfoInternal), Member = "set_RichText")]
	[Calls(Type = typeof(InfoInternal), Member = "set_Platform")]
	[Calls(Type = typeof(InfoInternal), Member = "set_UserId")]
	[Calls(Type = typeof(InfoInternal), Member = "set_ProductId")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(InfoInternal), Member = "set_ProductName")]
	[Calls(Type = typeof(InfoInternal), Member = "set_ProductVersion")]
	[CalledBy(Type = typeof(InfoInternal), Member = "Set")]
	public void Set(Info other)
	{
	}

	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InfoInternal), Member = "Set")]
	public void Set(object other)
	{
	}

	[Calls(Type = typeof(Helper), Member = "TryMarshalDispose")]
	[Calls(Type = typeof(Helper), Member = "TryMarshalDispose")]
	[Calls(Type = typeof(Helper), Member = "TryMarshalDispose")]
	[Calls(Type = typeof(Helper), Member = "TryMarshalDispose")]
	[Calls(Type = typeof(Helper), Member = "TryMarshalDispose")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Helper), Member = "TryMarshalDispose")]
	public void Dispose()
	{
	}
}
