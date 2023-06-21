using System;

namespace TLD.Utility;

[Serializable]
public struct MaterialTagMapping<T>
{
	public string m_Tag;

	public T m_Value;
}
