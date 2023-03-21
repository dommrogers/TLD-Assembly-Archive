using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class PropertyBinding : MonoBehaviour
{
	public enum UpdateCondition
	{
		OnStart,
		OnUpdate,
		OnLateUpdate,
		OnFixedUpdate
	}

	public enum Direction
	{
		SourceUpdatesTarget,
		TargetUpdatesSource,
		BiDirectional
	}

	public PropertyReference source;

	public PropertyReference target;

	public Direction direction;

	public UpdateCondition update;

	public bool editMode;

	private object mLastValue;

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PropertyBinding), Member = "UpdateTarget")]
	[CallsUnknownMethods(Count = 1)]
	private void Start()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PropertyBinding), Member = "UpdateTarget")]
	private void Update()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PropertyBinding), Member = "UpdateTarget")]
	private void LateUpdate()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PropertyBinding), Member = "UpdateTarget")]
	private void FixedUpdate()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PropertyReference), Member = "Reset")]
	private void OnValidate()
	{
	}

	[CalledBy(Type = typeof(PropertyBinding), Member = "Start")]
	[CalledBy(Type = typeof(PropertyBinding), Member = "Update")]
	[CalledBy(Type = typeof(PropertyBinding), Member = "LateUpdate")]
	[CalledBy(Type = typeof(PropertyBinding), Member = "FixedUpdate")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(PropertyReference), Member = "get_isValid")]
	[Calls(Type = typeof(PropertyReference), Member = "GetPropertyType")]
	[Calls(Type = typeof(PropertyReference), Member = "Get")]
	[Calls(Type = typeof(PropertyReference), Member = "Set")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 14)]
	public void UpdateTarget()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	public PropertyBinding()
	{
	}
}
