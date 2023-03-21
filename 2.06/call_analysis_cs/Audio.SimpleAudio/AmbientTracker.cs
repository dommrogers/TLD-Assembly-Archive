using AK.Wwise;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

namespace Audio.SimpleAudio;

public class AmbientTracker : BaseTracker
{
	public AK.Wwise.Event m_Event;

	public MultiPositionTypeLabel m_MultiPositionType;

	private GameObject m_DynamicGameObject;

	private AkAmbient m_Ambient;

	private AmbientMultiPositionEnvironmentTracker m_EnvironmentTracker;

	private AkGameObj m_AudioObject;

	private bool m_AudioObjectIsDynamic;

	private bool m_RigidBodyIsDynamic;

	private bool m_ColliderIsDynamic;

	public GameObject TargetGameObject
	{
		[CalledBy(Type = typeof(AmbientTracker), Member = "Start")]
		[CalledBy(Type = typeof(AmbientTracker), Member = "Stop")]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(Object), Member = "op_Implicit")]
		get
		{
			return null;
		}
	}

	[CalledBy(Type = typeof(PlayAudioSimpleManager), Member = "AddAmbient")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(BaseTracker), Member = ".ctor")]
	[Calls(Type = typeof(Object), Member = "get_name")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(GameObject), Member = ".ctor")]
	[Calls(Type = typeof(Transform), Member = "SetParent")]
	[Calls(Type = typeof(GameObject), Member = "set_layer")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 9)]
	public AmbientTracker(AK.Wwise.Event akEvent, MultiPositionTypeLabel multiposition, GameObject go, float radius, bool stopWhenDisabled)
		: base(null, 0f, stopWhenDisabled: false)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(AkAmbient), Member = "OnDisable")]
	[Calls(Type = typeof(Object), Member = "Destroy")]
	[Calls(Type = typeof(GameObject), Member = "TryGetComponent")]
	[CallsUnknownMethods(Count = 1)]
	public override void Cleanup()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Object), Member = "CompareBaseObjects")]
	public override bool HasProxy()
	{
		return false;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Object), Member = "CompareBaseObjects")]
	public override bool IsActive()
	{
		return false;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Object), Member = "CompareBaseObjects")]
	public override bool Matches(GameObject go, AK.Wwise.Event akEvent)
	{
		return false;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AmbientTracker), Member = "get_TargetGameObject")]
	[Calls(Type = typeof(GameObject), Member = "TryGetComponent")]
	[Calls(Type = typeof(GameObject), Member = "AddComponent")]
	[Calls(Type = typeof(Rigidbody), Member = "set_isKinematic")]
	[Calls(Type = typeof(SphereCollider), Member = "set_radius")]
	[Calls(Type = typeof(Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(AK.Wwise.Event), Member = "Post")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Debug), Member = "Log")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 14)]
	protected override void Start()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AmbientTracker), Member = "get_TargetGameObject")]
	[Calls(Type = typeof(AK.Wwise.Event), Member = "ExecuteAction")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	protected override void Stop()
	{
	}
}
