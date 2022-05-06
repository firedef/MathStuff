# MathStuff
[![Nuget](https://img.shields.io/nuget/v/MathStuff?color=orange&style=flat-square)](https://www.nuget.org/packages/MathStuff/)<br/>
Collection of some mathematic stuff i using

# Vectors
``float2``, ``float3``, ``float4``, planned to add int and bool analogs.<br/>
Auto-generated code with 1k lines<br/>
```C#
// constructors and conversion
float3 coordinates = new(100,-22.5f); // (100, -22.5f, 0)
float4 vec = new(coordinates,2);      // (100, -22.5f, 0, 2)
vec = float2.one;                     // (1, 1, 0, 0)
float2 five = new(5);                 // (5, 5)

// swizzling
float2 a = vec.xw;                    // (1, 0)
vec = coordinates.xyyz                // (100, -22.5f, -22.5f, 0)

// operators
vec *= 2;                             // (200, -45, -45, 0)
vec /= new float4(20,10,10,0);        // (10, -4.5f, -4.5f, 0)
bool b = a == float2.right;           // true
b = a == 2;                           // false

// other functions
a = float2.Max(a, new float2(2,-1));  // (2, 0)
float c = a.max;                      // 2
a = a.normalized;                     // (1, 0)
```

# Math
``math`` class with mathematic functions <br/>
Bare minimum of math with some other useful functions.<br/>
Planned to implement other common functions, like sin, atan2, etc.<br/>
```C#
float a = math.min(3,-2);             // -2
a = math.pow(5,3);                    // 125
a = math.lerp(10,20,0.5f);            // 15
int b = math.bitCast<int>(a);         // 0x417
```

# Other
```C#
color col = color.red;
col = color.FromHsl((0.5f, 0.5f, 0.8f), 0.5f); // hue from 0 to 1
col = "#FF2233AC";
float4 a = col.WithHue(0.8f);
rect bounds = new(0,0,1920,1080);
```
