#### [DiGi\.Math](DiGi.Math.Overview.md 'DiGi\.Math\.Overview')

## DiGi\.Math\.Classes Namespace
### Classes

<a name='DiGi.Math.Classes.BilinearInterpolation'></a>

## BilinearInterpolation Class

Class to perform Bilinear Interpolation on a set of data\.

```csharp
public class BilinearInterpolation : DiGi.Core.Classes.SerializableObject, DiGi.Math.Interfaces.IInterpolation, DiGi.Core.Interfaces.ISerializableObject, DiGi.Core.Interfaces.ICloneableObject<DiGi.Core.Interfaces.ISerializableObject>, DiGi.Core.Interfaces.ICloneableObject, DiGi.Core.Interfaces.IObject
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → [DiGi\.Core\.Classes\.Object](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.object 'DiGi\.Core\.Classes\.Object') → [DiGi\.Core\.Classes\.SerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.serializableobject 'DiGi\.Core\.Classes\.SerializableObject') → BilinearInterpolation

Implements [IInterpolation](DiGi.Math.Interfaces.md#DiGi.Math.Interfaces.IInterpolation 'DiGi\.Math\.Interfaces\.IInterpolation'), [DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject'), [DiGi\.Core\.Interfaces\.ICloneableObject&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1')[DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1'), [DiGi\.Core\.Interfaces\.ICloneableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject 'DiGi\.Core\.Interfaces\.ICloneableObject'), [DiGi\.Core\.Interfaces\.IObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iobject 'DiGi\.Core\.Interfaces\.IObject')
### Constructors

<a name='DiGi.Math.Classes.BilinearInterpolation.BilinearInterpolation()'></a>

## BilinearInterpolation\(\) Constructor

Default constructor\. Initializes a new instance of the BilinearInterpolation class\.

```csharp
public BilinearInterpolation();
```

<a name='DiGi.Math.Classes.BilinearInterpolation.BilinearInterpolation(DiGi.Math.Classes.BilinearInterpolation)'></a>

## BilinearInterpolation\(BilinearInterpolation\) Constructor

Copy constructor\. Initializes a new instance of the BilinearInterpolation class by copying an existing instance\.

```csharp
public BilinearInterpolation(DiGi.Math.Classes.BilinearInterpolation? bilinearInterpolation);
```
#### Parameters

<a name='DiGi.Math.Classes.BilinearInterpolation.BilinearInterpolation(DiGi.Math.Classes.BilinearInterpolation).bilinearInterpolation'></a>

`bilinearInterpolation` [BilinearInterpolation](DiGi.Math.Classes.md#DiGi.Math.Classes.BilinearInterpolation 'DiGi\.Math\.Classes\.BilinearInterpolation')

The instance to copy\.

<a name='DiGi.Math.Classes.BilinearInterpolation.BilinearInterpolation(double[,])'></a>

## BilinearInterpolation\(double\[,\]\) Constructor

Initializes a new instance of the BilinearInterpolation class using a 2D data array\.

```csharp
public BilinearInterpolation(double[,]? data);
```
#### Parameters

<a name='DiGi.Math.Classes.BilinearInterpolation.BilinearInterpolation(double[,]).data'></a>

`data` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')[\[\]](https://learn.microsoft.com/en-us/dotnet/api/system.array 'System\.Array')

The 2D data array\.

<a name='DiGi.Math.Classes.BilinearInterpolation.BilinearInterpolation(System.Text.Json.Nodes.JsonObject)'></a>

## BilinearInterpolation\(JsonObject\) Constructor

Initializes a new instance of the [BilinearInterpolation](DiGi.Math.Classes.md#DiGi.Math.Classes.BilinearInterpolation 'DiGi\.Math\.Classes\.BilinearInterpolation') class using a [System\.Text\.Json\.Nodes\.JsonObject](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonobject 'System\.Text\.Json\.Nodes\.JsonObject')\.

```csharp
public BilinearInterpolation(System.Text.Json.Nodes.JsonObject? jsonObject);
```
#### Parameters

<a name='DiGi.Math.Classes.BilinearInterpolation.BilinearInterpolation(System.Text.Json.Nodes.JsonObject).jsonObject'></a>

`jsonObject` [System\.Text\.Json\.Nodes\.JsonObject](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonobject 'System\.Text\.Json\.Nodes\.JsonObject')

The JSON object containing the data to be deserialized into this instance\.
### Fields

<a name='DiGi.Math.Classes.BilinearInterpolation.values'></a>

## BilinearInterpolation\.values Field

The data matrix for interpolation, in \[y, x\] format\.

```csharp
private double[,]? values;
```

#### Field Value
[System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')[\[\]](https://learn.microsoft.com/en-us/dotnet/api/system.array 'System\.Array')

<a name='DiGi.Math.Classes.BilinearInterpolation.xArray'></a>

## BilinearInterpolation\.xArray Field

Array of row \(horizontal\) values\.

```csharp
private readonly double[]? xArray;
```

#### Field Value
[System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')[\[\]](https://learn.microsoft.com/en-us/dotnet/api/system.array 'System\.Array')

<a name='DiGi.Math.Classes.BilinearInterpolation.yArray'></a>

## BilinearInterpolation\.yArray Field

Array of column \(vertical\) values\.

```csharp
private readonly double[]? yArray;
```

#### Field Value
[System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')[\[\]](https://learn.microsoft.com/en-us/dotnet/api/system.array 'System\.Array')
### Methods

<a name='DiGi.Math.Classes.BilinearInterpolation.Calculate(double,double)'></a>

## BilinearInterpolation\.Calculate\(double, double\) Method

Calculate value

```csharp
public double Calculate(double x, double y);
```
#### Parameters

<a name='DiGi.Math.Classes.BilinearInterpolation.Calculate(double,double).x'></a>

`x` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

Column value \(Horizontal value\)

<a name='DiGi.Math.Classes.BilinearInterpolation.Calculate(double,double).y'></a>

`y` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

Row value \(Vertical value\)

#### Returns
[System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

<a name='DiGi.Math.Classes.BilinearInterpolation.FromJsonObject(System.Text.Json.Nodes.JsonObject)'></a>

## BilinearInterpolation\.FromJsonObject\(JsonObject\) Method

Populates the object's properties from a JsonObject\.

```csharp
public override bool FromJsonObject(System.Text.Json.Nodes.JsonObject? jsonObject);
```
#### Parameters

<a name='DiGi.Math.Classes.BilinearInterpolation.FromJsonObject(System.Text.Json.Nodes.JsonObject).jsonObject'></a>

`jsonObject` [System\.Text\.Json\.Nodes\.JsonObject](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonobject 'System\.Text\.Json\.Nodes\.JsonObject')

The [System\.Text\.Json\.Nodes\.JsonObject](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonobject 'System\.Text\.Json\.Nodes\.JsonObject') containing the data to populate the object\.

Implements [FromJsonObject\(JsonObject\)](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject.fromjsonobject#digi-core-interfaces-iserializableobject-fromjsonobject(system-text-json-nodes-jsonobject) 'DiGi\.Core\.Interfaces\.ISerializableObject\.FromJsonObject\(System\.Text\.Json\.Nodes\.JsonObject\)')

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
True if the object was successfully populated; otherwise, false\.

<a name='DiGi.Math.Classes.BilinearInterpolation.ToJsonObject()'></a>

## BilinearInterpolation\.ToJsonObject\(\) Method

Converts the object into a JsonObject for serialization\.

```csharp
public override System.Text.Json.Nodes.JsonObject? ToJsonObject();
```

Implements [ToJsonObject\(\)](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject.tojsonobject 'DiGi\.Core\.Interfaces\.ISerializableObject\.ToJsonObject')

#### Returns
[System\.Text\.Json\.Nodes\.JsonObject](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonobject 'System\.Text\.Json\.Nodes\.JsonObject')  
A [System\.Text\.Json\.Nodes\.JsonObject](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonobject 'System\.Text\.Json\.Nodes\.JsonObject') representation of the object, or null if conversion fails\.

<a name='DiGi.Math.Classes.LinearEquation'></a>

## LinearEquation Class

Equation in format y = Ax \+ B

```csharp
public class LinearEquation : DiGi.Core.Classes.SerializableObject, DiGi.Math.Interfaces.IEquation, DiGi.Core.Interfaces.ISerializableObject, DiGi.Core.Interfaces.ICloneableObject<DiGi.Core.Interfaces.ISerializableObject>, DiGi.Core.Interfaces.ICloneableObject, DiGi.Core.Interfaces.IObject
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → [DiGi\.Core\.Classes\.Object](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.object 'DiGi\.Core\.Classes\.Object') → [DiGi\.Core\.Classes\.SerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.serializableobject 'DiGi\.Core\.Classes\.SerializableObject') → LinearEquation

Implements [IEquation](DiGi.Math.Interfaces.md#DiGi.Math.Interfaces.IEquation 'DiGi\.Math\.Interfaces\.IEquation'), [DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject'), [DiGi\.Core\.Interfaces\.ICloneableObject&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1')[DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1'), [DiGi\.Core\.Interfaces\.ICloneableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject 'DiGi\.Core\.Interfaces\.ICloneableObject'), [DiGi\.Core\.Interfaces\.IObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iobject 'DiGi\.Core\.Interfaces\.IObject')
### Constructors

<a name='DiGi.Math.Classes.LinearEquation.LinearEquation(DiGi.Math.Classes.LinearEquation)'></a>

## LinearEquation\(LinearEquation\) Constructor

Initializes a new instance of the [LinearEquation](DiGi.Math.Classes.md#DiGi.Math.Classes.LinearEquation 'DiGi\.Math\.Classes\.LinearEquation') class by copying an existing [LinearEquation](DiGi.Math.Classes.md#DiGi.Math.Classes.LinearEquation 'DiGi\.Math\.Classes\.LinearEquation') instance\.

```csharp
public LinearEquation(DiGi.Math.Classes.LinearEquation linearEquation);
```
#### Parameters

<a name='DiGi.Math.Classes.LinearEquation.LinearEquation(DiGi.Math.Classes.LinearEquation).linearEquation'></a>

`linearEquation` [LinearEquation](DiGi.Math.Classes.md#DiGi.Math.Classes.LinearEquation 'DiGi\.Math\.Classes\.LinearEquation')

The source equation to copy from\.

<a name='DiGi.Math.Classes.LinearEquation.LinearEquation(double,double)'></a>

## LinearEquation\(double, double\) Constructor

Initializes a new instance of the [LinearEquation](DiGi.Math.Classes.md#DiGi.Math.Classes.LinearEquation 'DiGi\.Math\.Classes\.LinearEquation') class with specified coefficients A and B\.

```csharp
public LinearEquation(double a, double b);
```
#### Parameters

<a name='DiGi.Math.Classes.LinearEquation.LinearEquation(double,double).a'></a>

`a` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The coefficient A \(slope\) of the linear equation\.

<a name='DiGi.Math.Classes.LinearEquation.LinearEquation(double,double).b'></a>

`b` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The coefficient B \(y\-intercept\) of the linear equation\.

<a name='DiGi.Math.Classes.LinearEquation.LinearEquation(System.Text.Json.Nodes.JsonObject)'></a>

## LinearEquation\(JsonObject\) Constructor

Initializes a new instance of the [LinearEquation](DiGi.Math.Classes.md#DiGi.Math.Classes.LinearEquation 'DiGi\.Math\.Classes\.LinearEquation') class using a [System\.Text\.Json\.Nodes\.JsonObject](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonobject 'System\.Text\.Json\.Nodes\.JsonObject')\.

```csharp
public LinearEquation(System.Text.Json.Nodes.JsonObject jsonObject);
```
#### Parameters

<a name='DiGi.Math.Classes.LinearEquation.LinearEquation(System.Text.Json.Nodes.JsonObject).jsonObject'></a>

`jsonObject` [System\.Text\.Json\.Nodes\.JsonObject](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonobject 'System\.Text\.Json\.Nodes\.JsonObject')

The JSON object containing the equation data\.
### Properties

<a name='DiGi.Math.Classes.LinearEquation.A'></a>

## LinearEquation\.A Property

Coefficient A in the equation

```csharp
public double A { get; }
```

#### Property Value
[System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

<a name='DiGi.Math.Classes.LinearEquation.B'></a>

## LinearEquation\.B Property

Coefficient B in the equation

```csharp
public double B { get; }
```

#### Property Value
[System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

<a name='DiGi.Math.Classes.LinearEquation.Coefficients'></a>

## LinearEquation\.Coefficients Property

Gets the coefficients of the equation

```csharp
public System.Collections.Generic.List<double> Coefficients { get; }
```

#### Property Value
[System\.Collections\.Generic\.List&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')[System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')
### Methods

<a name='DiGi.Math.Classes.LinearEquation.Evaluate(double)'></a>

## LinearEquation\.Evaluate\(double\) Method

Evaluates the equation for a given value of x

```csharp
public double Evaluate(double value);
```
#### Parameters

<a name='DiGi.Math.Classes.LinearEquation.Evaluate(double).value'></a>

`value` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The value of x

Implements [Evaluate\(double\)](DiGi.Math.Interfaces.md#DiGi.Math.Interfaces.IEquation.Evaluate(double) 'DiGi\.Math\.Interfaces\.IEquation\.Evaluate\(double\)')

#### Returns
[System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')  
The value of y for the given value of x

<a name='DiGi.Math.Classes.LinearEquation.Evaluate(System.Collections.Generic.IEnumerable_double_)'></a>

## LinearEquation\.Evaluate\(IEnumerable\<double\>\) Method

Evaluates the equation for a collection of values of x

```csharp
public System.Collections.Generic.List<double>? Evaluate(System.Collections.Generic.IEnumerable<double>? values);
```
#### Parameters

<a name='DiGi.Math.Classes.LinearEquation.Evaluate(System.Collections.Generic.IEnumerable_double_).values'></a>

`values` [System\.Collections\.Generic\.IEnumerable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')[System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')

The collection of values of x

Implements [Evaluate\(IEnumerable&lt;double&gt;\)](DiGi.Math.Interfaces.md#DiGi.Math.Interfaces.IEquation.Evaluate(System.Collections.Generic.IEnumerable_double_) 'DiGi\.Math\.Interfaces\.IEquation\.Evaluate\(System\.Collections\.Generic\.IEnumerable\<double\>\)')

#### Returns
[System\.Collections\.Generic\.List&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')[System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')  
A list of corresponding values of y

<a name='DiGi.Math.Classes.LinearInterpolation'></a>

## LinearInterpolation Class

Linear Interpolation of given vlues

```csharp
public class LinearInterpolation : DiGi.Core.Classes.SerializableObject, DiGi.Math.Interfaces.IInterpolation, DiGi.Core.Interfaces.ISerializableObject, DiGi.Core.Interfaces.ICloneableObject<DiGi.Core.Interfaces.ISerializableObject>, DiGi.Core.Interfaces.ICloneableObject, DiGi.Core.Interfaces.IObject
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → [DiGi\.Core\.Classes\.Object](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.object 'DiGi\.Core\.Classes\.Object') → [DiGi\.Core\.Classes\.SerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.serializableobject 'DiGi\.Core\.Classes\.SerializableObject') → LinearInterpolation

Implements [IInterpolation](DiGi.Math.Interfaces.md#DiGi.Math.Interfaces.IInterpolation 'DiGi\.Math\.Interfaces\.IInterpolation'), [DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject'), [DiGi\.Core\.Interfaces\.ICloneableObject&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1')[DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1'), [DiGi\.Core\.Interfaces\.ICloneableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject 'DiGi\.Core\.Interfaces\.ICloneableObject'), [DiGi\.Core\.Interfaces\.IObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iobject 'DiGi\.Core\.Interfaces\.IObject')
### Constructors

<a name='DiGi.Math.Classes.LinearInterpolation.LinearInterpolation()'></a>

## LinearInterpolation\(\) Constructor

Initializes a new instance of the [LinearInterpolation](DiGi.Math.Classes.md#DiGi.Math.Classes.LinearInterpolation 'DiGi\.Math\.Classes\.LinearInterpolation') class\.

```csharp
public LinearInterpolation();
```

<a name='DiGi.Math.Classes.LinearInterpolation.LinearInterpolation(DiGi.Math.Classes.LinearInterpolation)'></a>

## LinearInterpolation\(LinearInterpolation\) Constructor

Initializes a new instance of the [LinearInterpolation](DiGi.Math.Classes.md#DiGi.Math.Classes.LinearInterpolation 'DiGi\.Math\.Classes\.LinearInterpolation') class by copying values from an existing interpolation object\.

```csharp
public LinearInterpolation(DiGi.Math.Classes.LinearInterpolation? linearInterpolation);
```
#### Parameters

<a name='DiGi.Math.Classes.LinearInterpolation.LinearInterpolation(DiGi.Math.Classes.LinearInterpolation).linearInterpolation'></a>

`linearInterpolation` [LinearInterpolation](DiGi.Math.Classes.md#DiGi.Math.Classes.LinearInterpolation 'DiGi\.Math\.Classes\.LinearInterpolation')

The source [LinearInterpolation](DiGi.Math.Classes.md#DiGi.Math.Classes.LinearInterpolation 'DiGi\.Math\.Classes\.LinearInterpolation') instance to copy\.

<a name='DiGi.Math.Classes.LinearInterpolation.LinearInterpolation(double,double,double,double)'></a>

## LinearInterpolation\(double, double, double, double\) Constructor

Initializes a new instance of the [LinearInterpolation](DiGi.Math.Classes.md#DiGi.Math.Classes.LinearInterpolation 'DiGi\.Math\.Classes\.LinearInterpolation') class with two initial data points\.

```csharp
public LinearInterpolation(double x_1, double y_1, double x_2, double y_2);
```
#### Parameters

<a name='DiGi.Math.Classes.LinearInterpolation.LinearInterpolation(double,double,double,double).x_1'></a>

`x_1` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The X coordinate of the first point\.

<a name='DiGi.Math.Classes.LinearInterpolation.LinearInterpolation(double,double,double,double).y_1'></a>

`y_1` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The Y coordinate of the first point\.

<a name='DiGi.Math.Classes.LinearInterpolation.LinearInterpolation(double,double,double,double).x_2'></a>

`x_2` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The X coordinate of the second point\.

<a name='DiGi.Math.Classes.LinearInterpolation.LinearInterpolation(double,double,double,double).y_2'></a>

`y_2` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The Y coordinate of the second point\.

<a name='DiGi.Math.Classes.LinearInterpolation.LinearInterpolation(double[,])'></a>

## LinearInterpolation\(double\[,\]\) Constructor

Initializes a new instance of the [LinearInterpolation](DiGi.Math.Classes.md#DiGi.Math.Classes.LinearInterpolation 'DiGi\.Math\.Classes\.LinearInterpolation') class using a 2D array where the first dimension represents axes \(0 for X, 1 for Y\) and the second dimension represents points\.

```csharp
public LinearInterpolation(double[,]? data);
```
#### Parameters

<a name='DiGi.Math.Classes.LinearInterpolation.LinearInterpolation(double[,]).data'></a>

`data` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')[\[\]](https://learn.microsoft.com/en-us/dotnet/api/system.array 'System\.Array')

A 2D array containing coordinate pairs\.

<a name='DiGi.Math.Classes.LinearInterpolation.LinearInterpolation(System.Text.Json.Nodes.JsonObject)'></a>

## LinearInterpolation\(JsonObject\) Constructor

Initializes a new instance of the [LinearInterpolation](DiGi.Math.Classes.md#DiGi.Math.Classes.LinearInterpolation 'DiGi\.Math\.Classes\.LinearInterpolation') class using a [System\.Text\.Json\.Nodes\.JsonObject](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonobject 'System\.Text\.Json\.Nodes\.JsonObject') for deserialization\.

```csharp
public LinearInterpolation(System.Text.Json.Nodes.JsonObject? jsonObject);
```
#### Parameters

<a name='DiGi.Math.Classes.LinearInterpolation.LinearInterpolation(System.Text.Json.Nodes.JsonObject).jsonObject'></a>

`jsonObject` [System\.Text\.Json\.Nodes\.JsonObject](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonobject 'System\.Text\.Json\.Nodes\.JsonObject')

The JSON object containing the interpolation data\.
### Properties

<a name='DiGi.Math.Classes.LinearInterpolation.Count'></a>

## LinearInterpolation\.Count Property

Gets the number of data points stored in the interpolation set\. Returns \-1 if the values collection is not initialized\.

```csharp
public int Count { get; }
```

#### Property Value
[System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')

<a name='DiGi.Math.Classes.LinearInterpolation.MaxX'></a>

## LinearInterpolation\.MaxX Property

Gets the maximum X value among all stored data points\. Returns [System\.Double\.NaN](https://learn.microsoft.com/en-us/dotnet/api/system.double.nan 'System\.Double\.NaN') if no values are present\.

```csharp
public double MaxX { get; }
```

#### Property Value
[System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

<a name='DiGi.Math.Classes.LinearInterpolation.MinX'></a>

## LinearInterpolation\.MinX Property

Gets the minimum X value among all stored data points\. Returns [System\.Double\.NaN](https://learn.microsoft.com/en-us/dotnet/api/system.double.nan 'System\.Double\.NaN') if no values are present\.

```csharp
public double MinX { get; }
```

#### Property Value
[System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')
### Methods

<a name='DiGi.Math.Classes.LinearInterpolation.Add(double,double)'></a>

## LinearInterpolation\.Add\(double, double\) Method

Adds a coordinate pair to the interpolation set\.

```csharp
public bool Add(double x, double y);
```
#### Parameters

<a name='DiGi.Math.Classes.LinearInterpolation.Add(double,double).x'></a>

`x` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The X coordinate\.

<a name='DiGi.Math.Classes.LinearInterpolation.Add(double,double).y'></a>

`y` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The Y coordinate\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
True if the point was added; false if either X or Y is [System\.Double\.NaN](https://learn.microsoft.com/en-us/dotnet/api/system.double.nan 'System\.Double\.NaN')\.

<a name='DiGi.Math.Classes.LinearInterpolation.Add(System.Collections.Generic.KeyValuePair_double,double_)'></a>

## LinearInterpolation\.Add\(KeyValuePair\<double,double\>\) Method

Adds a coordinate pair to the interpolation set\.

```csharp
public bool Add(System.Collections.Generic.KeyValuePair<double,double> keyValuePair);
```
#### Parameters

<a name='DiGi.Math.Classes.LinearInterpolation.Add(System.Collections.Generic.KeyValuePair_double,double_).keyValuePair'></a>

`keyValuePair` [System\.Collections\.Generic\.KeyValuePair&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.keyvaluepair-2 'System\.Collections\.Generic\.KeyValuePair\`2')[System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')[,](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.keyvaluepair-2 'System\.Collections\.Generic\.KeyValuePair\`2')[System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.keyvaluepair-2 'System\.Collections\.Generic\.KeyValuePair\`2')

A [System\.Collections\.Generic\.KeyValuePair&lt;&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.keyvaluepair-2 'System\.Collections\.Generic\.KeyValuePair\`2') where Key is X and Value is Y\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
True if the point was successfully added; otherwise, false\.

<a name='DiGi.Math.Classes.LinearInterpolation.CalculateY(double)'></a>

## LinearInterpolation\.CalculateY\(double\) Method

Calculates a single interpolated Y value for the given X coordinate\.

```csharp
public double CalculateY(double x);
```
#### Parameters

<a name='DiGi.Math.Classes.LinearInterpolation.CalculateY(double).x'></a>

`x` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The X coordinate to interpolate\.

#### Returns
[System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')  
The interpolated Y value, or [System\.Double\.NaN](https://learn.microsoft.com/en-us/dotnet/api/system.double.nan 'System\.Double\.NaN') if interpolation is not possible\.

<a name='DiGi.Math.Classes.LinearInterpolation.CalculateYs(double,int)'></a>

## LinearInterpolation\.CalculateYs\(double, int\) Method

Calculates a list of interpolated Y values for the given X coordinate\.

```csharp
public System.Collections.Generic.List<double>? CalculateYs(double x, int maxCount=int.MaxValue);
```
#### Parameters

<a name='DiGi.Math.Classes.LinearInterpolation.CalculateYs(double,int).x'></a>

`x` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The X coordinate to interpolate\.

<a name='DiGi.Math.Classes.LinearInterpolation.CalculateYs(double,int).maxCount'></a>

`maxCount` [System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')

The maximum number of results to return\.

#### Returns
[System\.Collections\.Generic\.List&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')[System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')  
A [System\.Collections\.Generic\.List&lt;&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1') of interpolated Y values, or null if the input is invalid or out of range\.

<a name='DiGi.Math.Classes.LinearInterpolation.InRange(double)'></a>

## LinearInterpolation\.InRange\(double\) Method

Checks whether the specified X coordinate falls within the range defined by the minimum and maximum stored X values\.

```csharp
public bool InRange(double x);
```
#### Parameters

<a name='DiGi.Math.Classes.LinearInterpolation.InRange(double).x'></a>

`x` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The X coordinate to check\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
True if the value is within the inclusive range \[MinX, MaxX\]; otherwise, false\.

<a name='DiGi.Math.Classes.Matrix'></a>

## Matrix Class

Represents a mathematical matrix with double\-precision floating\-point elements\.

```csharp
public class Matrix : DiGi.Core.Classes.SerializableObject, DiGi.Math.Interfaces.IMatrix, DiGi.Core.Interfaces.ISerializableObject, DiGi.Core.Interfaces.ICloneableObject<DiGi.Core.Interfaces.ISerializableObject>, DiGi.Core.Interfaces.ICloneableObject, DiGi.Core.Interfaces.IObject
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → [DiGi\.Core\.Classes\.Object](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.object 'DiGi\.Core\.Classes\.Object') → [DiGi\.Core\.Classes\.SerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.serializableobject 'DiGi\.Core\.Classes\.SerializableObject') → Matrix

Derived  
↳ [Matrix2D](DiGi.Math.Classes.md#DiGi.Math.Classes.Matrix2D 'DiGi\.Math\.Classes\.Matrix2D')  
↳ [Matrix3D](DiGi.Math.Classes.md#DiGi.Math.Classes.Matrix3D 'DiGi\.Math\.Classes\.Matrix3D')  
↳ [Matrix4D](DiGi.Math.Classes.md#DiGi.Math.Classes.Matrix4D 'DiGi\.Math\.Classes\.Matrix4D')

Implements [IMatrix](DiGi.Math.Interfaces.md#DiGi.Math.Interfaces.IMatrix 'DiGi\.Math\.Interfaces\.IMatrix'), [DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject'), [DiGi\.Core\.Interfaces\.ICloneableObject&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1')[DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1'), [DiGi\.Core\.Interfaces\.ICloneableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject 'DiGi\.Core\.Interfaces\.ICloneableObject'), [DiGi\.Core\.Interfaces\.IObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iobject 'DiGi\.Core\.Interfaces\.IObject')
### Constructors

<a name='DiGi.Math.Classes.Matrix.Matrix(DiGi.Math.Classes.Matrix)'></a>

## Matrix\(Matrix\) Constructor

Initializes a new instance of the [Matrix](DiGi.Math.Classes.md#DiGi.Math.Classes.Matrix 'DiGi\.Math\.Classes\.Matrix') class by copying another matrix\.

```csharp
public Matrix(DiGi.Math.Classes.Matrix? matrix);
```
#### Parameters

<a name='DiGi.Math.Classes.Matrix.Matrix(DiGi.Math.Classes.Matrix).matrix'></a>

`matrix` [Matrix](DiGi.Math.Classes.md#DiGi.Math.Classes.Matrix 'DiGi\.Math\.Classes\.Matrix')

The source matrix to copy\.

<a name='DiGi.Math.Classes.Matrix.Matrix(double[,])'></a>

## Matrix\(double\[,\]\) Constructor

Initializes a new instance of the [Matrix](DiGi.Math.Classes.md#DiGi.Math.Classes.Matrix 'DiGi\.Math\.Classes\.Matrix') class from a 2D array of values\.

```csharp
public Matrix(double[,]? values);
```
#### Parameters

<a name='DiGi.Math.Classes.Matrix.Matrix(double[,]).values'></a>

`values` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')[\[\]](https://learn.microsoft.com/en-us/dotnet/api/system.array 'System\.Array')

The 2D array containing the matrix elements\.

<a name='DiGi.Math.Classes.Matrix.Matrix(double[])'></a>

## Matrix\(double\[\]\) Constructor

Initializes a new instance of the [Matrix](DiGi.Math.Classes.md#DiGi.Math.Classes.Matrix 'DiGi\.Math\.Classes\.Matrix') class from a 1D array of values\.

```csharp
public Matrix(double[]? values);
```
#### Parameters

<a name='DiGi.Math.Classes.Matrix.Matrix(double[]).values'></a>

`values` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')[\[\]](https://learn.microsoft.com/en-us/dotnet/api/system.array 'System\.Array')

An array of values to be used as the first row of the matrix\.

<a name='DiGi.Math.Classes.Matrix.Matrix(int,int)'></a>

## Matrix\(int, int\) Constructor

Initializes a new instance of the [Matrix](DiGi.Math.Classes.md#DiGi.Math.Classes.Matrix 'DiGi\.Math\.Classes\.Matrix') class with the specified number of rows and columns\.

```csharp
public Matrix(int rowCount, int columnCount);
```
#### Parameters

<a name='DiGi.Math.Classes.Matrix.Matrix(int,int).rowCount'></a>

`rowCount` [System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')

The number of rows in the matrix\.

<a name='DiGi.Math.Classes.Matrix.Matrix(int,int).columnCount'></a>

`columnCount` [System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')

The number of columns in the matrix\.

<a name='DiGi.Math.Classes.Matrix.Matrix(System.Text.Json.Nodes.JsonObject)'></a>

## Matrix\(JsonObject\) Constructor

Initializes a new instance of the [Matrix](DiGi.Math.Classes.md#DiGi.Math.Classes.Matrix 'DiGi\.Math\.Classes\.Matrix') class from a JSON object\.

```csharp
public Matrix(System.Text.Json.Nodes.JsonObject? jsonObject);
```
#### Parameters

<a name='DiGi.Math.Classes.Matrix.Matrix(System.Text.Json.Nodes.JsonObject).jsonObject'></a>

`jsonObject` [System\.Text\.Json\.Nodes\.JsonObject](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonobject 'System\.Text\.Json\.Nodes\.JsonObject')

The JSON object containing matrix data\.
### Properties

<a name='DiGi.Math.Classes.Matrix.this[int,int]'></a>

## Matrix\.this\[int, int\] Property

Gets or sets the element at the specified row and column\.

```csharp
public double this[int row, int column] { get; set; }
```
#### Parameters

<a name='DiGi.Math.Classes.Matrix.this[int,int].row'></a>

`row` [System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')

The zero\-based index of the row\.

<a name='DiGi.Math.Classes.Matrix.this[int,int].column'></a>

`column` [System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')

The zero\-based index of the column\.

#### Property Value
[System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')
### Methods

<a name='DiGi.Math.Classes.Matrix.Clone()'></a>

## Matrix\.Clone\(\) Method

Creates a shallow copy of the current matrix\.

```csharp
public override DiGi.Core.Interfaces.ISerializableObject? Clone();
```

Implements [Clone\(\)](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1.clone 'DiGi\.Core\.Interfaces\.ICloneableObject\`1\.Clone')

#### Returns
[DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject')  
A clone of the current matrix\.

<a name='DiGi.Math.Classes.Matrix.ColumnCount()'></a>

## Matrix\.ColumnCount\(\) Method

Gets the number of columns in the matrix\.

```csharp
public int ColumnCount();
```

#### Returns
[System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')  
The column count, or \-1 if values are null\.

<a name='DiGi.Math.Classes.Matrix.CountNonZeroRows(double)'></a>

## Matrix\.CountNonZeroRows\(double\) Method

Counts the number of rows that contain at least one non\-zero element\.

```csharp
public int CountNonZeroRows(double tolerance=1E-06);
```
#### Parameters

<a name='DiGi.Math.Classes.Matrix.CountNonZeroRows(double).tolerance'></a>

`tolerance` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The tolerance value for determining if an element is non\-zero\.

#### Returns
[System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')  
The count of non\-zero rows\.

<a name='DiGi.Math.Classes.Matrix.Determinant()'></a>

## Matrix\.Determinant\(\) Method

Calculates the determinant of the matrix\.

```csharp
public double Determinant();
```

#### Returns
[System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')  
The determinant value, or NaN if the matrix is not square or values are null\.

<a name='DiGi.Math.Classes.Matrix.Eigenvalues(double)'></a>

## Matrix\.Eigenvalues\(double\) Method

Calculates the eigenvalues of a 3x3 symmetric matrix\.

```csharp
public double[]? Eigenvalues(double tolerance=1E-06);
```
#### Parameters

<a name='DiGi.Math.Classes.Matrix.Eigenvalues(double).tolerance'></a>

`tolerance` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The tolerance value for symmetry check\.

#### Returns
[System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')[\[\]](https://learn.microsoft.com/en-us/dotnet/api/system.array 'System\.Array')  
An array containing the real eigenvalues, or null if calculation fails\.

#### Exceptions

[System\.NotImplementedException](https://learn.microsoft.com/en-us/dotnet/api/system.notimplementedexception 'System\.NotImplementedException')  
Thrown when matrix is not 3x3 or not symmetric\.

<a name='DiGi.Math.Classes.Matrix.Equals(object)'></a>

## Matrix\.Equals\(object\) Method

Determines whether the specified object is equal to the current matrix\.

```csharp
public override bool Equals(object? obj);
```
#### Parameters

<a name='DiGi.Math.Classes.Matrix.Equals(object).obj'></a>

`obj` [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object')

The object to compare with the current matrix\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
True if the objects are equal; otherwise, false\.

<a name='DiGi.Math.Classes.Matrix.FromJsonObject(System.Text.Json.Nodes.JsonObject)'></a>

## Matrix\.FromJsonObject\(JsonObject\) Method

Populates the object's properties from a JsonObject\.

```csharp
public override bool FromJsonObject(System.Text.Json.Nodes.JsonObject? jsonObject);
```
#### Parameters

<a name='DiGi.Math.Classes.Matrix.FromJsonObject(System.Text.Json.Nodes.JsonObject).jsonObject'></a>

`jsonObject` [System\.Text\.Json\.Nodes\.JsonObject](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonobject 'System\.Text\.Json\.Nodes\.JsonObject')

The [System\.Text\.Json\.Nodes\.JsonObject](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonobject 'System\.Text\.Json\.Nodes\.JsonObject') containing the data to populate the object\.

Implements [FromJsonObject\(JsonObject\)](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject.fromjsonobject#digi-core-interfaces-iserializableobject-fromjsonobject(system-text-json-nodes-jsonobject) 'DiGi\.Core\.Interfaces\.ISerializableObject\.FromJsonObject\(System\.Text\.Json\.Nodes\.JsonObject\)')

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
True if the object was successfully populated; otherwise, false\.

<a name='DiGi.Math.Classes.Matrix.GetCofactorsMatrix()'></a>

## Matrix\.GetCofactorsMatrix\(\) Method

Generates the matrix of cofactors for the current matrix, where each element is the signed minor determinant \(\-1\)^\(row\+column\) multiplied by the determinant of the corresponding minor matrix\.

```csharp
public DiGi.Math.Classes.Matrix? GetCofactorsMatrix();
```

#### Returns
[Matrix](DiGi.Math.Classes.md#DiGi.Math.Classes.Matrix 'DiGi\.Math\.Classes\.Matrix')  
The cofactor matrix, or null if values are null or the matrix is not square\.

<a name='DiGi.Math.Classes.Matrix.GetHashCode()'></a>

## Matrix\.GetHashCode\(\) Method

Gets the hash code for the current matrix\.

```csharp
public override int GetHashCode();
```

#### Returns
[System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')  
A 32\-bit signed integer hash code\.

<a name='DiGi.Math.Classes.Matrix.GetInversed()'></a>

## Matrix\.GetInversed\(\) Method

Returns a new matrix that is the inverse of the current matrix\.

```csharp
public DiGi.Math.Classes.Matrix? GetInversed();
```

#### Returns
[Matrix](DiGi.Math.Classes.md#DiGi.Math.Classes.Matrix 'DiGi\.Math\.Classes\.Matrix')  
The inversed matrix, or null if the matrix is not square\.

<a name='DiGi.Math.Classes.Matrix.GetMinorMatrix(int,int)'></a>

## Matrix\.GetMinorMatrix\(int, int\) Method

Gets the minor matrix obtained by removing the specified row and column\.

```csharp
public DiGi.Math.Classes.Matrix? GetMinorMatrix(int row, int column);
```
#### Parameters

<a name='DiGi.Math.Classes.Matrix.GetMinorMatrix(int,int).row'></a>

`row` [System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')

The index of the row to remove\.

<a name='DiGi.Math.Classes.Matrix.GetMinorMatrix(int,int).column'></a>

`column` [System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')

The index of the column to remove\.

#### Returns
[Matrix](DiGi.Math.Classes.md#DiGi.Math.Classes.Matrix 'DiGi\.Math\.Classes\.Matrix')  
The resulting minor matrix, or null if values are null or dimensions are too small\.

<a name='DiGi.Math.Classes.Matrix.GetMinorsMatrix()'></a>

## Matrix\.GetMinorsMatrix\(\) Method

Generates the matrix of minors for the current matrix\.

```csharp
public DiGi.Math.Classes.Matrix? GetMinorsMatrix();
```

#### Returns
[Matrix](DiGi.Math.Classes.md#DiGi.Math.Classes.Matrix 'DiGi\.Math\.Classes\.Matrix')  
The matrix of minors, or null if values are null\.

<a name='DiGi.Math.Classes.Matrix.GetTransposed()'></a>

## Matrix\.GetTransposed\(\) Method

Returns a new matrix that is the transpose of the current matrix\.

```csharp
public DiGi.Math.Classes.Matrix? GetTransposed();
```

#### Returns
[Matrix](DiGi.Math.Classes.md#DiGi.Math.Classes.Matrix 'DiGi\.Math\.Classes\.Matrix')  
The transposed matrix\.

<a name='DiGi.Math.Classes.Matrix.Inverse()'></a>

## Matrix\.Inverse\(\) Method

Inverts the current matrix in place\.

```csharp
public void Inverse();
```

<a name='DiGi.Math.Classes.Matrix.IsSquare()'></a>

## Matrix\.IsSquare\(\) Method

Determines whether the current matrix is square\.

```csharp
public bool IsSquare();
```

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
True if the matrix is square; otherwise, false\.

<a name='DiGi.Math.Classes.Matrix.Multiply(DiGi.Math.Classes.Matrix)'></a>

## Matrix\.Multiply\(Matrix\) Method

Multiplies the current matrix by another matrix\.

```csharp
public DiGi.Math.Classes.Matrix? Multiply(DiGi.Math.Classes.Matrix? matrix);
```
#### Parameters

<a name='DiGi.Math.Classes.Matrix.Multiply(DiGi.Math.Classes.Matrix).matrix'></a>

`matrix` [Matrix](DiGi.Math.Classes.md#DiGi.Math.Classes.Matrix 'DiGi\.Math\.Classes\.Matrix')

The matrix to multiply with\.

#### Returns
[Matrix](DiGi.Math.Classes.md#DiGi.Math.Classes.Matrix 'DiGi\.Math\.Classes\.Matrix')  
The result of the multiplication, or null if dimensions are incompatible\.

<a name='DiGi.Math.Classes.Matrix.Multiply(double)'></a>

## Matrix\.Multiply\(double\) Method

Multiplies every element of the current matrix by a scalar value\.

```csharp
public DiGi.Math.Classes.Matrix? Multiply(double value);
```
#### Parameters

<a name='DiGi.Math.Classes.Matrix.Multiply(double).value'></a>

`value` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The scalar value\.

#### Returns
[Matrix](DiGi.Math.Classes.md#DiGi.Math.Classes.Matrix 'DiGi\.Math\.Classes\.Matrix')  
The result of the multiplication, or null if values are null\.

<a name='DiGi.Math.Classes.Matrix.Negate()'></a>

## Matrix\.Negate\(\) Method

Negates every element of the current matrix in place\.

```csharp
public void Negate();
```

<a name='DiGi.Math.Classes.Matrix.REFTolerance(double)'></a>

## Matrix\.REFTolerance\(double\) Method

Calculates a tolerance value for Row Echelon Form based on matrix dimensions and maximum row sum\.

```csharp
public double REFTolerance(double tolerance=1E-06);
```
#### Parameters

<a name='DiGi.Math.Classes.Matrix.REFTolerance(double).tolerance'></a>

`tolerance` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The base tolerance value\.

#### Returns
[System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')  
The calculated REF tolerance\.

<a name='DiGi.Math.Classes.Matrix.Round(double)'></a>

## Matrix\.Round\(double\) Method

Rounds every element of the current matrix to the specified tolerance in place\.

```csharp
public void Round(double tolerance=1E-06);
```
#### Parameters

<a name='DiGi.Math.Classes.Matrix.Round(double).tolerance'></a>

`tolerance` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The precision to round to\.

<a name='DiGi.Math.Classes.Matrix.RowCount()'></a>

## Matrix\.RowCount\(\) Method

Gets the number of rows in the matrix\.

```csharp
public int RowCount();
```

#### Returns
[System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')  
The row count, or \-1 if values are null\.

<a name='DiGi.Math.Classes.Matrix.RowEchelonForm(bool,double)'></a>

## Matrix\.RowEchelonForm\(bool, double\) Method

Transforms the matrix into row echelon form or reduced row echelon form\.

```csharp
public DiGi.Math.Classes.Matrix? RowEchelonForm(bool reduced=true, double tolerance=1E-06);
```
#### Parameters

<a name='DiGi.Math.Classes.Matrix.RowEchelonForm(bool,double).reduced'></a>

`reduced` [System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')

If true, calculates the reduced row echelon form\.

<a name='DiGi.Math.Classes.Matrix.RowEchelonForm(bool,double).tolerance'></a>

`tolerance` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The tolerance for zero detection during elimination\.

#### Returns
[Matrix](DiGi.Math.Classes.md#DiGi.Math.Classes.Matrix 'DiGi\.Math\.Classes\.Matrix')  
A new matrix in \(reduced\) row echelon form, or null if cloning fails\.

<a name='DiGi.Math.Classes.Matrix.SetValues(double)'></a>

## Matrix\.SetValues\(double\) Method

Sets all elements of the current matrix to a specified value in place\.

```csharp
public void SetValues(double value);
```
#### Parameters

<a name='DiGi.Math.Classes.Matrix.SetValues(double).value'></a>

`value` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The value to set\.

<a name='DiGi.Math.Classes.Matrix.Size()'></a>

## Matrix\.Size\(\) Method

Returns a new matrix containing the dimensions of the current matrix\.

```csharp
public DiGi.Math.Classes.Matrix? Size();
```

#### Returns
[Matrix](DiGi.Math.Classes.md#DiGi.Math.Classes.Matrix 'DiGi\.Math\.Classes\.Matrix')  
A 1x2 matrix with row and column counts, or null if values are null\.

<a name='DiGi.Math.Classes.Matrix.SizeEqual(DiGi.Math.Classes.Matrix)'></a>

## Matrix\.SizeEqual\(Matrix\) Method

Checks if the current matrix has the same dimensions as another matrix\.

```csharp
public bool SizeEqual(DiGi.Math.Classes.Matrix? matrix);
```
#### Parameters

<a name='DiGi.Math.Classes.Matrix.SizeEqual(DiGi.Math.Classes.Matrix).matrix'></a>

`matrix` [Matrix](DiGi.Math.Classes.md#DiGi.Math.Classes.Matrix 'DiGi\.Math\.Classes\.Matrix')

The other matrix to compare\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
True if sizes are equal; otherwise, false\.

<a name='DiGi.Math.Classes.Matrix.ToArray()'></a>

## Matrix\.ToArray\(\) Method

Converts the current matrix to a 2D array of doubles\.

```csharp
public double[,]? ToArray();
```

#### Returns
[System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')[\[\]](https://learn.microsoft.com/en-us/dotnet/api/system.array 'System\.Array')  
A copy of the matrix elements as a 2D array, or null if values are null\.

<a name='DiGi.Math.Classes.Matrix.ToJsonObject()'></a>

## Matrix\.ToJsonObject\(\) Method

Converts the object into a JsonObject for serialization\.

```csharp
public override System.Text.Json.Nodes.JsonObject? ToJsonObject();
```

Implements [ToJsonObject\(\)](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject.tojsonobject 'DiGi\.Core\.Interfaces\.ISerializableObject\.ToJsonObject')

#### Returns
[System\.Text\.Json\.Nodes\.JsonObject](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonobject 'System\.Text\.Json\.Nodes\.JsonObject')  
A [System\.Text\.Json\.Nodes\.JsonObject](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonobject 'System\.Text\.Json\.Nodes\.JsonObject') representation of the object, or null if conversion fails\.

<a name='DiGi.Math.Classes.Matrix.Transpose()'></a>

## Matrix\.Transpose\(\) Method

Transposes the current matrix in place\.

```csharp
public void Transpose();
```
### Operators

<a name='DiGi.Math.Classes.Matrix.op_Addition(DiGi.Math.Classes.Matrix,DiGi.Math.Classes.Matrix)'></a>

## Matrix\.operator \+\(Matrix, Matrix\) Operator

Adds two matrices together element\-wise\.

```csharp
public static DiGi.Math.Classes.Matrix? operator +(DiGi.Math.Classes.Matrix? matrix_1, DiGi.Math.Classes.Matrix? matrix_2);
```
#### Parameters

<a name='DiGi.Math.Classes.Matrix.op_Addition(DiGi.Math.Classes.Matrix,DiGi.Math.Classes.Matrix).matrix_1'></a>

`matrix_1` [Matrix](DiGi.Math.Classes.md#DiGi.Math.Classes.Matrix 'DiGi\.Math\.Classes\.Matrix')

The first matrix to add\.

<a name='DiGi.Math.Classes.Matrix.op_Addition(DiGi.Math.Classes.Matrix,DiGi.Math.Classes.Matrix).matrix_2'></a>

`matrix_2` [Matrix](DiGi.Math.Classes.md#DiGi.Math.Classes.Matrix 'DiGi\.Math\.Classes\.Matrix')

The second matrix to add\.

#### Returns
[Matrix](DiGi.Math.Classes.md#DiGi.Math.Classes.Matrix 'DiGi\.Math\.Classes\.Matrix')  
A new [Matrix](DiGi.Math.Classes.md#DiGi.Math.Classes.Matrix 'DiGi\.Math\.Classes\.Matrix') containing the sum of the two matrices, or [null](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null 'https://docs\.microsoft\.com/en\-us/dotnet/csharp/language\-reference/keywords/null') if either input is null or if the matrices have different dimensions\.

<a name='DiGi.Math.Classes.Matrix.op_Addition(DiGi.Math.Classes.Matrix,double)'></a>

## Matrix\.operator \+\(Matrix, double\) Operator

Adds a scalar value to every element of the matrix\.

```csharp
public static DiGi.Math.Classes.Matrix? operator +(DiGi.Math.Classes.Matrix? matrix, double value);
```
#### Parameters

<a name='DiGi.Math.Classes.Matrix.op_Addition(DiGi.Math.Classes.Matrix,double).matrix'></a>

`matrix` [Matrix](DiGi.Math.Classes.md#DiGi.Math.Classes.Matrix 'DiGi\.Math\.Classes\.Matrix')

The matrix to which the scalar value will be added\.

<a name='DiGi.Math.Classes.Matrix.op_Addition(DiGi.Math.Classes.Matrix,double).value'></a>

`value` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The scalar value to add to each element\.

#### Returns
[Matrix](DiGi.Math.Classes.md#DiGi.Math.Classes.Matrix 'DiGi\.Math\.Classes\.Matrix')  
A new [Matrix](DiGi.Math.Classes.md#DiGi.Math.Classes.Matrix 'DiGi\.Math\.Classes\.Matrix') containing the result of the addition, or [null](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null 'https://docs\.microsoft\.com/en\-us/dotnet/csharp/language\-reference/keywords/null') if the input matrix is null\.

<a name='DiGi.Math.Classes.Matrix.op_ExplicitDiGi.Math.Classes.Matrix(double[,])'></a>

## Matrix\.explicit operator Matrix\(double\[,\]\) Operator

Explicitly converts a two\-dimensional array of doubles to a [Matrix](DiGi.Math.Classes.md#DiGi.Math.Classes.Matrix 'DiGi\.Math\.Classes\.Matrix')\.

```csharp
public static DiGi.Math.Classes.Matrix? explicit operator DiGi.Math.Classes.Matrix?(double[,]? values);
```
#### Parameters

<a name='DiGi.Math.Classes.Matrix.op_ExplicitDiGi.Math.Classes.Matrix(double[,]).values'></a>

`values` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')[\[\]](https://learn.microsoft.com/en-us/dotnet/api/system.array 'System\.Array')

The two\-dimensional array of doubles to convert\.

#### Returns
[Matrix](DiGi.Math.Classes.md#DiGi.Math.Classes.Matrix 'DiGi\.Math\.Classes\.Matrix')  
A new [Matrix](DiGi.Math.Classes.md#DiGi.Math.Classes.Matrix 'DiGi\.Math\.Classes\.Matrix') instance created from the provided values, or [null](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null 'https://docs\.microsoft\.com/en\-us/dotnet/csharp/language\-reference/keywords/null') if the input array is null\.

<a name='DiGi.Math.Classes.Matrix.op_Multiply(DiGi.Math.Classes.Matrix,DiGi.Math.Classes.Matrix)'></a>

## Matrix\.operator \*\(Matrix, Matrix\) Operator

Multiplies two matrices together using matrix multiplication\.

```csharp
public static DiGi.Math.Classes.Matrix? operator *(DiGi.Math.Classes.Matrix? matrix_1, DiGi.Math.Classes.Matrix? matrix_2);
```
#### Parameters

<a name='DiGi.Math.Classes.Matrix.op_Multiply(DiGi.Math.Classes.Matrix,DiGi.Math.Classes.Matrix).matrix_1'></a>

`matrix_1` [Matrix](DiGi.Math.Classes.md#DiGi.Math.Classes.Matrix 'DiGi\.Math\.Classes\.Matrix')

The first matrix to multiply\.

<a name='DiGi.Math.Classes.Matrix.op_Multiply(DiGi.Math.Classes.Matrix,DiGi.Math.Classes.Matrix).matrix_2'></a>

`matrix_2` [Matrix](DiGi.Math.Classes.md#DiGi.Math.Classes.Matrix 'DiGi\.Math\.Classes\.Matrix')

The second matrix to multiply\.

#### Returns
[Matrix](DiGi.Math.Classes.md#DiGi.Math.Classes.Matrix 'DiGi\.Math\.Classes\.Matrix')  
A new [Matrix](DiGi.Math.Classes.md#DiGi.Math.Classes.Matrix 'DiGi\.Math\.Classes\.Matrix') representing the product of the two matrices, or [null](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null 'https://docs\.microsoft\.com/en\-us/dotnet/csharp/language\-reference/keywords/null') if either input is null or if the number of columns in the first matrix does not match the number of rows in the second matrix\.

<a name='DiGi.Math.Classes.Matrix.op_Multiply(DiGi.Math.Classes.Matrix,double)'></a>

## Matrix\.operator \*\(Matrix, double\) Operator

Multiplies every element of the matrix by a scalar value\.

```csharp
public static DiGi.Math.Classes.Matrix? operator *(DiGi.Math.Classes.Matrix? matrix, double value);
```
#### Parameters

<a name='DiGi.Math.Classes.Matrix.op_Multiply(DiGi.Math.Classes.Matrix,double).matrix'></a>

`matrix` [Matrix](DiGi.Math.Classes.md#DiGi.Math.Classes.Matrix 'DiGi\.Math\.Classes\.Matrix')

The matrix to be multiplied\.

<a name='DiGi.Math.Classes.Matrix.op_Multiply(DiGi.Math.Classes.Matrix,double).value'></a>

`value` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The scalar value to multiply each element by\.

#### Returns
[Matrix](DiGi.Math.Classes.md#DiGi.Math.Classes.Matrix 'DiGi\.Math\.Classes\.Matrix')  
A new [Matrix](DiGi.Math.Classes.md#DiGi.Math.Classes.Matrix 'DiGi\.Math\.Classes\.Matrix') containing the result of the multiplication, or [null](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null 'https://docs\.microsoft\.com/en\-us/dotnet/csharp/language\-reference/keywords/null') if the input matrix is null\.

<a name='DiGi.Math.Classes.Matrix.op_Subtraction(DiGi.Math.Classes.Matrix,DiGi.Math.Classes.Matrix)'></a>

## Matrix\.operator \-\(Matrix, Matrix\) Operator

Subtracts the second matrix from the first matrix element\-wise\.

```csharp
public static DiGi.Math.Classes.Matrix? operator -(DiGi.Math.Classes.Matrix? matrix_1, DiGi.Math.Classes.Matrix? matrix_2);
```
#### Parameters

<a name='DiGi.Math.Classes.Matrix.op_Subtraction(DiGi.Math.Classes.Matrix,DiGi.Math.Classes.Matrix).matrix_1'></a>

`matrix_1` [Matrix](DiGi.Math.Classes.md#DiGi.Math.Classes.Matrix 'DiGi\.Math\.Classes\.Matrix')

The first matrix to subtract from\.

<a name='DiGi.Math.Classes.Matrix.op_Subtraction(DiGi.Math.Classes.Matrix,DiGi.Math.Classes.Matrix).matrix_2'></a>

`matrix_2` [Matrix](DiGi.Math.Classes.md#DiGi.Math.Classes.Matrix 'DiGi\.Math\.Classes\.Matrix')

The second matrix to be subtracted\.

#### Returns
[Matrix](DiGi.Math.Classes.md#DiGi.Math.Classes.Matrix 'DiGi\.Math\.Classes\.Matrix')  
A new [Matrix](DiGi.Math.Classes.md#DiGi.Math.Classes.Matrix 'DiGi\.Math\.Classes\.Matrix') containing the result of the subtraction, or [null](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null 'https://docs\.microsoft\.com/en\-us/dotnet/csharp/language\-reference/keywords/null') if either input is null or the matrices have different dimensions\.

<a name='DiGi.Math.Classes.Matrix.op_Subtraction(DiGi.Math.Classes.Matrix,double)'></a>

## Matrix\.operator \-\(Matrix, double\) Operator

Subtracts a scalar value from every element of the matrix\.

```csharp
public static DiGi.Math.Classes.Matrix? operator -(DiGi.Math.Classes.Matrix? matrix, double value);
```
#### Parameters

<a name='DiGi.Math.Classes.Matrix.op_Subtraction(DiGi.Math.Classes.Matrix,double).matrix'></a>

`matrix` [Matrix](DiGi.Math.Classes.md#DiGi.Math.Classes.Matrix 'DiGi\.Math\.Classes\.Matrix')

The matrix to subtract the value from\.

<a name='DiGi.Math.Classes.Matrix.op_Subtraction(DiGi.Math.Classes.Matrix,double).value'></a>

`value` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The scalar value to be subtracted from each element\.

#### Returns
[Matrix](DiGi.Math.Classes.md#DiGi.Math.Classes.Matrix 'DiGi\.Math\.Classes\.Matrix')  
A new [Matrix](DiGi.Math.Classes.md#DiGi.Math.Classes.Matrix 'DiGi\.Math\.Classes\.Matrix') representing the result of the subtraction, or [null](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null 'https://docs\.microsoft\.com/en\-us/dotnet/csharp/language\-reference/keywords/null') if the input matrix is null\.

<a name='DiGi.Math.Classes.Matrix2D'></a>

## Matrix2D Class

Represents a 2x2 square matrix providing specialized mathematical operations and serialization capabilities\.

```csharp
public class Matrix2D : DiGi.Math.Classes.Matrix, DiGi.Math.Interfaces.ISquareMatrix, DiGi.Math.Interfaces.IMatrix, DiGi.Core.Interfaces.ISerializableObject, DiGi.Core.Interfaces.ICloneableObject<DiGi.Core.Interfaces.ISerializableObject>, DiGi.Core.Interfaces.ICloneableObject, DiGi.Core.Interfaces.IObject
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → [DiGi\.Core\.Classes\.Object](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.object 'DiGi\.Core\.Classes\.Object') → [DiGi\.Core\.Classes\.SerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.serializableobject 'DiGi\.Core\.Classes\.SerializableObject') → [Matrix](DiGi.Math.Classes.md#DiGi.Math.Classes.Matrix 'DiGi\.Math\.Classes\.Matrix') → Matrix2D

Implements [ISquareMatrix](DiGi.Math.Interfaces.md#DiGi.Math.Interfaces.ISquareMatrix 'DiGi\.Math\.Interfaces\.ISquareMatrix'), [IMatrix](DiGi.Math.Interfaces.md#DiGi.Math.Interfaces.IMatrix 'DiGi\.Math\.Interfaces\.IMatrix'), [DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject'), [DiGi\.Core\.Interfaces\.ICloneableObject&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1')[DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1'), [DiGi\.Core\.Interfaces\.ICloneableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject 'DiGi\.Core\.Interfaces\.ICloneableObject'), [DiGi\.Core\.Interfaces\.IObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iobject 'DiGi\.Core\.Interfaces\.IObject')
### Constructors

<a name='DiGi.Math.Classes.Matrix2D.Matrix2D()'></a>

## Matrix2D\(\) Constructor

Initializes a new instance of the [Matrix2D](DiGi.Math.Classes.md#DiGi.Math.Classes.Matrix2D 'DiGi\.Math\.Classes\.Matrix2D') class with default dimensions of 2x2\.

```csharp
public Matrix2D();
```

<a name='DiGi.Math.Classes.Matrix2D.Matrix2D(DiGi.Math.Classes.Matrix2D)'></a>

## Matrix2D\(Matrix2D\) Constructor

Initializes a new instance of the [Matrix2D](DiGi.Math.Classes.md#DiGi.Math.Classes.Matrix2D 'DiGi\.Math\.Classes\.Matrix2D') class by copying the values from an existing [Matrix2D](DiGi.Math.Classes.md#DiGi.Math.Classes.Matrix2D 'DiGi\.Math\.Classes\.Matrix2D') instance\.

```csharp
public Matrix2D(DiGi.Math.Classes.Matrix2D? matrix2D);
```
#### Parameters

<a name='DiGi.Math.Classes.Matrix2D.Matrix2D(DiGi.Math.Classes.Matrix2D).matrix2D'></a>

`matrix2D` [Matrix2D](DiGi.Math.Classes.md#DiGi.Math.Classes.Matrix2D 'DiGi\.Math\.Classes\.Matrix2D')

The source matrix to copy\.

<a name='DiGi.Math.Classes.Matrix2D.Matrix2D(System.Text.Json.Nodes.JsonObject)'></a>

## Matrix2D\(JsonObject\) Constructor

Initializes a new instance of the [Matrix2D](DiGi.Math.Classes.md#DiGi.Math.Classes.Matrix2D 'DiGi\.Math\.Classes\.Matrix2D') class using the provided JSON object for deserialization\.

```csharp
public Matrix2D(System.Text.Json.Nodes.JsonObject? jsonObject);
```
#### Parameters

<a name='DiGi.Math.Classes.Matrix2D.Matrix2D(System.Text.Json.Nodes.JsonObject).jsonObject'></a>

`jsonObject` [System\.Text\.Json\.Nodes\.JsonObject](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonobject 'System\.Text\.Json\.Nodes\.JsonObject')

The [System\.Text\.Json\.Nodes\.JsonObject](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonobject 'System\.Text\.Json\.Nodes\.JsonObject') containing the matrix data\.
### Methods

<a name='DiGi.Math.Classes.Matrix2D.Clone()'></a>

## Matrix2D\.Clone\(\) Method

Creates a deep copy of the current [Matrix2D](DiGi.Math.Classes.md#DiGi.Math.Classes.Matrix2D 'DiGi\.Math\.Classes\.Matrix2D') instance\.

```csharp
public override DiGi.Core.Interfaces.ISerializableObject? Clone();
```

Implements [Clone\(\)](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1.clone 'DiGi\.Core\.Interfaces\.ICloneableObject\`1\.Clone')

#### Returns
[DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject')  
A new [DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject') representing the cloned matrix, or null\.
### Operators

<a name='DiGi.Math.Classes.Matrix2D.op_Addition(DiGi.Math.Classes.Matrix2D,DiGi.Math.Classes.Matrix2D)'></a>

## Matrix2D\.operator \+\(Matrix2D, Matrix2D\) Operator

Adds two [Matrix2D](DiGi.Math.Classes.md#DiGi.Math.Classes.Matrix2D 'DiGi\.Math\.Classes\.Matrix2D') instances together\.

```csharp
public static DiGi.Math.Classes.Matrix2D? operator +(DiGi.Math.Classes.Matrix2D? matrix2D_1, DiGi.Math.Classes.Matrix2D? matrix2D_2);
```
#### Parameters

<a name='DiGi.Math.Classes.Matrix2D.op_Addition(DiGi.Math.Classes.Matrix2D,DiGi.Math.Classes.Matrix2D).matrix2D_1'></a>

`matrix2D_1` [Matrix2D](DiGi.Math.Classes.md#DiGi.Math.Classes.Matrix2D 'DiGi\.Math\.Classes\.Matrix2D')

The first matrix operand\.

<a name='DiGi.Math.Classes.Matrix2D.op_Addition(DiGi.Math.Classes.Matrix2D,DiGi.Math.Classes.Matrix2D).matrix2D_2'></a>

`matrix2D_2` [Matrix2D](DiGi.Math.Classes.md#DiGi.Math.Classes.Matrix2D 'DiGi\.Math\.Classes\.Matrix2D')

The second matrix operand to add to the first\.

#### Returns
[Matrix2D](DiGi.Math.Classes.md#DiGi.Math.Classes.Matrix2D 'DiGi\.Math\.Classes\.Matrix2D')  
The result of the addition as a [Matrix2D](DiGi.Math.Classes.md#DiGi.Math.Classes.Matrix2D 'DiGi\.Math\.Classes\.Matrix2D'), or null if either operand is null\.

<a name='DiGi.Math.Classes.Matrix2D.op_Addition(DiGi.Math.Classes.Matrix2D,double)'></a>

## Matrix2D\.operator \+\(Matrix2D, double\) Operator

Adds a scalar value to every element of the [Matrix2D](DiGi.Math.Classes.md#DiGi.Math.Classes.Matrix2D 'DiGi\.Math\.Classes\.Matrix2D')\.

```csharp
public static DiGi.Math.Classes.Matrix2D? operator +(DiGi.Math.Classes.Matrix2D? matrix2D, double value);
```
#### Parameters

<a name='DiGi.Math.Classes.Matrix2D.op_Addition(DiGi.Math.Classes.Matrix2D,double).matrix2D'></a>

`matrix2D` [Matrix2D](DiGi.Math.Classes.md#DiGi.Math.Classes.Matrix2D 'DiGi\.Math\.Classes\.Matrix2D')

The matrix operand\.

<a name='DiGi.Math.Classes.Matrix2D.op_Addition(DiGi.Math.Classes.Matrix2D,double).value'></a>

`value` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The scalar value to add\.

#### Returns
[Matrix2D](DiGi.Math.Classes.md#DiGi.Math.Classes.Matrix2D 'DiGi\.Math\.Classes\.Matrix2D')  
A new [Matrix2D](DiGi.Math.Classes.md#DiGi.Math.Classes.Matrix2D 'DiGi\.Math\.Classes\.Matrix2D') containing the result, or null if the matrix is null\.

<a name='DiGi.Math.Classes.Matrix2D.op_ExplicitDiGi.Math.Classes.Matrix2D(double[,])'></a>

## Matrix2D\.explicit operator Matrix2D\(double\[,\]\) Operator

Explicitly converts a two\-dimensional array of doubles into a [Matrix2D](DiGi.Math.Classes.md#DiGi.Math.Classes.Matrix2D 'DiGi\.Math\.Classes\.Matrix2D') instance\.

```csharp
public static DiGi.Math.Classes.Matrix2D? explicit operator DiGi.Math.Classes.Matrix2D?(double[,]? values);
```
#### Parameters

<a name='DiGi.Math.Classes.Matrix2D.op_ExplicitDiGi.Math.Classes.Matrix2D(double[,]).values'></a>

`values` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')[\[\]](https://learn.microsoft.com/en-us/dotnet/api/system.array 'System\.Array')

The 2D double array to convert\.

#### Returns
[Matrix2D](DiGi.Math.Classes.md#DiGi.Math.Classes.Matrix2D 'DiGi\.Math\.Classes\.Matrix2D')  
A [Matrix2D](DiGi.Math.Classes.md#DiGi.Math.Classes.Matrix2D 'DiGi\.Math\.Classes\.Matrix2D') instance created from the values, or null if the input is null\.

<a name='DiGi.Math.Classes.Matrix2D.op_Multiply(DiGi.Math.Classes.Matrix2D,DiGi.Math.Classes.Matrix2D)'></a>

## Matrix2D\.operator \*\(Matrix2D, Matrix2D\) Operator

Performs matrix multiplication between two [Matrix2D](DiGi.Math.Classes.md#DiGi.Math.Classes.Matrix2D 'DiGi\.Math\.Classes\.Matrix2D') instances\.

```csharp
public static DiGi.Math.Classes.Matrix2D? operator *(DiGi.Math.Classes.Matrix2D? matrix2D_1, DiGi.Math.Classes.Matrix2D? matrix2D_2);
```
#### Parameters

<a name='DiGi.Math.Classes.Matrix2D.op_Multiply(DiGi.Math.Classes.Matrix2D,DiGi.Math.Classes.Matrix2D).matrix2D_1'></a>

`matrix2D_1` [Matrix2D](DiGi.Math.Classes.md#DiGi.Math.Classes.Matrix2D 'DiGi\.Math\.Classes\.Matrix2D')

The left\-hand side matrix operand\.

<a name='DiGi.Math.Classes.Matrix2D.op_Multiply(DiGi.Math.Classes.Matrix2D,DiGi.Math.Classes.Matrix2D).matrix2D_2'></a>

`matrix2D_2` [Matrix2D](DiGi.Math.Classes.md#DiGi.Math.Classes.Matrix2D 'DiGi\.Math\.Classes\.Matrix2D')

The right\-hand side matrix operand\.

#### Returns
[Matrix2D](DiGi.Math.Classes.md#DiGi.Math.Classes.Matrix2D 'DiGi\.Math\.Classes\.Matrix2D')  
The resulting product as a [Matrix2D](DiGi.Math.Classes.md#DiGi.Math.Classes.Matrix2D 'DiGi\.Math\.Classes\.Matrix2D'), or null if either operand is null\.

<a name='DiGi.Math.Classes.Matrix2D.op_Multiply(DiGi.Math.Classes.Matrix2D,double)'></a>

## Matrix2D\.operator \*\(Matrix2D, double\) Operator

Multiplies every element of the [Matrix2D](DiGi.Math.Classes.md#DiGi.Math.Classes.Matrix2D 'DiGi\.Math\.Classes\.Matrix2D') by a scalar value\.

```csharp
public static DiGi.Math.Classes.Matrix2D? operator *(DiGi.Math.Classes.Matrix2D? matrix2D, double value);
```
#### Parameters

<a name='DiGi.Math.Classes.Matrix2D.op_Multiply(DiGi.Math.Classes.Matrix2D,double).matrix2D'></a>

`matrix2D` [Matrix2D](DiGi.Math.Classes.md#DiGi.Math.Classes.Matrix2D 'DiGi\.Math\.Classes\.Matrix2D')

The matrix operand\.

<a name='DiGi.Math.Classes.Matrix2D.op_Multiply(DiGi.Math.Classes.Matrix2D,double).value'></a>

`value` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The scalar multiplier\.

#### Returns
[Matrix2D](DiGi.Math.Classes.md#DiGi.Math.Classes.Matrix2D 'DiGi\.Math\.Classes\.Matrix2D')  
A new [Matrix2D](DiGi.Math.Classes.md#DiGi.Math.Classes.Matrix2D 'DiGi\.Math\.Classes\.Matrix2D') containing the result, or null if the matrix is null\.

<a name='DiGi.Math.Classes.Matrix2D.op_Subtraction(DiGi.Math.Classes.Matrix2D,DiGi.Math.Classes.Matrix2D)'></a>

## Matrix2D\.operator \-\(Matrix2D, Matrix2D\) Operator

Subtracts one [Matrix2D](DiGi.Math.Classes.md#DiGi.Math.Classes.Matrix2D 'DiGi\.Math\.Classes\.Matrix2D') from another\.

```csharp
public static DiGi.Math.Classes.Matrix2D? operator -(DiGi.Math.Classes.Matrix2D? matrix2D_1, DiGi.Math.Classes.Matrix2D? matrix2D_2);
```
#### Parameters

<a name='DiGi.Math.Classes.Matrix2D.op_Subtraction(DiGi.Math.Classes.Matrix2D,DiGi.Math.Classes.Matrix2D).matrix2D_1'></a>

`matrix2D_1` [Matrix2D](DiGi.Math.Classes.md#DiGi.Math.Classes.Matrix2D 'DiGi\.Math\.Classes\.Matrix2D')

The first matrix operand\.

<a name='DiGi.Math.Classes.Matrix2D.op_Subtraction(DiGi.Math.Classes.Matrix2D,DiGi.Math.Classes.Matrix2D).matrix2D_2'></a>

`matrix2D_2` [Matrix2D](DiGi.Math.Classes.md#DiGi.Math.Classes.Matrix2D 'DiGi\.Math\.Classes\.Matrix2D')

The second matrix operand to subtract from the first\.

#### Returns
[Matrix2D](DiGi.Math.Classes.md#DiGi.Math.Classes.Matrix2D 'DiGi\.Math\.Classes\.Matrix2D')  
The result of the subtraction as a [Matrix2D](DiGi.Math.Classes.md#DiGi.Math.Classes.Matrix2D 'DiGi\.Math\.Classes\.Matrix2D'), or null if either operand is null\.

<a name='DiGi.Math.Classes.Matrix2D.op_Subtraction(DiGi.Math.Classes.Matrix2D,double)'></a>

## Matrix2D\.operator \-\(Matrix2D, double\) Operator

Subtracts a scalar value from every element of the [Matrix2D](DiGi.Math.Classes.md#DiGi.Math.Classes.Matrix2D 'DiGi\.Math\.Classes\.Matrix2D')\.

```csharp
public static DiGi.Math.Classes.Matrix2D? operator -(DiGi.Math.Classes.Matrix2D? matrix2D, double value);
```
#### Parameters

<a name='DiGi.Math.Classes.Matrix2D.op_Subtraction(DiGi.Math.Classes.Matrix2D,double).matrix2D'></a>

`matrix2D` [Matrix2D](DiGi.Math.Classes.md#DiGi.Math.Classes.Matrix2D 'DiGi\.Math\.Classes\.Matrix2D')

The matrix operand\.

<a name='DiGi.Math.Classes.Matrix2D.op_Subtraction(DiGi.Math.Classes.Matrix2D,double).value'></a>

`value` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The scalar value to subtract\.

#### Returns
[Matrix2D](DiGi.Math.Classes.md#DiGi.Math.Classes.Matrix2D 'DiGi\.Math\.Classes\.Matrix2D')  
A new [Matrix2D](DiGi.Math.Classes.md#DiGi.Math.Classes.Matrix2D 'DiGi\.Math\.Classes\.Matrix2D') containing the result, or null if the matrix is null\.

<a name='DiGi.Math.Classes.Matrix3D'></a>

## Matrix3D Class

Represents a 3x3 square matrix used for three\-dimensional mathematical operations\.

```csharp
public class Matrix3D : DiGi.Math.Classes.Matrix, DiGi.Math.Interfaces.ISquareMatrix, DiGi.Math.Interfaces.IMatrix, DiGi.Core.Interfaces.ISerializableObject, DiGi.Core.Interfaces.ICloneableObject<DiGi.Core.Interfaces.ISerializableObject>, DiGi.Core.Interfaces.ICloneableObject, DiGi.Core.Interfaces.IObject
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → [DiGi\.Core\.Classes\.Object](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.object 'DiGi\.Core\.Classes\.Object') → [DiGi\.Core\.Classes\.SerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.serializableobject 'DiGi\.Core\.Classes\.SerializableObject') → [Matrix](DiGi.Math.Classes.md#DiGi.Math.Classes.Matrix 'DiGi\.Math\.Classes\.Matrix') → Matrix3D

Implements [ISquareMatrix](DiGi.Math.Interfaces.md#DiGi.Math.Interfaces.ISquareMatrix 'DiGi\.Math\.Interfaces\.ISquareMatrix'), [IMatrix](DiGi.Math.Interfaces.md#DiGi.Math.Interfaces.IMatrix 'DiGi\.Math\.Interfaces\.IMatrix'), [DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject'), [DiGi\.Core\.Interfaces\.ICloneableObject&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1')[DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1'), [DiGi\.Core\.Interfaces\.ICloneableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject 'DiGi\.Core\.Interfaces\.ICloneableObject'), [DiGi\.Core\.Interfaces\.IObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iobject 'DiGi\.Core\.Interfaces\.IObject')
### Constructors

<a name='DiGi.Math.Classes.Matrix3D.Matrix3D()'></a>

## Matrix3D\(\) Constructor

Initializes a new instance of the [Matrix3D](DiGi.Math.Classes.md#DiGi.Math.Classes.Matrix3D 'DiGi\.Math\.Classes\.Matrix3D') class as a 3x3 matrix\.

```csharp
public Matrix3D();
```

<a name='DiGi.Math.Classes.Matrix3D.Matrix3D(DiGi.Math.Classes.Matrix3D)'></a>

## Matrix3D\(Matrix3D\) Constructor

Initializes a new instance of the [Matrix3D](DiGi.Math.Classes.md#DiGi.Math.Classes.Matrix3D 'DiGi\.Math\.Classes\.Matrix3D') class by copying an existing [Matrix3D](DiGi.Math.Classes.md#DiGi.Math.Classes.Matrix3D 'DiGi\.Math\.Classes\.Matrix3D') instance\.

```csharp
public Matrix3D(DiGi.Math.Classes.Matrix3D? matrix3D);
```
#### Parameters

<a name='DiGi.Math.Classes.Matrix3D.Matrix3D(DiGi.Math.Classes.Matrix3D).matrix3D'></a>

`matrix3D` [Matrix3D](DiGi.Math.Classes.md#DiGi.Math.Classes.Matrix3D 'DiGi\.Math\.Classes\.Matrix3D')

The source [Matrix3D](DiGi.Math.Classes.md#DiGi.Math.Classes.Matrix3D 'DiGi\.Math\.Classes\.Matrix3D') to copy\.

<a name='DiGi.Math.Classes.Matrix3D.Matrix3D(System.Text.Json.Nodes.JsonObject)'></a>

## Matrix3D\(JsonObject\) Constructor

Initializes a new instance of the [Matrix3D](DiGi.Math.Classes.md#DiGi.Math.Classes.Matrix3D 'DiGi\.Math\.Classes\.Matrix3D') class from the specified JSON object\.

```csharp
public Matrix3D(System.Text.Json.Nodes.JsonObject? jsonObject);
```
#### Parameters

<a name='DiGi.Math.Classes.Matrix3D.Matrix3D(System.Text.Json.Nodes.JsonObject).jsonObject'></a>

`jsonObject` [System\.Text\.Json\.Nodes\.JsonObject](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonobject 'System\.Text\.Json\.Nodes\.JsonObject')

The [System\.Text\.Json\.Nodes\.JsonObject](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonobject 'System\.Text\.Json\.Nodes\.JsonObject') containing the matrix data\.
### Methods

<a name='DiGi.Math.Classes.Matrix3D.Clone()'></a>

## Matrix3D\.Clone\(\) Method

Creates a deep copy of the current [Matrix3D](DiGi.Math.Classes.md#DiGi.Math.Classes.Matrix3D 'DiGi\.Math\.Classes\.Matrix3D') instance\.

```csharp
public override DiGi.Core.Interfaces.ISerializableObject? Clone();
```

Implements [Clone\(\)](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1.clone 'DiGi\.Core\.Interfaces\.ICloneableObject\`1\.Clone')

#### Returns
[DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject')  
A new [DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject') representing the cloned matrix\.
### Operators

<a name='DiGi.Math.Classes.Matrix3D.op_Addition(DiGi.Math.Classes.Matrix3D,DiGi.Math.Classes.Matrix3D)'></a>

## Matrix3D\.operator \+\(Matrix3D, Matrix3D\) Operator

Adds two [Matrix3D](DiGi.Math.Classes.md#DiGi.Math.Classes.Matrix3D 'DiGi\.Math\.Classes\.Matrix3D') instances together\.

```csharp
public static DiGi.Math.Classes.Matrix3D? operator +(DiGi.Math.Classes.Matrix3D? matrix3D_1, DiGi.Math.Classes.Matrix3D? matrix3D_2);
```
#### Parameters

<a name='DiGi.Math.Classes.Matrix3D.op_Addition(DiGi.Math.Classes.Matrix3D,DiGi.Math.Classes.Matrix3D).matrix3D_1'></a>

`matrix3D_1` [Matrix3D](DiGi.Math.Classes.md#DiGi.Math.Classes.Matrix3D 'DiGi\.Math\.Classes\.Matrix3D')

The first [Matrix3D](DiGi.Math.Classes.md#DiGi.Math.Classes.Matrix3D 'DiGi\.Math\.Classes\.Matrix3D')\.

<a name='DiGi.Math.Classes.Matrix3D.op_Addition(DiGi.Math.Classes.Matrix3D,DiGi.Math.Classes.Matrix3D).matrix3D_2'></a>

`matrix3D_2` [Matrix3D](DiGi.Math.Classes.md#DiGi.Math.Classes.Matrix3D 'DiGi\.Math\.Classes\.Matrix3D')

The second [Matrix3D](DiGi.Math.Classes.md#DiGi.Math.Classes.Matrix3D 'DiGi\.Math\.Classes\.Matrix3D') to add to the first\.

#### Returns
[Matrix3D](DiGi.Math.Classes.md#DiGi.Math.Classes.Matrix3D 'DiGi\.Math\.Classes\.Matrix3D')  
The result of the addition as a [Matrix3D](DiGi.Math.Classes.md#DiGi.Math.Classes.Matrix3D 'DiGi\.Math\.Classes\.Matrix3D'), or null if either operand is null\.

<a name='DiGi.Math.Classes.Matrix3D.op_Addition(DiGi.Math.Classes.Matrix3D,double)'></a>

## Matrix3D\.operator \+\(Matrix3D, double\) Operator

Adds a scalar value to each element of the [Matrix3D](DiGi.Math.Classes.md#DiGi.Math.Classes.Matrix3D 'DiGi\.Math\.Classes\.Matrix3D')\.

```csharp
public static DiGi.Math.Classes.Matrix3D? operator +(DiGi.Math.Classes.Matrix3D? matrix3D, double value);
```
#### Parameters

<a name='DiGi.Math.Classes.Matrix3D.op_Addition(DiGi.Math.Classes.Matrix3D,double).matrix3D'></a>

`matrix3D` [Matrix3D](DiGi.Math.Classes.md#DiGi.Math.Classes.Matrix3D 'DiGi\.Math\.Classes\.Matrix3D')

The [Matrix3D](DiGi.Math.Classes.md#DiGi.Math.Classes.Matrix3D 'DiGi\.Math\.Classes\.Matrix3D') instance\.

<a name='DiGi.Math.Classes.Matrix3D.op_Addition(DiGi.Math.Classes.Matrix3D,double).value'></a>

`value` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The double value to add\.

#### Returns
[Matrix3D](DiGi.Math.Classes.md#DiGi.Math.Classes.Matrix3D 'DiGi\.Math\.Classes\.Matrix3D')  
A new [Matrix3D](DiGi.Math.Classes.md#DiGi.Math.Classes.Matrix3D 'DiGi\.Math\.Classes\.Matrix3D') containing the result, or null if the matrix is null\.

<a name='DiGi.Math.Classes.Matrix3D.op_ExplicitDiGi.Math.Classes.Matrix3D(double[,])'></a>

## Matrix3D\.explicit operator Matrix3D\(double\[,\]\) Operator

Explicitly converts a two\-dimensional array of doubles to a [Matrix3D](DiGi.Math.Classes.md#DiGi.Math.Classes.Matrix3D 'DiGi\.Math\.Classes\.Matrix3D')\.

```csharp
public static DiGi.Math.Classes.Matrix3D? explicit operator DiGi.Math.Classes.Matrix3D?(double[,]? values);
```
#### Parameters

<a name='DiGi.Math.Classes.Matrix3D.op_ExplicitDiGi.Math.Classes.Matrix3D(double[,]).values'></a>

`values` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')[\[\]](https://learn.microsoft.com/en-us/dotnet/api/system.array 'System\.Array')

The 2D double array containing the matrix elements\.

#### Returns
[Matrix3D](DiGi.Math.Classes.md#DiGi.Math.Classes.Matrix3D 'DiGi\.Math\.Classes\.Matrix3D')  
A [Matrix3D](DiGi.Math.Classes.md#DiGi.Math.Classes.Matrix3D 'DiGi\.Math\.Classes\.Matrix3D') instance created from the values, or null if the input is null\.

<a name='DiGi.Math.Classes.Matrix3D.op_Multiply(DiGi.Math.Classes.Matrix3D,DiGi.Math.Classes.Matrix3D)'></a>

## Matrix3D\.operator \*\(Matrix3D, Matrix3D\) Operator

Performs matrix multiplication between two [Matrix3D](DiGi.Math.Classes.md#DiGi.Math.Classes.Matrix3D 'DiGi\.Math\.Classes\.Matrix3D') instances\.

```csharp
public static DiGi.Math.Classes.Matrix3D? operator *(DiGi.Math.Classes.Matrix3D? matrix3D_1, DiGi.Math.Classes.Matrix3D? matrix3D_2);
```
#### Parameters

<a name='DiGi.Math.Classes.Matrix3D.op_Multiply(DiGi.Math.Classes.Matrix3D,DiGi.Math.Classes.Matrix3D).matrix3D_1'></a>

`matrix3D_1` [Matrix3D](DiGi.Math.Classes.md#DiGi.Math.Classes.Matrix3D 'DiGi\.Math\.Classes\.Matrix3D')

The left\-hand side [Matrix3D](DiGi.Math.Classes.md#DiGi.Math.Classes.Matrix3D 'DiGi\.Math\.Classes\.Matrix3D')\.

<a name='DiGi.Math.Classes.Matrix3D.op_Multiply(DiGi.Math.Classes.Matrix3D,DiGi.Math.Classes.Matrix3D).matrix3D_2'></a>

`matrix3D_2` [Matrix3D](DiGi.Math.Classes.md#DiGi.Math.Classes.Matrix3D 'DiGi\.Math\.Classes\.Matrix3D')

The right\-hand side [Matrix3D](DiGi.Math.Classes.md#DiGi.Math.Classes.Matrix3D 'DiGi\.Math\.Classes\.Matrix3D')\.

#### Returns
[Matrix3D](DiGi.Math.Classes.md#DiGi.Math.Classes.Matrix3D 'DiGi\.Math\.Classes\.Matrix3D')  
The resulting [Matrix3D](DiGi.Math.Classes.md#DiGi.Math.Classes.Matrix3D 'DiGi\.Math\.Classes\.Matrix3D') from the multiplication, or null if either operand is null\.

<a name='DiGi.Math.Classes.Matrix3D.op_Multiply(DiGi.Math.Classes.Matrix3D,double)'></a>

## Matrix3D\.operator \*\(Matrix3D, double\) Operator

Multiplies each element of the [Matrix3D](DiGi.Math.Classes.md#DiGi.Math.Classes.Matrix3D 'DiGi\.Math\.Classes\.Matrix3D') by a scalar value\.

```csharp
public static DiGi.Math.Classes.Matrix3D? operator *(DiGi.Math.Classes.Matrix3D? matrix3D, double value);
```
#### Parameters

<a name='DiGi.Math.Classes.Matrix3D.op_Multiply(DiGi.Math.Classes.Matrix3D,double).matrix3D'></a>

`matrix3D` [Matrix3D](DiGi.Math.Classes.md#DiGi.Math.Classes.Matrix3D 'DiGi\.Math\.Classes\.Matrix3D')

The [Matrix3D](DiGi.Math.Classes.md#DiGi.Math.Classes.Matrix3D 'DiGi\.Math\.Classes\.Matrix3D') instance\.

<a name='DiGi.Math.Classes.Matrix3D.op_Multiply(DiGi.Math.Classes.Matrix3D,double).value'></a>

`value` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The double value to multiply by\.

#### Returns
[Matrix3D](DiGi.Math.Classes.md#DiGi.Math.Classes.Matrix3D 'DiGi\.Math\.Classes\.Matrix3D')  
A new [Matrix3D](DiGi.Math.Classes.md#DiGi.Math.Classes.Matrix3D 'DiGi\.Math\.Classes\.Matrix3D') containing the result, or null if the matrix is null\.

<a name='DiGi.Math.Classes.Matrix3D.op_Subtraction(DiGi.Math.Classes.Matrix3D,DiGi.Math.Classes.Matrix3D)'></a>

## Matrix3D\.operator \-\(Matrix3D, Matrix3D\) Operator

Subtracts one [Matrix3D](DiGi.Math.Classes.md#DiGi.Math.Classes.Matrix3D 'DiGi\.Math\.Classes\.Matrix3D') from another\.

```csharp
public static DiGi.Math.Classes.Matrix3D? operator -(DiGi.Math.Classes.Matrix3D? matrix3D_1, DiGi.Math.Classes.Matrix3D? matrix3D_2);
```
#### Parameters

<a name='DiGi.Math.Classes.Matrix3D.op_Subtraction(DiGi.Math.Classes.Matrix3D,DiGi.Math.Classes.Matrix3D).matrix3D_1'></a>

`matrix3D_1` [Matrix3D](DiGi.Math.Classes.md#DiGi.Math.Classes.Matrix3D 'DiGi\.Math\.Classes\.Matrix3D')

The first [Matrix3D](DiGi.Math.Classes.md#DiGi.Math.Classes.Matrix3D 'DiGi\.Math\.Classes\.Matrix3D')\.

<a name='DiGi.Math.Classes.Matrix3D.op_Subtraction(DiGi.Math.Classes.Matrix3D,DiGi.Math.Classes.Matrix3D).matrix3D_2'></a>

`matrix3D_2` [Matrix3D](DiGi.Math.Classes.md#DiGi.Math.Classes.Matrix3D 'DiGi\.Math\.Classes\.Matrix3D')

The second [Matrix3D](DiGi.Math.Classes.md#DiGi.Math.Classes.Matrix3D 'DiGi\.Math\.Classes\.Matrix3D') to subtract from the first\.

#### Returns
[Matrix3D](DiGi.Math.Classes.md#DiGi.Math.Classes.Matrix3D 'DiGi\.Math\.Classes\.Matrix3D')  
The result of the subtraction as a [Matrix3D](DiGi.Math.Classes.md#DiGi.Math.Classes.Matrix3D 'DiGi\.Math\.Classes\.Matrix3D'), or null if either operand is null\.

<a name='DiGi.Math.Classes.Matrix3D.op_Subtraction(DiGi.Math.Classes.Matrix3D,double)'></a>

## Matrix3D\.operator \-\(Matrix3D, double\) Operator

Subtracts a scalar value from each element of the [Matrix3D](DiGi.Math.Classes.md#DiGi.Math.Classes.Matrix3D 'DiGi\.Math\.Classes\.Matrix3D')\.

```csharp
public static DiGi.Math.Classes.Matrix3D? operator -(DiGi.Math.Classes.Matrix3D? matrix3D, double value);
```
#### Parameters

<a name='DiGi.Math.Classes.Matrix3D.op_Subtraction(DiGi.Math.Classes.Matrix3D,double).matrix3D'></a>

`matrix3D` [Matrix3D](DiGi.Math.Classes.md#DiGi.Math.Classes.Matrix3D 'DiGi\.Math\.Classes\.Matrix3D')

The [Matrix3D](DiGi.Math.Classes.md#DiGi.Math.Classes.Matrix3D 'DiGi\.Math\.Classes\.Matrix3D') instance\.

<a name='DiGi.Math.Classes.Matrix3D.op_Subtraction(DiGi.Math.Classes.Matrix3D,double).value'></a>

`value` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The double value to subtract\.

#### Returns
[Matrix3D](DiGi.Math.Classes.md#DiGi.Math.Classes.Matrix3D 'DiGi\.Math\.Classes\.Matrix3D')  
A new [Matrix3D](DiGi.Math.Classes.md#DiGi.Math.Classes.Matrix3D 'DiGi\.Math\.Classes\.Matrix3D') containing the result, or null if the matrix is null\.

<a name='DiGi.Math.Classes.Matrix4D'></a>

## Matrix4D Class

Represents a 4x4 square matrix providing mathematical operations and serialization capabilities\.

```csharp
public class Matrix4D : DiGi.Math.Classes.Matrix, DiGi.Math.Interfaces.ISquareMatrix, DiGi.Math.Interfaces.IMatrix, DiGi.Core.Interfaces.ISerializableObject, DiGi.Core.Interfaces.ICloneableObject<DiGi.Core.Interfaces.ISerializableObject>, DiGi.Core.Interfaces.ICloneableObject, DiGi.Core.Interfaces.IObject
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → [DiGi\.Core\.Classes\.Object](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.object 'DiGi\.Core\.Classes\.Object') → [DiGi\.Core\.Classes\.SerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.serializableobject 'DiGi\.Core\.Classes\.SerializableObject') → [Matrix](DiGi.Math.Classes.md#DiGi.Math.Classes.Matrix 'DiGi\.Math\.Classes\.Matrix') → Matrix4D

Implements [ISquareMatrix](DiGi.Math.Interfaces.md#DiGi.Math.Interfaces.ISquareMatrix 'DiGi\.Math\.Interfaces\.ISquareMatrix'), [IMatrix](DiGi.Math.Interfaces.md#DiGi.Math.Interfaces.IMatrix 'DiGi\.Math\.Interfaces\.IMatrix'), [DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject'), [DiGi\.Core\.Interfaces\.ICloneableObject&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1')[DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1'), [DiGi\.Core\.Interfaces\.ICloneableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject 'DiGi\.Core\.Interfaces\.ICloneableObject'), [DiGi\.Core\.Interfaces\.IObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iobject 'DiGi\.Core\.Interfaces\.IObject')
### Constructors

<a name='DiGi.Math.Classes.Matrix4D.Matrix4D()'></a>

## Matrix4D\(\) Constructor

Initializes a new instance of the [Matrix4D](DiGi.Math.Classes.md#DiGi.Math.Classes.Matrix4D 'DiGi\.Math\.Classes\.Matrix4D') class as a 4x4 matrix\.

```csharp
public Matrix4D();
```

<a name='DiGi.Math.Classes.Matrix4D.Matrix4D(DiGi.Math.Classes.Matrix4D)'></a>

## Matrix4D\(Matrix4D\) Constructor

Initializes a new instance of the [Matrix4D](DiGi.Math.Classes.md#DiGi.Math.Classes.Matrix4D 'DiGi\.Math\.Classes\.Matrix4D') class by copying an existing matrix\.

```csharp
public Matrix4D(DiGi.Math.Classes.Matrix4D? matrix4D);
```
#### Parameters

<a name='DiGi.Math.Classes.Matrix4D.Matrix4D(DiGi.Math.Classes.Matrix4D).matrix4D'></a>

`matrix4D` [Matrix4D](DiGi.Math.Classes.md#DiGi.Math.Classes.Matrix4D 'DiGi\.Math\.Classes\.Matrix4D')

The source [Matrix4D](DiGi.Math.Classes.md#DiGi.Math.Classes.Matrix4D 'DiGi\.Math\.Classes\.Matrix4D') to copy\.

<a name='DiGi.Math.Classes.Matrix4D.Matrix4D(System.Text.Json.Nodes.JsonObject)'></a>

## Matrix4D\(JsonObject\) Constructor

Initializes a new instance of the [Matrix4D](DiGi.Math.Classes.md#DiGi.Math.Classes.Matrix4D 'DiGi\.Math\.Classes\.Matrix4D') class using a JSON object\.

```csharp
public Matrix4D(System.Text.Json.Nodes.JsonObject? jsonObject);
```
#### Parameters

<a name='DiGi.Math.Classes.Matrix4D.Matrix4D(System.Text.Json.Nodes.JsonObject).jsonObject'></a>

`jsonObject` [System\.Text\.Json\.Nodes\.JsonObject](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonobject 'System\.Text\.Json\.Nodes\.JsonObject')

The [System\.Text\.Json\.Nodes\.JsonObject](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonobject 'System\.Text\.Json\.Nodes\.JsonObject') containing the matrix data\.
### Methods

<a name='DiGi.Math.Classes.Matrix4D.Clone()'></a>

## Matrix4D\.Clone\(\) Method

Creates a deep copy of the current [Matrix4D](DiGi.Math.Classes.md#DiGi.Math.Classes.Matrix4D 'DiGi\.Math\.Classes\.Matrix4D') instance\.

```csharp
public override DiGi.Core.Interfaces.ISerializableObject? Clone();
```

Implements [Clone\(\)](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1.clone 'DiGi\.Core\.Interfaces\.ICloneableObject\`1\.Clone')

#### Returns
[DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject')  
A new [DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject') representing the cloned matrix, or null\.
### Operators

<a name='DiGi.Math.Classes.Matrix4D.op_Addition(DiGi.Math.Classes.Matrix4D,DiGi.Math.Classes.Matrix4D)'></a>

## Matrix4D\.operator \+\(Matrix4D, Matrix4D\) Operator

Adds two [Matrix4D](DiGi.Math.Classes.md#DiGi.Math.Classes.Matrix4D 'DiGi\.Math\.Classes\.Matrix4D') matrices together\.

```csharp
public static DiGi.Math.Classes.Matrix4D? operator +(DiGi.Math.Classes.Matrix4D? matrix4D_1, DiGi.Math.Classes.Matrix4D? matrix4D_2);
```
#### Parameters

<a name='DiGi.Math.Classes.Matrix4D.op_Addition(DiGi.Math.Classes.Matrix4D,DiGi.Math.Classes.Matrix4D).matrix4D_1'></a>

`matrix4D_1` [Matrix4D](DiGi.Math.Classes.md#DiGi.Math.Classes.Matrix4D 'DiGi\.Math\.Classes\.Matrix4D')

The first matrix\.

<a name='DiGi.Math.Classes.Matrix4D.op_Addition(DiGi.Math.Classes.Matrix4D,DiGi.Math.Classes.Matrix4D).matrix4D_2'></a>

`matrix4D_2` [Matrix4D](DiGi.Math.Classes.md#DiGi.Math.Classes.Matrix4D 'DiGi\.Math\.Classes\.Matrix4D')

The second matrix to add to the first\.

#### Returns
[Matrix4D](DiGi.Math.Classes.md#DiGi.Math.Classes.Matrix4D 'DiGi\.Math\.Classes\.Matrix4D')  
The result of the addition as a [Matrix4D](DiGi.Math.Classes.md#DiGi.Math.Classes.Matrix4D 'DiGi\.Math\.Classes\.Matrix4D'), or null if either operand is null\.

<a name='DiGi.Math.Classes.Matrix4D.op_Addition(DiGi.Math.Classes.Matrix4D,double)'></a>

## Matrix4D\.operator \+\(Matrix4D, double\) Operator

Adds a scalar value to each element of the [Matrix4D](DiGi.Math.Classes.md#DiGi.Math.Classes.Matrix4D 'DiGi\.Math\.Classes\.Matrix4D')\.

```csharp
public static DiGi.Math.Classes.Matrix4D? operator +(DiGi.Math.Classes.Matrix4D? matrix4D, double value);
```
#### Parameters

<a name='DiGi.Math.Classes.Matrix4D.op_Addition(DiGi.Math.Classes.Matrix4D,double).matrix4D'></a>

`matrix4D` [Matrix4D](DiGi.Math.Classes.md#DiGi.Math.Classes.Matrix4D 'DiGi\.Math\.Classes\.Matrix4D')

The matrix to add to\.

<a name='DiGi.Math.Classes.Matrix4D.op_Addition(DiGi.Math.Classes.Matrix4D,double).value'></a>

`value` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The scalar value to add\.

#### Returns
[Matrix4D](DiGi.Math.Classes.md#DiGi.Math.Classes.Matrix4D 'DiGi\.Math\.Classes\.Matrix4D')  
A new [Matrix4D](DiGi.Math.Classes.md#DiGi.Math.Classes.Matrix4D 'DiGi\.Math\.Classes\.Matrix4D') containing the result, or null if the matrix is null\.

<a name='DiGi.Math.Classes.Matrix4D.op_ExplicitDiGi.Math.Classes.Matrix4D(double[,])'></a>

## Matrix4D\.explicit operator Matrix4D\(double\[,\]\) Operator

Explicitly converts a two\-dimensional array of doubles to a [Matrix4D](DiGi.Math.Classes.md#DiGi.Math.Classes.Matrix4D 'DiGi\.Math\.Classes\.Matrix4D')\.

```csharp
public static DiGi.Math.Classes.Matrix4D? explicit operator DiGi.Math.Classes.Matrix4D?(double[,]? values);
```
#### Parameters

<a name='DiGi.Math.Classes.Matrix4D.op_ExplicitDiGi.Math.Classes.Matrix4D(double[,]).values'></a>

`values` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')[\[\]](https://learn.microsoft.com/en-us/dotnet/api/system.array 'System\.Array')

The 2D double array containing the matrix elements\.

#### Returns
[Matrix4D](DiGi.Math.Classes.md#DiGi.Math.Classes.Matrix4D 'DiGi\.Math\.Classes\.Matrix4D')  
A [Matrix4D](DiGi.Math.Classes.md#DiGi.Math.Classes.Matrix4D 'DiGi\.Math\.Classes\.Matrix4D') instance created from the values, or null if the input is null\.

<a name='DiGi.Math.Classes.Matrix4D.op_Multiply(DiGi.Math.Classes.Matrix4D,DiGi.Math.Classes.Matrix4D)'></a>

## Matrix4D\.operator \*\(Matrix4D, Matrix4D\) Operator

Multiplies two [Matrix4D](DiGi.Math.Classes.md#DiGi.Math.Classes.Matrix4D 'DiGi\.Math\.Classes\.Matrix4D') matrices\.

```csharp
public static DiGi.Math.Classes.Matrix4D? operator *(DiGi.Math.Classes.Matrix4D? matrix4D_1, DiGi.Math.Classes.Matrix4D? matrix4D_2);
```
#### Parameters

<a name='DiGi.Math.Classes.Matrix4D.op_Multiply(DiGi.Math.Classes.Matrix4D,DiGi.Math.Classes.Matrix4D).matrix4D_1'></a>

`matrix4D_1` [Matrix4D](DiGi.Math.Classes.md#DiGi.Math.Classes.Matrix4D 'DiGi\.Math\.Classes\.Matrix4D')

The first matrix\.

<a name='DiGi.Math.Classes.Matrix4D.op_Multiply(DiGi.Math.Classes.Matrix4D,DiGi.Math.Classes.Matrix4D).matrix4D_2'></a>

`matrix4D_2` [Matrix4D](DiGi.Math.Classes.md#DiGi.Math.Classes.Matrix4D 'DiGi\.Math\.Classes\.Matrix4D')

The second matrix\.

#### Returns
[Matrix4D](DiGi.Math.Classes.md#DiGi.Math.Classes.Matrix4D 'DiGi\.Math\.Classes\.Matrix4D')  
The result of the multiplication as a [Matrix4D](DiGi.Math.Classes.md#DiGi.Math.Classes.Matrix4D 'DiGi\.Math\.Classes\.Matrix4D'), or null if either operand is null\.

<a name='DiGi.Math.Classes.Matrix4D.op_Multiply(DiGi.Math.Classes.Matrix4D,double)'></a>

## Matrix4D\.operator \*\(Matrix4D, double\) Operator

Multiplies each element of the [Matrix4D](DiGi.Math.Classes.md#DiGi.Math.Classes.Matrix4D 'DiGi\.Math\.Classes\.Matrix4D') by a scalar value\.

```csharp
public static DiGi.Math.Classes.Matrix4D? operator *(DiGi.Math.Classes.Matrix4D? matrix4D, double value);
```
#### Parameters

<a name='DiGi.Math.Classes.Matrix4D.op_Multiply(DiGi.Math.Classes.Matrix4D,double).matrix4D'></a>

`matrix4D` [Matrix4D](DiGi.Math.Classes.md#DiGi.Math.Classes.Matrix4D 'DiGi\.Math\.Classes\.Matrix4D')

The matrix to multiply\.

<a name='DiGi.Math.Classes.Matrix4D.op_Multiply(DiGi.Math.Classes.Matrix4D,double).value'></a>

`value` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The scalar multiplier\.

#### Returns
[Matrix4D](DiGi.Math.Classes.md#DiGi.Math.Classes.Matrix4D 'DiGi\.Math\.Classes\.Matrix4D')  
A new [Matrix4D](DiGi.Math.Classes.md#DiGi.Math.Classes.Matrix4D 'DiGi\.Math\.Classes\.Matrix4D') containing the result, or null if the matrix is null\.

<a name='DiGi.Math.Classes.Matrix4D.op_Subtraction(DiGi.Math.Classes.Matrix4D,DiGi.Math.Classes.Matrix4D)'></a>

## Matrix4D\.operator \-\(Matrix4D, Matrix4D\) Operator

Subtracts one [Matrix4D](DiGi.Math.Classes.md#DiGi.Math.Classes.Matrix4D 'DiGi\.Math\.Classes\.Matrix4D') from another\.

```csharp
public static DiGi.Math.Classes.Matrix4D? operator -(DiGi.Math.Classes.Matrix4D? matrix4D_1, DiGi.Math.Classes.Matrix4D? matrix4D_2);
```
#### Parameters

<a name='DiGi.Math.Classes.Matrix4D.op_Subtraction(DiGi.Math.Classes.Matrix4D,DiGi.Math.Classes.Matrix4D).matrix4D_1'></a>

`matrix4D_1` [Matrix4D](DiGi.Math.Classes.md#DiGi.Math.Classes.Matrix4D 'DiGi\.Math\.Classes\.Matrix4D')

The first matrix\.

<a name='DiGi.Math.Classes.Matrix4D.op_Subtraction(DiGi.Math.Classes.Matrix4D,DiGi.Math.Classes.Matrix4D).matrix4D_2'></a>

`matrix4D_2` [Matrix4D](DiGi.Math.Classes.md#DiGi.Math.Classes.Matrix4D 'DiGi\.Math\.Classes\.Matrix4D')

The second matrix to subtract from the first\.

#### Returns
[Matrix4D](DiGi.Math.Classes.md#DiGi.Math.Classes.Matrix4D 'DiGi\.Math\.Classes\.Matrix4D')  
The result of the subtraction as a [Matrix4D](DiGi.Math.Classes.md#DiGi.Math.Classes.Matrix4D 'DiGi\.Math\.Classes\.Matrix4D'), or null if either operand is null\.

<a name='DiGi.Math.Classes.Matrix4D.op_Subtraction(DiGi.Math.Classes.Matrix4D,double)'></a>

## Matrix4D\.operator \-\(Matrix4D, double\) Operator

Subtracts a scalar value from each element of the [Matrix4D](DiGi.Math.Classes.md#DiGi.Math.Classes.Matrix4D 'DiGi\.Math\.Classes\.Matrix4D')\.

```csharp
public static DiGi.Math.Classes.Matrix4D? operator -(DiGi.Math.Classes.Matrix4D? matrix4D, double value);
```
#### Parameters

<a name='DiGi.Math.Classes.Matrix4D.op_Subtraction(DiGi.Math.Classes.Matrix4D,double).matrix4D'></a>

`matrix4D` [Matrix4D](DiGi.Math.Classes.md#DiGi.Math.Classes.Matrix4D 'DiGi\.Math\.Classes\.Matrix4D')

The matrix to subtract from\.

<a name='DiGi.Math.Classes.Matrix4D.op_Subtraction(DiGi.Math.Classes.Matrix4D,double).value'></a>

`value` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The scalar value to subtract\.

#### Returns
[Matrix4D](DiGi.Math.Classes.md#DiGi.Math.Classes.Matrix4D 'DiGi\.Math\.Classes\.Matrix4D')  
A new [Matrix4D](DiGi.Math.Classes.md#DiGi.Math.Classes.Matrix4D 'DiGi\.Math\.Classes\.Matrix4D') containing the result, or null if the matrix is null\.

<a name='DiGi.Math.Classes.PolynomialEquation'></a>

## PolynomialEquation Class

Represents a polynomial equation of the form a\(n\)\*x^\(n\) \+ a\(n\-1\)\*x^\(n\-1\) \+ a\(n\-2\)\*x^\(n\-2\) \+ \[\.\.\.\] \+ a\(1\)\*x \+ a\(0\) = 0\.

```csharp
public class PolynomialEquation : DiGi.Core.Classes.SerializableObject, DiGi.Math.Interfaces.IEquation, DiGi.Core.Interfaces.ISerializableObject, DiGi.Core.Interfaces.ICloneableObject<DiGi.Core.Interfaces.ISerializableObject>, DiGi.Core.Interfaces.ICloneableObject, DiGi.Core.Interfaces.IObject
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → [DiGi\.Core\.Classes\.Object](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.object 'DiGi\.Core\.Classes\.Object') → [DiGi\.Core\.Classes\.SerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.serializableobject 'DiGi\.Core\.Classes\.SerializableObject') → PolynomialEquation

Implements [IEquation](DiGi.Math.Interfaces.md#DiGi.Math.Interfaces.IEquation 'DiGi\.Math\.Interfaces\.IEquation'), [DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject'), [DiGi\.Core\.Interfaces\.ICloneableObject&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1')[DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1'), [DiGi\.Core\.Interfaces\.ICloneableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject 'DiGi\.Core\.Interfaces\.ICloneableObject'), [DiGi\.Core\.Interfaces\.IObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iobject 'DiGi\.Core\.Interfaces\.IObject')
### Constructors

<a name='DiGi.Math.Classes.PolynomialEquation.PolynomialEquation(DiGi.Math.Classes.PolynomialEquation)'></a>

## PolynomialEquation\(PolynomialEquation\) Constructor

Initializes a new instance of the PolynomialEquation class using another PolynomialEquation object\.

```csharp
public PolynomialEquation(DiGi.Math.Classes.PolynomialEquation? polynomialEquation);
```
#### Parameters

<a name='DiGi.Math.Classes.PolynomialEquation.PolynomialEquation(DiGi.Math.Classes.PolynomialEquation).polynomialEquation'></a>

`polynomialEquation` [PolynomialEquation](DiGi.Math.Classes.md#DiGi.Math.Classes.PolynomialEquation 'DiGi\.Math\.Classes\.PolynomialEquation')

The PolynomialEquation to copy from\.

<a name='DiGi.Math.Classes.PolynomialEquation.PolynomialEquation(System.Collections.Generic.IEnumerable_double_)'></a>

## PolynomialEquation\(IEnumerable\<double\>\) Constructor

Initializes a new instance of the PolynomialEquation class using coefficients\.

```csharp
public PolynomialEquation(System.Collections.Generic.IEnumerable<double>? coefficients);
```
#### Parameters

<a name='DiGi.Math.Classes.PolynomialEquation.PolynomialEquation(System.Collections.Generic.IEnumerable_double_).coefficients'></a>

`coefficients` [System\.Collections\.Generic\.IEnumerable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')[System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')

The coefficients of the polynomial equation\.

<a name='DiGi.Math.Classes.PolynomialEquation.PolynomialEquation(System.Text.Json.Nodes.JsonObject)'></a>

## PolynomialEquation\(JsonObject\) Constructor

Initializes a new instance of the [PolynomialEquation](DiGi.Math.Classes.md#DiGi.Math.Classes.PolynomialEquation 'DiGi\.Math\.Classes\.PolynomialEquation') class using a [System\.Text\.Json\.Nodes\.JsonObject](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonobject 'System\.Text\.Json\.Nodes\.JsonObject')\.

```csharp
public PolynomialEquation(System.Text.Json.Nodes.JsonObject? jsonObject);
```
#### Parameters

<a name='DiGi.Math.Classes.PolynomialEquation.PolynomialEquation(System.Text.Json.Nodes.JsonObject).jsonObject'></a>

`jsonObject` [System\.Text\.Json\.Nodes\.JsonObject](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonobject 'System\.Text\.Json\.Nodes\.JsonObject')

The JSON object containing the polynomial equation data\.
### Properties

<a name='DiGi.Math.Classes.PolynomialEquation.Coefficients'></a>

## PolynomialEquation\.Coefficients Property

Gets the coefficients of the polynomial equation\.

```csharp
public System.Collections.Generic.List<double>? Coefficients { get; }
```

#### Property Value
[System\.Collections\.Generic\.List&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')[System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')

<a name='DiGi.Math.Classes.PolynomialEquation.Degree'></a>

## PolynomialEquation\.Degree Property

Gets the degree of the polynomial equation\.

```csharp
public int Degree { get; }
```

#### Property Value
[System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')
### Methods

<a name='DiGi.Math.Classes.PolynomialEquation.Evaluate(double)'></a>

## PolynomialEquation\.Evaluate\(double\) Method

Evaluates the polynomial equation for a given x value\.

```csharp
public double Evaluate(double value);
```
#### Parameters

<a name='DiGi.Math.Classes.PolynomialEquation.Evaluate(double).value'></a>

`value` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The x value to evaluate the polynomial equation for\.

Implements [Evaluate\(double\)](DiGi.Math.Interfaces.md#DiGi.Math.Interfaces.IEquation.Evaluate(double) 'DiGi\.Math\.Interfaces\.IEquation\.Evaluate\(double\)')

#### Returns
[System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')  
The result of the polynomial equation\.

<a name='DiGi.Math.Classes.PolynomialEquation.Evaluate(System.Collections.Generic.IEnumerable_double_)'></a>

## PolynomialEquation\.Evaluate\(IEnumerable\<double\>\) Method

Evaluates the polynomial equation for a given set of x values\.

```csharp
public System.Collections.Generic.List<double>? Evaluate(System.Collections.Generic.IEnumerable<double>? values);
```
#### Parameters

<a name='DiGi.Math.Classes.PolynomialEquation.Evaluate(System.Collections.Generic.IEnumerable_double_).values'></a>

`values` [System\.Collections\.Generic\.IEnumerable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')[System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')

The x values to evaluate the polynomial equation for\.

Implements [Evaluate\(IEnumerable&lt;double&gt;\)](DiGi.Math.Interfaces.md#DiGi.Math.Interfaces.IEquation.Evaluate(System.Collections.Generic.IEnumerable_double_) 'DiGi\.Math\.Interfaces\.IEquation\.Evaluate\(System\.Collections\.Generic\.IEnumerable\<double\>\)')

#### Returns
[System\.Collections\.Generic\.List&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')[System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')  
The results of the polynomial equation\.
### Operators

<a name='DiGi.Math.Classes.PolynomialEquation.op_ExplicitDiGi.Math.Classes.PolynomialEquation(DiGi.Math.Classes.LinearEquation)'></a>

## PolynomialEquation\.explicit operator PolynomialEquation\(LinearEquation\) Operator

Explicitly converts a [LinearEquation](DiGi.Math.Classes.md#DiGi.Math.Classes.LinearEquation 'DiGi\.Math\.Classes\.LinearEquation') to a [PolynomialEquation](DiGi.Math.Classes.md#DiGi.Math.Classes.PolynomialEquation 'DiGi\.Math\.Classes\.PolynomialEquation')\.

```csharp
public static DiGi.Math.Classes.PolynomialEquation? explicit operator DiGi.Math.Classes.PolynomialEquation?(DiGi.Math.Classes.LinearEquation? linearEquation);
```
#### Parameters

<a name='DiGi.Math.Classes.PolynomialEquation.op_ExplicitDiGi.Math.Classes.PolynomialEquation(DiGi.Math.Classes.LinearEquation).linearEquation'></a>

`linearEquation` [LinearEquation](DiGi.Math.Classes.md#DiGi.Math.Classes.LinearEquation 'DiGi\.Math\.Classes\.LinearEquation')

The linear equation to convert\.

#### Returns
[PolynomialEquation](DiGi.Math.Classes.md#DiGi.Math.Classes.PolynomialEquation 'DiGi\.Math\.Classes\.PolynomialEquation')  
A [PolynomialEquation](DiGi.Math.Classes.md#DiGi.Math.Classes.PolynomialEquation 'DiGi\.Math\.Classes\.PolynomialEquation') instance created from the provided linear equation, or null if the input is null\.