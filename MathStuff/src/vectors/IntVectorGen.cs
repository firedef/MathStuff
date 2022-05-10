/* GENERATED USING T4 */

// ReSharper disable IdentifierTypo

namespace MathStuff.vectors;

public struct int2 {
#region staticFields

	public static readonly int2 zero = new(0);
	public static readonly int2 one = new(1);
	public static readonly int2 maxValue = new(int.MaxValue);
	public static readonly int2 minValue = new(int.MinValue);
	public static readonly int2 up = new(0, 1);
	public static readonly int2 down = new(0, -1);
	public static readonly int2 right = new(1, 0);
	public static readonly int2 left = new(-1, 0);

#endregion staticFields

#region axis

	// x axis
	public int x;
	public int2 xx => new(x, x);
	public int3 xxx => new(x, x, x);
	public int4 xxxx => new(x, x, x, x);
	public int4 xxxy => new(x, x, x, y);
	public int3 xxy => new(x, x, y);
	public int4 xxyx => new(x, x, y, x);
	public int4 xxyy => new(x, x, y, y);
	public int2 xy => new(x, y);
	public int3 xyx => new(x, y, x);
	public int4 xyxx => new(x, y, x, x);
	public int4 xyxy => new(x, y, x, y);
	public int3 xyy => new(x, y, y);
	public int4 xyyx => new(x, y, y, x);
	public int4 xyyy => new(x, y, y, y);

	// y axis
	public int y;
	public int2 yx => new(y, x);
	public int3 yxx => new(y, x, x);
	public int4 yxxx => new(y, x, x, x);
	public int4 yxxy => new(y, x, x, y);
	public int3 yxy => new(y, x, y);
	public int4 yxyx => new(y, x, y, x);
	public int4 yxyy => new(y, x, y, y);
	public int2 yy => new(y, y);
	public int3 yyx => new(y, y, x);
	public int4 yyxx => new(y, y, x, x);
	public int4 yyxy => new(y, y, x, y);
	public int3 yyy => new(y, y, y);
	public int4 yyyx => new(y, y, y, x);
	public int4 yyyy => new(y, y, y, y);

#endregion axis

#region constructors

	public int2(int x = 0, int y = 0) {
		this.x = x;
		this.y = y;
	}

	public int2(int v) => x = y = v;

#endregion constructors

#region functions

	public float lengthSq => (float)x * x + (float)y * y;
	public float length => math.sqrt(lengthSq);

	public int sum => x + y;
	public int mul => x * y;
	public float avg => sum * 0.5f;
	public int min => math.min(x, y);
	public int max => math.max(x, y);

	public float2 normalized {
		get {
			float len = 1 / length;
			return this * len;
		}
	}

	public float2 WithLength(float l) {
		float len = l / length;
		return this * len;
	}

	public void FlipX() => x = -x;
	public void FlipY() => y = -y;

#endregion functions

#region operators

	// binary operators 
	public static int2 operator +(int2 a, int2 b) => new(a.x + b.x, a.y + b.y);
	public static int2 operator +(int2 a, int b) => new(a.x + b, a.y + b);
	public static int2 operator +(int a, int2 b) => new(a + b.x, a + b.y);
	public static float2 operator +(int2 a, float2 b) => new(a.x + b.x, a.y + b.y);
	public static float2 operator +(float2 a, int2 b) => new(a.x + b.x, a.y + b.y);

	public static int2 operator -(int2 a, int2 b) => new(a.x - b.x, a.y - b.y);
	public static int2 operator -(int2 a, int b) => new(a.x - b, a.y - b);
	public static int2 operator -(int a, int2 b) => new(a - b.x, a - b.y);
	public static float2 operator -(int2 a, float2 b) => new(a.x - b.x, a.y - b.y);
	public static float2 operator -(float2 a, int2 b) => new(a.x - b.x, a.y - b.y);

	public static int2 operator *(int2 a, int2 b) => new(a.x * b.x, a.y * b.y);
	public static int2 operator *(int2 a, int b) => new(a.x * b, a.y * b);
	public static int2 operator *(int a, int2 b) => new(a * b.x, a * b.y);
	public static float2 operator *(int2 a, float2 b) => new(a.x * b.x, a.y * b.y);
	public static float2 operator *(float2 a, int2 b) => new(a.x * b.x, a.y * b.y);

	public static int2 operator /(int2 a, int2 b) => new(a.x / b.x, a.y / b.y);
	public static int2 operator /(int2 a, int b) => new(a.x / b, a.y / b);
	public static int2 operator /(int a, int2 b) => new(a / b.x, a / b.y);
	public static float2 operator /(int2 a, float2 b) => new(a.x / b.x, a.y / b.y);
	public static float2 operator /(float2 a, int2 b) => new(a.x / b.x, a.y / b.y);


	// equality operators
	public static bool operator ==(int2 a, int2 b) => a.x == b.x && a.y == b.y;
	public static bool operator ==(int2 a, int b) => a.x == b && a.y == b;
	public static bool operator ==(int a, int2 b) => a == b.x && a == b.y;
	public static bool operator ==(int2 a, float2 b) => math.abs(a.x - b.x) < .00001f && math.abs(a.y - b.y) < .00001f;
	public static bool operator ==(float2 a, int2 b) => math.abs(a.x - b.x) < .00001f && math.abs(a.y - b.y) < .00001f;

	public static bool operator !=(int2 a, int2 b) => a.x != b.x || a.y != b.y;
	public static bool operator !=(int2 a, int b) => a.x != b || a.y != b;
	public static bool operator !=(int a, int2 b) => a != b.x || a != b.y;
	public static bool operator !=(int2 a, float2 b) => math.abs(a.x - b.x) >= .00001f || math.abs(a.y - b.y) >= .00001f;
	public static bool operator !=(float2 a, int2 b) => math.abs(a.x - b.x) >= .00001f || math.abs(a.y - b.y) >= .00001f;

	public static bool operator >(int2 a, int2 b) => a.x > b.x && a.y > b.y;
	public static bool operator >(int2 a, int b) => a.x > b && a.y > b;
	public static bool operator >(int a, int2 b) => a > b.x && a > b.y;
	public static bool operator >(int2 a, float2 b) => a.x > b.x && a.y > b.y;
	public static bool operator >(float2 a, int2 b) => a.x > b.x && a.y > b.y;

	public static bool operator >=(int2 a, int2 b) => a.x >= b.x && a.y >= b.y;
	public static bool operator >=(int2 a, int b) => a.x >= b && a.y >= b;
	public static bool operator >=(int a, int2 b) => a >= b.x && a >= b.y;
	public static bool operator >=(int2 a, float2 b) => a.x >= b.x && a.y >= b.y;
	public static bool operator >=(float2 a, int2 b) => a.x >= b.x && a.y >= b.y;

	public static bool operator <(int2 a, int2 b) => a.x < b.x && a.y < b.y;
	public static bool operator <(int2 a, int b) => a.x < b && a.y < b;
	public static bool operator <(int a, int2 b) => a < b.x && a < b.y;
	public static bool operator <(int2 a, float2 b) => a.x < b.x && a.y < b.y;
	public static bool operator <(float2 a, int2 b) => a.x < b.x && a.y < b.y;

	public static bool operator <=(int2 a, int2 b) => a.x <= b.x && a.y <= b.y;
	public static bool operator <=(int2 a, int b) => a.x <= b && a.y <= b;
	public static bool operator <=(int a, int2 b) => a <= b.x && a <= b.y;
	public static bool operator <=(int2 a, float2 b) => a.x <= b.x && a.y <= b.y;
	public static bool operator <=(float2 a, int2 b) => a.x <= b.x && a.y <= b.y;


	// other operators
	public static int2 operator -(int2 a) => new(-a.x, -a.y);
	public static implicit operator int2(int v) => new(v);
	public static explicit operator int2(float v) => new((int)v);

#endregion operators

#region staticFunc

	public static int2 Min(int2 a, int2 b) => new(math.min(a.x, b.x), math.min(a.y, b.y));
	public static int2 Min(int2 a, int2 b, int2 c) => new(math.min(a.x, b.x, c.x), math.min(a.y, b.y, c.y));
	public static int2 Min(int2 a, int2 b, int2 c, int2 d) => new(math.min(a.x, b.x, c.x, d.x), math.min(a.y, b.y, c.y, d.y));

	public static int2 Max(int2 a, int2 b) => new(math.max(a.x, b.x), math.max(a.y, b.y));
	public static int2 Max(int2 a, int2 b, int2 c) => new(math.max(a.x, b.x, c.x), math.max(a.y, b.y, c.y));
	public static int2 Max(int2 a, int2 b, int2 c, int2 d) => new(math.max(a.x, b.x, c.x, d.x), math.max(a.y, b.y, c.y, d.y));

	public static int2 Clamp(int2 v, int2 min, int2 max) => Max(Min(v, max), min);

#endregion staticFunc

#region impl

	public bool Equals(int2 other) => x == other.x && y == other.y;
	public override bool Equals(object? obj) => obj is int2 other && Equals(other);
	public override int GetHashCode() => HashCode.Combine(x, y);

	public override string ToString() => $"({x},{y})";

#endregion impl

#region other

	public static float Dot(int2 a, int2 b) => (float)a.x * b.x + (float)a.y * b.y;

#endregion other

}

public struct int3 {
#region staticFields

	public static readonly int3 zero = new(0);
	public static readonly int3 one = new(1);
	public static readonly int3 maxValue = new(int.MaxValue);
	public static readonly int3 minValue = new(int.MinValue);
	public static readonly int3 up = new(0, 1);
	public static readonly int3 down = new(0, -1);
	public static readonly int3 right = new(1, 0);
	public static readonly int3 left = new(-1, 0);
	public static readonly int3 front = new(0, 0, 1);
	public static readonly int3 back = new(0, 0, -1);

#endregion staticFields

#region axis

	// x axis
	public int x;
	public int2 xx => new(x, x);
	public int3 xxx => new(x, x, x);
	public int4 xxxx => new(x, x, x, x);
	public int4 xxxy => new(x, x, x, y);
	public int4 xxxz => new(x, x, x, z);
	public int3 xxy => new(x, x, y);
	public int4 xxyx => new(x, x, y, x);
	public int4 xxyy => new(x, x, y, y);
	public int4 xxyz => new(x, x, y, z);
	public int3 xxz => new(x, x, z);
	public int4 xxzx => new(x, x, z, x);
	public int4 xxzy => new(x, x, z, y);
	public int4 xxzz => new(x, x, z, z);
	public int2 xy => new(x, y);
	public int3 xyx => new(x, y, x);
	public int4 xyxx => new(x, y, x, x);
	public int4 xyxy => new(x, y, x, y);
	public int4 xyxz => new(x, y, x, z);
	public int3 xyy => new(x, y, y);
	public int4 xyyx => new(x, y, y, x);
	public int4 xyyy => new(x, y, y, y);
	public int4 xyyz => new(x, y, y, z);
	public int3 xyz => new(x, y, z);
	public int4 xyzx => new(x, y, z, x);
	public int4 xyzy => new(x, y, z, y);
	public int4 xyzz => new(x, y, z, z);
	public int2 xz => new(x, z);
	public int3 xzx => new(x, z, x);
	public int4 xzxx => new(x, z, x, x);
	public int4 xzxy => new(x, z, x, y);
	public int4 xzxz => new(x, z, x, z);
	public int3 xzy => new(x, z, y);
	public int4 xzyx => new(x, z, y, x);
	public int4 xzyy => new(x, z, y, y);
	public int4 xzyz => new(x, z, y, z);
	public int3 xzz => new(x, z, z);
	public int4 xzzx => new(x, z, z, x);
	public int4 xzzy => new(x, z, z, y);
	public int4 xzzz => new(x, z, z, z);

	// y axis
	public int y;
	public int2 yx => new(y, x);
	public int3 yxx => new(y, x, x);
	public int4 yxxx => new(y, x, x, x);
	public int4 yxxy => new(y, x, x, y);
	public int4 yxxz => new(y, x, x, z);
	public int3 yxy => new(y, x, y);
	public int4 yxyx => new(y, x, y, x);
	public int4 yxyy => new(y, x, y, y);
	public int4 yxyz => new(y, x, y, z);
	public int3 yxz => new(y, x, z);
	public int4 yxzx => new(y, x, z, x);
	public int4 yxzy => new(y, x, z, y);
	public int4 yxzz => new(y, x, z, z);
	public int2 yy => new(y, y);
	public int3 yyx => new(y, y, x);
	public int4 yyxx => new(y, y, x, x);
	public int4 yyxy => new(y, y, x, y);
	public int4 yyxz => new(y, y, x, z);
	public int3 yyy => new(y, y, y);
	public int4 yyyx => new(y, y, y, x);
	public int4 yyyy => new(y, y, y, y);
	public int4 yyyz => new(y, y, y, z);
	public int3 yyz => new(y, y, z);
	public int4 yyzx => new(y, y, z, x);
	public int4 yyzy => new(y, y, z, y);
	public int4 yyzz => new(y, y, z, z);
	public int2 yz => new(y, z);
	public int3 yzx => new(y, z, x);
	public int4 yzxx => new(y, z, x, x);
	public int4 yzxy => new(y, z, x, y);
	public int4 yzxz => new(y, z, x, z);
	public int3 yzy => new(y, z, y);
	public int4 yzyx => new(y, z, y, x);
	public int4 yzyy => new(y, z, y, y);
	public int4 yzyz => new(y, z, y, z);
	public int3 yzz => new(y, z, z);
	public int4 yzzx => new(y, z, z, x);
	public int4 yzzy => new(y, z, z, y);
	public int4 yzzz => new(y, z, z, z);

	// z axis
	public int z;
	public int2 zx => new(z, x);
	public int3 zxx => new(z, x, x);
	public int4 zxxx => new(z, x, x, x);
	public int4 zxxy => new(z, x, x, y);
	public int4 zxxz => new(z, x, x, z);
	public int3 zxy => new(z, x, y);
	public int4 zxyx => new(z, x, y, x);
	public int4 zxyy => new(z, x, y, y);
	public int4 zxyz => new(z, x, y, z);
	public int3 zxz => new(z, x, z);
	public int4 zxzx => new(z, x, z, x);
	public int4 zxzy => new(z, x, z, y);
	public int4 zxzz => new(z, x, z, z);
	public int2 zy => new(z, y);
	public int3 zyx => new(z, y, x);
	public int4 zyxx => new(z, y, x, x);
	public int4 zyxy => new(z, y, x, y);
	public int4 zyxz => new(z, y, x, z);
	public int3 zyy => new(z, y, y);
	public int4 zyyx => new(z, y, y, x);
	public int4 zyyy => new(z, y, y, y);
	public int4 zyyz => new(z, y, y, z);
	public int3 zyz => new(z, y, z);
	public int4 zyzx => new(z, y, z, x);
	public int4 zyzy => new(z, y, z, y);
	public int4 zyzz => new(z, y, z, z);
	public int2 zz => new(z, z);
	public int3 zzx => new(z, z, x);
	public int4 zzxx => new(z, z, x, x);
	public int4 zzxy => new(z, z, x, y);
	public int4 zzxz => new(z, z, x, z);
	public int3 zzy => new(z, z, y);
	public int4 zzyx => new(z, z, y, x);
	public int4 zzyy => new(z, z, y, y);
	public int4 zzyz => new(z, z, y, z);
	public int3 zzz => new(z, z, z);
	public int4 zzzx => new(z, z, z, x);
	public int4 zzzy => new(z, z, z, y);
	public int4 zzzz => new(z, z, z, z);

#endregion axis

#region constructors

	public int3(int x = 0, int y = 0, int z = 0) {
		this.x = x;
		this.y = y;
		this.z = z;
	}

	public int3(int v) => x = y = z = v;

#endregion constructors

#region functions

	public float lengthSq => (float)x * x + (float)y * y + (float)z * z;
	public float length => math.sqrt(lengthSq);

	public int sum => x + y + z;
	public int mul => x * y * z;
	public float avg => sum * 0.3333333f;
	public int min => math.min(x, y, z);
	public int max => math.max(x, y, z);

	public float3 normalized {
		get {
			float len = 1 / length;
			return this * len;
		}
	}

	public float3 WithLength(float l) {
		float len = l / length;
		return this * len;
	}

	public void FlipX() => x = -x;
	public void FlipY() => y = -y;
	public void FlipZ() => z = -z;

#endregion functions

#region operators

	// binary operators 
	public static int3 operator +(int3 a, int3 b) => new(a.x + b.x, a.y + b.y, a.z + b.z);
	public static int3 operator +(int3 a, int b) => new(a.x + b, a.y + b, a.z + b);
	public static int3 operator +(int a, int3 b) => new(a + b.x, a + b.y, a + b.z);
	public static float3 operator +(int3 a, float3 b) => new(a.x + b.x, a.y + b.y, a.z + b.z);
	public static float3 operator +(float3 a, int3 b) => new(a.x + b.x, a.y + b.y, a.z + b.z);

	public static int3 operator -(int3 a, int3 b) => new(a.x - b.x, a.y - b.y, a.z - b.z);
	public static int3 operator -(int3 a, int b) => new(a.x - b, a.y - b, a.z - b);
	public static int3 operator -(int a, int3 b) => new(a - b.x, a - b.y, a - b.z);
	public static float3 operator -(int3 a, float3 b) => new(a.x - b.x, a.y - b.y, a.z - b.z);
	public static float3 operator -(float3 a, int3 b) => new(a.x - b.x, a.y - b.y, a.z - b.z);

	public static int3 operator *(int3 a, int3 b) => new(a.x * b.x, a.y * b.y, a.z * b.z);
	public static int3 operator *(int3 a, int b) => new(a.x * b, a.y * b, a.z * b);
	public static int3 operator *(int a, int3 b) => new(a * b.x, a * b.y, a * b.z);
	public static float3 operator *(int3 a, float3 b) => new(a.x * b.x, a.y * b.y, a.z * b.z);
	public static float3 operator *(float3 a, int3 b) => new(a.x * b.x, a.y * b.y, a.z * b.z);

	public static int3 operator /(int3 a, int3 b) => new(a.x / b.x, a.y / b.y, a.z / b.z);
	public static int3 operator /(int3 a, int b) => new(a.x / b, a.y / b, a.z / b);
	public static int3 operator /(int a, int3 b) => new(a / b.x, a / b.y, a / b.z);
	public static float3 operator /(int3 a, float3 b) => new(a.x / b.x, a.y / b.y, a.z / b.z);
	public static float3 operator /(float3 a, int3 b) => new(a.x / b.x, a.y / b.y, a.z / b.z);


	// equality operators
	public static bool operator ==(int3 a, int3 b) => a.x == b.x && a.y == b.y && a.z == b.z;
	public static bool operator ==(int3 a, int b) => a.x == b && a.y == b && a.z == b;
	public static bool operator ==(int a, int3 b) => a == b.x && a == b.y && a == b.z;
	public static bool operator ==(int3 a, float3 b) => math.abs(a.x - b.x) < .00001f && math.abs(a.y - b.y) < .00001f && math.abs(a.z - b.z) < .00001f;
	public static bool operator ==(float3 a, int3 b) => math.abs(a.x - b.x) < .00001f && math.abs(a.y - b.y) < .00001f && math.abs(a.z - b.z) < .00001f;

	public static bool operator !=(int3 a, int3 b) => a.x != b.x || a.y != b.y || a.z != b.z;
	public static bool operator !=(int3 a, int b) => a.x != b || a.y != b || a.z != b;
	public static bool operator !=(int a, int3 b) => a != b.x || a != b.y || a != b.z;
	public static bool operator !=(int3 a, float3 b) => math.abs(a.x - b.x) >= .00001f || math.abs(a.y - b.y) >= .00001f || math.abs(a.z - b.z) >= .00001f;
	public static bool operator !=(float3 a, int3 b) => math.abs(a.x - b.x) >= .00001f || math.abs(a.y - b.y) >= .00001f || math.abs(a.z - b.z) >= .00001f;

	public static bool operator >(int3 a, int3 b) => a.x > b.x && a.y > b.y && a.z > b.z;
	public static bool operator >(int3 a, int b) => a.x > b && a.y > b && a.z > b;
	public static bool operator >(int a, int3 b) => a > b.x && a > b.y && a > b.z;
	public static bool operator >(int3 a, float3 b) => a.x > b.x && a.y > b.y && a.z > b.z;
	public static bool operator >(float3 a, int3 b) => a.x > b.x && a.y > b.y && a.z > b.z;

	public static bool operator >=(int3 a, int3 b) => a.x >= b.x && a.y >= b.y && a.z >= b.z;
	public static bool operator >=(int3 a, int b) => a.x >= b && a.y >= b && a.z >= b;
	public static bool operator >=(int a, int3 b) => a >= b.x && a >= b.y && a >= b.z;
	public static bool operator >=(int3 a, float3 b) => a.x >= b.x && a.y >= b.y && a.z >= b.z;
	public static bool operator >=(float3 a, int3 b) => a.x >= b.x && a.y >= b.y && a.z >= b.z;

	public static bool operator <(int3 a, int3 b) => a.x < b.x && a.y < b.y && a.z < b.z;
	public static bool operator <(int3 a, int b) => a.x < b && a.y < b && a.z < b;
	public static bool operator <(int a, int3 b) => a < b.x && a < b.y && a < b.z;
	public static bool operator <(int3 a, float3 b) => a.x < b.x && a.y < b.y && a.z < b.z;
	public static bool operator <(float3 a, int3 b) => a.x < b.x && a.y < b.y && a.z < b.z;

	public static bool operator <=(int3 a, int3 b) => a.x <= b.x && a.y <= b.y && a.z <= b.z;
	public static bool operator <=(int3 a, int b) => a.x <= b && a.y <= b && a.z <= b;
	public static bool operator <=(int a, int3 b) => a <= b.x && a <= b.y && a <= b.z;
	public static bool operator <=(int3 a, float3 b) => a.x <= b.x && a.y <= b.y && a.z <= b.z;
	public static bool operator <=(float3 a, int3 b) => a.x <= b.x && a.y <= b.y && a.z <= b.z;


	// other operators
	public static int3 operator -(int3 a) => new(-a.x, -a.y, -a.z);
	public static implicit operator int3(int v) => new(v);
	public static explicit operator int3(float v) => new((int)v);

	public int3(int2 a, int z) {
		x = a.x;
		y = a.y;

		this.z = z;
	}

	public static implicit operator int2(int3 v) => v.xy;
	public static implicit operator int3(int2 v) => new(v.x, v.y);

#endregion operators

#region staticFunc

	public static int3 Min(int3 a, int3 b) => new(math.min(a.x, b.x), math.min(a.y, b.y), math.min(a.z, b.z));
	public static int3 Min(int3 a, int3 b, int3 c) => new(math.min(a.x, b.x, c.x), math.min(a.y, b.y, c.y), math.min(a.z, b.z, c.z));
	public static int3 Min(int3 a, int3 b, int3 c, int3 d) => new(math.min(a.x, b.x, c.x, d.x), math.min(a.y, b.y, c.y, d.y), math.min(a.z, b.z, c.z, d.z));

	public static int3 Max(int3 a, int3 b) => new(math.max(a.x, b.x), math.max(a.y, b.y), math.max(a.z, b.z));
	public static int3 Max(int3 a, int3 b, int3 c) => new(math.max(a.x, b.x, c.x), math.max(a.y, b.y, c.y), math.max(a.z, b.z, c.z));
	public static int3 Max(int3 a, int3 b, int3 c, int3 d) => new(math.max(a.x, b.x, c.x, d.x), math.max(a.y, b.y, c.y, d.y), math.max(a.z, b.z, c.z, d.z));

	public static int3 Clamp(int3 v, int3 min, int3 max) => Max(Min(v, max), min);

#endregion staticFunc

#region impl

	public bool Equals(int3 other) => x == other.x && y == other.y && z == other.z;
	public override bool Equals(object? obj) => obj is int3 other && Equals(other);
	public override int GetHashCode() => HashCode.Combine(x, y, z);

	public override string ToString() => $"({x},{y},{z})";

#endregion impl

#region other

	public static float Dot(int3 a, int3 b) => (float)a.x * b.x + (float)a.y * b.y + (float)a.z * b.z;

#endregion other

}

public struct int4 {
#region staticFields

	public static readonly int4 zero = new(0);
	public static readonly int4 one = new(1);
	public static readonly int4 maxValue = new(int.MaxValue);
	public static readonly int4 minValue = new(int.MinValue);
	public static readonly int4 up = new(0, 1);
	public static readonly int4 down = new(0, -1);
	public static readonly int4 right = new(1, 0);
	public static readonly int4 left = new(-1, 0);
	public static readonly int4 front = new(0, 0, 1);
	public static readonly int4 back = new(0, 0, -1);

#endregion staticFields

#region axis

	// x axis
	public int x;
	public int2 xx => new(x, x);
	public int3 xxx => new(x, x, x);
	public int4 xxxx => new(x, x, x, x);
	public int4 xxxy => new(x, x, x, y);
	public int4 xxxz => new(x, x, x, z);
	public int4 xxxw => new(x, x, x, w);
	public int3 xxy => new(x, x, y);
	public int4 xxyx => new(x, x, y, x);
	public int4 xxyy => new(x, x, y, y);
	public int4 xxyz => new(x, x, y, z);
	public int4 xxyw => new(x, x, y, w);
	public int3 xxz => new(x, x, z);
	public int4 xxzx => new(x, x, z, x);
	public int4 xxzy => new(x, x, z, y);
	public int4 xxzz => new(x, x, z, z);
	public int4 xxzw => new(x, x, z, w);
	public int3 xxw => new(x, x, w);
	public int4 xxwx => new(x, x, w, x);
	public int4 xxwy => new(x, x, w, y);
	public int4 xxwz => new(x, x, w, z);
	public int4 xxww => new(x, x, w, w);
	public int2 xy => new(x, y);
	public int3 xyx => new(x, y, x);
	public int4 xyxx => new(x, y, x, x);
	public int4 xyxy => new(x, y, x, y);
	public int4 xyxz => new(x, y, x, z);
	public int4 xyxw => new(x, y, x, w);
	public int3 xyy => new(x, y, y);
	public int4 xyyx => new(x, y, y, x);
	public int4 xyyy => new(x, y, y, y);
	public int4 xyyz => new(x, y, y, z);
	public int4 xyyw => new(x, y, y, w);
	public int3 xyz => new(x, y, z);
	public int4 xyzx => new(x, y, z, x);
	public int4 xyzy => new(x, y, z, y);
	public int4 xyzz => new(x, y, z, z);
	public int4 xyzw => new(x, y, z, w);
	public int3 xyw => new(x, y, w);
	public int4 xywx => new(x, y, w, x);
	public int4 xywy => new(x, y, w, y);
	public int4 xywz => new(x, y, w, z);
	public int4 xyww => new(x, y, w, w);
	public int2 xz => new(x, z);
	public int3 xzx => new(x, z, x);
	public int4 xzxx => new(x, z, x, x);
	public int4 xzxy => new(x, z, x, y);
	public int4 xzxz => new(x, z, x, z);
	public int4 xzxw => new(x, z, x, w);
	public int3 xzy => new(x, z, y);
	public int4 xzyx => new(x, z, y, x);
	public int4 xzyy => new(x, z, y, y);
	public int4 xzyz => new(x, z, y, z);
	public int4 xzyw => new(x, z, y, w);
	public int3 xzz => new(x, z, z);
	public int4 xzzx => new(x, z, z, x);
	public int4 xzzy => new(x, z, z, y);
	public int4 xzzz => new(x, z, z, z);
	public int4 xzzw => new(x, z, z, w);
	public int3 xzw => new(x, z, w);
	public int4 xzwx => new(x, z, w, x);
	public int4 xzwy => new(x, z, w, y);
	public int4 xzwz => new(x, z, w, z);
	public int4 xzww => new(x, z, w, w);
	public int2 xw => new(x, w);
	public int3 xwx => new(x, w, x);
	public int4 xwxx => new(x, w, x, x);
	public int4 xwxy => new(x, w, x, y);
	public int4 xwxz => new(x, w, x, z);
	public int4 xwxw => new(x, w, x, w);
	public int3 xwy => new(x, w, y);
	public int4 xwyx => new(x, w, y, x);
	public int4 xwyy => new(x, w, y, y);
	public int4 xwyz => new(x, w, y, z);
	public int4 xwyw => new(x, w, y, w);
	public int3 xwz => new(x, w, z);
	public int4 xwzx => new(x, w, z, x);
	public int4 xwzy => new(x, w, z, y);
	public int4 xwzz => new(x, w, z, z);
	public int4 xwzw => new(x, w, z, w);
	public int3 xww => new(x, w, w);
	public int4 xwwx => new(x, w, w, x);
	public int4 xwwy => new(x, w, w, y);
	public int4 xwwz => new(x, w, w, z);
	public int4 xwww => new(x, w, w, w);

	// y axis
	public int y;
	public int2 yx => new(y, x);
	public int3 yxx => new(y, x, x);
	public int4 yxxx => new(y, x, x, x);
	public int4 yxxy => new(y, x, x, y);
	public int4 yxxz => new(y, x, x, z);
	public int4 yxxw => new(y, x, x, w);
	public int3 yxy => new(y, x, y);
	public int4 yxyx => new(y, x, y, x);
	public int4 yxyy => new(y, x, y, y);
	public int4 yxyz => new(y, x, y, z);
	public int4 yxyw => new(y, x, y, w);
	public int3 yxz => new(y, x, z);
	public int4 yxzx => new(y, x, z, x);
	public int4 yxzy => new(y, x, z, y);
	public int4 yxzz => new(y, x, z, z);
	public int4 yxzw => new(y, x, z, w);
	public int3 yxw => new(y, x, w);
	public int4 yxwx => new(y, x, w, x);
	public int4 yxwy => new(y, x, w, y);
	public int4 yxwz => new(y, x, w, z);
	public int4 yxww => new(y, x, w, w);
	public int2 yy => new(y, y);
	public int3 yyx => new(y, y, x);
	public int4 yyxx => new(y, y, x, x);
	public int4 yyxy => new(y, y, x, y);
	public int4 yyxz => new(y, y, x, z);
	public int4 yyxw => new(y, y, x, w);
	public int3 yyy => new(y, y, y);
	public int4 yyyx => new(y, y, y, x);
	public int4 yyyy => new(y, y, y, y);
	public int4 yyyz => new(y, y, y, z);
	public int4 yyyw => new(y, y, y, w);
	public int3 yyz => new(y, y, z);
	public int4 yyzx => new(y, y, z, x);
	public int4 yyzy => new(y, y, z, y);
	public int4 yyzz => new(y, y, z, z);
	public int4 yyzw => new(y, y, z, w);
	public int3 yyw => new(y, y, w);
	public int4 yywx => new(y, y, w, x);
	public int4 yywy => new(y, y, w, y);
	public int4 yywz => new(y, y, w, z);
	public int4 yyww => new(y, y, w, w);
	public int2 yz => new(y, z);
	public int3 yzx => new(y, z, x);
	public int4 yzxx => new(y, z, x, x);
	public int4 yzxy => new(y, z, x, y);
	public int4 yzxz => new(y, z, x, z);
	public int4 yzxw => new(y, z, x, w);
	public int3 yzy => new(y, z, y);
	public int4 yzyx => new(y, z, y, x);
	public int4 yzyy => new(y, z, y, y);
	public int4 yzyz => new(y, z, y, z);
	public int4 yzyw => new(y, z, y, w);
	public int3 yzz => new(y, z, z);
	public int4 yzzx => new(y, z, z, x);
	public int4 yzzy => new(y, z, z, y);
	public int4 yzzz => new(y, z, z, z);
	public int4 yzzw => new(y, z, z, w);
	public int3 yzw => new(y, z, w);
	public int4 yzwx => new(y, z, w, x);
	public int4 yzwy => new(y, z, w, y);
	public int4 yzwz => new(y, z, w, z);
	public int4 yzww => new(y, z, w, w);
	public int2 yw => new(y, w);
	public int3 ywx => new(y, w, x);
	public int4 ywxx => new(y, w, x, x);
	public int4 ywxy => new(y, w, x, y);
	public int4 ywxz => new(y, w, x, z);
	public int4 ywxw => new(y, w, x, w);
	public int3 ywy => new(y, w, y);
	public int4 ywyx => new(y, w, y, x);
	public int4 ywyy => new(y, w, y, y);
	public int4 ywyz => new(y, w, y, z);
	public int4 ywyw => new(y, w, y, w);
	public int3 ywz => new(y, w, z);
	public int4 ywzx => new(y, w, z, x);
	public int4 ywzy => new(y, w, z, y);
	public int4 ywzz => new(y, w, z, z);
	public int4 ywzw => new(y, w, z, w);
	public int3 yww => new(y, w, w);
	public int4 ywwx => new(y, w, w, x);
	public int4 ywwy => new(y, w, w, y);
	public int4 ywwz => new(y, w, w, z);
	public int4 ywww => new(y, w, w, w);

	// z axis
	public int z;
	public int2 zx => new(z, x);
	public int3 zxx => new(z, x, x);
	public int4 zxxx => new(z, x, x, x);
	public int4 zxxy => new(z, x, x, y);
	public int4 zxxz => new(z, x, x, z);
	public int4 zxxw => new(z, x, x, w);
	public int3 zxy => new(z, x, y);
	public int4 zxyx => new(z, x, y, x);
	public int4 zxyy => new(z, x, y, y);
	public int4 zxyz => new(z, x, y, z);
	public int4 zxyw => new(z, x, y, w);
	public int3 zxz => new(z, x, z);
	public int4 zxzx => new(z, x, z, x);
	public int4 zxzy => new(z, x, z, y);
	public int4 zxzz => new(z, x, z, z);
	public int4 zxzw => new(z, x, z, w);
	public int3 zxw => new(z, x, w);
	public int4 zxwx => new(z, x, w, x);
	public int4 zxwy => new(z, x, w, y);
	public int4 zxwz => new(z, x, w, z);
	public int4 zxww => new(z, x, w, w);
	public int2 zy => new(z, y);
	public int3 zyx => new(z, y, x);
	public int4 zyxx => new(z, y, x, x);
	public int4 zyxy => new(z, y, x, y);
	public int4 zyxz => new(z, y, x, z);
	public int4 zyxw => new(z, y, x, w);
	public int3 zyy => new(z, y, y);
	public int4 zyyx => new(z, y, y, x);
	public int4 zyyy => new(z, y, y, y);
	public int4 zyyz => new(z, y, y, z);
	public int4 zyyw => new(z, y, y, w);
	public int3 zyz => new(z, y, z);
	public int4 zyzx => new(z, y, z, x);
	public int4 zyzy => new(z, y, z, y);
	public int4 zyzz => new(z, y, z, z);
	public int4 zyzw => new(z, y, z, w);
	public int3 zyw => new(z, y, w);
	public int4 zywx => new(z, y, w, x);
	public int4 zywy => new(z, y, w, y);
	public int4 zywz => new(z, y, w, z);
	public int4 zyww => new(z, y, w, w);
	public int2 zz => new(z, z);
	public int3 zzx => new(z, z, x);
	public int4 zzxx => new(z, z, x, x);
	public int4 zzxy => new(z, z, x, y);
	public int4 zzxz => new(z, z, x, z);
	public int4 zzxw => new(z, z, x, w);
	public int3 zzy => new(z, z, y);
	public int4 zzyx => new(z, z, y, x);
	public int4 zzyy => new(z, z, y, y);
	public int4 zzyz => new(z, z, y, z);
	public int4 zzyw => new(z, z, y, w);
	public int3 zzz => new(z, z, z);
	public int4 zzzx => new(z, z, z, x);
	public int4 zzzy => new(z, z, z, y);
	public int4 zzzz => new(z, z, z, z);
	public int4 zzzw => new(z, z, z, w);
	public int3 zzw => new(z, z, w);
	public int4 zzwx => new(z, z, w, x);
	public int4 zzwy => new(z, z, w, y);
	public int4 zzwz => new(z, z, w, z);
	public int4 zzww => new(z, z, w, w);
	public int2 zw => new(z, w);
	public int3 zwx => new(z, w, x);
	public int4 zwxx => new(z, w, x, x);
	public int4 zwxy => new(z, w, x, y);
	public int4 zwxz => new(z, w, x, z);
	public int4 zwxw => new(z, w, x, w);
	public int3 zwy => new(z, w, y);
	public int4 zwyx => new(z, w, y, x);
	public int4 zwyy => new(z, w, y, y);
	public int4 zwyz => new(z, w, y, z);
	public int4 zwyw => new(z, w, y, w);
	public int3 zwz => new(z, w, z);
	public int4 zwzx => new(z, w, z, x);
	public int4 zwzy => new(z, w, z, y);
	public int4 zwzz => new(z, w, z, z);
	public int4 zwzw => new(z, w, z, w);
	public int3 zww => new(z, w, w);
	public int4 zwwx => new(z, w, w, x);
	public int4 zwwy => new(z, w, w, y);
	public int4 zwwz => new(z, w, w, z);
	public int4 zwww => new(z, w, w, w);

	// w axis
	public int w;
	public int2 wx => new(w, x);
	public int3 wxx => new(w, x, x);
	public int4 wxxx => new(w, x, x, x);
	public int4 wxxy => new(w, x, x, y);
	public int4 wxxz => new(w, x, x, z);
	public int4 wxxw => new(w, x, x, w);
	public int3 wxy => new(w, x, y);
	public int4 wxyx => new(w, x, y, x);
	public int4 wxyy => new(w, x, y, y);
	public int4 wxyz => new(w, x, y, z);
	public int4 wxyw => new(w, x, y, w);
	public int3 wxz => new(w, x, z);
	public int4 wxzx => new(w, x, z, x);
	public int4 wxzy => new(w, x, z, y);
	public int4 wxzz => new(w, x, z, z);
	public int4 wxzw => new(w, x, z, w);
	public int3 wxw => new(w, x, w);
	public int4 wxwx => new(w, x, w, x);
	public int4 wxwy => new(w, x, w, y);
	public int4 wxwz => new(w, x, w, z);
	public int4 wxww => new(w, x, w, w);
	public int2 wy => new(w, y);
	public int3 wyx => new(w, y, x);
	public int4 wyxx => new(w, y, x, x);
	public int4 wyxy => new(w, y, x, y);
	public int4 wyxz => new(w, y, x, z);
	public int4 wyxw => new(w, y, x, w);
	public int3 wyy => new(w, y, y);
	public int4 wyyx => new(w, y, y, x);
	public int4 wyyy => new(w, y, y, y);
	public int4 wyyz => new(w, y, y, z);
	public int4 wyyw => new(w, y, y, w);
	public int3 wyz => new(w, y, z);
	public int4 wyzx => new(w, y, z, x);
	public int4 wyzy => new(w, y, z, y);
	public int4 wyzz => new(w, y, z, z);
	public int4 wyzw => new(w, y, z, w);
	public int3 wyw => new(w, y, w);
	public int4 wywx => new(w, y, w, x);
	public int4 wywy => new(w, y, w, y);
	public int4 wywz => new(w, y, w, z);
	public int4 wyww => new(w, y, w, w);
	public int2 wz => new(w, z);
	public int3 wzx => new(w, z, x);
	public int4 wzxx => new(w, z, x, x);
	public int4 wzxy => new(w, z, x, y);
	public int4 wzxz => new(w, z, x, z);
	public int4 wzxw => new(w, z, x, w);
	public int3 wzy => new(w, z, y);
	public int4 wzyx => new(w, z, y, x);
	public int4 wzyy => new(w, z, y, y);
	public int4 wzyz => new(w, z, y, z);
	public int4 wzyw => new(w, z, y, w);
	public int3 wzz => new(w, z, z);
	public int4 wzzx => new(w, z, z, x);
	public int4 wzzy => new(w, z, z, y);
	public int4 wzzz => new(w, z, z, z);
	public int4 wzzw => new(w, z, z, w);
	public int3 wzw => new(w, z, w);
	public int4 wzwx => new(w, z, w, x);
	public int4 wzwy => new(w, z, w, y);
	public int4 wzwz => new(w, z, w, z);
	public int4 wzww => new(w, z, w, w);
	public int2 ww => new(w, w);
	public int3 wwx => new(w, w, x);
	public int4 wwxx => new(w, w, x, x);
	public int4 wwxy => new(w, w, x, y);
	public int4 wwxz => new(w, w, x, z);
	public int4 wwxw => new(w, w, x, w);
	public int3 wwy => new(w, w, y);
	public int4 wwyx => new(w, w, y, x);
	public int4 wwyy => new(w, w, y, y);
	public int4 wwyz => new(w, w, y, z);
	public int4 wwyw => new(w, w, y, w);
	public int3 wwz => new(w, w, z);
	public int4 wwzx => new(w, w, z, x);
	public int4 wwzy => new(w, w, z, y);
	public int4 wwzz => new(w, w, z, z);
	public int4 wwzw => new(w, w, z, w);
	public int3 www => new(w, w, w);
	public int4 wwwx => new(w, w, w, x);
	public int4 wwwy => new(w, w, w, y);
	public int4 wwwz => new(w, w, w, z);
	public int4 wwww => new(w, w, w, w);

#endregion axis

#region constructors

	public int4(int x = 0, int y = 0, int z = 0, int w = 0) {
		this.x = x;
		this.y = y;
		this.z = z;
		this.w = w;
	}

	public int4(int v) => x = y = z = w = v;

#endregion constructors

#region functions

	public float lengthSq => (float)x * x + (float)y * y + (float)z * z + (float)w * w;
	public float length => math.sqrt(lengthSq);

	public int sum => x + y + z + w;
	public int mul => x * y * z * w;
	public float avg => sum * 0.25f;
	public int min => math.min(x, y, z, w);
	public int max => math.max(x, y, z, w);

	public float4 normalized {
		get {
			float len = 1 / length;
			return this * len;
		}
	}

	public float4 WithLength(float l) {
		float len = l / length;
		return this * len;
	}

	public void FlipX() => x = -x;
	public void FlipY() => y = -y;
	public void FlipZ() => z = -z;
	public void FlipW() => w = -w;

#endregion functions

#region operators

	// binary operators 
	public static int4 operator +(int4 a, int4 b) => new(a.x + b.x, a.y + b.y, a.z + b.z, a.w + b.w);
	public static int4 operator +(int4 a, int b) => new(a.x + b, a.y + b, a.z + b, a.w + b);
	public static int4 operator +(int a, int4 b) => new(a + b.x, a + b.y, a + b.z, a + b.w);
	public static float4 operator +(int4 a, float4 b) => new(a.x + b.x, a.y + b.y, a.z + b.z, a.w + b.w);
	public static float4 operator +(float4 a, int4 b) => new(a.x + b.x, a.y + b.y, a.z + b.z, a.w + b.w);

	public static int4 operator -(int4 a, int4 b) => new(a.x - b.x, a.y - b.y, a.z - b.z, a.w - b.w);
	public static int4 operator -(int4 a, int b) => new(a.x - b, a.y - b, a.z - b, a.w - b);
	public static int4 operator -(int a, int4 b) => new(a - b.x, a - b.y, a - b.z, a - b.w);
	public static float4 operator -(int4 a, float4 b) => new(a.x - b.x, a.y - b.y, a.z - b.z, a.w - b.w);
	public static float4 operator -(float4 a, int4 b) => new(a.x - b.x, a.y - b.y, a.z - b.z, a.w - b.w);

	public static int4 operator *(int4 a, int4 b) => new(a.x * b.x, a.y * b.y, a.z * b.z, a.w * b.w);
	public static int4 operator *(int4 a, int b) => new(a.x * b, a.y * b, a.z * b, a.w * b);
	public static int4 operator *(int a, int4 b) => new(a * b.x, a * b.y, a * b.z, a * b.w);
	public static float4 operator *(int4 a, float4 b) => new(a.x * b.x, a.y * b.y, a.z * b.z, a.w * b.w);
	public static float4 operator *(float4 a, int4 b) => new(a.x * b.x, a.y * b.y, a.z * b.z, a.w * b.w);

	public static int4 operator /(int4 a, int4 b) => new(a.x / b.x, a.y / b.y, a.z / b.z, a.w / b.w);
	public static int4 operator /(int4 a, int b) => new(a.x / b, a.y / b, a.z / b, a.w / b);
	public static int4 operator /(int a, int4 b) => new(a / b.x, a / b.y, a / b.z, a / b.w);
	public static float4 operator /(int4 a, float4 b) => new(a.x / b.x, a.y / b.y, a.z / b.z, a.w / b.w);
	public static float4 operator /(float4 a, int4 b) => new(a.x / b.x, a.y / b.y, a.z / b.z, a.w / b.w);


	// equality operators
	public static bool operator ==(int4 a, int4 b) => a.x == b.x && a.y == b.y && a.z == b.z && a.w == b.w;
	public static bool operator ==(int4 a, int b) => a.x == b && a.y == b && a.z == b && a.w == b;
	public static bool operator ==(int a, int4 b) => a == b.x && a == b.y && a == b.z && a == b.w;
	public static bool operator ==(int4 a, float4 b) => math.abs(a.x - b.x) < .00001f && math.abs(a.y - b.y) < .00001f && math.abs(a.z - b.z) < .00001f && math.abs(a.w - b.w) < .00001f;
	public static bool operator ==(float4 a, int4 b) => math.abs(a.x - b.x) < .00001f && math.abs(a.y - b.y) < .00001f && math.abs(a.z - b.z) < .00001f && math.abs(a.w - b.w) < .00001f;

	public static bool operator !=(int4 a, int4 b) => a.x != b.x || a.y != b.y || a.z != b.z || a.w != b.w;
	public static bool operator !=(int4 a, int b) => a.x != b || a.y != b || a.z != b || a.w != b;
	public static bool operator !=(int a, int4 b) => a != b.x || a != b.y || a != b.z || a != b.w;
	public static bool operator !=(int4 a, float4 b) => math.abs(a.x - b.x) >= .00001f || math.abs(a.y - b.y) >= .00001f || math.abs(a.z - b.z) >= .00001f || math.abs(a.w - b.w) >= .00001f;
	public static bool operator !=(float4 a, int4 b) => math.abs(a.x - b.x) >= .00001f || math.abs(a.y - b.y) >= .00001f || math.abs(a.z - b.z) >= .00001f || math.abs(a.w - b.w) >= .00001f;

	public static bool operator >(int4 a, int4 b) => a.x > b.x && a.y > b.y && a.z > b.z && a.w > b.w;
	public static bool operator >(int4 a, int b) => a.x > b && a.y > b && a.z > b && a.w > b;
	public static bool operator >(int a, int4 b) => a > b.x && a > b.y && a > b.z && a > b.w;
	public static bool operator >(int4 a, float4 b) => a.x > b.x && a.y > b.y && a.z > b.z && a.w > b.w;
	public static bool operator >(float4 a, int4 b) => a.x > b.x && a.y > b.y && a.z > b.z && a.w > b.w;

	public static bool operator >=(int4 a, int4 b) => a.x >= b.x && a.y >= b.y && a.z >= b.z && a.w >= b.w;
	public static bool operator >=(int4 a, int b) => a.x >= b && a.y >= b && a.z >= b && a.w >= b;
	public static bool operator >=(int a, int4 b) => a >= b.x && a >= b.y && a >= b.z && a >= b.w;
	public static bool operator >=(int4 a, float4 b) => a.x >= b.x && a.y >= b.y && a.z >= b.z && a.w >= b.w;
	public static bool operator >=(float4 a, int4 b) => a.x >= b.x && a.y >= b.y && a.z >= b.z && a.w >= b.w;

	public static bool operator <(int4 a, int4 b) => a.x < b.x && a.y < b.y && a.z < b.z && a.w < b.w;
	public static bool operator <(int4 a, int b) => a.x < b && a.y < b && a.z < b && a.w < b;
	public static bool operator <(int a, int4 b) => a < b.x && a < b.y && a < b.z && a < b.w;
	public static bool operator <(int4 a, float4 b) => a.x < b.x && a.y < b.y && a.z < b.z && a.w < b.w;
	public static bool operator <(float4 a, int4 b) => a.x < b.x && a.y < b.y && a.z < b.z && a.w < b.w;

	public static bool operator <=(int4 a, int4 b) => a.x <= b.x && a.y <= b.y && a.z <= b.z && a.w <= b.w;
	public static bool operator <=(int4 a, int b) => a.x <= b && a.y <= b && a.z <= b && a.w <= b;
	public static bool operator <=(int a, int4 b) => a <= b.x && a <= b.y && a <= b.z && a <= b.w;
	public static bool operator <=(int4 a, float4 b) => a.x <= b.x && a.y <= b.y && a.z <= b.z && a.w <= b.w;
	public static bool operator <=(float4 a, int4 b) => a.x <= b.x && a.y <= b.y && a.z <= b.z && a.w <= b.w;


	// other operators
	public static int4 operator -(int4 a) => new(-a.x, -a.y, -a.z, -a.w);
	public static implicit operator int4(int v) => new(v);
	public static explicit operator int4(float v) => new((int)v);

	public int4(int2 a, int z, int w) {
		x = a.x;
		y = a.y;

		this.z = z;
		this.w = w;
	}

	public static implicit operator int2(int4 v) => v.xy;
	public static implicit operator int4(int2 v) => new(v.x, v.y);
	public int4(int3 a, int w) {
		x = a.x;
		y = a.y;
		z = a.z;

		this.w = w;
	}

	public static implicit operator int3(int4 v) => v.xyz;
	public static implicit operator int4(int3 v) => new(v.x, v.y, v.z);

#endregion operators

#region staticFunc

	public static int4 Min(int4 a, int4 b) => new(math.min(a.x, b.x), math.min(a.y, b.y), math.min(a.z, b.z), math.min(a.w, b.w));
	public static int4 Min(int4 a, int4 b, int4 c) => new(math.min(a.x, b.x, c.x), math.min(a.y, b.y, c.y), math.min(a.z, b.z, c.z), math.min(a.w, b.w, c.w));
	public static int4 Min(int4 a, int4 b, int4 c, int4 d) => new(math.min(a.x, b.x, c.x, d.x), math.min(a.y, b.y, c.y, d.y), math.min(a.z, b.z, c.z, d.z), math.min(a.w, b.w, c.w, d.w));

	public static int4 Max(int4 a, int4 b) => new(math.max(a.x, b.x), math.max(a.y, b.y), math.max(a.z, b.z), math.max(a.w, b.w));
	public static int4 Max(int4 a, int4 b, int4 c) => new(math.max(a.x, b.x, c.x), math.max(a.y, b.y, c.y), math.max(a.z, b.z, c.z), math.max(a.w, b.w, c.w));
	public static int4 Max(int4 a, int4 b, int4 c, int4 d) => new(math.max(a.x, b.x, c.x, d.x), math.max(a.y, b.y, c.y, d.y), math.max(a.z, b.z, c.z, d.z), math.max(a.w, b.w, c.w, d.w));

	public static int4 Clamp(int4 v, int4 min, int4 max) => Max(Min(v, max), min);

#endregion staticFunc

#region impl

	public bool Equals(int4 other) => x == other.x && y == other.y && z == other.z && w == other.w;
	public override bool Equals(object? obj) => obj is int4 other && Equals(other);
	public override int GetHashCode() => HashCode.Combine(x, y, z, w);

	public override string ToString() => $"({x},{y},{z},{w})";

#endregion impl

#region other

	public static float Dot(int4 a, int4 b) => (float)a.x * b.x + (float)a.y * b.y + (float)a.z * b.z + (float)a.w * b.w;

#endregion other

}