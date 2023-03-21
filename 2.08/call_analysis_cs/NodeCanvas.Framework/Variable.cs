using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using Cpp2ILInjected.CallAnalysis;
using NodeCanvas.Framework.Internal;
using ParadoxNotion;
using UnityEngine;

namespace NodeCanvas.Framework;

[Serializable]
public abstract class Variable
{
	private sealed class _003C_003Ec__DisplayClass37_0
	{
		public Variable _003C_003E4__this;

		public Func<object, object> converter;

		[CallerCount(Count = 6)]
		[DeduplicatedMethod]
		public _003C_003Ec__DisplayClass37_0()
		{
		}

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		internal object _003CGetGetConverter_003Eb__0()
		{
			return null;
		}

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		internal object _003CGetGetConverter_003Eb__1()
		{
			return null;
		}
	}

	private sealed class _003C_003Ec__DisplayClass39_0
	{
		public Variable _003C_003E4__this;

		public Func<object, object> converter;

		[DeduplicatedMethod]
		[CallerCount(Count = 6)]
		public _003C_003Ec__DisplayClass39_0()
		{
		}

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		[CallsDeduplicatedMethods(Count = 1)]
		internal void _003CGetSetConverter_003Eb__0(object x)
		{
		}

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 1)]
		internal void _003CGetSetConverter_003Eb__1(object x)
		{
		}
	}

	private string _name;

	private string _id;

	private bool _protected;

	public string name
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 80)]
		get
		{
			return null;
		}
		[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		set
		{
		}
	}

	public string ID
	{
		[Calls(Type = typeof(Interop), Member = "GetRandomBytes")]
		[Calls(Type = typeof(Guid), Member = "ToString")]
		[CallerCount(Count = 0)]
		get
		{
			return null;
		}
	}

	public object value
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		get
		{
			return null;
		}
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		set
		{
		}
	}

	public bool isProtected
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		get
		{
			return default(bool);
		}
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		set
		{
		}
	}

	protected abstract object objectValue
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 101262)]
		get;
		[DeduplicatedMethod]
		[CallerCount(Count = 101262)]
		set;
	}

	public abstract Type varType
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 101262)]
		get;
	}

	public abstract bool hasBinding
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 101262)]
		get;
	}

	public abstract string propertyPath
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 101262)]
		get;
		[CallerCount(Count = 101262)]
		[DeduplicatedMethod]
		set;
	}

	public event Action<string> onNameChanged
	{
		[CallsUnknownMethods(Count = 3)]
		[Calls(Type = typeof(Delegate), Member = "Combine")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		add
		{
		}
		[CompilerGenerated]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Delegate), Member = "Remove")]
		[CallsUnknownMethods(Count = 3)]
		remove
		{
		}
	}

	public event Action<string, object> onValueChanged
	{
		[CompilerGenerated]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Delegate), Member = "Combine")]
		[CallsUnknownMethods(Count = 3)]
		add
		{
		}
		[CallsUnknownMethods(Count = 3)]
		[Calls(Type = typeof(Delegate), Member = "Remove")]
		[CompilerGenerated]
		[CallerCount(Count = 0)]
		remove
		{
		}
	}

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	protected bool HasValueChangeEvent()
	{
		return default(bool);
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	protected void OnValueChanged(string name, object value)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 6)]
	public Variable()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 101262)]
	public abstract void BindProperty(MemberInfo prop, GameObject target = null);

	[DeduplicatedMethod]
	[CallerCount(Count = 101262)]
	public abstract void UnBindProperty();

	[DeduplicatedMethod]
	[CallerCount(Count = 101262)]
	public abstract void InitializePropertyBinding(GameObject go, bool callSetter = false);

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Variable), Member = "GetGetConverter")]
	public bool CanConvertTo(Type toType)
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(BlackboardSource), Member = "GetVariable")]
	[CalledBy(Type = typeof(BlackboardSource._003C_003Ec__DisplayClass30_0), Member = "<GetVariableNames>b__0")]
	[CalledBy(Type = typeof(Variable), Member = "CanConvertTo")]
	[CallsDeduplicatedMethods(Count = 4)]
	[Calls(Type = typeof(TypeConverter), Member = "Get")]
	[CallerCount(Count = 4)]
	[CalledBy(Type = typeof(BBParameter<>), Member = "BindGetter")]
	public Func<object> GetGetConverter(Type toType)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Variable), Member = "GetSetConverter")]
	public bool CanConvertFrom(Type fromType)
	{
		return default(bool);
	}

	[CalledBy(Type = typeof(Variable), Member = "CanConvertFrom")]
	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(BBParameter<>), Member = "BindSetter")]
	[Calls(Type = typeof(TypeConverter), Member = "Get")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 2)]
	public Action<object> GetSetConverter(Type fromType)
	{
		return null;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 80)]
	public override string ToString()
	{
		return null;
	}
}
[Serializable]
public class Variable<T> : Variable
{
	private sealed class _003C_003Ec__DisplayClass22_0
	{
		public Variable<T> _003C_003E4__this;

		public GameObject go;

		public FieldInfo field;

		[DeduplicatedMethod]
		[CallerCount(Count = 6)]
		public _003C_003Ec__DisplayClass22_0()
		{
		}

		[Calls(Type = typeof(Debug), Member = "LogError")]
		[Calls(Type = typeof(string), Member = "Format")]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		internal T _003CInitializePropertyBinding_003Eb__1()
		{
			return (T)null;
		}

		[Calls(Type = typeof(string), Member = "Format")]
		[Calls(Type = typeof(Debug), Member = "LogError")]
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		internal void _003CInitializePropertyBinding_003Eb__3(T o)
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass22_1
	{
		public MethodInfo getMethod;

		public Component instance;

		public MethodInfo setMethod;

		[CallerCount(Count = 6)]
		[DeduplicatedMethod]
		public _003C_003Ec__DisplayClass22_1()
		{
		}

		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 3)]
		internal T _003CInitializePropertyBinding_003Eb__0()
		{
			return (T)null;
		}

		[Calls(Type = typeof(ReflectionTools), Member = "SingleTempArgsArray")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 2)]
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		internal void _003CInitializePropertyBinding_003Eb__2(T o)
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass22_2
	{
		public Component instance;

		public _003C_003Ec__DisplayClass22_0 CS_0024_003C_003E8__locals1;

		[DeduplicatedMethod]
		[CallerCount(Count = 6)]
		public _003C_003Ec__DisplayClass22_2()
		{
		}

		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 3)]
		internal T _003CInitializePropertyBinding_003Eb__4()
		{
			return (T)null;
		}

		[Calls(Type = typeof(FieldInfo), Member = "SetValue")]
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 2)]
		internal void _003CInitializePropertyBinding_003Eb__5(T o)
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass22_3
	{
		public T value;

		[CallerCount(Count = 6)]
		[DeduplicatedMethod]
		public _003C_003Ec__DisplayClass22_3()
		{
		}

		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		internal T _003CInitializePropertyBinding_003Eb__6()
		{
			return (T)null;
		}
	}

	private T _value;

	private string _propertyPath;

	private Func<T> getter;

	private Action<T> setter;

	public override string propertyPath
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 4)]
		get
		{
			return null;
		}
		[CallerCount(Count = 60)]
		[DeduplicatedMethod]
		set
		{
		}
	}

	public override bool hasBinding
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		get
		{
			return default(bool);
		}
	}

	protected override object objectValue
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		get
		{
			return null;
		}
		[CallsUnknownMethods(Count = 3)]
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		set
		{
		}
	}

	public override Type varType
	{
		[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		get
		{
			return null;
		}
	}

	public new T value
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		get
		{
			return (T)null;
		}
		[DeduplicatedMethod]
		[CallerCount(Count = 3)]
		[CallsDeduplicatedMethods(Count = 4)]
		[CallsUnknownMethods(Count = 4)]
		set
		{
		}
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 6)]
	public Variable()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public T GetValue()
	{
		return (T)null;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public void SetValue(T newValue)
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(string), Member = "Format")]
	[Calls(Type = typeof(ReflectionTools), Member = "RTReflectedOrDeclaredType")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public override void BindProperty(MemberInfo prop, GameObject target = null)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public override void UnBindProperty()
	{
	}

	[CallsUnknownMethods(Count = 28)]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[Calls(Type = typeof(string), Member = "Format")]
	[Calls(Type = typeof(string), Member = "Format")]
	[Calls(Type = typeof(GameObject), Member = "GetComponent")]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[Calls(Type = typeof(string), Member = "Format")]
	[Calls(Type = typeof(ReflectionTools), Member = "IsConstant")]
	[Calls(Type = typeof(GameObject), Member = "GetComponent")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ReflectionTools), Member = "RTGetField")]
	[Calls(Type = typeof(ReflectionTools), Member = "RTGetProperty")]
	[Calls(Type = typeof(ReflectionTools), Member = "GetType")]
	[Calls(Type = typeof(string), Member = "Substring")]
	[Calls(Type = typeof(string), Member = "Substring")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "LastIndexOf")]
	[CallsDeduplicatedMethods(Count = 26)]
	[DeduplicatedMethod]
	[Calls(Type = typeof(string), Member = "Format")]
	public override void InitializePropertyBinding(GameObject go, bool callSetter = false)
	{
	}
}
