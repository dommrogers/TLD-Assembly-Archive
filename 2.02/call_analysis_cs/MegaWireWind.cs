using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class MegaWireWind : MonoBehaviour
{
	public float decay;

	public float turb;

	public float strength;

	public MegaWindType type;

	public float freq;

	public float scale;

	public Vector3 force;

	private MegaWirePerlin iperlin;

	private static float forceScaleFactor;

	public Vector3 gizmoSize;

	public int divs;

	public bool displayGizmo;

	public float gizscale;

	public Vector3 gizmopos;

	public Color gizmocol;

	public bool dirnoise;

	public float dirfreq;

	public float dirphase;

	public Vector3 dirscale;

	public bool strengthnoise;

	public float strengthfreq;

	public float strengthphase;

	public float strengthscale;

	public Vector3 dir;

	public float t;

	private Vector3 rotseed;

	private float strengthval;

	private Vector3 dirval;

	[CalledBy(Type = typeof(MegaWireWind), Member = "Force")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(MegaWirePerlin), Member = "Noise")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private float RTurbulence(Vector3 p, float freq)
	{
		return 0f;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Vector3), Member = "Magnitude")]
	[Calls(Type = typeof(Vector3), Member = "get_zero")]
	[Calls(Type = typeof(MegaWireWind), Member = "RTurbulence")]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallsUnknownMethods(Count = 15)]
	public virtual Vector3 Force(Vector3 pos)
	{
		return default(Vector3);
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(MegaWirePerlin), Member = "Noise")]
	[Calls(Type = typeof(Vector3), Member = "get_zero")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 7)]
	private void Update()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Vector3), Member = "get_zero")]
	[Calls(Type = typeof(MegaWirePerlin), Member = "get_Instance")]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 1)]
	public MegaWireWind()
	{
	}
}
