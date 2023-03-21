using System.Runtime.CompilerServices;
using Cpp2ILInjected.CallAnalysis;

namespace Epic.OnlineServices.Presence;

public class Info : ISettable
{
	private Status _003CStatus_003Ek__BackingField;

	private EpicAccountId _003CUserId_003Ek__BackingField;

	private string _003CProductId_003Ek__BackingField;

	private string _003CProductVersion_003Ek__BackingField;

	private string _003CPlatform_003Ek__BackingField;

	private string _003CRichText_003Ek__BackingField;

	private DataRecord[] _003CRecords_003Ek__BackingField;

	private string _003CProductName_003Ek__BackingField;

	public Status Status
	{
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 7)]
		get
		{
			return default(Status);
		}
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		set
		{
		}
	}

	public EpicAccountId UserId
	{
		[CallerCount(Count = 29)]
		[DeduplicatedMethod]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 71)]
		set
		{
		}
	}

	public string ProductId
	{
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 5)]
		get
		{
			return null;
		}
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 41)]
		set
		{
		}
	}

	public string ProductVersion
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 12)]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[DeduplicatedMethod]
		[CallerCount(Count = 20)]
		[CompilerGenerated]
		set
		{
		}
	}

	public string Platform
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 15)]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 20)]
		set
		{
		}
	}

	public string RichText
	{
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 8)]
		get
		{
			return null;
		}
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 15)]
		set
		{
		}
	}

	public DataRecord[] Records
	{
		[DeduplicatedMethod]
		[CompilerGenerated]
		[CallerCount(Count = 0)]
		get
		{
			return null;
		}
		[CallerCount(Count = 41)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		set
		{
		}
	}

	public string ProductName
	{
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 3)]
		get
		{
			return null;
		}
		[CallerCount(Count = 17)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		set
		{
		}
	}

	[Calls(Type = typeof(InfoInternal), Member = "get_ProductName")]
	[Calls(Type = typeof(InfoInternal), Member = "get_Records")]
	[CallsUnknownMethods(Count = 8)]
	[CalledBy(Type = typeof(Info), Member = "Set")]
	[Calls(Type = typeof(InfoInternal), Member = "get_RichText")]
	[Calls(Type = typeof(InfoInternal), Member = "get_Platform")]
	[Calls(Type = typeof(InfoInternal), Member = "get_ProductVersion")]
	[Calls(Type = typeof(InfoInternal), Member = "get_ProductId")]
	[Calls(Type = typeof(InfoInternal), Member = "get_UserId")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 1)]
	internal void Set(InfoInternal? other)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Info), Member = "Set")]
	[CallsUnknownMethods(Count = 2)]
	public void Set(object other)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 2)]
	public Info()
	{
	}
}
