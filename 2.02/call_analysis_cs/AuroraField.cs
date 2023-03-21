using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;
using NodeCanvas.Tasks.Actions;
using UnityEngine;

public class AuroraField : MonoBehaviour
{
	public enum ControlledComponents
	{
		None,
		Electrolizer,
		Toggle
	}

	public float m_ChanceActive;

	public bool m_IsStaticField;

	public float m_Radius;

	private bool m_IsActive;

	private bool m_CanRollChance;

	private Collider[] m_Colliders;

	private static AuroraFieldDataProxy m_AuroraFieldDataProxy;

	private float m_ExtentRadius;

	private const float m_Margin = 0.5f;

	private ControlledComponents m_ControlledComponents;

	private float m_InvSqrRootOfTwo;

	public List<GameObject> m_InfluencedObjects;

	private List<AuroraElectrolizer> m_InfluencedAuroraElectrolizers;

	private List<AuroraActivatedToggle> m_InfluencedAAuroraActivatedToggles;

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = "GetComponents")]
	[Calls(Type = typeof(AuroraManager), Member = "RegisterAuroraField")]
	[Calls(Type = typeof(List<>.Enumerator), Member = "MoveNext")]
	[Calls(Type = typeof(GameObject), Member = "GetComponentsInChildren")]
	[Calls(Type = typeof(List<>), Member = "Contains")]
	[Calls(Type = typeof(List<>), Member = "Add")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 14)]
	public void Awake()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AuroraManager), Member = "UnRegisterAuroraField")]
	[CallsDeduplicatedMethods(Count = 1)]
	public void OnDestroy()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AuroraField), Member = "ComputeRadiusExtent")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	public void Start()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public float GetExtentRadius()
	{
		return 0f;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Utils), Member = "SerializeObject")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public string Serialize()
	{
		return null;
	}

	[CalledBy(Type = typeof(AuroraFieldsSceneManager), Member = "Deserialize")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Utils), Member = "DeserializeObject")]
	[Calls(Type = typeof(AuroraField), Member = "SetFieldActive")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public void Deserialize(string text)
	{
	}

	[CalledBy(Type = typeof(FlashlightItem), Member = "Awake")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(List<>), Member = "Contains")]
	[Calls(Type = typeof(AuroraManager), Member = "UnRegisterAuroraField")]
	[Calls(Type = typeof(AuroraManager), Member = "RegisterAuroraField")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 2)]
	public void SetDynamic(bool isDynamic)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public void SetControlledComponents(ControlledComponents controlledComponentFlags)
	{
	}

	[CallerCount(Count = 0)]
	public bool DoesFieldControlComponents(ControlledComponents flag)
	{
		return false;
	}

	[CallerCount(Count = 0)]
	public void UnsetControlledComponents(ControlledComponents flag)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public bool IsActive()
	{
		return false;
	}

	[CalledBy(Type = typeof(BaseAi), Member = "EnterInvestigate")]
	[CalledBy(Type = typeof(BaseAi), Member = "MaybeMoveInvestigationPositionOutsideOfField")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Vector3), Member = "Distance")]
	[Calls(Type = typeof(Vector3), Member = "Normalize")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 3)]
	public Vector3 GetClosestPointOnFieldExtent(Vector3 position, float margin)
	{
		return default(Vector3);
	}

	[CalledBy(Type = typeof(BaseAi), Member = "MaybeMoveWanderPosOutsideOfField")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Utils), Member = "IsZero")]
	[Calls(Type = typeof(Vector3), Member = "Distance")]
	[Calls(Type = typeof(Vector3), Member = "Normalize")]
	[Calls(Type = typeof(Collider), Member = "ClosestPointOnBounds")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 8)]
	public Vector3 GetClosestPointOnFieldBorder(Vector3 position)
	{
		return default(Vector3);
	}

	[CalledBy(Type = typeof(AuroraFieldsSceneManager), Member = "UpdateAuroraFields")]
	[CalledBy(Type = typeof(AuroraManager), Member = "UpdateAuroraFields")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Utils), Member = "RollChance")]
	[Calls(Type = typeof(AuroraField), Member = "SetFieldActive")]
	[CallsDeduplicatedMethods(Count = 1)]
	public void OnAuroraEnabled()
	{
	}

	[CalledBy(Type = typeof(AuroraFieldsSceneManager), Member = "UpdateAuroraFields")]
	[CalledBy(Type = typeof(AuroraManager), Member = "UpdateAuroraFields")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(AuroraField), Member = "ActivateElectrolizers")]
	[Calls(Type = typeof(AuroraField), Member = "ActivateToggles")]
	public void OnAuroraDisabled()
	{
	}

	[CalledBy(Type = typeof(BaseAi), Member = "HoldGroundInsideAuroraField")]
	[CalledBy(Type = typeof(AuroraField), Member = "ActivateElectrolizers")]
	[CalledBy(Type = typeof(AuroraField), Member = "ActivateToggles")]
	[CalledBy(Type = typeof(AuroraFieldsSceneManager), Member = "GetFieldContaining")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(Utils), Member = "IsZero")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 10)]
	public bool Contains(Vector3 position)
	{
		return false;
	}

	[CalledBy(Type = typeof(BaseAi), Member = "MaybeHoldGroundDueToSafeHaven")]
	[CalledBy(Type = typeof(BaseAi), Member = "GetVisibleFieldNearby")]
	[CalledBy(Type = typeof(AuroraFieldsSceneManager), Member = "GetFieldContaining")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(Utils), Member = "IsZero")]
	[Calls(Type = typeof(Bounds), Member = "Intersects")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 9)]
	public bool Contains(Vector3 position, float radius)
	{
		return false;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AuroraField), Member = "SetFieldActive")]
	public void Enable(bool enabled)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 2)]
	public bool IsStaticField()
	{
		return false;
	}

	[CalledBy(Type = typeof(GearItem), Member = "Awake")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(GameObject), Member = "GetComponentsInChildren")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GameObject), Member = "get_layer")]
	[Calls(Type = typeof(GameObject), Member = "set_layer")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 7)]
	public static void ResetAllAuroraFieldLayerToDefault(GameObject rootObject)
	{
	}

	[CalledBy(Type = typeof(AuroraField), Member = "Deserialize")]
	[CalledBy(Type = typeof(AuroraField), Member = "OnAuroraEnabled")]
	[CalledBy(Type = typeof(AuroraField), Member = "Enable")]
	[CalledBy(Type = typeof(FlashlightItem), Member = "EnableLights")]
	[CalledBy(Type = typeof(AuroraFieldsSceneManager), Member = "EnableAllStaticFields")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_enable_aurorafields")]
	[CalledBy(Type = typeof(Action_AuroraFielEnable), Member = "DoWork")]
	[CallerCount(Count = 7)]
	[Calls(Type = typeof(AuroraField), Member = "ActivateElectrolizers")]
	[Calls(Type = typeof(AuroraField), Member = "ActivateToggles")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	private void SetFieldActive(bool enabled)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Utils), Member = "RollChance")]
	[CallsDeduplicatedMethods(Count = 1)]
	private bool ShouldActivate()
	{
		return false;
	}

	[CalledBy(Type = typeof(AuroraField), Member = "OnAuroraDisabled")]
	[CalledBy(Type = typeof(AuroraField), Member = "SetFieldActive")]
	[CalledBy(Type = typeof(AuroraField), Member = "OnFieldEnableChanged")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(AuroraField), Member = "Contains")]
	[Calls(Type = typeof(List<>), Member = "Contains")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 9)]
	private void ActivateElectrolizers(bool enabled)
	{
	}

	[CalledBy(Type = typeof(AuroraField), Member = "OnAuroraDisabled")]
	[CalledBy(Type = typeof(AuroraField), Member = "SetFieldActive")]
	[CalledBy(Type = typeof(AuroraField), Member = "OnFieldEnableChanged")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(AuroraField), Member = "Contains")]
	[Calls(Type = typeof(List<>), Member = "Contains")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 8)]
	private void ActivateToggles(bool enabled)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AuroraField), Member = "ActivateElectrolizers")]
	[Calls(Type = typeof(AuroraField), Member = "ActivateToggles")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	private void OnFieldEnableChanged(bool enabled)
	{
	}

	[CalledBy(Type = typeof(AuroraField), Member = "Start")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Bounds), Member = "get_max")]
	[Calls(Type = typeof(Vector3), Member = "Distance")]
	[Calls(Type = typeof(Collider), Member = "get_bounds")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 16)]
	private void ComputeRadiusExtent()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(List<>), Member = ".ctor")]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 15)]
	public AuroraField()
	{
	}
}
