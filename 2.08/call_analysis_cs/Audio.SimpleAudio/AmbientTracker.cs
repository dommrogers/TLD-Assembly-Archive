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
		[CalledBy(Type = typeof(AmbientTracker), Member = "Stop")]
		[CalledBy(Type = typeof(AmbientTracker), Member = "Start")]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(Object), Member = "op_Implicit")]
		get
		{
			return null;
		}
	}

	[Calls(Type = typeof(GameObject), Member = "set_layer")]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 4)]
	[Calls(Type = typeof(BaseTracker), Member = ".ctor")]
	[Calls(Type = typeof(Object), Member = "get_name")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(GameObject), Member = ".ctor")]
	[Calls(Type = typeof(Transform), Member = "SetParent")]
	[CalledBy(Type = typeof(PlayAmbientSimple), Member = "Start")]
	[CalledBy(Type = typeof(PlayAudioSimpleManager), Member = "AddAmbient")]
	[CallsUnknownMethods(Count = 4)]
	public AmbientTracker(AK.Wwise.Event akEvent, MultiPositionTypeLabel multiposition, GameObject go, float radius, bool stopWhenDisabled)
		: base(null, default(float), stopWhenDisabled: default(bool))
	{
	}

	[Calls(Type = typeof(Object), Member = "Destroy")]
	[Calls(Type = typeof(Object), Member = "Destroy")]
	[Calls(Type = typeof(Object), Member = "Destroy")]
	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Object), Member = "Destroy")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(Object), Member = "Destroy")]
	[Calls(Type = typeof(AkAmbient), Member = "OnDisable")]
	[Calls(Type = typeof(Object), Member = "Destroy")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
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

	[CallsUnknownMethods(Count = 7)]
	[Calls(Type = typeof(Debug), Member = "Log")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(AK.Wwise.Event), Member = "Post")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(AmbientTracker), Member = "get_TargetGameObject")]
	[Calls(Type = typeof(SphereCollider), Member = "set_radius")]
	[Calls(Type = typeof(Rigidbody), Member = "set_isKinematic")]
	[CallsDeduplicatedMethods(Count = 13)]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[CallerCount(Count = 0)]
	protected override void Start()
	{
	}

	[Calls(Type = typeof(AK.Wwise.Event), Member = "ExecuteAction")]
	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(AmbientTracker), Member = "get_TargetGameObject")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	protected override void Stop()
	{
	}
}
