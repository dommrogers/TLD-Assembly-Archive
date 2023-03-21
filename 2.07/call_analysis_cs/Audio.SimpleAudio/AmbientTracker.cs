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
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(Object), Member = "op_Implicit")]
		[CalledBy(Type = typeof(AmbientTracker), Member = "Start")]
		[CalledBy(Type = typeof(AmbientTracker), Member = "Stop")]
		get
		{
			return null;
		}
	}

	[Calls(Type = typeof(Transform), Member = "SetParent")]
	[CallsUnknownMethods(Count = 4)]
	[CalledBy(Type = typeof(PlayAmbientSimple), Member = "Start")]
	[Calls(Type = typeof(GameObject), Member = "set_layer")]
	[Calls(Type = typeof(GameObject), Member = ".ctor")]
	[CalledBy(Type = typeof(PlayAudioSimpleManager), Member = "AddAmbient")]
	[Calls(Type = typeof(Object), Member = "get_name")]
	[Calls(Type = typeof(BaseTracker), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(string), Member = "Concat")]
	public AmbientTracker(AK.Wwise.Event akEvent, MultiPositionTypeLabel multiposition, GameObject go, float radius, bool stopWhenDisabled)
		: base(null, default(float), stopWhenDisabled: default(bool))
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(Object), Member = "Destroy")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Object), Member = "Destroy")]
	[Calls(Type = typeof(Object), Member = "Destroy")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Object), Member = "Destroy")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Object), Member = "Destroy")]
	[Calls(Type = typeof(AkAmbient), Member = "OnDisable")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Object), Member = "Destroy")]
	public override void Cleanup()
	{
	}

	[CallerCount(Count = 0)]
	public override bool HasProxy()
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	public override bool IsActive()
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public override bool Matches(GameObject go, AK.Wwise.Event akEvent)
	{
		return default(bool);
	}

	[Calls(Type = typeof(AK.Wwise.Event), Member = "Post")]
	[CallsUnknownMethods(Count = 7)]
	[Calls(Type = typeof(Debug), Member = "Log")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Rigidbody), Member = "set_isKinematic")]
	[Calls(Type = typeof(SphereCollider), Member = "set_radius")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(AmbientTracker), Member = "get_TargetGameObject")]
	[CallsDeduplicatedMethods(Count = 13)]
	[CallerCount(Count = 0)]
	protected override void Start()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(AmbientTracker), Member = "get_TargetGameObject")]
	[Calls(Type = typeof(AK.Wwise.Event), Member = "ExecuteAction")]
	[CallsUnknownMethods(Count = 1)]
	protected override void Stop()
	{
	}
}
