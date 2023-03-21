using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using Cpp2ILInjected.CallAnalysis;

namespace ParadoxNotion.Serialization.FullSerializer.Internal;

public class fsMetaProperty
{
	private FieldInfo _fieldInfo;

	private Type _003CStorageType_003Ek__BackingField;

	private string _003CJsonName_003Ek__BackingField;

	public Type StorageType
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 44)]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[CallerCount(Count = 85)]
		[DeduplicatedMethod]
		[CompilerGenerated]
		private set
		{
		}
	}

	public string JsonName
	{
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 23)]
		get
		{
			return null;
		}
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 51)]
		private set
		{
		}
	}

	public string MemberName
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		get
		{
			return null;
		}
	}

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(fsMetaType), Member = "CollectProperties")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 1)]
	internal fsMetaProperty(fsConfig config, FieldInfo field)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(FieldInfo), Member = "SetValue")]
	[CallsUnknownMethods(Count = 1)]
	public void Write(object context, object value)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public object Read(object context)
	{
		return null;
	}
}
