using System;
using AK.Wwise;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public abstract class WwiseObjectReference : ScriptableObject
{
	private string objectName;

	private uint id;

	private string guid;

	public Guid Guid
	{
		[CalledBy(Type = typeof(BaseType), Member = "get_valueGuid")]
		[CalledBy(Type = typeof(BaseGroupType), Member = "get_groupGuid")]
		[CalledBy(Type = typeof(AkSwitch), Member = "get_valueGuid")]
		[CalledBy(Type = typeof(AkState), Member = "get_groupGuid")]
		[CalledBy(Type = typeof(AkState), Member = "get_valueGuid")]
		[CalledBy(Type = typeof(AkSwitch), Member = "get_groupGuid")]
		[CalledBy(Type = typeof(AkEnvironment), Member = "get_valueGuid")]
		[CalledBy(Type = typeof(AkBank), Member = "get_valueGuid")]
		[Calls(Type = typeof(Guid), Member = ".ctor")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallerCount(Count = 9)]
		[CalledBy(Type = typeof(AkEvent), Member = "get_valueGuid")]
		get
		{
			return default(Guid);
		}
	}

	public string ObjectName
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 29)]
		get
		{
			return null;
		}
	}

	public virtual string DisplayName
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 29)]
		get
		{
			return null;
		}
	}

	public uint Id
	{
		[CallerCount(Count = 1)]
		[DeduplicatedMethod]
		get
		{
			return default(uint);
		}
	}

	public abstract WwiseObjectType WwiseObjectType
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 121780)]
		get;
	}

	[CalledBy(Type = typeof(WwiseTriggerReference), Member = ".ctor")]
	[CalledBy(Type = typeof(WwiseSwitchReference), Member = ".ctor")]
	[CalledBy(Type = typeof(WwiseSwitchGroupReference), Member = ".ctor")]
	[CalledBy(Type = typeof(WwiseStateReference), Member = ".ctor")]
	[CalledBy(Type = typeof(WwiseStateGroupReference), Member = ".ctor")]
	[CalledBy(Type = typeof(WwiseRtpcReference), Member = ".ctor")]
	[CalledBy(Type = typeof(WwiseGroupValueObjectReference), Member = ".ctor")]
	[CallerCount(Count = 11)]
	[CalledBy(Type = typeof(WwiseBankReference), Member = ".ctor")]
	[CalledBy(Type = typeof(WwiseAuxBusReference), Member = ".ctor")]
	[CalledBy(Type = typeof(WwiseAcousticTextureReference), Member = ".ctor")]
	[Calls(Type = typeof(ScriptableObject), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CalledBy(Type = typeof(WwiseEventReference), Member = ".ctor")]
	protected WwiseObjectReference()
	{
	}
}
