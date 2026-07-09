#### [DiGi\.Math](DiGi.Math.Overview.md 'DiGi\.Math\.Overview')

## DiGi\.Math\.Interfaces Namespace
### Interfaces

<a name='DiGi.Math.Interfaces.IEquation'></a>

## IEquation Interface

Defines the members of an equation\.

```csharp
public interface IEquation : DiGi.Core.Interfaces.ISerializableObject, DiGi.Core.Interfaces.ICloneableObject<DiGi.Core.Interfaces.ISerializableObject>, DiGi.Core.Interfaces.ICloneableObject, DiGi.Core.Interfaces.IObject
```

Derived  
↳ [LinearEquation](DiGi.Math.Classes.md#DiGi.Math.Classes.LinearEquation 'DiGi\.Math\.Classes\.LinearEquation')  
↳ [PolynomialEquation](DiGi.Math.Classes.md#DiGi.Math.Classes.PolynomialEquation 'DiGi\.Math\.Classes\.PolynomialEquation')

Implements [DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject'), [DiGi\.Core\.Interfaces\.ICloneableObject&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1')[DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1'), [DiGi\.Core\.Interfaces\.ICloneableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject 'DiGi\.Core\.Interfaces\.ICloneableObject'), [DiGi\.Core\.Interfaces\.IObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iobject 'DiGi\.Core\.Interfaces\.IObject')
### Methods

<a name='DiGi.Math.Interfaces.IEquation.Evaluate(double)'></a>

## IEquation\.Evaluate\(double\) Method

Evaluates the equation for a given value\.

```csharp
double Evaluate(double value);
```
#### Parameters

<a name='DiGi.Math.Interfaces.IEquation.Evaluate(double).value'></a>

`value` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The value to evaluate\.

#### Returns
[System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')  
The result of the evaluation\.

<a name='DiGi.Math.Interfaces.IEquation.Evaluate(System.Collections.Generic.IEnumerable_double_)'></a>

## IEquation\.Evaluate\(IEnumerable\<double\>\) Method

Evaluates the equation for a given set of values\.

```csharp
System.Collections.Generic.List<double>? Evaluate(System.Collections.Generic.IEnumerable<double>? values);
```
#### Parameters

<a name='DiGi.Math.Interfaces.IEquation.Evaluate(System.Collections.Generic.IEnumerable_double_).values'></a>

`values` [System\.Collections\.Generic\.IEnumerable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')[System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')

The values to evaluate\.

#### Returns
[System\.Collections\.Generic\.List&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')[System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')  
The results of the evaluations\.

<a name='DiGi.Math.Interfaces.IInterpolation'></a>

## IInterpolation Interface

Defines the members of an interpolation method\.

```csharp
public interface IInterpolation : DiGi.Core.Interfaces.ISerializableObject, DiGi.Core.Interfaces.ICloneableObject<DiGi.Core.Interfaces.ISerializableObject>, DiGi.Core.Interfaces.ICloneableObject, DiGi.Core.Interfaces.IObject
```

Derived  
↳ [BilinearInterpolation](DiGi.Math.Classes.md#DiGi.Math.Classes.BilinearInterpolation 'DiGi\.Math\.Classes\.BilinearInterpolation')  
↳ [LinearInterpolation](DiGi.Math.Classes.md#DiGi.Math.Classes.LinearInterpolation 'DiGi\.Math\.Classes\.LinearInterpolation')

Implements [DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject'), [DiGi\.Core\.Interfaces\.ICloneableObject&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1')[DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1'), [DiGi\.Core\.Interfaces\.ICloneableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject 'DiGi\.Core\.Interfaces\.ICloneableObject'), [DiGi\.Core\.Interfaces\.IObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iobject 'DiGi\.Core\.Interfaces\.IObject')

<a name='DiGi.Math.Interfaces.IMatrix'></a>

## IMatrix Interface

Defines the members of a matrix\.

```csharp
public interface IMatrix : DiGi.Core.Interfaces.ISerializableObject, DiGi.Core.Interfaces.ICloneableObject<DiGi.Core.Interfaces.ISerializableObject>, DiGi.Core.Interfaces.ICloneableObject, DiGi.Core.Interfaces.IObject
```

Derived  
↳ [Matrix](DiGi.Math.Classes.md#DiGi.Math.Classes.Matrix 'DiGi\.Math\.Classes\.Matrix')  
↳ [Matrix2D](DiGi.Math.Classes.md#DiGi.Math.Classes.Matrix2D 'DiGi\.Math\.Classes\.Matrix2D')  
↳ [Matrix3D](DiGi.Math.Classes.md#DiGi.Math.Classes.Matrix3D 'DiGi\.Math\.Classes\.Matrix3D')  
↳ [Matrix4D](DiGi.Math.Classes.md#DiGi.Math.Classes.Matrix4D 'DiGi\.Math\.Classes\.Matrix4D')  
↳ [ISquareMatrix](DiGi.Math.Interfaces.md#DiGi.Math.Interfaces.ISquareMatrix 'DiGi\.Math\.Interfaces\.ISquareMatrix')

Implements [DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject'), [DiGi\.Core\.Interfaces\.ICloneableObject&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1')[DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1'), [DiGi\.Core\.Interfaces\.ICloneableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject 'DiGi\.Core\.Interfaces\.ICloneableObject'), [DiGi\.Core\.Interfaces\.IObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iobject 'DiGi\.Core\.Interfaces\.IObject')

<a name='DiGi.Math.Interfaces.ISquareMatrix'></a>

## ISquareMatrix Interface

Defines the members of a square matrix\.

```csharp
public interface ISquareMatrix : DiGi.Math.Interfaces.IMatrix, DiGi.Core.Interfaces.ISerializableObject, DiGi.Core.Interfaces.ICloneableObject<DiGi.Core.Interfaces.ISerializableObject>, DiGi.Core.Interfaces.ICloneableObject, DiGi.Core.Interfaces.IObject
```

Derived  
↳ [Matrix2D](DiGi.Math.Classes.md#DiGi.Math.Classes.Matrix2D 'DiGi\.Math\.Classes\.Matrix2D')  
↳ [Matrix3D](DiGi.Math.Classes.md#DiGi.Math.Classes.Matrix3D 'DiGi\.Math\.Classes\.Matrix3D')  
↳ [Matrix4D](DiGi.Math.Classes.md#DiGi.Math.Classes.Matrix4D 'DiGi\.Math\.Classes\.Matrix4D')

Implements [IMatrix](DiGi.Math.Interfaces.md#DiGi.Math.Interfaces.IMatrix 'DiGi\.Math\.Interfaces\.IMatrix'), [DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject'), [DiGi\.Core\.Interfaces\.ICloneableObject&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1')[DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1'), [DiGi\.Core\.Interfaces\.ICloneableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject 'DiGi\.Core\.Interfaces\.ICloneableObject'), [DiGi\.Core\.Interfaces\.IObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iobject 'DiGi\.Core\.Interfaces\.IObject')