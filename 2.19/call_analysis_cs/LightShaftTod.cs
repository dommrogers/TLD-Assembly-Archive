using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class LightShaftTod : MonoBehaviour
{
	public enum LightShaftDirection
	{
		NORTH,
		EAST,
		SOUTH,
		WEST,
		NONE
	}

	public bool followTod;

	public bool m_FadeWithViewAngle;

	public Vector2 yMinMax;

	public Vector2 zMinMax;

	public bool useXRotation;

	public LightShaftDirection facingDirection;

	public float m_MaximumIntensity;

	public Light m_Light;

	public GameObject[] m_LightShaft;

	public bool m_UseLightColour;

	private float m_ExternalIntensity;

	private float m_TodIntensity;

	private float yDirection;

	private float tod;

	private float xtemp;

	private float m_Dot;

	private float m_lValOrg;

	private Renderer[] m_LightShaftRenderer;

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Quaternion), Member = "get_eulerAngles")]
	[Calls(Type = typeof(Transform), Member = "set_eulerAngles")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 7)]
	private void Start()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(LightShaftTod), Member = "UpdateRotation")]
	[Calls(Type = typeof(LightShaftTod), Member = "UpdateMaterial")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Light), Member = "set_intensity")]
	[CallsUnknownMethods(Count = 2)]
	private void Update()
	{
	}

	[CalledBy(Type = typeof(LightShaftTod), Member = "Update")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Quaternion), Member = "get_eulerAngles")]
	[Calls(Type = typeof(Transform), Member = "set_eulerAngles")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 6)]
	private void UpdateRotation(float tod)
	{
	}

	[CalledBy(Type = typeof(LightShaftTod), Member = "Update")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Light), Member = "get_intensity")]
	[Calls(Type = typeof(LightShaftTod), Member = "CalculateDot")]
	[Calls(Type = typeof(Material), Member = "SetFloat")]
	[Calls(Type = typeof(Material), Member = "SetColor")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 3)]
	private void UpdateMaterial()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Light), Member = "set_intensity")]
	[CallsUnknownMethods(Count = 1)]
	private void UpdateLight()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public void SetExternalIntensity(float newIntensity)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public void SetTimeOfDayIntensity(float todIntensity)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public void SetFollowTimeOfDay(bool followTod)
	{
	}

	[CalledBy(Type = typeof(LightShaftTod), Member = "UpdateMaterial")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Transform), Member = "get_forward")]
	[Calls(Type = typeof(Transform), Member = "get_right")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 6)]
	private float CalculateDot()
	{
		return 0f;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	private float AngleDir(Vector3 fwd, Vector3 targetDir, Vector3 up)
	{
		return 0f;
	}

	[CallerCount(Count = 0)]
	public LightShaftTod()
	{
	}
}
