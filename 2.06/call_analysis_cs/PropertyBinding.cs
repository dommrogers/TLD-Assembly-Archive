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
	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(PropertyBinding), Member = "UpdateTarget")]
	private void Start()
	{
	}

	[Calls(Type = typeof(PropertyBinding), Member = "UpdateTarget")]
	[CallerCount(Count = 0)]
	private void Update()
	{
	}

	[Calls(Type = typeof(PropertyBinding), Member = "UpdateTarget")]
	[CallerCount(Count = 0)]
	private void LateUpdate()
	{
	}

	[Calls(Type = typeof(PropertyBinding), Member = "UpdateTarget")]
	[CallerCount(Count = 0)]
	private void FixedUpdate()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PropertyReference), Member = "Reset")]
	[Calls(Type = typeof(PropertyReference), Member = "Reset")]
	private void OnValidate()
	{
	}

	[Calls(Type = typeof(PropertyReference), Member = "GetPropertyType")]
	[Calls(Type = typeof(PropertyReference), Member = "GetPropertyType")]
	[Calls(Type = typeof(PropertyReference), Member = "get_isValid")]
	[ContextMenu("Update Now")]
	[Calls(Type = typeof(PropertyReference), Member = "get_isValid")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(PropertyReference), Member = "Get")]
	[CalledBy(Type = typeof(PropertyBinding), Member = "Start")]
	[Calls(Type = typeof(PropertyReference), Member = "Get")]
	[Calls(Type = typeof(PropertyReference), Member = "Get")]
	[CalledBy(Type = typeof(PropertyBinding), Member = "Update")]
	[CalledBy(Type = typeof(PropertyBinding), Member = "LateUpdate")]
	[CalledBy(Type = typeof(PropertyBinding), Member = "FixedUpdate")]
	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(PropertyReference), Member = "Get")]
	[Calls(Type = typeof(PropertyReference), Member = "Set")]
	public void UpdateTarget()
	{
	}

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public PropertyBinding()
	{
	}
}
