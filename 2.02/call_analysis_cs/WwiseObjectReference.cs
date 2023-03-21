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
		[CalledBy(Type = typeof(AkBank), Member = "get_valueGuid")]
		[CalledBy(Type = typeof(AkEnvironment), Member = "get_valueGuid")]
		[CalledBy(Type = typeof(AkEvent), Member = "get_valueGuid")]
		[CalledBy(Type = typeof(AkState), Member = "get_valueGuid")]
		[CalledBy(Type = typeof(AkState), Member = "get_groupGuid")]
		[CalledBy(Type = typeof(AkSwitch), Member = "get_valueGuid")]
		[CalledBy(Type = typeof(AkSwitch), Member = "get_groupGuid")]
		[CalledBy(Type = typeof(BaseGroupType), Member = "get_groupGuid")]
		[CalledBy(Type = typeof(BaseType), Member = "get_valueGuid")]
		[CallerCount(Count = 9)]
		[Calls(Type = typeof(Guid), Member = ".ctor")]
		[CallsDeduplicatedMethods(Count = 1)]
		get
		{
			return default(Guid);
		}
	}

	public string ObjectName
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 35)]
		get
		{
			return null;
		}
	}

	public virtual string DisplayName
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 35)]
		get
		{
			return null;
		}
	}

	public uint Id
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 1)]
		get
		{
			return 0u;
		}
	}

	public abstract WwiseObjectType WwiseObjectType { get; }

	[CalledBy(Type = typeof(WwiseAcousticTextureReference), Member = ".ctor")]
	[CalledBy(Type = typeof(WwiseAuxBusReference), Member = ".ctor")]
	[CalledBy(Type = typeof(WwiseBankReference), Member = ".ctor")]
	[CalledBy(Type = typeof(WwiseEventReference), Member = ".ctor")]
	[CalledBy(Type = typeof(WwiseGroupValueObjectReference), Member = ".ctor")]
	[CalledBy(Type = typeof(WwiseRtpcReference), Member = ".ctor")]
	[CalledBy(Type = typeof(WwiseStateGroupReference), Member = ".ctor")]
	[CalledBy(Type = typeof(WwiseStateReference), Member = ".ctor")]
	[CalledBy(Type = typeof(WwiseSwitchGroupReference), Member = ".ctor")]
	[CalledBy(Type = typeof(WwiseSwitchReference), Member = ".ctor")]
	[CalledBy(Type = typeof(WwiseTriggerReference), Member = ".ctor")]
	[CallerCount(Count = 11)]
	[Calls(Type = typeof(ScriptableObject), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 1)]
	protected WwiseObjectReference()
	{
	}
}
