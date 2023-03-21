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
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		set
		{
		}
	}

	public EpicAccountId UserId
	{
		[CalledBy(Type = typeof(Info), Member = "Set")]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(Helper), Member = "TryMarshalGet")]
		[CallsDeduplicatedMethods(Count = 1)]
		get
		{
			return null;
		}
		[CalledBy(Type = typeof(InfoInternal), Member = "Set")]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(Helper), Member = "TryMarshalSet")]
		[CallsDeduplicatedMethods(Count = 1)]
		set
		{
		}
	}

	public string ProductId
	{
		[CalledBy(Type = typeof(Info), Member = "Set")]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(Helper), Member = "TryMarshalGet")]
		[CallsDeduplicatedMethods(Count = 1)]
		get
		{
			return null;
		}
		[CalledBy(Type = typeof(InfoInternal), Member = "Set")]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(Helper), Member = "TryMarshalSet")]
		[CallsDeduplicatedMethods(Count = 1)]
		set
		{
		}
	}

	public string ProductVersion
	{
		[CalledBy(Type = typeof(Info), Member = "Set")]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(Helper), Member = "TryMarshalGet")]
		[CallsDeduplicatedMethods(Count = 1)]
		get
		{
			return null;
		}
		[CalledBy(Type = typeof(InfoInternal), Member = "Set")]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(Helper), Member = "TryMarshalSet")]
		[CallsDeduplicatedMethods(Count = 1)]
		set
		{
		}
	}

	public string Platform
	{
		[CalledBy(Type = typeof(Info), Member = "Set")]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(Helper), Member = "TryMarshalGet")]
		[CallsDeduplicatedMethods(Count = 1)]
		get
		{
			return null;
		}
		[CalledBy(Type = typeof(InfoInternal), Member = "Set")]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(Helper), Member = "TryMarshalSet")]
		[CallsDeduplicatedMethods(Count = 1)]
		set
		{
		}
	}

	public string RichText
	{
		[CalledBy(Type = typeof(Info), Member = "Set")]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(Helper), Member = "TryMarshalGet")]
		[CallsDeduplicatedMethods(Count = 1)]
		get
		{
			return null;
		}
		[CalledBy(Type = typeof(InfoInternal), Member = "Set")]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(Helper), Member = "TryMarshalSet")]
		[CallsDeduplicatedMethods(Count = 1)]
		set
		{
		}
	}

	public DataRecord[] Records
	{
		[CalledBy(Type = typeof(Info), Member = "Set")]
		[CallerCount(Count = 1)]
		[CallsDeduplicatedMethods(Count = 5)]
		get
		{
			return null;
		}
		[CalledBy(Type = typeof(InfoInternal), Member = "Set")]
		[CallerCount(Count = 1)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		set
		{
		}
	}

	public string ProductName
	{
		[CalledBy(Type = typeof(Info), Member = "Set")]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(Helper), Member = "TryMarshalGet")]
		[CallsDeduplicatedMethods(Count = 1)]
		get
		{
			return null;
		}
		[CalledBy(Type = typeof(InfoInternal), Member = "Set")]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(Helper), Member = "TryMarshalSet")]
		[CallsDeduplicatedMethods(Count = 1)]
		set
		{
		}
	}

	[CalledBy(Type = typeof(InfoInternal), Member = "Set")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(InfoInternal), Member = "set_UserId")]
	[Calls(Type = typeof(InfoInternal), Member = "set_ProductId")]
	[Calls(Type = typeof(InfoInternal), Member = "set_ProductVersion")]
	[Calls(Type = typeof(InfoInternal), Member = "set_Platform")]
	[Calls(Type = typeof(InfoInternal), Member = "set_RichText")]
	[Calls(Type = typeof(InfoInternal), Member = "set_Records")]
	[Calls(Type = typeof(InfoInternal), Member = "set_ProductName")]
	public void Set(Info other)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InfoInternal), Member = "Set")]
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
