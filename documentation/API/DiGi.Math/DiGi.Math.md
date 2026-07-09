#### [DiGi\.Math](DiGi.Math.Overview.md 'DiGi\.Math\.Overview')

## DiGi\.Math Namespace
### Classes

<a name='DiGi.Math.Convert'></a>

## Convert Class

```csharp
public static class Convert
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → Convert
### Methods

<a name='DiGi.Math.Convert.ToDiGi(thisMatrix_double_)'></a>

## Convert\.ToDiGi\(this Matrix\<double\>\) Method

Converts a MathNet\.Numerics\.LinearAlgebra\.Matrix to a Matrix object\.

```csharp
public static DiGi.Math.Classes.Matrix? ToDiGi(this Matrix<double>? matrix);
```
#### Parameters

<a name='DiGi.Math.Convert.ToDiGi(thisMatrix_double_).matrix'></a>

`matrix` [MathNet\.Numerics\.LinearAlgebra\.Matrix](https://learn.microsoft.com/en-us/dotnet/api/mathnet.numerics.linearalgebra.matrix 'MathNet\.Numerics\.LinearAlgebra\.Matrix')

The MathNet matrix to convert\.

#### Returns
[Matrix](DiGi.Math.Classes.md#DiGi.Math.Classes.Matrix 'DiGi\.Math\.Classes\.Matrix')  
A Matrix object, or null if the input is null\.

<a name='DiGi.Math.Convert.ToDiGi(thisPolynomial)'></a>

## Convert\.ToDiGi\(this Polynomial\) Method

Converts a MathNet\.Numerics\.Polynomial to a PolynomialEquation object\.

```csharp
public static DiGi.Math.Classes.PolynomialEquation? ToDiGi(this Polynomial? polynomial);
```
#### Parameters

<a name='DiGi.Math.Convert.ToDiGi(thisPolynomial).polynomial'></a>

`polynomial` [MathNet\.Numerics\.Polynomial](https://learn.microsoft.com/en-us/dotnet/api/mathnet.numerics.polynomial 'MathNet\.Numerics\.Polynomial')

The MathNet polynomial to convert\.

#### Returns
[PolynomialEquation](DiGi.Math.Classes.md#DiGi.Math.Classes.PolynomialEquation 'DiGi\.Math\.Classes\.PolynomialEquation')  
A PolynomialEquation object, or null if the input is null\.

<a name='DiGi.Math.Convert.ToDiGi_SquareMatrix(thisDiGi.Math.Classes.Matrix)'></a>

## Convert\.ToDiGi\_SquareMatrix\(this Matrix\) Method

Converts a Matrix to an ISquareMatrix if it is square and its size is 2, 3, or 4\.

```csharp
public static DiGi.Math.Interfaces.ISquareMatrix? ToDiGi_SquareMatrix(this DiGi.Math.Classes.Matrix? matrix);
```
#### Parameters

<a name='DiGi.Math.Convert.ToDiGi_SquareMatrix(thisDiGi.Math.Classes.Matrix).matrix'></a>

`matrix` [Matrix](DiGi.Math.Classes.md#DiGi.Math.Classes.Matrix 'DiGi\.Math\.Classes\.Matrix')

The matrix to convert\.

#### Returns
[ISquareMatrix](DiGi.Math.Interfaces.md#DiGi.Math.Interfaces.ISquareMatrix 'DiGi\.Math\.Interfaces\.ISquareMatrix')  
An ISquareMatrix object, or null if the matrix is not square or has an unsupported size\.

<a name='DiGi.Math.Convert.ToMathNet(thisDiGi.Math.Classes.Matrix)'></a>

## Convert\.ToMathNet\(this Matrix\) Method

Converts a Matrix to a MathNet\.Numerics\.LinearAlgebra\.Matrix object\.

```csharp
public static Matrix<double>? ToMathNet(this DiGi.Math.Classes.Matrix? matrix);
```
#### Parameters

<a name='DiGi.Math.Convert.ToMathNet(thisDiGi.Math.Classes.Matrix).matrix'></a>

`matrix` [Matrix](DiGi.Math.Classes.md#DiGi.Math.Classes.Matrix 'DiGi\.Math\.Classes\.Matrix')

The matrix to convert\.

#### Returns
[MathNet\.Numerics\.LinearAlgebra\.Matrix](https://learn.microsoft.com/en-us/dotnet/api/mathnet.numerics.linearalgebra.matrix 'MathNet\.Numerics\.LinearAlgebra\.Matrix')  
A MathNet\.Numerics\.LinearAlgebra\.Matrix object, or null if the input is null\.

<a name='DiGi.Math.Convert.ToMathNet(thisDiGi.Math.Classes.PolynomialEquation)'></a>

## Convert\.ToMathNet\(this PolynomialEquation\) Method

Converts a PolynomialEquation to a MathNet\.Numerics\.Polynomial object\.

```csharp
public static Polynomial? ToMathNet(this DiGi.Math.Classes.PolynomialEquation? polynomialEquation);
```
#### Parameters

<a name='DiGi.Math.Convert.ToMathNet(thisDiGi.Math.Classes.PolynomialEquation).polynomialEquation'></a>

`polynomialEquation` [PolynomialEquation](DiGi.Math.Classes.md#DiGi.Math.Classes.PolynomialEquation 'DiGi\.Math\.Classes\.PolynomialEquation')

The polynomial equation to convert\.

#### Returns
[MathNet\.Numerics\.Polynomial](https://learn.microsoft.com/en-us/dotnet/api/mathnet.numerics.polynomial 'MathNet\.Numerics\.Polynomial')  
A MathNet\.Numerics\.Polynomial object, or null if the input is null\.

<a name='DiGi.Math.Create'></a>

## Create Class

```csharp
public static class Create
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → Create
### Methods

<a name='DiGi.Math.Create.BilinearInterpolation(string,string)'></a>

## Create\.BilinearInterpolation\(string, string\) Method

Creates a BilinearInterpolation object from a file\.

```csharp
public static DiGi.Math.Classes.BilinearInterpolation? BilinearInterpolation(string? path, string separator="\t");
```
#### Parameters

<a name='DiGi.Math.Create.BilinearInterpolation(string,string).path'></a>

`path` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The path to the data file\.

<a name='DiGi.Math.Create.BilinearInterpolation(string,string).separator'></a>

`separator` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The separator used in the data file\.

#### Returns
[BilinearInterpolation](DiGi.Math.Classes.md#DiGi.Math.Classes.BilinearInterpolation 'DiGi\.Math\.Classes\.BilinearInterpolation')  
A BilinearInterpolation object, or null if the file cannot be read\.

<a name='DiGi.Math.Create.LinearEquation(double,double,double,double)'></a>

## Create\.LinearEquation\(double, double, double, double\) Method

Creates a LinearEquation that passes through two points \(x1, y1\) and \(x2, y2\)\.

```csharp
public static DiGi.Math.Classes.LinearEquation? LinearEquation(double x_1, double y_1, double x_2, double y_2);
```
#### Parameters

<a name='DiGi.Math.Create.LinearEquation(double,double,double,double).x_1'></a>

`x_1` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The x\-coordinate of the first point\.

<a name='DiGi.Math.Create.LinearEquation(double,double,double,double).y_1'></a>

`y_1` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The y\-coordinate of the first point\.

<a name='DiGi.Math.Create.LinearEquation(double,double,double,double).x_2'></a>

`x_2` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The x\-coordinate of the second point\.

<a name='DiGi.Math.Create.LinearEquation(double,double,double,double).y_2'></a>

`y_2` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The y\-coordinate of the second point\.

#### Returns
[LinearEquation](DiGi.Math.Classes.md#DiGi.Math.Classes.LinearEquation 'DiGi\.Math\.Classes\.LinearEquation')  
A LinearEquation, or null if points are invalid or vertical\.

<a name='DiGi.Math.Create.LinearInterpolation(string,string)'></a>

## Create\.LinearInterpolation\(string, string\) Method

Creates a LinearInterpolation object from a file\.

```csharp
public static DiGi.Math.Classes.LinearInterpolation? LinearInterpolation(string? path, string separator="\t");
```
#### Parameters

<a name='DiGi.Math.Create.LinearInterpolation(string,string).path'></a>

`path` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The path to the data file\.

<a name='DiGi.Math.Create.LinearInterpolation(string,string).separator'></a>

`separator` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The separator used in the data file\.

#### Returns
[LinearInterpolation](DiGi.Math.Classes.md#DiGi.Math.Classes.LinearInterpolation 'DiGi\.Math\.Classes\.LinearInterpolation')  
A LinearInterpolation object, or null if the file cannot be read\.

<a name='DiGi.Math.Create.PolynomialEquation(System.Collections.Generic.IEnumerable_double_,System.Collections.Generic.IEnumerable_double_,int)'></a>

## Create\.PolynomialEquation\(IEnumerable\<double\>, IEnumerable\<double\>, int\) Method

Creates a polynomial equation that fits the given data points\.

```csharp
public static DiGi.Math.Classes.PolynomialEquation? PolynomialEquation(System.Collections.Generic.IEnumerable<double>? x, System.Collections.Generic.IEnumerable<double>? y, int order=-1);
```
#### Parameters

<a name='DiGi.Math.Create.PolynomialEquation(System.Collections.Generic.IEnumerable_double_,System.Collections.Generic.IEnumerable_double_,int).x'></a>

`x` [System\.Collections\.Generic\.IEnumerable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')[System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')

The x coordinates of the data points\.

<a name='DiGi.Math.Create.PolynomialEquation(System.Collections.Generic.IEnumerable_double_,System.Collections.Generic.IEnumerable_double_,int).y'></a>

`y` [System\.Collections\.Generic\.IEnumerable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')[System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')

The y coordinates of the data points\.

<a name='DiGi.Math.Create.PolynomialEquation(System.Collections.Generic.IEnumerable_double_,System.Collections.Generic.IEnumerable_double_,int).order'></a>

`order` [System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')

The order of the polynomial\. If \-1, it uses count \- 1\.

#### Returns
[PolynomialEquation](DiGi.Math.Classes.md#DiGi.Math.Classes.PolynomialEquation 'DiGi\.Math\.Classes\.PolynomialEquation')  
A PolynomialEquation that fits the data, or null if fitting fails\.

<a name='DiGi.Math.Create.Matrix'></a>

## Create\.Matrix Class

```csharp
public static class Create.Matrix
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → Matrix
### Methods

<a name='DiGi.Math.Create.Matrix.Identity(int)'></a>

## Create\.Matrix\.Identity\(int\) Method

Creates an identity matrix of the specified size\.

```csharp
public static DiGi.Math.Classes.Matrix Identity(int count=3);
```
#### Parameters

<a name='DiGi.Math.Create.Matrix.Identity(int).count'></a>

`count` [System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')

The number of rows and columns for the square identity matrix\.

#### Returns
[Matrix](DiGi.Math.Classes.md#DiGi.Math.Classes.Matrix 'DiGi\.Math\.Classes\.Matrix')  
An identity matrix of size count x count\.

<a name='DiGi.Math.Create.Matrix.Scale(int,double)'></a>

## Create\.Matrix\.Scale\(int, double\) Method

Creates a diagonal scale matrix with the specified factor\.

```csharp
public static DiGi.Math.Classes.Matrix Scale(int count, double factor);
```
#### Parameters

<a name='DiGi.Math.Create.Matrix.Scale(int,double).count'></a>

`count` [System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')

The number of diagonal elements to set\.

<a name='DiGi.Math.Create.Matrix.Scale(int,double).factor'></a>

`factor` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The scaling factor for each diagonal element\.

#### Returns
[Matrix](DiGi.Math.Classes.md#DiGi.Math.Classes.Matrix 'DiGi\.Math\.Classes\.Matrix')  
A scale matrix with dimensions \(count\+1\) x \(count\+1\)\.

<a name='DiGi.Math.Create.Matrix.Scale(System.Collections.Generic.IEnumerable_double_)'></a>

## Create\.Matrix\.Scale\(IEnumerable\<double\>\) Method

Creates a diagonal scale matrix from the given values\.

```csharp
public static DiGi.Math.Classes.Matrix? Scale(System.Collections.Generic.IEnumerable<double>? values);
```
#### Parameters

<a name='DiGi.Math.Create.Matrix.Scale(System.Collections.Generic.IEnumerable_double_).values'></a>

`values` [System\.Collections\.Generic\.IEnumerable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')[System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')

The diagonal values of the scale matrix\.

#### Returns
[Matrix](DiGi.Math.Classes.md#DiGi.Math.Classes.Matrix 'DiGi\.Math\.Classes\.Matrix')  
A scale matrix with dimensions \(count\+1\) x \(count\+1\), or null if values are null\.

<a name='DiGi.Math.Create.Matrix.Unset(int,int)'></a>

## Create\.Matrix\.Unset\(int, int\) Method

Creates a matrix of the specified size and initializes all values to double\.MinValue\.

```csharp
public static DiGi.Math.Classes.Matrix Unset(int rowCount, int columnCount);
```
#### Parameters

<a name='DiGi.Math.Create.Matrix.Unset(int,int).rowCount'></a>

`rowCount` [System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')

The number of rows in the matrix\.

<a name='DiGi.Math.Create.Matrix.Unset(int,int).columnCount'></a>

`columnCount` [System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')

The number of columns in the matrix\.

#### Returns
[Matrix](DiGi.Math.Classes.md#DiGi.Math.Classes.Matrix 'DiGi\.Math\.Classes\.Matrix')  
A matrix filled with double\.MinValue\.

<a name='DiGi.Math.Create.Matrix2D'></a>

## Create\.Matrix2D Class

```csharp
public static class Create.Matrix2D
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → Matrix2D
### Methods

<a name='DiGi.Math.Create.Matrix2D.ByMatrix(DiGi.Math.Classes.Matrix)'></a>

## Create\.Matrix2D\.ByMatrix\(Matrix\) Method

Creates a Matrix2D from an existing Matrix object\.

```csharp
public static DiGi.Math.Classes.Matrix2D? ByMatrix(DiGi.Math.Classes.Matrix? matrix);
```
#### Parameters

<a name='DiGi.Math.Create.Matrix2D.ByMatrix(DiGi.Math.Classes.Matrix).matrix'></a>

`matrix` [Matrix](DiGi.Math.Classes.md#DiGi.Math.Classes.Matrix 'DiGi\.Math\.Classes\.Matrix')

The matrix to convert from\.

#### Returns
[Matrix2D](DiGi.Math.Classes.md#DiGi.Math.Classes.Matrix2D 'DiGi\.Math\.Classes\.Matrix2D')  
A Matrix2D object, or null if the provided matrix is not 2x2\.

<a name='DiGi.Math.Create.Matrix2D.ByValues(double[,])'></a>

## Create\.Matrix2D\.ByValues\(double\[,\]\) Method

Creates a Matrix2D from a 2D array of values\.

```csharp
public static DiGi.Math.Classes.Matrix2D? ByValues(double[,]? values);
```
#### Parameters

<a name='DiGi.Math.Create.Matrix2D.ByValues(double[,]).values'></a>

`values` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')[\[\]](https://learn.microsoft.com/en-us/dotnet/api/system.array 'System\.Array')

The values to use for the matrix\.

#### Returns
[Matrix2D](DiGi.Math.Classes.md#DiGi.Math.Classes.Matrix2D 'DiGi\.Math\.Classes\.Matrix2D')  
A Matrix2D object, or null if the provided values are not 2x2\.

<a name='DiGi.Math.Create.Matrix2D.Identity()'></a>

## Create\.Matrix2D\.Identity\(\) Method

Creates a 2x2 identity matrix\.

```csharp
public static DiGi.Math.Classes.Matrix2D Identity();
```

#### Returns
[Matrix2D](DiGi.Math.Classes.md#DiGi.Math.Classes.Matrix2D 'DiGi\.Math\.Classes\.Matrix2D')  
A Matrix2D representing the identity matrix\.

<a name='DiGi.Math.Create.Matrix3D'></a>

## Create\.Matrix3D Class

```csharp
public static class Create.Matrix3D
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → Matrix3D
### Methods

<a name='DiGi.Math.Create.Matrix3D.ByMatrix(DiGi.Math.Classes.Matrix)'></a>

## Create\.Matrix3D\.ByMatrix\(Matrix\) Method

Creates a Matrix3D from an existing Matrix object\.

```csharp
public static DiGi.Math.Classes.Matrix3D? ByMatrix(DiGi.Math.Classes.Matrix? matrix);
```
#### Parameters

<a name='DiGi.Math.Create.Matrix3D.ByMatrix(DiGi.Math.Classes.Matrix).matrix'></a>

`matrix` [Matrix](DiGi.Math.Classes.md#DiGi.Math.Classes.Matrix 'DiGi\.Math\.Classes\.Matrix')

The matrix to convert from\.

#### Returns
[Matrix3D](DiGi.Math.Classes.md#DiGi.Math.Classes.Matrix3D 'DiGi\.Math\.Classes\.Matrix3D')  
A Matrix3D object, or null if the provided matrix is not 3x3\.

<a name='DiGi.Math.Create.Matrix3D.ByValues(double[,])'></a>

## Create\.Matrix3D\.ByValues\(double\[,\]\) Method

Creates a Matrix3D from a 2D array of values\.

```csharp
public static DiGi.Math.Classes.Matrix3D? ByValues(double[,]? values);
```
#### Parameters

<a name='DiGi.Math.Create.Matrix3D.ByValues(double[,]).values'></a>

`values` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')[\[\]](https://learn.microsoft.com/en-us/dotnet/api/system.array 'System\.Array')

The values to use for the matrix\.

#### Returns
[Matrix3D](DiGi.Math.Classes.md#DiGi.Math.Classes.Matrix3D 'DiGi\.Math\.Classes\.Matrix3D')  
A Matrix3D object, or null if the provided values are not 3x3\.

<a name='DiGi.Math.Create.Matrix3D.Identity()'></a>

## Create\.Matrix3D\.Identity\(\) Method

Creates a 3x3 identity matrix\.

```csharp
public static DiGi.Math.Classes.Matrix3D Identity();
```

#### Returns
[Matrix3D](DiGi.Math.Classes.md#DiGi.Math.Classes.Matrix3D 'DiGi\.Math\.Classes\.Matrix3D')  
A Matrix3D representing the identity matrix\.

<a name='DiGi.Math.Create.Matrix4D'></a>

## Create\.Matrix4D Class

```csharp
public static class Create.Matrix4D
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → Matrix4D
### Methods

<a name='DiGi.Math.Create.Matrix4D.ByMatrix(DiGi.Math.Classes.Matrix)'></a>

## Create\.Matrix4D\.ByMatrix\(Matrix\) Method

Creates a Matrix4D from an existing Matrix object\.

```csharp
public static DiGi.Math.Classes.Matrix4D? ByMatrix(DiGi.Math.Classes.Matrix? matrix);
```
#### Parameters

<a name='DiGi.Math.Create.Matrix4D.ByMatrix(DiGi.Math.Classes.Matrix).matrix'></a>

`matrix` [Matrix](DiGi.Math.Classes.md#DiGi.Math.Classes.Matrix 'DiGi\.Math\.Classes\.Matrix')

The matrix to convert from\.

#### Returns
[Matrix4D](DiGi.Math.Classes.md#DiGi.Math.Classes.Matrix4D 'DiGi\.Math\.Classes\.Matrix4D')  
A Matrix4D object, or null if the provided matrix is not 4x4\.

<a name='DiGi.Math.Create.Matrix4D.ByValues(double[,])'></a>

## Create\.Matrix4D\.ByValues\(double\[,\]\) Method

Creates a Matrix4D from a 2D array of values\.

```csharp
public static DiGi.Math.Classes.Matrix4D? ByValues(double[,]? values);
```
#### Parameters

<a name='DiGi.Math.Create.Matrix4D.ByValues(double[,]).values'></a>

`values` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')[\[\]](https://learn.microsoft.com/en-us/dotnet/api/system.array 'System\.Array')

The values to use for the matrix\.

#### Returns
[Matrix4D](DiGi.Math.Classes.md#DiGi.Math.Classes.Matrix4D 'DiGi\.Math\.Classes\.Matrix4D')  
A Matrix4D object, or null if the provided values are not 4x4\.

<a name='DiGi.Math.Create.Matrix4D.Identity()'></a>

## Create\.Matrix4D\.Identity\(\) Method

Creates a 4x4 identity matrix\.

```csharp
public static DiGi.Math.Classes.Matrix4D Identity();
```

#### Returns
[Matrix4D](DiGi.Math.Classes.md#DiGi.Math.Classes.Matrix4D 'DiGi\.Math\.Classes\.Matrix4D')  
A Matrix4D representing the identity matrix\.

<a name='DiGi.Math.Create.Matrix4D.Unset()'></a>

## Create\.Matrix4D\.Unset\(\) Method

Creates an unset \(zero\) 4x4 matrix\.

```csharp
public static DiGi.Math.Classes.Matrix4D Unset();
```

#### Returns
[Matrix4D](DiGi.Math.Classes.md#DiGi.Math.Classes.Matrix4D 'DiGi\.Math\.Classes\.Matrix4D')  
A Matrix4D representing an unset matrix\.

<a name='DiGi.Math.Query'></a>

## Query Class

```csharp
public static class Query
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → Query
### Methods

<a name='DiGi.Math.Query.Arccos(double)'></a>

## Query\.Arccos\(double\) Method

Calculates the inverse cosine \(arccosine\) of a specified value\.

```csharp
public static double Arccos(double angle);
```
#### Parameters

<a name='DiGi.Math.Query.Arccos(double).angle'></a>

`angle` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The value whose inverse cosine is to be computed\. This value should be between \-1 and 1\.

#### Returns
[System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')  
The arccosine of the specified value, expressed in radians\.

<a name='DiGi.Math.Query.Arccosec(double)'></a>

## Query\.Arccosec\(double\) Method

Calculates the inverse cosecant \(arccosecant\) of a specified value\.

```csharp
public static double Arccosec(double angle);
```
#### Parameters

<a name='DiGi.Math.Query.Arccosec(double).angle'></a>

`angle` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The value for which to calculate the inverse cosecant\.

#### Returns
[System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')  
The inverse cosecant of the specified value, expressed in radians\.

<a name='DiGi.Math.Query.Arccotan(double)'></a>

## Query\.Arccotan\(double\) Method

Calculates the inverse cotangent \(arccotangent\) of a specified value\.

```csharp
public static double Arccotan(double angle);
```
#### Parameters

<a name='DiGi.Math.Query.Arccotan(double).angle'></a>

`angle` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The numeric value for which to calculate the inverse cotangent\.

#### Returns
[System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')  
The inverse cotangent of the specified value, expressed in radians\.

<a name='DiGi.Math.Query.Arcosh(double)'></a>

## Query\.Arcosh\(double\) Method

Calculates the inverse hyperbolic cosine \(arccosh\) of a specified number\.

```csharp
public static double Arcosh(double x);
```
#### Parameters

<a name='DiGi.Math.Query.Arcosh(double).x'></a>

`x` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The number for which to calculate the inverse hyperbolic cosine\.

#### Returns
[System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')  
The inverse hyperbolic cosine of [x](DiGi.Math.md#DiGi.Math.Query.Arcosh(double).x 'DiGi\.Math\.Query\.Arcosh\(double\)\.x')\.

<a name='DiGi.Math.Query.Arcoth(double)'></a>

## Query\.Arcoth\(double\) Method

Calculates the inverse hyperbolic cotangent of a specified number\.

```csharp
public static double Arcoth(double x);
```
#### Parameters

<a name='DiGi.Math.Query.Arcoth(double).x'></a>

`x` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The number for which to calculate the inverse hyperbolic cotangent\.

#### Returns
[System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')  
The inverse hyperbolic cotangent of [x](DiGi.Math.md#DiGi.Math.Query.Arcoth(double).x 'DiGi\.Math\.Query\.Arcoth\(double\)\.x')\.

<a name='DiGi.Math.Query.Arcsch(double)'></a>

## Query\.Arcsch\(double\) Method

Calculates the inverse hyperbolic cosecant \(csch⁻¹\) of a specified number\.

```csharp
public static double Arcsch(double x);
```
#### Parameters

<a name='DiGi.Math.Query.Arcsch(double).x'></a>

`x` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The double\-precision floating\-point number for which to calculate the inverse hyperbolic cosecant\.

#### Returns
[System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')  
The inverse hyperbolic cosecant of [x](DiGi.Math.md#DiGi.Math.Query.Arcsch(double).x 'DiGi\.Math\.Query\.Arcsch\(double\)\.x')\.

<a name='DiGi.Math.Query.Arcsec(double)'></a>

## Query\.Arcsec\(double\) Method

Calculates the inverse secant \(arcsecant\) of a specified number\.

```csharp
public static double Arcsec(double x);
```
#### Parameters

<a name='DiGi.Math.Query.Arcsec(double).x'></a>

`x` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The number for which to calculate the inverse secant\.

#### Returns
[System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')  
The inverse secant of [x](DiGi.Math.md#DiGi.Math.Query.Arcsec(double).x 'DiGi\.Math\.Query\.Arcsec\(double\)\.x') expressed in radians\.

<a name='DiGi.Math.Query.Arcsin(double)'></a>

## Query\.Arcsin\(double\) Method

Calculates the inverse sine \(arcsine\) of a specified value\.

```csharp
public static double Arcsin(double angle);
```
#### Parameters

<a name='DiGi.Math.Query.Arcsin(double).angle'></a>

`angle` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The value for which to calculate the inverse sine\. This value must be between \-1 and 1 inclusive\.

#### Returns
[System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')  
The angle in radians whose sine is the specified value\.

<a name='DiGi.Math.Query.Arsech(double)'></a>

## Query\.Arsech\(double\) Method

Calculates the inverse hyperbolic secant \(arsech\) of a specified value\.

```csharp
public static double Arsech(double x);
```
#### Parameters

<a name='DiGi.Math.Query.Arsech(double).x'></a>

`x` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The double\-precision floating\-point number for which to calculate the inverse hyperbolic secant\.

#### Returns
[System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')  
The inverse hyperbolic secant of [x](DiGi.Math.md#DiGi.Math.Query.Arsech(double).x 'DiGi\.Math\.Query\.Arsech\(double\)\.x')\.

<a name='DiGi.Math.Query.Arsinh(double)'></a>

## Query\.Arsinh\(double\) Method

Calculates the inverse hyperbolic sine \(asinh\) of a specified number\.

```csharp
public static double Arsinh(double x);
```
#### Parameters

<a name='DiGi.Math.Query.Arsinh(double).x'></a>

`x` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The numeric value for which to compute the inverse hyperbolic sine\.

#### Returns
[System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')  
The inverse hyperbolic sine of [x](DiGi.Math.md#DiGi.Math.Query.Arsinh(double).x 'DiGi\.Math\.Query\.Arsinh\(double\)\.x')\.

<a name='DiGi.Math.Query.Artanh(double)'></a>

## Query\.Artanh\(double\) Method

Calculates the inverse hyperbolic tangent of a specified number\.

```csharp
public static double Artanh(double x);
```
#### Parameters

<a name='DiGi.Math.Query.Artanh(double).x'></a>

`x` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The number for which to calculate the inverse hyperbolic tangent\.

#### Returns
[System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')  
The inverse hyperbolic tangent of [x](DiGi.Math.md#DiGi.Math.Query.Artanh(double).x 'DiGi\.Math\.Query\.Artanh\(double\)\.x')\.

<a name='DiGi.Math.Query.Cosec(double)'></a>

## Query\.Cosec\(double\) Method

Calculates the cosecant of a specified angle\.

```csharp
public static double Cosec(double angle);
```
#### Parameters

<a name='DiGi.Math.Query.Cosec(double).angle'></a>

`angle` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The angle in radians\.

#### Returns
[System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')  
The cosecant of the specified angle\.

<a name='DiGi.Math.Query.Cosech(double)'></a>

## Query\.Cosech\(double\) Method

Calculates the hyperbolic cosecant of the specified angle\.

```csharp
public static double Cosech(double angle);
```
#### Parameters

<a name='DiGi.Math.Query.Cosech(double).angle'></a>

`angle` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The angle in radians\.

#### Returns
[System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')  
The hyperbolic cosecant of the angle\.

<a name='DiGi.Math.Query.Cosh(double)'></a>

## Query\.Cosh\(double\) Method

Calculates the hyperbolic cosine of a specified angle\.

```csharp
public static double Cosh(double angle);
```
#### Parameters

<a name='DiGi.Math.Query.Cosh(double).angle'></a>

`angle` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The angle in radians\.

#### Returns
[System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')  
The hyperbolic cosine of the specified angle\.

<a name='DiGi.Math.Query.Cotan(double)'></a>

## Query\.Cotan\(double\) Method

Calculates the cotangent of the specified angle\.

```csharp
public static double Cotan(double angle);
```
#### Parameters

<a name='DiGi.Math.Query.Cotan(double).angle'></a>

`angle` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The angle in radians\.

#### Returns
[System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')  
The cotangent of the angle\.

<a name='DiGi.Math.Query.Coth(double)'></a>

## Query\.Coth\(double\) Method

Calculates the hyperbolic cotangent of the specified angle\.

```csharp
public static double Coth(double angle);
```
#### Parameters

<a name='DiGi.Math.Query.Coth(double).angle'></a>

`angle` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The angle in radians for which the hyperbolic cotangent is calculated\.

#### Returns
[System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')  
The hyperbolic cotangent of the specified angle\.

<a name='DiGi.Math.Query.CubeRoot(double)'></a>

## Query\.CubeRoot\(double\) Method

Calculates the cube root of a specified double\-precision floating\-point number\.

```csharp
public static double CubeRoot(double value);
```
#### Parameters

<a name='DiGi.Math.Query.CubeRoot(double).value'></a>

`value` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The double\-precision floating\-point number to calculate the cube root of\.

#### Returns
[System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')  
The cube root of the specified value\.

<a name='DiGi.Math.Query.LogN(double,double)'></a>

## Query\.LogN\(double, double\) Method

Calculates the logarithm of a specified number to a specified base\.

```csharp
public static double LogN(double x, double n);
```
#### Parameters

<a name='DiGi.Math.Query.LogN(double,double).x'></a>

`x` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The number to calculate the logarithm for\.

<a name='DiGi.Math.Query.LogN(double,double).n'></a>

`n` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The base of the logarithm\.

#### Returns
[System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')  
The logarithm of [x](DiGi.Math.md#DiGi.Math.Query.LogN(double,double).x 'DiGi\.Math\.Query\.LogN\(double, double\)\.x') to base [n](DiGi.Math.md#DiGi.Math.Query.LogN(double,double).n 'DiGi\.Math\.Query\.LogN\(double, double\)\.n')\.

<a name='DiGi.Math.Query.MatrixCofactor(int,int)'></a>

## Query\.MatrixCofactor\(int, int\) Method

Calculates the sign component of a matrix cofactor based on the provided row and column indices\.

```csharp
public static double MatrixCofactor(int row, int column);
```
#### Parameters

<a name='DiGi.Math.Query.MatrixCofactor(int,int).row'></a>

`row` [System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')

The zero\-based index of the row\.

<a name='DiGi.Math.Query.MatrixCofactor(int,int).column'></a>

`column` [System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')

The zero\-based index of the column\.

#### Returns
[System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')  
Returns 1\.0 if the sum of the row and column indices is even, otherwise returns \-1\.0\.

<a name='DiGi.Math.Query.Max_T_(T[])'></a>

## Query\.Max\<T\>\(T\[\]\) Method

Returns the maximum value from a collection of values\.

```csharp
public static T? Max<T>(params T[]? values);
```
#### Type parameters

<a name='DiGi.Math.Query.Max_T_(T[]).T'></a>

`T`

The type of the values being compared\.
#### Parameters

<a name='DiGi.Math.Query.Max_T_(T[]).values'></a>

`values` [T](DiGi.Math.md#DiGi.Math.Query.Max_T_(T[]).T 'DiGi\.Math\.Query\.Max\<T\>\(T\[\]\)\.T')[\[\]](https://learn.microsoft.com/en-us/dotnet/api/system.array 'System\.Array')

A variable number of values to evaluate\.

#### Returns
[T](DiGi.Math.md#DiGi.Math.Query.Max_T_(T[]).T 'DiGi\.Math\.Query\.Max\<T\>\(T\[\]\)\.T')  
The maximum value found in the provided array, or the default value of [T](DiGi.Math.md#DiGi.Math.Query.Max_T_(T[]).T 'DiGi\.Math\.Query\.Max\<T\>\(T\[\]\)\.T') if the input is null\.

<a name='DiGi.Math.Query.Median(thisSystem.Collections.Generic.IEnumerable_double_)'></a>

## Query\.Median\(this IEnumerable\<double\>\) Method

Calculates the median value of a collection of double\-precision floating\-point numbers\.

```csharp
public static double Median(this System.Collections.Generic.IEnumerable<double>? values);
```
#### Parameters

<a name='DiGi.Math.Query.Median(thisSystem.Collections.Generic.IEnumerable_double_).values'></a>

`values` [System\.Collections\.Generic\.IEnumerable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')[System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')

The collection of double\-precision floating\-point numbers to evaluate\.

#### Returns
[System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')  
The median value if the collection is not null or empty; otherwise, [System\.Double\.NaN](https://learn.microsoft.com/en-us/dotnet/api/system.double.nan 'System\.Double\.NaN')\.

<a name='DiGi.Math.Query.Min_T_(T[])'></a>

## Query\.Min\<T\>\(T\[\]\) Method

Returns the minimum value from a collection of values\.

```csharp
public static T? Min<T>(params T[]? values);
```
#### Type parameters

<a name='DiGi.Math.Query.Min_T_(T[]).T'></a>

`T`

The type of elements in the array\.
#### Parameters

<a name='DiGi.Math.Query.Min_T_(T[]).values'></a>

`values` [T](DiGi.Math.md#DiGi.Math.Query.Min_T_(T[]).T 'DiGi\.Math\.Query\.Min\<T\>\(T\[\]\)\.T')[\[\]](https://learn.microsoft.com/en-us/dotnet/api/system.array 'System\.Array')

An optional array of values to evaluate\.

#### Returns
[T](DiGi.Math.md#DiGi.Math.Query.Min_T_(T[]).T 'DiGi\.Math\.Query\.Min\<T\>\(T\[\]\)\.T')  
The minimum value found in the array, or the default value of [T](DiGi.Math.md#DiGi.Math.Query.Min_T_(T[]).T 'DiGi\.Math\.Query\.Min\<T\>\(T\[\]\)\.T') if the array is null\.

<a name='DiGi.Math.Query.Modal_T_(thisSystem.Collections.Generic.IEnumerable_T_)'></a>

## Query\.Modal\<T\>\(this IEnumerable\<T\>\) Method

Returns the modal value \(the most frequent element\) from the specified collection\.

```csharp
public static T? Modal<T>(this System.Collections.Generic.IEnumerable<T>? values);
```
#### Type parameters

<a name='DiGi.Math.Query.Modal_T_(thisSystem.Collections.Generic.IEnumerable_T_).T'></a>

`T`

The type of elements in the collection\.
#### Parameters

<a name='DiGi.Math.Query.Modal_T_(thisSystem.Collections.Generic.IEnumerable_T_).values'></a>

`values` [System\.Collections\.Generic\.IEnumerable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')[T](DiGi.Math.md#DiGi.Math.Query.Modal_T_(thisSystem.Collections.Generic.IEnumerable_T_).T 'DiGi\.Math\.Query\.Modal\<T\>\(this System\.Collections\.Generic\.IEnumerable\<T\>\)\.T')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')

The collection of values to analyze\.

#### Returns
[T](DiGi.Math.md#DiGi.Math.Query.Modal_T_(thisSystem.Collections.Generic.IEnumerable_T_).T 'DiGi\.Math\.Query\.Modal\<T\>\(this System\.Collections\.Generic\.IEnumerable\<T\>\)\.T')  
The most frequently occurring element of type \<typeparam ref="T" /\>, or the default value if the collection is null or empty\.

<a name='DiGi.Math.Query.NeigbourIndices(double[],double,int,int)'></a>

## Query\.NeigbourIndices\(double\[\], double, int, int\) Method

Returns neigbour indices in values array for given value\. Values have to be sorted\.

```csharp
public static void NeigbourIndices(double[]? values, double value, out int lowerIndex, out int upperIndex);
```
#### Parameters

<a name='DiGi.Math.Query.NeigbourIndices(double[],double,int,int).values'></a>

`values` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')[\[\]](https://learn.microsoft.com/en-us/dotnet/api/system.array 'System\.Array')

Values array

<a name='DiGi.Math.Query.NeigbourIndices(double[],double,int,int).value'></a>

`value` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

Value

<a name='DiGi.Math.Query.NeigbourIndices(double[],double,int,int).lowerIndex'></a>

`lowerIndex` [System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')

Lower Index

<a name='DiGi.Math.Query.NeigbourIndices(double[],double,int,int).upperIndex'></a>

`upperIndex` [System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')

Upper Index

<a name='DiGi.Math.Query.RealCubicRoots_ThreeRootsOnly(double,double,double,double,double)'></a>

## Query\.RealCubicRoots\_ThreeRootsOnly\(double, double, double, double, double\) Method

Solves a cubic equation ax³ \+ bx² \+ cx \+ d = 0, specifically returning results only when three real roots exist\.

```csharp
public static double[]? RealCubicRoots_ThreeRootsOnly(double a, double b, double c, double d, double tolerance=1E-06);
```
#### Parameters

<a name='DiGi.Math.Query.RealCubicRoots_ThreeRootsOnly(double,double,double,double,double).a'></a>

`a` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The coefficient of the x³ term\.

<a name='DiGi.Math.Query.RealCubicRoots_ThreeRootsOnly(double,double,double,double,double).b'></a>

`b` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The coefficient of the x² term\.

<a name='DiGi.Math.Query.RealCubicRoots_ThreeRootsOnly(double,double,double,double,double).c'></a>

`c` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The coefficient of the x term\.

<a name='DiGi.Math.Query.RealCubicRoots_ThreeRootsOnly(double,double,double,double,double).d'></a>

`d` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The constant term\.

<a name='DiGi.Math.Query.RealCubicRoots_ThreeRootsOnly(double,double,double,double,double).tolerance'></a>

`tolerance` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The tolerance value used for rounding and comparison operations, defaulting to [DiGi\.Core\.Constants\.Tolerance\.Distance](https://learn.microsoft.com/en-us/dotnet/api/digi.core.constants.tolerance.distance 'DiGi\.Core\.Constants\.Tolerance\.Distance')\.

#### Returns
[System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')[\[\]](https://learn.microsoft.com/en-us/dotnet/api/system.array 'System\.Array')  
An array containing the three real roots if they exist; otherwise, null\.

<a name='DiGi.Math.Query.RealCubricRoots(double,double,double,double)'></a>

## Query\.RealCubricRoots\(double, double, double, double\) Method

Solves a cubic equation of the form ax³ \+ bx² \+ cx \+ d = 0 using Cardano's method\.

```csharp
public static double[]? RealCubricRoots(double a, double b, double c, double d);
```
#### Parameters

<a name='DiGi.Math.Query.RealCubricRoots(double,double,double,double).a'></a>

`a` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The coefficient of the x³ term\.

<a name='DiGi.Math.Query.RealCubricRoots(double,double,double,double).b'></a>

`b` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The coefficient of the x² term\.

<a name='DiGi.Math.Query.RealCubricRoots(double,double,double,double).c'></a>

`c` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The coefficient of the x term\.

<a name='DiGi.Math.Query.RealCubricRoots(double,double,double,double).d'></a>

`d` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The constant term\.

#### Returns
[System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')[\[\]](https://learn.microsoft.com/en-us/dotnet/api/system.array 'System\.Array')  
An array containing the real roots of the equation, or null if no real roots are found\.

<a name='DiGi.Math.Query.Remap(thisdouble,double,double,double,double)'></a>

## Query\.Remap\(this double, double, double, double, double\) Method

Remaps a value from one numeric range to another\.

```csharp
public static double Remap(this double value, double from_1, double to_1, double from_2, double to_2);
```
#### Parameters

<a name='DiGi.Math.Query.Remap(thisdouble,double,double,double,double).value'></a>

`value` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The double\-precision floating\-point number to remap\.

<a name='DiGi.Math.Query.Remap(thisdouble,double,double,double,double).from_1'></a>

`from_1` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The lower bound of the source range\.

<a name='DiGi.Math.Query.Remap(thisdouble,double,double,double,double).to_1'></a>

`to_1` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The upper bound of the source range\.

<a name='DiGi.Math.Query.Remap(thisdouble,double,double,double,double).from_2'></a>

`from_2` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The lower bound of the target range\.

<a name='DiGi.Math.Query.Remap(thisdouble,double,double,double,double).to_2'></a>

`to_2` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The upper bound of the target range\.

#### Returns
[System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')  
The value mapped into the target range, or [from\_2](DiGi.Math.md#DiGi.Math.Query.Remap(thisdouble,double,double,double,double).from_2 'DiGi\.Math\.Query\.Remap\(this double, double, double, double, double\)\.from\_2') if the source or target ranges have zero width\.

<a name='DiGi.Math.Query.Sec(double)'></a>

## Query\.Sec\(double\) Method

Calculates the secant of a specified angle\.

```csharp
public static double Sec(double angle);
```
#### Parameters

<a name='DiGi.Math.Query.Sec(double).angle'></a>

`angle` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The angle in radians\.

#### Returns
[System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')  
The secant of the specified angle\.

<a name='DiGi.Math.Query.Sech(double)'></a>

## Query\.Sech\(double\) Method

Calculates the hyperbolic secant of the specified angle\.

```csharp
public static double Sech(double angle);
```
#### Parameters

<a name='DiGi.Math.Query.Sech(double).angle'></a>

`angle` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The angle in radians\.

#### Returns
[System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')  
The hyperbolic secant of the angle\.

<a name='DiGi.Math.Query.Sinh(double)'></a>

## Query\.Sinh\(double\) Method

Calculates the hyperbolic sine of the specified angle\.

```csharp
public static double Sinh(double angle);
```
#### Parameters

<a name='DiGi.Math.Query.Sinh(double).angle'></a>

`angle` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The angle in radians for which to calculate the hyperbolic sine\.

#### Returns
[System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')  
The hyperbolic sine of the specified angle\.

<a name='DiGi.Math.Query.Tanh(double)'></a>

## Query\.Tanh\(double\) Method

Calculates the hyperbolic tangent of the specified angle\.

```csharp
public static double Tanh(double angle);
```
#### Parameters

<a name='DiGi.Math.Query.Tanh(double).angle'></a>

`angle` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The angle in radians for which to calculate the hyperbolic tangent\.

#### Returns
[System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')  
The hyperbolic tangent of the specified angle\.