using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class UIKeyNavigation : MonoBehaviour
{
	public enum Constraint
	{
		None,
		Vertical,
		Horizontal,
		Explicit
	}

	public static BetterList<UIKeyNavigation> list;

	public static KeyCode lastKeycodeUsed;

	public Constraint constraint;

	public GameObject onUp;

	public GameObject onDown;

	public GameObject onLeft;

	public GameObject onRight;

	public GameObject onClick;

	public GameObject[] onLeftBackup;

	public GameObject[] onRightBackup;

	public GameObject[] onUpBackup;

	public GameObject[] onDownBackup;

	public bool startsSelected;

	private UIKeyNavigation onLeftNav;

	private UIKeyNavigation onRightNav;

	private UIKeyNavigation onUpNav;

	private UIKeyNavigation onDownNav;

	private BetterList<UIKeyNavigation> onLeftNavBackup;

	private BetterList<UIKeyNavigation> onRightNavBackup;

	private BetterList<UIKeyNavigation> onUpNavBackup;

	private BetterList<UIKeyNavigation> onDownNavBackup;

	[Calls(Type = typeof(Object), Member = "op_Inequality")]
	[Calls(Type = typeof(Object), Member = "op_Inequality")]
	[Calls(Type = typeof(Object), Member = "op_Inequality")]
	[Calls(Type = typeof(Object), Member = "op_Inequality")]
	[Calls(Type = typeof(Object), Member = "op_Inequality")]
	[Calls(Type = typeof(Object), Member = "op_Inequality")]
	[CallsUnknownMethods(Count = 60)]
	[Calls(Type = typeof(Object), Member = "op_Inequality")]
	[CallsDeduplicatedMethods(Count = 13)]
	[Calls(Type = typeof(Object), Member = "op_Inequality")]
	[CallerCount(Count = 0)]
	private void Awake()
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(UIButtonKeys), Member = "OnEnable")]
	[Calls(Type = typeof(UICamera), Member = "set_selectedObject")]
	[Calls(Type = typeof(NGUITools), Member = "GetActive")]
	[Calls(Type = typeof(UICamera), Member = "get_selectedObject")]
	[Calls(Type = typeof(Object), Member = "op_Equality")]
	[Calls(Type = typeof(UICamera), Member = "get_selectedObject")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 3)]
	protected virtual void OnEnable()
	{
	}

	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	protected virtual void OnDisable()
	{
	}

	[Calls(Type = typeof(Vector3), Member = "get_left")]
	[Calls(Type = typeof(UIKeyNavigation), Member = "Get")]
	[CalledBy(Type = typeof(UIKeyNavigation), Member = "OnKey")]
	[CalledBy(Type = typeof(UIKeyNavigation), Member = "OnKey")]
	[CalledBy(Type = typeof(UIKeyNavigation), Member = "OnKey")]
	[CallsUnknownMethods(Count = 12)]
	[CallerCount(Count = 3)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(Object), Member = "op_Inequality")]
	protected GameObject GetLeft()
	{
		return null;
	}

	[CallsUnknownMethods(Count = 12)]
	[CalledBy(Type = typeof(UIKeyNavigation), Member = "OnKey")]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(Object), Member = "op_Inequality")]
	[Calls(Type = typeof(Vector3), Member = "get_right")]
	[Calls(Type = typeof(UIKeyNavigation), Member = "Get")]
	[CalledBy(Type = typeof(UIKeyNavigation), Member = "OnKey")]
	private GameObject GetRight()
	{
		return null;
	}

	[CallerCount(Count = 3)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(Object), Member = "op_Inequality")]
	[Calls(Type = typeof(UIKeyNavigation), Member = "Get")]
	[CalledBy(Type = typeof(UIKeyNavigation), Member = "OnKey")]
	[CalledBy(Type = typeof(UIKeyNavigation), Member = "OnKey")]
	[Calls(Type = typeof(Vector3), Member = "get_up")]
	[CalledBy(Type = typeof(UIKeyNavigation), Member = "OnKey")]
	[CallsUnknownMethods(Count = 12)]
	protected GameObject GetUp()
	{
		return null;
	}

	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(Vector3), Member = "get_down")]
	[Calls(Type = typeof(UIKeyNavigation), Member = "Get")]
	[CalledBy(Type = typeof(UIKeyNavigation), Member = "OnKey")]
	[CallerCount(Count = 3)]
	[CalledBy(Type = typeof(UIKeyNavigation), Member = "OnKey")]
	[CalledBy(Type = typeof(UIKeyNavigation), Member = "OnKey")]
	[CallsUnknownMethods(Count = 12)]
	[Calls(Type = typeof(Object), Member = "op_Inequality")]
	protected GameObject GetDown()
	{
		return null;
	}

	[CalledBy(Type = typeof(UIKeyNavigation), Member = "GetUp")]
	[CallsUnknownMethods(Count = 12)]
	[CalledBy(Type = typeof(UIKeyNavigation), Member = "GetDown")]
	[CalledBy(Type = typeof(UIKeyNavigation), Member = "GetRight")]
	[CalledBy(Type = typeof(UIKeyNavigation), Member = "GetLeft")]
	[Calls(Type = typeof(Vector3), Member = "get_normalized")]
	[Calls(Type = typeof(UIKeyNavigation), Member = "GetCenter")]
	[Calls(Type = typeof(Object), Member = "op_Equality")]
	[Calls(Type = typeof(UIKeyNavigation), Member = "GetCenter")]
	[Calls(Type = typeof(Object), Member = "op_Inequality")]
	[CallerCount(Count = 4)]
	[CallsDeduplicatedMethods(Count = 9)]
	protected GameObject Get(Vector3 myDir, bool horizontal)
	{
		return null;
	}

	[CalledBy(Type = typeof(UIKeyNavigation), Member = "Get")]
	[Calls(Type = typeof(Object), Member = "op_Inequality")]
	[CalledBy(Type = typeof(UIKeyNavigation), Member = "Get")]
	[CallsUnknownMethods(Count = 23)]
	[Calls(Type = typeof(UICamera), Member = "get_cachedCamera")]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 10)]
	[Calls(Type = typeof(UICamera), Member = "FindCameraForLayer")]
	[Calls(Type = typeof(Object), Member = "op_Inequality")]
	[Calls(Type = typeof(Object), Member = "op_Inequality")]
	protected static Vector3 GetCenter(GameObject go)
	{
		return default(Vector3);
	}

	[Calls(Type = typeof(Object), Member = "op_Equality")]
	[Calls(Type = typeof(UIKeyNavigation), Member = "GetLeft")]
	[Calls(Type = typeof(UIKeyNavigation), Member = "GetLeft")]
	[Calls(Type = typeof(Object), Member = "op_Equality")]
	[Calls(Type = typeof(Object), Member = "op_Equality")]
	[Calls(Type = typeof(UIKeyNavigation), Member = "GetUp")]
	[Calls(Type = typeof(UIKeyNavigation), Member = "GetDown")]
	[Calls(Type = typeof(UIKeyNavigation), Member = "GetLeft")]
	[Calls(Type = typeof(UIKeyNavigation), Member = "GetRight")]
	[Calls(Type = typeof(Object), Member = "op_Equality")]
	[Calls(Type = typeof(UIKeyNavigation), Member = "GetDown")]
	[Calls(Type = typeof(UIKeyNavigation), Member = "GetUp")]
	[Calls(Type = typeof(UIKeyNavigation), Member = "GetUp")]
	[Calls(Type = typeof(Object), Member = "op_Equality")]
	[Calls(Type = typeof(UICamera), Member = "set_selectedObject")]
	[Calls(Type = typeof(Object), Member = "op_Equality")]
	[Calls(Type = typeof(UIKeyNavigation), Member = "GetRight")]
	[Calls(Type = typeof(NGUITools), Member = "GetActive")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Object), Member = "op_Inequality")]
	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(UIKeyNavigation), Member = "GetDown")]
	protected virtual void OnKey(KeyCode key)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(NGUITools), Member = "GetActive")]
	[Calls(Type = typeof(UICamera), Member = "set_selectedObject")]
	[Calls(Type = typeof(NGUITools), Member = "GetActive")]
	protected virtual void OnClick()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	public UIKeyNavigation()
	{
	}
}
